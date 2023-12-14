using System.Collections.Generic;

public class CompanyFinancialDataItem
{
    public double Year { get; set; }
    public double Income { get; set; }
    public double Cashflow { get; set; }
    public double Revenue { get; set; }
}

public class CompanyFinancialData
    : List<CompanyFinancialDataItem>
{
    public CompanyFinancialData()
    {
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2009,
            Income = 4.5,
            Cashflow = 4,
            Revenue = 50
        });
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2010,
            Income = 3,
            Cashflow = 5,
            Revenue = 70
        });
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2011,
            Income = 4.5,
            Cashflow = 4,
            Revenue = 80
        });
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2012,
            Income = 4,
            Cashflow = 5,
            Revenue = 90
        });
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2013,
            Income = 3.5,
            Cashflow = 5,
            Revenue = 85
        });
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2014,
            Income = 4,
            Cashflow = 6,
            Revenue = 90
        });
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2015,
            Income = 3.5,
            Cashflow = 7,
            Revenue = 80
        });
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2016,
            Income = 4,
            Cashflow = 6,
            Revenue = 95
        });
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2017,
            Income = 5.5,
            Cashflow = 5,
            Revenue = 85
        });
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2018,
            Income = 6.5,
            Cashflow = 6,
            Revenue = 90
        });
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2019,
            Income = 7,
            Cashflow = 7.5,
            Revenue = 95
        });
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2020,
            Income = 2.5,
            Cashflow = 4,
            Revenue = 65
        });
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2021,
            Income = 4.5,
            Cashflow = 5,
            Revenue = 70
        });
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2022,
            Income = 5,
            Cashflow = 6,
            Revenue = 85
        });
        this.Add(new CompanyFinancialDataItem()
        {
            Year = 2023,
            Income = 6.5,
            Cashflow = 7,
            Revenue = 95
        });
    }
}
