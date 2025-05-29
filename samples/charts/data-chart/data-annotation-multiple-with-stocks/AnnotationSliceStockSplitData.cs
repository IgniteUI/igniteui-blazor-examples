using System;
using System.Collections.Generic;
public class AnnotationSliceStockSplitDataItem
{
    public double Value { get; set; }
    public string Label { get; set; }
}

public class AnnotationSliceStockSplitData
    : List<AnnotationSliceStockSplitDataItem>
{
    public AnnotationSliceStockSplitData()
    {
        this.Add(new AnnotationSliceStockSplitDataItem()
        {
            Value = 126,
            Label = @"Stock Split 3-1"
        });
        this.Add(new AnnotationSliceStockSplitDataItem()
        {
            Value = 61,
            Label = @"Stock Split 5-1"
        });
    }
}
