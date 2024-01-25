using System;
using System.Collections.Generic;
public class CountryRenewableElectricityFilteredItem
{
    public string Year { get; set; }
    public double Europe { get; set; }
    public double China { get; set; }
    public double America { get; set; }
}

public class CountryRenewableElectricityFiltered
    : List<CountryRenewableElectricityFilteredItem>
{
    public CountryRenewableElectricityFiltered()
    {
        this.Add(new CountryRenewableElectricityFilteredItem()
        {
            Year = @"2009",
            Europe = 26,
            China = 14,
            America = 12
        });
        this.Add(new CountryRenewableElectricityFilteredItem()
        {
            Year = @"2010",
            Europe = 29,
            China = 17,
            America = 18
        });
        this.Add(new CountryRenewableElectricityFilteredItem()
        {
            Year = @"2011",
            Europe = 50,
            China = 21,
            America = 22
        });
        this.Add(new CountryRenewableElectricityFilteredItem()
        {
            Year = @"2012",
            Europe = 48,
            China = 20,
            America = 20
        });
        this.Add(new CountryRenewableElectricityFilteredItem()
        {
            Year = @"2013",
            Europe = 37,
            China = 23,
            America = 26
        });
        this.Add(new CountryRenewableElectricityFilteredItem()
        {
            Year = @"2014",
            Europe = 26,
            China = 34,
            America = 21
        });
        this.Add(new CountryRenewableElectricityFilteredItem()
        {
            Year = @"2015",
            Europe = 55,
            China = 38,
            America = 12
        });
        this.Add(new CountryRenewableElectricityFilteredItem()
        {
            Year = @"2016",
            Europe = 7,
            China = 55,
            America = 38
        });
        this.Add(new CountryRenewableElectricityFilteredItem()
        {
            Year = @"2017",
            Europe = 57,
            China = 101,
            America = 32
        });
        this.Add(new CountryRenewableElectricityFilteredItem()
        {
            Year = @"2018",
            Europe = 23,
            China = 112,
            America = 19
        });
        this.Add(new CountryRenewableElectricityFilteredItem()
        {
            Year = @"2018",
            Europe = 18,
            China = 118,
            America = 22
        });
        this.Add(new CountryRenewableElectricityFilteredItem()
        {
            Year = @"2019",
            Europe = 40,
            China = 70,
            America = 26
        });
    }
}
