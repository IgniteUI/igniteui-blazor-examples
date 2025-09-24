using System;
using System.Collections.Generic;
public class AnnotationSliceEarningsMissDataItem
{
    public double Value { get; set; }
    public string Label { get; set; }
}

public class AnnotationSliceEarningsMissData
    : List<AnnotationSliceEarningsMissDataItem>
{
    public AnnotationSliceEarningsMissData()
    {
        this.Add(new AnnotationSliceEarningsMissDataItem() { Value = 9, Label = @"Earnings Miss" });
        this.Add(new AnnotationSliceEarningsMissDataItem() { Value = 179, Label = @"Earnings Miss" });
        this.Add(new AnnotationSliceEarningsMissDataItem() { Value = 215, Label = @"Earnings Miss" });
    }
}
