using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Samples
{
    /// <summary>One segment of the ticket's quick-size group.</summary>
    public class FintechDockManagerQuickSize
    {
        public string Label { get; set; }
        public double Quantity { get; set; }
        public bool Disabled { get; set; }

        /// <summary>Only Max needs saying: its size is not on its face.</summary>
        public string Hint { get; set; }
    }

    /// <summary>
    /// The order ticket's form and every rule it applies: which price fields the order type uses, what
    /// is valid, the price the order works against, the estimate and the largest size the account can
    /// carry. The ticket's fields write their text here as the trader types; the tick-driven parts of
    /// the ticket (the price ladder, the quick sizes, the estimate) read it, and re-render on Changed.
    /// </summary>
    public class FintechDockManagerTicketModel
    {
        public static readonly double[] QuickQuantities = { 25, 50, 100, 500 };

        public const string QuantityField = "quantity";
        public const string LimitField = "limit";
        public const string StopField = "stop";

        /// <summary>Any change to the form: the estimate, the quick sizes and the submit state follow it.</summary>
        public event Action Changed;

        /// <summary>
        /// A field's text set by the desk rather than typed (a quick size, the Bid or Ask, a new
        /// symbol): only then does the field hand its input a new value.
        /// </summary>
        public event Action<string> FieldAssigned;

        public string QuantityText { get; private set; } = "100";
        public string Type { get; private set; } = FintechDockManagerOrderTerms.Limit;
        public string LimitText { get; private set; } = "";
        public string StopText { get; private set; } = "";
        public string TimeInForce { get; private set; } = FintechDockManagerOrderTerms.Day;

        /// <summary>The engine's rejection, cleared as soon as the ticket is edited.</summary>
        public string Rejection { get; private set; }

        public double? Quantity => FintechDockManagerFormat.ParseInput(QuantityText);
        public double? LimitPrice => FintechDockManagerFormat.ParseInput(LimitText);
        public double? StopPrice => FintechDockManagerFormat.ParseInput(StopText);

        public bool NeedsLimitPrice => FintechDockManagerOrderTerms.NeedsLimitPrice(Type);
        public bool NeedsStopPrice => FintechDockManagerOrderTerms.NeedsStopPrice(Type);
        public bool IsTrailing => Type == FintechDockManagerOrderTerms.TrailingStop;

        /// <summary>
        /// The form's own validation: a quantity of at least 1 is required; the price fields the order
        /// type uses must be at least 0.01 when they are filled in (an empty one is the engine's to
        /// reject, with a reason).
        /// </summary>
        public bool IsValid
        {
            get
            {
                var quantity = Quantity;
                if (quantity == null || quantity < 1)
                {
                    return false;
                }

                if (NeedsLimitPrice && LimitPrice.HasValue && LimitPrice < 0.01)
                {
                    return false;
                }

                if (NeedsStopPrice && StopPrice.HasValue && StopPrice < 0.01)
                {
                    return false;
                }

                return true;
            }
        }

        public string TextOf(string field) => field == QuantityField ? QuantityText : field == LimitField ? LimitText : StopText;

        /// <summary>Text the trader typed: the model follows the field.</summary>
        public void Typed(string field, string text) => Edit(() => Write(field, text ?? ""));

        /// <summary>Text the desk chose: the field follows the model.</summary>
        public void Assign(string field, string text)
        {
            Edit(() => Write(field, text ?? ""));
            FieldAssigned?.Invoke(field);
        }

        public void SetQuantity(double quantity) => Assign(QuantityField, FintechDockManagerFormat.InputNumber(quantity));

        /// <summary>Clicking the bid or the ask pulls that price into the limit field.</summary>
        public void UsePrice(double price)
        {
            if (NeedsLimitPrice)
            {
                Assign(LimitField, FintechDockManagerFormat.InputNumber(price));
            }
        }

        public void SetType(string type)
        {
            if (FintechDockManagerOrderTerms.OrderTypes.Contains(type))
            {
                Edit(() => Type = type);
            }
        }

        public void SetTimeInForce(string tif)
        {
            if (FintechDockManagerOrderTerms.TimesInForce.Contains(tif))
            {
                Edit(() => TimeInForce = tif);
            }
        }

        /// <summary>
        /// Following the selected symbol re-seeds the price fields: a limit left over from the previous
        /// instrument would be nonsense.
        /// </summary>
        public void SeedFor(FintechDockManagerQuote quote)
        {
            LimitText = quote != null ? FintechDockManagerFormat.InputNumber(quote.LastPrice) : "";
            StopText = "";
            Rejection = null;
            Changed?.Invoke();
            FieldAssigned?.Invoke(LimitField);
            FieldAssigned?.Invoke(StopField);
        }

        public void Reject(string reason)
        {
            Rejection = reason;
            Changed?.Invoke();
        }

        /// <summary>The price this order would work against right now.</summary>
        public double? ReferencePrice(FintechDockManagerQuote quote, string side)
        {
            if (quote == null)
            {
                return null;
            }

            var limit = LimitPrice;
            if (NeedsLimitPrice && limit.HasValue && limit.Value != 0)
            {
                return limit;
            }

            return side == FintechDockManagerOrderTerms.Buy ? quote.Ask : quote.Bid;
        }

        public (double Notional, double Commission, double Total) Estimate(FintechDockManagerQuote quote, string side)
        {
            var quantity = Quantity ?? 0;
            var price = ReferencePrice(quote, side) ?? 0;
            var notional = FintechDockManagerFormat.Round2(quantity * price);
            var commission = quantity > 0 ? FintechDockManagerTrading.CommissionFor(quantity) : 0;
            return (notional, commission, FintechDockManagerFormat.Round2(notional + commission));
        }

        /// <summary>Largest size the account can support for the side; commission is priced in, so Max is always accepted.</summary>
        public double MaxQuantity(FintechDockManagerDesk desk, FintechDockManagerQuote quote, string side)
        {
            if (side == FintechDockManagerOrderTerms.Sell)
            {
                return desk.Trading.QuantityHeld(desk.SelectedSymbol);
            }

            var price = ReferencePrice(quote, side);
            return price > 0 ? Math.Floor(desk.Trading.BuyingPower / (price.Value + FintechDockManagerTrading.CommissionPerShare)) : 0;
        }

        /// <summary>The quick sizes, in the order the group renders them; Max is last, so the fixed sizes keep their places.</summary>
        public List<FintechDockManagerQuickSize> QuickSizes(double max)
        {
            var sizes = QuickQuantities
                .Select(quantity => new FintechDockManagerQuickSize { Label = FintechDockManagerFormat.InputNumber(quantity), Quantity = quantity })
                .ToList();
            sizes.Add(new FintechDockManagerQuickSize
            {
                Label = "Max",
                Quantity = max,
                Disabled = max < 1,
                Hint = "Maximum size for this side: " + FintechDockManagerFormat.InputNumber(max),
            });
            return sizes;
        }

        /// <summary>
        /// Which quick size the field holds, or -1 for none (a hand-typed size lights none). First match
        /// wins, so Max landing on a fixed size exactly leaves the fixed one lit.
        /// </summary>
        public int SelectedQuickSize(List<FintechDockManagerQuickSize> sizes)
        {
            var quantity = Quantity ?? 0;
            return sizes.FindIndex(size => !size.Disabled && size.Quantity == quantity);
        }

        public FintechDockManagerOrderDraft ToDraft(string symbol, string side) => new FintechDockManagerOrderDraft
        {
            Symbol = symbol,
            Side = side,
            Quantity = Quantity ?? double.NaN,
            Type = Type,
            LimitPrice = NeedsLimitPrice ? LimitPrice : null,
            StopPrice = NeedsStopPrice ? StopPrice : null,
            TimeInForce = TimeInForce,
        };

        private void Write(string field, string text)
        {
            if (field == QuantityField)
            {
                QuantityText = text;
            }
            else if (field == LimitField)
            {
                LimitText = text;
            }
            else
            {
                StopText = text;
            }
        }

        // Any edit clears the rejection.
        private void Edit(Action change)
        {
            change();
            Rejection = null;
            Changed?.Invoke();
        }
    }
}
