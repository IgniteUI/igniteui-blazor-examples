using System;
using System.Collections.Generic;
public class SparklineUnknownDataItem
{
    public double Label { get; set; }
    public double Value { get; set; }
}

public class SparklineUnknownData
    : List<SparklineUnknownDataItem>
{
    public SparklineUnknownData()
    {
        this.Add(new SparklineUnknownDataItem()
        {
            Label = 4,
            Value = 4
        });
        this.Add(new SparklineUnknownDataItem()
        {
            Label = 5,
            Value = 5
        });
        this.Add(new SparklineUnknownDataItem()
        {
            Label = 2,
            Value = double.NaN
        });
        this.Add(new SparklineUnknownDataItem()
        {
            Label = 7,
            Value = 7
        });
        this.Add(new SparklineUnknownDataItem()
        {
            Label = -1,
            Value = -1
        });
        this.Add(new SparklineUnknownDataItem()
        {
            Label = 3,
            Value = 3
        });
        this.Add(new SparklineUnknownDataItem()
        {
            Label = -2,
            Value = -2
        });
        this.Add(new SparklineUnknownDataItem()
        {
            Label = 5,
            Value = double.NaN
        });
        this.Add(new SparklineUnknownDataItem()
        {
            Label = 2,
            Value = 2
        });
        this.Add(new SparklineUnknownDataItem()
        {
            Label = 6,
            Value = 6
        });
    }
}
