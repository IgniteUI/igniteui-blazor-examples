using System;
using System.Collections.Generic;
public class OlympicMedalsTopCountriesWithTotalsItem
{
    public string Year { get; set; }
    public double America { get; set; }
    public double China { get; set; }
    public double Russia { get; set; }
    public double Total { get; set; }
}

public class OlympicMedalsTopCountriesWithTotals
    : List<OlympicMedalsTopCountriesWithTotalsItem>
{
    public OlympicMedalsTopCountriesWithTotals()
    {
        this.Add(new OlympicMedalsTopCountriesWithTotalsItem()
        {
            Year = @"1996",
            America = 148,
            China = 110,
            Russia = 95,
            Total = 353
        });
        this.Add(new OlympicMedalsTopCountriesWithTotalsItem()
        {
            Year = @"2000",
            America = 142,
            China = 115,
            Russia = 91,
            Total = 348
        });
        this.Add(new OlympicMedalsTopCountriesWithTotalsItem()
        {
            Year = @"2004",
            America = 134,
            China = 121,
            Russia = 86,
            Total = 341
        });
        this.Add(new OlympicMedalsTopCountriesWithTotalsItem()
        {
            Year = @"2008",
            America = 131,
            China = 129,
            Russia = 65,
            Total = 325
        });
        this.Add(new OlympicMedalsTopCountriesWithTotalsItem()
        {
            Year = @"2012",
            America = 135,
            China = 115,
            Russia = 77,
            Total = 327
        });
        this.Add(new OlympicMedalsTopCountriesWithTotalsItem()
        {
            Year = @"2016",
            America = 146,
            China = 112,
            Russia = 88,
            Total = 346
        });
    }
}
