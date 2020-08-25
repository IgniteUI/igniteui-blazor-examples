using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class SparklineItem
    {
        public double Index { get; set; }
        public double Value { get; set; }
        public double Angle { get; set; }
        public double Expanse { get; set; }
        public double Income { get; set; }
    }

    public static class SparklineData
    {
        public static List<SparklineItem> Generate()
        {
            var SparklineItems = new List<SparklineItem>();
            var index = 0;
            var min = 1000.0;
            var max = -1000.0;

            for (var angle = 0; angle <= 360 * 4.0; angle += 5)
            {
                var v1 = Math.Sin(angle * Math.PI / 180);
                var v2 = Math.Sin(3 * angle * Math.PI / 180) / 3;
                var revenue = v1 + v2;
                var expanse = revenue < 0 ? revenue : 0;
                var income = revenue > 0 ? revenue : 0;

                SparklineItems.Add(new SparklineItem()
                {
                    Index = index++,
                    Angle = angle,
                    // Value = v1 + v2
                    Value = revenue,
                    Expanse = expanse,
                    Income = income
                });
                min = Math.Min(min, v1 + v2);
                max = Math.Max(max, v1 + v2);
            }

            return SparklineItems;
        }
    }
}
