using System;
using System.Collections.Generic;
public class AnnotationSliceMultiOverlayDataItem
{
    public double Value { get; set; }
}

public class AnnotationSliceMultiOverlayData
    : List<AnnotationSliceMultiOverlayDataItem>
{
    public AnnotationSliceMultiOverlayData()
    {
        this.Add(new AnnotationSliceMultiOverlayDataItem() { Value = 50 });
    }
}
