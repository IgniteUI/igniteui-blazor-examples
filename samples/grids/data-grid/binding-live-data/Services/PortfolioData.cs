using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class Region
    {
        public string Name { get; set; }
        public List<string> Countries { get; set; }
    }

    public class PortfolioData // LiveFinancialData
    {
        public static Random random = new Random();

        public static List<string> DealType = new List<string>() { "Buy", "Sell" };
        public static List<string> Contracts = new List<string>() { "Forwards", "Futures", "Options", "Swap", "CFD" };
        public static List<string> Settlements = new List<string>() { "Credit", "Cash", "Loan" };
        public static List<string> SectorTypes = new List<string>() { "Public", "Private", "Government" };
        public static List<string> CurrencyTypes = new List<string>() { "USD", "EUR", "PLN", "GBP", "YEN" };
        public static List<string> CountryRisks = new List<string>() { "Low", "High" };
        public static List<string> SecurityTypes = new List<string>() { "Poor", "Good", "High", };
        public static List<string> IssuerNames = new List<string>() { "American Airlines", "Delta Airlines", "Southwest", "FedEx", };
        public static List<string> RatingTypes = new List<string>() { "AAA", "BBB", "CCC", };
        public static List<PortfolioInfo> DataItems = GetDataItems();
        public static List<Region> Regions = GetRegions();

        public static List<PortfolioInfo> Create(int count)
        {
            var dataItems = new List<PortfolioInfo>();
            var defaultItem = GetDefaultData();

            for (int i = 0; i < count; i++)
            {
                var rand = (int)Math.Floor(random.NextDouble() * DataItems.Count);

                var region = DataRandomizer.GetItem(Regions) as Region;

                var item = DataItems[rand].Clone();
                item.Region = region.Name;
                // generating random values of properties
                item.Settlement = DataRandomizer.GetItem(Settlements).ToString();
                item.Contract = DataRandomizer.GetItem(Contracts).ToString();
                item.Country = DataRandomizer.GetItem(region.Countries).ToString();
                item.Risk = DataRandomizer.GetItem(CountryRisks).ToString();
                item.Sector = DataRandomizer.GetItem(SectorTypes).ToString();
                item.Currency = DataRandomizer.GetItem(CurrencyTypes).ToString();
                item.Security = DataRandomizer.GetItem(SecurityTypes).ToString();
                item.Issuer = DataRandomizer.GetItem(IssuerNames).ToString();
                item.Maturity = DataRandomizer.GetDate();
                item.Rating = DataRandomizer.GetItem(RatingTypes).ToString();

                // setting default properties
                item.IndGroup = defaultItem.IndGroup;
                item.IndSector = defaultItem.IndSector;
                item.IndCategory = defaultItem.IndCategory;
                item.Fitch = defaultItem.Fitch;
                item.Collateral = defaultItem.Collateral;
                item.Transactions = defaultItem.Transactions;
                item.Spread = defaultItem.Spread;
                item.KRD_1YR = defaultItem.KRD_1YR;
                item.KRD_3YR = defaultItem.KRD_3YR;
                item.KRD_5YR = defaultItem.KRD_5YR;

                item.ID = i;
                RandomizeDataValues(item);
                dataItems.Add(item);
            }
            return dataItems;
        }

        public static PortfolioInfo GetDefaultData()
        {
            return new PortfolioInfo
            {
                IndGroup = "Airlines",
                IndSector = "Consumer, Cyclical",
                IndCategory = "Airlines",
                Fitch = "N.A.",
                Collateral = "Assets",
                Transactions = "1765866",
                CPN = 7.875,
                Maturity = new DateTime(2022, 1, 1),
                Spread = 28.302,
                KRD_3YR = 0.00006,
                KRD_5YR = 0,
                KRD_1YR = -0.00187,
            };
        }

        public static List<Region> GetRegions()
        {
            var data = new List<Region>
            {
                new Region {
                    Name = "North America",
                    Countries = new List<string>() {"Canada", "United States", "Mexico" }
                },
                new Region {
                    Name = "Middle East",
                    Countries =  new List<string>() {"Turkey", "Iraq", "Saudi Arabia", "Syria", "UAE", "Israel", "Jordan", "Lebanon", "Oman", "Kuwait", "Qatar", "Bahrain", "Iran" }
                },
                new Region {
                    Name = "Europe",
                    Countries = new List<string>() {
                        "Russia", "Germany", "France", "United Kingdom", "Italy", "Spain", "Poland", "Romania", "Netherlands", "Belgium", "Greece",
                        "Portugal", "Czech Republic", "Hungary", "Sweden", "Austria", "Switzerland", "Bulgaria", "Denmark", "Finland", "Slovakia", "Norway",
                        "Ireland", "Croatia", "Slovenia", "Estonia", "Iceland"
                    }
                },

                new Region {
                    Name = "Africa",
                    Countries= new List<string>() { "Nigeria", "Ethiopia", "Egypt", "South Africa", "Algeria", "Morocco", "Cameroon", "Niger", "Senegal", "Tunisia", "Libya" }
                },

                new Region {
                    Name = "Asia Pacific",
                    Countries =  new List<string>() {
                        "Afghanistan", "Australia", "Azerbaijan", "China", "Hong Kong", "India", "Indonesia", "Japan",
                        "Malaysia", "New Zealand", "Pakistan", "Philippines", "Korea", "Singapore", "Taiwan", "Thailand"}
                },

                new Region {
                    Name = "South America",
                    Countries =  new List<string>() { "Argentina", "Bolivia", "Brazil", "Chile", "Colombia", "Ecuador", "Guyana", "Paraguay", "Peru", "Suriname", "Uruguay", "Venezuela" }
                },

            };

            return data;
        }

        #region Default Data Items
        public static List<PortfolioInfo> GetDataItems()
        {
            var data = new List<PortfolioInfo>()
            {
                new PortfolioInfo {
                    Category = "Metal",
                    Type = "Gold",
                    Spread = 0.01,
                    Open = 1281.10,
                    Price = 1280.7317,
                    Buy = 1280.7267,
                    Sell = 1280.7367,
                    Change = -0.3683,
                    ChangePercent = -0.0287,
                    Volume = 48387,
                    DailyHigh = 1289.50,
                    DailyLow = 1279.10,
                    YearlyHigh = 1306,
                    YearlyLow = 1047.20,
                    YearlyStart = 1176.60,
                    ChangeOnYear = 8.8502
                },
                new PortfolioInfo {
                    Category = "Metal",
                    Type = "Silver",
                    Spread = 0.01,
                    Open = 17.43,
                    Price = 17.42,
                    Buy = 17.43,
                    Sell = 17.43,
                    Change = -0.01,
                    ChangePercent = -0.0287,
                    Volume = 48387,
                    DailyHigh = 1289.50,
                    DailyLow = 1279.10,
                    YearlyHigh = 1306,
                    YearlyLow = 1047.20,
                    YearlyStart = 1176.60,
                    ChangeOnYear = 8.8502
                },
                new PortfolioInfo {
                    Category= "Metal",
                    Type = "Copper",
                    Spread = 0.02,
                    Open = 2.123,
                    Price = 2.113,
                    Buy = 2.123,
                    Sell = 2.123,
                    Change = -0.01,
                    ChangePercent = -0.471,
                    Volume = 28819,
                    DailyHigh = 2.16,
                    DailyLow = 2.11,
                    YearlyHigh = 2.94,
                    YearlyLow = 1.96,
                    YearlyStart = 2.45,
                    ChangeOnYear = -13.7551
                },
                new PortfolioInfo {
                    Category = "Metal",
                    Type = "Platinum",
                    Spread = 0.01,
                    Open = 1071.60,
                    Price = 1071.0993,
                    Buy = 1071.0943,
                    Sell = 1071.1043,
                    Change = -0.5007,
                    ChangePercent = -0.0467,
                    Volume = 3039,
                    DailyHigh = 1081.20,
                    DailyLow = 1070.50,
                    YearlyHigh = 1120.60,
                    YearlyLow = 812.40,
                    YearlyStart = 966.50,
                    ChangeOnYear = 10.8225
                },
                new PortfolioInfo {
                     Category = "Metal",
                     Type = "Palladium",
                     Spread = 0.01,
                     Open = 600.55,
                     Price = 601.0005,
                     Buy = 600.9955,
                     Sell = 601.0055,
                     Change = 0.4505,
                     ChangePercent = 0.075,
                     Volume = 651,
                     DailyHigh = 607.20,
                     DailyLow = 598.40,
                     YearlyHigh = 690,
                     YearlyLow = 458.6,
                     YearlyStart = 574.3,
                     ChangeOnYear = 4.6492
                },
                new PortfolioInfo
                {
                     Category = "Oil",
                     Type = "Oil",
                     Spread = 0.015,
                     Open = 45.54,
                     Price = 45.7899,
                     Buy = 45.7824,
                     Sell = 45.7974,
                     Change = 0.2499,
                     ChangePercent = 0.5487,
                     Volume = 107196,
                     DailyHigh = 45.94,
                     DailyLow = 45.00,
                     YearlyHigh = 65.28,
                     YearlyLow = 30.79,
                     YearlyStart = 48.035,
                     ChangeOnYear = -4.6739
                },
                new PortfolioInfo
                {
                    Category = "Oil",
                    Type = "Brent",
                    Spread = 0.01,
                    Open = 46.06,
                    Price = 46.05,
                    Buy = 46.06,
                    Sell = 46.06,
                    Change = -0.01,
                    ChangePercent = -0.0217,
                    Volume = 59818,
                    DailyHigh = 46.48,
                    DailyLow = 45.60,
                    YearlyHigh = 71.14,
                    YearlyLow = 30.02,
                    YearlyStart = 50.58,
                    ChangeOnYear = -8.9561
                },
                new PortfolioInfo
                {
                     Category = "Oil",
                     Type = "Natural Gas",
                     Spread = 0.02,
                     Open = 2.094,
                     Price = 2.104,
                     Buy = 2.094,
                     Sell = 2.094,
                     Change = 0.01,
                     ChangePercent = 0.4776,
                     Volume = 2783,
                     DailyHigh = 2.11,
                     DailyLow = 2.09,
                     YearlyHigh = 3.20,
                     YearlyLow = 1.84,
                     YearlyStart = 2.52,
                     ChangeOnYear = -16.5079
                },
                new PortfolioInfo
                {
                    Category = "Oil",
                    Type = "Gas",
                    Spread = 0.015,
                    Open = 1.5086,
                    Price = 1.9532,
                    Buy = 1.9457,
                    Sell = 1.9607,
                    Change = 0.4446,
                    ChangePercent = 29.4686,
                    Volume = 2646,
                    DailyHigh = 1.9532,
                    DailyLow = 1.50,
                    YearlyHigh = 2.05,
                    YearlyLow = 1.15,
                    YearlyStart = 1.60,
                    ChangeOnYear = 22.0727
                },
                new PortfolioInfo
                {
                     Category = "Oil",
                     Type = "Diesel",
                     Spread = 0.015,
                     Open = 1.3474,
                     Price = 1.3574,
                     Buy = 1.3474,
                     Sell = 1.3474,
                     Change = 0.01,
                     ChangePercent = 0.7422,
                     Volume = 2971,
                     DailyHigh = 1.36,
                     DailyLow = 1.34,
                     YearlyHigh = 2.11,
                     YearlyLow = 0.92,
                     YearlyStart = 1.515,
                     ChangeOnYear = -10.4026
                },
                new PortfolioInfo
                {
                     Category = "Oil",
                     Type = "Ethanol",
                     Spread = 0.01,
                     Open = 1.512,
                     Price = 2.7538,
                     Buy = 2.7488,
                     Sell = 2.7588,
                     Change = 1.2418,
                     ChangePercent = 82.1323,
                     Volume = 14,
                     DailyHigh = 2.7538,
                     DailyLow = 1.1168,
                     YearlyHigh = 2.7538,
                     YearlyLow = 1.1168,
                     YearlyStart = 1.475,
                     ChangeOnYear = 86.7011
                },
                new PortfolioInfo
                {
                     Category = "Oil",
                     Type = "Crude",
                     Spread = 0.02,
                     Open = 27.55,
                     Price = 27.58,
                     Buy = 27.55,
                     Sell = 27.55,
                     Change = 0.03,
                     ChangePercent = 0.1089,
                     Volume = 1200,
                     DailyHigh = 27.55,
                     DailyLow = 27.55,
                     YearlyHigh = 29.32,
                     YearlyLow = 21.28,
                     YearlyStart = 25.30,
                     ChangeOnYear = 9.0119
                },
                new PortfolioInfo
                {
                     Category = "Oil",
                     Type = "Coal",
                     Spread = 0.015,
                     Open = 0.4363,
                     Price = 0.4163,
                     Buy = 0.4363,
                     Sell = 0.4363,
                     Change = -0.02,
                     ChangePercent = -4.584,
                     Volume = 300,
                     DailyHigh = 0.4363,
                     DailyLow = 0.4363,
                     YearlyHigh = 0.4841,
                     YearlyLow = 0.3954,
                     YearlyStart = 0.4398,
                     ChangeOnYear = -5.3326
                },
                new PortfolioInfo
                {
                     Category = "Agriculture",
                     Type = "Wheat",
                     Spread = 0.01,
                     Open = 465.50,
                     Price = 465.52,
                     Buy = 465.50,
                     Sell = 465.50,
                     Change = 0.02,
                     ChangePercent = 0.0043,
                     Volume = 4318,
                     DailyHigh = 467.00,
                     DailyLow = 463.25,
                     YearlyHigh = 628.50,
                     YearlyLow = 449.50,
                     YearlyStart = 539.00,
                     ChangeOnYear = -13.6327
                },
                new PortfolioInfo
                {
                     Category = "Agriculture",
                     Type = "Corn",
                     Spread = 0.01,
                     Open = 379.50,
                     Price = 379.8026,
                     Buy = 379.7976,
                     Sell = 379.8076,
                     Change = 0.3026,
                     ChangePercent = 0.0797,
                     Volume = 11266,
                     DailyHigh = 381.00,
                     DailyLow = 377.75,
                     YearlyHigh = 471.25,
                     YearlyLow = 351.25,
                     YearlyStart = 411.25,
                     ChangeOnYear = -7.6468
                },
                new PortfolioInfo
                {
                     Category = "Agriculture",
                     Type = "Sugar",
                     Spread = 0.01,
                     Open = 15.68,
                     Price = 14.6742,
                     Buy = 14.6692,
                     Sell = 14.6792,
                     Change = -1.0058,
                     ChangePercent = -6.4146,
                     Volume = 4949,
                     DailyHigh = 15.70,
                     DailyLow = 14.6742,
                     YearlyHigh = 16.87,
                     YearlyLow = 11.37,
                     YearlyStart = 14.12,
                     ChangeOnYear = 3.9249
                },
                new PortfolioInfo
                {
                     Category = "Agriculture",
                     Type = "Soybean",
                     Spread = 0.01,
                     Open = 1038.00,
                     Price = 1038.6171,
                     Buy = 1038.6121,
                     Sell = 1038.6221,
                     Change = 0.6171,
                     ChangePercent = 0.0595,
                     Volume = 20356,
                     DailyHigh = 1044.00,
                     DailyLow = 1031.75,
                     YearlyHigh = 1057.00,
                     YearlyLow = 859.50,
                     YearlyStart = 958.25,
                     ChangeOnYear = 8.3869
                },
                new PortfolioInfo
                {
                     Category = "Agriculture",
                     Type = "Soy oil",
                     Spread = 0.01,
                     Open = 33.26,
                     Price = 33.7712,
                     Buy = 33.7662,
                     Sell = 33.7762,
                     Change = 0.5112,
                     ChangePercent = 1.5371,
                     Volume = 10592,
                     DailyHigh = 33.7712,
                     DailyLow = 33.06,
                     YearlyHigh = 35.43,
                     YearlyLow = 26.61,
                     YearlyStart = 31.02,
                     ChangeOnYear = 8.8692
                },
                new PortfolioInfo
                {
                     Category = "Agriculture",
                     Type = "Soy Meat",
                     Spread = 0.01,
                     Open = 342.60,
                     Price = 342.62,
                     Buy = 342.60,
                     Sell = 342.60,
                     Change = 0.02,
                     ChangePercent = 0.0058,
                     Volume = 5646,
                     DailyHigh = 345.40,
                     DailyLow = 340.30,
                     YearlyHigh = 353.40,
                     YearlyLow = 261.70,
                     YearlyStart = 307.55,
                     ChangeOnYear = 11.403
                },
                new PortfolioInfo
                {
                     Category = "Agriculture",
                     Type = "OJ Future",
                     Spread = 0.01,
                     Open = 140.60,
                     Price = 140.1893,
                     Buy = 140.1843,
                     Sell = 140.1943,
                     Change = -0.4107,
                     ChangePercent = -0.2921,
                     Volume = 7000,
                     DailyHigh = 140.1893,
                     DailyLow = 0.00,
                     YearlyHigh = 155.95,
                     YearlyLow = 113.00,
                     YearlyStart = 134.475,
                     ChangeOnYear = 4.2493
                },
                new PortfolioInfo
                {
                    Category = "Agriculture",
                    Type = "Coffee",
                    Spread = 0.01,
                    Open = 125.70,
                    Price = 125.69,
                    Buy = 125.70,
                    Sell = 125.70,
                    Change = -0.01,
                    ChangePercent = -0.008,
                    Volume = 1654,
                    DailyHigh = 125.80,
                    DailyLow = 125.00,
                    YearlyHigh = 155.75,
                    YearlyLow = 115.35,
                    YearlyStart = 135.55,
                    ChangeOnYear = -7.2741
                },
                new PortfolioInfo
                {
                     Category = "Agriculture",
                     Type = "Cocoa",
                     Spread = 0.01,
                     Open = 3076.00,
                     Price = 3076.03,
                     Buy = 3076.00,
                     Sell = 3076.00,
                     Change = 0.03,
                     ChangePercent = 0.001,
                     Volume = 978,
                     DailyHigh = 3078.00,
                     DailyLow = 3066.00,
                     YearlyHigh = 3406.00,
                     YearlyLow = 2746.00,
                     YearlyStart = 3076.00,
                     ChangeOnYear = 0.001
                },
                new PortfolioInfo
                {
                     Category = "Agriculture",
                     Type = "Rice",
                     Spread = 0.01,
                     Open = 11.245,
                     Price = 10.4154,
                     Buy = 10.4104,
                     Sell = 10.4204,
                     Change = -0.8296,
                     ChangePercent = -7.3779,
                     Volume = 220,
                     DailyHigh = 11.38,
                     DailyLow = 10.4154,
                     YearlyHigh = 14.14,
                     YearlyLow = 9.70,
                     YearlyStart = 11.92,
                     ChangeOnYear = -12.6228
                },
                new PortfolioInfo
                {
                     Category = "Agriculture",
                     Type = "Oats",
                     Spread = 0.01,
                     Open = 194.50,
                     Price = 194.2178,
                     Buy = 194.2128,
                     Sell = 194.2228,
                     Change = -0.2822,
                     ChangePercent = -0.1451,
                     Volume = 640,
                     DailyHigh = 195.75,
                     DailyLow = 194.00,
                     YearlyHigh = 241.25,
                     YearlyLow = 183.75,
                     YearlyStart = 212.50,
                     ChangeOnYear = -8.6034
                },
                new PortfolioInfo
                {
                     Category = "Agriculture",
                     Type = "Milk",
                     Spread = 0.01,
                     Open = 12.87,
                     Price = 12.86,
                     Buy = 12.87,
                     Sell = 12.87,
                     Change = -0.01,
                     ChangePercent = -0.0777,
                     Volume = 7000,
                     DailyHigh = 12.89,
                     DailyLow = 12.81,
                     YearlyHigh = 16.96,
                     YearlyLow = 12.81,
                     YearlyStart = 14.885,
                     ChangeOnYear = -13.6043
                },
                new PortfolioInfo
                {
                     Category = "Agriculture",
                     Type = "Cotton",
                     Spread = 0.01,
                     Open = 61.77,
                     Price = 61.76,
                     Buy = 61.77,
                     Sell = 61.77,
                     Change = -0.01,
                     ChangePercent = -0.0162,
                     Volume = 3612,
                     DailyHigh = 62.06,
                     DailyLow = 61.32,
                     YearlyHigh = 67.59,
                     YearlyLow = 54.33,
                     YearlyStart = 60.96,
                     ChangeOnYear = 1.3123
                },
                new PortfolioInfo
                {
                     Category = "Agriculture",
                     Type = "Lumber",
                     Spread = 0.01,
                     Open = 303.90,
                     Price = 304.5994,
                     Buy = 304.5944,
                     Sell = 304.6044,
                     Change = 0.6994,
                     ChangePercent = 0.2302,
                     Volume = 200,
                     DailyHigh = 304.5994,
                     DailyLow = 303.90,
                     YearlyHigh = 317.10,
                     YearlyLow = 236.00,
                     YearlyStart = 276.55,
                     ChangeOnYear = 10.1426
                },
                new PortfolioInfo
                {
                     Category = "Livestock",
                     Type = "LV Cattle",
                     Spread = 0.01,
                     Open = 120.725,
                     Price = 120.705,
                     Buy = 120.725,
                     Sell = 120.725,
                     Change = -0.02,
                     ChangePercent = -0.0166,
                     Volume = 4000,
                     DailyHigh = 120.725,
                     DailyLow = 120.725,
                     YearlyHigh = 147.98,
                     YearlyLow = 113.90,
                     YearlyStart = 130.94,
                     ChangeOnYear = -7.8166
                },
                new PortfolioInfo
                {
                     Category = "Livestock",
                     Type = "FD Cattle",
                     Spread = 0.01,
                     Open = 147.175,
                     Price = 148.6065,
                     Buy = 148.6015,
                     Sell = 148.6115,
                     Change = 1.4315,
                     ChangePercent = 0.9727,
                     Volume = 500,
                     DailyHigh = 148.6065,
                     DailyLow = 147.175,
                     YearlyHigh = 190.00,
                     YearlyLow = 138.10,
                     YearlyStart = 164.05,
                     ChangeOnYear = -9.4139
                },
                new PortfolioInfo
                {
                     Category = "Livestock",
                     Type = "Lean Hogs",
                     Spread = 0.01,
                     Open = 81.275,
                     Price = 81.8146,
                     Buy = 81.8096,
                     Sell = 81.8196,
                     Change = 0.5396,
                     ChangePercent = 0.664,
                     Volume = 1000,
                     DailyHigh = 81.8146,
                     DailyLow = 81.275,
                     YearlyHigh = 83.98,
                     YearlyLow = 70.25,
                     YearlyStart = 77.115,
                     ChangeOnYear = 6.0943
                },
                new PortfolioInfo
                {
                     Category = "Currencies",
                     Type = "USD IDX Future",
                     Spread = 0.02,
                     Open = 93.88,
                     Price = 93.7719,
                     Buy = 93.7619,
                     Sell = 93.7819,
                     Change = -0.1081,
                     ChangePercent = -0.1151,
                     Volume = 5788,
                     DailyHigh = 94.05,
                     DailyLow = 93.7534,
                     YearlyHigh = 100.70,
                     YearlyLow = 91.88,
                     YearlyStart = 96.29,
                     ChangeOnYear = -2.6151
                },
                new PortfolioInfo
                {
                     Category = "Currencies",
                     Type = "USD/JPY Future",
                     Spread = 0.02,
                     Open = 9275.50,
                     Price = 9277.3342,
                     Buy = 9277.3242,
                     Sell = 9277.3442,
                     Change = 1.8342,
                     ChangePercent = 0.0198,
                     Volume = 47734,
                     DailyHigh = 9277.3342,
                     DailyLow = 0.93,
                     YearlyHigh = 9483.00,
                     YearlyLow = 0.93,
                     YearlyStart = 4741.965,
                     ChangeOnYear = 95.6432
                },
                new PortfolioInfo
                {
                     Category = "Currencies",
                     Type = "GBP/USD Future",
                     Spread = 0.02,
                     Open = 1.4464,
                     Price = 1.1941,
                     Buy = 1.1841,
                     Sell = 1.2041,
                     Change = -0.2523,
                     ChangePercent = -17.4441,
                     Volume = 29450,
                     DailyHigh = 1.45,
                     DailyLow = 1.1941,
                     YearlyHigh = 1.59,
                     YearlyLow = 1.1941,
                     YearlyStart = 1.485,
                     ChangeOnYear = -19.59
                },
                new PortfolioInfo
                {
                     Category = "Currencies",
                     Type = "AUD/USD Future",
                     Spread = 0.02,
                     Open = 0.7344,
                     Price = 0.7444,
                     Buy = 0.7344,
                     Sell = 0.7344,
                     Change = 0.01,
                     ChangePercent = 1.3617,
                     Volume = 36764,
                     DailyHigh = 0.74,
                     DailyLow = 0.73,
                     YearlyHigh = 0.79,
                     YearlyLow = 0.68,
                     YearlyStart = 0.735,
                     ChangeOnYear = 1.2789
                },
                new PortfolioInfo
                {
                     Category = "Currencies",
                     Type = "USD/CAD Future",
                     Spread = 0.02,
                     Open = 0.7744,
                     Price = 0.9545,
                     Buy = 0.9445,
                     Sell = 0.9645,
                     Change = 0.1801,
                     ChangePercent = 23.2622,
                     Volume = 13669,
                     DailyHigh = 0.9545,
                     DailyLow = 0.77,
                     YearlyHigh = 0.9545,
                     YearlyLow = 0.68,
                     YearlyStart = 0.755,
                     ChangeOnYear = 26.4295
                },
                new PortfolioInfo
                {
                     Category = "Currencies",
                     Type = "USD/CHF Future",
                     Spread = 0.02,
                     Open = 1.0337,
                     Price = 1.0437,
                     Buy = 1.0337,
                     Sell = 1.0337,
                     Change = 0.01,
                     ChangePercent = 0.9674,
                     Volume = 5550,
                     DailyHigh = 1.03,
                     DailyLow = 1.03,
                     YearlyHigh = 1.11,
                     YearlyLow = 0.98,
                     YearlyStart = 1.045,
                     ChangeOnYear = -0.1244
                },
                new PortfolioInfo
                {
                     Category = "Index",
                     Type = "DOW Future",
                     Spread = 0.01,
                     Open = 17711.00,
                     Price = 17712.1515,
                     Buy = 17712.1465,
                     Sell = 17712.1565,
                     Change = 1.1515,
                     ChangePercent = 0.0065,
                     Volume = 22236,
                     DailyHigh = 17727.00,
                     DailyLow = 17642.00,
                     YearlyHigh = 18083.00,
                     YearlyLow = 15299.00,
                     YearlyStart = 16691.00,
                     ChangeOnYear = 6.118
                },
                new PortfolioInfo
                {
                     Category = "Index",
                     Type = "S&P Future",
                     Spread = 0.01,
                     Open = 2057.50,
                     Price = 2056.6018,
                     Buy = 2056.5968,
                     Sell = 2056.6068,
                     Change = -0.8982,
                     ChangePercent = -0.0437,
                     Volume = 142780,
                     DailyHigh = 2059.50,
                     DailyLow = 2049.00,
                     YearlyHigh = 2105.50,
                     YearlyLow = 1794.50,
                     YearlyStart = 1950.00,
                     ChangeOnYear = 5.4668
                },
                new PortfolioInfo
                {
                     Category = "Index",
                     Type = "NAS Future",
                     Spread = 0.01,
                     Open = 4341.25,
                     Price = 4341.28,
                     Buy = 4341.25,
                     Sell = 4341.25,
                     Change = 0.03,
                     ChangePercent = 0.0007,
                     Volume = 18259,
                     DailyHigh = 4347.00,
                     DailyLow = 4318.00,
                     YearlyHigh = 4719.75,
                     YearlyLow = 3867.75,
                     YearlyStart = 4293.75,
                     ChangeOnYear = 1.107
                },
                new PortfolioInfo
                {
                     Category = "Index",
                     Type = "S&P MID MINI",
                     Spread = 0.01,
                     Open = 1454.30,
                     Price = 1455.7812,
                     Buy = 1455.7762,
                     Sell = 1455.7862,
                     Change = 1.4812,
                     ChangePercent = 0.1018,
                     Volume = 3380,
                     DailyHigh = 1455.7812,
                     DailyLow = 1448.00,
                     YearlyHigh = 1527.30,
                     YearlyLow = 1236.00,
                     YearlyStart = 1381.65,
                     ChangeOnYear = 5.3654
                },
                new PortfolioInfo
                {
                     Category = "Index",
                     Type = "S&P 600 MINI",
                     Spread = 0.01,
                     Open = 687.90,
                     Price = 687.88,
                     Buy = 687.90,
                     Sell = 687.90,
                     Change = -0.02,
                     ChangePercent = -0.0029,
                     Volume = 3340,
                     DailyHigh = 0.00,
                     DailyLow = 0.00,
                     YearlyHigh = 620.32,
                     YearlyLow = 595.90,
                     YearlyStart = 608.11,
                     ChangeOnYear = 13.1177
                },
                new PortfolioInfo
                {
                     Category = "Interest Rate",
                     Type = "US 30YR Future",
                     Spread = 0.01,
                     Open = 164.875,
                     Price = 164.1582,
                     Buy = 164.1532,
                     Sell = 164.1632,
                     Change = -0.7168,
                     ChangePercent = -0.4347,
                     Volume = 28012,
                     DailyHigh = 165.25,
                     DailyLow = 164.0385,
                     YearlyHigh = 169.38,
                     YearlyLow = 151.47,
                     YearlyStart = 160.425,
                     ChangeOnYear = 2.3271
                },
                new PortfolioInfo
                {
                     Category = "Interest Rate",
                     Type = "US 2Y Future",
                     Spread = 0.01,
                     Open = 109.3984,
                     Price = 109.3884,
                     Buy = 109.3984,
                     Sell = 109.3984,
                     Change = -0.01,
                     ChangePercent = -0.0091,
                     Volume = 17742,
                     DailyHigh = 109.41,
                     DailyLow = 109.38,
                     YearlyHigh = 109.80,
                     YearlyLow = 108.62,
                     YearlyStart = 109.21,
                     ChangeOnYear = 0.1634
                },
                new PortfolioInfo
                {
                     Category = "Interest Rate",
                     Type = "US 10YR Future",
                     Spread = 0.01,
                     Open = 130.5625,
                     Price = 130.5825,
                     Buy = 130.5625,
                     Sell = 130.5625,
                     Change = 0.02,
                     ChangePercent = 0.0153,
                     Volume = 189310,
                     DailyHigh = 130.63,
                     DailyLow = 130.44,
                     YearlyHigh = 132.64,
                     YearlyLow = 125.48,
                     YearlyStart = 129.06,
                     ChangeOnYear = 1.1797
                },
                new PortfolioInfo
                {
                     Category = "Interest Rate",
                     Type = "Euro$ 3M",
                     Spread = 0.01,
                     Open = 99.18,
                     Price = 99.17,
                     Buy = 99.18,
                     Sell = 99.18,
                     Change = -0.01,
                     ChangePercent = -0.0101,
                     Volume = 29509,
                     DailyHigh = 99.18,
                     DailyLow = 99.17,
                     YearlyHigh = 99.38,
                     YearlyLow = 98.41,
                     YearlyStart = 98.895,
                     ChangeOnYear = 0.2781
                }

            };

            return data;
        }
        #endregion

        public static List<PortfolioInfo> UpdateAllPrices(List<PortfolioInfo> data)
        {
            var updateItems = new List<PortfolioInfo>();
            foreach (var item in data)
            {
                var changeItem = item.Clone();
                RandomizeDataValues(changeItem as PortfolioInfo);
                updateItems.Add(changeItem);
            }
            return updateItems;
        }

        public static List<PortfolioInfo> UpdateRandomPrices(List<PortfolioInfo> data)
        {
            var updateItems = new List<PortfolioInfo>();
            foreach (var item in data)
            {
                updateItems.Add(item.Clone());
            }
            var updatedCount = 0;
            var start = (int)Math.Round(random.NextDouble() * 10);
            var step = (int)Math.Round(random.NextDouble() * 10);
            for (var i = start; i < data.Count; i += step)
            {
                var item = data[i].Clone();
                RandomizeDataValues(item as PortfolioInfo);
                updateItems[i] = item;
                updatedCount++;
            }
            return data;
        }

        public static void RandomizeDataValues(PortfolioInfo item)
        {
            var priceChange = DataRandomizer.GetPriceChange(item.Price);
            item.Change = priceChange.ByAmount;
            item.Price = priceChange.New;
            item.ChangePercent = priceChange.Percentage;
        }
    }

    public static class DataRandomizer
    {
        public static Random random = new Random();

        public static DateTime GetDate()
        {
            var year = DateTime.Now.Year;
            var month = GetInteger(10, 12);
            var day = GetInteger(10, 25);
            return new DateTime(year, month, day);
        }

        public static object GetItem(IList list)
        {
            var index = GetInteger(0, list.Count - 1);
            return list[index];
        }

        public static double GetNumber(double min, double max)
        {
            return Math.Round(min + (random.NextDouble() * (max - min)));
        }

        public static int GetInteger(double min, double max)
        {
            return (int)GetNumber(min, max);
        }

        public static PriceChange GetPriceChange(double oldPrice)
        {
            var rnd = float.Parse(random.NextDouble().ToString("N2"));
            var volatility = 2;
            var changePercent = 2 * volatility * rnd;
            if (changePercent > volatility)
            {
                changePercent -= (2 * volatility);
            }

            var changeAmount = oldPrice * (changePercent / 100);
            var newPrice = oldPrice + changeAmount;

            var result = new PriceChange();
            result.ByAmount = changeAmount;
            result.New = Math.Round(newPrice * 100) / 100;
            result.Old = Math.Round(oldPrice * 100) / 100;
            result.Percentage = Math.Round(changePercent * 100) / 100;

            return result;
        }
    }

    public class PriceChange {
        public double New { get; set; }
        public double Old { get; set; }
        public double ByAmount { get; set; }
        public double Percentage { get; set; }
    }

    public class PortfolioInfo
    {
        public PortfolioInfo Clone()
        {
            return (PortfolioInfo)this.MemberwiseClone();
        }
        public double PriceHeat { get; set; }

        public string IndGroup { get; set; }
        public string IndSector { get; set; }
        public string IndCategory { get; set; }
        public string Fitch { get; set; }
        public string Collateral { get; set; }
        public string Transactions { get; set; }
        public double CPN { get; set; }
        public double Spread { get; set; }
        public double KRD_3YR { get; set; }
        public double KRD_5YR { get; set; }
        public double KRD_1YR { get; set; }
        public DateTime Maturity { get; set; }

        public int ID { get; set; }
        public string Settlement { get; set; }
        public string Category { get; set; }
        public string Contract { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public string Type { get; set; }

        public double Open { get; set; }
        public double Price { get; set; }
        public double Buy { get; set; }
        public string Rating { get; set; }
        public string Region { get; set; }
        public string Risk { get; set; }
        public double Sell { get; set; }
        public string Sector { get; set; }
        public string Security { get; set; }
        public string Issuer { get; set; }
        public double Change { get; set; }
        public double ChangePercent { get; set; }
        public double Volume { get; set; }

        public double DailyHigh { get; set; }
        public double DailyLow { get; set; }

        public double YearlyHigh { get; set; }
        public double YearlyLow { get; set; }
        public double YearlyStart { get; set; }
        public double ChangeOnYear { get; set; }
    }

    public class UpdateResponse
    {
        public List<object> Data { get; set; }
        public int RecordsUpdated { get; set; }
    }

}