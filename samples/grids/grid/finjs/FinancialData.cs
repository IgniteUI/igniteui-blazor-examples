using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;

namespace Infragistics.Samples
{
    public class Stock
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
        public double openPrice { get; set; }
        public double price { get; set; }
        public double buy { get; set; }
        public double sell { get; set; }
        public double change { get; set; }
        public double changeP { get; set; }
        public double volume { get; set; }
        public double highD { get; set; }
        public double lowD { get; set; }
        public double highY { get; set; }
        public double lowY { get; set; }
        public double startY { get; set; }
        public double changeOnYear { get; set; }

        public string? region { get; set; }
        public string? country { get; set; }
        public string? settlement { get; set; }
        public string? contract { get; set; }
        public DateTime? lastUpdated { get; set; }
        public double? openPriceDiff { get; set; }
        public double? buyDiff { get; set; }
        public double? sellDiff { get; set; }
        public double? startYDiff { get; set; }
        public double? highYDiff { get; set; }
        public double? lowYDiff { get; set; }
        public double? highDDiff { get; set; }
        public double? lowDDiff { get; set; }
        public double changePercent { get; set; }

        public Stock Clone()
        {
            return this.MemberwiseClone() as Stock;
        }
    }

    public class Region
    {
        public string Name { get; set; }
        public List<string> Countries { get; set; }
    }



    public class FinancialData
    {
        public List<string> Settlement = new List<string>() { "Deliverable", "Cash" };
        public List<string> Contract = new List<string>() { "Forwards", "Futures", "Options", "Swap", "CFD" };
        public List<Region> Regions = new List<Region> { new Region() {
            Name = "North America",
            Countries= new List<string>() { "Canada", "US", "Mexico"}
        },
            new Region() {
            Name = "Middle East",
            Countries= new List<string>() { "Turkey", "Iraq", "Saudi Arabia", "Syria", "UAE", "Israel", "Jordan", "Lebanon", "Oman", "Kuwait", "Qatar", "Bahrain", "Iran" }
        },
            new Region() {
            Name = "Europe",
            Countries= new List<string>() { "Russia", "Germany", "France", "UK", "Italy", "Spain", "Poland", "Romania", "Netherlands", "Belgium", "Greece", "Portugal", "Czech Republic", "Hungary", "Sweden", "Austria", "Switzerland", "Bulgaria", "Denmark", "Finland", "Slovakia", "Norway", "Ireland", "Croatia", "Slovenia", "Estonia", "Iceland" }
        },
            new Region() {
            Name = "Africa",
            Countries= new List<string>() { "Nigeria", "Ethiopia", "Egypt", "South Africa", "Algeria", "Morocco", "Cameroon", "Niger", "Senegal", "Tunisia", "Libya" }
        },
            new Region() {
            Name = "Asia Pacific",
            Countries= new List<string>() { "Afghanistan", "Australia", "Azerbaijan", "China", "Hong Kong", "India", "Indonesia", "Japan", "Malaysia", "New Zealand", "Pakistan", "Philippines", "Korea", "Singapore", "Taiwan", "Thailand" }
        },
            new Region() {
            Name = "South America",
            Countries= new List<string>() { "Argentina", "Bolivia", "Brazil", "Chile", "Colombia", "Ecuador", "Guyana", "Paraguay", "Peru", "Suriname", "Uruguay", "Venezuela" }
        }};
        public DateTime RandomDate(Random gen)
        {
            var start = new DateTime(2000, 1, 1);
            var range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));
        }

        public List<Stock> GenerateData(int count)
        {
            List<Stock> stocks = new List<Stock>();
            var mockData = MockData();
            var random = new Random();
            for (int i = 0; i < count; i++)
            {

                int rand = random.Next(0, mockData.Count - 1);
                Stock randStock = mockData[rand].Clone();
                randStock.settlement = Settlement.ElementAt(random.Next(0, 1));
                randStock.contract = Contract.ElementAt(random.Next(0, Contract.Count - 1));
                randStock.lastUpdated = RandomDate(random);
                randStock.openPriceDiff = (((randStock.openPrice - randStock.price) / randStock.price) * 100) * 150;
                randStock.buyDiff = (((randStock.buy - randStock.price) / randStock.price) * 100) * 150;
                randStock.sellDiff = (((randStock.sell - randStock.price) / randStock.price) * 100) * 150;
                randStock.startYDiff = (((randStock.startY - randStock.price) / randStock.price) * 100) * 150;
                randStock.highYDiff = (((randStock.highY - randStock.price) / randStock.price) * 100) * 150;
                randStock.lowYDiff = (((randStock.lowY - randStock.price) / randStock.price) * 100) * 150;
                randStock.highDDiff = (((randStock.highD - randStock.price) / randStock.price) * 100) * 150;
                randStock.lowDDiff = (((randStock.lowD - randStock.price) / randStock.price) * 100) * 150;
                var region = Regions.ElementAt(random.Next(0, Regions.Count - 1));
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
                RandomizeStockObject(randStock, random);
                randStock.id = i;
                stocks.Add(randStock);
            }

            return stocks;
        }

        public void RandomizeStockObject(Stock stock, Random rand)
        {
            Stock res = this.GenerateNewPrice(stock.price, rand);
            stock.change = res.price - stock.price;
            stock.price = res.price;
            stock.changeP = res.changePercent;
        }

        public Stock GenerateNewPrice(double oldPrice, Random rand)
        {
            Stock stock = new Stock();
            double rnd = rand.NextDouble();
            int volatility = 2;
            double changePercent = 2 * volatility * rnd;
            if (changePercent > volatility)
            {
                changePercent -= (2 * volatility);
            }

            double changeAmount = oldPrice * (changePercent / 100);
            double newPrice = oldPrice + changeAmount;
            stock.price = newPrice;
            stock.changePercent = changePercent;
            return stock;

        }


        public List<Stock> MockData()
        {
            List<Stock> data = new List<Stock>();
            var jsonString = @"[{""category"":""Metal"",""type"":""Gold"",""spread"":0.01,""openPrice"":1281.1,""price"":1280.7317,""buy"":1280.7267,""sell"":1280.7367,""change"":-0.3683,""changeP"":-0.0287,""volume"":48387,""highD"":1289.5,""lowD"":1279.1,""highY"":1306,""lowY"":1047.2,""startY"":1176.6,""changeOnYear"":8.8502},{""category"":""Metal"",""type"":""Silver"",""spread"":0.01,""openPrice"":17.43,""price"":17.42,""buy"":17.43,""sell"":17.43,""change"":-0.01,""changeP"":-0.0574,""volume"":11720,""highD"":17.51,""lowD"":17.37,""highY"":18.06,""lowY"":13.73,""startY"":15.895,""changeOnYear"":9.5942},{""category"":""Metal"",""type"":""Copper"",""spread"":0.02,""openPrice"":2.123,""price"":2.113,""buy"":2.123,""sell"":2.123,""change"":-0.01,""changeP"":-0.471,""volume"":28819,""highD"":2.16,""lowD"":2.11,""highY"":2.94,""lowY"":1.96,""startY"":2.45,""changeOnYear"":-13.7551},{""category"":""Metal"",""type"":""Platinum"",""spread"":0.01,""openPrice"":1071.6,""price"":1071.0993,""buy"":1071.0943,""sell"":1071.1043,""change"":-0.5007,""changeP"":-0.0467,""volume"":3039,""highD"":1081.2,""lowD"":1070.5,""highY"":1120.6,""lowY"":812.4,""startY"":966.5,""changeOnYear"":10.8225},{""category"":""Metal"",""type"":""Palladium"",""spread"":0.01,""openPrice"":600.55,""price"":601.0005,""buy"":600.9955,""sell"":601.0055,""change"":0.4505,""changeP"":0.075,""volume"":651,""highD"":607.2,""lowD"":598.4,""highY"":690,""lowY"":458.6,""startY"":574.3,""changeOnYear"":4.6492},{""category"":""Oil"",""type"":""Oil"",""spread"":0.015,""openPrice"":45.54,""price"":45.7899,""buy"":45.7824,""sell"":45.7974,""change"":0.2499,""changeP"":0.5487,""volume"":107196,""highD"":45.94,""lowD"":45,""highY"":65.28,""lowY"":30.79,""startY"":48.035,""changeOnYear"":-4.6739},{""category"":""Oil"",""type"":""Brent"",""spread"":0.01,""openPrice"":46.06,""price"":46.05,""buy"":46.06,""sell"":46.06,""change"":-0.01,""changeP"":-0.0217,""volume"":59818,""highD"":45.6,""highY"":71.14,""lowY"":30.02,""startY"":50.58,""changeOnYear"":-8.9561},{""category"":""Oil"",""type"":""Natural Gas"",""spread"":0.02,""openPrice"":2.094,""price"":2.104,""buy"":2.094,""sell"":2.094,""change"":0.01,""changeP"":0.4776,""volume"":2783,""highD"":2.11,""lowD"":2.09,""highY"":3.2,""lowY"":1.84,""startY"":2.52,""changeOnYear"":-16.5079},{""category"":""Oil"",""type"":""RBOB Gas"",""spread"":0.015,""openPrice"":1.5086,""price"":1.9532,""buy"":1.9457,""sell"":1.9607,""change"":0.4446,""changeP"":29.4686,""volume"":2646,""highD"":1.9532,""lowD"":1.5,""highY"":2.05,""lowY"":1.15,""startY"":1.6,""changeOnYear"":22.0727},{""category"":""Oil"",""type"":""Diesel"",""spread"":0.015,""openPrice"":1.3474,""price"":1.3574,""buy"":1.3474,""sell"":1.3474,""change"":0.01,""changeP"":0.7422,""volume"":2971,""highD"":1.36,""lowD"":1.34,""highY"":2.11,""lowY"":0.92,""startY"":1.515,""changeOnYear"":-10.4026},{""category"":""Oil"",""type"":""Ethanol"",""spread"":0.01,""openPrice"":1.512,""price"":2.7538,""buy"":2.7488,""sell"":2.7588,""change"":1.2418,""changeP"":82.1323,""volume"":14,""highD"":2.7538,""lowD"":1.1168,""highY"":2.7538,""lowY"":1.1168,""startY"":1.475,""changeOnYear"":86.7011},{""category"":""Oil"",""type"":""Uranium"",""spread"":0.02,""openPrice"":27.55,""price"":27.58,""buy"":27.55,""sell"":27.55,""change"":0.03,""changeP"":0.1089,""volume"":12,""highD"":27.55,""lowD"":27.55,""highY"":29.32,""lowY"":21.28,""startY"":25.3,""changeOnYear"":9.0119},{""category"":""Oil"",""type"":""Coal"",""spread"":0.015,""openPrice"":0.4363,""price"":0.4163,""buy"":0.4363,""sell"":0.4363,""change"":-0.02,""changeP"":-4.584,""volume"":3,""highD"":0.4363,""lowD"":0.4363,""highY"":0.4841,""lowY"":0.3954,""startY"":0.4398,""changeOnYear"":-5.3326},{""category"":""Agriculture"",""type"":""Wheat"",""spread"":0.01,""openPrice"":465.5,""price"":465.52,""buy"":465.5,""sell"":465.5,""change"":0.02,""changeP"":0.0043,""volume"":4318,""highD"":467,""lowD"":463.25,""highY"":628.5,""lowY"":449.5,""startY"":539,""changeOnYear"":-13.6327},{""category"":""Agriculture"",""type"":""Corn"",""spread"":0.01,""openPrice"":379.5,""price"":379.8026,""buy"":379.7976,""sell"":379.8076,""change"":0.3026,""changeP"":0.0797,""volume"":11266,""highD"":381,""lowD"":377.75,""highY"":471.25,""lowY"":351.25,""startY"":411.25,""changeOnYear"":-7.6468},{""category"":""Agriculture"",""type"":""Sugar"",""spread"":0.01,""openPrice"":15.68,""price"":14.6742,""buy"":14.6692,""sell"":14.6792,""change"":-1.0058,""changeP"":-6.4146,""volume"":4949,""highD"":15.7,""lowD"":14.6742,""highY"":16.87,""lowY"":11.37,""startY"":14.12,""changeOnYear"":3.9249},{""category"":""Agriculture"",""type"":""Soybean"",""spread"":0.01,""openPrice"":1038,""price"":1038.6171,""buy"":1038.6121,""sell"":1038.6221,""change"":0.6171,""changeP"":0.0595,""volume"":20356,""highD"":1044,""lowD"":1031.75,""highY"":1057,""lowY"":859.5,""startY"":958.25,""changeOnYear"":8.3869},{""category"":""Agriculture"",""type"":""Soy oil"",""spread"":0.01,""openPrice"":33.26,""price"":33.7712,""buy"":33.7662,""sell"":33.7762,""change"":0.5112,""changeP"":1.5371,""volume"":10592,""highD"":33.7712,""lowD"":33.06,""highY"":35.43,""lowY"":26.61,""startY"":31.02,""changeOnYear"":8.8692},{""category"":""Agriculture"",""type"":""Soy Meat"",""spread"":0.01,""openPrice"":342.6,""price"":342.62,""buy"":342.6,""sell"":342.6,""change"":0.02,""changeP"":0.0058,""volume"":5646,""highD"":345.4,""lowD"":340.3,""highY"":353.4,""lowY"":261.7,""startY"":307.55,""changeOnYear"":11.403},{""category"":""Agriculture"",""type"":""OJ Future"",""spread"":0.01,""openPrice"":140.6,""price"":140.1893,""buy"":140.1843,""sell"":140.1943,""change"":-0.4107,""changeP"":-0.2921,""volume"":7,""highD"":140.1893,""lowD"":0,""highY"":155.95,""lowY"":113,""startY"":134.475,""changeOnYear"":4.2493},{""category"":""Agriculture"",""type"":""Coffee"",""spread"":0.01,""openPrice"":125.7,""price"":125.69,""buy"":125.7,""sell"":125.7,""change"":-0.01,""changeP"":-0.008,""volume"":1654,""highD"":125.8,""lowD"":125,""highY"":155.75,""lowY"":115.35,""startY"":135.55,""changeOnYear"":-7.2741},{""category"":""Agriculture"",""type"":""Cocoa"",""spread"":0.01,""openPrice"":3076,""price"":3076.03,""buy"":3076,""sell"":3076,""change"":0.03,""changeP"":0.001,""volume"":978,""highD"":3078,""lowD"":3066,""highY"":3406,""lowY"":2746,""startY"":3076,""changeOnYear"":0.001},{""category"":""Agriculture"",""type"":""Rice"",""spread"":0.01,""openPrice"":11.245,""price"":10.4154,""buy"":10.4104,""sell"":10.4204,""change"":-0.8296,""changeP"":-7.3779,""volume"":220,""highD"":11.38,""lowD"":10.4154,""highY"":14.14,""lowY"":9.7,""startY"":11.92,""changeOnYear"":-12.6228},{""category"":""Agriculture"",""type"":""Oats"",""spread"":0.01,""openPrice"":194.5,""price"":194.2178,""buy"":194.2128,""sell"":194.2228,""change"":-0.2822,""changeP"":-0.1451,""volume"":64,""highD"":195.75,""lowD"":194,""highY"":241.25,""lowY"":183.75,""startY"":212.5,""changeOnYear"":-8.6034},{""category"":""Agriculture"",""type"":""Milk"",""spread"":0.01,""openPrice"":12.87,""price"":12.86,""buy"":12.87,""sell"":12.87,""change"":-0.01,""changeP"":-0.0777,""volume"":7,""highD"":12.89,""lowD"":12.81,""highY"":16.96,""lowY"":12.81,""startY"":14.885,""changeOnYear"":-13.6043},{""category"":""Agriculture"",""type"":""Cotton"",""spread"":0.01,""openPrice"":61.77,""price"":61.76,""buy"":61.77,""sell"":61.77,""change"":-0.01,""changeP"":-0.0162,""volume"":3612,""highD"":62.06,""lowD"":61.32,""highY"":67.59,""lowY"":54.33,""startY"":60.96,""changeOnYear"":1.3123},{""category"":""Agriculture"",""type"":""Lumber"",""spread"":0.01,""openPrice"":303.9,""price"":304.5994,""buy"":304.5944,""sell"":304.6044,""change"":0.6994,""changeP"":0.2302,""volume"":2,""highD"":304.5994,""lowD"":303.9,""highY"":317.1,""lowY"":236,""startY"":276.55,""changeOnYear"":10.1426},{""category"":""Livestock"",""type"":""LV Cattle"",""spread"":0.01,""openPrice"":120.725,""price"":120.705,""buy"":120.725,""sell"":120.725,""change"":-0.02,""changeP"":-0.0166,""volume"":4,""highD"":120.725,""lowD"":120.725,""highY"":147.98,""lowY"":113.9,""startY"":130.94,""changeOnYear"":-7.8166},{""category"":""Livestock"",""type"":""FD Cattle"",""spread"":0.01,""openPrice"":147.175,""price"":148.6065,""buy"":148.6015,""sell"":148.6115,""change"":1.4315,""changeP"":0.9727,""volume"":5,""highD"":148.6065,""lowD"":147.175,""highY"":190,""lowY"":138.1,""startY"":164.05,""changeOnYear"":-9.4139},{""category"":""Livestock"",""type"":""Lean Hogs"",""spread"":0.01,""openPrice"":81.275,""price"":81.8146,""buy"":81.8096,""sell"":81.8196,""change"":0.5396,""changeP"":0.664,""volume"":1,""highD"":81.8146,""lowD"":81.275,""highY"":83.98,""lowY"":70.25,""startY"":77.115,""changeOnYear"":6.0943},{""category"":""Currencies"",""type"":""USD IDX Future"",""spread"":0.02,""openPrice"":93.88,""price"":93.7719,""buy"":93.7619,""sell"":93.7819,""change"":-0.1081,""changeP"":-0.1151,""volume"":5788,""highD"":94.05,""lowD"":93.7534,""highY"":100.7,""lowY"":91.88,""startY"":96.29,""changeOnYear"":-2.6151},{""category"":""Currencies"",""type"":""USD/JPY Future"",""spread"":0.02,""openPrice"":9275.5,""price"":9277.3342,""buy"":9277.3242,""sell"":9277.3442,""change"":1.8342,""changeP"":0.0198,""volume"":47734,""highD"":9277.3342,""lowD"":0.93,""highY"":9483,""lowY"":0.93,""startY"":4741.965,""changeOnYear"":95.6432},{""category"":""Currencies"",""type"":""GBP/USD Future"",""spread"":0.02,""openPrice"":1.4464,""price"":1.1941,""buy"":1.1841,""sell"":1.2041,""change"":-0.2523,""changeP"":-17.4441,""volume"":29450,""highD"":1.45,""lowD"":1.1941,""highY"":1.59,""lowY"":1.1941,""startY"":1.485,""changeOnYear"":-19.59},{""category"":""Currencies"",""type"":""AUD/USD Future"",""spread"":0.02,""openPrice"":0.7344,""price"":0.7444,""buy"":0.7344,""sell"":0.7344,""change"":0.01,""changeP"":1.3617,""volume"":36764,""highD"":0.74,""lowD"":0.73,""highY"":0.79,""lowY"":0.68,""startY"":0.735,""changeOnYear"":1.2789},{""category"":""Currencies"",""type"":""USD/CAD Future"",""spread"":0.02,""openPrice"":0.7744,""price"":0.9545,""buy"":0.9445,""sell"":0.9645,""change"":0.1801,""changeP"":23.2622,""volume"":13669,""highD"":0.9545,""lowD"":0.77,""highY"":0.9545,""lowY"":0.68,""startY"":0.755,""changeOnYear"":26.4295},{""category"":""Currencies"",""type"":""USD/CHF Future"",""spread"":0.02,""openPrice"":1.0337,""price"":1.0437,""buy"":1.0337,""sell"":1.0337,""change"":0.01,""changeP"":0.9674,""volume"":5550,""highD"":1.03,""lowD"":1.03,""highY"":1.11,""lowY"":0.98,""startY"":1.045,""changeOnYear"":-0.1244},{""category"":""Index"",""type"":""DOW Future"",""spread"":0.01,""openPrice"":17711,""price"":17712.1515,""buy"":17712.1465,""sell"":17712.1565,""change"":1.1515,""changeP"":0.0065,""volume"":22236,""highD"":17727,""lowD"":17642,""highY"":18083,""lowY"":15299,""startY"":16691,""changeOnYear"":6.118},{""category"":""Index"",""type"":""S&P Future"",""spread"":0.01,""openPrice"":2057.5,""price"":2056.6018,""buy"":2056.5968,""sell"":2056.6068,""change"":-0.8982,""changeP"":-0.0437,""volume"":142780,""highD"":2059.5,""lowD"":2049,""highY"":2105.5,""lowY"":1794.5,""startY"":1950,""changeOnYear"":5.4668},{""category"":""Index"",""type"":""NAS Future"",""spread"":0.01,""openPrice"":4341.25,""price"":4341.28,""buy"":4341.25,""sell"":4341.25,""change"":0.03,""changeP"":0.0007,""volume"":18259,""highD"":4347,""lowD"":4318,""highY"":4719.75,""lowY"":3867.75,""startY"":4293.75,""changeOnYear"":1.107},{""category"":""Index"",""type"":""S&P MID MINI"",""spread"":0.01,""openPrice"":1454.3,""price"":1455.7812,""buy"":1455.7762,""sell"":1455.7862,""change"":1.4812,""changeP"":0.1018,""volume"":338,""highD"":1455.7812,""lowD"":1448,""highY"":1527.3,""lowY"":1236,""startY"":1381.65,""changeOnYear"":5.3654},{""category"":""Index"",""type"":""S&P 600 MINI"",""spread"":0.01,""openPrice"":687.9,""price"":687.88,""buy"":687.9,""sell"":687.9,""change"":-0.02,""changeP"":-0.0029,""volume"":0,""highD"":0,""lowD"":0,""highY"":620.32,""lowY"":595.9,""startY"":608.11,""changeOnYear"":13.1177},{""category"":""Interest Rate"",""type"":""US 30YR Future"",""spread"":0.01,""openPrice"":164.875,""price"":164.1582,""buy"":164.1532,""sell"":164.1632,""change"":-0.7168,""changeP"":-0.4347,""volume"":28012,""highD"":165.25,""lowD"":164.0385,""highY"":169.38,""lowY"":151.47,""startY"":160.425,""changeOnYear"":2.3271},{""category"":""Interest Rate"",""type"":""US 2Y Future"",""spread"":0.01,""openPrice"":109.3984,""price"":109.3884,""buy"":109.3984,""sell"":109.3984,""change"":-0.01,""changeP"":-0.0091,""volume"":17742,""highD"":109.41,""lowD"":109.38,""highY"":109.8,""lowY"":108.62,""startY"":109.21,""changeOnYear"":0.1634},{""category"":""Interest Rate"",""type"":""US 10YR Future"",""spread"":0.01,""openPrice"":130.5625,""price"":130.5825,""buy"":130.5625,""sell"":130.5625,""change"":0.02,""changeP"":0.0153,""volume"":189310,""highD"":130.63,""lowD"":130.44,""highY"":132.64,""lowY"":125.48,""startY"":129.06,""changeOnYear"":1.1797},{""category"":""Interest Rate"",""type"":""Euro$ 3M"",""spread"":0.01,""openPrice"":99.18,""price"":99.17,""buy"":99.18,""sell"":99.18,""change"":-0.01,""changeP"":-0.0101,""volume"":29509,""highD"":99.18,""lowD"":99.17,""highY"":99.38,""lowY"":98.41,""startY"":98.895,""changeOnYear"":0.2781}]";
            data = JsonConvert.DeserializeObject<List<Stock>>(jsonString);
            return data;
        }

        public Stock MockFinanceData()
        {
            Stock data = new Stock()
            {

                indGrou = "Airlines",
                indSect = "Consumer, Cyclical",
                indSubg = "Airlines",
                secType = "PUBLIC",
                cpnTyp = "FIXED",
                issuerN = "AMERICAN AIRLINES GROUP",
                moodys = "WR",
                fitch = "N.A.",
                dbrs = "N.A.",
                collatT = "NEW MONEY",
                curncy = "USD",
                security = "001765866 Pfd",
                sector = "Pfd",
                cusip = "1765866",
                ticker = "AAL",
                cpn = "7.875",
                maturity = "7/13/1939",
                krD_3YR = 0.00006,
                RISK_COUNTRY = "",
                MUNI_SECTOR = 1,
                zV_SPREAD = 28.302,
                kRD_5YR = 0,
                kRD_1YR = -0.00187,
                PD_WALA = null
            };
            return data;
        }
    }
}
