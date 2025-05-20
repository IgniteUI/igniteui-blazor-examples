using System.Collections.Generic;

public class AnnotationDataItem
{
    public double Start { get; set; }
    public double End { get; set; }
    public string Label { get; set; }
}

public class AnnotationData
    : List<AnnotationDataItem>
{
    public AnnotationData()
    {
        this.Add(new AnnotationDataItem()
        {
            Start = 40,
            End = 45,
            Label = @"Covid - Market Crash"
        });
        this.Add(new AnnotationDataItem()
        {
            Start = 100,
            End = 144,
            Label = @"Fed Rate Up  0.25 - 5.25%"
        });
        this.Add(new AnnotationDataItem()
        {
            Start = 190,
            End = 205,
            Label = @"Fed Rate Down 5.25% to 4.45%"
        });
    }
}
