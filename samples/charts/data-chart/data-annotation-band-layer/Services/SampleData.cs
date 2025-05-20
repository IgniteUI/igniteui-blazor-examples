using System.Collections.Generic;

public class AnnotationDataItem
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

public class AnnotationData
    : List<AnnotationDataItem>
{
    public AnnotationData()
    {
        this.Add(new AnnotationDataItem()
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
