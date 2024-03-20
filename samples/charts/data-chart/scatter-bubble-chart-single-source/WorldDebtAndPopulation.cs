using System;
using System.Collections.Generic;
public class WorldDebtAndPopulationItem
{
    public string CountryCode { get; set; }
    public string CountryName { get; set; }
    public double GdpPerCapita { get; set; }
    public double UnemploymentRate { get; set; }
    public double Televisions { get; set; }
    public double PublicDebt { get; set; }
    public double Population { get; set; }
    public double OilProduction { get; set; }
    public double MedianAge { get; set; }
    public double InternetUsers { get; set; }
    public double ElectricityProduction { get; set; }
    public double BirthRate { get; set; }
}

public class WorldDebtAndPopulation
    : List<WorldDebtAndPopulationItem>
{
    public WorldDebtAndPopulation()
    {
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"AL",
            CountryName = @"Albania",
            GdpPerCapita = 5800,
            UnemploymentRate = 13,
            Televisions = 700000,
            PublicDebt = 51,
            Population = 3619778,
            OilProduction = 7006,
            MedianAge = 30,
            InternetUsers = 471200,
            ElectricityProduction = 5385,
            BirthRate = 15
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"DZ",
            CountryName = @"Algeria",
            GdpPerCapita = 6700,
            UnemploymentRate = 12,
            Televisions = 3100000,
            PublicDebt = 18,
            Population = 33769668,
            OilProduction = 1358000,
            MedianAge = 26,
            InternetUsers = 3500000,
            ElectricityProduction = 31910,
            BirthRate = 17
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"AO",
            CountryName = @"Angola",
            GdpPerCapita = 7800,
            UnemploymentRate = 0,
            Televisions = 196000,
            PublicDebt = 12,
            Population = 12531357,
            OilProduction = 1712000,
            MedianAge = 18,
            InternetUsers = 100000,
            ElectricityProduction = 2585,
            BirthRate = 44
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"AR",
            CountryName = @"Argentina",
            GdpPerCapita = 13100,
            UnemploymentRate = 9,
            Televisions = 7950000,
            PublicDebt = 56,
            Population = 40134425,
            OilProduction = 730000,
            MedianAge = 30,
            InternetUsers = 9309000,
            ElectricityProduction = 101100,
            BirthRate = 18
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"AW",
            CountryName = @"Aruba",
            GdpPerCapita = 21800,
            UnemploymentRate = 7,
            Televisions = 20000,
            PublicDebt = 46,
            Population = 101541,
            OilProduction = 2356,
            MedianAge = 38,
            InternetUsers = 24000,
            ElectricityProduction = 770,
            BirthRate = 13
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"AU",
            CountryName = @"Australia",
            GdpPerCapita = 37300,
            UnemploymentRate = 4,
            Televisions = 10150000,
            PublicDebt = 16,
            Population = 21007310,
            OilProduction = 540000,
            MedianAge = 37,
            InternetUsers = 11240000,
            ElectricityProduction = 236700,
            BirthRate = 13
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"AT",
            CountryName = @"Austria",
            GdpPerCapita = 39300,
            UnemploymentRate = 4,
            Televisions = 10150000,
            PublicDebt = 59,
            Population = 8205533,
            OilProduction = 23320,
            MedianAge = 42,
            InternetUsers = 4277000,
            ElectricityProduction = 61020,
            BirthRate = 9
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"AZ",
            CountryName = @"Azerbaijan",
            GdpPerCapita = 8000,
            UnemploymentRate = 1,
            Televisions = 170000,
            PublicDebt = 7,
            Population = 8177717,
            OilProduction = 934700,
            MedianAge = 28,
            InternetUsers = 1036000,
            ElectricityProduction = 23800,
            BirthRate = 18
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"BH",
            CountryName = @"Bahrain",
            GdpPerCapita = 33900,
            UnemploymentRate = 15,
            Televisions = 275000,
            PublicDebt = 31,
            Population = 718306,
            OilProduction = 184300,
            MedianAge = 30,
            InternetUsers = 250000,
            ElectricityProduction = 8187,
            BirthRate = 17
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"BD",
            CountryName = @"Bangladesh",
            GdpPerCapita = 1400,
            UnemploymentRate = 3,
            Televisions = 770000,
            PublicDebt = 37,
            Population = 153546896,
            OilProduction = 6746,
            MedianAge = 23,
            InternetUsers = 500000,
            ElectricityProduction = 21350,
            BirthRate = 29
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"BE",
            CountryName = @"Belgium",
            GdpPerCapita = 36200,
            UnemploymentRate = 8,
            Televisions = 4720000,
            PublicDebt = 85,
            Population = 10403951,
            OilProduction = 9000,
            MedianAge = 41,
            InternetUsers = 5220000,
            ElectricityProduction = 80840,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"BT",
            CountryName = @"Bhutan",
            GdpPerCapita = 5200,
            UnemploymentRate = 3,
            Televisions = 11000,
            PublicDebt = 81,
            Population = 682321,
            OilProduction = 0,
            MedianAge = 24,
            InternetUsers = 40000,
            ElectricityProduction = 2000,
            BirthRate = 21
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"BO",
            CountryName = @"Bolivia",
            GdpPerCapita = 4400,
            UnemploymentRate = 8,
            Televisions = 900000,
            PublicDebt = 46,
            Population = 9247816,
            OilProduction = 46470,
            MedianAge = 23,
            InternetUsers = 1000000,
            ElectricityProduction = 5293,
            BirthRate = 22
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"BA",
            CountryName = @"Bosnia and Herzegovina",
            GdpPerCapita = 6100,
            UnemploymentRate = 46,
            Televisions = 0,
            PublicDebt = 34,
            Population = 4590310,
            OilProduction = 0,
            MedianAge = 39,
            InternetUsers = 1055000,
            ElectricityProduction = 12220,
            BirthRate = 9
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"BW",
            CountryName = @"Botswana",
            GdpPerCapita = 14300,
            UnemploymentRate = 8,
            Televisions = 31000,
            PublicDebt = 5,
            Population = 1842323,
            OilProduction = 0,
            MedianAge = 21,
            InternetUsers = 80000,
            ElectricityProduction = 912,
            BirthRate = 23
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"BR",
            CountryName = @"Brazil",
            GdpPerCapita = 9500,
            UnemploymentRate = 9,
            Televisions = 36500000,
            PublicDebt = 45,
            Population = 196342592,
            OilProduction = 1797000,
            MedianAge = 28,
            InternetUsers = 50000000,
            ElectricityProduction = 396400,
            BirthRate = 19
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"BG",
            CountryName = @"Bulgaria",
            GdpPerCapita = 11800,
            UnemploymentRate = 8,
            Televisions = 3310000,
            PublicDebt = 11,
            Population = 7262675,
            OilProduction = 3661,
            MedianAge = 41,
            InternetUsers = 1899000,
            ElectricityProduction = 45700,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"CM",
            CountryName = @"Cameroon",
            GdpPerCapita = 2200,
            UnemploymentRate = 30,
            Televisions = 450000,
            PublicDebt = 16,
            Population = 18467692,
            OilProduction = 85300,
            MedianAge = 19,
            InternetUsers = 370000,
            ElectricityProduction = 4090,
            BirthRate = 35
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"CA",
            CountryName = @"Canada",
            GdpPerCapita = 38600,
            UnemploymentRate = 6,
            Televisions = 21500000,
            PublicDebt = 64,
            Population = 33212696,
            OilProduction = 3310000,
            MedianAge = 40,
            InternetUsers = 28000000,
            ElectricityProduction = 609600,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"CL",
            CountryName = @"Chile",
            GdpPerCapita = 14300,
            UnemploymentRate = 7,
            Televisions = 3150000,
            PublicDebt = 4,
            Population = 16454143,
            OilProduction = 15100,
            MedianAge = 31,
            InternetUsers = 557000,
            ElectricityProduction = 47600,
            BirthRate = 15
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"CN",
            CountryName = @"China",
            GdpPerCapita = 5400,
            UnemploymentRate = 4,
            Televisions = 400000000,
            PublicDebt = 18,
            Population = 1330044544,
            OilProduction = 3725000,
            MedianAge = 34,
            InternetUsers = 253000000,
            ElectricityProduction = 3256000,
            BirthRate = 14
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"CO",
            CountryName = @"Colombia",
            GdpPerCapita = 7400,
            UnemploymentRate = 11,
            Televisions = 4590000,
            PublicDebt = 53,
            Population = 45013672,
            OilProduction = 531300,
            MedianAge = 27,
            InternetUsers = 12100000,
            ElectricityProduction = 50470,
            BirthRate = 20
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"CR",
            CountryName = @"Costa Rica",
            GdpPerCapita = 11100,
            UnemploymentRate = 5,
            Televisions = 525000,
            PublicDebt = 47,
            Population = 4195914,
            OilProduction = 0,
            MedianAge = 27,
            InternetUsers = 1500000,
            ElectricityProduction = 8349,
            BirthRate = 18
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"IV",
            CountryName = @"Ivory Coast",
            GdpPerCapita = 1700,
            UnemploymentRate = 0,
            Televisions = 1090000,
            PublicDebt = 75,
            Population = 20179602,
            OilProduction = 48370,
            MedianAge = 19,
            InternetUsers = 300000,
            ElectricityProduction = 5305,
            BirthRate = 33
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"HR",
            CountryName = @"Croatia",
            GdpPerCapita = 15500,
            UnemploymentRate = 12,
            Televisions = 1220000,
            PublicDebt = 48,
            Population = 4491543,
            OilProduction = 17100,
            MedianAge = 41,
            InternetUsers = 1995000,
            ElectricityProduction = 11990,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"CU",
            CountryName = @"Cuba",
            GdpPerCapita = 11000,
            UnemploymentRate = 2,
            Televisions = 2640000,
            PublicDebt = 37,
            Population = 11423952,
            OilProduction = 58300,
            MedianAge = 37,
            InternetUsers = 1310000,
            ElectricityProduction = 16450,
            BirthRate = 11
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"CY",
            CountryName = @"Cyprus",
            GdpPerCapita = 27100,
            UnemploymentRate = 4,
            Televisions = 0,
            PublicDebt = 60,
            Population = 792604,
            OilProduction = 0,
            MedianAge = 35,
            InternetUsers = 380000,
            ElectricityProduction = 4618,
            BirthRate = 13
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"CZ",
            CountryName = @"Czech Republic",
            GdpPerCapita = 24500,
            UnemploymentRate = 7,
            Televisions = 3405834,
            PublicDebt = 26,
            Population = 10220911,
            OilProduction = 18030,
            MedianAge = 40,
            InternetUsers = 4400000,
            ElectricityProduction = 77380,
            BirthRate = 9
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"DK",
            CountryName = @"Denmark",
            GdpPerCapita = 37200,
            UnemploymentRate = 3,
            Televisions = 3121000,
            PublicDebt = 26,
            Population = 5484723,
            OilProduction = 342000,
            MedianAge = 40,
            InternetUsers = 3500000,
            ElectricityProduction = 43350,
            BirthRate = 11
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"DO",
            CountryName = @"Dominican Republic",
            GdpPerCapita = 6600,
            UnemploymentRate = 16,
            Televisions = 770000,
            PublicDebt = 41,
            Population = 9507133,
            OilProduction = 12,
            MedianAge = 25,
            InternetUsers = 1677000,
            ElectricityProduction = 12220,
            BirthRate = 23
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"EC",
            CountryName = @"Ecuador",
            GdpPerCapita = 7200,
            UnemploymentRate = 9,
            Televisions = 2500000,
            PublicDebt = 33,
            Population = 13927650,
            OilProduction = 511100,
            MedianAge = 24,
            InternetUsers = 1549000,
            ElectricityProduction = 12940,
            BirthRate = 22
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"EG",
            CountryName = @"Egypt",
            GdpPerCapita = 5000,
            UnemploymentRate = 9,
            Televisions = 7700000,
            PublicDebt = 106,
            Population = 81713520,
            OilProduction = 665000,
            MedianAge = 25,
            InternetUsers = 8620000,
            ElectricityProduction = 102500,
            BirthRate = 22
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"SV",
            CountryName = @"El Salvador",
            GdpPerCapita = 6000,
            UnemploymentRate = 6,
            Televisions = 600000,
            PublicDebt = 37,
            Population = 7066403,
            OilProduction = 0,
            MedianAge = 22,
            InternetUsers = 700000,
            ElectricityProduction = 5316,
            BirthRate = 26
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"GQ",
            CountryName = @"Equatorial Guinea",
            GdpPerCapita = 28200,
            UnemploymentRate = 30,
            Televisions = 4000,
            PublicDebt = 2,
            Population = 616459,
            OilProduction = 385500,
            MedianAge = 19,
            InternetUsers = 8000,
            ElectricityProduction = 28,
            BirthRate = 37
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"EE",
            CountryName = @"Estonia",
            GdpPerCapita = 21800,
            UnemploymentRate = 5,
            Televisions = 605000,
            PublicDebt = 3,
            Population = 1307605,
            OilProduction = 6930,
            MedianAge = 40,
            InternetUsers = 780000,
            ElectricityProduction = 9599,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"ET",
            CountryName = @"Ethiopia",
            GdpPerCapita = 700,
            UnemploymentRate = 0,
            Televisions = 682000,
            PublicDebt = 45,
            Population = 82544840,
            OilProduction = 7,
            MedianAge = 17,
            InternetUsers = 291000,
            ElectricityProduction = 2864,
            BirthRate = 44
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"FI",
            CountryName = @"Finland",
            GdpPerCapita = 36000,
            UnemploymentRate = 7,
            Televisions = 3200000,
            PublicDebt = 36,
            Population = 5244749,
            OilProduction = 8951,
            MedianAge = 42,
            InternetUsers = 3600000,
            ElectricityProduction = 73470,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"GA",
            CountryName = @"Gabon",
            GdpPerCapita = 14000,
            UnemploymentRate = 21,
            Televisions = 63000,
            PublicDebt = 53,
            Population = 1485832,
            OilProduction = 240000,
            MedianAge = 19,
            InternetUsers = 145000,
            ElectricityProduction = 1520,
            BirthRate = 36
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"DE",
            CountryName = @"Germany",
            GdpPerCapita = 34100,
            UnemploymentRate = 9,
            Televisions = 51400000,
            PublicDebt = 65,
            Population = 82369552,
            OilProduction = 141700,
            MedianAge = 43,
            InternetUsers = 42500000,
            ElectricityProduction = 579400,
            BirthRate = 8
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"GH",
            CountryName = @"Ghana",
            GdpPerCapita = 1400,
            UnemploymentRate = 11,
            Televisions = 1900000,
            PublicDebt = 59,
            Population = 23382848,
            OilProduction = 700,
            MedianAge = 20,
            InternetUsers = 650000,
            ElectricityProduction = 7042,
            BirthRate = 29
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"GI",
            CountryName = @"Gibraltar",
            GdpPerCapita = 38200,
            UnemploymentRate = 3,
            Televisions = 10000,
            PublicDebt = 16,
            Population = 28002,
            OilProduction = 0,
            MedianAge = 40,
            InternetUsers = 6200,
            ElectricityProduction = 141,
            BirthRate = 11
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"GR",
            CountryName = @"Greece",
            GdpPerCapita = 30600,
            UnemploymentRate = 8,
            Televisions = 2540000,
            PublicDebt = 90,
            Population = 10722816,
            OilProduction = 5687,
            MedianAge = 42,
            InternetUsers = 2540000,
            ElectricityProduction = 56130,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"GT",
            CountryName = @"Guatemala",
            GdpPerCapita = 5100,
            UnemploymentRate = 3,
            Televisions = 1323000,
            PublicDebt = 21,
            Population = 13002206,
            OilProduction = 13000,
            MedianAge = 19,
            InternetUsers = 1320000,
            ElectricityProduction = 7281,
            BirthRate = 29
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"HN",
            CountryName = @"Honduras",
            GdpPerCapita = 4300,
            UnemploymentRate = 28,
            Televisions = 570000,
            PublicDebt = 24,
            Population = 7639327,
            OilProduction = 0,
            MedianAge = 20,
            InternetUsers = 344100,
            ElectricityProduction = 5339,
            BirthRate = 27
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"HU",
            CountryName = @"Hungary",
            GdpPerCapita = 19300,
            UnemploymentRate = 7,
            Televisions = 4420000,
            PublicDebt = 67,
            Population = 9930915,
            OilProduction = 42180,
            MedianAge = 39,
            InternetUsers = 4200000,
            ElectricityProduction = 33690,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"IS",
            CountryName = @"Iceland",
            GdpPerCapita = 40400,
            UnemploymentRate = 1,
            Televisions = 98000,
            PublicDebt = 28,
            Population = 304367,
            OilProduction = 0,
            MedianAge = 35,
            InternetUsers = 202300,
            ElectricityProduction = 8533,
            BirthRate = 14
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"IN",
            CountryName = @"India",
            GdpPerCapita = 2600,
            UnemploymentRate = 7,
            Televisions = 63000000,
            PublicDebt = 58,
            Population = 1147995904,
            OilProduction = 810000,
            MedianAge = 25,
            InternetUsers = 80000000,
            ElectricityProduction = 661600,
            BirthRate = 22
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"ID",
            CountryName = @"Indonesia",
            GdpPerCapita = 3600,
            UnemploymentRate = 9,
            Televisions = 13750000,
            PublicDebt = 34,
            Population = 237512352,
            OilProduction = 837500,
            MedianAge = 27,
            InternetUsers = 13000000,
            ElectricityProduction = 125900,
            BirthRate = 19
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"IR",
            CountryName = @"Iran",
            GdpPerCapita = 11700,
            UnemploymentRate = 12,
            Televisions = 4610000,
            PublicDebt = 17,
            Population = 65875224,
            OilProduction = 3956000,
            MedianAge = 26,
            InternetUsers = 23000000,
            ElectricityProduction = 170400,
            BirthRate = 17
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"IE",
            CountryName = @"Ireland",
            GdpPerCapita = 46600,
            UnemploymentRate = 5,
            Televisions = 1820000,
            PublicDebt = 25,
            Population = 4156119,
            OilProduction = 0,
            MedianAge = 35,
            InternetUsers = 1708000,
            ElectricityProduction = 24130,
            BirthRate = 14
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"IL",
            CountryName = @"Israel",
            GdpPerCapita = 26600,
            UnemploymentRate = 7,
            Televisions = 1690000,
            PublicDebt = 81,
            Population = 7112359,
            OilProduction = 100,
            MedianAge = 29,
            InternetUsers = 2000000,
            ElectricityProduction = 46850,
            BirthRate = 20
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"IT",
            CountryName = @"Italy",
            GdpPerCapita = 30900,
            UnemploymentRate = 6,
            Televisions = 30300000,
            PublicDebt = 104,
            Population = 58145320,
            OilProduction = 164800,
            MedianAge = 43,
            InternetUsers = 32000000,
            ElectricityProduction = 278500,
            BirthRate = 8
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"JM",
            CountryName = @"Jamaica",
            GdpPerCapita = 7400,
            UnemploymentRate = 10,
            Televisions = 460000,
            PublicDebt = 127,
            Population = 2804332,
            OilProduction = 0,
            MedianAge = 23,
            InternetUsers = 1500000,
            ElectricityProduction = 6985,
            BirthRate = 20
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"JP",
            CountryName = @"Japan",
            GdpPerCapita = 33500,
            UnemploymentRate = 4,
            Televisions = 86500000,
            PublicDebt = 170,
            Population = 127288416,
            OilProduction = 125000,
            MedianAge = 44,
            InternetUsers = 88110000,
            ElectricityProduction = 1025000,
            BirthRate = 8
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"JO",
            CountryName = @"Jordan",
            GdpPerCapita = 4700,
            UnemploymentRate = 14,
            Televisions = 500000,
            PublicDebt = 72,
            Population = 6198677,
            OilProduction = 0,
            MedianAge = 24,
            InternetUsers = 1127000,
            ElectricityProduction = 9074,
            BirthRate = 20
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"KZ",
            CountryName = @"Kazakhstan",
            GdpPerCapita = 11000,
            UnemploymentRate = 7,
            Televisions = 3880000,
            PublicDebt = 8,
            Population = 15340533,
            OilProduction = 1355000,
            MedianAge = 29,
            InternetUsers = 1901000,
            ElectricityProduction = 76340,
            BirthRate = 16
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"KE",
            CountryName = @"Kenya",
            GdpPerCapita = 1700,
            UnemploymentRate = 40,
            Televisions = 730000,
            PublicDebt = 49,
            Population = 37953840,
            OilProduction = 0,
            MedianAge = 19,
            InternetUsers = 3000000,
            ElectricityProduction = 5502,
            BirthRate = 38
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"KR",
            CountryName = @"Korea, South",
            GdpPerCapita = 25000,
            UnemploymentRate = 3,
            Televisions = 15900000,
            PublicDebt = 28,
            Population = 48379392,
            OilProduction = 17050,
            MedianAge = 37,
            InternetUsers = 35590000,
            ElectricityProduction = 403200,
            BirthRate = 9
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"KW",
            CountryName = @"Kuwait",
            GdpPerCapita = 55900,
            UnemploymentRate = 2,
            Televisions = 875000,
            PublicDebt = 10,
            Population = 2596799,
            OilProduction = 2440000,
            MedianAge = 26,
            InternetUsers = 900000,
            ElectricityProduction = 41110,
            BirthRate = 22
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"LV",
            CountryName = @"Latvia",
            GdpPerCapita = 17700,
            UnemploymentRate = 6,
            Televisions = 1220000,
            PublicDebt = 7,
            Population = 2245423,
            OilProduction = 0,
            MedianAge = 40,
            InternetUsers = 1770000,
            ElectricityProduction = 4778,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"LB",
            CountryName = @"Lebanon",
            GdpPerCapita = 10300,
            UnemploymentRate = 20,
            Televisions = 1180000,
            PublicDebt = 187,
            Population = 3971941,
            OilProduction = 0,
            MedianAge = 29,
            InternetUsers = 950000,
            ElectricityProduction = 9183,
            BirthRate = 18
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"LY",
            CountryName = @"Libya",
            GdpPerCapita = 12400,
            UnemploymentRate = 30,
            Televisions = 730000,
            PublicDebt = 5,
            Population = 6173579,
            OilProduction = 1712000,
            MedianAge = 24,
            InternetUsers = 260000,
            ElectricityProduction = 21150,
            BirthRate = 26
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"LT",
            CountryName = @"Lithuania",
            GdpPerCapita = 16800,
            UnemploymentRate = 4,
            Televisions = 1700000,
            PublicDebt = 17,
            Population = 3565205,
            OilProduction = 13160,
            MedianAge = 39,
            InternetUsers = 1330000,
            ElectricityProduction = 13480,
            BirthRate = 9
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"LU",
            CountryName = @"Luxembourg",
            GdpPerCapita = 79400,
            UnemploymentRate = 4,
            Televisions = 285000,
            PublicDebt = 6,
            Population = 486006,
            OilProduction = 0,
            MedianAge = 39,
            InternetUsers = 345000,
            ElectricityProduction = 3156,
            BirthRate = 12
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"MK",
            CountryName = @"Macedonia",
            GdpPerCapita = 8400,
            UnemploymentRate = 35,
            Televisions = 510000,
            PublicDebt = 31,
            Population = 2061315,
            OilProduction = 0,
            MedianAge = 35,
            InternetUsers = 685000,
            ElectricityProduction = 6051,
            BirthRate = 12
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"MW",
            CountryName = @"Malawi",
            GdpPerCapita = 800,
            UnemploymentRate = 0,
            Televisions = 0,
            PublicDebt = 51,
            Population = 13931831,
            OilProduction = 0,
            MedianAge = 17,
            InternetUsers = 139500,
            ElectricityProduction = 1397,
            BirthRate = 42
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"MY",
            CountryName = @"Malaysia",
            GdpPerCapita = 14500,
            UnemploymentRate = 3,
            Televisions = 10800000,
            PublicDebt = 42,
            Population = 25274132,
            OilProduction = 757500,
            MedianAge = 25,
            InternetUsers = 15868000,
            ElectricityProduction = 82360,
            BirthRate = 22
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"MU",
            CountryName = @"Mauritius",
            GdpPerCapita = 11300,
            UnemploymentRate = 9,
            Televisions = 258000,
            PublicDebt = 63,
            Population = 1274189,
            OilProduction = 0,
            MedianAge = 32,
            InternetUsers = 340000,
            ElectricityProduction = 2350,
            BirthRate = 15
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"MX",
            CountryName = @"Mexico",
            GdpPerCapita = 12400,
            UnemploymentRate = 4,
            Televisions = 25600000,
            PublicDebt = 23,
            Population = 109955400,
            OilProduction = 3083000,
            MedianAge = 26,
            InternetUsers = 22812000,
            ElectricityProduction = 222400,
            BirthRate = 20
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"MD",
            CountryName = @"Moldova",
            GdpPerCapita = 2300,
            UnemploymentRate = 2,
            Televisions = 1260000,
            PublicDebt = 23,
            Population = 4324450,
            OilProduction = 0,
            MedianAge = 34,
            InternetUsers = 700000,
            ElectricityProduction = 3881,
            BirthRate = 11
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"MA",
            CountryName = @"Morocco",
            GdpPerCapita = 3700,
            UnemploymentRate = 10,
            Televisions = 3100000,
            PublicDebt = 67,
            Population = 34343220,
            OilProduction = 300,
            MedianAge = 25,
            InternetUsers = 7300000,
            ElectricityProduction = 21370,
            BirthRate = 21
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"MZ",
            CountryName = @"Mozambique",
            GdpPerCapita = 800,
            UnemploymentRate = 21,
            Televisions = 67600,
            PublicDebt = 22,
            Population = 21284700,
            OilProduction = 0,
            MedianAge = 17,
            InternetUsers = 200000,
            ElectricityProduction = 13170,
            BirthRate = 38
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"NA",
            CountryName = @"Namibia",
            GdpPerCapita = 5200,
            UnemploymentRate = 5,
            Televisions = 60000,
            PublicDebt = 22,
            Population = 2088669,
            OilProduction = 0,
            MedianAge = 21,
            InternetUsers = 101000,
            ElectricityProduction = 1688,
            BirthRate = 23
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"NL",
            CountryName = @"Netherlands",
            GdpPerCapita = 39000,
            UnemploymentRate = 5,
            Televisions = 8100000,
            PublicDebt = 46,
            Population = 16645313,
            OilProduction = 76000,
            MedianAge = 40,
            InternetUsers = 15000000,
            ElectricityProduction = 94340,
            BirthRate = 11
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"NZ",
            CountryName = @"New Zealand",
            GdpPerCapita = 27200,
            UnemploymentRate = 4,
            Televisions = 1926000,
            PublicDebt = 21,
            Population = 4173460,
            OilProduction = 25880,
            MedianAge = 36,
            InternetUsers = 3360000,
            ElectricityProduction = 42060,
            BirthRate = 14
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"NI",
            CountryName = @"Nicaragua",
            GdpPerCapita = 2800,
            UnemploymentRate = 5,
            Televisions = 320000,
            PublicDebt = 63,
            Population = 5785846,
            OilProduction = 0,
            MedianAge = 22,
            InternetUsers = 155000,
            ElectricityProduction = 2778,
            BirthRate = 24
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"NG",
            CountryName = @"Nigeria",
            GdpPerCapita = 2100,
            UnemploymentRate = 5,
            Televisions = 6900000,
            PublicDebt = 14,
            Population = 146255312,
            OilProduction = 2166000,
            MedianAge = 19,
            InternetUsers = 10000000,
            ElectricityProduction = 22530,
            BirthRate = 37
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"NO",
            CountryName = @"Norway",
            GdpPerCapita = 53300,
            UnemploymentRate = 3,
            Televisions = 2030000,
            PublicDebt = 83,
            Population = 4644457,
            OilProduction = 2560000,
            MedianAge = 39,
            InternetUsers = 3800000,
            ElectricityProduction = 135800,
            BirthRate = 11
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"OM",
            CountryName = @"Oman",
            GdpPerCapita = 1900,
            UnemploymentRate = 15,
            Televisions = 1600000,
            PublicDebt = 4,
            Population = 3311640,
            OilProduction = 710800,
            MedianAge = 19,
            InternetUsers = 340000,
            ElectricityProduction = 11890,
            BirthRate = 35
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"PK",
            CountryName = @"Pakistan",
            GdpPerCapita = 2400,
            UnemploymentRate = 6,
            Televisions = 3100000,
            PublicDebt = 51,
            Population = 172800048,
            OilProduction = 62000,
            MedianAge = 21,
            InternetUsers = 17500000,
            ElectricityProduction = 89820,
            BirthRate = 28
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"PA",
            CountryName = @"Panama",
            GdpPerCapita = 10700,
            UnemploymentRate = 6,
            Televisions = 510000,
            PublicDebt = 53,
            Population = 3309679,
            OilProduction = 0,
            MedianAge = 27,
            InternetUsers = 525200,
            ElectricityProduction = 5661,
            BirthRate = 21
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"PG",
            CountryName = @"Papua New Guinea",
            GdpPerCapita = 2100,
            UnemploymentRate = 2,
            Televisions = 59841,
            PublicDebt = 40,
            Population = 5931769,
            OilProduction = 47800,
            MedianAge = 22,
            InternetUsers = 110000,
            ElectricityProduction = 3698,
            BirthRate = 28
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"PY",
            CountryName = @"Paraguay",
            GdpPerCapita = 4000,
            UnemploymentRate = 6,
            Televisions = 990000,
            PublicDebt = 27,
            Population = 6831306,
            OilProduction = 0,
            MedianAge = 22,
            InternetUsers = 280000,
            ElectricityProduction = 70000,
            BirthRate = 28
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"PE",
            CountryName = @"Peru",
            GdpPerCapita = 7600,
            UnemploymentRate = 7,
            Televisions = 3060000,
            PublicDebt = 29,
            Population = 29180900,
            OilProduction = 119000,
            MedianAge = 26,
            InternetUsers = 7636000,
            ElectricityProduction = 24970,
            BirthRate = 20
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"PH",
            CountryName = @"Philippines",
            GdpPerCapita = 3200,
            UnemploymentRate = 7,
            Televisions = 3700000,
            PublicDebt = 56,
            Population = 96061680,
            OilProduction = 0,
            MedianAge = 22,
            InternetUsers = 5300000,
            ElectricityProduction = 53670,
            BirthRate = 26
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"PL",
            CountryName = @"Poland",
            GdpPerCapita = 16200,
            UnemploymentRate = 13,
            Televisions = 13050000,
            PublicDebt = 43,
            Population = 38500696,
            OilProduction = 0,
            MedianAge = 38,
            InternetUsers = 16000000,
            ElectricityProduction = 146200,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"PT",
            CountryName = @"Portugal",
            GdpPerCapita = 21800,
            UnemploymentRate = 8,
            Televisions = 3310000,
            PublicDebt = 64,
            Population = 10676910,
            OilProduction = 9500,
            MedianAge = 39,
            InternetUsers = 3549000,
            ElectricityProduction = 49040,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"QA",
            CountryName = @"Qatar",
            GdpPerCapita = 87600,
            UnemploymentRate = 1,
            Televisions = 230000,
            PublicDebt = 11,
            Population = 824789,
            OilProduction = 797500,
            MedianAge = 31,
            InternetUsers = 351000,
            ElectricityProduction = 13540,
            BirthRate = 16
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"RO",
            CountryName = @"Romania",
            GdpPerCapita = 11100,
            UnemploymentRate = 4,
            Televisions = 5250000,
            PublicDebt = 13,
            Population = 22246862,
            OilProduction = 115000,
            MedianAge = 37,
            InternetUsers = 12000000,
            ElectricityProduction = 60520,
            BirthRate = 11
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"RU",
            CountryName = @"Russia",
            GdpPerCapita = 14800,
            UnemploymentRate = 6,
            Televisions = 60500000,
            PublicDebt = 6,
            Population = 140702096,
            OilProduction = 9870000,
            MedianAge = 38,
            InternetUsers = 30000000,
            ElectricityProduction = 1000000,
            BirthRate = 11
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"SA",
            CountryName = @"Saudi Arabia",
            GdpPerCapita = 19800,
            UnemploymentRate = 13,
            Televisions = 5100000,
            PublicDebt = 24,
            Population = 28146656,
            OilProduction = 11000000,
            MedianAge = 22,
            InternetUsers = 6200000,
            ElectricityProduction = 165600,
            BirthRate = 29
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"SN",
            CountryName = @"Senegal",
            GdpPerCapita = 1700,
            UnemploymentRate = 48,
            Televisions = 361000,
            PublicDebt = 23,
            Population = 12853259,
            OilProduction = 0,
            MedianAge = 19,
            InternetUsers = 820000,
            ElectricityProduction = 2159,
            BirthRate = 37
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"SC",
            CountryName = @"Seychelles",
            GdpPerCapita = 16600,
            UnemploymentRate = 2,
            Televisions = 11000,
            PublicDebt = 92,
            Population = 82247,
            OilProduction = 0,
            MedianAge = 29,
            InternetUsers = 32000,
            ElectricityProduction = 252,
            BirthRate = 16
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"SG",
            CountryName = @"Singapore",
            GdpPerCapita = 49900,
            UnemploymentRate = 2,
            Televisions = 1330000,
            PublicDebt = 96,
            Population = 4608167,
            OilProduction = 9836,
            MedianAge = 38,
            InternetUsers = 3105000,
            ElectricityProduction = 39440,
            BirthRate = 9
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"SK",
            CountryName = @"Slovakia",
            GdpPerCapita = 20200,
            UnemploymentRate = 8,
            Televisions = 2620000,
            PublicDebt = 36,
            Population = 5455407,
            OilProduction = 12840,
            MedianAge = 37,
            InternetUsers = 2350000,
            ElectricityProduction = 29890,
            BirthRate = 11
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"SI",
            CountryName = @"Slovenia",
            GdpPerCapita = 28000,
            UnemploymentRate = 8,
            Televisions = 710000,
            PublicDebt = 24,
            Population = 2007711,
            OilProduction = 5,
            MedianAge = 41,
            InternetUsers = 1300000,
            ElectricityProduction = 14900,
            BirthRate = 9
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"ZA",
            CountryName = @"South Africa",
            GdpPerCapita = 9700,
            UnemploymentRate = 24,
            Televisions = 6000000,
            PublicDebt = 31,
            Population = 48782756,
            OilProduction = 200000,
            MedianAge = 24,
            InternetUsers = 5100000,
            ElectricityProduction = 264000,
            BirthRate = 20
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"ES",
            CountryName = @"Spain",
            GdpPerCapita = 33600,
            UnemploymentRate = 8,
            Televisions = 16200000,
            PublicDebt = 36,
            Population = 40491052,
            OilProduction = 29350,
            MedianAge = 41,
            InternetUsers = 19690000,
            ElectricityProduction = 270300,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"LK",
            CountryName = @"Sri Lanka",
            GdpPerCapita = 4000,
            UnemploymentRate = 6,
            Televisions = 1530000,
            PublicDebt = 86,
            Population = 21128772,
            OilProduction = 0,
            MedianAge = 30,
            InternetUsers = 771700,
            ElectricityProduction = 8411,
            BirthRate = 17
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"SD",
            CountryName = @"Sudan",
            GdpPerCapita = 1900,
            UnemploymentRate = 19,
            Televisions = 2380000,
            PublicDebt = 106,
            Population = 40218456,
            OilProduction = 484500,
            MedianAge = 19,
            InternetUsers = 1500000,
            ElectricityProduction = 3944,
            BirthRate = 34
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"SE",
            CountryName = @"Sweden",
            GdpPerCapita = 37500,
            UnemploymentRate = 6,
            Televisions = 4600000,
            PublicDebt = 42,
            Population = 9045389,
            OilProduction = 2350,
            MedianAge = 41,
            InternetUsers = 7000000,
            ElectricityProduction = 153200,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"CH",
            CountryName = @"Switzerland",
            GdpPerCapita = 40100,
            UnemploymentRate = 3,
            Televisions = 3310000,
            PublicDebt = 44,
            Population = 7581520,
            OilProduction = 3202,
            MedianAge = 41,
            InternetUsers = 4610000,
            ElectricityProduction = 56100,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"SY",
            CountryName = @"Syria",
            GdpPerCapita = 4700,
            UnemploymentRate = 9,
            Televisions = 1050000,
            PublicDebt = 38,
            Population = 19747586,
            OilProduction = 379000,
            MedianAge = 21,
            InternetUsers = 3470000,
            ElectricityProduction = 153200,
            BirthRate = 27
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"TW",
            CountryName = @"Taiwan",
            GdpPerCapita = 30100,
            UnemploymentRate = 4,
            Televisions = 8800000,
            PublicDebt = 28,
            Population = 22920946,
            OilProduction = 600,
            MedianAge = 36,
            InternetUsers = 14760000,
            ElectricityProduction = 235000,
            BirthRate = 9
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"TZ",
            CountryName = @"Tanzania",
            GdpPerCapita = 1300,
            UnemploymentRate = 0,
            Televisions = 103000,
            PublicDebt = 20,
            Population = 40213160,
            OilProduction = 0,
            MedianAge = 18,
            InternetUsers = 400000,
            ElectricityProduction = 1880,
            BirthRate = 35
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"TH",
            CountryName = @"Thailand",
            GdpPerCapita = 8000,
            UnemploymentRate = 1,
            Televisions = 15190000,
            PublicDebt = 38,
            Population = 65493296,
            OilProduction = 310000,
            MedianAge = 33,
            InternetUsers = 13416000,
            ElectricityProduction = 124600,
            BirthRate = 14
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"TN",
            CountryName = @"Tunisia",
            GdpPerCapita = 7400,
            UnemploymentRate = 14,
            Televisions = 920000,
            PublicDebt = 55,
            Population = 10383577,
            OilProduction = 76900,
            MedianAge = 29,
            InternetUsers = 1722000,
            ElectricityProduction = 12850,
            BirthRate = 16
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"TR",
            CountryName = @"Turkey",
            GdpPerCapita = 12000,
            UnemploymentRate = 10,
            Televisions = 20900000,
            PublicDebt = 39,
            Population = 71892808,
            OilProduction = 45460,
            MedianAge = 29,
            InternetUsers = 13150000,
            ElectricityProduction = 154200,
            BirthRate = 16
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"UG",
            CountryName = @"Uganda",
            GdpPerCapita = 1000,
            UnemploymentRate = 0,
            Televisions = 500000,
            PublicDebt = 21,
            Population = 31367972,
            OilProduction = 0,
            MedianAge = 15,
            InternetUsers = 2000000,
            ElectricityProduction = 1983,
            BirthRate = 48
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"UA",
            CountryName = @"Ukraine",
            GdpPerCapita = 7000,
            UnemploymentRate = 2,
            Televisions = 18050000,
            PublicDebt = 12,
            Population = 45994288,
            OilProduction = 90400,
            MedianAge = 39,
            InternetUsers = 10000000,
            ElectricityProduction = 192100,
            BirthRate = 10
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"AE",
            CountryName = @"United Arab Emirates",
            GdpPerCapita = 37000,
            UnemploymentRate = 2,
            Televisions = 310000,
            PublicDebt = 21,
            Population = 4621399,
            OilProduction = 2510000,
            MedianAge = 30,
            InternetUsers = 2300000,
            ElectricityProduction = 57060,
            BirthRate = 16
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"UK",
            CountryName = @"United Kingdom",
            GdpPerCapita = 35000,
            UnemploymentRate = 5,
            Televisions = 30500000,
            PublicDebt = 44,
            Population = 60943912,
            OilProduction = 1636000,
            MedianAge = 40,
            InternetUsers = 40200000,
            ElectricityProduction = 372600,
            BirthRate = 11
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"US",
            CountryName = @"United States",
            GdpPerCapita = 45800,
            UnemploymentRate = 5,
            Televisions = 219000000,
            PublicDebt = 61,
            Population = 303824640,
            OilProduction = 7460000,
            MedianAge = 37,
            InternetUsers = 223000000,
            ElectricityProduction = 4062000,
            BirthRate = 14
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"UY",
            CountryName = @"Uruguay",
            GdpPerCapita = 10800,
            UnemploymentRate = 9,
            Televisions = 782000,
            PublicDebt = 65,
            Population = 3477778,
            OilProduction = 27830,
            MedianAge = 33,
            InternetUsers = 968000,
            ElectricityProduction = 9200,
            BirthRate = 14
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"UZ",
            CountryName = @"Uzbekistan",
            GdpPerCapita = 2400,
            UnemploymentRate = 1,
            Televisions = 6400000,
            PublicDebt = 19,
            Population = 27345026,
            OilProduction = 109400,
            MedianAge = 24,
            InternetUsers = 1200000,
            ElectricityProduction = 49000,
            BirthRate = 18
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"VE",
            CountryName = @"Venezuela",
            GdpPerCapita = 12800,
            UnemploymentRate = 9,
            Televisions = 4100000,
            PublicDebt = 19,
            Population = 26414816,
            OilProduction = 2398000,
            MedianAge = 25,
            InternetUsers = 5720000,
            ElectricityProduction = 99200,
            BirthRate = 21
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"VN",
            CountryName = @"Vietnam",
            GdpPerCapita = 2600,
            UnemploymentRate = 4,
            Televisions = 3570000,
            PublicDebt = 42,
            Population = 86116560,
            OilProduction = 324000,
            MedianAge = 27,
            InternetUsers = 17870000,
            ElectricityProduction = 59010,
            BirthRate = 16
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"WF",
            CountryName = @"Wallis and Futuna",
            GdpPerCapita = 3800,
            UnemploymentRate = 15,
            Televisions = 0,
            PublicDebt = 6,
            Population = 15237,
            OilProduction = 0,
            MedianAge = 0,
            InternetUsers = 900,
            ElectricityProduction = 0,
            BirthRate = 0
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"YE",
            CountryName = @"Yemen",
            GdpPerCapita = 2500,
            UnemploymentRate = 35,
            Televisions = 470000,
            PublicDebt = 34,
            Population = 23013376,
            OilProduction = 339200,
            MedianAge = 17,
            InternetUsers = 320000,
            ElectricityProduction = 4456,
            BirthRate = 42
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"ZM",
            CountryName = @"Zambia",
            GdpPerCapita = 1400,
            UnemploymentRate = 50,
            Televisions = 277000,
            PublicDebt = 28,
            Population = 11669534,
            OilProduction = 150,
            MedianAge = 17,
            InternetUsers = 500000,
            ElectricityProduction = 8850,
            BirthRate = 41
        });
        this.Add(new WorldDebtAndPopulationItem()
        {
            CountryCode = @"ZW",
            CountryName = @"Zimbabwe",
            GdpPerCapita = 200,
            UnemploymentRate = 80,
            Televisions = 370000,
            PublicDebt = 218,
            Population = 11350111,
            OilProduction = 0,
            MedianAge = 18,
            InternetUsers = 1351000,
            ElectricityProduction = 9950,
            BirthRate = 32
        });
    }
}
