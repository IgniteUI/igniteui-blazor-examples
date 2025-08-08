using System;
using System.Collections.Generic;
public class RadialProportionalDataItem
{
    public string Label { get; set; }
    public double Value { get; set; }
    public double Radius { get; set; }
    public double Radius2 { get; set; }
}

public class RadialProportionalData
    : List<RadialProportionalDataItem>
{
    public RadialProportionalData()
    {
        this.Add(new RadialProportionalDataItem() { Label = @"A", Value = 100, Radius = 75, Radius2 = 50 });
        this.Add(new RadialProportionalDataItem() { Label = @"B", Value = 100, Radius = 100, Radius2 = 75 });
        this.Add(new RadialProportionalDataItem() { Label = @"C", Value = 100, Radius = 80, Radius2 = 140 });
        this.Add(new RadialProportionalDataItem() { Label = @"D", Value = 100, Radius = 60, Radius2 = 220 });
        this.Add(new RadialProportionalDataItem() { Label = @"E", Value = 100, Radius = 90, Radius2 = 30 });
        this.Add(new RadialProportionalDataItem() { Label = @"F", Value = 100, Radius = 95, Radius2 = 120 });
        this.Add(new RadialProportionalDataItem() { Label = @"G", Value = 100, Radius = 100, Radius2 = 200 });
        this.Add(new RadialProportionalDataItem() { Label = @"H", Value = 100, Radius = 80, Radius2 = 120 });
    }
}
