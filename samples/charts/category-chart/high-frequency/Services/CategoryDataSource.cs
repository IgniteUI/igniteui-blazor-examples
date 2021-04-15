using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class CategoryDataItem
    {
        public string Label { get; set; }
        public double Value { get; set; }
    }

    public static class CategoryDataSource
    {
        public static List<CategoryDataItem> Generate(double startValue, int maxPoints, bool useShortLabels)
        {
            var data = new List<CategoryDataItem>();
            data.Add(new CategoryDataItem { Label = "0", Value = startValue });
            for (var i = 1; i <= maxPoints; i++)
            {
                var item = GetNewItem(data, i);
                data.Add(item);
            }
            return data;
        }

        public static CategoryDataItem GetLastItem(IList<CategoryDataItem> array)
        {
            if (array.Count == 0)
            {
                return null;
            }
            return array[array.Count - 1];
        }

        public static CategoryDataItem GetNewItem(IList<CategoryDataItem> array, int index)
        {
            var random = new Random();
            var lastItem = GetLastItem(array);
            var newValue = lastItem.Value + random.NextDouble() * 4.0 - 2.0;
            //newValue = Math.Max(newValue, -19);
            //newValue = Math.Min(newValue,  19);
            return new CategoryDataItem { Label = index.ToString(), Value = newValue };
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
