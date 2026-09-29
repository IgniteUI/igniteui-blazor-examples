using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Samples
{
    /// <summary>One point of a holding's price-trend sparkline: the day's change, in percent.</summary>
    public class FinanceGridTrendPoint
    {
        public double Value { get; set; }
    }

    /// <summary>Direction of a holding's most recent re-pricing, or None while it is idle.</summary>
    public enum FinanceGridTickDirection
    {
        None,
        Up,
        Down
    }

    /// <summary>
    /// One holding of the portfolio. The live feed re-prices these objects in place; the cell
    /// templates find them through the grid's primary key (the ticker).
    /// </summary>
    public class FinanceGridRow
    {
        public string Ticker { get; set; }
        public string Company { get; set; }
        public double LastPrice { get; set; }
        public double ChangePct { get; set; }
        public double MarketValue { get; set; }
        public double NetProfit { get; set; }
        public double NetProfitPct { get; set; }
        public double AllocationPct { get; set; }
        public double AverageCost { get; set; }
        public double Position { get; set; }
        public int HoldingPeriodDays { get; set; }
        public string Tone { get; set; }

        /// <summary>The sparkline series. Replaced (never mutated) on every re-pricing.</summary>
        public List<FinanceGridTrendPoint> PriceTrend { get; set; }

        public FinanceGridTickDirection Direction { get; private set; }

        /// <summary>Bumped on every re-pricing; the grid's Price Trend field carries it.</summary>
        public int TrendRevision { get; set; }

        /// <summary>
        /// Bumped whenever a new flash starts: the direction changes, or the row moves again after
        /// an idle tick. The delta chips use it as their @key, so a new flash gets a new element.
        /// </summary>
        public int FlashSerial { get; private set; }

        /// <summary>
        /// True when the latest move went the same way as the one on the tick before. The delta chips
        /// then add is-repeat, which switches their flash off: re-rendering a chip would restart it.
        /// </summary>
        public bool IsRepeatMove { get; private set; }

        public void SetDirection(FinanceGridTickDirection direction)
        {
            var isMove = direction != FinanceGridTickDirection.None;
            IsRepeatMove = isMove && direction == Direction;
            if (isMove && !IsRepeatMove)
            {
                FlashSerial++;
            }

            Direction = direction;
        }

        /// <summary>The flat record the grid is bound to: one property per column field.</summary>
        public FinanceGridRecord ToRecord()
        {
            return new FinanceGridRecord
            {
                Ticker = Ticker,
                PriceTrend = TrendRevision,
                LastPrice = LastPrice,
                HoldingPeriodDays = HoldingPeriodDays,
                MarketValue = MarketValue,
                NetProfit = NetProfit,
                AllocationPct = AllocationPct
            };
        }
    }

    /// <summary>
    /// What IgbGrid.Data holds: sorting, export and the live patch all work on these fields.
    /// PriceTrend is a revision number rather than the 30-point series, which stays on
    /// FinanceGridRow: the column is neither sortable nor exported, and keeping the arrays out of
    /// the grid's data is what keeps a live tick cheap.
    /// </summary>
    public class FinanceGridRecord
    {
        public string Ticker { get; set; }
        public int PriceTrend { get; set; }
        public double LastPrice { get; set; }
        public int HoldingPeriodDays { get; set; }
        public double MarketValue { get; set; }
        public double NetProfit { get; set; }
        public double AllocationPct { get; set; }
    }

    /// <summary>The 50 seeded holdings and their deterministic synthetic price trends.</summary>
    public static class FinanceGridDataService
    {
        public const int TrendPoints = 30;

        public static List<FinanceGridRow> CreateRows()
        {
            var rows = new List<FinanceGridRow>
            {
            Seed("AMD", "Advanced Micro Devices Inc.", 130.36, 0, 3128.64, 1315.68, 72.57, 4.38, 75.54, 24, 157, "blue"),
            Seed("ETH", "Ethereum", 3567.93, -0.2, 10073.79, 3074.79, 40.3, 18.43, 2543, 3, 120, "slate"),
            Seed("ABNB", "Airbnb Inc.", 130.65, -0.77, 3004.95, 1709.59, 131.98, 3.13, 56.32, 23, 540, "red"),
            Seed("BABA", "Alibaba Group Holding Limited", 81.81, 1.22, 981.72, -310.92, -24.05, 3.12, 107.72, 12, 91, "orange"),
            Seed("BTC", "Bitcoin", 95300.86, 0.72, 19060.17, 7013.97, 58.23, 29.1, 60231, 0.2, 323, "gold"),
            Seed("BKNG", "Booking Holdings Inc", 4932.51, 1.03, 986.5, 110.86, 12.66, 2.12, 4378.21, 0.2, 17, "blue"),
            Seed("COST", "Costco Wholesale Corporation", 911.37, -0.33, 9113.7, 212.5, 2.39, 21.5, 890.12, 10, 32, "red"),
            Seed("DPZ", "Dominos Pizza Inc", 19.5, 0, 409.5, -96.6, -19.09, 1.22, 24.1, 21, 54, "red"),
            Seed("FDX", "FedEx Corporation", 286.96, 0.35, 573.92, 35.82, 6.66, 1.3, 269.05, 2, 72, "orange"),
            Seed("F", "Ford Motor Company", 10.41, 0, 58.3, -26.88, -31.56, 0.21, 15.21, 5.6, 431, "blue"),
            Seed("GM", "General Motors Company", 53.25, 0, 165.08, 65.07, 65.07, 0.24, 32.26, 3.1, 652, "blue"),
            Seed("AAPL", "Apple Inc.", 223.36, 0.45, 245.7, 76.07, 44.84, 0.41, 154.21, 1.1, 632, "slate"),
            Seed("MSFT", "Microsoft Corp.", 401.22, 0.5, 280.85, -20.15, -6.69, 0.73, 430, 0.7, 342, "blue"),
            Seed("GOOGL", "Alphabet Inc.", 160.02, 1.25, 208.03, -18.17, -8.03, 0.55, 174, 1.3, 376, "green"),
            Seed("AMZN", "Amazon.com Inc.", 205.87, 0.49, 885.24, -285.82, -24.41, 2.83, 272.34, 4.3, 352, "gold"),
            Seed("JPM", "JPMorgan Chase and Co", 238.84, -0.42, 71.65, 1.42, 2.02, 0.17, 234.11, 0.3, 13, "blue"),
            Seed("TSLA", "Tesla Inc.", 332.92, 0.9, 1598.02, 157.01, 10.9, 3.48, 300.21, 4.8, 452, "red"),
            Seed("NVDA", "NVIDIA Corp.", 136.92, 0, 164.3, 44.3, 36.92, 0.29, 100, 1.2, 237, "green"),
            Seed("K", "Kellogg Company", 76.66, 0, 15.33, -0.31, -1.98, 0.04, 78.23, 0.2, 2, "red"),
            Seed("V", "Visa Inc.", 307.92, 0.65, 24.63, -2.37, -8.78, 0.07, 337.6, 0.08, 365, "blue"),
            Seed("JNJ", "Johnson & Johnson", 155.77, -0.64, 327.12, -33.41, -9.27, 0.87, 171.68, 2.1, 420, "red"),
            Seed("PG", "Procter & Gamble Co.", 156.89, 0, 141.2, -9.01, -6, 0.36, 166.9, 0.9, 150, "slate"),
            Seed("WMT", "Walmart Inc.", 145.65, -1.37, 52.43, 9.23, 21.37, 0.1, 120, 0.36, 250, "blue"),
            Seed("HD", "The Home Depot Inc.", 428.61, -1.4, 145.73, -7.72, -5.03, 0.37, 451.31, 0.34, 290, "orange"),
            Seed("KO", "Coca-Cola Co.", 56.79, 0, 22.72, -11.87, -34.32, 0.08, 86.46, 0.4, 180, "red"),
            Seed("PEP", "PepsiCo Inc.", 184.37, -1.08, 36.87, -1.16, -3.05, 0.09, 190.15, 0.2, 430, "slate"),
            Seed("DIS", "Walt Disney Co.", 178, 0.56, 33.82, -8.47, -20.03, 0.1, 222.56, 0.19, 380, "red"),
            Seed("PFE", "Pfizer Inc.", 39.81, 0, 3.98, -0.15, -3.63, 0.01, 41.32, 0.1, 180, "blue"),
            Seed("XOM", "Exxon Mobil Corp.", 114.38, 1.75, 388.89, -100.06, -20.46, 1.18, 143.81, 3.4, 400, "red"),
            Seed("CVX", "Chevron Corp.", 179.62, -0.56, 71.85, 11.12, 18.31, 0.15, 151.82, 0.4, 320, "blue"),
            Seed("MCD", "McDonalds Corporation", 281.27, 0.61, 87.19, 74.62, 132.06, 0.17, 121.21, 0.31, 610, "gold"),
            Seed("INTC", "Intel Corp.", 23.65, 0, 6.39, -16.56, -72.18, 0.01, 85, 0.27, 342, "green"),
            Seed("NFLX", "Netflix Inc.", 877.34, 0, 105.28, 99.88, 1849.64, 0.19, 45, 0.12, 289, "blue"),
            Seed("ADBE", "Adobe Inc.", 513.68, 0, 174.65, 148.13, 558.56, 0.32, 78, 0.34, 412, "gold"),
            Seed("CRM", "Salesforce Inc.", 341.45, 0, 307.31, 256.9, 509.73, 0.56, 56, 0.9, 198, "gold"),
            Seed("BA", "Boeing Co", 152.4, 0, 71.63, 28.39, 65.65, 0.13, 92, 0.47, 276, "red"),
            Seed("IBM", "IBM Corp.", 222.97, 0, 66.89, 53.39, 395.49, 0.12, 45, 0.3, 365, "blue"),
            Seed("MDLZ", "Mondelez International Inc", 64.4, 0, 61.18, -47.5, -43.71, 0.11, 114.4, 0.95, 2, "red"),
            Seed("MS", "Morgan Stanley", 131.2, 0, 87.9, -33.5, -27.59, 0.16, 181.2, 0.67, 13, "gold"),
            Seed("SPOT", "Spotify Technology SA", 475.87, 0, 166.55, -17.5, -9.51, 0.3, 525.87, 0.35, 41, "green"),
            Seed("MMM", "3M Co.", 130.32, 0, 195.48, -30, -13.3, 0.36, 150.32, 1.5, 123, "slate"),
            Seed("CSCO", "Cisco Systems Inc.", 58.74, 0, 28.2, -19.2, -40.51, 0.05, 98.74, 0.48, 456, "green"),
            Seed("SBUX", "Starbucks Corp.", 101.51, 0, 22.33, -8.8, -28.27, 0.04, 141.51, 0.22, 234, "gold"),
            Seed("AXP", "American Express Co.", 304.28, 0, 100.41, -13.2, -11.62, 0.18, 344.28, 0.33, 389, "red"),
            Seed("GE", "General Electric Co.", 181.15, 0, 126.8, -28, -18.09, 0.23, 221.15, 0.7, 178, "green"),
            Seed("UBER", "Uber Technologies Inc", 71.51, 0, 16.45, 3.45, 26.54, 0.03, 56.51, 0.23, 487, "green"),
            Seed("ZM", "Zoom Video Communications Inc", 89.03, 0, 9.79, 3.85, 64.78, 0.02, 54.03, 0.11, 276, "red"),
            Seed("CAT", "Caterpillar Inc.", 406.35, 0, 77.21, -7.6, -8.96, 0.14, 446.35, 0.19, 87, "blue"),
            Seed("HON", "Honeywell International Inc.", 229.64, 0, 50.52, -8.8, -14.83, 0.09, 269.64, 0.22, 276, "orange"),
            Seed("PYPL", "PayPal Holdings Inc.", 86.57, 0, 32.03, -14.8, -31.6, 0.06, 126.57, 0.37, 412, "orange")
            };

            foreach (var row in rows)
            {
                row.PriceTrend = BuildPriceTrend(row.Ticker, row.ChangePct);
            }

            return rows;
        }

        /// <summary>The largest absolute allocation; the Allocation bars are scaled against it.</summary>
        public static double GetMaxAllocationPct(IEnumerable<FinanceGridRow> rows)
        {
            return Math.Max(rows.Select(row => Math.Abs(row.AllocationPct)).DefaultIfEmpty(0).Max(), 0);
        }

        /// <summary>
        /// A deterministic synthetic trend for one ticker: a random walk from an xorshift32 generator
        /// seeded with the ticker, pulled toward the day's change, which is also its last point. The
        /// same ticker draws the same curve on every load.
        /// </summary>
        public static List<FinanceGridTrendPoint> BuildPriceTrend(string ticker, double changePct)
        {
            var target = Math.Round(changePct, 2, MidpointRounding.AwayFromZero);
            var volatility = Math.Max(0.2, Math.Min(1.15, Math.Abs(changePct) * 0.55 + 0.25));

            // Seed: acc * 31 + character code over the ticker, from 2166136261, wrapping at 32 bits.
            uint hashSeed = 2166136261;
            foreach (var ch in ticker)
            {
                hashSeed = unchecked(hashSeed * 31 + ch);
            }

            var seed = hashSeed;
            var value = 0.0;
            var series = new List<FinanceGridTrendPoint>(TrendPoints);

            for (var index = 0; index < TrendPoints; index++)
            {
                // xorshift32 (the state is a uint, so ">> 17" is the logical shift it needs).
                seed ^= seed << 13;
                seed ^= seed >> 17;
                seed ^= seed << 5;
                var random = seed / 4294967296.0;

                var t = (double)index / (TrendPoints - 1);
                var directionalTarget = target * t;
                var randomStep = (random - 0.5) * volatility;
                var pull = (directionalTarget - value) * 0.22;
                var microWave = Math.Sin((t * Math.PI * 9) + (hashSeed % 11)) * 0.06;
                value += randomStep + pull + microWave;
                series.Add(new FinanceGridTrendPoint { Value = Math.Round(value, 2, MidpointRounding.AwayFromZero) });
            }

            series[series.Count - 1] = new FinanceGridTrendPoint { Value = target };
            return series;
        }

        private static FinanceGridRow Seed(string ticker, string company, double lastPrice, double changePct,
            double marketValue, double netProfit, double netProfitPct, double allocationPct, double averageCost,
            double position, int holdingPeriodDays, string tone)
        {
            return new FinanceGridRow
            {
                Ticker = ticker,
                Company = company,
                LastPrice = lastPrice,
                ChangePct = changePct,
                MarketValue = marketValue,
                NetProfit = netProfit,
                NetProfitPct = netProfitPct,
                AllocationPct = allocationPct,
                AverageCost = averageCost,
                Position = position,
                HoldingPeriodDays = holdingPeriodDays,
                Tone = tone
            };
        }
    }
}
