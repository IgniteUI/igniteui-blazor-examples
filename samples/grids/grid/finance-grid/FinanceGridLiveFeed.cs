using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Samples
{
    /// <summary>What one pass of the feed changed.</summary>
    public class FinanceGridTick
    {
        /// <summary>The holdings whose price moved.</summary>
        public List<FinanceGridRow> Repriced { get; } = new List<FinanceGridRow>();

        /// <summary>The holdings that moved on the pass before and not on this one: their flash ends.</summary>
        public List<FinanceGridRow> Settled { get; } = new List<FinanceGridRow>();
    }

    /// <summary>
    /// The portfolio's simulated market feed.
    /// Every tick re-prices a random 35% of the holdings in place: a random walk with a light pull
    /// back toward the previous close, so a long session wanders without running away.
    /// </summary>
    public class FinanceGridLiveFeed
    {
        /// <summary>Milliseconds between re-pricing passes.</summary>
        public const int TickMilliseconds = 1200;

        /// <summary>Share of the portfolio that re-prices on any given tick.</summary>
        public const double TickCoverage = 0.35;

        /// <summary>Largest single-tick move, as a percentage of the last price.</summary>
        public const double Volatility = 0.45;

        /// <summary>How hard a price is pulled back toward its previous close each tick.</summary>
        public const double MeanReversion = 0.04;

        private readonly IReadOnlyList<FinanceGridRow> rows;
        private readonly Dictionary<string, double> previousClose;
        private readonly Random random = new Random();

        public FinanceGridLiveFeed(IReadOnlyList<FinanceGridRow> rows)
        {
            this.rows = rows;

            // The close the day's change is measured against. Derived once from the seed, so
            // ChangePct keeps its opening meaning for the whole session.
            previousClose = rows.ToDictionary(row => row.Ticker, row => row.LastPrice / (1 + row.ChangePct / 100));
        }

        /// <summary>
        /// Re-prices a random slice of the portfolio. Every holding whose price did not move loses its
        /// up/down flag, so a flash lasts one tick; the ones that had a flag are reported as settled.
        /// </summary>
        public FinanceGridTick RepriceBatch()
        {
            var batchSize = Math.Max(1, (int)Math.Round(rows.Count * TickCoverage, MidpointRounding.AwayFromZero));
            var moved = new HashSet<int>();
            while (moved.Count < batchSize)
            {
                moved.Add(random.Next(rows.Count));
            }

            var tick = new FinanceGridTick();
            for (var index = 0; index < rows.Count; index++)
            {
                var row = rows[index];
                if (moved.Contains(index) && Reprice(row))
                {
                    tick.Repriced.Add(row);
                    continue;
                }

                var wasMoving = row.Direction != FinanceGridTickDirection.None;
                row.SetDirection(FinanceGridTickDirection.None);
                if (wasMoving)
                {
                    tick.Settled.Add(row);
                }
            }

            return tick;
        }

        /// <summary>
        /// Marks one holding to a new market price and recomputes everything off it. Returns false,
        /// with the holding untouched, when the new price rounds to the old one.
        /// </summary>
        private bool Reprice(FinanceGridRow row)
        {
            var reference = previousClose.TryGetValue(row.Ticker, out var close) ? close : row.LastPrice;
            var drift = (random.NextDouble() - 0.5) * 2 * Volatility;
            var pull = ((reference - row.LastPrice) / row.LastPrice) * 100 * MeanReversion;
            var nextPrice = Round2(Math.Max(0.01, row.LastPrice * (1 + (drift + pull) / 100)));

            if (nextPrice == row.LastPrice)
            {
                return false;
            }

            row.SetDirection(nextPrice > row.LastPrice ? FinanceGridTickDirection.Up : FinanceGridTickDirection.Down);
            row.LastPrice = nextPrice;

            // The same identities the seed data satisfies, so a live row stays arithmetically
            // consistent with the ones that have not moved yet.
            row.ChangePct = Round2((nextPrice / reference - 1) * 100);
            row.MarketValue = Round2(nextPrice * row.Position);

            var costBasis = row.AverageCost * row.Position;
            var previousNetProfit = row.NetProfit;
            row.NetProfit = Round2((nextPrice - row.AverageCost) * row.Position);
            row.NetProfitPct = costBasis == 0 ? 0 : Round2((row.NetProfit / costBasis) * 100);

            // The Total Revenue cell renders only when NetProfit changes, so its chip counts only the
            // flashes that come with a new NetProfit.
            row.CountProfitFlash(previousNetProfit);

            // The Price Trend column's field is TrendRevision: the bump is what makes its cell
            // template run again and draw the new series.
            row.PriceTrend = AppendTrendPoint(row.PriceTrend, row.ChangePct);
            row.TrendRevision++;
            return true;
        }

        private static double Round2(double value) => Math.Round(value, 2, MidpointRounding.AwayFromZero);

        // The newest value goes last; the oldest drops off once the series holds TrendPoints values.
        private static double[] AppendTrendPoint(double[] series, double value)
        {
            var kept = Math.Min(series.Length, FinanceGridDataService.TrendPoints - 1);
            var next = new double[kept + 1];
            Array.Copy(series, series.Length - kept, next, 0, kept);
            next[kept] = value;
            return next;
        }
    }
}
