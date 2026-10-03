using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    // The Signal Desk domain model: the contract between the market feed, the trading engine, the
    // alerts and news wire, and every pane that renders their state.

    /// <summary>A single instrument as published by the market feed.</summary>
    public class FintechDockManagerQuote
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Sector { get; set; }

        /// <summary>Last traded price.</summary>
        public double LastPrice { get; set; }

        /// <summary>Best bid and ask around the last price.</summary>
        public double Bid { get; set; }
        public double Ask { get; set; }

        /// <summary>Yesterday's settlement: the anchor for every day-change figure.</summary>
        public double PreviousClose { get; set; }

        /// <summary>LastPrice minus PreviousClose, kept denormalised for grid sorting.</summary>
        public double Change { get; set; }
        public double ChangePct { get; set; }
        public string Currency { get; set; }
        public string MarketTime { get; set; }
        public double Volume { get; set; }
        public double AvgVol3M { get; set; }
        public double DayLow { get; set; }
        public double DayHigh { get; set; }
        public double Week52Low { get; set; }
        public double Week52High { get; set; }
        public double MarketCap { get; set; }
        public bool Positive { get; set; }

        public FintechDockManagerQuote Clone() => (FintechDockManagerQuote)MemberwiseClone();

        public void CopyFrom(FintechDockManagerQuote source)
        {
            Symbol = source.Symbol;
            Name = source.Name;
            Sector = source.Sector;
            LastPrice = source.LastPrice;
            Bid = source.Bid;
            Ask = source.Ask;
            PreviousClose = source.PreviousClose;
            Change = source.Change;
            ChangePct = source.ChangePct;
            Currency = source.Currency;
            MarketTime = source.MarketTime;
            Volume = source.Volume;
            AvgVol3M = source.AvgVol3M;
            DayLow = source.DayLow;
            DayHigh = source.DayHigh;
            Week52Low = source.Week52Low;
            Week52High = source.Week52High;
            MarketCap = source.MarketCap;
            Positive = source.Positive;
        }
    }

    /// <summary>A headline index shown in the command-bar ribbon.</summary>
    public class FintechDockManagerIndex
    {
        public string Name { get; set; }
        public double Value { get; set; }

        /// <summary>Yesterday's close, so ChangePct is always derivable rather than drifting.</summary>
        public double PreviousClose { get; set; }
        public double ChangePct { get; set; }
        public bool Positive { get; set; }

        public FintechDockManagerIndex Clone() => (FintechDockManagerIndex)MemberwiseClone();
    }

    /// <summary>The order vocabulary, spelled the way the ticket and the blotter show it.</summary>
    public static class FintechDockManagerOrderTerms
    {
        public const string Buy = "BUY";
        public const string Sell = "SELL";

        public const string Market = "Market";
        public const string Limit = "Limit";
        public const string Stop = "Stop";
        public const string StopLimit = "Stop Limit";
        public const string TrailingStop = "Trailing Stop";

        public const string Day = "Day";
        public const string Gtc = "GTC";
        public const string Ioc = "IOC";
        public const string Fok = "FOK";

        public const string Working = "Working";
        public const string Filled = "Filled";
        public const string Cancelled = "Cancelled";
        public const string Rejected = "Rejected";

        public static readonly string[] OrderTypes = { Market, Limit, Stop, StopLimit, TrailingStop };
        public static readonly string[] TimesInForce = { Day, Gtc, Ioc, Fok };

        /// <summary>Order types that rest on a limit price.</summary>
        public static bool NeedsLimitPrice(string type) => type == Limit || type == StopLimit;

        /// <summary>Order types that need a stop price or a trail amount.</summary>
        public static bool NeedsStopPrice(string type) => type == Stop || type == StopLimit || type == TrailingStop;
    }

    /// <summary>What the order ticket hands to the trading engine.</summary>
    public class FintechDockManagerOrderDraft
    {
        public string Symbol { get; set; }
        public string Side { get; set; }
        public double Quantity { get; set; }
        public string Type { get; set; }

        /// <summary>Required for Limit and Stop Limit.</summary>
        public double? LimitPrice { get; set; }

        /// <summary>Required for Stop, Stop Limit and Trailing Stop (as an offset).</summary>
        public double? StopPrice { get; set; }
        public string TimeInForce { get; set; }
    }

    /// <summary>A draft accepted by the engine, with its lifecycle state.</summary>
    public class FintechDockManagerOrder : FintechDockManagerOrderDraft
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public DateTime PlacedAt { get; set; }

        /// <summary>Populated once the order leaves Working.</summary>
        public DateTime? FilledAt { get; set; }
        public double? FillPrice { get; set; }

        /// <summary>Rejection reason, or the trigger that filled the order.</summary>
        public string Note { get; set; }

        /// <summary>Best price seen since submission: drives the trailing stop.</summary>
        public double? PeakPrice { get; set; }

        public FintechDockManagerOrder With(string status, string note)
        {
            var copy = (FintechDockManagerOrder)MemberwiseClone();
            copy.Status = status;
            copy.Note = note;
            return copy;
        }

        public FintechDockManagerOrder Clone() => (FintechDockManagerOrder)MemberwiseClone();
    }

    /// <summary>The engine's book: one aggregated lot per symbol.</summary>
    public class FintechDockManagerLot
    {
        public string Symbol { get; set; }
        public double Quantity { get; set; }
        public double AvgCost { get; set; }
    }

    /// <summary>A lot marked to the live market: everything the positions grid renders.</summary>
    public class FintechDockManagerPosition
    {
        public string Symbol { get; set; }
        public double Quantity { get; set; }
        public double AvgCost { get; set; }
        public string Name { get; set; }
        public double Last { get; set; }
        public double PreviousClose { get; set; }
        public double MarketValue { get; set; }
        public double DayChange { get; set; }
        public double DayChangePct { get; set; }
        public double OpenPl { get; set; }
        public double OpenPlPct { get; set; }

        /// <summary>Share of gross market value, 0 to 100.</summary>
        public double Weight { get; set; }
    }

    /// <summary>Aggregated account state for the command bar and the positions footer.</summary>
    public class FintechDockManagerAccount
    {
        public double Cash { get; set; }
        public double MarketValue { get; set; }
        public double NetLiquidation { get; set; }
        public double OpenPl { get; set; }
        public double DayPl { get; set; }
        public double RealizedPl { get; set; }
        public double BuyingPower { get; set; }

        /// <summary>Gross exposure as a share of net liquidation, 0 to 100.</summary>
        public double Utilisation { get; set; }
    }

    /// <summary>A desk notification: order fills, price alerts and risk warnings.</summary>
    public class FintechDockManagerAlert
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Icon { get; set; }

        /// <summary>success, warn, error or info.</summary>
        public string Tone { get; set; }
        public DateTime At { get; set; }
        public bool Read { get; set; }
    }

    /// <summary>A news wire item; Symbol ties it to an instrument when relevant.</summary>
    public class FintechDockManagerArticle
    {
        public string Id { get; set; }
        public string Headline { get; set; }
        public string Source { get; set; }
        public string Symbol { get; set; }
        public DateTime At { get; set; }
    }

    /// <summary>Outcome of a ticket submission. Reason is set only when rejected.</summary>
    public class FintechDockManagerOrderResult
    {
        public bool Accepted { get; set; }
        public string Reason { get; set; }
        public FintechDockManagerOrder Order { get; set; }
    }

    /// <summary>One candle of a chart's price history.</summary>
    public class FintechDockManagerCandle
    {
        /// <summary>Milliseconds since the Unix epoch.</summary>
        public double Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }

        public FintechDockManagerCandle Clone() => (FintechDockManagerCandle)MemberwiseClone();
    }
}
