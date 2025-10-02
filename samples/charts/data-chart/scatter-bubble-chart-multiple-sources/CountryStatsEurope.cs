using System;
using System.Collections.Generic;
public class CountryStatsEuropeItem
{
    public string Code { get; set; }
    public double Population { get; set; }
    public double WorkedHours { get; set; }
    public double GDP { get; set; }
    public string Name { get; set; }
}

public class CountryStatsEurope
    : List<CountryStatsEuropeItem>
{
    public CountryStatsEurope()
    {
        this.Add(new CountryStatsEuropeItem() { Code = @"ALB", Population = 2891000, WorkedHours = 41, GDP = 10970, Name = @"Albania" });
        this.Add(new CountryStatsEuropeItem() { Code = @"AUT", Population = 8679000, WorkedHours = 30.75, GDP = 44305, Name = @"Austria" });
        this.Add(new CountryStatsEuropeItem() { Code = @"BLR", Population = 9439000, WorkedHours = 43.5, GDP = 17230, Name = @"Belarus" });
        this.Add(new CountryStatsEuropeItem() { Code = @"BEL", Population = 11288000, WorkedHours = 29.7, GDP = 41708, Name = @"Belgium" });
        this.Add(new CountryStatsEuropeItem() { Code = @"BIH", Population = 3429000, WorkedHours = 46.5, GDP = 10932, Name = @"Bosnia" });
        this.Add(new CountryStatsEuropeItem() { Code = @"BGR", Population = 7200000, WorkedHours = 31.62, GDP = 17000, Name = @"Bulgaria" });
        this.Add(new CountryStatsEuropeItem() { Code = @"HRV", Population = 4233000, WorkedHours = 35.15, GDP = 20984, Name = @"Croatia" });
        this.Add(new CountryStatsEuropeItem() { Code = @"CYP", Population = 1161000, WorkedHours = 34.42, GDP = 30549, Name = @"Cyprus" });
        this.Add(new CountryStatsEuropeItem() { Code = @"CZE", Population = 10601000, WorkedHours = 33.77, GDP = 30605, Name = @"Czechia" });
        this.Add(new CountryStatsEuropeItem() { Code = @"DNK", Population = 5689000, WorkedHours = 27.16, GDP = 45459, Name = @"Denmark" });
        this.Add(new CountryStatsEuropeItem() { Code = @"EST", Population = 1315000, WorkedHours = 35.61, GDP = 27550, Name = @"Estonia" });
        this.Add(new CountryStatsEuropeItem() { Code = @"FIN", Population = 5481000, WorkedHours = 31.48, GDP = 38942, Name = @"Finland" });
        this.Add(new CountryStatsEuropeItem() { Code = @"FRA", Population = 64453000, WorkedHours = 29.03, GDP = 37766, Name = @"France" });
        this.Add(new CountryStatsEuropeItem() { Code = @"DEU", Population = 81787000, WorkedHours = 26.31, GDP = 43938, Name = @"Germany" });
        this.Add(new CountryStatsEuropeItem() { Code = @"GRC", Population = 10660000, WorkedHours = 39.06, GDP = 24170, Name = @"Greece" });
        this.Add(new CountryStatsEuropeItem() { Code = @"HUN", Population = 9778000, WorkedHours = 36.99, GDP = 25034, Name = @"Hungary" });
        this.Add(new CountryStatsEuropeItem() { Code = @"ISL", Population = 330000, WorkedHours = 29.02, GDP = 43048, Name = @"Iceland" });
        this.Add(new CountryStatsEuropeItem() { Code = @"IRL", Population = 4652000, WorkedHours = 33.47, GDP = 60818, Name = @"Ireland" });
        this.Add(new CountryStatsEuropeItem() { Code = @"ITA", Population = 60578000, WorkedHours = 33.04, GDP = 34302, Name = @"Italy" });
        this.Add(new CountryStatsEuropeItem() { Code = @"LVA", Population = 1998000, WorkedHours = 36.57, GDP = 23019, Name = @"Latvia" });
        this.Add(new CountryStatsEuropeItem() { Code = @"LTU", Population = 2932000, WorkedHours = 35.76, GDP = 27046, Name = @"Lithuania" });
        this.Add(new CountryStatsEuropeItem() { Code = @"LUX", Population = 567000, WorkedHours = 29.25, GDP = 94089, Name = @"Luxembourg" });
        this.Add(new CountryStatsEuropeItem() { Code = @"MLT", Population = 434000, WorkedHours = 37.78, GDP = 34087, Name = @"Malta" });
        this.Add(new CountryStatsEuropeItem() { Code = @"MDA", Population = 4071000, WorkedHours = 41, GDP = 4747, Name = @"Moldova" });
        this.Add(new CountryStatsEuropeItem() { Code = @"MNE", Population = 627000, WorkedHours = 47.2, GDP = 15290, Name = @"Montenegro" });
        this.Add(new CountryStatsEuropeItem() { Code = @"NLD", Population = 16938000, WorkedHours = 27.38, GDP = 46494, Name = @"Netherlands" });
        this.Add(new CountryStatsEuropeItem() { Code = @"MKD", Population = 2079000, WorkedHours = 36.6, GDP = 12760, Name = @"North Macedonia" });
        this.Add(new CountryStatsEuropeItem() { Code = @"NOR", Population = 5200000, WorkedHours = 27.36, GDP = 64008, Name = @"Norway" });
        this.Add(new CountryStatsEuropeItem() { Code = @"POL", Population = 38034000, WorkedHours = 39.4, GDP = 25300, Name = @"Poland" });
        this.Add(new CountryStatsEuropeItem() { Code = @"PRT", Population = 10368000, WorkedHours = 36.06, GDP = 26608, Name = @"Portugal" });
        this.Add(new CountryStatsEuropeItem() { Code = @"ROU", Population = 19925000, WorkedHours = 34.34, GDP = 20556, Name = @"Romania" });
        this.Add(new CountryStatsEuropeItem() { Code = @"RUS", Population = 145000000, WorkedHours = 38.04, GDP = 24517, Name = @"Russia" });
        this.Add(new CountryStatsEuropeItem() { Code = @"SMR", Population = 33000, WorkedHours = 40.1, GDP = 56372, Name = @"San Marino" });
        this.Add(new CountryStatsEuropeItem() { Code = @"SRB", Population = 8877000, WorkedHours = 46.5, GDP = 13278, Name = @"Serbia" });
        this.Add(new CountryStatsEuropeItem() { Code = @"SVK", Population = 5436000, WorkedHours = 33.73, GDP = 28309, Name = @"Slovakia" });
        this.Add(new CountryStatsEuropeItem() { Code = @"SVN", Population = 2071000, WorkedHours = 32.46, GDP = 29038, Name = @"Slovenia" });
        this.Add(new CountryStatsEuropeItem() { Code = @"ESP", Population = 46672000, WorkedHours = 32.68, GDP = 32291, Name = @"Spain" });
        this.Add(new CountryStatsEuropeItem() { Code = @"SWE", Population = 9765000, WorkedHours = 30.96, GDP = 45679, Name = @"Sweden" });
        this.Add(new CountryStatsEuropeItem() { Code = @"CHE", Population = 8297000, WorkedHours = 30.57, GDP = 57264, Name = @"Switzerland" });
        this.Add(new CountryStatsEuropeItem() { Code = @"UKR", Population = 44922000, WorkedHours = 38.6, GDP = 7465, Name = @"Ukraine" });
        this.Add(new CountryStatsEuropeItem() { Code = @"GBR", Population = 65860000, WorkedHours = 32.1, GDP = 38839, Name = @"United Kingdom" });
    }
}
