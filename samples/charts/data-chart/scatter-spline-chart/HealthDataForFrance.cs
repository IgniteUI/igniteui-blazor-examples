using System;
using System.Collections.Generic;
public class HealthDataForFranceItem
{
    public string Label{ get; set; }
    public double Shoes{ get; set; }
    public double Hats{ get; set; }
    public double Coats{ get; set; }
    public double Scarves{ get; set; }
}
public class HealthDataForFrance
    : List<HealthDataForFranceItem>
{
    public HealthDataForFrance()
    {
        this.Add(new HealthDataForFranceItem()
        {
            Label = @"2000",
            Shoes = 21,
            Hats = 40,
            Coats = 8,
            Scarves = 14
        });
        this.Add(new HealthDataForFranceItem()
        {
            Label = @"2001",
            Shoes = 24,
            Hats = 38,
            Coats = 9,
            Scarves = 16
        });
        this.Add(new HealthDataForFranceItem()
        {
            Label = @"2002",
            Shoes = 26,
            Hats = 38,
            Coats = 8,
            Scarves = 18
        });
        this.Add(new HealthDataForFranceItem()
        {
            Label = @"2003",
            Shoes = 31,
            Hats = 36,
            Coats = 10,
            Scarves = 20
        });
        this.Add(new HealthDataForFranceItem()
        {
            Label = @"2004",
            Shoes = 36,
            Hats = 36,
            Coats = 11,
            Scarves = 20
        });
        this.Add(new HealthDataForFranceItem()
        {
            Label = @"2005",
            Shoes = 30,
            Hats = 32,
            Coats = 12,
            Scarves = 22
        });
    }
}
