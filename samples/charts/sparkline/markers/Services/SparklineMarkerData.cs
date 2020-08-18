using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samples.Pages
{
    public class SparklineMarkerItem
    {
        public double Label { get; set; }
        public double Value { get; set; }
    }

    public static class SparklineMarkerData
    {
        public static List<SparklineMarkerItem> Generate()
        {
            var dataItems = new List<SparklineMarkerItem>();

            dataItems.Add(new DataItem() { Label = double.NaN, Value = double.NaN });
            dataItems.Add(new DataItem() { Label = 4, Value = 4 });
            dataItems.Add(new DataItem() { Label = 5, Value = 5 });
            dataItems.Add(new DataItem() { Label = 2, Value = 2 });
            dataItems.Add(new DataItem() { Label = 7, Value = 7 });
            dataItems.Add(new DataItem() { Label = -1, Value = -1 });
            dataItems.Add(new DataItem() { Label = 3, Value = 3 });
            dataItems.Add(new DataItem() { Label = -2, Value = -2 });
            dataItems.Add(new DataItem() { Label = 5, Value = 5 });
            dataItems.Add(new DataItem() { Label = 2, Value = 2 });
            dataItems.Add(new DataItem() { Label = 6, Value = 6 });
            dataItems.Add(new DataItem() { Label = double.NaN, Value = double.NaN });

            return dataItems;
        }

    }
}
