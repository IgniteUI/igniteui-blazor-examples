using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samples
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
            var dataItems = new List<SparklineMarkerItem>
            {
                new SparklineMarkerItem() { Label = double.NaN, Value = double.NaN },
                new SparklineMarkerItem() { Label = 4, Value = 4 },
                new SparklineMarkerItem() { Label = 5, Value = 5 },
                new SparklineMarkerItem() { Label = 2, Value = 2 },
                new SparklineMarkerItem() { Label = 7, Value = 7 },
                new SparklineMarkerItem() { Label = -1, Value = -1 },
                new SparklineMarkerItem() { Label = 3, Value = 3 },
                new SparklineMarkerItem() { Label = -2, Value = -2 },
                new SparklineMarkerItem() { Label = 5, Value = 5 },
                new SparklineMarkerItem() { Label = 2, Value = 2 },
                new SparklineMarkerItem() { Label = 6, Value = 6 },
                new SparklineMarkerItem() { Label = double.NaN, Value = double.NaN }
            };

            return dataItems;
        }

    }
}
