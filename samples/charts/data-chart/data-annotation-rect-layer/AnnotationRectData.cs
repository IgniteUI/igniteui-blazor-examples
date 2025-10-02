using System;
using System.Collections.Generic;
public class AnnotationRectDataItem
{
    public double StartX { get; set; }
    public double StartY { get; set; }
    public double EndX { get; set; }
    public double EndY { get; set; }
    public string Label { get; set; }
}

public class AnnotationRectData
    : List<AnnotationRectDataItem>
{
    public AnnotationRectData()
    {
        this.Add(new AnnotationRectDataItem() { StartX = 85, StartY = 190, EndX = 140, EndY = 415, Label = @"Head & Shoulders Pattern
  (Bearish Downtrend)" });
        this.Add(new AnnotationRectDataItem() { StartX = 53, StartY = 75, EndX = 230, EndY = 80, Label = @"Price Gap (Bearish Target)" });
    }
}
