using System;
using System.Collections.Generic;
public class CompanyMarketSharesItem
{
    public double Value { get; set; }
    public string Category { get; set; }
    public string Summary { get; set; }
}

public class CompanyMarketShares
    : List<CompanyMarketSharesItem>
{
    public CompanyMarketShares()
    {
        this.Add(new CompanyMarketSharesItem()
        {
            Value = 30,
            Category = @"Google",
            Summary = @"Google 30%"
        });
        this.Add(new CompanyMarketSharesItem()
        {
            Value = 25,
            Category = @"Apple",
            Summary = @"Apple 25%"
        });
        this.Add(new CompanyMarketSharesItem()
        {
            Value = 20,
            Category = @"Microsoft",
            Summary = @"Microsoft 20%"
        });
        this.Add(new CompanyMarketSharesItem()
        {
            Value = 15,
            Category = @"Samsung",
            Summary = @"Samsung 15%"
        });
        this.Add(new CompanyMarketSharesItem()
        {
            Value = 10,
            Category = @"Other",
            Summary = @"Other 10%"
        });
    }
}
