using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Infragistics.Samples
{
    public class Region
    {
        public string Name { get; set; }
        public List<string> Countries { get; set; }
    }
    public class LiveFinancialData
    {
        public static Random random = new Random();

        #region Arrays
        public static List<string> DealType = new List<string>() { "Buy", "Sell" };

        public static List<string> Contracts = new List<string>() { "Forwards", "Futures", "Options", "Swap", "CFD" };

        public static List<string> Settlements = new List<string>() { "Credit", "Cash", "Loan" };
                      
        public static List<string> SectorTypes = new List<string>() { "Public", "Private", "Government" };
                      
        public static List<string> CurrencyTypes = new List<string>() { "USD", "EUR", "PLN", "GBP", "YEN" };
                      
        public static List<string> CountryRisks = new List<string>() { "Low", "High" };
                      
        public static List<string> SecurityTypes = new List<string>() { "Poor", "Good", "High", };
                      
        public static List<string> IssuerNames = new List<string>() { "American Airlines", "Delta Airlines", "Southwest", "FedEx", };
                      
        public static List<string> RatingTypes = new List<string>() { "AAA", "BBB", "CCC", };

        #endregion

        public static List<DefaultItems> GenerateData(int count)
        {
            List<DefaultItems> data = DataItems();
            List<Region> regions = Regions();
            List<AirlineDataItem> defaultData = DefaultData();
            List<PropertyInfo> propInfo = typeof(AirlineDataItem).GetProperties().ToList();

            for (int i = 0; i < count; i++)
            {
                double dataItemCount = data.Count;
                var rand = Math.Floor(random.NextDouble() * Math.Floor(dataItemCount));
                //todo add the properties
                var item = data[(int)rand];
                item.Settlement = GetRandomItem(Settlements).ToString();
                item.Contract = GetRandomItem(Contracts).ToString();
                var region = GetRandomItem(regions) as Region;
                item.Region = region.Name;
                item.Country = GetRandomItem(region.Countries).ToString();
                item.Risk = GetRandomItem(CountryRisks).ToString();
                item.Sector = GetRandomItem(SectorTypes).ToString();
                item.Currency = GetRandomItem(CurrencyTypes).ToString();
                item.Security = GetRandomItem(SecurityTypes).ToString();
                item.Issuer = GetRandomItem(IssuerNames).ToString();
                item.Maturity = GetRandomDate();
                item.Rating = GetRandomItem(RatingTypes).ToString();

                //TODO combine fields for grid
                //foreach (var mockData in defaultData)
                //{
                //    foreach (var prop in propInfo)
                //    {
                //        //if (mockData.hasOwnProperty(prop))
                //        //{
                //        //    item[prop] = mockData[prop];
                //        //}
                //    }
                //}
                item.ID = i;
                RandomizeDataValues(item);
                data.Add(item);
            }

            return data;
        }
        
        public static List<Region> Regions()
        {
            var data = new List<Region>
            {
                new Region {
                    Name = "North America",
                    Countries = new List<string>() {"Canada", "United States", "Mexico" }
                },
                new Region {
                    Name = "Middle East",
                    Countries =  new List<string>(){"Turkey", "Iraq", "Saudi Arabia", "Syria", "UAE", "Israel", "Jordan", "Lebanon", "Oman", "Kuwait", "Qatar", "Bahrain", "Iran" }
                },
                new Region {
                    Name = "Europe",
                    Countries = new List<string>(){ "Russia", "Germany", "France", "United Kingdom", "Italy", "Spain", "Poland", "Romania", "Netherlands", "Belgium", "Greece",
              "Portugal", "Czech Republic", "Hungary", "Sweden", "Austria", "Switzerland", "Bulgaria", "Denmark", "Finland", "Slovakia", "Norway",
              "Ireland", "Croatia", "Slovenia", "Estonia", "Iceland" }
                },

                new Region {
                    Name = "Africa",
                    Countries= new List<string>(){ "Nigeria", "Ethiopia", "Egypt", "South Africa", "Algeria", "Morocco", "Cameroon", "Niger", "Senegal", "Tunisia", "Libya" }
                },

                new Region {
                    Name = "Asia Pacific",
                    Countries =  new List<string>(){ "Afghanistan", "Australia", "Azerbaijan", "China", "Hong Kong", "India", "Indonesia",
              "Japan", "Malaysia", "New Zealand", "Pakistan", "Philippines", "Korea", "Singapore", "Taiwan", "Thailand"}
                },

                new Region {
                    Name = "South America",
                    Countries =  new List<string>(){ "Argentina", "Bolivia", "Brazil", "Chile", "Colombia", "Ecuador", "Guyana", "Paraguay", "Peru", "Suriname", "Uruguay", "Venezuela" }
                },

            };

            return data;
        }

        public static List<AirlineDataItem> DefaultData()
        {
            var data = new List<AirlineDataItem>()
        {
            new AirlineDataItem {

                IndGroup = "Airlines",
                IndSector = new string[] {"Consumer, Cyclical" },
                IndCategory = "Airlines",
                Fitch = "N.A.",
                Collateral = "Assets",
                Transactions = "1765866",
                CPN = 7.875,
                Maturity = new DateTime(7/13/2022),
                Spread = 28.302,
                KRD_3YR = 0.00006,
                KRD_5YR = 0,
                KRD_1YR = -0.00187,
            }
        };

            return data;
        }

        public static List<DefaultItems> DataItems()
        {
            var data = new List<DefaultItems>()
        {
            new DefaultItems {

                Category = "Metal",
                Type = "Gold",
                Spread = 0.01,
                OpenPrice = 1281.10,
                Price = 1280.7317,
                Buy = 1280.7267,
                Sell = 1280.7367,
                Change = -0.3683,
                ChangePercent = -0.0287,
                Volume = 48387,
                High_D = 1289.50,
                Low_D = 1279.10,
                High_Y = 1306,
                Low_Y = 1047.20,
                Start_Y = 1176.60,
                ChangeOnYear = 8.8502
            },
            new DefaultItems {

                Category = "Metal",
                Type = "Silver",
                Spread = 0.01,
                OpenPrice = 17.43,
                Price = 17.42,
                Buy = 17.43,
                Sell = 17.43,
                Change = -0.01,
                ChangePercent = -0.0287,
                Volume = 48387,
                High_D = 1289.50,
                Low_D = 1279.10,
                High_Y = 1306,
                Low_Y = 1047.20,
                Start_Y = 1176.60,
                ChangeOnYear = 8.8502
            },
            new DefaultItems {
                Category= "Metal",
                Type = "Copper",
                Spread = 0.02,
                OpenPrice = 2.123,
                Price = 2.113,
                Buy = 2.123,
                Sell = 2.123,
                Change = -0.01,
                ChangePercent = -0.471,
                Volume = 28819,
                High_D = 2.16,
                Low_D = 2.11,
                High_Y = 2.94,
                Low_Y = 1.96,
                Start_Y = 2.45,
                ChangeOnYear = -13.7551
            },
            new DefaultItems {
                Category = "Metal",
                Type = "Platinum",
                Spread = 0.01,
                OpenPrice = 1071.60,
                Price = 1071.0993,
                Buy = 1071.0943,
                Sell = 1071.1043,
                Change = -0.5007,
                ChangePercent = -0.0467,
                Volume = 3039,
                High_D = 1081.20,
                Low_D = 1070.50,
                High_Y = 1120.60,
                Low_Y = 812.40,
                Start_Y = 966.50,
                ChangeOnYear = 10.8225
            },
            new DefaultItems {
                 Category = "Metal",
                 Type = "Palladium",
                 Spread = 0.01,
                 OpenPrice = 600.55,
                 Price = 601.0005,
                 Buy = 600.9955,
                 Sell = 601.0055,
                 Change = 0.4505,
                 ChangePercent = 0.075,
                 Volume = 651,
                 High_D = 607.20,
                 Low_D = 598.40,
                 High_Y = 690,
                 Low_Y = 458.6,
                 Start_Y = 574.3,
                 ChangeOnYear = 4.6492
            },
            new DefaultItems
            {
                 Category = "Oil",
                 Type = "Oil",
                 Spread = 0.015,
                 OpenPrice = 45.54,
                 Price = 45.7899,
                 Buy = 45.7824,
                 Sell = 45.7974,
                 Change = 0.2499,
                 ChangePercent = 0.5487,
                 Volume = 107196,
                 High_D = 45.94,
                 Low_D = 45.00,
                 High_Y = 65.28,
                 Low_Y = 30.79,
                 Start_Y = 48.035,
                 ChangeOnYear = -4.6739
            },
            new DefaultItems
            {
                Category = "Oil",
                Type = "Brent",
                Spread = 0.01,
                OpenPrice = 46.06,
                Price = 46.05,
                Buy = 46.06,
                Sell = 46.06,
                Change = -0.01,
                ChangePercent = -0.0217,
                Volume = 59818,
                High_D = 46.48,
                Low_D = 45.60,
                High_Y = 71.14,
                Low_Y = 30.02,
                Start_Y = 50.58,
                ChangeOnYear = -8.9561
            },
            new DefaultItems
            {
                 Category = "Oil",
                 Type = "Natural Gas",
                 Spread = 0.02,
                 OpenPrice = 2.094,
                 Price = 2.104,
                 Buy = 2.094,
                 Sell = 2.094,
                 Change = 0.01,
                 ChangePercent = 0.4776,
                 Volume = 2783,
                 High_D = 2.11,
                 Low_D = 2.09,
                 High_Y = 3.20,
                 Low_Y = 1.84,
                 Start_Y = 2.52,
                 ChangeOnYear = -16.5079
            },
            new DefaultItems
            {
                Category = "Oil",
                Type = "Gas",
                Spread = 0.015,
                OpenPrice = 1.5086,
                Price = 1.9532,
                Buy = 1.9457,
                Sell = 1.9607,
                Change = 0.4446,
                ChangePercent = 29.4686,
                Volume = 2646,
                High_D = 1.9532,
                Low_D = 1.50,
                High_Y = 2.05,
                Low_Y = 1.15,
                Start_Y = 1.60,
                ChangeOnYear = 22.0727
            },
            new DefaultItems
            {
                 Category = "Oil",
                 Type = "Diesel",
                 Spread = 0.015,
                 OpenPrice = 1.3474,
                 Price = 1.3574,
                 Buy = 1.3474,
                 Sell = 1.3474,
                 Change = 0.01,
                 ChangePercent = 0.7422,
                 Volume = 2971,
                 High_D = 1.36,
                 Low_D = 1.34,
                 High_Y = 2.11,
                 Low_Y = 0.92,
                 Start_Y = 1.515,
                 ChangeOnYear = -10.4026
            },
            new DefaultItems
            {
                 Category = "Oil",
                 Type = "Ethanol",
                 Spread = 0.01,
                 OpenPrice = 1.512,
                 Price = 2.7538,
                 Buy = 2.7488,
                 Sell = 2.7588,
                 Change = 1.2418,
                 ChangePercent = 82.1323,
                 Volume = 14,
                 High_D = 2.7538,
                 Low_D = 1.1168,
                 High_Y = 2.7538,
                 Low_Y = 1.1168,
                 Start_Y = 1.475,
                 ChangeOnYear = 86.7011
            },
            new DefaultItems
            {
                 Category = "Oil",
                 Type = "Crude",
                 Spread = 0.02,
                 OpenPrice = 27.55,
                 Price = 27.58,
                 Buy = 27.55,
                 Sell = 27.55,
                 Change = 0.03,
                 ChangePercent = 0.1089,
                 Volume = 12,
                 High_D = 27.55,
                 Low_D = 27.55,
                 High_Y = 29.32,
                 Low_Y = 21.28,
                 Start_Y = 25.30,
                 ChangeOnYear = 9.0119
            },
            new DefaultItems
            {
                 Category = "Oil",
                 Type = "Coal",
                 Spread = 0.015,
                 OpenPrice = 0.4363,
                 Price = 0.4163,
                 Buy = 0.4363,
                 Sell = 0.4363,
                 Change = -0.02,
                 ChangePercent = -4.584,
                 Volume = 3,
                 High_D = 0.4363,
                 Low_D = 0.4363,
                 High_Y = 0.4841,
                 Low_Y = 0.3954,
                 Start_Y = 0.4398,
                 ChangeOnYear = -5.3326
            },
            new DefaultItems
            {
                 Category = "Agriculture",
                 Type = "Wheat",
                 Spread = 0.01,
                 OpenPrice = 465.50,
                 Price = 465.52,
                 Buy = 465.50,
                 Sell = 465.50,
                 Change = 0.02,
                 ChangePercent = 0.0043,
                 Volume = 4318,
                 High_D = 467.00,
                 Low_D = 463.25,
                 High_Y = 628.50,
                 Low_Y = 449.50,
                 Start_Y = 539.00,
                 ChangeOnYear = -13.6327
            },
            new DefaultItems
            {
                 Category = "Agriculture",
                 Type = "Corn",
                 Spread = 0.01,
                 OpenPrice = 379.50,
                 Price = 379.8026,
                 Buy = 379.7976,
                 Sell = 379.8076,
                 Change = 0.3026,
                 ChangePercent = 0.0797,
                 Volume = 11266,
                 High_D = 381.00,
                 Low_D = 377.75,
                 High_Y = 471.25,
                 Low_Y = 351.25,
                 Start_Y = 411.25,
                 ChangeOnYear = -7.6468
            },
            new DefaultItems
            {
                 Category = "Agriculture",
                 Type = "Sugar",
                 Spread = 0.01,
                 OpenPrice = 15.68,
                 Price = 14.6742,
                 Buy = 14.6692,
                 Sell = 14.6792,
                 Change = -1.0058,
                 ChangePercent = -6.4146,
                 Volume = 4949,
                 High_D = 15.70,
                 Low_D = 14.6742,
                 High_Y = 16.87,
                 Low_Y = 11.37,
                 Start_Y = 14.12,
                 ChangeOnYear = 3.9249
            },
            new DefaultItems
            {
                 Category = "Agriculture",
                 Type = "Soybean",
                 Spread = 0.01,
                 OpenPrice = 1038.00,
                 Price = 1038.6171,
                 Buy = 1038.6121,
                 Sell = 1038.6221,
                 Change = 0.6171,
                 ChangePercent = 0.0595,
                 Volume = 20356,
                 High_D = 1044.00,
                 Low_D = 1031.75,
                 High_Y = 1057.00,
                 Low_Y = 859.50,
                 Start_Y = 958.25,
                 ChangeOnYear = 8.3869
            },
            new DefaultItems
            {
                 Category = "Agriculture",
                 Type = "Soy oil",
                 Spread = 0.01,
                 OpenPrice = 33.26,
                 Price = 33.7712,
                 Buy = 33.7662,
                 Sell = 33.7762,
                 Change = 0.5112,
                 ChangePercent = 1.5371,
                 Volume = 10592,
                 High_D = 33.7712,
                 Low_D = 33.06,
                 High_Y = 35.43,
                 Low_Y = 26.61,
                 Start_Y = 31.02,
                 ChangeOnYear = 8.8692
            },
            new DefaultItems
            {
                 Category = "Agriculture",
                 Type = "Soy Meat",
                 Spread = 0.01,
                 OpenPrice = 342.60,
                 Price = 342.62,
                 Buy = 342.60,
                 Sell = 342.60,
                 Change = 0.02,
                 ChangePercent = 0.0058,
                 Volume = 5646,
                 High_D = 345.40,
                 Low_D = 340.30,
                 High_Y = 353.40,
                 Low_Y = 261.70,
                 Start_Y = 307.55,
                 ChangeOnYear = 11.403
            },
            new DefaultItems
            {
                 Category = "Agriculture",
                 Type = "OJ Future",
                 Spread = 0.01,
                 OpenPrice = 140.60,
                 Price = 140.1893,
                 Buy = 140.1843,
                 Sell = 140.1943,
                 Change = -0.4107,
                 ChangePercent = -0.2921,
                 Volume = 7,
                 High_D = 140.1893,
                 Low_D = 0.00,
                 High_Y = 155.95,
                 Low_Y = 113.00,
                 Start_Y = 134.475,
                 ChangeOnYear = 4.2493
            },
            new DefaultItems
            {
                Category = "Agriculture",
                Type = "Coffee",
                Spread = 0.01,
                OpenPrice = 125.70,
                Price = 125.69,
                Buy = 125.70,
                Sell = 125.70,
                Change = -0.01,
                ChangePercent = -0.008,
                Volume = 1654,
                High_D = 125.80,
                Low_D = 125.00,
                High_Y = 155.75,
                Low_Y = 115.35,
                Start_Y = 135.55,
                ChangeOnYear = -7.2741
            },
            new DefaultItems
            {
                 Category = "Agriculture",
                 Type = "Cocoa",
                 Spread = 0.01,
                 OpenPrice = 3076.00,
                 Price = 3076.03,
                 Buy = 3076.00,
                 Sell = 3076.00,
                 Change = 0.03,
                 ChangePercent = 0.001,
                 Volume = 978,
                 High_D = 3078.00,
                 Low_D = 3066.00,
                 High_Y = 3406.00,
                 Low_Y = 2746.00,
                 Start_Y = 3076.00,
                 ChangeOnYear = 0.001
            },
            new DefaultItems
            {
                 Category = "Agriculture",
                 Type = "Rice",
                 Spread = 0.01,
                 OpenPrice = 11.245,
                 Price = 10.4154,
                 Buy = 10.4104,
                 Sell = 10.4204,
                 Change = -0.8296,
                 ChangePercent = -7.3779,
                 Volume = 220,
                 High_D = 11.38,
                 Low_D = 10.4154,
                 High_Y = 14.14,
                 Low_Y = 9.70,
                 Start_Y = 11.92,
                 ChangeOnYear = -12.6228
            },
            new DefaultItems
            {
                 Category = "Agriculture",
                 Type = "Oats",
                 Spread = 0.01,
                 OpenPrice = 194.50,
                 Price = 194.2178,
                 Buy = 194.2128,
                 Sell = 194.2228,
                 Change = -0.2822,
                 ChangePercent = -0.1451,
                 Volume = 64,
                 High_D = 195.75,
                 Low_D = 194.00,
                 High_Y = 241.25,
                 Low_Y = 183.75,
                 Start_Y = 212.50,
                 ChangeOnYear = -8.6034
            },
            new DefaultItems
            {
                 Category = "Agriculture",
                 Type = "Milk",
                 Spread = 0.01,
                 OpenPrice = 12.87,
                 Price = 12.86,
                 Buy = 12.87,
                 Sell = 12.87,
                 Change = -0.01,
                 ChangePercent = -0.0777,
                 Volume = 7,
                 High_D = 12.89,
                 Low_D = 12.81,
                 High_Y = 16.96,
                 Low_Y = 12.81,
                 Start_Y = 14.885,
                 ChangeOnYear = -13.6043
            },
            new DefaultItems
            {
                 Category = "Agriculture",
                 Type = "Cotton",
                 Spread = 0.01,
                 OpenPrice = 61.77,
                 Price = 61.76,
                 Buy = 61.77,
                 Sell = 61.77,
                 Change = -0.01,
                 ChangePercent = -0.0162,
                 Volume = 3612,
                 High_D = 62.06,
                 Low_D = 61.32,
                 High_Y = 67.59,
                 Low_Y = 54.33,
                 Start_Y = 60.96,
                 ChangeOnYear = 1.3123
            },
            new DefaultItems
            {
                 Category = "Agriculture",
                 Type = "Lumber",
                 Spread = 0.01,
                 OpenPrice = 303.90,
                 Price = 304.5994,
                 Buy = 304.5944,
                 Sell = 304.6044,
                 Change = 0.6994,
                 ChangePercent = 0.2302,
                 Volume = 2,
                 High_D = 304.5994,
                 Low_D = 303.90,
                 High_Y = 317.10,
                 Low_Y = 236.00,
                 Start_Y = 276.55,
                 ChangeOnYear = 10.1426
            },
            new DefaultItems
            {
                 Category = "Livestock",
                 Type = "LV Cattle",
                 Spread = 0.01,
                 OpenPrice = 120.725,
                 Price = 120.705,
                 Buy = 120.725,
                 Sell = 120.725,
                 Change = -0.02,
                 ChangePercent = -0.0166,
                 Volume = 4,
                 High_D = 120.725,
                 Low_D = 120.725,
                 High_Y = 147.98,
                 Low_Y = 113.90,
                 Start_Y = 130.94,
                 ChangeOnYear = -7.8166
            },
            new DefaultItems
            {
                 Category = "Livestock",
                 Type = "FD Cattle",
                 Spread = 0.01,
                 OpenPrice = 147.175,
                 Price = 148.6065,
                 Buy = 148.6015,
                 Sell = 148.6115,
                 Change = 1.4315,
                 ChangePercent = 0.9727,
                 Volume = 5,
                 High_D = 148.6065,
                 Low_D = 147.175,
                 High_Y = 190.00,
                 Low_Y = 138.10,
                 Start_Y = 164.05,
                 ChangeOnYear = -9.4139
            },
            new DefaultItems
            {
                 Category = "Livestock",
                 Type = "Lean Hogs",
                 Spread = 0.01,
                 OpenPrice = 81.275,
                 Price = 81.8146,
                 Buy = 81.8096,
                 Sell = 81.8196,
                 Change = 0.5396,
                 ChangePercent = 0.664,
                 Volume = 1,
                 High_D = 81.8146,
                 Low_D = 81.275,
                 High_Y = 83.98,
                 Low_Y = 70.25,
                 Start_Y = 77.115,
                 ChangeOnYear = 6.0943
            },
            new DefaultItems
            {
                 Category = "Currencies",
                 Type = "USD IDX Future",
                 Spread = 0.02,
                 OpenPrice = 93.88,
                 Price = 93.7719,
                 Buy = 93.7619,
                 Sell = 93.7819,
                 Change = -0.1081,
                 ChangePercent = -0.1151,
                 Volume = 5788,
                 High_D = 94.05,
                 Low_D = 93.7534,
                 High_Y = 100.70,
                 Low_Y = 91.88,
                 Start_Y = 96.29,
                 ChangeOnYear = -2.6151
            },
            new DefaultItems
            {
                 Category = "Currencies",
                 Type = "USD/JPY Future",
                 Spread = 0.02,
                 OpenPrice = 9275.50,
                 Price = 9277.3342,
                 Buy = 9277.3242,
                 Sell = 9277.3442,
                 Change = 1.8342,
                 ChangePercent = 0.0198,
                 Volume = 47734,
                 High_D = 9277.3342,
                 Low_D = 0.93,
                 High_Y = 9483.00,
                 Low_Y = 0.93,
                 Start_Y = 4741.965,
                 ChangeOnYear = 95.6432
            },
            new DefaultItems
            {
                 Category = "Currencies",
                 Type = "GBP/USD Future",
                 Spread = 0.02,
                 OpenPrice = 1.4464,
                 Price = 1.1941,
                 Buy = 1.1841,
                 Sell = 1.2041,
                 Change = -0.2523,
                 ChangePercent = -17.4441,
                 Volume = 29450,
                 High_D = 1.45,
                 Low_D = 1.1941,
                 High_Y = 1.59,
                 Low_Y = 1.1941,
                 Start_Y = 1.485,
                 ChangeOnYear = -19.59
            },
            new DefaultItems
            {
                 Category = "Currencies",
                 Type = "AUD/USD Future",
                 Spread = 0.02,
                 OpenPrice = 0.7344,
                 Price = 0.7444,
                 Buy = 0.7344,
                 Sell = 0.7344,
                 Change = 0.01,
                 ChangePercent = 1.3617,
                 Volume = 36764,
                 High_D = 0.74,
                 Low_D = 0.73,
                 High_Y = 0.79,
                 Low_Y = 0.68,
                 Start_Y = 0.735,
                 ChangeOnYear = 1.2789
            },
            new DefaultItems
            {
                 Category = "Currencies",
                 Type = "USD/CAD Future",
                 Spread = 0.02,
                 OpenPrice = 0.7744,
                 Price = 0.9545,
                 Buy = 0.9445,
                 Sell = 0.9645,
                 Change = 0.1801,
                 ChangePercent = 23.2622,
                 Volume = 13669,
                 High_D = 0.9545,
                 Low_D = 0.77,
                 High_Y = 0.9545,
                 Low_Y = 0.68,
                 Start_Y = 0.755,
                 ChangeOnYear = 26.4295
            },
            new DefaultItems
            {
                 Category = "Currencies",
                 Type = "USD/CHF Future",
                 Spread = 0.02,
                 OpenPrice = 1.0337,
                 Price = 1.0437,
                 Buy = 1.0337,
                 Sell = 1.0337,
                 Change = 0.01,
                 ChangePercent = 0.9674,
                 Volume = 5550,
                 High_D = 1.03,
                 Low_D = 1.03,
                 High_Y = 1.11,
                 Low_Y = 0.98,
                 Start_Y = 1.045,
                 ChangeOnYear = -0.1244
            },
            new DefaultItems
            {
                 Category = "Index",
                 Type = "DOW Future",
                 Spread = 0.01,
                 OpenPrice = 17711.00,
                 Price = 17712.1515,
                 Buy = 17712.1465,
                 Sell = 17712.1565,
                 Change = 1.1515,
                 ChangePercent = 0.0065,
                 Volume = 22236,
                 High_D = 17727.00,
                 Low_D = 17642.00,
                 High_Y = 18083.00,
                 Low_Y = 15299.00,
                 Start_Y = 16691.00,
                 ChangeOnYear = 6.118
            },
            new DefaultItems
            {
                 Category = "Index",
                 Type = "S&P Future",
                 Spread = 0.01,
                 OpenPrice = 2057.50,
                 Price = 2056.6018,
                 Buy = 2056.5968,
                 Sell = 2056.6068,
                 Change = -0.8982,
                 ChangePercent = -0.0437,
                 Volume = 142780,
                 High_D = 2059.50,
                 Low_D = 2049.00,
                 High_Y = 2105.50,
                 Low_Y = 1794.50,
                 Start_Y = 1950.00,
                 ChangeOnYear = 5.4668
            },
            new DefaultItems
            {
                 Category = "Index",
                 Type = "NAS Future",
                 Spread = 0.01,
                 OpenPrice = 4341.25,
                 Price = 4341.28,
                 Buy = 4341.25,
                 Sell = 4341.25,
                 Change = 0.03,
                 ChangePercent = 0.0007,
                 Volume = 18259,
                 High_D = 4347.00,
                 Low_D = 4318.00,
                 High_Y = 4719.75,
                 Low_Y = 3867.75,
                 Start_Y = 4293.75,
                 ChangeOnYear = 1.107
            },
            new DefaultItems
            {
                 Category = "Index",
                 Type = "S&P MID MINI",
                 Spread = 0.01,
                 OpenPrice = 1454.30,
                 Price = 1455.7812,
                 Buy = 1455.7762,
                 Sell = 1455.7862,
                 Change = 1.4812,
                 ChangePercent = 0.1018,
                 Volume = 338,
                 High_D = 1455.7812,
                 Low_D = 1448.00,
                 High_Y = 1527.30,
                 Low_Y = 1236.00,
                 Start_Y = 1381.65,
                 ChangeOnYear = 5.3654
            },
            new DefaultItems
            {
                 Category = "Index",
                 Type = "S&P 600 MINI",
                 Spread = 0.01,
                 OpenPrice = 687.90,
                 Price = 687.88,
                 Buy = 687.90,
                 Sell = 687.90,
                 Change = -0.02,
                 ChangePercent = -0.0029,
                 Volume = 0,
                 High_D = 0.00,
                 Low_D = 0.00,
                 High_Y = 620.32,
                 Low_Y = 595.90,
                 Start_Y = 608.11,
                 ChangeOnYear = 13.1177
            },
            new DefaultItems
            {
                 Category = "Interest Rate",
                 Type = "US 30YR Future",
                 Spread = 0.01,
                 OpenPrice = 164.875,
                 Price = 164.1582,
                 Buy = 164.1532,
                 Sell = 164.1632,
                 Change = -0.7168,
                 ChangePercent = -0.4347,
                 Volume = 28012,
                 High_D = 165.25,
                 Low_D = 164.0385,
                 High_Y = 169.38,
                 Low_Y = 151.47,
                 Start_Y = 160.425,
                 ChangeOnYear = 2.3271
            },
            new DefaultItems
            {
                 Category = "Interest Rate",
                 Type = "US 2Y Future",
                 Spread = 0.01,
                 OpenPrice = 109.3984,
                 Price = 109.3884,
                 Buy = 109.3984,
                 Sell = 109.3984,
                 Change = -0.01,
                 ChangePercent = -0.0091,
                 Volume = 17742,
                 High_D = 109.41,
                 Low_D = 109.38,
                 High_Y = 109.80,
                 Low_Y = 108.62,
                 Start_Y = 109.21,
                 ChangeOnYear = 0.1634
            },
            new DefaultItems
            {
                 Category = "Interest Rate",
                 Type = "US 10YR Future",
                 Spread = 0.01,
                 OpenPrice = 130.5625,
                 Price = 130.5825,
                 Buy = 130.5625,
                 Sell = 130.5625,
                 Change = 0.02,
                 ChangePercent = 0.0153,
                 Volume = 189310,
                 High_D = 130.63,
                 Low_D = 130.44,
                 High_Y = 132.64,
                 Low_Y = 125.48,
                 Start_Y = 129.06,
                 ChangeOnYear = 1.1797
            },
            new DefaultItems
            {
                 Category = "Interest Rate",
                 Type = "Euro$ 3M",
                 Spread = 0.01,
                 OpenPrice = 99.18,
                 Price = 99.17,
                 Buy = 99.18,
                 Sell = 99.18,
                 Change = -0.01,
                 ChangePercent = -0.0101,
                 Volume = 29509,
                 High_D = 99.18,
                 Low_D = 99.17,
                 High_Y = 99.38,
                 Low_Y = 98.41,
                 Start_Y = 98.895,
                 ChangeOnYear = 0.2781
            }

        };

            return data;
        }

        public static List<object> UpdateAllPrices(List<object> data)
        {
            var currData = new List<object>();
            foreach (var dataRow in data)
            {
                var item = dataRow;
                RandomizeDataValues(item as DefaultItems);
                currData.Add(item);
            }
            return currData;
        }

        //TODO
        public static List<object> UpdateRandomPrices(List<object> data)
        {
            var currData = data.Skip(0);
            var y = 0;
            for (var i = Math.Round(random.NextDouble() * 10); i < data.Count; i += Math.Round(random.NextDouble() * 10))
            {
                var item = data[(int)i];
                RandomizeDataValues(item as DefaultItems);
                currData[i] = item;
                y++;
            }
            return currData;
        }

        //TODO
        public static List<object> UpdateRandomPrices2(List<object> data)
        {
            var currData = data.Skip(0);
            var y = 0;
            for (var i = Math.Round(random.NextDouble() * 10); i < data.Count; i += Math.Round(random * 10))
            {
                var item = data[i];
                RandomizeDataValues(item);
                currData[i] = item;
                y++;
            }

            return new UpdateResponse() { Data = currData, RecordsUpdated = y };
          
        }

        public static void RandomizeDataValues(DefaultItems item)
        {
            var changeP = "Change(%)";
            DefaultItems res = GetRandomPrice(item.Price);
            item.Change = res.Price - item.Price;
            item.Price = res.Price;
            //todo
            item.ChangePercent = res.ChangePercent;
        }

        public static DefaultItems GetRandomPrice(double oldPrice)
        {
            var rnd = float.Parse(random.NextDouble().ToString("N2"));
            var volatility = 2;
            double newPrice = 0;

            var changePercent = 2 * volatility * rnd;
            if (changePercent > volatility)
            {
                changePercent -= (2 * volatility);
            }
            var changeAmount = oldPrice * (changePercent / 100);
            newPrice = oldPrice + changeAmount;
            var result = new DefaultItems { Price = 0, ChangePercent = 0 };
            result.Price = Math.Round(newPrice * 100) / 100;
            result.ChangePercent = Math.Round(changePercent * 100) / 100;

            return result;
        }

        public static DateTime GetRandomDate()
        {
            var now = new DateTime();
            var month = GetRandomNumber(1, 9);
            var day = GetRandomNumber(10, 27);
            return new DateTime(now.Year, (int)month, (int)day);
        }

        public static object GetRandomItem(IList list)
        {
            var index = Math.Round(GetRandomNumber(0, list.Count - 1));
            return list[((int)index)];
        }

        public static double GetRandomNumber(double min, double max)
        {
            return Math.Round((min + random.NextDouble()) * (max - min));
        }

        public static object GetRandomCountry(object region)
        {
            if (((Region)region).Countries == null)
            {
                return GetRandomItem(((Region)region).Countries);
            }
            else
            {
                return GetRandomItem(((Region)region).Countries);
            }
        }
    }
    public class AirlineDataItem
    {
        public string IndGroup { get; set; }
        public string[] IndSector { get; set; }
        public string IndCategory { get; set; }
        public string Fitch { get; set; }
        public string Collateral { get; set; }
        public string Transactions { get; set; }
        public double CPN { get; set; }
        public DateTime Maturity { get; set; }
        public double Spread { get; set; }
        public double KRD_3YR { get; set; }
        public double KRD_5YR { get; set; }
        public double KRD_1YR { get; set; }

    }
    public class DefaultItems : AirlineDataItem
    {
        //string properties for items in the static arrays
        public string Settlement { get; set; }
        public string Category { get; set; }
        public string Contract { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public string Type { get; set; }
        public double Spread { get; set; }
        public double OpenPrice { get; set; }
        public double Price { get; set; }
        public double Buy { get; set; }
        public string Rating { get; set; }
        public string Region { get; set; }
        public string Risk { get; set; }
        public double Sell { get; set; }
        public string Sector { get; set; }
        public string Security { get; set; }
        public int ID { get; set; }
        public string Issuer { get; set; }
        public double Change { get; set; }
        public double ChangePercent { get; set; }
        public double Volume { get; set; }
        public double High_D { get; set; }
        public double Low_D { get; set; }
        public double High_Y { get; set; }
        public double Low_Y { get; set; }
        public double Start_Y { get; set; }
        public double ChangeOnYear { get; set; }

    }
    public class UpdateResponse
    {
        public List<object> Data { get; set; }
        public int RecordsUpdated { get; set; }
    }
}
