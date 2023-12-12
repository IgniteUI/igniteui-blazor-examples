using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class EditableLineDataItem
    {
        public string Category { get; set; }
        public double DataValue { get; set; }
        public double EditingValue { get; set; }
    }

    public class EditableLineDataSource : List<EditableLineDataItem>
    {
        public EditableLineDataSource()
        {
            Add(new EditableLineDataItem { Category = "2010", DataValue = 20, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2011", DataValue = 40, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2012", DataValue = 30, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2013", DataValue = 50, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2014", DataValue = 40, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2015", DataValue = 60, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2016", DataValue = 30, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2017", DataValue = 50, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2018", DataValue = 40, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2019", DataValue = 70, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2020", DataValue = 40, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2021", DataValue = 60, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2022", DataValue = 50, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2023", DataValue = 70, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2024", DataValue = 60, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2025", DataValue = 80, EditingValue = double.NaN });
            Add(new EditableLineDataItem { Category = "2026", DataValue = 70, EditingValue = double.NaN });
        }
    }


    public class EditableScatterDataItem
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double EditingX { get; set; }
        public double EditingY { get; set; } 
    }

    public class EditableScattereDataSource : List<EditableScatterDataItem>
    {
        public EditableScattereDataSource()
        {
            Add(new EditableScatterDataItem { X = 10, Y = 20, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 11, Y = 40, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 12, Y = 30, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 13, Y = 50, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 14, Y = 40, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 15, Y = 60, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 16, Y = 30, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 17, Y = 50, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 18, Y = 40, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 19, Y = 70, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 20, Y = 40, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 21, Y = 60, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 22, Y = 50, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 23, Y = 70, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 24, Y = 60, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 25, Y = 80, EditingX = double.NaN, EditingY = double.NaN });
            Add(new EditableScatterDataItem { X = 26, Y = 70, EditingX = double.NaN, EditingY = double.NaN });
        }
    }


}
