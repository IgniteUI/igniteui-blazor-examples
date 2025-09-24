using System;
using System.Collections.Generic;
public class AnnotationSliceEarningsBeatDataItem
{
    public double Value { get; set; }
    public string Label { get; set; }
}

public class AnnotationSliceEarningsBeatData
    : List<AnnotationSliceEarningsBeatDataItem>
{
    public AnnotationSliceEarningsBeatData()
    {
        this.Add(new AnnotationSliceEarningsBeatDataItem() { Value = 155, Label = @"Earnings Beat" });
        this.Add(new AnnotationSliceEarningsBeatDataItem() { Value = 86, Label = @"Earnings Beat" });
        this.Add(new AnnotationSliceEarningsBeatDataItem() { Value = 28, Label = @"Earnings Miss" });
    }
}
