using System.Collections.Generic;

public class AnnotationData1Item
{
    public double StartX { get; set; }
    public double StartY { get; set; }
    public double EndX { get; set; }
    public double EndY { get; set; }
    public string Label { get; set; }
}

public class AnnotationData1
    : List<AnnotationData1Item>
{
    public AnnotationData1()
    {
        this.Add(new AnnotationData1Item()
        {
            StartX = 190,
            StartY = 138,
            EndX = 230,
            EndY = 138,
            Label = @"52-Week Low"
        });
        this.Add(new AnnotationData1Item()
        {
            StartX = 190,
            StartY = 481,
            EndX = 230,
            EndY = 481,
            Label = @"52-Week High"
        });
    }
}
public class AnnotationData2Item
{
    public double StartX { get; set; }
    public double StartY { get; set; }
    public double EndX { get; set; }
    public double EndY { get; set; }
    public string Label { get; set; }
}

public class AnnotationData2
    : List<AnnotationData2Item>
{
    public AnnotationData2()
    {
        this.Add(new AnnotationData2Item()
        {
            StartX = 48,
            StartY = 25,
            EndX = 105,
            EndY = 250,
            Label = @"Growth &
Support"
        });
        this.Add(new AnnotationData2Item()
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
