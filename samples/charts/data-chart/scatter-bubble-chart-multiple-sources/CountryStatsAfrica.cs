using System;
using System.Collections.Generic;
public class CountryStatsAfricaItem
{
    public string Code { get; set; }
    public double Population { get; set; }
    public double WorkedHours { get; set; }
    public double GDP { get; set; }
    public string Name { get; set; }
}

public class CountryStatsAfrica
    : List<CountryStatsAfricaItem>
{
    public CountryStatsAfrica()
    {
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"DZA",
            Population = 39728000,
            WorkedHours = 47.5,
            GDP = 13725,
            Name = @"Algeria"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"AGO",
            Population = 27884000,
            WorkedHours = 39.8,
            GDP = 6228,
            Name = @"Angola"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"BEN",
            Population = 10576000,
            WorkedHours = 43.7,
            GDP = 1987,
            Name = @"Benin"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"BWA",
            Population = 2121000,
            WorkedHours = 41.2,
            GDP = 15357,
            Name = @"Botswana"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"BFA",
            Population = 18111000,
            WorkedHours = 39.3,
            GDP = 1596,
            Name = @"Burkina Faso"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"BDI",
            Population = 10160000,
            WorkedHours = 36.4,
            GDP = 748,
            Name = @"Burundi"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"CMR",
            Population = 23298000,
            WorkedHours = 42,
            GDP = 3289,
            Name = @"Cameroon"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"CPV",
            Population = 525000,
            WorkedHours = 45,
            GDP = 5915,
            Name = @"Cape Verde"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"CAF",
            Population = 4493000,
            WorkedHours = 38,
            GDP = 622,
            Name = @"C.A.R"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"TCD",
            Population = 14111000,
            WorkedHours = 40.4,
            GDP = 2067,
            Name = @"Chad"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"COM",
            Population = 777000,
            WorkedHours = 40.1,
            GDP = 1413,
            Name = @"Comoros"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"COG",
            Population = 4856000,
            WorkedHours = 38.1,
            GDP = 5543,
            Name = @"Congo"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"CIV",
            Population = 23226000,
            WorkedHours = 39.7,
            GDP = 3242,
            Name = @"Cote Ivoire"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"COD",
            Population = 76245000,
            WorkedHours = 44,
            GDP = 812,
            Name = @"DRC"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"EGY",
            Population = 92443000,
            WorkedHours = 39.7,
            GDP = 10096,
            Name = @"Egypt"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"GNQ",
            Population = 1169000,
            WorkedHours = 38.8,
            GDP = 27554,
            Name = @"Equatorial Guinea"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"SWZ",
            Population = 1104000,
            WorkedHours = 45.7,
            GDP = 7759,
            Name = @"Eswatini"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"ETH",
            Population = 101000000,
            WorkedHours = 40.1,
            GDP = 1533,
            Name = @"Ethiopia"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"GAB",
            Population = 1948000,
            WorkedHours = 40.5,
            GDP = 16837,
            Name = @"Gabon"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"GMB",
            Population = 2086000,
            WorkedHours = 40.3,
            GDP = 1568,
            Name = @"Gambia"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"GHA",
            Population = 27849000,
            WorkedHours = 47.6,
            GDP = 3927,
            Name = @"Ghana"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"GIN",
            Population = 11432000,
            WorkedHours = 43.4,
            GDP = 1758,
            Name = @"Guinea"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"GNB",
            Population = 1737000,
            WorkedHours = 35.1,
            GDP = 1446,
            Name = @"Guinea-Bissau"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"KEN",
            Population = 47878000,
            WorkedHours = 43.9,
            GDP = 2836,
            Name = @"Kenya"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"LSO",
            Population = 2059000,
            WorkedHours = 47.6,
            GDP = 2708,
            Name = @"Lesotho"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"LBR",
            Population = 4472000,
            WorkedHours = 40.3,
            GDP = 785,
            Name = @"Liberia"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"LBY",
            Population = 6418000,
            WorkedHours = 42.5,
            GDP = 14847,
            Name = @"Libya"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"MDG",
            Population = 24234000,
            WorkedHours = 40.8,
            GDP = 1377,
            Name = @"Madagascar"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"MWI",
            Population = 16745000,
            WorkedHours = 44.5,
            GDP = 1089,
            Name = @"Malawi"
        });
        this.Add(new CountryStatsAfricaItem()
        {
            Code = @"MLI",
            Population = 17439000,
            WorkedHours = 40.6,
            GDP = 1919,
            Name = @"Mali"
        });
    }
}
