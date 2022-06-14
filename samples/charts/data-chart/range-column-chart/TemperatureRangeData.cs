using System;
using System.Collections.Generic;
public class TemperatureRangeDataItem
{
    public string Month{ get; set; }
    public double HighNY{ get; set; }
    public double LowNY{ get; set; }
    public double HighLA{ get; set; }
    public double LowLA{ get; set; }
}
public class TemperatureRangeData
    : List<TemperatureRangeDataItem>
{
    public TemperatureRangeData()
    {
        this.Add(new TemperatureRangeDataItem()
        {
            Month = @"Jan",
            HighNY = 10.6,
            LowNY = -6.6,
            HighLA = 28.3,
            LowLA = 7.8
        });
        this.Add(new TemperatureRangeDataItem()
        {
            Month = @"Feb",
            HighNY = 7.8,
            LowNY = -9.9,
            HighLA = 31.1,
            LowLA = 5.6
        });
        this.Add(new TemperatureRangeDataItem()
        {
            Month = @"Mar",
            HighNY = 12.2,
            LowNY = -3.8,
            HighLA = 27.8,
            LowLA = 8.3
        });
        this.Add(new TemperatureRangeDataItem()
        {
            Month = @"Apr",
            HighNY = 11.7,
            LowNY = 2.2,
            HighLA = 33.9,
            LowLA = 10.6
        });
        this.Add(new TemperatureRangeDataItem()
        {
            Month = @"May",
            HighNY = 19.4,
            LowNY = 1.1,
            HighLA = 35,
            LowLA = 13.9
        });
        this.Add(new TemperatureRangeDataItem()
        {
            Month = @"Jun",
            HighNY = 23.3,
            LowNY = 10.6,
            HighLA = 36.7,
            LowLA = 16.1
        });
        this.Add(new TemperatureRangeDataItem()
        {
            Month = @"Jul",
            HighNY = 27.2,
            LowNY = 19.4,
            HighLA = 33.3,
            LowLA = 15.6
        });
        this.Add(new TemperatureRangeDataItem()
        {
            Month = @"Aug",
            HighNY = 25.6,
            LowNY = 16.7,
            HighLA = 36.7,
            LowLA = 15.6
        });
        this.Add(new TemperatureRangeDataItem()
        {
            Month = @"Sep",
            HighNY = 22.8,
            LowNY = 8.9,
            HighLA = 43.9,
            LowLA = 16.1
        });
        this.Add(new TemperatureRangeDataItem()
        {
            Month = @"Oct",
            HighNY = 17.8,
            LowNY = 0,
            HighLA = 38.3,
            LowLA = 11.1
        });
        this.Add(new TemperatureRangeDataItem()
        {
            Month = @"Nov",
            HighNY = 17.8,
            LowNY = -1,
            HighLA = 32.8,
            LowLA = 6.7
        });
        this.Add(new TemperatureRangeDataItem()
        {
            Month = @"Dec",
            HighNY = 8.3,
            LowNY = -6.6,
            HighLA = 28.9,
            LowLA = 5.6
        });
    }
}
