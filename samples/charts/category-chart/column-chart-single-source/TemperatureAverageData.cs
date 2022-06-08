using System;
using System.Collections.Generic;
public class TemperatureAverageDataItem
{
    public double MarketShare{ get; set; }
    public string Category{ get; set; }
    public string Summary{ get; set; }
}
public class TemperatureAverageData
    : List<TemperatureAverageDataItem>
{
    public TemperatureAverageData()
    {
        this.Add(new TemperatureAverageDataItem()
        {
            MarketShare = 30,
            Category = @"Google",
            Summary = @"Google 30%"
        });
        this.Add(new TemperatureAverageDataItem()
        {
            MarketShare = 25,
            Category = @"Apple",
            Summary = @"Apple 25%"
        });
        this.Add(new TemperatureAverageDataItem()
        {
            MarketShare = 20,
            Category = @"Microsoft",
            Summary = @"Microsoft 20%"
        });
        this.Add(new TemperatureAverageDataItem()
        {
            MarketShare = 15,
            Category = @"Samsung",
            Summary = @"Samsung 15%"
        });
        this.Add(new TemperatureAverageDataItem()
        {
            MarketShare = 10,
            Category = @"Other",
            Summary = @"Other 10%"
        });
    }
}
