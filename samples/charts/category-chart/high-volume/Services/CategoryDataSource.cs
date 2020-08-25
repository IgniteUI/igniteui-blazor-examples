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
            var value = startValue;
            var random = new Random();
            for (var i = 0; i <= maxPoints; i++)
            {
                value += random.NextDouble() * 4.0 - 2.0;
                var v = Math.Round(value);
                var l = i.ToString();
                if (useShortLabels)
                {
                    l = CategoryDataSource.ToShortString(i);
                }
                data.Add(new CategoryDataItem { Label = l, Value = v });
            }
            return data;
        }

        public static CategoryDataItem GetLastItem(List<CategoryDataItem> array)
        {
            if (array.Count == 0)
            {
                return null;
            }
            return array[array.Count - 1];
        }

        public static CategoryDataItem GetNewItem(List<CategoryDataItem> array, int index)
        {
            var random = new Random();
            var lastItem = CategoryDataSource.GetLastItem(array);
            var newValue = lastItem.Value + random.NextDouble() * 4.0 - 2.0;
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
