using System;
using System.Collections.Generic;
public class TemperatureAverageDataItem
{
    public string Month{ get; set; }
    public double Temperature{ get; set; }
}
public class TemperatureAverageData
    : List<TemperatureAverageDataItem>
{
    public TemperatureAverageData()
    {
        this.Add(new TemperatureAverageDataItem()
        {
            Month = @"Jan",
            Temperature = 3
        });
        this.Add(new TemperatureAverageDataItem()
        {
            Month = @"Feb",
            Temperature = 4
        });
        this.Add(new TemperatureAverageDataItem()
        {
            Month = @"Mar",
            Temperature = 9
        });
        this.Add(new TemperatureAverageDataItem()
        {
            Month = @"Apr",
            Temperature = 15
        });
        this.Add(new TemperatureAverageDataItem()
        {
            Month = @"May",
            Temperature = 21
        });
        this.Add(new TemperatureAverageDataItem()
        {
            Month = @"Jun",
            Temperature = 26
        });
        this.Add(new TemperatureAverageDataItem()
        {
            Month = @"Jul",
            Temperature = 29
        });
        this.Add(new TemperatureAverageDataItem()
        {
            Month = @"Aug",
            Temperature = 28
        });
        this.Add(new TemperatureAverageDataItem()
        {
            Month = @"Sep",
            Temperature = 24
        });
        this.Add(new TemperatureAverageDataItem()
        {
            Month = @"Oct",
            Temperature = 18
        });
        this.Add(new TemperatureAverageDataItem()
        {
            Month = @"Nov",
            Temperature = 11
        });
        this.Add(new TemperatureAverageDataItem()
        {
            Month = @"Dec",
            Temperature = 5
        });
    }
}
