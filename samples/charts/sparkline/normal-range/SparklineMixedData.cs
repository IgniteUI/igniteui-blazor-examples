using System;
using System.Collections.Generic;
public class SparklineMixedDataItem
{
    public string Label { get; set; }
    public double Value { get; set; }
}

public class SparklineMixedData
    : List<SparklineMixedDataItem>
{
    public SparklineMixedData()
    {
        this.Add(new SparklineMixedDataItem()
        {
            Label = @"A",
            Value = 30
        });
        this.Add(new SparklineMixedDataItem()
        {
            Label = @"B",
            Value = -10
        });
        this.Add(new SparklineMixedDataItem()
        {
            Label = @"C",
            Value = 40
        });
        this.Add(new SparklineMixedDataItem()
        {
            Label = @"D",
            Value = -20
        });
        this.Add(new SparklineMixedDataItem()
        {
            Label = @"E",
            Value = 30
        });
        this.Add(new SparklineMixedDataItem()
        {
            Label = @"F",
            Value = 40
        });
        this.Add(new SparklineMixedDataItem()
        {
            Label = @"G",
            Value = -10
        });
        this.Add(new SparklineMixedDataItem()
        {
            Label = @"H",
            Value = 30
        });
    }
}
