using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class CompanyBudgetInfoWithFormatting
    {
        public string Date { get; set; }
        public double Revenue { get; set; }
        public double Expenses { get; set; }
        public double RevenueX { get; set; }
        public double ExpensesX { get; set; }
        public double Income { get; set; }
        public double IncomePerRevenue { get; set; }
        public string FormattedRevenue { get; set; }
        public string FormattedIncome { get; set; }
        public string FormattedExpenses { get; set; }
        public string FormattedProfit { get; set; }
    }

    public class CompanyBudgetDataWithFormatting : List<CompanyBudgetInfoWithFormatting>
    {
        public string FormatNumber(double num)
        {
            var ret = num;
            if (num >= 1000000) return (num / 1000000.0).ToString("0") + "M";
            if (num >= 1000) return (num / 1000.0).ToString("0") + "K";
            return ret.ToString().Replace(@"/\B(?=(\d{3})+(?!\d))/g", ",");
        }

        public CompanyBudgetDataWithFormatting()
        {
            Add(new CompanyBudgetInfoWithFormatting { Date = "Jan 1, 2019", Revenue = 16914, Expenses = 10183 });
            Add(new CompanyBudgetInfoWithFormatting { Date = "Mar 1, 2019", Revenue = 15077, Expenses = 12813 });
            Add(new CompanyBudgetInfoWithFormatting { Date = "Jun 1, 2019", Revenue = 16886, Expenses = 14476 });
            Add(new CompanyBudgetInfoWithFormatting { Date = "Sep 1, 2019", Revenue = 17652, Expenses = 11705 });
            Add(new CompanyBudgetInfoWithFormatting { Date = "Jan 1, 2020", Revenue = 21082, Expenses = 14044 });
            Add(new CompanyBudgetInfoWithFormatting { Date = "Mar 1, 2020", Revenue = 17737, Expenses = 12803 });
            Add(new CompanyBudgetInfoWithFormatting { Date = "Jun 1, 2020", Revenue = 18687, Expenses = 13677 });
            Add(new CompanyBudgetInfoWithFormatting { Date = "Sep 1, 2020", Revenue = 21470, Expenses = 13717 });
            Add(new CompanyBudgetInfoWithFormatting { Date = "Jan 1, 2021", Revenue = 28072, Expenses = 17133 });

            var i = 0;
            foreach (var item in this)
            {
                item.Revenue = item.Revenue * 1000;
                item.Expenses = item.Expenses * 1000;
                item.Income = item.Revenue - item.Expenses;
                item.IncomePerRevenue = (item.Income / item.Revenue * 100);
                // calculating x-offset for callouts
                item.RevenueX = i;
                item.ExpensesX = i;
                // formatting values for callouts
                item.FormattedRevenue = "$" + FormatNumber(item.Revenue);
                item.FormattedIncome = "$" + FormatNumber(item.Income);
                item.FormattedExpenses = "$" + FormatNumber(item.Expenses);
                item.FormattedProfit = item.IncomePerRevenue + "%";
                i++;
            }
        }
    }
}
