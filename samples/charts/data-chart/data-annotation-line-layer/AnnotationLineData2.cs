using System;
using System.Collections.Generic;
public class AnnotationLineData2Item
{
    public double StartX { get; set; }
    public double StartY { get; set; }
    public double EndX { get; set; }
    public double EndY { get; set; }
    public string Label { get; set; }
}

public class AnnotationLineData2
    : List<AnnotationLineData2Item>
{
    public AnnotationLineData2()
    {
        this.Add(new AnnotationLineData2Item()
        {
            StartX = 48,
            StartY = 25,
            EndX = 105,
            EndY = 250,
            Label = @"Growth &
Support"
        });
        this.Add(new AnnotationLineData2Item()
        {
            StartX = 108,
            StartY = 440,
            EndX = 155,
            EndY = 210,
            Label = @"Decline &
Resistance"
        });
    }
}
