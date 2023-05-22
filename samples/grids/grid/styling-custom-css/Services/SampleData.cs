using System.Collections.Generic;

public class LocalDataItem
{
    public double MarketShare { get; set; }
    public string Category { get; set; }
    public string Summary { get; set; }
}

public class LocalData
    : List<LocalDataItem>
{
    public LocalData()
    {
        this.Add(new LocalDataItem()
        {
            MarketShare = 37,
            Category = @"Cooling",
            Summary = @"Cooling 37%"
        });
        this.Add(new LocalDataItem()
        {
            MarketShare = 25,
            Category = @"Residential",
            Summary = @"Residential 25%"
        });
        this.Add(new LocalDataItem()
        {
            MarketShare = 12,
            Category = @"Heating",
            Summary = @"Heating 12%"
        });
        this.Add(new LocalDataItem()
        {
            MarketShare = 11,
            Category = @"Lighting",
            Summary = @"Lighting 11%"
        });
        this.Add(new LocalDataItem()
        {
            MarketShare = 15,
            Category = @"Other",
            Summary = @"Other 15%"
        });
    }
}
