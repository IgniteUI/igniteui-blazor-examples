using System;
using System.Collections.Generic;
public class DashboardGaugeDataSourceItem
{
    public double Value { get; set; }
}

public class DashboardGaugeDataSource
    : List<DashboardGaugeDataSourceItem>
{
    public DashboardGaugeDataSource()
    {
        this.Add(new DashboardGaugeDataSourceItem()
        {
            Value = 40
        });
    }
}
