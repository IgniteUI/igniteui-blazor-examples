using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Samples
{
    /// <summary>A feed speed the command bar offers.</summary>
    public class FintechDockManagerFeedSpeed
    {
        public string Label { get; set; }

        /// <summary>Milliseconds per tick.</summary>
        public int Milliseconds { get; set; }
    }

    /// <summary>
    /// The market feed: one source of truth for prices. The Angular sample opens a connection to the
    /// public Infragistics stream hub and only reports its state (the prices always come from the
    /// local simulator); this port has no hub client, so the feed is the simulator alone and says so:
    /// its status is simulated, or paused.
    ///
    /// The universe is a stable list of mutable quotes: a tick writes prices in place, and the grids
    /// get only the changed rows through one JavaScript patch.
    /// </summary>
    public class FintechDockManagerMarket
    {
        public const string StatusSimulated = "simulated";
        public const string StatusPaused = "paused";

        public const int DefaultFrequency = 1000;

        /// <summary>Percentage move applied to a stock on a single tick, at most.</summary>
        public const double StockVolatility = 0.4;
        public const double IndexVolatility = 0.06;

        /// <summary>Share of the universe that re-prices on any given tick.</summary>
        public const double TickCoverage = 0.35;

        public static readonly IReadOnlyList<FintechDockManagerFeedSpeed> Speeds = new[]
        {
            new FintechDockManagerFeedSpeed { Label = "0.5\u00D7", Milliseconds = 2000 },
            new FintechDockManagerFeedSpeed { Label = "1\u00D7", Milliseconds = DefaultFrequency },
            new FintechDockManagerFeedSpeed { Label = "2\u00D7", Milliseconds = 500 },
            new FintechDockManagerFeedSpeed { Label = "5\u00D7", Milliseconds = 200 },
        };

        private readonly Random random = new Random();

        public FintechDockManagerMarket()
        {
            Stocks = FintechDockManagerSeed.Stocks.Select(stock => stock.Clone()).ToList();
            Quotes = Stocks.ToDictionary(stock => stock.Symbol);
            Indices = FintechDockManagerSeed.Indices.ToList();
        }

        /// <summary>The tradable universe. The list and its objects are reused for the whole session.</summary>
        public IReadOnlyList<FintechDockManagerQuote> Stocks { get; }

        public IReadOnlyDictionary<string, FintechDockManagerQuote> Quotes { get; }

        /// <summary>The indices feed the command bar, not a grid, so each tick replaces them.</summary>
        public IReadOnlyList<FintechDockManagerIndex> Indices { get; private set; }

        public string Status { get; private set; } = StatusSimulated;

        public int Frequency { get; private set; } = DefaultFrequency;

        public bool IsPaused => Status == StatusPaused;

        /// <summary>Incremented after every re-pricing pass.</summary>
        public int Tick { get; private set; }

        public FintechDockManagerQuote QuoteOf(string symbol) => symbol != null && Quotes.TryGetValue(symbol, out var quote) ? quote : null;

        /// <summary>Freezes the tape.</summary>
        public void Pause() => Status = StatusPaused;

        public void Resume() => Status = StatusSimulated;

        public void TogglePlayback()
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        public void SetFrequency(int milliseconds) => Frequency = milliseconds;

        /// <summary>
        /// Puts the tape back to its opening state: seed prices, seed indices, default speed, running.
        /// Quotes are rewritten in place, so the grids keep their row objects through a reset too.
        /// </summary>
        public void Reset()
        {
            foreach (var stock in Stocks)
            {
                var seed = FintechDockManagerSeed.FindStock(stock.Symbol);
                if (seed != null)
                {
                    stock.CopyFrom(seed);
                }
            }

            Indices = FintechDockManagerSeed.Indices.ToList();
            Frequency = DefaultFrequency;
            Status = StatusSimulated;
            Tick++;
        }

        /// <summary>
        /// Advances the tape one step: re-prices part of the universe in place and returns the quotes
        /// that moved. The command bar's indices all re-price.
        /// </summary>
        public List<FintechDockManagerQuote> Advance(string marketTime)
        {
            var repriced = new List<FintechDockManagerQuote>();
            foreach (var stock in Stocks)
            {
                if (random.NextDouble() < TickCoverage)
                {
                    RepriceStock(stock, marketTime);
                    repriced.Add(stock);
                }
            }

            Indices = Indices.Select(RepriceIndex).ToList();
            Tick++;
            return repriced;
        }

        private void RepriceStock(FintechDockManagerQuote stock, string marketTime)
        {
            var lastPrice = Drift(stock.LastPrice, StockVolatility);
            var spread = Math.Max(0.01, FintechDockManagerFormat.Round2(lastPrice * FintechDockManagerSeed.SpreadBps / 10000));
            var changePct = FintechDockManagerFormat.Round2(FintechDockManagerFormat.PercentChange(lastPrice, stock.PreviousClose));

            stock.LastPrice = lastPrice;
            stock.Bid = FintechDockManagerFormat.Round2(lastPrice - spread);
            stock.Ask = FintechDockManagerFormat.Round2(lastPrice + spread);
            stock.Change = FintechDockManagerFormat.Round2(lastPrice - stock.PreviousClose);
            stock.ChangePct = changePct;
            stock.Positive = changePct >= 0;
            stock.DayHigh = Math.Max(stock.DayHigh, lastPrice);
            stock.DayLow = Math.Min(stock.DayLow, lastPrice);
            stock.Volume += Math.Floor(stock.AvgVol3M / 5000 + 0.5);
            stock.MarketTime = marketTime;
        }

        private FintechDockManagerIndex RepriceIndex(FintechDockManagerIndex index)
        {
            var value = Drift(index.Value, IndexVolatility);
            var changePct = FintechDockManagerFormat.Round2(FintechDockManagerFormat.PercentChange(value, index.PreviousClose));
            var next = index.Clone();
            next.Value = value;
            next.ChangePct = changePct;
            next.Positive = changePct >= 0;
            return next;
        }

        /// <summary>Random walk: a symmetric move of up to volatility percent.</summary>
        private double Drift(double price, double volatility)
        {
            var changePct = (random.NextDouble() * 2 - 1) * volatility;
            return FintechDockManagerFormat.Round2(price * (1 + changePct / 100));
        }
    }
}
