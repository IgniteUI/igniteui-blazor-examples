using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class CompanyBudgetInfo
    {
        public string Date { get; set; }
        public double Revenue { get; set; }
        public double Expenses { get; set; }
        public double Income { get { return Revenue - Expenses; } }
        public double IncomePerRevenue { get; set; }
    }

    public class CompanyBudgetData : List<CompanyBudgetInfo>
    {
        public CompanyBudgetData()
        {
            Add(new CompanyBudgetInfo { Date = "Jan 1, 2019", Revenue = 16914, Expenses = 10183 });
            Add(new CompanyBudgetInfo { Date = "Mar 1, 2019", Revenue = 15077, Expenses = 12813 });
            Add(new CompanyBudgetInfo { Date = "Jun 1, 2019", Revenue = 16886, Expenses = 14476 });
            Add(new CompanyBudgetInfo { Date = "Sep 1, 2019", Revenue = 17652, Expenses = 11705 });
            Add(new CompanyBudgetInfo { Date = "Jan 1, 2020", Revenue = 21082, Expenses = 14044 });
            Add(new CompanyBudgetInfo { Date = "Mar 1, 2020", Revenue = 17737, Expenses = 12803 });
            Add(new CompanyBudgetInfo { Date = "Jun 1, 2020", Revenue = 18687, Expenses = 13677 });
            Add(new CompanyBudgetInfo { Date = "Sep 1, 2020", Revenue = 21470, Expenses = 13717 });
            Add(new CompanyBudgetInfo { Date = "Jan 1, 2021", Revenue = 28072, Expenses = 17133 });

            foreach (var item in this)
            {
                item.IncomePerRevenue = (item.Income / item.Revenue * 100);
            }
        }
    }    
}
