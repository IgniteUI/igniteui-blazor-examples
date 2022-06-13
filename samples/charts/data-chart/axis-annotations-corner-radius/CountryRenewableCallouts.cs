using System;
using System.Collections.Generic;
public class CountryRenewableCalloutsItem
{
    public double Index{ get; set; }
    public string Label{ get; set; }
    public double Value{ get; set; }
}
public class CountryRenewableCallouts
    : List<CountryRenewableCalloutsItem>
{
    public CountryRenewableCallouts()
    {
        this.Add(new CountryRenewableCalloutsItem()
        {
            Index = 0,
            Label = @"19 TWh",
            Value = 19
        });
        this.Add(new CountryRenewableCalloutsItem()
        {
            Index = 1,
            Label = @"24 TWh",
            Value = 24
        });
        this.Add(new CountryRenewableCalloutsItem()
        {
            Index = 2,
            Label = @"28 TWh",
            Value = 28
        });
        this.Add(new CountryRenewableCalloutsItem()
        {
            Index = 3,
            Label = @"26 TWh",
            Value = 26
        });
        this.Add(new CountryRenewableCalloutsItem()
        {
            Index = 4,
            Label = @"38 TWh",
            Value = 38
        });
        this.Add(new CountryRenewableCalloutsItem()
        {
            Index = 5,
            Label = @"31 TWh",
            Value = 31
        });
        this.Add(new CountryRenewableCalloutsItem()
        {
            Index = 6,
            Label = @"19 TWh",
            Value = 19
        });
        this.Add(new CountryRenewableCalloutsItem()
        {
            Index = 7,
            Label = @"52 TWh",
            Value = 52
        });
        this.Add(new CountryRenewableCalloutsItem()
        {
            Index = 8,
            Label = @"50 TWh",
            Value = 50
        });
        this.Add(new CountryRenewableCalloutsItem()
        {
            Index = 9,
            Label = @"34 TWh",
            Value = 34
        });
        this.Add(new CountryRenewableCalloutsItem()
        {
            Index = 10,
            Label = @"38 TWh",
            Value = 34
        });
        this.Add(new CountryRenewableCalloutsItem()
        {
            Index = 11,
            Label = @"38 TWh",
            Value = 38
        });
    }
}
