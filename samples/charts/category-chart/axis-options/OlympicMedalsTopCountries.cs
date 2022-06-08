using System;
using System.Collections.Generic;
public class OlympicMedalsTopCountriesItem
{
    public string Year{ get; set; }
    public double USA{ get; set; }
    public double CHN{ get; set; }
    public double RUS{ get; set; }
}
public class OlympicMedalsTopCountries
    : List<OlympicMedalsTopCountriesItem>
{
    public OlympicMedalsTopCountries()
    {
        this.Add(new OlympicMedalsTopCountriesItem()
        {
            Year = @"1996",
            USA = 148,
            CHN = 110,
            RUS = 95
        });
        this.Add(new OlympicMedalsTopCountriesItem()
        {
            Year = @"2000",
            USA = 142,
            CHN = 115,
            RUS = 91
        });
        this.Add(new OlympicMedalsTopCountriesItem()
        {
            Year = @"2004",
            USA = 134,
            CHN = 121,
            RUS = 86
        });
        this.Add(new OlympicMedalsTopCountriesItem()
        {
            Year = @"2008",
            USA = 131,
            CHN = 129,
            RUS = 65
        });
        this.Add(new OlympicMedalsTopCountriesItem()
        {
            Year = @"2012",
            USA = 135,
            CHN = 115,
            RUS = 77
        });
        this.Add(new OlympicMedalsTopCountriesItem()
        {
            Year = @"2016",
            USA = 146,
            CHN = 112,
            RUS = 88
        });
    }
}
