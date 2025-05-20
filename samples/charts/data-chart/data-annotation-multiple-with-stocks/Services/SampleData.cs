using System.Collections.Generic;

public class StripAnnotationDataItem
{
    public double Start { get; set; }
    public double End { get; set; }
    public string Label { get; set; }
}

public class StripAnnotationData
    : List<StripAnnotationDataItem>
{
    public StripAnnotationData()
    {
        this.Add(new StripAnnotationDataItem()
        {
            Start = 40,
            End = 45,
            Label = @"Covid - Market Crash"
        });
        this.Add(new StripAnnotationDataItem()
        {
            Start = 100,
            End = 144,
            Label = @"Fed Rate Up  0.25 - 5.25%"
        });
        this.Add(new StripAnnotationDataItem()
        {
            Start = 190,
            End = 205,
            Label = @"Fed Rate Down 5.25% to 4.45%"
        });
    }
}
public class LineAnnotationData1Item
{
    public double StartX { get; set; }
    public double StartY { get; set; }
    public double EndX { get; set; }
    public double EndY { get; set; }
    public string Label { get; set; }
}

public class LineAnnotationData1
    : List<LineAnnotationData1Item>
{
    public LineAnnotationData1()
    {
        this.Add(new LineAnnotationData1Item()
        {
            StartX = 190,
            StartY = 138,
            EndX = 230,
            EndY = 138,
            Label = @"52-Week Low"
        });
        this.Add(new LineAnnotationData1Item()
        {
            StartX = 190,
            StartY = 481,
            EndX = 230,
            EndY = 481,
            Label = @"52-Week High"
        });
    }
}
public class LineAnnotationData2Item
{
    public double StartX { get; set; }
    public double StartY { get; set; }
    public double EndX { get; set; }
    public double EndY { get; set; }
    public string Label { get; set; }
}

public class LineAnnotationData2
    : List<LineAnnotationData2Item>
{
    public LineAnnotationData2()
    {
        this.Add(new LineAnnotationData2Item()
        {
            StartX = 48,
            StartY = 25,
            EndX = 105,
            EndY = 250,
            Label = @"Growth &
Support"
        });
        this.Add(new LineAnnotationData2Item()
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
public class SliceAnnotationData1Item
{
    public double Value { get; set; }
    public string Label { get; set; }
}

public class SliceAnnotationData1
    : List<SliceAnnotationData1Item>
{
    public SliceAnnotationData1()
    {
        this.Add(new SliceAnnotationData1Item()
        {
            Value = 126,
            Label = @"Stock Split 3-1"
        });
        this.Add(new SliceAnnotationData1Item()
        {
            Value = 61,
            Label = @"Stock Split 5-1"
        });
    }
}
public class SliceAnnotationData2Item
{
    public double Value { get; set; }
    public string Label { get; set; }
}

public class SliceAnnotationData2
    : List<SliceAnnotationData2Item>
{
    public SliceAnnotationData2()
    {
        this.Add(new SliceAnnotationData2Item()
        {
            Value = 9,
            Label = @"Earnings Miss"
        });
        this.Add(new SliceAnnotationData2Item()
        {
            Value = 179,
            Label = @"Earnings Miss"
        });
        this.Add(new SliceAnnotationData2Item()
        {
            Value = 215,
            Label = @"Earnings Miss"
        });
    }
}
public class SliceAnnotationData3Item
{
    public double Value { get; set; }
    public string Label { get; set; }
}

public class SliceAnnotationData3
    : List<SliceAnnotationData3Item>
{
    public SliceAnnotationData3()
    {
        this.Add(new SliceAnnotationData3Item()
        {
            Value = 155,
            Label = @"Earnings Beat"
        });
        this.Add(new SliceAnnotationData3Item()
        {
            Value = 86,
            Label = @"Earnings Beat"
        });
        this.Add(new SliceAnnotationData3Item()
        {
            Value = 28,
            Label = @"Earnings Miss"
        });
    }
}
