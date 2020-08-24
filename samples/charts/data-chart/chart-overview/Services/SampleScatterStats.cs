using System;
using System.Collections.Generic;

namespace Samples
{
    public class SampleScatterStats
    {
        public static List<Country> countries;

        public static List<Country> GetCountries(int? count) {
            if (countries == null) countries = InitData();

            if (count == null) {
                count = 1000;
            }

            var items = new List<Country>();
            for (var i = 0; i < countries.Count; i++) {
                var country = countries[i];
                if (i < count) {
                    items.Add(country);
                }
            }

            items.Sort(SortByPopDescending);
            return items;
        }

        public static List<Country> GetCountriesWithHighIncome() {
            if (countries == null) countries = InitData();

            var items = new List<Country>();
            foreach (var country in countries)
            {
                if (country.GdpPerCapita >= 10000)
                {
                    items.Add(country);
                }
            }
            return items;
        }

        public static List<Country> GetCountriesWithLowIncome() {
            if (countries == null) countries = InitData();

            var items = new List<Country>();
            foreach (var country in countries) {
                if (country.GdpPerCapita < 10000)
                {
                    items.Add(country);
                }
            }
            return items;
        }

        public static List<Country> GetCountriesWithLargePop()
        {
            if (countries == null) countries = InitData();
            var items = new List<Country>();
            foreach (var country in countries)
            {
                if (country.Population >= 10000000)
                {
                    items.Add(country);
                }
            }
            return items;
        }

        public static List<Country> GetCountriesWithSmallPop()
        {
            if (countries == null) countries = InitData();
            var items = new List<Country>();
            foreach (var country in countries)
            {
                if (country.Population < 10000000)
                {
                    items.Add(country);
                }
            }
            return items;
        }

        public static int SortByPopDescending(Country a, Country b)
        {
            if (a.Population > b.Population) { return 1; }
            if (a.Population < b.Population) { return -1; }
            return 0;
        }

        public static int SortByPopAscending(Country a, Country b)
        {
            if (a.Population > b.Population) { return -1; }
            if (a.Population < b.Population) { return 1; }
            return 0;
        }

        public static int SortByGdpAscending(Country a, Country b)
        {
            if (a.GdpPerCapita > b.GdpPerCapita) { return -1; }
            if (a.GdpPerCapita < b.GdpPerCapita) { return 1; }
            return 0;
        }

        public static int SortByGdpDescending(Country a, Country b)
        {
            if (a.GdpPerCapita > b.GdpPerCapita) { return 1; }
            if (a.GdpPerCapita < b.GdpPerCapita) { return -1; }
            return 0;
        }

        public static int SortByDepDescending(Country a, Country b)
        {
            if (a.DptPerCapita > b.DptPerCapita) { return 1; }
            if (a.DptPerCapita < b.DptPerCapita) { return -1; }
            return 0;
        }

        public static int SortByDptAscending(Country a, Country b)
        {
            if (a.DptPerCapita > b.DptPerCapita) { return -1; }
            if (a.DptPerCapita < b.DptPerCapita) { return 1; }
            return 0;
        }

        public static List<Country> InitData()
        {
            var data = new List<Country>
            {
                // Code, Population, GDP per Capita, Debt per Capita, Mobile Phones (per 100 people), Name, Region
                new Country("AFG", 29824536, 688, 92, 46, "Afghanistan", "Asia"),
                new Country("ALB", 2801681, 4406, 882, 86, "Albania", "Europe"),
                new Country("DZA", 38481705, 5310, 115, 88, "Algeria", "Africa"),
                new Country("ADO", 78360, 40365, 15212, 84, "Andorra", "Europe"),
                new Country("AGO", 20820525, 5539, 944, 48, "Angola", "Africa"),
                new Country("ATG", 89069, 13406, 4388, 193, "Antigua and Barbuda", "North America"),
                new Country("ARG", 41086927, 14680, 7759, 141, "Argentina", "South America"),
                new Country("ARM", 2969081, 3354, 1584, 130, "Armenia", "Asia"),
                new Country("ABW", 102384, 0, 4935, 130, "Aruba", "South America"),
                new Country("AUS", 22723900, 67436, 52596, 100, "Australia", "Oceania"),
                new Country("AUT", 8429991, 46792, 90128, 146, "Austria", "Europe"),
                new Country("AZE", 9295784, 7394, 8513, 100, "Azerbaijan", "Asia"),
                new Country("BHS", 371960, 21908, 1067, 119, "Bahamas", "North America"),
                new Country("BHR", 1317827, 23040, 13261, 125, "Bahrain", "Asia"),
                new Country("BGD", 154695368, 750, 149, 45, "Bangladesh", "Asia"),
                new Country("BRB", 283221, 14917, 2456, 125, "Barbados", "North America"),
                new Country("BLR", 9464000, 6722, 2629, 109, "Belarus", "Europe"),
                new Country("BEL", 11128246, 43396, 113603, 111, "Belgium", "Europe"),
                new Country("BLZ", 324060, 4852, 3079, 63, "Belize", "North America"),
                new Country("BEN", 10050702, 751, 308, 74, "Benin", "Asia"),
                new Country("BMU", 64798, 84471, 2575, 136, "Bermuda", "North America"),
                new Country("BTN", 741822, 2509, 1193, 55, "Bhutan", "Asia"),
                new Country("BOL", 10496285, 2576, 275, 71, "Bolivia", "South America"),
                new Country("BIH", 3833916, 4396, 2052, 81, "Bosnia and Herzegovina", "Europe"),
                new Country("BWA", 2003910, 7255, 1208, 120, "Botswana", "Africa"),
                new Country("BRA", 198656019, 11320, 1608, 101, "Brazil", "South America"),
                new Country("BRN", 412238, 41127, 0, 109, "Brunei", "Oceania"),
                new Country("BGR", 7305888, 7022, 6261, 138, "Bulgaria", "Europe"),
                new Country("BFA", 16460141, 652, 136, 37, "Burkina Faso", "Africa"),
                new Country("BDI", 9849569, 251, 167, 18, "Burundi", "Africa"),
                new Country("CPV", 494401, 3554, 714, 76, "Cabo Verde", "Africa"),
                new Country("KHM", 14864646, 945, 304, 57, "Cambodia", "Asia"),
                new Country("CMR", 21699631, 1220, 164, 42, "Cameroon", "Africa"),
                new Country("CAN", 34754312, 52409, 29625, 76, "Canada", "North America"),
                new Country("CYM", 57570, 0, 2078, 181, "Cayman Islands", "North America"),
                new Country("CAF", 4525209, 479, 270, 23, "Central African Republic", "Africa"),
                new Country("TCD", 12448175, 1035, 160, 25, "Chad", "Africa"),
                new Country("CHL", 17464814, 15245, 5867, 116, "Chile", "South America"),
                new Country("CHN", 1350695000, 6093, 2221, 63, "China", "Asia"),
                new Country("COL", 47704427, 7763, 1269, 96, "Colombia", "South America"),
                new Country("COM", 717503, 831, 430, 24, "Comoros", "Africa"),
                new Country("ZAR", 65705093, 418, 197, 19, "Congo Dem. Rep.", "Africa"),
                new Country("COG", 4337051, 3154, 1722, 90, "Congo Rep.", "Africa"),
                new Country("CRI", 4805295, 9443, 1874, 67, "Costa Rica", "North America"),
                new Country("CIV", 19839750, 1244, 527, 82, "Cote d'Ivoire", "Africa"),
                new Country("HRV", 4267558, 13159, 13519, 114, "Croatia", "Europe"),
                new Country("CUB", 11270957, 0, 1780, 9, "Cuba", "North America"),
                new Country("CUW", 152056, 0, 0, 138, "Curacao", "North America"),
                new Country("CYP", 1128994, 26352, 37812, 94, "Cyprus", "Europe"),
                new Country("CZE", 10510785, 18690, 8260, 123, "Czech Republic", "Europe"),
                new Country("DNK", 5591572, 56364, 101084, 116, "Denmark", "Europe"),
                new Country("DJI", 859652, 1575, 573, 20, "Djibouti", "Africa"),
                new Country("DMA", 71684, 6913, 3000, 148, "Dominica", "North America"),
                new Country("DOM", 10276621, 5733, 1162, 89, "Dominican Republic", "North America"),
                new Country("ECU", 15492264, 5425, 995, 99, "Ecuador", "South America"),
                new Country("EGY", 80721874, 3256, 391, 91, "Egypt", "Africa"),
                new Country("SLV", 6297394, 3782, 1953, 124, "El Salvador", "North America"),
                new Country("GNQ", 736296, 22391, 634, 57, "Equatorial Guinea", "Africa"),
                new Country("ERI", 6130922, 504, 195, 3, "Eritrea", "Africa"),
                new Country("EST", 1325016, 16887, 16944, 127, "Estonia", "Europe"),
                new Country("ETH", 91728849, 467, 51, 8, "Ethiopia", "Africa"),
                new Country("EUU", 505640311, 32917, 0, 118, "Euroean Union", "Europe"),
                new Country("FRO", 49506, 0, 0, 120, "Faeroe Islands", "Europe"),
                new Country("FJI", 874742, 4613, 150, 81, "Fiji", "Oceania"),
                new Country("FIN", 5413971, 45649, 68960, 156, "Finland", "Europe"),
                new Country("FRA", 65676758, 39759, 74619, 91, "France", "Europe"),
                new Country("GAB", 1632572, 10930, 1587, 103, "Gabon", "Africa"),
                new Country("GMB", 1791225, 510, 306, 88, "Gambia", "Africa"),
                new Country("GEO", 4490700, 3529, 1940, 91, "Georgia", "Asia"),
                new Country("DEU", 80425823, 42598, 57755, 106, "Germany", "Europe"),
                new Country("GHA", 25366462, 1646, 274, 72, "Ghana", "Africa"),
                new Country("GRC", 11092771, 22395, 47636, 111, "Greece", "Europe"),
                new Country("GRL", 56810, 0, 1035, 101, "Greenland", "Europe"),
                new Country("GRD", 105483, 7598, 3402, 116, "Grenada", "North America"),
                new Country("GTM", 15082831, 3341, 1216, 126, "Guatemala", "North America"),
                new Country("GIN", 11451273, 493, 305, 37, "Guinea", "Asia"),
                new Country("GNB", 1663558, 494, 722, 43, "Guinea-Bissau", "Asia"),
                new Country("GUY", 795369, 3585, 1049, 71, "Guyana", "South America"),
                new Country("HTI", 10173775, 776, 36, 40, "Haiti", "North America"),
                new Country("HND", 7935846, 2339, 465, 125, "Honduras", "North America"),
                new Country("HKG", 7154600, 36708, 105420, 196, "Hong Kong", "Asia"),
                new Country("HUN", 9920362, 12560, 14821, 120, "Hungary", "Europe"),
                new Country("ISL", 320716, 42362, 362942, 107, "Iceland", "Europe"),
                new Country("IND", 1236686732, 1503, 240, 62, "India", "Asia"),
                new Country("IDN", 246864191, 3551, 837, 88, "Indonesia", "Asia"),
                new Country("IRN", 76424443, 6578, 170, 73, "Iran", "Asia"),
                new Country("IRQ", 32578209, 6625, 1641, 75, "Iraq", "Asia"),
                new Country("IRL", 4586897, 45922, 512083, 105, "Ireland", "Europe"),
                new Country("ISR", 7910500, 32567, 12070, 123, "Israel", "Asia"),
                new Country("ITA", 59539717, 33814, 36841, 155, "Italy", "Europe"),
                new Country("JAM", 2707805, 5464, 4660, 116, "Jamaica", "North America"),
                new Country("JPN", 127561489, 46548, 24000, 97, "Japan", "Asia"),
                new Country("JOR", 6318000, 4909, 903, 103, "Jordan", "Asia"),
                new Country("KAZ", 16791425, 12120, 6060, 122, "Kazakhstan", "Asia"),
                new Country("KEN", 43178141, 933, 200, 61, "Kenya", "Africa"),
                new Country("KIR", 100786, 1736, 120, 11, "Kiribati", "Oceania"),
                new Country("PRK", 24763188, 0, 544, 2, "Korea North", "Asia"),
                new Country("KOR", 50004441, 24454, 7567, 105, "Korea South", "Asia"),
                new Country("KSV", 1807106, 3567, 0, 0, "Kosovo", "Europe"),
                new Country("KWT", 3250496, 56367, 15754, 133, "Kuwait", "Asia"),
                new Country("KGZ", 5607200, 1178, 699, 99, "Kyrgyzstan", "Asia"),
                new Country("LAO", 6645827, 1412, 900, 63, "Laos", "Asia"),
                new Country("LVA", 2034319, 13947, 18527, 110, "Latvia", "Europe"),
                new Country("LBN", 4424888, 9764, 8815, 66, "Lebanon", "Asia"),
                new Country("LSO", 2051545, 1135, 255, 49, "Lesotho", "Africa"),
                new Country("LBR", 4190435, 414, 65, 40, "Liberia", "Africa"),
                new Country("LBY", 6154623, 13303, 972, 180, "Libya", "Africa"),
                new Country("LIE", 36656, 0, 0, 98, "Liechtenstein", "Europe"),
                new Country("LTU", 2987773, 14172, 9995, 159, "Lithuania", "Europe"),
                new Country("LUX", 530946, 103859, 3696467, 143, "Luxembourg", "Europe"),
                new Country("MAC", 556783, 77196, 0, 210, "Macao", "Asia"),
                new Country("MKD", 2105575, 4548, 2668, 102, "Macedonia", "Europe"),
                new Country("MDG", 22293914, 443, 140, 37, "Madagascar", "Africa"),
                new Country("MWI", 15906483, 267, 77, 21, "Malawi", "Africa"),
                new Country("MYS", 29239927, 10432, 2570, 120, "Malaysia", "Asia"),
                new Country("MDV", 338442, 6244, 2947, 152, "Maldives", "Oceania"),
                new Country("MLI", 14853572, 696, 254, 53, "Mali", "Africa"),
                new Country("MLT", 419455, 20839, 14233, 107, "Malta", "Europe"),
                new Country("MHL", 52555, 3292, 1377, 0, "Marshall Islands", "Oceania"),
                new Country("MRT", 3796141, 1043, 831, 77, "Mauritania", "Africa"),
                new Country("MUS", 1291167, 8862, 3937, 97, "Mauritius", "Africa"),
                new Country("MEX", 120847477, 9818, 1956, 78, "Mexico", "North America"),
                new Country("FSM", 103395, 3155, 556, 27, "Micronesia", "Oceania"),
                new Country("MDA", 3559519, 2047, 1296, 71, "Moldova", "Europe"),
                new Country("MCO", 37579, 0, 471428, 64, "Monaco", "Europe"),
                new Country("MNG", 2796484, 3691, 686, 93, "Mongolia", "Asia"),
                new Country("MNE", 621081, 6514, 939, 189, "Montenegro", "Europe"),
                new Country("MAR", 32521143, 2902, 712, 101, "Morocco", "Africa"),
                new Country("MOZ", 25203395, 570, 231, 30, "Mozambique", "Africa"),
                new Country("MMR", 52797319, 0, 117, 1, "Myanmar", "Asia"),
                new Country("NAM", 2259393, 5931, 1131, 90, "Namibia", "Africa"),
                new Country("NPL", 27474377, 699, 161, 34, "Nepal", "Asia"),
                new Country("NLD", 16754962, 45961, 226503, 115, "Netherlands", "Europe"),
                new Country("NCL", 258000, 0, 385, 90, "New Caledonia", "Oceania"),
                new Country("NZL", 4433000, 38680, 52300, 108, "New Zealand", "Oceania"),
                new Country("NIC", 5991733, 1777, 693, 68, "Nicaragua", "North America"),
                new Country("NER", 17157042, 395, 178, 23, "Niger", "Africa"),
                new Country("NGA", 168833776, 2722, 71, 55, "Nigeria", "Africa"),
                new Country("NAC", 348692795, 51826, 0, 90, "North America", "North America"),
                new Country("NOR", 5018573, 99636, 131220, 114, "Norway", "Europe"),
                new Country("OMN", 3314001, 23624, 2962, 164, "Oman", "Asia"),
                new Country("PAK", 179160111, 1255, 366, 57, "Pakistan", "Asia"),
                new Country("PLW", 20754, 11202, 0, 71, "Palau", "Oceania"),
                new Country("PAN", 3802281, 9982, 3927, 181, "Panama", "North America"),
                new Country("PNG", 7167010, 2184, 238, 28, "Papua New Guinea", "Oceania"),
                new Country("PRY", 6687361, 3680, 382, 92, "Paraguay", "South America"),
                new Country("PER", 29987800, 6424, 1126, 100, "Peru", "South America"),
                new Country("PHL", 96706764, 2587, 636, 89, "Philippines", "Asia"),
                new Country("POL", 38535873, 12721, 6586, 123, "Poland", "Europe"),
                new Country("PRT", 10514844, 20175, 47835, 115, "Portugal", "Europe"),
                new Country("PRI", 3651545, 27795, 15692, 79, "Puerto Rico", "North America"),
                new Country("QAT", 2050514, 92633, 41988, 125, "Qatar", "Asia"),
                new Country("ROM", 20076727, 8437, 5082, 111, "Romania", "Europe"),
                new Country("RUS", 143178000, 14091, 3634, 166, "Russian", "Asia"),
                new Country("RWA", 11457801, 623, 284, 33, "Rwanda", "Africa"),
                new Country("WSM", 188889, 3623, 968, 0, "Samoa", "Oceania"),
                new Country("SMR", 31247, 0, 8388, 99, "San Marino", "Europe"),
                new Country("STP", 188098, 1400, 2193, 58, "Sao Tome and Principe", "Oceania"),
                new Country("SAU", 28287855, 25946, 3176, 189, "Saudi Arabia", "Asia"),
                new Country("SEN", 13726021, 1023, 296, 64, "Senegal", "Africa"),
                new Country("SRB", 7199077, 5294, 4178, 125, "Serbia", "Europe"),
                new Country("SYC", 88303, 11689, 15614, 129, "Seychelles", "Africa"),
                new Country("SLE", 5978727, 633, 340, 35, "Sierra Leone", "Africa"),
                new Country("SGP", 5312400, 54007, 0, 145, "Singapore", "Asia"),
                new Country("SVK", 5407579, 16893, 10926, 109, "Slovakia", "Europe"),
                new Country("SVN", 2057159, 22059, 25555, 103, "Slovenia", "Europe"),
                new Country("SLB", 549598, 1819, 355, 22, "Solomon Islands", "Oceania"),
                new Country("SOM", 10195134, 0, 386, 7, "Somalia", "Africa"),
                new Country("ZAF", 52274945, 7314, 1613, 98, "South Africa", "Africa"),
                new Country("SAS", 1649249388, 1396, 0, 60, "South Asia", "South Asia"),
                new Country("SSD", 10837527, 974, 0, 0, "South Sudan", "Africa"),
                new Country("ESP", 46761264, 28282, 52045, 111, "Spain", "Europe"),
                new Country("LKA", 20328000, 2922, 881, 84, "Sri Lanka", "Asia"),
                new Country("KNA", 53584, 13658, 6408, 153, "St. Kitts and Nevis", "North America"),
                new Country("LCA", 180870, 7288, 1586, 112, "St. Lucia", "North America"),
                new Country("VCT", 109373, 6349, 4477, 121, "St. Vincent and the Grenadines", "North America"),
                new Country("SXM", 30959, 0, 0, 0, "Sint Maarten", "North America"),
                new Country("SDN", 37195349, 1695, 946, 42, "Sudan", "Africa"),
                new Country("SUR", 534541, 9376, 1011, 99, "Suriname", "South America"),
                new Country("SWZ", 1230985, 3290, 428, 61, "Swaziland", "Africa"),
                new Country("SWE", 9519374, 55039, 91487, 117, "Sweden", "Europe"),
                new Country("CHE", 7996861, 78929, 154063, 123, "Switzerland", "Europe"),
                new Country("SYR", 22399254, 0, 373, 54, "Syria", "Asia"),
                new Country("TJK", 8008990, 953, 262, 78, "Tajikistan", "Asia"),
                new Country("TZA", 47783107, 609, 183, 47, "Tanzania", "Africa"),
                new Country("THA", 66785001, 5480, 1292, 108, "Thailand", "Asia"),
                new Country("TMP", 1148958, 1179, 0, 44, "East Timor", "Oceania"),
                new Country("TGO", 6642928, 589, 0, 41, "Togo", "Africa"),
                new Country("TON", 104941, 4494, 799, 52, "Tonga", "Africa"),
                new Country("TTO", 1337439, 17523, 3502, 143, "Trinidad and Tobago", "North America"),
                new Country("TUN", 10777500, 4197, 1779, 105, "Tunisia", "Africa"),
                new Country("TUR", 73997128, 10661, 3794, 86, "Turkey", "Asia"),
                new Country("TKM", 5172931, 6798, 978, 63, "Turkmenistan", "Asia"),
                new Country("TUV", 9860, 4044, 0, 16, "Tuvalu", "Oceania"),
                new Country("UGA", 36345860, 551, 85, 38, "Uganda", "Africa"),
                new Country("UKR", 45593300, 3873, 2144, 117, "Ukraine", "Europe"),
                new Country("ARE", 9205651, 41692, 24273, 129, "United Arab Emirates", "Asia"),
                new Country("GBR", 63695687, 38649, 160158, 124, "United Kingdom", "Europe"),
                new Country("USA", 313873685, 51755, 52170, 91, "United States", "North America"),
                new Country("URY", 3395253, 14728, 3989, 132, "Uruguay", "South America"),
                new Country("UZB", 29774500, 1719, 150, 76, "Uzbekistan", "Asia"),
                new Country("VUT", 247262, 3183, 389, 72, "Vanuatu", "Oceania"),
                new Country("VEN", 29954782, 12729, 1906, 96, "Venezuela", "South America"),
                new Country("VNM", 88772900, 1755, 379, 125, "Vietnam", "Asia"),
                new Country("WBG", 4046901, 2530, 414, 65, "Palestine", "Asia"),
                new Country("YEM", 23852409, 1341, 293, 49, "Yemen Rep.", "Asia"),
                new Country("ZMB", 14075099, 1463, 264, 41, "Zambia", "Africa"),
                new Country("ZWE", 13724317, 909, 609, 59, "Zimbabwe", "Africa")
            };

            // data = data.sort(this.SortByPopAscending);
            data.Sort(SortByPopDescending);

            var countries = new List<Country>();
            foreach (var country in data)
            {
                if (country.IsValid())
                    countries.Add(country);
            }
            return countries;
        }

        public static string Abbreviate(double value) {
            var suffixes = new List<string> { "", "K", "M", "B", "T" };
            var roundValue = Math.Round(value);
            var suffixNum = (int)Math.Floor(roundValue.ToString().Length / 3.0);
            var shortValue = (suffixNum != 0 ? (value / Math.Pow(1000, suffixNum)) : value);

            return shortValue.ToString("0.0") + suffixes[suffixNum];
        }
    }
        
    public class Country
    {
        public double Population { get; set; }
        public double GdpPerCapita { get; set; }
        public double GdpTotal { get; set; }
        public double DptPerCapita { get; set; }
        public double PhonePer100 { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }

        public Country(string code,
            double pop, double gdp, double dpt, double phones,
            string name, string region)
        {
            this.Code = code;
            this.Region = region;
            this.Name = name;

            this.Population = pop;
            this.GdpPerCapita = gdp;
            this.GdpTotal = gdp * pop; // / 1000000;
            this.DptPerCapita = dpt;
            this.PhonePer100 = phones;
        }

        public bool IsValid() {
            return this.GdpPerCapita > 0 && this.Population > 0 &&
                   this.DptPerCapita > 0 && this.PhonePer100 > 0;
        }

        public string GetPopulation() {
            return SampleScatterStats.Abbreviate(this.Population);
        }
        public string GetGdpTotal() {
            return SampleScatterStats.Abbreviate(this.GdpTotal);
        }
        public string GetGdpPerCapita() {
            return SampleScatterStats.Abbreviate(this.GdpPerCapita);
        }
    }
}
