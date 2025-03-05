using System;
using System.Collections.Generic;
public class DataPieDataItem
{
    public double V1 { get; set; }
    public string Category { get; set; }
}

public class DataPieData
    : List<DataPieDataItem>
{
    public DataPieData()
    {
        this.Add(new DataPieDataItem()
        {
            V1 = 100,
            Category = @"Maintenance"
        });
        this.Add(new DataPieDataItem()
        {
            V1 = 40,
            Category = @"Cooling"
        });
        this.Add(new DataPieDataItem()
        {
            V1 = 20,
            Category = @"Residential"
        });
        this.Add(new DataPieDataItem()
        {
            V1 = 15,
            Category = @"Utilities"
        });
        this.Add(new DataPieDataItem()
        {
            V1 = 10,
            Category = @"Heating"
        });
        this.Add(new DataPieDataItem()
        {
            V1 = 5,
            Category = @"Lighting"
        });
        this.Add(new DataPieDataItem()
        {
            V1 = 4,
            Category = @"Electric"
        });
        this.Add(new DataPieDataItem()
        {
            V1 = 3,
            Category = @"Misc"
        });
    }
}
