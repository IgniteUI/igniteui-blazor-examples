using System;
using System.Collections.Generic;
public class CountryRenewableElectricityItem
{
    public string Year{ get; set; }
    public double Europe{ get; set; }
    public double China{ get; set; }
    public double USA{ get; set; }
}
public class CountryRenewableElectricity
    : List<CountryRenewableElectricityItem>
{
    public CountryRenewableElectricity()
    {
        this.Add(new CountryRenewableElectricityItem()
        {
            Year = @"2009",
            Europe = 34,
            China = 21,
            USA = 19
        });
        this.Add(new CountryRenewableElectricityItem()
        {
            Year = @"2010",
            Europe = 43,
            China = 26,
            USA = 24
        });
        this.Add(new CountryRenewableElectricityItem()
        {
            Year = @"2011",
            Europe = 66,
            China = 29,
            USA = 28
        });
        this.Add(new CountryRenewableElectricityItem()
        {
            Year = @"2012",
            Europe = 69,
            China = 32,
            USA = 26
        });
        this.Add(new CountryRenewableElectricityItem()
        {
            Year = @"2013",
            Europe = 58,
            China = 47,
            USA = 38
        });
        this.Add(new CountryRenewableElectricityItem()
        {
            Year = @"2014",
            Europe = 40,
            China = 46,
            USA = 31
        });
        this.Add(new CountryRenewableElectricityItem()
        {
            Year = @"2015",
            Europe = 78,
            China = 50,
            USA = 19
        });
        this.Add(new CountryRenewableElectricityItem()
        {
            Year = @"2016",
            Europe = 13,
            China = 90,
            USA = 52
        });
        this.Add(new CountryRenewableElectricityItem()
        {
            Year = @"2017",
            Europe = 78,
            China = 132,
            USA = 50
        });
        this.Add(new CountryRenewableElectricityItem()
        {
            Year = @"2018",
            Europe = 40,
            China = 134,
            USA = 34
        });
        this.Add(new CountryRenewableElectricityItem()
        {
            Year = @"2018",
            Europe = 40,
            China = 134,
            USA = 34
        });
        this.Add(new CountryRenewableElectricityItem()
        {
            Year = @"2019",
            Europe = 80,
            China = 96,
            USA = 38
        });
    }
}
