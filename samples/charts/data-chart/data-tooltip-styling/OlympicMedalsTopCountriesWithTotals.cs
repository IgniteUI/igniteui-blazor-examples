using System;
using System.Collections.Generic;
public class OlympicMedalsTopCountriesWithTotalsItem
{
    public string Year { get; set; }
    public double America { get; set; }
    public double AmericaGold { get; set; }
    public double China { get; set; }
    public double ChinaGold { get; set; }
    public double Russia { get; set; }
    public double RussiaGold { get; set; }
    public double Total { get; set; }
}

public class OlympicMedalsTopCountriesWithTotals
    : List<OlympicMedalsTopCountriesWithTotalsItem>
{
    public OlympicMedalsTopCountriesWithTotals()
    {
        this.Add(new OlympicMedalsTopCountriesWithTotalsItem() { Year = @"1996", America = 148, AmericaGold = 50, China = 110, ChinaGold = 40, Russia = 95, RussiaGold = 20, Total = 353 });
        this.Add(new OlympicMedalsTopCountriesWithTotalsItem() { Year = @"2000", America = 142, AmericaGold = 40, China = 115, ChinaGold = 45, Russia = 91, RussiaGold = 40, Total = 348 });
        this.Add(new OlympicMedalsTopCountriesWithTotalsItem() { Year = @"2004", America = 134, AmericaGold = 35, China = 121, ChinaGold = 55, Russia = 86, RussiaGold = 25, Total = 341 });
        this.Add(new OlympicMedalsTopCountriesWithTotalsItem() { Year = @"2008", America = 131, AmericaGold = 20, China = 129, ChinaGold = 35, Russia = 65, RussiaGold = 35, Total = 325 });
        this.Add(new OlympicMedalsTopCountriesWithTotalsItem() { Year = @"2012", America = 135, AmericaGold = 25, China = 115, ChinaGold = 50, Russia = 77, RussiaGold = 15, Total = 327 });
        this.Add(new OlympicMedalsTopCountriesWithTotalsItem() { Year = @"2016", America = 146, AmericaGold = 45, China = 112, ChinaGold = 45, Russia = 88, RussiaGold = 30, Total = 346 });
    }
}
