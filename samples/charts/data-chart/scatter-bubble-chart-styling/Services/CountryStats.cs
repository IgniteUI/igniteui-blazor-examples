using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class CountryInfo
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Code { get; set; }
        public string Continent { get; set; }
        public double Population { get; set; }
        public double WorkedHours { get; set; }
        public double GDP { get; set; }
    }

    public class CountryStats : List<CountryInfo>
    {
        public CountryStats()
        {
            Add(new CountryInfo { Code = "AFG", Population = 34414000, WorkedHours = 38.90, GDP = 1809.02, Continent = "Asia", Name = "Afghanistan" });
            Add(new CountryInfo { Code = "ALB", Population = 2891000, WorkedHours = 41.00, GDP = 10970.45, Continent = "Europe", Name = "Albania" });
            Add(new CountryInfo { Code = "DZA", Population = 39728000, WorkedHours = 47.50, GDP = 13724.72, Continent = "Africa", Name = "Algeria" });
            Add(new CountryInfo { Code = "AGO", Population = 27884000, WorkedHours = 39.80, GDP = 6227.67, Continent = "Africa", Name = "Angola" });
            Add(new CountryInfo { Code = "ATG", Population = 94000, WorkedHours = 43.40, GDP = 20154.95, Continent = "North America", Name = "Antigua and Barbuda" });
            Add(new CountryInfo { Code = "ARG", Population = 43075000, WorkedHours = 32.53, GDP = 19116.91, Continent = "South America", Name = "Argentina" });
            Add(new CountryInfo { Code = "ARM", Population = 2926000, WorkedHours = 47.30, GDP = 8195.93, Continent = "Asia", Name = "Armenia" });
            Add(new CountryInfo { Code = "AUS", Population = 23932000, WorkedHours = 33.60, GDP = 43923.26, Continent = "Oceania", Name = "Australia" });
            Add(new CountryInfo { Code = "AUT", Population = 8679000, WorkedHours = 30.75, GDP = 44304.97, Continent = "Europe", Name = "Austria" });
            Add(new CountryInfo { Code = "AZE", Population = 9623000, WorkedHours = 43.50, GDP = 16698.86, Continent = "Asia", Name = "Azerbaijan" });
            Add(new CountryInfo { Code = "BHS", Population = 374000, WorkedHours = 44.90, GDP = 28407.13, Continent = "North America", Name = "Bahamas" });
            Add(new CountryInfo { Code = "BHR", Population = 1372000, WorkedHours = 45.00, GDP = 43926.47, Continent = "Asia", Name = "Bahrain" });
            Add(new CountryInfo { Code = "BGD", Population = 156000000, WorkedHours = 42.93, GDP = 3132.57, Continent = "Asia", Name = "Bangladesh" });
            Add(new CountryInfo { Code = "BRB", Population = 285000, WorkedHours = 41.30, GDP = 16458.10, Continent = "North America", Name = "Barbados" });
            Add(new CountryInfo { Code = "BLR", Population = 9439000, WorkedHours = 43.50, GDP = 17229.56, Continent = "Europe", Name = "Belarus" });
            Add(new CountryInfo { Code = "BEL", Population = 11288000, WorkedHours = 29.70, GDP = 41708.21, Continent = "Europe", Name = "Belgium" });
            Add(new CountryInfo { Code = "BLZ", Population = 361000, WorkedHours = 46.50, GDP = 8127.66, Continent = "North America", Name = "Belize" });
            Add(new CountryInfo { Code = "BEN", Population = 10576000, WorkedHours = 43.70, GDP = 1987.14, Continent = "Africa", Name = "Benin" });
            Add(new CountryInfo { Code = "BTN", Population = 728000, WorkedHours = 36.60, GDP = 7743.34, Continent = "Asia", Name = "Bhutan" });
            Add(new CountryInfo { Code = "BOL", Population = 10870000, WorkedHours = 47.50, GDP = 6531.52, Continent = "South America", Name = "Bolivia" });
            Add(new CountryInfo { Code = "BIH", Population = 3429000, WorkedHours = 46.50, GDP = 10932.46, Continent = "Europe", Name = "Bosnia and Herzegovina" });
            Add(new CountryInfo { Code = "BWA", Population = 2121000, WorkedHours = 41.20, GDP = 15356.77, Continent = "Africa", Name = "Botswana" });
            Add(new CountryInfo { Code = "BRA", Population = 204000000, WorkedHours = 32.87, GDP = 14702.59, Continent = "South America", Name = "Brazil" });
            Add(new CountryInfo { Code = "BRN", Population = 415000, WorkedHours = 46.50, GDP = 74600.16, Continent = "Asia", Name = "Brunei" });
            Add(new CountryInfo { Code = "BGR", Population = 7200000, WorkedHours = 31.62, GDP = 17000.18, Continent = "Europe", Name = "Bulgaria" });
            Add(new CountryInfo { Code = "BFA", Population = 18111000, WorkedHours = 39.30, GDP = 1596.34, Continent = "Africa", Name = "Burkina Faso" });
            Add(new CountryInfo { Code = "BDI", Population = 10160000, WorkedHours = 36.40, GDP = 748.42, Continent = "Africa", Name = "Burundi" });
            Add(new CountryInfo { Code = "KHM", Population = 15521000, WorkedHours = 47.22, GDP = 3290.95, Continent = "Asia", Name = "Cambodia" });
            Add(new CountryInfo { Code = "CMR", Population = 23298000, WorkedHours = 42.00, GDP = 3289.07, Continent = "Africa", Name = "Cameroon" });
            Add(new CountryInfo { Code = "CAN", Population = 36027000, WorkedHours = 32.83, GDP = 43149.48, Continent = "North America", Name = "Canada" });
            Add(new CountryInfo { Code = "CPV", Population = 525000, WorkedHours = 45.00, GDP = 5915.12, Continent = "Africa", Name = "Cape Verde" });
            Add(new CountryInfo { Code = "CAF", Population = 4493000, WorkedHours = 38.00, GDP = 621.57, Continent = "Africa", Name = "Central African Republic" });
            Add(new CountryInfo { Code = "TCD", Population = 14111000, WorkedHours = 40.40, GDP = 2067.10, Continent = "Africa", Name = "Chad" });
            Add(new CountryInfo { Code = "CHL", Population = 17969000, WorkedHours = 38.23, GDP = 22516.61, Continent = "South America", Name = "Chile" });
            Add(new CountryInfo { Code = "CHN", Population = 1410000000, WorkedHours = 41.81, GDP = 13569.89, Continent = "Asia", Name = "China" });
            Add(new CountryInfo { Code = "COL", Population = 47521000, WorkedHours = 38.42, GDP = 12985.38, Continent = "South America", Name = "Colombia" });
            Add(new CountryInfo { Code = "COM", Population = 777000, WorkedHours = 40.10, GDP = 1413.06, Continent = "Africa", Name = "Comoros" });
            Add(new CountryInfo { Code = "COG", Population = 4856000, WorkedHours = 38.10, GDP = 5542.89, Continent = "Africa", Name = "Congo" });
            Add(new CountryInfo { Code = "CRI", Population = 4848000, WorkedHours = 41.48, GDP = 14738.61, Continent = "North America", Name = "Costa Rica" });
            Add(new CountryInfo { Code = "CIV", Population = 23226000, WorkedHours = 39.70, GDP = 3241.61, Continent = "Africa", Name = "Cote d'Ivoire" });
            Add(new CountryInfo { Code = "HRV", Population = 4233000, WorkedHours = 35.15, GDP = 20983.99, Continent = "Europe", Name = "Croatia" });
            Add(new CountryInfo { Code = "CYP", Population = 1161000, WorkedHours = 34.42, GDP = 30549.10, Continent = "Europe", Name = "Cyprus" });
            Add(new CountryInfo { Code = "CZE", Population = 10601000, WorkedHours = 33.77, GDP = 30605.42, Continent = "Europe", Name = "Czechia" });
            Add(new CountryInfo { Code = "COD", Population = 76245000, WorkedHours = 44.00, GDP = 812.40, Continent = "Africa", Name = "Democratic Republic of Congo" });
            Add(new CountryInfo { Code = "DNK", Population = 5689000, WorkedHours = 27.16, GDP = 45458.70, Continent = "Europe", Name = "Denmark" });
            Add(new CountryInfo { Code = "DMA", Population = 71000, WorkedHours = 39.10, GDP = 9941.90, Continent = "North America", Name = "Dominica" });
            Add(new CountryInfo { Code = "DOM", Population = 10282000, WorkedHours = 35.40, GDP = 13395.92, Continent = "North America", Name = "Dominican Republic" });
            Add(new CountryInfo { Code = "ECU", Population = 16212000, WorkedHours = 32.72, GDP = 10749.13, Continent = "South America", Name = "Ecuador" });
            Add(new CountryInfo { Code = "EGY", Population = 92443000, WorkedHours = 39.70, GDP = 10095.61, Continent = "Africa", Name = "Egypt" });
            Add(new CountryInfo { Code = "SLV", Population = 6325000, WorkedHours = 37.80, GDP = 7019.59, Continent = "North America", Name = "El Salvador" });
            Add(new CountryInfo { Code = "GNQ", Population = 1169000, WorkedHours = 38.80, GDP = 27554.20, Continent = "Africa", Name = "Equatorial Guinea" });
            Add(new CountryInfo { Code = "EST", Population = 1315000, WorkedHours = 35.61, GDP = 27549.58, Continent = "Europe", Name = "Estonia" });
            Add(new CountryInfo { Code = "SWZ", Population = 1104000, WorkedHours = 45.70, GDP = 7758.50, Continent = "Africa", Name = "Eswatini" });
            Add(new CountryInfo { Code = "ETH", Population = 101000000, WorkedHours = 40.10, GDP = 1533.11, Continent = "Africa", Name = "Ethiopia" });
            Add(new CountryInfo { Code = "FJI", Population = 869000, WorkedHours = 43.60, GDP = 8477.65, Continent = "Oceania", Name = "Fiji" });
            Add(new CountryInfo { Code = "FIN", Population = 5481000, WorkedHours = 31.48, GDP = 38941.76, Continent = "Europe", Name = "Finland" });
            Add(new CountryInfo { Code = "FRA", Population = 64453000, WorkedHours = 29.03, GDP = 37766.37, Continent = "Europe", Name = "France" });
            Add(new CountryInfo { Code = "GAB", Population = 1948000, WorkedHours = 40.50, GDP = 16836.78, Continent = "Africa", Name = "Gabon" });
            Add(new CountryInfo { Code = "GMB", Population = 2086000, WorkedHours = 40.30, GDP = 1568.04, Continent = "Africa", Name = "Gambia" });
            Add(new CountryInfo { Code = "GEO", Population = 4024000, WorkedHours = 47.20, GDP = 9025.13, Continent = "Asia", Name = "Georgia" });
            Add(new CountryInfo { Code = "DEU", Population = 81787000, WorkedHours = 26.31, GDP = 43937.95, Continent = "Europe", Name = "Germany" });
            Add(new CountryInfo { Code = "GHA", Population = 27849000, WorkedHours = 47.60, GDP = 3926.71, Continent = "Africa", Name = "Ghana" });
            Add(new CountryInfo { Code = "GRC", Population = 10660000, WorkedHours = 39.06, GDP = 24170.30, Continent = "Europe", Name = "Greece" });
            Add(new CountryInfo { Code = "GRD", Population = 110000, WorkedHours = 37.70, GDP = 12757.97, Continent = "North America", Name = "Grenada" });
            Add(new CountryInfo { Code = "GTM", Population = 16252000, WorkedHours = 46.90, GDP = 7292.72, Continent = "North America", Name = "Guatemala" });
            Add(new CountryInfo { Code = "GIN", Population = 11432000, WorkedHours = 43.40, GDP = 1758.32, Continent = "Africa", Name = "Guinea" });
            Add(new CountryInfo { Code = "GNB", Population = 1737000, WorkedHours = 35.10, GDP = 1446.49, Continent = "Africa", Name = "Guinea-Bissau" });
            Add(new CountryInfo { Code = "GUY", Population = 767000, WorkedHours = 45.50, GDP = 7076.94, Continent = "South America", Name = "Guyana" });
            Add(new CountryInfo { Code = "HTI", Population = 10696000, WorkedHours = 43.10, GDP = 1651.23, Continent = "North America", Name = "Haiti" });
            Add(new CountryInfo { Code = "HND", Population = 9113000, WorkedHours = 36.40, GDP = 4319.47, Continent = "North America", Name = "Honduras" });
            Add(new CountryInfo { Code = "HKG", Population = 7186000, WorkedHours = 42.03, GDP = 53591.84, Continent = "Asia", Name = "Hong Kong" });
            Add(new CountryInfo { Code = "HUN", Population = 9778000, WorkedHours = 36.99, GDP = 25034.45, Continent = "Europe", Name = "Hungary" });
            Add(new CountryInfo { Code = "ISL", Population = 330000, WorkedHours = 29.02, GDP = 43048.13, Continent = "Europe", Name = "Iceland" });
            Add(new CountryInfo { Code = "IND", Population = 1310000000, WorkedHours = 40.71, GDP = 5756.67, Continent = "Asia", Name = "India" });
            Add(new CountryInfo { Code = "IDN", Population = 258000000, WorkedHours = 38.93, GDP = 10367.70, Continent = "Asia", Name = "Indonesia" });
            Add(new CountryInfo { Code = "IRN", Population = 78492000, WorkedHours = 35.80, GDP = 16500.90, Continent = "Asia", Name = "Iran" });
            Add(new CountryInfo { Code = "IRQ", Population = 35572000, WorkedHours = 40.20, GDP = 15072.87, Continent = "Asia", Name = "Iraq" });
            Add(new CountryInfo { Code = "IRL", Population = 4652000, WorkedHours = 33.47, GDP = 60818.05, Continent = "Europe", Name = "Ireland" });
            Add(new CountryInfo { Code = "ISR", Population = 7978000, WorkedHours = 36.45, GDP = 32024.35, Continent = "Asia", Name = "Israel" });
            Add(new CountryInfo { Code = "ITA", Population = 60578000, WorkedHours = 33.04, GDP = 34302.04, Continent = "Europe", Name = "Italy" });
            Add(new CountryInfo { Code = "JAM", Population = 2891000, WorkedHours = 47.40, GDP = 8095.26, Continent = "North America", Name = "Jamaica" });
            Add(new CountryInfo { Code = "JPN", Population = 128000000, WorkedHours = 33.67, GDP = 37882.98, Continent = "Asia", Name = "Japan" });
            Add(new CountryInfo { Code = "JOR", Population = 9267000, WorkedHours = 37.40, GDP = 8491.05, Continent = "Asia", Name = "Jordan" });
            Add(new CountryInfo { Code = "KAZ", Population = 17572000, WorkedHours = 37.30, GDP = 23524.06, Continent = "Asia", Name = "Kazakhstan" });
            Add(new CountryInfo { Code = "KEN", Population = 47878000, WorkedHours = 43.90, GDP = 2836.00, Continent = "Africa", Name = "Kenya" });
            Add(new CountryInfo { Code = "KIR", Population = 111000, WorkedHours = 37.60, GDP = 1967.30, Continent = "Oceania", Name = "Kiribati" });
            Add(new CountryInfo { Code = "KWT", Population = 3836000, WorkedHours = 35.70, GDP = 68476.33, Continent = "Asia", Name = "Kuwait" });
            Add(new CountryInfo { Code = "KGZ", Population = 5959000, WorkedHours = 41.80, GDP = 3237.60, Continent = "Asia", Name = "Kyrgyzstan" });
            Add(new CountryInfo { Code = "LAO", Population = 6741000, WorkedHours = 38.00, GDP = 5755.06, Continent = "Asia", Name = "Laos" });
            Add(new CountryInfo { Code = "LVA", Population = 1998000, WorkedHours = 36.57, GDP = 23018.82, Continent = "Europe", Name = "Latvia" });
            Add(new CountryInfo { Code = "LBN", Population = 6533000, WorkedHours = 42.00, GDP = 13352.71, Continent = "Asia", Name = "Lebanon" });
            Add(new CountryInfo { Code = "LSO", Population = 2059000, WorkedHours = 47.60, GDP = 2708.15, Continent = "Africa", Name = "Lesotho" });
            Add(new CountryInfo { Code = "LBR", Population = 4472000, WorkedHours = 40.30, GDP = 785.25, Continent = "Africa", Name = "Liberia" });
            Add(new CountryInfo { Code = "LBY", Population = 6418000, WorkedHours = 42.50, GDP = 14847.20, Continent = "Africa", Name = "Libya" });
            Add(new CountryInfo { Code = "LTU", Population = 2932000, WorkedHours = 35.76, GDP = 27045.71, Continent = "Europe", Name = "Lithuania" });
            Add(new CountryInfo { Code = "LUX", Population = 567000, WorkedHours = 29.25, GDP = 94088.59, Continent = "Europe", Name = "Luxembourg" });
            Add(new CountryInfo { Code = "MAC", Population = 602000, WorkedHours = 47.50, GDP = 100444.60, Continent = "Asia", Name = "Macao" });
            Add(new CountryInfo { Code = "MDG", Population = 24234000, WorkedHours = 40.80, GDP = 1377.17, Continent = "Africa", Name = "Madagascar" });
            Add(new CountryInfo { Code = "MWI", Population = 16745000, WorkedHours = 44.50, GDP = 1088.70, Continent = "Africa", Name = "Malawi" });
            Add(new CountryInfo { Code = "MYS", Population = 30271000, WorkedHours = 43.04, GDP = 25001.61, Continent = "Asia", Name = "Malaysia" });
            Add(new CountryInfo { Code = "MDV", Population = 455000, WorkedHours = 36.60, GDP = 13705.01, Continent = "Asia", Name = "Maldives" });
            Add(new CountryInfo { Code = "MLI", Population = 17439000, WorkedHours = 40.60, GDP = 1919.23, Continent = "Africa", Name = "Mali" });
            Add(new CountryInfo { Code = "MLT", Population = 434000, WorkedHours = 37.78, GDP = 34087.08, Continent = "Europe", Name = "Malta" });
            Add(new CountryInfo { Code = "MHL", Population = 57000, WorkedHours = 42.70, GDP = 3665.38, Continent = "Oceania", Name = "Marshall Islands" });
            Add(new CountryInfo { Code = "MRT", Population = 4046000, WorkedHours = 45.90, GDP = 3601.61, Continent = "Africa", Name = "Mauritania" });
            Add(new CountryInfo { Code = "MUS", Population = 1259000, WorkedHours = 44.40, GDP = 18864.11, Continent = "Africa", Name = "Mauritius" });
            Add(new CountryInfo { Code = "MEX", Population = 122000000, WorkedHours = 43.23, GDP = 16938.61, Continent = "North America", Name = "Mexico" });
            Add(new CountryInfo { Code = "FSM", Population = 109000, WorkedHours = 38.90, GDP = 3271.27, Continent = "Oceania", Name = "Micronesia (country)" });
            Add(new CountryInfo { Code = "MDA", Population = 4071000, WorkedHours = 41.00, GDP = 4746.79, Continent = "Europe", Name = "Moldova" });
            Add(new CountryInfo { Code = "MNG", Population = 2998000, WorkedHours = 35.90, GDP = 11411.94, Continent = "Asia", Name = "Mongolia" });
            Add(new CountryInfo { Code = "MNE", Population = 627000, WorkedHours = 47.20, GDP = 15289.72, Continent = "Europe", Name = "Montenegro" });
            Add(new CountryInfo { Code = "MAR", Population = 34664000, WorkedHours = 39.60, GDP = 7296.93, Continent = "Africa", Name = "Morocco" });
            Add(new CountryInfo { Code = "MOZ", Population = 27042000, WorkedHours = 46.70, GDP = 1118.22, Continent = "Africa", Name = "Mozambique" });
            Add(new CountryInfo { Code = "MMR", Population = 52681000, WorkedHours = 46.88, GDP = 5056.86, Continent = "Asia", Name = "Myanmar" });
            Add(new CountryInfo { Code = "NAM", Population = 2315000, WorkedHours = 43.10, GDP = 9975.13, Continent = "Africa", Name = "Namibia" });
            Add(new CountryInfo { Code = "NRU", Population = 10000, WorkedHours = 36.60, GDP = 12270.30, Continent = "Oceania", Name = "Nauru" });
            Add(new CountryInfo { Code = "NPL", Population = 27015000, WorkedHours = 37.80, GDP = 2314.28, Continent = "Asia", Name = "Nepal" });
            Add(new CountryInfo { Code = "NLD", Population = 16938000, WorkedHours = 27.38, GDP = 46494.36, Continent = "Europe", Name = "Netherlands" });
            Add(new CountryInfo { Code = "NZL", Population = 4615000, WorkedHours = 33.79, GDP = 35309.82, Continent = "Oceania", Name = "New Zealand" });
            Add(new CountryInfo { Code = "NIC", Population = 6223000, WorkedHours = 42.90, GDP = 4956.92, Continent = "North America", Name = "Nicaragua" });
            Add(new CountryInfo { Code = "NER", Population = 20002000, WorkedHours = 45.00, GDP = 908.18, Continent = "Africa", Name = "Niger" });
            Add(new CountryInfo { Code = "NGA", Population = 181000000, WorkedHours = 32.76, GDP = 5670.64, Continent = "Africa", Name = "Nigeria" });
            Add(new CountryInfo { Code = "MKD", Population = 2079000, WorkedHours = 36.60, GDP = 12759.82, Continent = "Europe", Name = "North Macedonia" });
            Add(new CountryInfo { Code = "NOR", Population = 5200000, WorkedHours = 27.36, GDP = 64008.29, Continent = "Europe", Name = "Norway" });
            Add(new CountryInfo { Code = "OMN", Population = 4267000, WorkedHours = 38.80, GDP = 39873.39, Continent = "Asia", Name = "Oman" });
            Add(new CountryInfo { Code = "PAK", Population = 199000000, WorkedHours = 40.31, GDP = 4695.70, Continent = "Asia", Name = "Pakistan" });
            Add(new CountryInfo { Code = "PLW", Population = 18000, WorkedHours = 38.80, GDP = 14028.68, Continent = "Oceania", Name = "Palau" });
            Add(new CountryInfo { Code = "PSE", Population = 4529000, WorkedHours = 39.60, GDP = 4713.50, Continent = "Asia", Name = "Palestine" });
            Add(new CountryInfo { Code = "PAN", Population = 3968000, WorkedHours = 45.90, GDP = 20786.66, Continent = "North America", Name = "Panama" });
            Add(new CountryInfo { Code = "PNG", Population = 8108000, WorkedHours = 37.30, GDP = 3824.73, Continent = "Oceania", Name = "Papua New Guinea" });
            Add(new CountryInfo { Code = "PRY", Population = 6689000, WorkedHours = 41.90, GDP = 8639.29, Continent = "South America", Name = "Paraguay" });
            Add(new CountryInfo { Code = "PER", Population = 30471000, WorkedHours = 37.16, GDP = 11770.03, Continent = "South America", Name = "Peru" });
            Add(new CountryInfo { Code = "PHL", Population = 102000000, WorkedHours = 41.32, GDP = 6874.58, Continent = "Asia", Name = "Philippines" });
            Add(new CountryInfo { Code = "POL", Population = 38034000, WorkedHours = 39.40, GDP = 25299.97, Continent = "Europe", Name = "Poland" });
            Add(new CountryInfo { Code = "PRT", Population = 10368000, WorkedHours = 36.06, GDP = 26607.83, Continent = "Europe", Name = "Portugal" });
            Add(new CountryInfo { Code = "PRI", Population = 3382000, WorkedHours = 36.20, GDP = 35291.84, Continent = "North America", Name = "Puerto Rico" });
            Add(new CountryInfo { Code = "QAT", Population = 2566000, WorkedHours = 45.00, GDP = 119749.40, Continent = "Asia", Name = "Qatar" });
            Add(new CountryInfo { Code = "ROU", Population = 19925000, WorkedHours = 34.34, GDP = 20556.00, Continent = "Europe", Name = "Romania" });
            Add(new CountryInfo { Code = "RUS", Population = 145000000, WorkedHours = 38.04, GDP = 24516.55, Continent = "Europe", Name = "Russia" });
            Add(new CountryInfo { Code = "RWA", Population = 11369000, WorkedHours = 46.30, GDP = 1731.04, Continent = "Africa", Name = "Rwanda" });
            Add(new CountryInfo { Code = "KNA", Population = 51000, WorkedHours = 40.60, GDP = 24169.86, Continent = "North America", Name = "Saint Kitts and Nevis" });
            Add(new CountryInfo { Code = "LCA", Population = 179000, WorkedHours = 46.40, GDP = 12522.04, Continent = "North America", Name = "Saint Lucia" });
            Add(new CountryInfo { Code = "VCT", Population = 109000, WorkedHours = 40.70, GDP = 10468.26, Continent = "North America", Name = "Saint Vincent and the Grenadines" });
            Add(new CountryInfo { Code = "WSM", Population = 194000, WorkedHours = 41.90, GDP = 5558.79, Continent = "Oceania", Name = "Samoa" });
            Add(new CountryInfo { Code = "SMR", Population = 33000, WorkedHours = 40.10, GDP = 56372.36, Continent = "Europe", Name = "San Marino" });
            Add(new CountryInfo { Code = "STP", Population = 199000, WorkedHours = 38.20, GDP = 2947.51, Continent = "Africa", Name = "Sao Tome and Principe" });
            Add(new CountryInfo { Code = "SAU", Population = 31718000, WorkedHours = 41.00, GDP = 50723.71, Continent = "Asia", Name = "Saudi Arabia" });
            Add(new CountryInfo { Code = "SEN", Population = 14578000, WorkedHours = 46.80, GDP = 2293.85, Continent = "Africa", Name = "Senegal" });
            Add(new CountryInfo { Code = "SRB", Population = 8877000, WorkedHours = 46.50, GDP = 13277.80, Continent = "Europe", Name = "Serbia" });
            Add(new CountryInfo { Code = "SYC", Population = 95000, WorkedHours = 39.80, GDP = 24856.56, Continent = "Africa", Name = "Seychelles" });
            Add(new CountryInfo { Code = "SLE", Population = 7172000, WorkedHours = 35.40, GDP = 1314.27, Continent = "Africa", Name = "Sierra Leone" });
            Add(new CountryInfo { Code = "SGP", Population = 5592000, WorkedHours = 43.52, GDP = 81741.10, Continent = "Asia", Name = "Singapore" });
            Add(new CountryInfo { Code = "SVK", Population = 5436000, WorkedHours = 33.73, GDP = 28308.88, Continent = "Europe", Name = "Slovakia" });
            Add(new CountryInfo { Code = "SVN", Population = 2071000, WorkedHours = 32.46, GDP = 29037.74, Continent = "Europe", Name = "Slovenia" });
            Add(new CountryInfo { Code = "SLB", Population = 603000, WorkedHours = 38.50, GDP = 2149.22, Continent = "Oceania", Name = "Solomon Islands" });
            Add(new CountryInfo { Code = "ZAF", Population = 55386000, WorkedHours = 42.48, GDP = 12377.66, Continent = "Africa", Name = "South Africa" });
            Add(new CountryInfo { Code = "KOR", Population = 50823000, WorkedHours = 39.93, GDP = 34177.65, Continent = "Asia", Name = "South Korea" });
            Add(new CountryInfo { Code = "SSD", Population = 10716000, WorkedHours = 39.30, GDP = 1875.38, Continent = "Africa", Name = "South Sudan" });
            Add(new CountryInfo { Code = "ESP", Population = 46672000, WorkedHours = 32.68, GDP = 32291.16, Continent = "Europe", Name = "Spain" });
            Add(new CountryInfo { Code = "LKA", Population = 20908000, WorkedHours = 37.00, GDP = 11079.71, Continent = "Asia", Name = "Sri Lanka" });
            Add(new CountryInfo { Code = "SDN", Population = 38903000, WorkedHours = 36.30, GDP = 4290.37, Continent = "Africa", Name = "Sudan" });
            Add(new CountryInfo { Code = "SUR", Population = 559000, WorkedHours = 41.30, GDP = 14766.80, Continent = "South America", Name = "Suriname" });
            Add(new CountryInfo { Code = "SWE", Population = 9765000, WorkedHours = 30.96, GDP = 45679.28, Continent = "Europe", Name = "Sweden" });
            Add(new CountryInfo { Code = "CHE", Population = 8297000, WorkedHours = 30.57, GDP = 57264.16, Continent = "Europe", Name = "Switzerland" });
            Add(new CountryInfo { Code = "TJK", Population = 8454000, WorkedHours = 36.50, GDP = 2640.59, Continent = "Asia", Name = "Tajikistan" });
            Add(new CountryInfo { Code = "TZA", Population = 51483000, WorkedHours = 38.00, GDP = 2490.96, Continent = "Africa", Name = "Tanzania" });
            Add(new CountryInfo { Code = "THA", Population = 68715000, WorkedHours = 42.03, GDP = 15252.23, Continent = "Asia", Name = "Thailand" });
            Add(new CountryInfo { Code = "TLS", Population = 1196000, WorkedHours = 39.30, GDP = 7398.84, Continent = "Asia", Name = "Timor" });
            Add(new CountryInfo { Code = "TGO", Population = 7323000, WorkedHours = 38.80, GDP = 1351.05, Continent = "Africa", Name = "Togo" });
            Add(new CountryInfo { Code = "TON", Population = 101000, WorkedHours = 40.60, GDP = 5189.84, Continent = "Oceania", Name = "Tonga" });
            Add(new CountryInfo { Code = "TTO", Population = 1370000, WorkedHours = 40.20, GDP = 31524.59, Continent = "North America", Name = "Trinidad and Tobago" });
            Add(new CountryInfo { Code = "TUN", Population = 11180000, WorkedHours = 35.20, GDP = 10765.89, Continent = "Africa", Name = "Tunisia" });
            Add(new CountryInfo { Code = "TUR", Population = 78529000, WorkedHours = 35.23, GDP = 23388.48, Continent = "Asia", Name = "Turkey" });
            Add(new CountryInfo { Code = "TKM", Population = 5565000, WorkedHours = 47.10, GDP = 14992.32, Continent = "Asia", Name = "Turkmenistan" });
            Add(new CountryInfo { Code = "TUV", Population = 11000, WorkedHours = 37.60, GDP = 3419.20, Continent = "Oceania", Name = "Tuvalu" });
            Add(new CountryInfo { Code = "UGA", Population = 38225000, WorkedHours = 38.60, GDP = 1665.95, Continent = "Africa", Name = "Uganda" });
            Add(new CountryInfo { Code = "UKR", Population = 44922000, WorkedHours = 38.60, GDP = 7464.94, Continent = "Europe", Name = "Ukraine" });
            Add(new CountryInfo { Code = "ARE", Population = 9263000, WorkedHours = 43.60, GDP = 66569.40, Continent = "Asia", Name = "United Arab Emirates" });
            Add(new CountryInfo { Code = "GBR", Population = 65860000, WorkedHours = 32.10, GDP = 38839.17, Continent = "Europe", Name = "United Kingdom" });
            Add(new CountryInfo { Code = "USA", Population = 321000000, WorkedHours = 33.95, GDP = 53005.64, Continent = "North America", Name = "United States" });
            Add(new CountryInfo { Code = "URY", Population = 3412000, WorkedHours = 29.85, GDP = 19831.45, Continent = "South America", Name = "Uruguay" });
            Add(new CountryInfo { Code = "UZB", Population = 30930000, WorkedHours = 36.10, GDP = 5700.24, Continent = "Asia", Name = "Uzbekistan" });
            Add(new CountryInfo { Code = "VUT", Population = 271000, WorkedHours = 46.60, GDP = 2806.79, Continent = "Oceania", Name = "Vanuatu" });
            Add(new CountryInfo { Code = "VNM", Population = 92677000, WorkedHours = 41.72, GDP = 5554.86, Continent = "Asia", Name = "Vietnam" });
            Add(new CountryInfo { Code = "YEM", Population = 26498000, WorkedHours = 47.20, GDP = 2308.64, Continent = "Asia", Name = "Yemen" });
            Add(new CountryInfo { Code = "ZMB", Population = 15879000, WorkedHours = 46.60, GDP = 3627.20, Continent = "Africa", Name = "Zambia" });
            Add(new CountryInfo { Code = "ZWE", Population = 13815000, WorkedHours = 41.40, GDP = 1912.28, Continent = "Africa", Name = "Zimbabwe" });
            
        }
    }
}
