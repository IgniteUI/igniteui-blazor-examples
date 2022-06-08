using System;
using System.Collections.Generic;
public class SparklineMixedDataItem
{
    public double Value{ get; set; }
    public string Category{ get; set; }
    public string Summary{ get; set; }
}
public class SparklineMixedData
    : List<SparklineMixedDataItem>
{
    public SparklineMixedData()
    {
        this.Add(new SparklineMixedDataItem()
        {
            Value = 37,
            Category = @"Cooling",
            Summary = @"Cooling 37%"
        });
        this.Add(new SparklineMixedDataItem()
        {
            Value = 25,
            Category = @"Residential",
            Summary = @"Residential 25%"
        });
        this.Add(new SparklineMixedDataItem()
        {
            Value = 12,
            Category = @"Heating",
            Summary = @"Heating 12%"
        });
        this.Add(new SparklineMixedDataItem()
        {
            Value = 11,
            Category = @"Lighting",
            Summary = @"Lighting 11%"
        });
        this.Add(new SparklineMixedDataItem()
        {
            Value = 15,
            Category = @"Other",
            Summary = @"Other 15%"
        });
    }
}
