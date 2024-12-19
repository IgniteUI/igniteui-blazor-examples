using System;
using System.Collections.Generic;
public class OlympicMedalsTopCountriesItem
{
    public string Year { get; set; }
    public double America { get; set; }
    public double China { get; set; }
    public double Russia { get; set; }
}

public class OlympicMedalsTopCountries
    : List<OlympicMedalsTopCountriesItem>
{
    public OlympicMedalsTopCountries()
    {
        this.Add(new OlympicMedalsTopCountriesItem()
        {
            Year = @"1996",
            America = 148,
            China = 110,
            Russia = 95
        });
        this.Add(new OlympicMedalsTopCountriesItem()
        {
            Year = @"2000",
            America = 142,
            China = 115,
            Russia = 91
        });
        this.Add(new OlympicMedalsTopCountriesItem()
        {
            Year = @"2004",
            America = 134,
            China = 121,
            Russia = 86
        });
        this.Add(new OlympicMedalsTopCountriesItem()
        {
            Year = @"2008",
            America = 131,
            China = 129,
            Russia = 65
        });
        this.Add(new OlympicMedalsTopCountriesItem()
        {
            Year = @"2012",
            America = 135,
            China = 115,
            Russia = 77
        });
        this.Add(new OlympicMedalsTopCountriesItem()
        {
            Year = @"2016",
            America = 146,
            China = 112,
            Russia = 88
        });
    }
}
