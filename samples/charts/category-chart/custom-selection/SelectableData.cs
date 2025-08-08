using System;
using System.Collections.Generic;
public class SelectableDataItem
{
    public string Category { get; set; }
    public double DataValue { get; set; }
    public double SelectedValue { get; set; }
}

public class SelectableData
    : List<SelectableDataItem>
{
    public SelectableData()
    {
        this.Add(new SelectableDataItem() { Category = @"2010", DataValue = 20, SelectedValue = 20 });
        this.Add(new SelectableDataItem() { Category = @"2011", DataValue = 40, SelectedValue = double.NaN });
        this.Add(new SelectableDataItem() { Category = @"2012", DataValue = 35, SelectedValue = double.NaN });
        this.Add(new SelectableDataItem() { Category = @"2013", DataValue = 50, SelectedValue = 50 });
        this.Add(new SelectableDataItem() { Category = @"2014", DataValue = 45, SelectedValue = double.NaN });
        this.Add(new SelectableDataItem() { Category = @"2015", DataValue = 60, SelectedValue = 60 });
        this.Add(new SelectableDataItem() { Category = @"2016", DataValue = 35, SelectedValue = double.NaN });
        this.Add(new SelectableDataItem() { Category = @"2017", DataValue = 40, SelectedValue = double.NaN });
        this.Add(new SelectableDataItem() { Category = @"2018", DataValue = 50, SelectedValue = 50 });
        this.Add(new SelectableDataItem() { Category = @"2019", DataValue = 75, SelectedValue = 75 });
        this.Add(new SelectableDataItem() { Category = @"2020", DataValue = 65, SelectedValue = double.NaN });
        this.Add(new SelectableDataItem() { Category = @"2021", DataValue = 40, SelectedValue = double.NaN });
        this.Add(new SelectableDataItem() { Category = @"2022", DataValue = 50, SelectedValue = double.NaN });
        this.Add(new SelectableDataItem() { Category = @"2023", DataValue = 65, SelectedValue = 65 });
        this.Add(new SelectableDataItem() { Category = @"2024", DataValue = 70, SelectedValue = 70 });
        this.Add(new SelectableDataItem() { Category = @"2025", DataValue = 85, SelectedValue = double.NaN });
    }
}
