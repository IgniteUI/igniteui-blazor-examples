using System;
using System.Collections.Generic;
public class AnnotationLineData1Item
{
    public double StartX { get; set; }
    public double StartY { get; set; }
    public double EndX { get; set; }
    public double EndY { get; set; }
    public string Label { get; set; }
}

public class AnnotationLineData1
    : List<AnnotationLineData1Item>
{
    public AnnotationLineData1()
    {
        this.Add(new AnnotationLineData1Item()
        {
            StartX = 190,
            StartY = 138,
            EndX = 230,
            EndY = 138,
            Label = @"52-Week Low"
        });
        this.Add(new AnnotationLineData1Item()
        {
            StartX = 190,
            StartY = 481,
            EndX = 230,
            EndY = 481,
            Label = @"52-Week High"
        });
    }
}
