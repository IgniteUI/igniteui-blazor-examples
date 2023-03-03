using System;
using System.Collections.Generic;
public class TemperatureAverageDataLongLabelsItem
{
    public string Month { get; set; }
    public double Temperature { get; set; }
}

public class TemperatureAverageDataLongLabels
    : List<TemperatureAverageDataLongLabelsItem>
{
    public TemperatureAverageDataLongLabels()
    {
        this.Add(new TemperatureAverageDataLongLabelsItem()
        {
            Month = @"January",
            Temperature = 3
        });
        this.Add(new TemperatureAverageDataLongLabelsItem()
        {
            Month = @"February",
            Temperature = 4
        });
        this.Add(new TemperatureAverageDataLongLabelsItem()
        {
            Month = @"March",
            Temperature = 9
        });
        this.Add(new TemperatureAverageDataLongLabelsItem()
        {
            Month = @"April",
            Temperature = 15
        });
        this.Add(new TemperatureAverageDataLongLabelsItem()
        {
            Month = @"May",
            Temperature = 21
        });
        this.Add(new TemperatureAverageDataLongLabelsItem()
        {
            Month = @"Jun",
            Temperature = 26
        });
        this.Add(new TemperatureAverageDataLongLabelsItem()
        {
            Month = @"July",
            Temperature = 29
        });
        this.Add(new TemperatureAverageDataLongLabelsItem()
        {
            Month = @"August",
            Temperature = 28
        });
        this.Add(new TemperatureAverageDataLongLabelsItem()
        {
            Month = @"September",
            Temperature = 24
        });
        this.Add(new TemperatureAverageDataLongLabelsItem()
        {
            Month = @"October",
            Temperature = 18
        });
        this.Add(new TemperatureAverageDataLongLabelsItem()
        {
            Month = @"November",
            Temperature = 11
        });
        this.Add(new TemperatureAverageDataLongLabelsItem()
        {
            Month = @"December",
            Temperature = 5
        });
    }
}
