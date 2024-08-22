using System;
using System.Collections.Generic;
public class EnergyRenewableConsumptionItem
{
    public string Location { get; set; }
    public double Year { get; set; }
    public double Hydro { get; set; }
    public double Solar { get; set; }
    public double Wind { get; set; }
    public double Other { get; set; }
}

public class EnergyRenewableConsumption
    : List<EnergyRenewableConsumptionItem>
{
    public EnergyRenewableConsumption()
    {
        this.Add(new EnergyRenewableConsumptionItem()
        {
            Location = @"China",
            Year = 2019,
            Hydro = 1269.5,
            Solar = 223,
            Wind = 405.2,
            Other = 102.8
        });
        this.Add(new EnergyRenewableConsumptionItem()
        {
            Location = @"Europe",
            Year = 2019,
            Hydro = 632.54,
            Solar = 154,
            Wind = 461.3,
            Other = 220.3
        });
        this.Add(new EnergyRenewableConsumptionItem()
        {
            Location = @"USA",
            Year = 2019,
            Hydro = 271.16,
            Solar = 108,
            Wind = 303.4,
            Other = 78.34
        });
        this.Add(new EnergyRenewableConsumptionItem()
        {
            Location = @"Brazil",
            Year = 2019,
            Hydro = 399.3,
            Solar = 5.5,
            Wind = 55.83,
            Other = 56.25
        });
        this.Add(new EnergyRenewableConsumptionItem()
        {
            Location = @"Canada",
            Year = 2019,
            Hydro = 381.98,
            Solar = 4.3,
            Wind = 34.17,
            Other = 10.81
        });
    }
}
