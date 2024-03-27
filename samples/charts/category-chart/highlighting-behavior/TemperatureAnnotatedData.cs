using System;
using System.Collections.Generic;
public class TemperatureAnnotatedDataItem
{
    public double Index { get; set; }
    public string TempInfo { get; set; }
    public double Temperature { get; set; }
    public string Month { get; set; }
}

public class TemperatureAnnotatedData
    : List<TemperatureAnnotatedDataItem>
{
    public TemperatureAnnotatedData()
    {
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 0,
            TempInfo = @"27°C",
            Temperature = 27,
            Month = @"Jan"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 1,
            TempInfo = @"25°C",
            Temperature = 25,
            Month = @"Feb"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 2,
            TempInfo = @"21°C",
            Temperature = 21,
            Month = @"Mar"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 3,
            TempInfo = @"19°C",
            Temperature = 19,
            Month = @"Apr"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 4,
            TempInfo = @"16°C",
            Temperature = 16,
            Month = @"May"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 5,
            TempInfo = @"13°C",
            Temperature = 13,
            Month = @"Jun"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 6,
            TempInfo = @"14°C",
            Temperature = 14,
            Month = @"Jul"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 7,
            TempInfo = @"15°C",
            Temperature = 15,
            Month = @"Aug"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 8,
            TempInfo = @"19°C",
            Temperature = 19,
            Month = @"Sep"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 9,
            TempInfo = @"22°C",
            Temperature = 22,
            Month = @"Oct"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 10,
            TempInfo = @"26°C",
            Temperature = 26,
            Month = @"Nov"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 11,
            TempInfo = @"30°C",
            Temperature = 30,
            Month = @"Dec"
        });
    }
}
