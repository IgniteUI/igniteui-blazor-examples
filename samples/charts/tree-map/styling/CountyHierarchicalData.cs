using System;
using System.Collections.Generic;
public class CountyHierarchicalDataItem
{
    public string Code{ get; set; }
    public string Parent{ get; set; }
    public string Name{ get; set; }
    public double Population{ get; set; }
}
public class CountyHierarchicalData
    : List<CountyHierarchicalDataItem>
{
    public CountyHierarchicalData()
    {
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"AFC",
            Parent = null,
            Name = @"Africa",
            Population = double.NaN
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ASA",
            Parent = null,
            Name = @"Asia",
            Population = double.NaN
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"EUR",
            Parent = null,
            Name = @"Europe",
            Population = double.NaN
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MDE",
            Parent = null,
            Name = @"Middle East",
            Population = double.NaN
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"NAM",
            Parent = null,
            Name = @"North America",
            Population = double.NaN
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CAM",
            Parent = null,
            Name = @"Central America",
            Population = double.NaN
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SAM",
            Parent = null,
            Name = @"South America",
            Population = double.NaN
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"OCE",
            Parent = null,
            Name = @"Oceania",
            Population = double.NaN
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ANG",
            Parent = @"Africa",
            Name = @"Angola",
            Population = 19618432
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BEN",
            Parent = @"Africa",
            Name = @"Benin",
            Population = 9099922
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BOT",
            Parent = @"Africa",
            Name = @"Botswana",
            Population = 2030738
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BUR",
            Parent = @"Africa",
            Name = @"Burkina Faso",
            Population = 16967845
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BUR",
            Parent = @"Africa",
            Name = @"Burundi",
            Population = 8575172
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CAM",
            Parent = @"Africa",
            Name = @"Cameroon",
            Population = 20030362
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CPV",
            Parent = @"Africa",
            Name = @"Cape Verde",
            Population = 500585
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CAR",
            Parent = @"Africa",
            Name = @"Central African Republic",
            Population = 4486837
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CHD",
            Parent = @"Africa",
            Name = @"Chad",
            Population = 11525496
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"COM",
            Parent = @"Africa",
            Name = @"Comoros",
            Population = 753943
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"DRC",
            Parent = @"Africa",
            Name = @"Congo DRC",
            Population = 67757577
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CRP",
            Parent = @"Africa",
            Name = @"Congo Republic",
            Population = 4139748
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CIR",
            Parent = @"Africa",
            Name = @"Cote Ivoire",
            Population = 20152894
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"DBT",
            Parent = @"Africa",
            Name = @"Djibouti",
            Population = 905564
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ETG",
            Parent = @"Africa",
            Name = @"Equatorial Guinea",
            Population = 720213
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ERT",
            Parent = @"Africa",
            Name = @"Eritrea",
            Population = 5415280
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ETH",
            Parent = @"Africa",
            Name = @"Ethiopia",
            Population = 84734262
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"GBN",
            Parent = @"Africa",
            Name = @"Gabon",
            Population = 1534262
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"GMB",
            Parent = @"Africa",
            Name = @"Gambia",
            Population = 1776103
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"GHN",
            Parent = @"Africa",
            Name = @"Ghana",
            Population = 24965816
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"GUN",
            Parent = @"Africa",
            Name = @"Guinea",
            Population = 10221808
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"GNB",
            Parent = @"Africa",
            Name = @"Guinea-Bissau",
            Population = 1547061
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"KEN",
            Parent = @"Africa",
            Name = @"Kenya",
            Population = 41609728
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"LES",
            Parent = @"Africa",
            Name = @"Lesotho",
            Population = 2193843
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"LBR",
            Parent = @"Africa",
            Name = @"Liberia",
            Population = 4128572
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MDG",
            Parent = @"Africa",
            Name = @"Madagascar",
            Population = 21315135
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MLW",
            Parent = @"Africa",
            Name = @"Malawi",
            Population = 15380888
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MAL",
            Parent = @"Africa",
            Name = @"Mali",
            Population = 15839538
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MRT",
            Parent = @"Africa",
            Name = @"Mauritania",
            Population = 3541540
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MUS",
            Parent = @"Africa",
            Name = @"Mauritius",
            Population = 1286051
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MOZ",
            Parent = @"Africa",
            Name = @"Mozambique",
            Population = 23929708
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"NMB",
            Parent = @"Africa",
            Name = @"Namibia",
            Population = 2324004
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"NER",
            Parent = @"Africa",
            Name = @"Niger",
            Population = 16068994
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"NGA",
            Parent = @"Africa",
            Name = @"Nigeria",
            Population = 162470737
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"RWD",
            Parent = @"Africa",
            Name = @"Rwanda",
            Population = 10942950
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"STM",
            Parent = @"Africa",
            Name = @"Sao Tome",
            Population = 168526
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SEN",
            Parent = @"Africa",
            Name = @"Senegal",
            Population = 12767556
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SYC",
            Parent = @"Africa",
            Name = @"Seychelles",
            Population = 86000
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SRL",
            Parent = @"Africa",
            Name = @"Sierra Leone",
            Population = 5997486
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ZAF",
            Parent = @"Africa",
            Name = @"South Africa",
            Population = 50586757
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SSD",
            Parent = @"Africa",
            Name = @"South Sudan",
            Population = 10314021
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SDN",
            Parent = @"Africa",
            Name = @"Sudan",
            Population = 34318385
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SWZ",
            Parent = @"Africa",
            Name = @"Swaziland",
            Population = 1067773
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"TNZ",
            Parent = @"Africa",
            Name = @"Tanzania",
            Population = 46218486
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"TOG",
            Parent = @"Africa",
            Name = @"Togo",
            Population = 6154813
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"UGN",
            Parent = @"Africa",
            Name = @"Uganda",
            Population = 34509205
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ZMB",
            Parent = @"Africa",
            Name = @"Zambia",
            Population = 13474959
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ZWE",
            Parent = @"Africa",
            Name = @"Zimbabwe",
            Population = 12754378
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"AFG",
            Parent = @"Asia",
            Name = @"Afghanistan",
            Population = 35320445
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BAN",
            Parent = @"Asia",
            Name = @"Bangladesh",
            Population = 150493658
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BHT",
            Parent = @"Asia",
            Name = @"Bhutan",
            Population = 738267
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BRN",
            Parent = @"Asia",
            Name = @"Brunei",
            Population = 405938
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CAM",
            Parent = @"Asia",
            Name = @"Cambodia",
            Population = 14305183
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CHI",
            Parent = @"Asia",
            Name = @"China",
            Population = 1344130000
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"HNK",
            Parent = @"Asia",
            Name = @"Hong Kong",
            Population = 7071600
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"IND",
            Parent = @"Asia",
            Name = @"India",
            Population = 1241491960
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"IDN",
            Parent = @"Asia",
            Name = @"Indonesia",
            Population = 242325638
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"JPN",
            Parent = @"Asia",
            Name = @"Japan",
            Population = 127817277
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"KZH",
            Parent = @"Asia",
            Name = @"Kazakhstan",
            Population = 16558676
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"NKO",
            Parent = @"Asia",
            Name = @"North Korea",
            Population = 24451285
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SKO",
            Parent = @"Asia",
            Name = @"South Korea",
            Population = 49779000
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"KGZ",
            Parent = @"Asia",
            Name = @"Kyrgyzstan",
            Population = 5514600
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"LAO",
            Parent = @"Asia",
            Name = @"Lao PDR",
            Population = 6288037
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MAC",
            Parent = @"Asia",
            Name = @"Macao",
            Population = 555731
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MYS",
            Parent = @"Asia",
            Name = @"Malaysia",
            Population = 28859154
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MDV",
            Parent = @"Asia",
            Name = @"Maldives",
            Population = 320081
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MNG",
            Parent = @"Asia",
            Name = @"Mongolia",
            Population = 2800114
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MYM",
            Parent = @"Asia",
            Name = @"Myanmar",
            Population = 48336763
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"NPL",
            Parent = @"Asia",
            Name = @"Nepal",
            Population = 30485798
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"PHP",
            Parent = @"Asia",
            Name = @"Philippines",
            Population = 94852030
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SNG",
            Parent = @"Asia",
            Name = @"Singapore",
            Population = 5183700
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SRL",
            Parent = @"Asia",
            Name = @"Sri Lanka",
            Population = 20869000
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"TKS",
            Parent = @"Asia",
            Name = @"Tajikistan",
            Population = 6976958
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"THL",
            Parent = @"Asia",
            Name = @"Thailand",
            Population = 69518555
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"TRK",
            Parent = @"Asia",
            Name = @"Turkmenistan",
            Population = 5105301
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"UZB",
            Parent = @"Asia",
            Name = @"Uzbekistan",
            Population = 29341200
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"VTN",
            Parent = @"Asia",
            Name = @"Vietnam",
            Population = 87840000
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ANT",
            Parent = @"Central America",
            Name = @"Antigua",
            Population = 89612
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ARB",
            Parent = @"Central America",
            Name = @"Aruba",
            Population = 108141
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BHM",
            Parent = @"Central America",
            Name = @"Bahamas",
            Population = 347176
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BRB",
            Parent = @"Central America",
            Name = @"Barbados",
            Population = 273925
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BLZ",
            Parent = @"Central America",
            Name = @"Belize",
            Population = 356600
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BRM",
            Parent = @"Central America",
            Name = @"Bermuda",
            Population = 64700
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CYI",
            Parent = @"Central America",
            Name = @"Cayman Islands",
            Population = 56729
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CSR",
            Parent = @"Central America",
            Name = @"Costa Rica",
            Population = 4726575
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CUB",
            Parent = @"Central America",
            Name = @"Cuba",
            Population = 11253665
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CUR",
            Parent = @"Central America",
            Name = @"Curacao",
            Population = 145619
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"DMA",
            Parent = @"Central America",
            Name = @"Dominica",
            Population = 67675
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"DOM",
            Parent = @"Central America",
            Name = @"Dominican Republic",
            Population = 10056181
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SLV",
            Parent = @"Central America",
            Name = @"El Salvador",
            Population = 6227491
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"FIS",
            Parent = @"Central America",
            Name = @"Faeroe Islands",
            Population = 48863
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"GND",
            Parent = @"Central America",
            Name = @"Grenada",
            Population = 104890
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"GUA",
            Parent = @"Central America",
            Name = @"Guam",
            Population = 182111
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"GTM",
            Parent = @"Central America",
            Name = @"Guatemala",
            Population = 14757316
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"HAT",
            Parent = @"Central America",
            Name = @"Haiti",
            Population = 10123787
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"HON",
            Parent = @"Central America",
            Name = @"Honduras",
            Population = 7754687
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"JAM",
            Parent = @"Central America",
            Name = @"Jamaica",
            Population = 2706500
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"NCR",
            Parent = @"Central America",
            Name = @"Nicaragua",
            Population = 5869859
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"NMI",
            Parent = @"Central America",
            Name = @"Northern Mariana Islands",
            Population = 61174
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"PAN",
            Parent = @"Central America",
            Name = @"Panama",
            Population = 3571185
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"PRT",
            Parent = @"Central America",
            Name = @"Puerto Rico",
            Population = 3706690
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"STK",
            Parent = @"Central America",
            Name = @"St. Kitts",
            Population = 53051
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"STL",
            Parent = @"Central America",
            Name = @"St. Lucia",
            Population = 176000
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"STV",
            Parent = @"Central America",
            Name = @"St. Vincent",
            Population = 109365
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"TAB",
            Parent = @"Central America",
            Name = @"Trinidad and Tobago",
            Population = 1346350
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"RCI",
            Parent = @"Central America",
            Name = @"Turks and Caicos Islands",
            Population = 39184
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ISV",
            Parent = @"Central America",
            Name = @"US Virgin Islands",
            Population = 109666
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ALB",
            Parent = @"Europe",
            Name = @"Albania",
            Population = 3215988
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"AND",
            Parent = @"Europe",
            Name = @"Andorra",
            Population = 86165
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ARM",
            Parent = @"Europe",
            Name = @"Armenia",
            Population = 3100236
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"AUT",
            Parent = @"Europe",
            Name = @"Austria",
            Population = 8423635
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BER",
            Parent = @"Europe",
            Name = @"Belarus",
            Population = 9473000
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BEL",
            Parent = @"Europe",
            Name = @"Belgium",
            Population = 11020952
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BIH",
            Parent = @"Europe",
            Name = @"Bosnia",
            Population = 3752228
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BUL",
            Parent = @"Europe",
            Name = @"Bulgaria",
            Population = 7348328
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CHI",
            Parent = @"Europe",
            Name = @"Channel Islands",
            Population = 153876
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CRO",
            Parent = @"Europe",
            Name = @"Croatia",
            Population = 4403000
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CYP",
            Parent = @"Europe",
            Name = @"Cyprus",
            Population = 1116564
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CZE",
            Parent = @"Europe",
            Name = @"Czechia",
            Population = 10496088
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"DEN",
            Parent = @"Europe",
            Name = @"Denmark",
            Population = 5570572
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"EST",
            Parent = @"Europe",
            Name = @"Estonia",
            Population = 1339928
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"FIN",
            Parent = @"Europe",
            Name = @"Finland",
            Population = 5388272
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"FRA",
            Parent = @"Europe",
            Name = @"France",
            Population = 65433714
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"GEO",
            Parent = @"Europe",
            Name = @"Georgia",
            Population = 4486000
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"DEU",
            Parent = @"Europe",
            Name = @"Germany",
            Population = 81797673
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"GRC",
            Parent = @"Europe",
            Name = @"Greece",
            Population = 11300410
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"HUN",
            Parent = @"Europe",
            Name = @"Hungary",
            Population = 9971727
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ICE",
            Parent = @"Europe",
            Name = @"Iceland",
            Population = 319014
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"IRE",
            Parent = @"Europe",
            Name = @"Ireland",
            Population = 4576317
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"IOM",
            Parent = @"Europe",
            Name = @"Isle of Man",
            Population = 83327
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ITA",
            Parent = @"Europe",
            Name = @"Italy",
            Population = 60723603
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"KOS",
            Parent = @"Europe",
            Name = @"Kosovo",
            Population = 1802765
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"LAT",
            Parent = @"Europe",
            Name = @"Latvia",
            Population = 2058184
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"LVA",
            Parent = @"Europe",
            Name = @"Liechtenstein",
            Population = 36304
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"LTU",
            Parent = @"Europe",
            Name = @"Lithuania",
            Population = 3030173
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"LUX",
            Parent = @"Europe",
            Name = @"Luxembourg",
            Population = 518252
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MKD",
            Parent = @"Europe",
            Name = @"North Macedonia",
            Population = 2063893
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MLT",
            Parent = @"Europe",
            Name = @"Malta",
            Population = 415654
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MDA",
            Parent = @"Europe",
            Name = @"Moldova",
            Population = 3559000
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MON",
            Parent = @"Europe",
            Name = @"Monaco",
            Population = 35427
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MNE",
            Parent = @"Europe",
            Name = @"Montenegro",
            Population = 632261
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MLD",
            Parent = @"Europe",
            Name = @"Netherlands",
            Population = 16693074
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"NOR",
            Parent = @"Europe",
            Name = @"Norway",
            Population = 4953088
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"POL",
            Parent = @"Europe",
            Name = @"Poland",
            Population = 38534157
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"POR",
            Parent = @"Europe",
            Name = @"Portugal",
            Population = 10556999
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ROM",
            Parent = @"Europe",
            Name = @"Romania",
            Population = 21384832
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"RUS",
            Parent = @"Europe",
            Name = @"Russia",
            Population = 142960000
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SMR",
            Parent = @"Europe",
            Name = @"San Marino",
            Population = 31735
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SBR",
            Parent = @"Europe",
            Name = @"Serbia",
            Population = 7258745
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"STM",
            Parent = @"Europe",
            Name = @"Sint Maarten",
            Population = 36609
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SVK",
            Parent = @"Europe",
            Name = @"Slovakia",
            Population = 5398384
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SLO",
            Parent = @"Europe",
            Name = @"Slovenia",
            Population = 2052843
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ESP",
            Parent = @"Europe",
            Name = @"Spain",
            Population = 46174601
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"STM",
            Parent = @"Europe",
            Name = @"St. Martin",
            Population = 30615
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SWE",
            Parent = @"Europe",
            Name = @"Sweden",
            Population = 9449213
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CHE",
            Parent = @"Europe",
            Name = @"Switzerland",
            Population = 7912398
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"UKR",
            Parent = @"Europe",
            Name = @"Ukraine",
            Population = 45706100
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"GBR",
            Parent = @"Europe",
            Name = @"United Kingdom",
            Population = 62744081
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"DZA",
            Parent = @"Middle East",
            Name = @"Algeria",
            Population = 35980193
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"AZE",
            Parent = @"Middle East",
            Name = @"Azerbaijan",
            Population = 9173082
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BHR",
            Parent = @"Middle East",
            Name = @"Bahrain",
            Population = 1323535
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"EGY",
            Parent = @"Middle East",
            Name = @"Egypt",
            Population = 82536770
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"IRN",
            Parent = @"Middle East",
            Name = @"Iran",
            Population = 74798599
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"IRQ",
            Parent = @"Middle East",
            Name = @"Iraq",
            Population = 32961959
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ISR",
            Parent = @"Middle East",
            Name = @"Israel",
            Population = 7765900
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"JOR",
            Parent = @"Middle East",
            Name = @"Jordan",
            Population = 6181000
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"KWT",
            Parent = @"Middle East",
            Name = @"Kuwait",
            Population = 2818042
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"LBN",
            Parent = @"Middle East",
            Name = @"Lebanon",
            Population = 4259405
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"LBY",
            Parent = @"Middle East",
            Name = @"Libya",
            Population = 6422772
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MAR",
            Parent = @"Middle East",
            Name = @"Morocco",
            Population = 32272974
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"OMN",
            Parent = @"Middle East",
            Name = @"Oman",
            Population = 2846145
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"PKS",
            Parent = @"Middle East",
            Name = @"Pakistan",
            Population = 176745364
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"QTR",
            Parent = @"Middle East",
            Name = @"Qatar",
            Population = 1870041
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SAR",
            Parent = @"Middle East",
            Name = @"Saudi Arabia",
            Population = 28082541
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SOM",
            Parent = @"Middle East",
            Name = @"Somalia",
            Population = 9556873
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SYR",
            Parent = @"Middle East",
            Name = @"Syria",
            Population = 20820311
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"TUN",
            Parent = @"Middle East",
            Name = @"Tunisia",
            Population = 10673800
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"TUR",
            Parent = @"Middle East",
            Name = @"Turkey",
            Population = 73639596
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"UAE",
            Parent = @"Middle East",
            Name = @"United Arab Emirates",
            Population = 7890924
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"WTB",
            Parent = @"Middle East",
            Name = @"West Bank",
            Population = 3927051
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"YEM",
            Parent = @"Middle East",
            Name = @"Yemen",
            Population = 24799880
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CAN",
            Parent = @"North America",
            Name = @"Canada",
            Population = 34483975
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"GRL",
            Parent = @"North America",
            Name = @"Greenland",
            Population = 56840
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MEX",
            Parent = @"North America",
            Name = @"Mexico",
            Population = 114793341
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"USA",
            Parent = @"North America",
            Name = @"United States",
            Population = 311591917
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"AMS",
            Parent = @"Oceania",
            Name = @"American Samoa",
            Population = 69543
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"AUS",
            Parent = @"Oceania",
            Name = @"Australia",
            Population = 22323900
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"FIJ",
            Parent = @"Oceania",
            Name = @"Fiji",
            Population = 868406
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"FRP",
            Parent = @"Oceania",
            Name = @"French Polynesia",
            Population = 273777
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"KIR",
            Parent = @"Oceania",
            Name = @"Kiribati",
            Population = 101093
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MIS",
            Parent = @"Oceania",
            Name = @"Marshall Islands",
            Population = 54816
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"MCR",
            Parent = @"Oceania",
            Name = @"Micronesia",
            Population = 111542
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"NCD",
            Parent = @"Oceania",
            Name = @"New Caledonia",
            Population = 254024
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"NZL",
            Parent = @"Oceania",
            Name = @"New Zealand",
            Population = 4405200
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"PAL",
            Parent = @"Oceania",
            Name = @"Palau",
            Population = 20609
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"PNG",
            Parent = @"Oceania",
            Name = @"Papua New Guinea",
            Population = 7013829
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SAM",
            Parent = @"Oceania",
            Name = @"Samoa",
            Population = 183874
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SIS",
            Parent = @"Oceania",
            Name = @"Solomon Islands",
            Population = 552267
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"TML",
            Parent = @"Oceania",
            Name = @"Timor-Leste",
            Population = 1175880
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"TON",
            Parent = @"Oceania",
            Name = @"Tonga",
            Population = 104509
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"TUV",
            Parent = @"Oceania",
            Name = @"Tuvalu",
            Population = 9847
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"VNT",
            Parent = @"Oceania",
            Name = @"Vanuatu",
            Population = 245619
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ARG",
            Parent = @"South America",
            Name = @"Argentina",
            Population = 40764561
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BOL",
            Parent = @"South America",
            Name = @"Bolivia",
            Population = 10088108
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"BRA",
            Parent = @"South America",
            Name = @"Brazil",
            Population = 196655014
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"CHI",
            Parent = @"South America",
            Name = @"Chile",
            Population = 17269525
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"COL",
            Parent = @"South America",
            Name = @"Colombia",
            Population = 46927125
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"ECU",
            Parent = @"South America",
            Name = @"Ecuador",
            Population = 14666055
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"GUY",
            Parent = @"South America",
            Name = @"Guyana",
            Population = 756040
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"PAR",
            Parent = @"South America",
            Name = @"Paraguay",
            Population = 6568290
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"PER",
            Parent = @"South America",
            Name = @"Peru",
            Population = 29399817
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"SUR",
            Parent = @"South America",
            Name = @"Suriname",
            Population = 529419
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"URG",
            Parent = @"South America",
            Name = @"Uruguay",
            Population = 3368595
        });
        this.Add(new CountyHierarchicalDataItem()
        {
            Code = @"VEN",
            Parent = @"South America",
            Name = @"Venezuela",
            Population = 29278000
        });
    }
}
