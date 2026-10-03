using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    // The records bound to the three grids (IgbGrid.Data). They carry every figure the JavaScript cell
    // templates show, with the desk's rules already applied: the range markers' positions, the
    // blotter's display price and badge variant. The same types are serialized for the live patch
    // (events.js, fintechDockManagerApplyTick), so a patched record is the same shape as a bound one.

    /// <summary>One watchlist row: a quote joined against the live feed.</summary>
    public class FintechDockManagerWatchRow
    {
        public string Symbol { get; set; }
        public double LastPrice { get; set; }
        public double ChangePct { get; set; }
        public double Change { get; set; }
        public double Bid { get; set; }
        public double Ask { get; set; }
        public string Sector { get; set; }
        public string MarketTime { get; set; }
        public double Volume { get; set; }
        public double AvgVol3M { get; set; }
        public double DayLow { get; set; }
        public double DayHigh { get; set; }
        public double Week52Low { get; set; }
        public double Week52High { get; set; }
        public double MarketCap { get; set; }
        public bool Positive { get; set; }

        /// <summary>Where the last price sits in the day's range, 0 to 100 (the Day Range marker).</summary>
        public double DayRangePosition { get; set; }

        /// <summary>Where the last price sits in the 52-week range, 0 to 100.</summary>
        public double Week52RangePosition { get; set; }

        public static FintechDockManagerWatchRow From(FintechDockManagerQuote quote) => new FintechDockManagerWatchRow
        {
            Symbol = quote.Symbol,
            LastPrice = quote.LastPrice,
            ChangePct = quote.ChangePct,
            Change = quote.Change,
            Bid = quote.Bid,
            Ask = quote.Ask,
            Sector = quote.Sector,
            MarketTime = quote.MarketTime,
            Volume = quote.Volume,
            AvgVol3M = quote.AvgVol3M,
            DayLow = quote.DayLow,
            DayHigh = quote.DayHigh,
            Week52Low = quote.Week52Low,
            Week52High = quote.Week52High,
            MarketCap = quote.MarketCap,
            Positive = quote.Positive,
            DayRangePosition = FintechDockManagerFormat.RangePosition(quote.LastPrice, quote.DayLow, quote.DayHigh),
            Week52RangePosition = FintechDockManagerFormat.RangePosition(quote.LastPrice, quote.Week52Low, quote.Week52High),
        };
    }

    /// <summary>One positions row: a lot marked to the live market.</summary>
    public class FintechDockManagerPositionRow
    {
        public string Symbol { get; set; }
        public double Quantity { get; set; }
        public double AvgCost { get; set; }
        public double Last { get; set; }
        public double MarketValue { get; set; }
        public double DayChange { get; set; }
        public double DayChangePct { get; set; }
        public double OpenPl { get; set; }
        public double OpenPlPct { get; set; }
        public double Weight { get; set; }

        public static FintechDockManagerPositionRow From(FintechDockManagerPosition position) => new FintechDockManagerPositionRow
        {
            Symbol = position.Symbol,
            Quantity = position.Quantity,
            AvgCost = position.AvgCost,
            Last = position.Last,
            MarketValue = position.MarketValue,
            DayChange = position.DayChange,
            DayChangePct = position.DayChangePct,
            OpenPl = position.OpenPl,
            OpenPlPct = position.OpenPlPct,
            Weight = position.Weight,
        };
    }

    /// <summary>One blotter row: an order plus the single price the blotter shows for it.</summary>
    public class FintechDockManagerOrderRow
    {
        public string Id { get; set; }

        /// <summary>When the order was placed, in milliseconds since the Unix epoch (sorts as a time).</summary>
        public double PlacedAt { get; set; }
        public string Symbol { get; set; }
        public string Side { get; set; }
        public double Quantity { get; set; }
        public string Type { get; set; }

        /// <summary>Fill price once filled, otherwise the resting limit or stop; null for a market order.</summary>
        public double? DisplayPrice { get; set; }

        /// <summary>Fill, Limit, Stop, Trail or Mkt.</summary>
        public string PriceKind { get; set; }
        public string TimeInForce { get; set; }
        public string Status { get; set; }

        /// <summary>The status badge's igc-badge variant: warning, success, danger or primary.</summary>
        public string StatusVariant { get; set; }
        public string Note { get; set; }

        public static FintechDockManagerOrderRow From(FintechDockManagerOrder order)
        {
            double? price;
            string kind;
            if (order.Status == FintechDockManagerOrderTerms.Filled)
            {
                price = order.FillPrice;
                kind = "Fill";
            }
            else if (order.Type == FintechDockManagerOrderTerms.Market)
            {
                price = null;
                kind = "Mkt";
            }
            else if (order.Type == FintechDockManagerOrderTerms.Limit)
            {
                price = order.LimitPrice;
                kind = "Limit";
            }
            else if (order.Type == FintechDockManagerOrderTerms.TrailingStop)
            {
                price = order.StopPrice;
                kind = "Trail";
            }
            else
            {
                price = order.StopPrice ?? order.LimitPrice;
                kind = "Stop";
            }

            return new FintechDockManagerOrderRow
            {
                Id = order.Id,
                PlacedAt = (order.PlacedAt - DateTime.UnixEpoch).TotalMilliseconds,
                Symbol = order.Symbol,
                Side = order.Side,
                Quantity = order.Quantity,
                Type = order.Type,
                DisplayPrice = price,
                PriceKind = kind,
                TimeInForce = order.TimeInForce,
                Status = order.Status,
                StatusVariant = VariantOf(order.Status),
                Note = order.Note,
            };
        }

        /// <summary>Order status to badge colour.</summary>
        private static string VariantOf(string status)
        {
            switch (status)
            {
                case FintechDockManagerOrderTerms.Working:
                    return "warning";
                case FintechDockManagerOrderTerms.Filled:
                    return "success";
                case FintechDockManagerOrderTerms.Rejected:
                    return "danger";
                default:
                    return "primary";
            }
        }
    }

    /// <summary>One entry of the add-symbol picker: the whole universe, each flagged when already watched.</summary>
    public class FintechDockManagerSymbolOption
    {
        public string Symbol { get; set; }
        public bool Added { get; set; }
    }
}
