using System;
using System.Collections.Generic;
public class CompanyIncomeDataItem
{
    public double Costs { get; set; }
    public double NetIncome { get; set; }
    public string Category { get; set; }
}

public class CompanyIncomeData
    : List<CompanyIncomeDataItem>
{
    public CompanyIncomeData()
    {
        this.Add(new CompanyIncomeDataItem()
        {
            Costs = 55,
            NetIncome = double.NaN,
            Category = @"Revenue"
        });
        this.Add(new CompanyIncomeDataItem()
        {
            Costs = 45,
            NetIncome = double.NaN,
            Category = @"Expenses"
        });
        this.Add(new CompanyIncomeDataItem()
        {
            Costs = 35,
            NetIncome = double.NaN,
            Category = @"Research"
        });
        this.Add(new CompanyIncomeDataItem()
        {
            Costs = 28,
            NetIncome = double.NaN,
            Category = @"Marketing"
        });
        this.Add(new CompanyIncomeDataItem()
        {
            Costs = 25,
            NetIncome = double.NaN,
            Category = @"Administration"
        });
        this.Add(new CompanyIncomeDataItem()
        {
            Costs = 55,
            NetIncome = double.NaN,
            Category = @"Total Costs"
        });
        this.Add(new CompanyIncomeDataItem()
        {
            Costs = 0,
            NetIncome = 25,
            Category = @"Net Income"
        });
    }
}
