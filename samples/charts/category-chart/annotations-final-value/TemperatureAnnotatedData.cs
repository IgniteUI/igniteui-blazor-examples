using System;
using System.Collections.Generic;
public class TemperatureAnnotatedDataItem
{
    public double Index{ get; set; }
    public double Temperature{ get; set; }
    public string TempInfo{ get; set; }
    public string Month{ get; set; }
}
public class TemperatureAnnotatedData
    : List<TemperatureAnnotatedDataItem>
{
    public TemperatureAnnotatedData()
    {
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 0,
            Temperature = 27,
            TempInfo = @"27°C",
            Month = @"Jan"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 1,
            Temperature = 25,
            TempInfo = @"25°C",
            Month = @"Feb"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 2,
            Temperature = 21,
            TempInfo = @"21°C",
            Month = @"Mar"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 3,
            Temperature = 19,
            TempInfo = @"19°C",
            Month = @"Apr"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 4,
            Temperature = 16,
            TempInfo = @"16°C",
            Month = @"May"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 5,
            Temperature = 13,
            TempInfo = @"13°C",
            Month = @"Jun"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 6,
            Temperature = 14,
            TempInfo = @"14°C",
            Month = @"Jul"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 7,
            Temperature = 15,
            TempInfo = @"15°C",
            Month = @"Aug"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 8,
            Temperature = 19,
            TempInfo = @"19°C",
            Month = @"Sep"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 9,
            Temperature = 22,
            TempInfo = @"22°C",
            Month = @"Oct"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 10,
            Temperature = 26,
            TempInfo = @"26°C",
            Month = @"Nov"
        });
        this.Add(new TemperatureAnnotatedDataItem()
        {
            Index = 11,
            Temperature = 30,
            TempInfo = @"30°C",
            Month = @"Dec"
        });
    }
}
