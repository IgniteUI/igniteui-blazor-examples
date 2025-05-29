using System;
using System.Collections.Generic;
public class AnnotationBandDataItem
{
    public string StartLabel { get; set; }
    public string EndLabel { get; set; }
    public double StartX { get; set; }
    public double StartY { get; set; }
    public double EndX { get; set; }
    public double EndY { get; set; }
    public double Value { get; set; }
    public string Label { get; set; }
}

public class AnnotationBandData
    : List<AnnotationBandDataItem>
{
    public AnnotationBandData()
    {
        this.Add(new AnnotationBandDataItem()
        {
            StartLabel = @"Growth Start",
            EndLabel = @"Growth Stop",
            StartX = 48,
            StartY = 110,
            EndX = 105,
            EndY = 335,
            Value = 170,
            Label = @"Rapid Growth"
        });
    }
}
