using System;
using System.Collections.Generic;
using System.Linq;

public class CountryTopUrbanPopDataItem
{
    public string Code { get; set; }
    public string Parent { get; set; }
    public string Name { get; set; }
    public double Population { get; set; }
    public double UrbanPopulation { get; set; }
    public string UrbanPopPercent { get; set; }
    public string UrbanPopPercentLabel
    {
        get
        {
            if (UrbanPopulation != 0)
            {
                return string.Format("{0}, {1}", Name, UrbanPopPercent);

            }
            else
            {
                return Name;
            }
        }
    }
}

public class CountryTopUrbanPopData
    : List<CountryTopUrbanPopDataItem>
{
    public CountryTopUrbanPopData()
    {

        this.Add(new CountryTopUrbanPopDataItem()
        {
            Code = @"NAM",
            Parent = null,
            Name = @"North America",
            Population = double.NaN
        });
        this.Add(new CountryTopUrbanPopDataItem()
        {
            Code = @"ASA",
            Parent = null,
            Name = @"Asia",
            Population = double.NaN
        });
        this.Add(new CountryTopUrbanPopDataItem()
        {
            Code = "@IND",
            Parent = @"Asia",
            Name = @"India",
            Population = 1428627663,
            UrbanPopulation = 530387142,
            UrbanPopPercent = "36%"

        });
        this.Add(new CountryTopUrbanPopDataItem()
        {
            Code = @"CHI",
            Parent = @"Asia",
            Name = @"China",
            Population = 1425178792,
            UrbanPopulation = 941865672,
            UrbanPopPercent = "65%"
        });
        this.Add(new CountryTopUrbanPopDataItem()
        {
            Code = @"USA",
            Parent = "North America",
            Name = @"USA",
            Population = 341814420,
            UrbanPopulation = 284698234,
            UrbanPopPercent = "83%"
        });
        this.Add(new CountryTopUrbanPopDataItem()
        {
            Code = @"MEX",
            Parent = @"North America",
            Name = @"Mexico",
            Population = 129388467,
            UrbanPopulation = 114397383,
            UrbanPopPercent = "88%"
        });
       


    }
}
