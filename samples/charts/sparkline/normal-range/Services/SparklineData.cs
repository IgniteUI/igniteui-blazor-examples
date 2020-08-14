using Infragistics.Blazor.Controls;
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

            dataItems.Add(new DataItem() { Label = 4, Value = 4 });
            dataItems.Add(new DataItem() { Label = 5, Value = 5 });
            dataItems.Add(new DataItem() { Label = 2, Value = 2 });
            dataItems.Add(new DataItem() { Label = 7, Value = 7});
            dataItems.Add(new DataItem() { Label = -1, Value = -1 });
            dataItems.Add(new DataItem() { Label = 3, Value = 3 });
            dataItems.Add(new DataItem() { Label = -2, Value = -2 });
            dataItems.Add(new DataItem() { Label = 5, Value = 5 });
            dataItems.Add(new DataItem() { Label = 2, Value = 2 });
            dataItems.Add(new DataItem() { Label = 6, Value = 6 });

            return dataItems;
        }
    }
}
