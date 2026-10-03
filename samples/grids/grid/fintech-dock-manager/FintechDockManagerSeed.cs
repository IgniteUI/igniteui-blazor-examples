using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Samples
{
    /// <summary>
    /// The seed tables: the tradable universe, the indices, the opening book and the news wire.
    /// One row per instrument; everything that can be derived (previous close, day range, the
    /// bid/ask spread) is computed from the row rather than repeated in it.
    /// </summary>
    public static class FintechDockManagerSeed
    {
        /// <summary>Half-spread applied around the last price, in basis points.</summary>
        public const double SpreadBps = 2;

        public const string OpeningMarketTime = "09:30:00";

        public const double OpeningCash = 812450;

        private static readonly object[][] SeedRows =
        {
            new object[] { "AAPL", "Apple", "Technology", 227.14, 0.55, 8500000d, 55400000d, 3440000000000d, 164.08, 237.49 },
            new object[] { "MSFT", "Microsoft", "Technology", 389.79, 1.26, 4508000d, 39100000d, 2897000000000d, 309.45, 468.35 },
            new object[] { "NVDA", "NVIDIA", "Technology", 138.92, 2.55, 12100000d, 246000000d, 3404000000000d, 39.23, 152.89 },
            new object[] { "AMZN", "Amazon", "Consumer", 198.34, -0.60, 7800000d, 37900000d, 2083000000000d, 118.35, 215.90 },
            new object[] { "GOOGL", "Alphabet", "Technology", 178.22, 0.50, 5100000d, 22600000d, 2186000000000d, 120.21, 191.75 },
            new object[] { "META", "Meta Platforms", "Technology", 512.77, -0.68, 4300000d, 12400000d, 1298000000000d, 274.38, 542.81 },
            new object[] { "TSLA", "Tesla", "Consumer", 248.50, -0.92, 6200000d, 82500000d, 793000000000d, 138.80, 299.29 },
            new object[] { "JPM", "JPMorgan Chase", "Financials", 204.10, 0.74, 3900000d, 9800000d, 586000000000d, 135.19, 225.48 },
            new object[] { "BLK", "BlackRock", "Financials", 1098.58, 7.13, 334440d, 719000d, 163000000000d, 596.18, 1105.20 },
            new object[] { "WFC", "Wells Fargo", "Financials", 86.49, 1.34, 2399000d, 16300000d, 289000000000d, 40.35, 88.10 },
            new object[] { "C", "Citigroup", "Financials", 134.24, 0.73, 2320000d, 12700000d, 126000000000d, 38.17, 137.05 },
            new object[] { "ADBE", "Adobe", "Technology", 226.98, 2.81, 560217d, 6400000d, 100000000000d, 187.35, 587.75 },
            new object[] { "QCOM", "Qualcomm", "Technology", 179.04, 0.53, 990650d, 23100000d, 197000000000d, 101.47, 230.63 },
            new object[] { "EQIX", "Equinix", "Real Estate", 1024.11, 0.06, 43869d, 590000d, 98000000000d, 673.06, 994.79 },
            new object[] { "MELI", "MercadoLibre", "Consumer", 1857.03, -0.90, 48228d, 540044d, 94146000000d, 1495.00, 2548.50 },
            new object[] { "ABNB", "Airbnb", "Consumer", 148.56, 1.38, 287751d, 3700000d, 93000000000d, 110.38, 170.10 },
            new object[] { "FDX", "FedEx", "Industrials", 314.30, 0.21, 54454d, 2100000d, 75000000000d, 199.62, 313.84 },
            new object[] { "WMT", "Walmart", "Consumer", 113.75, 0.04, 1376000d, 22500000d, 913000000000d, 49.85, 105.30 },
            new object[] { "WM", "Waste Management", "Industrials", 234.81, 0.22, 84026d, 2100000d, 94000000000d, 154.06, 222.42 },
            new object[] { "PG", "Procter & Gamble", "Consumer", 145.85, -0.17, 597359d, 9100000d, 395000000000d, 141.45, 180.43 },
            new object[] { "PFE", "Pfizer", "Healthcare", 24.58, 1.32, 3284000d, 40600000d, 139000000000d, 25.20, 45.35 },
            new object[] { "BRK-B", "Berkshire B", "Financials", 489.50, -0.32, 415865d, 5000000d, 1056000000000d, 322.87, 491.67 },
            new object[] { "IEMG", "iShares EM ETF", "ETF", 79.85, 0.16, 1033000d, 12400000d, 85000000000d, 46.51, 83.20 },
            new object[] { "UNIT", "Uniti Group", "Real Estate", 11.03, 0.18, 79080d, 2500000d, 2600000000d, 3.32, 15.98 },
        };

        /// <summary>The opening quote of every instrument, in seed order.</summary>
        public static readonly IReadOnlyList<FintechDockManagerQuote> Stocks = SeedRows.Select(ToQuote).ToList();

        /// <summary>Every symbol the feed knows about: the universe the add-symbol picker offers.</summary>
        public static readonly IReadOnlyList<string> TradableSymbols = Stocks.Select(stock => stock.Symbol).ToList();

        public static IReadOnlyList<FintechDockManagerIndex> Indices => new List<FintechDockManagerIndex>
        {
            ToIndex("S&P 500", 5634.61, 0.42),
            ToIndex("NASDAQ", 18234.55, 0.65),
            ToIndex("DOW", 39872.10, -0.12),
            ToIndex("VIX", 14.22, -2.10),
        };

        /// <summary>Symbols pre-loaded into the watchlist pane.</summary>
        public static readonly IReadOnlyList<string> DefaultWatchlist = new[]
        {
            "MELI", "FDX", "WMT", "WM", "BRK-B", "UNIT", "PFE", "WFC", "C",
            "PG", "IEMG", "ADBE", "EQIX", "QCOM", "MSFT", "BLK", "ABNB",
        };

        /// <summary>Charts open on first load.</summary>
        public static readonly IReadOnlyList<string> DefaultChartSymbols = new[] { "AAPL", "TSLA", "NVDA" };

        /// <summary>The book the desk starts the session with.</summary>
        public static List<FintechDockManagerLot> OpeningLots() => new List<FintechDockManagerLot>
        {
            new FintechDockManagerLot { Symbol = "AAPL", Quantity = 100, AvgCost = 210.40 },
            new FintechDockManagerLot { Symbol = "TSLA", Quantity = 50, AvgCost = 260.00 },
            new FintechDockManagerLot { Symbol = "NVDA", Quantity = 30, AvgCost = 120.00 },
            new FintechDockManagerLot { Symbol = "MSFT", Quantity = 40, AvgCost = 420.00 },
            new FintechDockManagerLot { Symbol = "AMZN", Quantity = 60, AvgCost = 205.00 },
            new FintechDockManagerLot { Symbol = "GOOGL", Quantity = 75, AvgCost = 172.00 },
            new FintechDockManagerLot { Symbol = "META", Quantity = 20, AvgCost = 530.00 },
            new FintechDockManagerLot { Symbol = "JPM", Quantity = 120, AvgCost = 195.00 },
        };

        /// <summary>Overnight wire the news pane starts with, newest first: headline, source, symbol, minutes ago.</summary>
        public static readonly (string Headline, string Source, string Symbol, int MinutesAgo)[] SeedNews =
        {
            ("Apple beats Q3 estimates on services growth", "Reuters", "AAPL", 2),
            ("Fed signals possible rate cut in September", "Bloomberg", null, 14),
            ("Tesla deliveries miss street expectations", "CNBC", "TSLA", 32),
            ("Nvidia unveils next-gen AI chip architecture", "TechWire", "NVDA", 58),
            ("Oil prices slide on supply glut concerns", "MarketWatch", null, 96),
            ("Microsoft Azure revenue jumps 29% year-over-year", "WSJ", "MSFT", 168),
            ("S&P 500 closes at a record high for a third week", "Barron\u2019s", null, 252),
        };

        /// <summary>Pool the live wire draws from once the session is running.</summary>
        public static readonly (string Headline, string Source, string Symbol)[] NewsWirePool =
        {
            ("Block trade crosses at a premium", "Bloomberg", "BLK"),
            ("Analyst lifts price target after guidance", "Reuters", "MSFT"),
            ("Unusual options activity flagged pre-close", "MarketWatch", "NVDA"),
            ("Buyback authorisation expanded", "WSJ", "AAPL"),
            ("Regulator opens review of proposed merger", "Reuters", "META"),
            ("Sector rotation lifts financials", "CNBC", "JPM"),
            ("Retail inflows hit a four-week high", "Barron\u2019s", null),
            ("Treasury yields ease after auction", "Bloomberg", null),
            ("Supply chain checks point to stronger demand", "TechWire", "AMZN"),
            ("Downgrade on valuation concerns", "CNBC", "TSLA"),
        };

        public static FintechDockManagerQuote FindStock(string symbol) => Stocks.FirstOrDefault(stock => stock.Symbol == symbol);

        private static FintechDockManagerQuote ToQuote(object[] row)
        {
            var lastPrice = (double)row[3];
            var changePct = (double)row[4];
            var previousClose = FintechDockManagerFormat.Round2(lastPrice / (1 + changePct / 100));
            var spread = FintechDockManagerFormat.Round2(lastPrice * SpreadBps / 10000);

            return new FintechDockManagerQuote
            {
                Symbol = (string)row[0],
                Name = (string)row[1],
                Sector = (string)row[2],
                LastPrice = lastPrice,
                Bid = FintechDockManagerFormat.Round2(lastPrice - spread),
                Ask = FintechDockManagerFormat.Round2(lastPrice + spread),
                PreviousClose = previousClose,
                Change = FintechDockManagerFormat.Round2(lastPrice - previousClose),
                ChangePct = changePct,
                Currency = "USD",
                MarketTime = OpeningMarketTime,
                Volume = (double)row[5],
                AvgVol3M = (double)row[6],
                DayLow = FintechDockManagerFormat.Round2(Math.Min(lastPrice, previousClose) * 0.994),
                DayHigh = FintechDockManagerFormat.Round2(Math.Max(lastPrice, previousClose) * 1.006),
                Week52Low = (double)row[8],
                Week52High = (double)row[9],
                MarketCap = (double)row[7],
                Positive = changePct >= 0,
            };
        }

        private static FintechDockManagerIndex ToIndex(string name, double value, double changePct) => new FintechDockManagerIndex
        {
            Name = name,
            Value = value,
            PreviousClose = FintechDockManagerFormat.Round2(value / (1 + changePct / 100)),
            ChangePct = changePct,
            Positive = changePct >= 0,
        };
    }
}
