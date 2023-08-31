using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class SelectedableItem
    {
        public string Category { get; set; }
        public double DataValue { get; set; }
        public double SelectedValue { get; set; }
    }

    public class SelectedableData : List<SelectedableItem>
    {
        public SelectedableData()
        {
            Add(new SelectedableItem { Category = "2010", DataValue = 20, SelectedValue = double.NaN });
            Add(new SelectedableItem { Category = "2011", DataValue = 40, SelectedValue = double.NaN });
            Add(new SelectedableItem { Category = "2012", DataValue = 35, SelectedValue = double.NaN });
            Add(new SelectedableItem { Category = "2013", DataValue = 50, SelectedValue = 50 });
            Add(new SelectedableItem { Category = "2014", DataValue = 45, SelectedValue = double.NaN });
            Add(new SelectedableItem { Category = "2015", DataValue = 60, SelectedValue = 60 });
            Add(new SelectedableItem { Category = "2016", DataValue = 35, SelectedValue = double.NaN });
            Add(new SelectedableItem { Category = "2017", DataValue = 40, SelectedValue = double.NaN });
            Add(new SelectedableItem { Category = "2018", DataValue = 50, SelectedValue = 50 });
            Add(new SelectedableItem { Category = "2019", DataValue = 75, SelectedValue = 75 });
            Add(new SelectedableItem { Category = "2020", DataValue = 65, SelectedValue = double.NaN });
            Add(new SelectedableItem { Category = "2021", DataValue = 40, SelectedValue = double.NaN });
            Add(new SelectedableItem { Category = "2022", DataValue = 50, SelectedValue = double.NaN });
            Add(new SelectedableItem { Category = "2023", DataValue = 65, SelectedValue = 65 });
            Add(new SelectedableItem { Category = "2024", DataValue = 70, SelectedValue = 70 });
            Add(new SelectedableItem { Category = "2025", DataValue = 85, SelectedValue = double.NaN });
        }
    }
}
