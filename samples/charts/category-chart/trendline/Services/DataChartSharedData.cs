using System;
using System.Collections.Generic;

namespace Samples
{
    public static class DataChartSharedData
    {
        public class Energy
        {
            public string Country { get; set; }
            public double Coal { get; set; }
            public double Oil { get; set; }
            public double Gas { get; set; }
            public double Nuclear { get; set; }
            public double Hydro { get; set; }
        }

        public static List<Energy> getEnergyProduction()
        {
            var dp = new Energy { Country = "", Coal = 400000000 };

            var data = new List<Energy>() {
                new Energy { Country = "Canada", Coal = 400000000, Oil = 100000000, Gas = 175000000, Nuclear = 225000000, Hydro = 350000000 },
                new Energy { Country = "China", Coal = 925000000, Oil = 200000000, Gas = 350000000, Nuclear = 400000000, Hydro = 625000000 },
                new Energy { Country = "Russia", Coal = 550000000, Oil = 200000000, Gas = 250000000, Nuclear = 475000000, Hydro = 425000000 },
                new Energy { Country = "Australia", Coal = 450000000, Oil = 100000000, Gas = 150000000, Nuclear = 175000000, Hydro = 350000000 },
                new Energy { Country = "United States", Coal = 800000000, Oil = 250000000, Gas = 475000000, Nuclear = 575000000, Hydro = 750000000 },
                new Energy { Country = "France", Coal = 375000000, Oil = 150000000, Gas = 350000000, Nuclear = 275000000, Hydro = 325000000 }
            };
            return data;
        }

        public class DataItem
        {

            public string Label { get; set; }
            public double Value { get; set; }
        }
        public static List<DataItem> getDataItems(double startValue, int maxPoints, bool useShortLabels)
        {

            var data = new List<DataItem>();
            var value = startValue;
            var random = new Random();
            for (var i = 0; i <= maxPoints; i++)
            {
                value += random.NextDouble() * 4.0 - 2.0;
                var v = Math.Round(value);
                var l = i.ToString();
                if (useShortLabels)
                {
                    l = DataChartSharedData.toShortString(i);
                }
                data.Add(new DataItem { Label = l, Value = v });
            }
            return data;
        }

        public static DataItem getLastItem(List<DataItem> array)
        {
            if (array.Count == 0)
            {
                return null;
            }
            return array[array.Count - 1];
        }

        public static DataItem getNewItem(List<DataItem> array, int index)
        {
            var random = new Random();
            var lastItem = DataChartSharedData.getLastItem(array);
            var newValue = lastItem.Value + random.NextDouble() * 4.0 - 2.0;
            return new DataItem { Label = index.ToString(), Value = newValue };
        }

        public class Temperature
        {
            public string Label { get; set; }
            public double Value { get; set; }
            public double Low { get; set; }
            public double High { get; set; }
        }

        public static List<Temperature> getTemperatures(double startValue, double startYear, double endYear)
        {
            var data = new List<Temperature>();
            var value = startValue;
            var random = new Random();
            for (var i = startYear; i <= endYear; i++)
            {
                value += (random.NextDouble() - 0.5) * 0.5;
                var high = value + (random.NextDouble() * 2);
                var low = value - (random.NextDouble() * 2);
                var v = Math.Abs(Math.Round(value * 10) / 10);
                var h = Math.Abs(Math.Round(high * 10) / 10);
                var l = Math.Abs(Math.Round(low * 10) / 10);
                data.Add(new Temperature { Label = i.ToString(), Value = v, High = h, Low = l, });
            }
            return data;
        }


        public static string toShortString(double largeValue)
        {
            double roundValue;

            if (largeValue >= 1000000)
            {
                roundValue = Math.Round(largeValue / 100000) / 10;
                return roundValue + "m";
            }
            if (largeValue >= 1000)
            {
                roundValue = Math.Round(largeValue / 100) / 10;
                return roundValue + "k";
            }

            roundValue = Math.Round(largeValue);
            return roundValue + "";
        }
    }
}
