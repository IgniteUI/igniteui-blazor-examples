using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    // One row of the FinTech Trading grid: a traded instrument, with the same fields as the
    // homepage sample's FinjsRow. Every field reaches the grid as-is (PascalCase) through
    // IgbGrid.Data; Trend is the outcome of the trend rule, which the cell classes and the Price
    // template only read.
    public class Fintech100kRow
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Contract { get; set; }
        public string Settlement { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public DateTime LastUpdated { get; set; }
        public double OpenPrice { get; set; }
        public double Price { get; set; }
        public double Change { get; set; }
        public double ChangeP { get; set; }
        public double Buy { get; set; }
        public double Sell { get; set; }
        public double Spread { get; set; }
        public double Volume { get; set; }
        public double HighD { get; set; }
        public double LowD { get; set; }
        public double HighY { get; set; }
        public double LowY { get; set; }
        public double StartY { get; set; }
        public string IndGroup { get; set; }
        public string IndSector { get; set; }
        public string IndSubgroup { get; set; }
        public string SecType { get; set; }
        public string IssuerName { get; set; }
        public string Moodys { get; set; }
        public string Fitch { get; set; }
        public string Dbrs { get; set; }
        public string CollateralType { get; set; }
        public string Currency { get; set; }
        public string Security { get; set; }
        public string Sector { get; set; }
        public string Cusip { get; set; }
        public string Ticker { get; set; }
        public string Coupon { get; set; }
        public string Maturity { get; set; }
        public double Krd3Yr { get; set; }
        public double ZSpread { get; set; }
        public double Krd5Yr { get; set; }
        public double Krd1Yr { get; set; }

        // The daily move's bucket (Fintech100kTrend), read by the trend cell classes of Price,
        // Change and Change % and by the Price arrow.
        public string Trend { get; set; }
    }

    // The daily-move buckets of the homepage sample's trend rules, decided on ChangeP (the percent
    // change): StrongPositive at 1 or more, Positive above 0, Negative below 0, StrongNegative at
    // -1 or less, and Flat at exactly 0, which no trend class or arrow marks.
    public static class Fintech100kTrend
    {
        public const string StrongPositive = "StrongPositive";
        public const string Positive = "Positive";
        public const string Flat = "Flat";
        public const string Negative = "Negative";
        public const string StrongNegative = "StrongNegative";

        public static string Of(double changeP)
        {
            if (changeP >= 1)
            {
                return StrongPositive;
            }

            if (changeP > 0)
            {
                return Positive;
            }

            if (changeP <= -1)
            {
                return StrongNegative;
            }

            return changeP < 0 ? Negative : Flat;
        }
    }

    public class Fintech100kRegion
    {
        public string Name { get; set; }
        public string[] Countries { get; set; }
    }

    // The figures one instrument starts from; every generated row copies one of them.
    internal class Fintech100kSeed
    {
        public string Category;
        public string Type;
        public double Spread;
        public double OpenPrice;
        public double Price;
        public double Buy;
        public double Sell;
        public double Change;
        public double ChangeP;
        public double Volume;
        public double HighD;
        public double LowD;
        public double HighY;
        public double LowY;
        public double StartY;

        public Fintech100kSeed(string category, string type, double spread, double openPrice, double price, double buy, double sell,
            double change, double changeP, double volume, double highD, double lowD, double highY, double lowY, double startY)
        {
            Category = category;
            Type = type;
            Spread = spread;
            OpenPrice = openPrice;
            Price = price;
            Buy = buy;
            Sell = sell;
            Change = change;
            ChangeP = changeP;
            Volume = volume;
            HighD = highD;
            LowD = lowD;
            HighY = highY;
            LowY = lowY;
            StartY = startY;
        }
    }

    // Generates the synthetic instrument rows of the FinTech Trading grid, as the homepage sample's
    // FinjsDataService does: each row copies a random seed instrument and the bond reference fields,
    // picks a contract, a settlement, a region and one of its countries, a date this year, and moves
    // the price once by up to 2% either way.
    public static class Fintech100kDataService
    {
        // The homepage sample's row count, which the toolbar's row count label reads.
        public const int RowCount = 100000;

        public static readonly string[] ContractTypes = { "Forwards", "Futures", "Options", "Swap", "CFD" };
        public static readonly string[] SettlementTypes = { "Deliverable", "Cash" };

        public static readonly Fintech100kRegion[] Regions =
        {
            new Fintech100kRegion { Name = "North America", Countries = new[] { "Canada", "United States", "Mexico" } },
            new Fintech100kRegion
            {
                Name = "Middle East",
                Countries = new[] { "Turkey", "Iraq", "Saudi Arabia", "Syria", "UAE", "Israel", "Jordan", "Lebanon", "Oman", "Kuwait", "Qatar", "Bahrain", "Iran" }
            },
            new Fintech100kRegion
            {
                Name = "Europe",
                Countries = new[]
                {
                    "Russia", "Germany", "France", "United Kingdom", "Italy", "Spain", "Poland", "Romania", "Netherlands", "Belgium", "Greece",
                    "Portugal", "Czech Republic", "Hungary", "Sweden", "Austria", "Switzerland", "Bulgaria", "Denmark", "Finland", "Slovakia",
                    "Norway", "Ireland", "Croatia", "Slovenia", "Estonia", "Iceland"
                }
            },
            new Fintech100kRegion
            {
                Name = "Africa",
                Countries = new[] { "Nigeria", "Ethiopia", "Egypt", "South Africa", "Algeria", "Morocco", "Cameroon", "Niger", "Senegal", "Tunisia", "Libya" }
            },
            new Fintech100kRegion
            {
                Name = "Asia Pacific",
                Countries = new[]
                {
                    "Afghanistan", "Australia", "Azerbaijan", "China", "Hong Kong", "India", "Indonesia", "Japan", "Malaysia", "New Zealand",
                    "Pakistan", "Philippines", "Korea", "Singapore", "Taiwan", "Thailand"
                }
            },
            new Fintech100kRegion
            {
                Name = "South America",
                Countries = new[] { "Argentina", "Bolivia", "Brazil", "Chile", "Colombia", "Ecuador", "Guyana", "Paraguay", "Peru", "Suriname", "Uruguay", "Venezuela" }
            }
        };

        private static readonly Fintech100kSeed[] Seeds =
        {
            new Fintech100kSeed("Metal", "Gold", 0.01, 1281.10, 1280.7317, 1280.7267, 1280.7367, -0.3683, -0.0287, 48387, 1289.50, 1279.10, 1306, 1047.20, 1176.60),
            new Fintech100kSeed("Metal", "Silver", 0.01, 17.43, 17.42, 17.43, 17.43, -0.01, -0.0574, 11720, 17.51, 17.37, 18.06, 13.73, 15.895),
            new Fintech100kSeed("Metal", "Copper", 0.02, 2.123, 2.113, 2.123, 2.123, -0.01, -0.471, 28819, 2.16, 2.11, 2.94, 1.96, 2.45),
            new Fintech100kSeed("Metal", "Platinum", 0.01, 1071.60, 1071.0993, 1071.0943, 1071.1043, -0.5007, -0.0467, 3039, 1081.20, 1070.50, 1120.60, 812.40, 966.50),
            new Fintech100kSeed("Metal", "Palladium", 0.01, 600.55, 601.0005, 600.9955, 601.0055, 0.4505, 0.075, 651, 607.20, 598.40, 690, 458.6, 574.3),
            new Fintech100kSeed("Oil", "Oil", 0.015, 45.54, 45.7899, 45.7824, 45.7974, 0.2499, 0.5487, 107196, 45.94, 45.00, 65.28, 30.79, 48.035),
            new Fintech100kSeed("Oil", "Brent", 0.01, 46.06, 46.05, 46.06, 46.06, -0.01, -0.0217, 59818, 46.48, 45.60, 71.14, 30.02, 50.58),
            new Fintech100kSeed("Oil", "Natural Gas", 0.02, 2.094, 2.104, 2.094, 2.094, 0.01, 0.4776, 2783, 2.11, 2.09, 3.20, 1.84, 2.52),
            new Fintech100kSeed("Oil", "RBOB Gas", 0.015, 1.5086, 1.9532, 1.9457, 1.9607, 0.4446, 29.4686, 2646, 1.9532, 1.50, 2.05, 1.15, 1.60),
            new Fintech100kSeed("Oil", "Diesel", 0.015, 1.3474, 1.3574, 1.3474, 1.3474, 0.01, 0.7422, 2971, 1.36, 1.34, 2.11, 0.92, 1.515),
            new Fintech100kSeed("Oil", "Ethanol", 0.01, 1.512, 2.7538, 2.7488, 2.7588, 1.2418, 82.1323, 14, 2.7538, 1.1168, 2.7538, 1.1168, 1.475),
            new Fintech100kSeed("Oil", "Uranium", 0.02, 27.55, 27.58, 27.55, 27.55, 0.03, 0.1089, 12, 27.55, 27.55, 29.32, 21.28, 25.30),
            new Fintech100kSeed("Oil", "Coal", 0.015, 0.4363, 0.4163, 0.4363, 0.4363, -0.02, -4.584, 3, 0.4363, 0.4363, 0.4841, 0.3954, 0.4398),
            new Fintech100kSeed("Agriculture", "Wheat", 0.01, 465.50, 465.52, 465.50, 465.50, 0.02, 0.0043, 4318, 467.00, 463.25, 628.50, 449.50, 539.00),
            new Fintech100kSeed("Agriculture", "Corn", 0.01, 379.50, 379.8026, 379.7976, 379.8076, 0.3026, 0.0797, 11266, 381.00, 377.75, 471.25, 351.25, 411.25),
            new Fintech100kSeed("Agriculture", "Sugar", 0.01, 15.68, 14.6742, 14.6692, 14.6792, -1.0058, -6.4146, 4949, 15.70, 14.6742, 16.87, 11.37, 14.12),
            new Fintech100kSeed("Agriculture", "Soybean", 0.01, 1038.00, 1038.6171, 1038.6121, 1038.6221, 0.6171, 0.0595, 20356, 1044.00, 1031.75, 1057.00, 859.50, 958.25),
            new Fintech100kSeed("Agriculture", "Soy oil", 0.01, 33.26, 33.7712, 33.7662, 33.7762, 0.5112, 1.5371, 10592, 33.7712, 33.06, 35.43, 26.61, 31.02),
            new Fintech100kSeed("Agriculture", "Soy Meat", 0.01, 342.60, 342.62, 342.60, 342.60, 0.02, 0.0058, 5646, 345.40, 340.30, 353.40, 261.70, 307.55),
            new Fintech100kSeed("Agriculture", "OJ Future", 0.01, 140.60, 140.1893, 140.1843, 140.1943, -0.4107, -0.2921, 7, 140.1893, 0.00, 155.95, 113.00, 134.475),
            new Fintech100kSeed("Agriculture", "Coffee", 0.01, 125.70, 125.69, 125.70, 125.70, -0.01, -0.008, 1654, 125.80, 125.00, 155.75, 115.35, 135.55),
            new Fintech100kSeed("Agriculture", "Cocoa", 0.01, 3076.00, 3076.03, 3076.00, 3076.00, 0.03, 0.001, 978, 3078.00, 3066.00, 3406.00, 2746.00, 3076.00),
            new Fintech100kSeed("Agriculture", "Rice", 0.01, 11.245, 10.4154, 10.4104, 10.4204, -0.8296, -7.3779, 220, 11.38, 10.4154, 14.14, 9.70, 11.92),
            new Fintech100kSeed("Agriculture", "Oats", 0.01, 194.50, 194.2178, 194.2128, 194.2228, -0.2822, -0.1451, 64, 195.75, 194.00, 241.25, 183.75, 212.50),
            new Fintech100kSeed("Agriculture", "Milk", 0.01, 12.87, 12.86, 12.87, 12.87, -0.01, -0.0777, 7, 12.89, 12.81, 16.96, 12.81, 14.885),
            new Fintech100kSeed("Agriculture", "Cotton", 0.01, 61.77, 61.76, 61.77, 61.77, -0.01, -0.0162, 3612, 62.06, 61.32, 67.59, 54.33, 60.96),
            new Fintech100kSeed("Agriculture", "Lumber", 0.01, 303.90, 304.5994, 304.5944, 304.6044, 0.6994, 0.2302, 2, 304.5994, 303.90, 317.10, 236.00, 276.55),
            new Fintech100kSeed("Livestock", "LV Cattle", 0.01, 120.725, 120.705, 120.725, 120.725, -0.02, -0.0166, 4, 120.725, 120.725, 147.98, 113.90, 130.94),
            new Fintech100kSeed("Livestock", "FD Cattle", 0.01, 147.175, 148.6065, 148.6015, 148.6115, 1.4315, 0.9727, 5, 148.6065, 147.175, 190.00, 138.10, 164.05),
            new Fintech100kSeed("Livestock", "Lean Hogs", 0.01, 81.275, 81.8146, 81.8096, 81.8196, 0.5396, 0.664, 1, 81.8146, 81.275, 83.98, 70.25, 77.115),
            new Fintech100kSeed("Currencies", "USD IDX Future", 0.02, 93.88, 93.7719, 93.7619, 93.7819, -0.1081, -0.1151, 5788, 94.05, 93.7534, 100.70, 91.88, 96.29),
            new Fintech100kSeed("Currencies", "USD/JPY Future", 0.02, 9275.50, 9277.3342, 9277.3242, 9277.3442, 1.8342, 0.0198, 47734, 9277.3342, 0.93, 9483.00, 0.93, 4741.965),
            new Fintech100kSeed("Currencies", "GBP/USD Future", 0.02, 1.4464, 1.1941, 1.1841, 1.2041, -0.2523, -17.4441, 29450, 1.45, 1.1941, 1.59, 1.1941, 1.485),
            new Fintech100kSeed("Currencies", "AUD/USD Future", 0.02, 0.7344, 0.7444, 0.7344, 0.7344, 0.01, 1.3617, 36764, 0.74, 0.73, 0.79, 0.68, 0.735),
            new Fintech100kSeed("Currencies", "USD/CAD Future", 0.02, 0.7744, 0.9545, 0.9445, 0.9645, 0.1801, 23.2622, 13669, 0.9545, 0.77, 0.9545, 0.68, 0.755),
            new Fintech100kSeed("Currencies", "USD/CHF Future", 0.02, 1.0337, 1.0437, 1.0337, 1.0337, 0.01, 0.9674, 5550, 1.03, 1.03, 1.11, 0.98, 1.045),
            new Fintech100kSeed("Index", "DOW Future", 0.01, 17711.00, 17712.1515, 17712.1465, 17712.1565, 1.1515, 0.0065, 22236, 17727.00, 17642.00, 18083.00, 15299.00, 16691.00),
            new Fintech100kSeed("Index", "S&P Future", 0.01, 2057.50, 2056.6018, 2056.5968, 2056.6068, -0.8982, -0.0437, 142780, 2059.50, 2049.00, 2105.50, 1794.50, 1950.00),
            new Fintech100kSeed("Index", "NAS Future", 0.01, 4341.25, 4341.28, 4341.25, 4341.25, 0.03, 0.0007, 18259, 4347.00, 4318.00, 4719.75, 3867.75, 4293.75),
            new Fintech100kSeed("Index", "S&P MID MINI", 0.01, 1454.30, 1455.7812, 1455.7762, 1455.7862, 1.4812, 0.1018, 338, 1455.7812, 1448.00, 1527.30, 1236.00, 1381.65),
            new Fintech100kSeed("Index", "S&P 600 MINI", 0.01, 687.90, 687.88, 687.90, 687.90, -0.02, -0.0029, 0, 0.00, 0.00, 620.32, 595.90, 608.11),
            new Fintech100kSeed("Interest Rate", "US 30YR Future", 0.01, 164.875, 164.1582, 164.1532, 164.1632, -0.7168, -0.4347, 28012, 165.25, 164.0385, 169.38, 151.47, 160.425),
            new Fintech100kSeed("Interest Rate", "US 2Y Future", 0.01, 109.3984, 109.3884, 109.3984, 109.3984, -0.01, -0.0091, 17742, 109.41, 109.38, 109.80, 108.62, 109.21),
            new Fintech100kSeed("Interest Rate", "US 10YR Future", 0.01, 130.5625, 130.5825, 130.5625, 130.5625, 0.02, 0.0153, 189310, 130.63, 130.44, 132.64, 125.48, 129.06),
            new Fintech100kSeed("Interest Rate", "Euro$ 3M", 0.01, 99.18, 99.17, 99.18, 99.18, -0.01, -0.0101, 29509, 99.18, 99.17, 99.38, 98.41, 98.895)
        };

        public static List<Fintech100kRow> CreateRows()
        {
            var random = new Random();
            var now = DateTime.Now;
            var rows = new List<Fintech100kRow>(RowCount);
            for (var id = 0; id < RowCount; id++)
            {
                rows.Add(CreateRow(id, random, now));
            }

            return rows;
        }

        private static Fintech100kRow CreateRow(int id, Random random, DateTime now)
        {
            var seed = Seeds[random.Next(Seeds.Length)];
            var region = Regions[random.Next(Regions.Length)];

            // A one-off jitter of up to 2% either way, rounded to cents, as in the homepage sample (the
            // data is static; nothing updates it later): the change is the difference to the seed's price.
            const double volatility = 2;
            var changePercent = 2 * volatility * random.NextDouble();
            if (changePercent > volatility)
            {
                changePercent -= 2 * volatility;
            }

            var newPrice = seed.Price + (seed.Price * (changePercent / 100));
            var changeP = Round2(changePercent);

            return new Fintech100kRow
            {
                Id = id,
                Category = seed.Category,
                Type = seed.Type,
                Contract = ContractTypes[random.Next(ContractTypes.Length)],
                Settlement = SettlementTypes[random.Next(SettlementTypes.Length)],
                Country = region.Countries[random.Next(region.Countries.Length)],
                Region = region.Name,
                LastUpdated = RandomDate(random, now),
                OpenPrice = seed.OpenPrice,
                Price = Round2(newPrice),
                Change = Round2(newPrice - seed.Price),
                ChangeP = changeP,
                Buy = seed.Buy,
                Sell = seed.Sell,
                Spread = seed.Spread,
                Volume = seed.Volume,
                HighD = seed.HighD,
                LowD = seed.LowD,
                HighY = seed.HighY,
                LowY = seed.LowY,
                StartY = seed.StartY,

                // The bond reference fields, one set for every row, as in the homepage sample.
                IndGroup = "Airlines",
                IndSector = "Consumer, Cyclical",
                IndSubgroup = "Airlines",
                SecType = "PUBLIC",
                IssuerName = "AMERICAN AIRLINES GROUP",
                Moodys = "WR",
                Fitch = "N.A.",
                Dbrs = "N.A.",
                CollateralType = "NEW MONEY",
                Currency = "USD",
                Security = "001765866 Pfd",
                Sector = "Pfd",
                Cusip = "1765866",
                Ticker = "AAL",
                Coupon = "7.875",
                Maturity = "7/13/1939",
                Krd3Yr = 0.00006,
                ZSpread = 28.302,
                Krd5Yr = 0,
                Krd1Yr = -0.00187,

                Trend = Fintech100kTrend.Of(changeP)
            };
        }

        // Rounds to two decimals the way the homepage sample does (toFixed(2)): half away from zero.
        private static double Round2(double value)
        {
            return Math.Round(value, 2, MidpointRounding.AwayFromZero);
        }

        // Today's time of day at a random hour, in a random month of this year up to the current one,
        // on a random day from the 1st to the 28th.
        private static DateTime RandomDate(Random random, DateTime now)
        {
            var month = random.Next(now.Month) + 1;
            var day = random.Next(28) + 1;
            var hour = random.Next(24);
            return new DateTime(now.Year, month, day, hour, now.Minute, now.Second, now.Millisecond, DateTimeKind.Local);
        }
    }
}
