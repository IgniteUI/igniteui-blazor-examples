using System;
using System.Collections.Generic;
public class SparklineProfitDataItem
{
    public double Value { get; set; }
    public string Label { get; set; }
}

public class SparklineProfitData
    : List<SparklineProfitDataItem>
{
    public SparklineProfitData()
    {
        this.Add(new SparklineProfitDataItem()
        {
            Value = 30,
            Label = @"A"
        });
        this.Add(new SparklineProfitDataItem()
        {
            Value = 40,
            Label = @"B"
        });
        this.Add(new SparklineProfitDataItem()
        {
            Value = 50,
            Label = @"C"
        });
        this.Add(new SparklineProfitDataItem()
        {
            Value = 40,
            Label = @"D"
        });
        this.Add(new SparklineProfitDataItem()
        {
            Value = 30,
            Label = @"E"
        });
        this.Add(new SparklineProfitDataItem()
        {
            Value = 20,
            Label = @"F"
        });
        this.Add(new SparklineProfitDataItem()
        {
            Value = 30,
            Label = @"G"
        });
        this.Add(new SparklineProfitDataItem()
        {
            Value = 40,
            Label = @"H"
        });
    }
}
