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
        this.Add(new CountryStatsAfricaItem() { Code = @"DZA", Population = 39728000, WorkedHours = 47.5, GDP = 13725, Name = @"Algeria" });
        this.Add(new CountryStatsAfricaItem() { Code = @"AGO", Population = 27884000, WorkedHours = 39.8, GDP = 6228, Name = @"Angola" });
        this.Add(new CountryStatsAfricaItem() { Code = @"BEN", Population = 10576000, WorkedHours = 43.7, GDP = 1987, Name = @"Benin" });
        this.Add(new CountryStatsAfricaItem() { Code = @"BWA", Population = 2121000, WorkedHours = 41.2, GDP = 15357, Name = @"Botswana" });
        this.Add(new CountryStatsAfricaItem() { Code = @"BFA", Population = 18111000, WorkedHours = 39.3, GDP = 1596, Name = @"Burkina Faso" });
        this.Add(new CountryStatsAfricaItem() { Code = @"BDI", Population = 10160000, WorkedHours = 36.4, GDP = 748, Name = @"Burundi" });
        this.Add(new CountryStatsAfricaItem() { Code = @"CMR", Population = 23298000, WorkedHours = 42, GDP = 3289, Name = @"Cameroon" });
        this.Add(new CountryStatsAfricaItem() { Code = @"CPV", Population = 525000, WorkedHours = 45, GDP = 5915, Name = @"Cape Verde" });
        this.Add(new CountryStatsAfricaItem() { Code = @"CAF", Population = 4493000, WorkedHours = 38, GDP = 622, Name = @"Central African Republic" });
        this.Add(new CountryStatsAfricaItem() { Code = @"TCD", Population = 14111000, WorkedHours = 40.4, GDP = 2067, Name = @"Chad" });
        this.Add(new CountryStatsAfricaItem() { Code = @"COM", Population = 777000, WorkedHours = 40.1, GDP = 1413, Name = @"Comoros" });
        this.Add(new CountryStatsAfricaItem() { Code = @"COG", Population = 4856000, WorkedHours = 38.1, GDP = 5543, Name = @"Congo" });
        this.Add(new CountryStatsAfricaItem() { Code = @"CIV", Population = 23226000, WorkedHours = 39.7, GDP = 3242, Name = @"Cote Ivoire" });
        this.Add(new CountryStatsAfricaItem() { Code = @"COD", Population = 76245000, WorkedHours = 44, GDP = 812, Name = @"Democratic Republic of Congo" });
        this.Add(new CountryStatsAfricaItem() { Code = @"EGY", Population = 92443000, WorkedHours = 39.7, GDP = 10096, Name = @"Egypt" });
        this.Add(new CountryStatsAfricaItem() { Code = @"GNQ", Population = 1169000, WorkedHours = 38.8, GDP = 27554, Name = @"Equatorial Guinea" });
        this.Add(new CountryStatsAfricaItem() { Code = @"SWZ", Population = 1104000, WorkedHours = 45.7, GDP = 7759, Name = @"Eswatini" });
        this.Add(new CountryStatsAfricaItem() { Code = @"ETH", Population = 101000000, WorkedHours = 40.1, GDP = 1533, Name = @"Ethiopia" });
        this.Add(new CountryStatsAfricaItem() { Code = @"GAB", Population = 1948000, WorkedHours = 40.5, GDP = 16837, Name = @"Gabon" });
        this.Add(new CountryStatsAfricaItem() { Code = @"GMB", Population = 2086000, WorkedHours = 40.3, GDP = 1568, Name = @"Gambia" });
        this.Add(new CountryStatsAfricaItem() { Code = @"GHA", Population = 27849000, WorkedHours = 47.6, GDP = 3927, Name = @"Ghana" });
        this.Add(new CountryStatsAfricaItem() { Code = @"GIN", Population = 11432000, WorkedHours = 43.4, GDP = 1758, Name = @"Guinea" });
        this.Add(new CountryStatsAfricaItem() { Code = @"GNB", Population = 1737000, WorkedHours = 35.1, GDP = 1446, Name = @"Guinea-Bissau" });
        this.Add(new CountryStatsAfricaItem() { Code = @"KEN", Population = 47878000, WorkedHours = 43.9, GDP = 2836, Name = @"Kenya" });
        this.Add(new CountryStatsAfricaItem() { Code = @"LSO", Population = 2059000, WorkedHours = 47.6, GDP = 2708, Name = @"Lesotho" });
        this.Add(new CountryStatsAfricaItem() { Code = @"LBR", Population = 4472000, WorkedHours = 40.3, GDP = 785, Name = @"Liberia" });
        this.Add(new CountryStatsAfricaItem() { Code = @"LBY", Population = 6418000, WorkedHours = 42.5, GDP = 14847, Name = @"Libya" });
        this.Add(new CountryStatsAfricaItem() { Code = @"MDG", Population = 24234000, WorkedHours = 40.8, GDP = 1377, Name = @"Madagascar" });
        this.Add(new CountryStatsAfricaItem() { Code = @"MWI", Population = 16745000, WorkedHours = 44.5, GDP = 1089, Name = @"Malawi" });
        this.Add(new CountryStatsAfricaItem() { Code = @"MLI", Population = 17439000, WorkedHours = 40.6, GDP = 1919, Name = @"Mali" });
        this.Add(new CountryStatsAfricaItem() { Code = @"MRT", Population = 4046000, WorkedHours = 45.9, GDP = 3602, Name = @"Mauritania" });
        this.Add(new CountryStatsAfricaItem() { Code = @"MUS", Population = 1259000, WorkedHours = 44.4, GDP = 18864, Name = @"Mauritius" });
        this.Add(new CountryStatsAfricaItem() { Code = @"MAR", Population = 34664000, WorkedHours = 39.6, GDP = 7297, Name = @"Morocco" });
        this.Add(new CountryStatsAfricaItem() { Code = @"MOZ", Population = 27042000, WorkedHours = 46.7, GDP = 1118, Name = @"Mozambique" });
        this.Add(new CountryStatsAfricaItem() { Code = @"NAM", Population = 2315000, WorkedHours = 43.1, GDP = 9975, Name = @"Namibia" });
        this.Add(new CountryStatsAfricaItem() { Code = @"NER", Population = 20002000, WorkedHours = 45, GDP = 908, Name = @"Niger" });
        this.Add(new CountryStatsAfricaItem() { Code = @"NGA", Population = 181000000, WorkedHours = 32.76, GDP = 5671, Name = @"Nigeria" });
        this.Add(new CountryStatsAfricaItem() { Code = @"RWA", Population = 11369000, WorkedHours = 46.3, GDP = 1731, Name = @"Rwanda" });
        this.Add(new CountryStatsAfricaItem() { Code = @"STP", Population = 199000, WorkedHours = 38.2, GDP = 2948, Name = @"Sao Tome" });
        this.Add(new CountryStatsAfricaItem() { Code = @"SEN", Population = 14578000, WorkedHours = 46.8, GDP = 2294, Name = @"Senegal" });
        this.Add(new CountryStatsAfricaItem() { Code = @"SYC", Population = 95000, WorkedHours = 39.8, GDP = 24857, Name = @"Seychelles" });
        this.Add(new CountryStatsAfricaItem() { Code = @"SLE", Population = 7172000, WorkedHours = 35.4, GDP = 1314, Name = @"Sierra Leone" });
        this.Add(new CountryStatsAfricaItem() { Code = @"ZAF", Population = 55386000, WorkedHours = 42.48, GDP = 12378, Name = @"South Africa" });
        this.Add(new CountryStatsAfricaItem() { Code = @"SSD", Population = 10716000, WorkedHours = 39.3, GDP = 1875, Name = @"South Sudan" });
        this.Add(new CountryStatsAfricaItem() { Code = @"SDN", Population = 38903000, WorkedHours = 36.3, GDP = 4290, Name = @"Sudan" });
        this.Add(new CountryStatsAfricaItem() { Code = @"TZA", Population = 51483000, WorkedHours = 38, GDP = 2491, Name = @"Tanzania" });
        this.Add(new CountryStatsAfricaItem() { Code = @"TGO", Population = 7323000, WorkedHours = 38.8, GDP = 1351, Name = @"Togo" });
        this.Add(new CountryStatsAfricaItem() { Code = @"TUN", Population = 11180000, WorkedHours = 35.2, GDP = 10766, Name = @"Tunisia" });
        this.Add(new CountryStatsAfricaItem() { Code = @"UGA", Population = 38225000, WorkedHours = 38.6, GDP = 1666, Name = @"Uganda" });
        this.Add(new CountryStatsAfricaItem() { Code = @"ZMB", Population = 15879000, WorkedHours = 46.6, GDP = 3627, Name = @"Zambia" });
        this.Add(new CountryStatsAfricaItem() { Code = @"ZWE", Population = 13815000, WorkedHours = 41.4, GDP = 1912, Name = @"Zimbabwe" });
    }
}
