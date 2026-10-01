using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Samples
{
    /// <summary>
    /// The trading engine: accepts drafts from the order ticket, keeps working orders alive against
    /// the live feed, and books fills into the position lots and the cash balance that every P and L
    /// figure on the desk derives from.
    /// </summary>
    public class FintechDockManagerTrading
    {
        public const double CommissionPerShare = 0.005;
        public const double MinCommission = 1;

        /// <summary>Reg-T style margin: cash buys twice its value in stock.</summary>
        public const double MarginMultiplier = 2;

        private readonly FintechDockManagerMarket market;
        private readonly FintechDockManagerNotifications notifications;

        private List<FintechDockManagerLot> lots = FintechDockManagerSeed.OpeningLots();
        private int sequence;

        public FintechDockManagerTrading(FintechDockManagerMarket market, FintechDockManagerNotifications notifications)
        {
            this.market = market;
            this.notifications = notifications;
            RebuildPositions();
        }

        /// <summary>Newest first: the blotter renders this directly.</summary>
        public List<FintechDockManagerOrder> Orders { get; private set; } = new List<FintechDockManagerOrder>();

        public double Cash { get; private set; } = FintechDockManagerSeed.OpeningCash;

        public double RealizedPl { get; private set; }

        /// <summary>
        /// The book marked to the live market. The list is rebuilt only when the lots change (a fill,
        /// not a tick); every tick marks these rows in place.
        /// </summary>
        public List<FintechDockManagerPosition> Positions { get; private set; }

        /// <summary>Bumped whenever the lots change, so the positions grid knows to take a new list.</summary>
        public int BookVersion { get; private set; }

        /// <summary>Bumped whenever the order list changes, so the blotter knows to take a new list.</summary>
        public int OrdersVersion { get; private set; }

        public IEnumerable<FintechDockManagerOrder> WorkingOrders => Orders.Where(order => order.Status == FintechDockManagerOrderTerms.Working);

        public int WorkingCount => Orders.Count(order => order.Status == FintechDockManagerOrderTerms.Working);

        /// <summary>Broker commission for a given size. Surfaced so the ticket can preview it.</summary>
        public static double CommissionFor(double quantity) => FintechDockManagerFormat.Round2(Math.Max(MinCommission, quantity * CommissionPerShare));

        /// <summary>Cash committed to unfilled buy orders, held back from buying power.</summary>
        private double ReservedCash => FintechDockManagerFormat.Round2(WorkingOrders
            .Where(order => order.Side == FintechDockManagerOrderTerms.Buy)
            .Sum(order => order.Quantity * (order.LimitPrice ?? order.StopPrice ?? 0)));

        public double BuyingPower => FintechDockManagerFormat.Round2(Math.Max(0, Cash - ReservedCash) * MarginMultiplier);

        public FintechDockManagerAccount Account
        {
            get
            {
                var marketValue = FintechDockManagerFormat.Round2(Positions.Sum(position => position.MarketValue));
                var openPl = FintechDockManagerFormat.Round2(Positions.Sum(position => position.OpenPl));
                var dayPl = FintechDockManagerFormat.Round2(Positions.Sum(position => position.DayChange) + RealizedPl);
                var netLiquidation = FintechDockManagerFormat.Round2(Cash + marketValue);

                return new FintechDockManagerAccount
                {
                    Cash = Cash,
                    MarketValue = marketValue,
                    NetLiquidation = netLiquidation,
                    OpenPl = openPl,
                    DayPl = dayPl,
                    RealizedPl = RealizedPl,
                    BuyingPower = BuyingPower,
                    Utilisation = netLiquidation == 0 ? 0 : FintechDockManagerFormat.Round2(marketValue / netLiquidation * 100),
                };
            }
        }

        public double QuantityHeld(string symbol) => lots.FirstOrDefault(lot => lot.Symbol == symbol)?.Quantity ?? 0;

        /// <summary>One pass per price tick: re-mark the book, then re-evaluate the working orders.</summary>
        public void OnTick()
        {
            MarkPositions(Positions, market.Quotes);
            MatchWorkingOrders();
        }

        public FintechDockManagerOrderResult SubmitOrder(FintechDockManagerOrderDraft draft, DateTime now)
        {
            var quote = market.QuoteOf(draft.Symbol);
            var rejection = Validate(draft, quote);
            sequence++;
            var order = new FintechDockManagerOrder
            {
                Symbol = draft.Symbol,
                Side = draft.Side,
                Quantity = draft.Quantity,
                Type = draft.Type,
                LimitPrice = draft.LimitPrice,
                StopPrice = draft.StopPrice,
                TimeInForce = draft.TimeInForce,
                Id = "ORD-" + sequence.ToString("D4"),
                Status = rejection != null ? FintechDockManagerOrderTerms.Rejected : FintechDockManagerOrderTerms.Working,
                PlacedAt = now,
                Note = rejection ?? "",
                PeakPrice = draft.Type == FintechDockManagerOrderTerms.TrailingStop ? quote?.LastPrice : null,
            };

            SetOrders(new[] { order }.Concat(Orders).ToList());

            if (rejection != null)
            {
                notifications.Push("Order rejected \u2014 " + order.Symbol, rejection, "block", "error");
                return new FintechDockManagerOrderResult { Accepted = false, Reason = rejection, Order = order };
            }

            // Market orders (and any resting order already through its trigger) fill on this pass
            // rather than waiting for the next tick.
            MatchWorkingOrders();
            ExpireImmediateOrder(order.Id);

            // The settled state, so the ticket can say "filled" rather than "working".
            var settled = Orders.FirstOrDefault(entry => entry.Id == order.Id) ?? order;
            return new FintechDockManagerOrderResult { Accepted = true, Reason = null, Order = settled };
        }

        /// <summary>Returns the book to its opening state: seeded lots, opening cash, no realised P and L, an empty blotter.</summary>
        public void Reset()
        {
            lots = FintechDockManagerSeed.OpeningLots();
            SetOrders(new List<FintechDockManagerOrder>());
            Cash = FintechDockManagerSeed.OpeningCash;
            RealizedPl = 0;
            sequence = 0;
            RebuildPositions();
        }

        public void CancelOrder(string id)
        {
            if (!Orders.Any(order => order.Id == id && order.Status == FintechDockManagerOrderTerms.Working))
            {
                return;
            }

            SetOrders(Orders.Select(order => order.Id == id && order.Status == FintechDockManagerOrderTerms.Working
                ? order.With(FintechDockManagerOrderTerms.Cancelled, "Cancelled by user")
                : order).ToList());
        }

        public void CancelAllWorking()
        {
            var count = WorkingCount;
            if (count == 0)
            {
                return;
            }

            SetOrders(Orders.Select(order => order.Status == FintechDockManagerOrderTerms.Working
                ? order.With(FintechDockManagerOrderTerms.Cancelled, "Cancelled by user")
                : order).ToList());

            notifications.Push("Working orders cancelled", count + " order" + (count == 1 ? "" : "s") + " pulled from the market", "cancel", "info");
        }

        /// <summary>Sells the whole position at market.</summary>
        public FintechDockManagerOrderResult Flatten(string symbol, DateTime now)
        {
            var quantity = QuantityHeld(symbol);
            if (quantity <= 0)
            {
                return null;
            }

            return SubmitOrder(new FintechDockManagerOrderDraft
            {
                Symbol = symbol,
                Side = FintechDockManagerOrderTerms.Sell,
                Quantity = quantity,
                Type = FintechDockManagerOrderTerms.Market,
                LimitPrice = null,
                StopPrice = null,
                TimeInForce = FintechDockManagerOrderTerms.Day,
            }, now);
        }

        private void SetOrders(List<FintechDockManagerOrder> next)
        {
            Orders = next;
            OrdersVersion++;
        }

        private void SetLots(List<FintechDockManagerLot> next)
        {
            lots = next;
            RebuildPositions();
        }

        private void RebuildPositions()
        {
            Positions = lots.Select(BlankPosition).ToList();
            MarkPositions(Positions, market.Quotes);
            BookVersion++;
        }

        // Validation ------------------------------------------------------------------------------

        private string Validate(FintechDockManagerOrderDraft draft, FintechDockManagerQuote quote)
        {
            if (quote == null)
            {
                return draft.Symbol + " is not tradable on this desk";
            }

            if (double.IsNaN(draft.Quantity) || draft.Quantity != Math.Floor(draft.Quantity) || draft.Quantity < 1)
            {
                return "Quantity must be a whole number of shares";
            }

            if (FintechDockManagerOrderTerms.NeedsLimitPrice(draft.Type) && !(draft.LimitPrice > 0))
            {
                return draft.Type + " orders require a limit price";
            }

            if (draft.Type != FintechDockManagerOrderTerms.Market && draft.Type != FintechDockManagerOrderTerms.Limit && !(draft.StopPrice > 0))
            {
                return draft.Type == FintechDockManagerOrderTerms.TrailingStop
                    ? "Trailing stop orders require a trail amount"
                    : draft.Type + " orders require a stop price";
            }

            if (draft.Side == FintechDockManagerOrderTerms.Buy)
            {
                var reference = draft.LimitPrice ?? quote.Ask;
                var required = FintechDockManagerFormat.Round2(draft.Quantity * reference + CommissionFor(draft.Quantity));
                var buyingPower = BuyingPower;
                if (required > buyingPower)
                {
                    return "Needs " + FintechDockManagerFormat.Money(required) + " \u2014 buying power is " + FintechDockManagerFormat.Money(buyingPower);
                }

                return null;
            }

            var held = QuantityHeld(draft.Symbol);
            if (draft.Quantity > held)
            {
                return held == 0
                    ? "No " + draft.Symbol + " position to sell \u2014 short selling is disabled"
                    : "Only " + held + " " + draft.Symbol + " share" + (held == 1 ? "" : "s") + " held";
            }

            return null;
        }

        /// <summary>IOC and FOK orders do not rest: pull them if the first pass missed.</summary>
        private void ExpireImmediateOrder(string id)
        {
            var order = Orders.FirstOrDefault(entry => entry.Id == id);
            if (order == null || order.Status != FintechDockManagerOrderTerms.Working ||
                (order.TimeInForce != FintechDockManagerOrderTerms.Ioc && order.TimeInForce != FintechDockManagerOrderTerms.Fok))
            {
                return;
            }

            SetOrders(Orders.Select(entry => entry.Id == id
                ? entry.With(FintechDockManagerOrderTerms.Cancelled, "Not filled immediately (" + order.TimeInForce + ")")
                : entry).ToList());
        }

        // Matching engine -------------------------------------------------------------------------

        private void MatchWorkingOrders()
        {
            if (!Orders.Any(order => order.Status == FintechDockManagerOrderTerms.Working))
            {
                return;
            }

            var fills = new List<FintechDockManagerOrder>();
            var changed = false;
            var next = Orders.Select(order =>
            {
                if (order.Status != FintechDockManagerOrderTerms.Working)
                {
                    return order;
                }

                var quote = market.QuoteOf(order.Symbol);
                if (quote == null)
                {
                    return order;
                }

                // PeakPrice is internal tracking state, never rendered, so it is written in place:
                // replacing the list on every tick would re-render the blotter for the whole life of
                // a trailing order.
                TrackTrailingExtreme(order, quote);

                var fillPrice = ResolveFillPrice(order, quote);
                if (fillPrice == null)
                {
                    return order;
                }

                var filled = order.With(FintechDockManagerOrderTerms.Filled, order.Type + " filled at " + FintechDockManagerFormat.Money(fillPrice.Value));
                filled.FilledAt = DateTime.UtcNow;
                filled.FillPrice = fillPrice;
                fills.Add(filled);
                changed = true;
                return filled;
            }).ToList();

            if (!changed)
            {
                return;
            }

            SetOrders(next);
            foreach (var order in fills)
            {
                Settle(order);
            }
        }

        private void Settle(FintechDockManagerOrder order)
        {
            var price = order.FillPrice ?? 0;
            var commission = CommissionFor(order.Quantity);
            var notional = FintechDockManagerFormat.Round2(order.Quantity * price);

            if (order.Side == FintechDockManagerOrderTerms.Buy)
            {
                Cash = FintechDockManagerFormat.Round2(Cash - notional - commission);
                SetLots(AddToLot(lots, order.Symbol, order.Quantity, price));
            }
            else
            {
                var avgCost = lots.FirstOrDefault(lot => lot.Symbol == order.Symbol)?.AvgCost ?? price;
                Cash = FintechDockManagerFormat.Round2(Cash + notional - commission);
                RealizedPl = FintechDockManagerFormat.Round2(RealizedPl + (price - avgCost) * order.Quantity - commission);
                SetLots(ReduceLot(lots, order.Symbol, order.Quantity));
            }

            notifications.Push(
                order.Side + " " + order.Quantity + " " + order.Symbol + " filled",
                order.Type + " at " + FintechDockManagerFormat.Money(price) + " \u00B7 commission " + FintechDockManagerFormat.Money(commission),
                "receipt_long",
                "success");
        }

        // Pure engine helpers ---------------------------------------------------------------------

        /// <summary>An unmarked row for a lot; MarkPositions fills in the live figures.</summary>
        private static FintechDockManagerPosition BlankPosition(FintechDockManagerLot lot) => new FintechDockManagerPosition
        {
            Symbol = lot.Symbol,
            Quantity = lot.Quantity,
            AvgCost = lot.AvgCost,
            Name = lot.Symbol,
            Last = lot.AvgCost,
            PreviousClose = lot.AvgCost,
        };

        /// <summary>Marks rows to the live market in place.</summary>
        private static void MarkPositions(IReadOnlyList<FintechDockManagerPosition> rows, IReadOnlyDictionary<string, FintechDockManagerQuote> quotes)
        {
            double gross = 0;
            foreach (var row in rows)
            {
                quotes.TryGetValue(row.Symbol, out var quote);
                var last = quote?.LastPrice ?? row.AvgCost;
                var previousClose = quote?.PreviousClose ?? row.AvgCost;

                row.Name = quote?.Name ?? row.Symbol;
                row.Last = last;
                row.PreviousClose = previousClose;
                row.MarketValue = FintechDockManagerFormat.Round2(last * row.Quantity);
                row.DayChange = FintechDockManagerFormat.Round2((last - previousClose) * row.Quantity);
                row.DayChangePct = FintechDockManagerFormat.Round2(FintechDockManagerFormat.PercentChange(last, previousClose));
                row.OpenPl = FintechDockManagerFormat.Round2((last - row.AvgCost) * row.Quantity);
                row.OpenPlPct = FintechDockManagerFormat.Round2(FintechDockManagerFormat.PercentChange(last, row.AvgCost));
                gross += Math.Abs(row.MarketValue);
            }

            foreach (var row in rows)
            {
                row.Weight = gross == 0 ? 0 : FintechDockManagerFormat.Round2(Math.Abs(row.MarketValue) / gross * 100);
            }
        }

        private static List<FintechDockManagerLot> AddToLot(List<FintechDockManagerLot> current, string symbol, double quantity, double price)
        {
            var existing = current.FirstOrDefault(lot => lot.Symbol == symbol);
            if (existing == null)
            {
                return current.Concat(new[] { new FintechDockManagerLot { Symbol = symbol, Quantity = quantity, AvgCost = FintechDockManagerFormat.Round2(price) } }).ToList();
            }

            var total = existing.Quantity + quantity;
            var avgCost = FintechDockManagerFormat.Round2((existing.AvgCost * existing.Quantity + price * quantity) / total);
            return current.Select(lot => lot.Symbol == symbol ? new FintechDockManagerLot { Symbol = symbol, Quantity = total, AvgCost = avgCost } : lot).ToList();
        }

        private static List<FintechDockManagerLot> ReduceLot(List<FintechDockManagerLot> current, string symbol, double quantity) => current
            .Select(lot => lot.Symbol == symbol ? new FintechDockManagerLot { Symbol = symbol, Quantity = lot.Quantity - quantity, AvgCost = lot.AvgCost } : lot)
            .Where(lot => lot.Quantity > 0)
            .ToList();

        /// <summary>Advances the high-water (or low-water) mark a trailing stop is measured from.</summary>
        private static void TrackTrailingExtreme(FintechDockManagerOrder order, FintechDockManagerQuote quote)
        {
            if (order.Type != FintechDockManagerOrderTerms.TrailingStop)
            {
                return;
            }

            var current = order.PeakPrice ?? quote.LastPrice;
            order.PeakPrice = order.Side == FintechDockManagerOrderTerms.Sell
                ? Math.Max(current, quote.LastPrice)
                : Math.Min(current, quote.LastPrice);
        }

        /// <summary>The price this order would fill at right now, or null if it stays working.</summary>
        private static double? ResolveFillPrice(FintechDockManagerOrder order, FintechDockManagerQuote quote)
        {
            var buying = order.Side == FintechDockManagerOrderTerms.Buy;
            var aggressive = buying ? quote.Ask : quote.Bid;

            switch (order.Type)
            {
                case FintechDockManagerOrderTerms.Market:
                    return aggressive;
                case FintechDockManagerOrderTerms.Limit:
                    return CrossesLimit(order.LimitPrice, aggressive, buying);
                case FintechDockManagerOrderTerms.Stop:
                    return IsTriggered(order.StopPrice, quote.LastPrice, buying) ? aggressive : null;
                case FintechDockManagerOrderTerms.StopLimit:
                    return IsTriggered(order.StopPrice, quote.LastPrice, buying) ? CrossesLimit(order.LimitPrice, aggressive, buying) : null;
                case FintechDockManagerOrderTerms.TrailingStop:
                    if (order.StopPrice == null || order.PeakPrice == null)
                    {
                        return null;
                    }

                    var trigger = buying ? order.PeakPrice.Value + order.StopPrice.Value : order.PeakPrice.Value - order.StopPrice.Value;
                    return IsTriggered(trigger, quote.LastPrice, buying) ? aggressive : null;
                default:
                    return null;
            }
        }

        private static double? CrossesLimit(double? limit, double aggressive, bool buying)
        {
            if (limit == null)
            {
                return null;
            }

            if (buying)
            {
                return aggressive <= limit.Value ? Math.Min(aggressive, limit.Value) : null;
            }

            return aggressive >= limit.Value ? Math.Max(aggressive, limit.Value) : null;
        }

        /// <summary>A stop is hit when the market trades up through it (buy) or down through it (sell).</summary>
        private static bool IsTriggered(double? stop, double last, bool buying)
        {
            if (stop == null)
            {
                return false;
            }

            return buying ? last >= stop.Value : last <= stop.Value;
        }
    }
}
