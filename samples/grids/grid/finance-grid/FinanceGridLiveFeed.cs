using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Samples
{
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
        /// Re-prices a random slice of the portfolio and returns the holdings whose price moved.
        /// Holdings left out of the batch lose their up/down flag, so a flash lasts one tick.
        /// </summary>
        public List<FinanceGridRow> RepriceBatch()
        {
            var batchSize = Math.Max(1, (int)Math.Round(rows.Count * TickCoverage, MidpointRounding.AwayFromZero));
            var moved = new HashSet<int>();
            while (moved.Count < batchSize)
            {
                moved.Add(random.Next(rows.Count));
            }

            var repriced = new List<FinanceGridRow>();
            for (var index = 0; index < rows.Count; index++)
            {
                var row = rows[index];
                if (!moved.Contains(index))
                {
                    row.SetDirection(FinanceGridTickDirection.None);
                }
                else if (Reprice(row))
                {
                    repriced.Add(row);
                }
            }

            return repriced;
        }

        /// <summary>Marks one holding to a new market price and recomputes everything off it.</summary>
        private bool Reprice(FinanceGridRow row)
        {
            var reference = previousClose.TryGetValue(row.Ticker, out var close) ? close : row.LastPrice;
            var drift = (random.NextDouble() - 0.5) * 2 * Volatility;
            var pull = ((reference - row.LastPrice) / row.LastPrice) * 100 * MeanReversion;
            var nextPrice = Round2(Math.Max(0.01, row.LastPrice * (1 + (drift + pull) / 100)));

            if (nextPrice == row.LastPrice)
            {
                row.SetDirection(FinanceGridTickDirection.None);
                return false;
            }

            row.SetDirection(nextPrice > row.LastPrice ? FinanceGridTickDirection.Up : FinanceGridTickDirection.Down);
            row.LastPrice = nextPrice;

            // The same identities the seed data satisfies, so a live row stays arithmetically
            // consistent with the ones that have not moved yet.
            row.ChangePct = Round2((nextPrice / reference - 1) * 100);
            row.MarketValue = Round2(nextPrice * row.Position);

            var costBasis = row.AverageCost * row.Position;
            row.NetProfit = Round2((nextPrice - row.AverageCost) * row.Position);
            row.NetProfitPct = costBasis == 0 ? 0 : Round2((row.NetProfit / costBasis) * 100);

            // A new series rather than an in-place append: the sparkline redraws when its
            // DataSource reference changes.
            row.PriceTrend = AppendTrendPoint(row.PriceTrend, row.ChangePct);
            row.TrendRevision++;
            return true;
        }

        private static double Round2(double value) => Math.Round(value, 2, MidpointRounding.AwayFromZero);

        private static List<FinanceGridTrendPoint> AppendTrendPoint(List<FinanceGridTrendPoint> series, double value)
        {
            var next = new List<FinanceGridTrendPoint>(series) { new FinanceGridTrendPoint { Value = value } };
            return next.Count > FinanceGridDataService.TrendPoints
                ? next.GetRange(next.Count - FinanceGridDataService.TrendPoints, FinanceGridDataService.TrendPoints)
                : next;
        }
    }
}
