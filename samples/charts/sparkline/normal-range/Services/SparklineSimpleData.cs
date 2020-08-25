using Infragistics.Blazor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class SparklineSimpleItem
    {
        public double Label { get; set; }
        public double Value { get; set; }
    }

    public static class SparklineSimpleData
    {

        public static List<SparklineSimpleItem> Generate()
        {
            var dataItems = new List<SparklineSimpleItem>();

            dataItems.Add(new SparklineSimpleItem() { Label = 4, Value = 4 });
            dataItems.Add(new SparklineSimpleItem() { Label = 5, Value = 5 });
            dataItems.Add(new SparklineSimpleItem() { Label = 2, Value = 2 });
            dataItems.Add(new SparklineSimpleItem() { Label = 7, Value = 7});
            dataItems.Add(new SparklineSimpleItem() { Label = -1, Value = -1 });
            dataItems.Add(new SparklineSimpleItem() { Label = 3, Value = 3 });
            dataItems.Add(new SparklineSimpleItem() { Label = -2, Value = -2 });
            dataItems.Add(new SparklineSimpleItem() { Label = 5, Value = 5 });
            dataItems.Add(new SparklineSimpleItem() { Label = 2, Value = 2 });
            dataItems.Add(new SparklineSimpleItem() { Label = 6, Value = 6 });

            return dataItems;
        }
    }
}
