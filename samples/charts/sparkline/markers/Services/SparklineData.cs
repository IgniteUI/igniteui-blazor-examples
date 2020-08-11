using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samples.Pages
{
    public static class SparklineData
    {
        public class DataItem
        {
            public double Label { get; set; }
            public double Value { get; set; }

        }

        public static List<DataItem> getData()
        {
            var dataItems = new List<DataItem>();

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

        //public class DataItem
        //{
        //    public double Index { get; set; }
        //    public double Value { get; set; }
        //    public double Angle { get; set; }
        //    public double Expanse { get; set; }
        //    public double Income { get; set; }
        //}

        //public static List<DataItem> getData()
        //{
        //    var dataItems = new List<DataItem>();
        //    var index = 0;
        //    var min = 1000.0;
        //    var max = -1000.0;

        //    for (var angle = 0; angle <= 360 * 4.0; angle += 5)
        //    {
        //        var v1 = Math.Sin(angle * Math.PI / 180);
        //        var v2 = Math.Sin(3 * angle * Math.PI / 180) / 3;
        //        var revenu = v1 + v2;

        //        var expanse = revenu < 0 ? revenu : 0;
        //        var income = revenu > 0 ? revenu : 0;

        //        dataItems.Add(new DataItem()
        //        {
        //            Index = index++,
        //            Angle = angle,
        //            Value = revenu,
        //            Expanse = expanse,
        //            Income = income
        //        });
        //        min = Math.Min(min, v1 + v2);
        //        max = Math.Max(max, v1 + v2);
        //    }

        //    return dataItems;
        //}
    }
}
