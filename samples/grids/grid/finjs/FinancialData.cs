﻿using System; 
using System.Collections.Generic; 
using System.Linq; 

namespace Infragistics.Samples
{
    public class FinancialLiveStock
    {
        public string indGrou { get; set; }
        public string indSect { get; set; }
        public string? indSubg { get; set; }
        public string? secType { get; set; }
        public string? cpnTyp { get; set; }
        public string? issuerN { get; set; }
        public string? moodys { get; set; }
        public string? fitch { get; set; }
        public string? dbrs { get; set; }
        public string? collatT { get; set; }
        public string? curncy { get; set; }
        public string? security { get; set; }
        public string? sector { get; set; }
        public string? cusip { get; set; }
        public string? ticker { get; set; }
        public string? cpn { get; set; }
        public string? maturity { get; set; }
        public double? krD_3YR { get; set; }
        public string? RISK_COUNTRY { get; set; }
        public double? MUNI_SECTOR { get; set; }
        public double? zV_SPREAD { get; set; }
        public double? kRD_5YR { get; set; }
        public double? kRD_1YR { get; set; }
        public string? PD_WALA { get; set; }
        public int id { get; set; }
        public string category { get; set; }
        public string type { get; set; }
        public double spread { get; set; }
        public double open { get; set; }
        public double price { get; set; }
        public double buy { get; set; }
        public double sell { get; set; }
        public double change { get; set; }
        public double changeP { get; set; }
        public double volume { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double annualHigh { get; set; }
        public double annualLow { get; set; }
        public double annualStart { get; set; }
        public double annualChange { get; set; }

        public string? region { get; set; }
        public string? country { get; set; }
        public string? settlement { get; set; }
        public string? contract { get; set; }
        public DateTime? lastUpdated { get; set; }
        public double? openDiff { get; set; }
        public double? buyDiff { get; set; }
        public double? sellDiff { get; set; }
        public double? annualStartDiff { get; set; }
        public double? annualhighiff { get; set; }
        public double? annuallowiff { get; set; }
        public double? highDiff { get; set; }
        public double? lowDiff { get; set; }
        public double changePercent { get; set; }

        public FinancialLiveStock Clone()
        {
            return this.MemberwiseClone() as FinancialLiveStock;
        }
    }

    public class FinancialRegion
    {
        public string Name { get; set; }
        public List<string> Countries { get; set; }
    }

    public class FinancialLiveData
    {
        public static List<string> Settlement = new List<string>() { "Deliverable", "Cash" };
        public static List<string> Contract = new List<string>() { "Forwards", "Futures", "Options", "Swap", "CFD" };
        public static List<FinancialRegion> Regions = new List<FinancialRegion> { new FinancialRegion() {
            Name = "North America",
            Countries= new List<string>() { "Canada", "US", "Mexico"}
        },
            new FinancialRegion() {
            Name = "Middle East",
            Countries= new List<string>() { "Turkey", "Iraq", "Saudi Arabia", "Syria", "UAE", "Israel", "Jordan", "Lebanon", "Oman", "Kuwait", "Qatar", "Bahrain", "Iran" }
        },
            new FinancialRegion() {
            Name = "Europe",
            Countries= new List<string>() { "Russia", "Germany", "France", "UK", "Italy", "Spain", "Poland", "Romania", "Netherlands", "Belgium", "Greece", "Portugal", "Czech Republic", "Hungary", "Sweden", "Austria", "Switzerland", "Bulgaria", "Denmark", "Finland", "Slovakia", "Norway", "Ireland", "Croatia", "Slovenia", "Estonia", "Iceland" }
        },
            new FinancialRegion() {
            Name = "Africa",
            Countries= new List<string>() { "Nigeria", "Ethiopia", "Egypt", "South Africa", "Algeria", "Morocco", "Cameroon", "Niger", "Senegal", "Tunisia", "Libya" }
        },
            new FinancialRegion() {
            Name = "Asia Pacific",
            Countries= new List<string>() { "Afghanistan", "Australia", "Azerbaijan", "China", "Hong Kong", "India", "Indonesia", "Japan", "Malaysia", "New Zealand", "Pakistan", "Philippines", "Korea", "Singapore", "Taiwan", "Thailand" }
        },
            new FinancialRegion() {
            Name = "South America",
            Countries= new List<string>() { "Argentina", "Bolivia", "Brazil", "Chile", "Colombia", "Ecuador", "Guyana", "Paraguay", "Peru", "Suriname", "Uruguay", "Venezuela" }
        }};

        public static DateTime RandomDate(Random gen)
        {
            var start = new DateTime(2000, 1, 1);
            var range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));
        }

        public static List<FinancialLiveStock> Generate(int count)
        {
            var liveData = new List<FinancialLiveStock>();
            var mockData = MockData();
        
            var random = new Random();
            for (int i = 0; i < count; i++)
            {
                var region = Regions.ElementAt(random.Next(0, Regions.Count - 1));
                int rand = random.Next(0, mockData.Count - 1);
                var randStock = mockData[rand].Clone();
            
                randStock.settlement = Settlement.ElementAt(random.Next(0, 1));
                randStock.contract = Contract.ElementAt(random.Next(0, Contract.Count - 1));
                randStock.lastUpdated = RandomDate(random);
                randStock.openDiff = (((randStock.open - randStock.price) / randStock.price) * 100) * 150;
                randStock.buyDiff = (((randStock.buy - randStock.price) / randStock.price) * 100) * 150;
                randStock.sellDiff = (((randStock.sell - randStock.price) / randStock.price) * 100) * 150;
                randStock.annualStartDiff = (((randStock.annualStart - randStock.price) / randStock.price) * 100) * 150;
                randStock.annualhighiff = (((randStock.annualHigh - randStock.price) / randStock.price) * 100) * 150;
                randStock.annuallowiff = (((randStock.annualLow - randStock.price) / randStock.price) * 100) * 150;
                randStock.highDiff = (((randStock.high - randStock.price) / randStock.price) * 100) * 150;
                randStock.lowDiff = (((randStock.low - randStock.price) / randStock.price) * 100) * 150;

                randStock.region = region.Name;
                randStock.country = region.Countries.ElementAt(random.Next(0, region.Countries.Count - 1));
                randStock.indGrou = "Airlines";
                randStock.indSect = "Consumer, Cyclical";
                randStock.indSubg = "Airlines";
                randStock.secType = "PUBLIC";
                randStock.cpnTyp = "FIXED";
                randStock.issuerN = "AMERICAN AIRLINES GROUP";
                randStock.moodys = "WR";
                randStock.fitch = "N.A.";
                randStock.dbrs = "N.A.";
                randStock.collatT = "NEW MONEY";
                randStock.curncy = "USD";
                randStock.security = "001765866 Pfd";
                randStock.sector = "Pfd";
                randStock.cusip = "1765866";
                randStock.ticker = "AAL";
                randStock.cpn = "7.875";
                randStock.maturity = "7/13/1939";
                randStock.krD_3YR = 0.00006;
                randStock.RISK_COUNTRY = "";
                randStock.MUNI_SECTOR = 1;
                randStock.zV_SPREAD = 28.302;
                randStock.kRD_5YR = 0;
                randStock.kRD_1YR = -0.00187;
                randStock.PD_WALA = null;
                RandomizeStockPirce(randStock, random);
                randStock.id = i;
                liveData.Add(randStock);
            }
            return liveData;
        }

        public static List<FinancialLiveStock> UpdatePrices(List<FinancialLiveStock> originalData) {
            var random = new Random();
            var newFinancialLiveStocks = new List<FinancialLiveStock>();
            for (int i = 0; i < originalData.Count; i++)
            {
                FinancialLiveStock data = originalData.ElementAt(i).Clone();
                RandomizeStockPirce(data, random);
                newFinancialLiveStocks.Add(data);
            }
            return newFinancialLiveStocks;
        }

        public static void RandomizeStockPirce(FinancialLiveStock stock, Random rand)
        {
            var res = GeneratePrice(stock.price, rand);
            stock.change = res.price - stock.price;
            stock.price = res.price;
            stock.changeP = res.changePercent;
        }

        public static FinancialLiveStock GeneratePrice(double oldPrice, Random rand)
        {
            FinancialLiveStock FinancialLiveStock = new FinancialLiveStock();
            double rnd = rand.NextDouble();
            int volatility = 2;
            double changePercent = 2 * volatility * rnd;
            if (changePercent > volatility)
            {
                changePercent -= (2 * volatility);
            }

            double changeAmount = oldPrice * (changePercent / 100);
            double newPrice = oldPrice + changeAmount;
            FinancialLiveStock.price = newPrice;
            FinancialLiveStock.changePercent = changePercent;
            return FinancialLiveStock;
        }

        public static List<FinancialLiveStock> MockData()
        {
            List<FinancialLiveStock> data = new List<FinancialLiveStock>();

            data.Add(new FinancialLiveStock
            {
                category = "Metals",
                type = "Gold",
                spread = 0.01,
                open = 1281.10,
                price = 1280.7317,
                buy = 1280.7267,
                sell = 1280.7367,
                change = -0.3683,
                changePercent = -0.0287,
                volume = 48387,
                high = 1289.50,
                low = 1279.10,
                annualHigh = 1306,
                annualLow = 1047.20,
                annualStart = 1176.60,
                annualChange = 8.8502
            });
            data.Add(new FinancialLiveStock
            {
                category = "Metals",
                type = "Silver",
              spread = 0.01,
                open = 17.43,
                price = 17.42,
                buy = 17.43,
                sell = 17.43,
                change = -0.01,
                changePercent = -0.0574,
                volume = 11720,
                high = 17.51,
                low = 17.37,
                annualHigh = 18.06,
                annualLow = 13.73,
                annualStart = 15.895,
                annualChange = 9.5942
            });
            data.Add(new FinancialLiveStock
            {
                category = "Metals",
                type = "Copper",
              spread = 0.02,
                open = 2.123,
                price = 2.113,
                buy = 2.123,
                sell = 2.123,
                change = -0.01,
                changePercent = -0.471,
                volume = 28819,
                high = 2.16,
                low = 2.11,
                annualHigh = 2.94,
                annualLow = 1.96,
                annualStart = 2.45,
                annualChange = -13.7551
            });
            data.Add(new FinancialLiveStock
            {
                category = "Metals",
                type = "Platinum",
              spread = 0.01,
                open = 1071.60,
                price = 1071.0993,
                buy = 1071.0943,
                sell = 1071.1043,
                change = -0.5007,
                changePercent = -0.0467,
                volume = 3039,
                high = 1081.20,
                low = 1070.50,
                annualHigh = 1120.60,
                annualLow = 812.40,
                annualStart = 966.50,
                annualChange = 10.8225
            });
            data.Add(new FinancialLiveStock
            {
                category = "Metals",
                type = "Palladium",
              spread = 0.01,
                open = 600.55,
                price = 601.0005,
                buy = 600.9955,
                sell = 601.0055,
                change = 0.4505,
                changePercent = 0.075,
                volume = 651,
                high = 607.20,
                low = 598.40,
                annualHigh = 690,
                annualLow = 458.6,
                annualStart = 574.3,
                annualChange = 4.6492
            });
            data.Add(new FinancialLiveStock
            {
                category = "Fuel",
                type = "Oil",
                spread = 0.015,
                open = 45.54,
                price = 45.7899,
                buy = 45.7824,
                sell = 45.7974,
                change = 0.2499,
                changePercent = 0.5487,
                volume = 107196,
                high = 45.94,
                low = 45.00,
                annualHigh = 65.28,
                annualLow = 30.79,
                annualStart = 48.035,
                annualChange = -4.6739
            });
            data.Add(new FinancialLiveStock
            {
                category = "Fuel",
                type = "Natural Gas",
                spread = 0.02,
                open = 2.094,
                price = 2.104,
                buy = 2.094,
                sell = 2.094,
                change = 0.01,
                changePercent = 0.4776,
                volume = 2783,
                high = 2.11,
                low = 2.09,
                annualHigh = 3.20,
                annualLow = 1.84,
                annualStart = 2.52,
                annualChange = -16.5079
            });
            data.Add(new FinancialLiveStock
            {
                category = "Fuel",
                type = "Diesel",
                spread = 0.015,
                open = 1.3474,
                price = 1.3574,
                buy = 1.3474,
                sell = 1.3474,
                change = 0.01,
                changePercent = 0.7422,
                volume = 2971,
                high = 1.36,
                low = 1.34,
                annualHigh = 2.11,
                annualLow = 0.92,
                annualStart = 1.515,
                annualChange = -10.4026
            });
            data.Add(new FinancialLiveStock
            {
                category = "Fuel",
                type = "Ethanol",
                spread = 0.01,
                open = 1.512,
                price = 2.7538,
                buy = 2.7488,
                sell = 2.7588,
                change = 1.2418,
                changePercent = 82.1323,
                volume = 14,
                high = 2.7538,
                low = 1.1168,
                annualHigh = 2.7538,
                annualLow = 1.1168,
                annualStart = 1.475,
                annualChange = 86.7011
            });
            data.Add(new FinancialLiveStock
            {
                category = "Fuel",
                type = "Uranium",
                spread = 0.02,
                open = 27.55,
                price = 27.58,
                buy = 27.55,
                sell = 27.55,
                change = 0.03,
                changePercent = 0.1089,
                volume = 12,
                high = 27.55,
                low = 27.55,
                annualHigh = 29.32,
                annualLow = 21.28,
                annualStart = 25.30,
                annualChange = 9.0119
            });
            data.Add(new FinancialLiveStock
            {
                category = "Fuel",
                type = "Coal",
              spread = 0.015,
                open = 0.4363,
                price = 0.4163,
                buy = 0.4363,
                sell = 0.4363,
                change = -0.02,
                changePercent = -4.584,
                volume = 3,
                high = 0.4363,
                low = 0.4363,
                annualHigh = 0.4841,
                annualLow = 0.3954,
                annualStart = 0.4398,
                annualChange = -5.3326
            });
            data.Add(new FinancialLiveStock
            {
                category = "Agriculture",
              type = "Wheat",
                spread = 0.01,
                open = 465.50,
                price = 465.52,
                buy = 465.50,
                sell = 465.50,
                change = 0.02,
                changePercent = 0.0043,
                volume = 4318,
                high = 467.00,
                low = 463.25,
                annualHigh = 628.50,
                annualLow = 449.50,
                annualStart = 539.00,
                annualChange = -13.6327
            });
            data.Add(new FinancialLiveStock
            {
                category = "Agriculture",
              type = "Corn",
              spread = 0.01,
                open = 379.50,
                price = 379.8026,
                buy = 379.7976,
                sell = 379.8076,
                change = 0.3026,
                changePercent = 0.0797,
                volume = 11266,
                high = 381.00,
                low = 377.75,
                annualHigh = 471.25,
                annualLow = 351.25,
                annualStart = 411.25,
                annualChange = -7.6468
            });
            data.Add(new FinancialLiveStock
            {
                category = "Agriculture",
              type = "Sugar",
              spread = 0.01,
                open = 15.68,
                price = 14.6742,
                buy = 14.6692,
                sell = 14.6792,
                change = -1.0058,
                changePercent = -6.4146,
                volume = 4949,
                high = 15.70,
                low = 14.6742,
                annualHigh = 16.87,
                annualLow = 11.37,
                annualStart = 14.12,
                annualChange = 3.9249
            });
            data.Add(new FinancialLiveStock
            {
                category = "Agriculture",
              type = "Soybean",
              spread = 0.01,
                open = 1038.00,
                price = 1038.6171,
                buy = 1038.6121,
                sell = 1038.6221,
                change = 0.6171,
                changePercent = 0.0595,
                volume = 20356,
                high = 1044.00,
                low = 1031.75,
                annualHigh = 1057.00,
                annualLow = 859.50,
                annualStart = 958.25,
                annualChange = 8.3869
            });
            data.Add(new FinancialLiveStock
            {
                category = "Agriculture",
              type = "Soy oil",
              spread = 0.01,
                open = 33.26,
                price = 33.7712,
                buy = 33.7662,
                sell = 33.7762,
                change = 0.5112,
                changePercent = 1.5371,
                volume = 10592,
                high = 33.7712,
                low = 33.06,
                annualHigh = 35.43,
                annualLow = 26.61,
                annualStart = 31.02,
                annualChange = 8.8692
            });
            data.Add(new FinancialLiveStock
            {
                category = "Agriculture",
              type = "Soy Meat",
              spread = 0.01,
                open = 342.60,
                price = 342.62,
                buy = 342.60,
                sell = 342.60,
                change = 0.02,
                changePercent = 0.0058,
                volume = 5646,
                high = 345.40,
                low = 340.30,
                annualHigh = 353.40,
                annualLow = 261.70,
                annualStart = 307.55,
                annualChange = 11.403
            });
            data.Add(new FinancialLiveStock
            {
                category = "Agriculture",
              type = "OJ Future",
                spread = 0.01,
                open = 140.60,
                price = 140.1893,
                buy = 140.1843,
                sell = 140.1943,
                change = -0.4107,
                changePercent = -0.2921,
                volume = 7,
                high = 140.1893,
                low = 0.00,
                annualHigh = 155.95,
                annualLow = 113.00,
                annualStart = 134.475,
                annualChange = 4.2493
            });
            data.Add(new FinancialLiveStock
            {
                category = "Agriculture",
              type = "Coffee",
              spread = 0.01,
                open = 125.70,
                price = 125.69,
                buy = 125.70,
                sell = 125.70,
                change = -0.01,
                changePercent = -0.008,
                volume = 1654,
                high = 125.80,
                low = 125.00,
                annualHigh = 155.75,
                annualLow = 115.35,
                annualStart = 135.55,
                annualChange = -7.2741
            });
            data.Add(new FinancialLiveStock
            {
                category = "Agriculture",
              type = "Cocoa",
              spread = 0.01,
                open = 3076.00,
                price = 3076.03,
                buy = 3076.00,
                sell = 3076.00,
                change = 0.03,
                changePercent = 0.001,
                volume = 978,
                high = 3078.00,
                low = 3066.00,
                annualHigh = 3406.00,
                annualLow = 2746.00,
                annualStart = 3076.00,
                annualChange = 0.001
            });
            data.Add(new FinancialLiveStock
            {
                category = "Agriculture",
              type = "Rice",
                spread = 0.01,
                open = 11.245,
                price = 10.4154,
                buy = 10.4104,
                sell = 10.4204,
                change = -0.8296,
                changePercent = -7.3779,
                volume = 220,
                high = 11.38,
                low = 10.4154,
                annualHigh = 14.14,
                annualLow = 9.70,
                annualStart = 11.92,
                annualChange = -12.6228
            });
            data.Add(new FinancialLiveStock
            {
                category = "Agriculture",
              type = "Oats",
                spread = 0.01,
                open = 194.50,
                price = 194.2178,
                buy = 194.2128,
                sell = 194.2228,
                change = -0.2822,
                changePercent = -0.1451,
                volume = 64,
                high = 195.75,
                low = 194.00,
                annualHigh = 241.25,
                annualLow = 183.75,
                annualStart = 212.50,
                annualChange = -8.6034
            });
            data.Add(new FinancialLiveStock
            {
                category = "Agriculture",
              type = "Milk",
                spread = 0.01,
                open = 12.87,
                price = 12.86,
                buy = 12.87,
                sell = 12.87,
                change = -0.01,
                changePercent = -0.0777,
                volume = 7,
                high = 12.89,
                low = 12.81,
                annualHigh = 16.96,
                annualLow = 12.81,
                annualStart = 14.885,
                annualChange = -13.6043
            });
            data.Add(new FinancialLiveStock
            {
                category = "Agriculture",
              type = "Cotton",
              spread = 0.01,
                open = 61.77,
                price = 61.76,
                buy = 61.77,
                sell = 61.77,
                change = -0.01,
                changePercent = -0.0162,
                volume = 3612,
                high = 62.06,
                low = 61.32,
                annualHigh = 67.59,
                annualLow = 54.33,
                annualStart = 60.96,
                annualChange = 1.3123
            });
            data.Add(new FinancialLiveStock
            {
                category = "Agriculture",
              type = "Lumber",
              spread = 0.01,
                open = 303.90,
                price = 304.5994,
                buy = 304.5944,
                sell = 304.6044,
                change = 0.6994,
                changePercent = 0.2302,
                volume = 2,
                high = 304.5994,
                low = 303.90,
                annualHigh = 317.10,
                annualLow = 236.00,
                annualStart = 276.55,
                annualChange = 10.1426
            });
            data.Add(new FinancialLiveStock
            {
                category = "LiveFinancialLiveStock",
              type = "LV Cattle",
              spread = 0.01,
                open = 120.725,
                price = 120.705,
                buy = 120.725,
                sell = 120.725,
                change = -0.02,
                changePercent = -0.0166,
                volume = 4,
                high = 120.725,
                low = 120.725,
                annualHigh = 147.98,
                annualLow = 113.90,
                annualStart = 130.94,
                annualChange = -7.8166
            });
            data.Add(new FinancialLiveStock
            {
                category = "LiveFinancialLiveStock",
              type = "FD Cattle",
                spread = 0.01,
                open = 147.175,
                price = 148.6065,
                buy = 148.6015,
                sell = 148.6115,
                change = 1.4315,
                changePercent = 0.9727,
                volume = 5,
                high = 148.6065,
                low = 147.175,
                annualHigh = 190.00,
                annualLow = 138.10,
                annualStart = 164.05,
                annualChange = -9.4139
            });
            data.Add(new FinancialLiveStock
            {
                category = "LiveFinancialLiveStock",
              type = "Lean Hogs",
              spread = 0.01,
                open = 81.275,
                price = 81.8146,
                buy = 81.8096,
                sell = 81.8196,
                change = 0.5396,
                changePercent = 0.664,
                volume = 1,
                high = 81.8146,
                low = 81.275,
                annualHigh = 83.98,
                annualLow = 70.25,
                annualStart = 77.115,
                annualChange = 6.0943
            });
            data.Add(new FinancialLiveStock
            {
                category = "Currencies",
              type = "BTC / USD",
              spread = 0.06,
                open = 93.88,
                price = 21000.7719,
                buy = 21200.7619,
                sell = 21400.7819,
                change = -1000.1081,
                changePercent = -2.1151,
                volume = 5788000,
                high = 22400.05,
                low = 20100.7534,
                annualHigh = 62400.70,
                annualLow = 15100.88,
                annualStart = 21200.29,
                annualChange = -20.6151
            });
            data.Add(new FinancialLiveStock
            {
                category = "Currencies",
              type = "USD/JPY",
                spread = 0.02,
                open = 9275.50,
                price = 9277.3342,
                buy = 9277.3242,
                sell = 9277.3442,
                change = 1.8342,
                changePercent = 0.0198,
                volume = 47734,
                high = 9277.3342,
                low = 0.93,
                annualHigh = 9483.00,
                annualLow = 0.93,
                annualStart = 4741.965,
                annualChange = 95.6432
            });
            data.Add(new FinancialLiveStock
            {
                category = "Currencies",
              type = "GBP/USD",
                spread = 0.02,
                open = 1.4464,
                price = 1.1941,
                buy = 1.1841,
                sell = 1.2041,
                change = -0.2523,
                changePercent = -17.4441,
                volume = 29450,
                high = 1.45,
                low = 1.1941,
                annualHigh = 1.59,
                annualLow = 1.1941,
                annualStart = 1.485,
                annualChange = -19.59
            });
            data.Add(new FinancialLiveStock
            {
                category = "Currencies",
              type = "AUD / USD",
              spread = 0.02,
                open = 0.7344,
                price = 0.7444,
                buy = 0.7344,
                sell = 0.7344,
                change = 0.01,
                changePercent = 1.3617,
                volume = 36764,
                high = 0.74,
                low = 0.73,
                annualHigh = 0.79,
                annualLow = 0.68,
                annualStart = 0.735,
                annualChange = 1.2789
            });
            data.Add(new FinancialLiveStock
            {
                category = "Currencies",
              type = "USD/CAD",
                spread = 0.02,
                open = 0.7744,
                price = 0.9545,
                buy = 0.9445,
                sell = 0.9645,
                change = 0.1801,
                changePercent = 23.2622,
                volume = 13669,
                high = 0.9545,
                low = 0.77,
                annualHigh = 0.9545,
                annualLow = 0.68,
                annualStart = 0.755,
                annualChange = 26.4295
            });
            data.Add(new FinancialLiveStock
            {
                category = "Currencies",
              type = "USD/CHF",
                spread = 0.02,
                open = 1.0337,
                price = 1.0437,
                buy = 1.0337,
                sell = 1.0337,
                change = 0.01,
                changePercent = 0.9674,
                volume = 5550,
                high = 1.03,
                low = 1.03,
                annualHigh = 1.11,
                annualLow = 0.98,
                annualStart = 1.045,
                annualChange = -0.1244
            });
            data.Add(new FinancialLiveStock
            {
                category = "Index",
                type = "DOW Future",
                spread = 0.01,
                open = 17711.00,
                price = 17712.1515,
                buy = 17712.1465,
                sell = 17712.1565,
                change = 1.1515,
                changePercent = 0.0065,
                volume = 22236,
                high = 17727.00,
                low = 17642.00,
                annualHigh = 18083.00,
                annualLow = 15299.00,
                annualStart = 16691.00,
                annualChange = 6.118
            });
            data.Add(new FinancialLiveStock
            {
                category = "Index",
                type = "S & P Future",
              spread = 0.01,
                open = 2057.50,
                price = 2056.6018,
                buy = 2056.5968,
                sell = 2056.6068,
                change = -0.8982,
                changePercent = -0.0437,
                volume = 142780,
                high = 2059.50,
                low = 2049.00,
                annualHigh = 2105.50,
                annualLow = 1794.50,
                annualStart = 1950.00,
                annualChange = 5.4668
            });
            data.Add(new FinancialLiveStock
            {
                category = "Index",
                type = "NAS Future",
                spread = 0.01,
                open = 4341.25,
                price = 4341.28,
                buy = 4341.25,
                sell = 4341.25,
                change = 0.03,
                changePercent = 0.0007,
                volume = 18259,
                high = 4347.00,
                low = 4318.00,
                annualHigh = 4719.75,
                annualLow = 3867.75,
                annualStart = 4293.75,
                annualChange = 1.107
            });
            data.Add(new FinancialLiveStock
            {
                category = "Index",
                type = "S & P MID MINI",
              spread = 0.01,
                open = 1454.30,
                price = 1455.7812,
                buy = 1455.7762,
                sell = 1455.7862,
                change = 1.4812,
                changePercent = 0.1018,
                volume = 338,
                high = 1455.7812,
                low = 1448.00,
                annualHigh = 1527.30,
                annualLow = 1236.00,
                annualStart = 1381.65,
                annualChange = 5.3654
            });
            data.Add(new FinancialLiveStock
            {
                category = "Index",
                type = "S & P 600 MINI",
              spread = 0.01,
                open = 687.90,
                price = 687.88,
                buy = 687.90,
                sell = 687.90,
                change = -0.02,
                changePercent = -0.0029,
                volume = 0,
                high = 0.00,
                low = 0.00,
                annualHigh = 620.32,
                annualLow = 595.90,
                annualStart = 608.11,
                annualChange = 13.1177
            });
            data.Add(new FinancialLiveStock
            {
                category = "Interest Rate",
                type = "US 30YR Future",
                spread = 0.01,
                open = 164.875,
                price = 164.1582,
                buy = 164.1532,
                sell = 164.1632,
                change = -0.7168,
                changePercent = -0.4347,
                volume = 28012,
                high = 165.25,
                low = 164.0385,
                annualHigh = 169.38,
                annualLow = 151.47,
                annualStart = 160.425,
                annualChange = 2.3271
            });
            data.Add(new FinancialLiveStock
            {
                category = "Interest Rate",
                type = "US 2Y Future",
                spread = 0.01,
                open = 109.3984,
                price = 109.3884,
                buy = 109.3984,
                sell = 109.3984,
                change = -0.01,
                changePercent = -0.0091,
                volume = 17742,
                high = 109.41,
                low = 109.38,
                annualHigh = 109.80,
                annualLow = 108.62,
                annualStart = 109.21,
                annualChange = 0.1634
            });
            data.Add(new FinancialLiveStock
            {
                category = "Interest Rate",
                type = "US 10YR Future",
                spread = 0.01,
                open = 130.5625,
                price = 130.5825,
                buy = 130.5625,
                sell = 130.5625,
                change = 0.02,
                changePercent = 0.0153,
                volume = 189310,
                high = 130.63,
                low = 130.44,
                annualHigh = 132.64,
                annualLow = 125.48,
                annualStart = 129.06,
                annualChange = 1.1797
            });
            data.Add(new FinancialLiveStock
            {
                category = "Interest Rate",
                type = "Euro$ 3M",
                spread = 0.01,
                open = 99.18,
                price = 99.17,
                buy = 99.18,
                sell = 99.18,
                change = -0.01,
                changePercent = -0.0101,
                volume = 29509,
                high = 99.18,
                low = 99.17,
                annualHigh = 99.38,
                annualLow = 98.41,
                annualStart = 98.895,
                annualChange = 0.2781
            });

            FinancialLiveStock randStock = new FinancialLiveStock(); // mockData[rand].Clone();
            return data;
        }
         
    }
}
