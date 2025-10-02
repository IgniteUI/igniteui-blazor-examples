using System;
using System.Collections.Generic;
public class ContinentsBirthRateItem
{
    public string Year { get; set; }
    public double Asia { get; set; }
    public double Africa { get; set; }
    public double Europe { get; set; }
    public double NorthAmerica { get; set; }
    public double SouthAmerica { get; set; }
    public double Oceania { get; set; }
}

public class ContinentsBirthRate
    : List<ContinentsBirthRateItem>
{
    public ContinentsBirthRate()
    {
        this.Add(new ContinentsBirthRateItem() { Year = @"1950", Asia = 62, Africa = 13, Europe = 10, NorthAmerica = 4, SouthAmerica = 8, Oceania = 1 });
        this.Add(new ContinentsBirthRateItem() { Year = @"1960", Asia = 68, Africa = 12, Europe = 15, NorthAmerica = 4, SouthAmerica = 9, Oceania = 2 });
        this.Add(new ContinentsBirthRateItem() { Year = @"1970", Asia = 80, Africa = 17, Europe = 11, NorthAmerica = 3, SouthAmerica = 9, Oceania = 1 });
        this.Add(new ContinentsBirthRateItem() { Year = @"1980", Asia = 77, Africa = 21, Europe = 12, NorthAmerica = 3, SouthAmerica = 10, Oceania = 2 });
        this.Add(new ContinentsBirthRateItem() { Year = @"1990", Asia = 87, Africa = 24, Europe = 9, NorthAmerica = 3, SouthAmerica = 10, Oceania = 1 });
        this.Add(new ContinentsBirthRateItem() { Year = @"2000", Asia = 79, Africa = 28, Europe = 8, NorthAmerica = 4, SouthAmerica = 9, Oceania = 3 });
        this.Add(new ContinentsBirthRateItem() { Year = @"2010", Asia = 78, Africa = 35, Europe = 10, NorthAmerica = 4, SouthAmerica = 8, Oceania = 2 });
        this.Add(new ContinentsBirthRateItem() { Year = @"2020", Asia = 75, Africa = 43, Europe = 7, NorthAmerica = 4, SouthAmerica = 7, Oceania = 4 });
    }
}
