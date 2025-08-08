using System;
using System.Collections.Generic;
public class CountryTopUrbanPopDataItem
{
    public string Code { get; set; }
    public string Parent { get; set; }
    public string Name { get; set; }
    public double Population { get; set; }
    public double UrbanPopulation { get; set; }
    public string UrbanPopPercent { get; set; }
}

public class CountryTopUrbanPopData
    : List<CountryTopUrbanPopDataItem>
{
    public CountryTopUrbanPopData()
    {
        this.Add(new CountryTopUrbanPopDataItem() { Code = @"ASA", Parent = null, Name = @"Asia", Population = double.NaN, UrbanPopulation = double.NaN, UrbanPopPercent = null });
        this.Add(new CountryTopUrbanPopDataItem() { Code = @"NAM", Parent = null, Name = @"North America", Population = double.NaN, UrbanPopulation = double.NaN, UrbanPopPercent = null });
        this.Add(new CountryTopUrbanPopDataItem() { Code = @"CHI", Parent = @"Asia", Name = @"China", Population = 1425178792, UrbanPopulation = 941865672, UrbanPopPercent = @"65%" });
        this.Add(new CountryTopUrbanPopDataItem() { Code = @"IND", Parent = @"Asia", Name = @"India", Population = 1428627663, UrbanPopulation = 530387142, UrbanPopPercent = @"36%" });
        this.Add(new CountryTopUrbanPopDataItem() { Code = @"USA", Parent = @"North America", Name = @"United States", Population = 341814420, UrbanPopulation = 284698234, UrbanPopPercent = @"83%" });
        this.Add(new CountryTopUrbanPopDataItem() { Code = @"MEX", Parent = @"North America", Name = @"Mexico", Population = 129388467, UrbanPopulation = 114397383, UrbanPopPercent = @"88%" });
    }
}
