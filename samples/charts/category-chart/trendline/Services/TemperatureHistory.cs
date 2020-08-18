using System;
using System.Collections.Generic;

namespace Samples
{
    public class Temperature
    {
        public string Label { get; set; }
        public double Value { get; set; }
        public double Low { get; set; }
        public double High { get; set; }
    }

    public static class TemperatureHistory
    {
        public static List<Temperature> Generate(double startValue, double startYear, double endYear)
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


        public static string ToShortString(double largeValue)
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
