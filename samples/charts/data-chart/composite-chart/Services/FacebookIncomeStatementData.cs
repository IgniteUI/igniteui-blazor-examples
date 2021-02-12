using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class FacebookIncomeStatementInfo
    {
        public DateTime Date { get; set; }
        public double Revenue { get; set; }
        public double TotalCostsAndExpenses { get; set; }
        public double NetIncome { get; set; }        
    }

    public class FacebookIncomeStatementData : List<FacebookIncomeStatementInfo>
    {
        public FacebookIncomeStatementData()
        {
            this.Add(new FacebookIncomeStatementInfo() { Date = new DateTime(2018, 12, 31), Revenue = 16914, TotalCostsAndExpenses = 10183, NetIncome = 6882 });
            this.Add(new FacebookIncomeStatementInfo() { Date = new DateTime(2019, 3, 31),  Revenue = 15077, TotalCostsAndExpenses = 12813, NetIncome = 2429 });
            this.Add(new FacebookIncomeStatementInfo() { Date = new DateTime(2019, 6, 30),  Revenue = 16886, TotalCostsAndExpenses = 14476, NetIncome = 2616 });
            this.Add(new FacebookIncomeStatementInfo() { Date = new DateTime(2019, 9, 30),  Revenue = 17652, TotalCostsAndExpenses = 11705, NetIncome = 6091 });
            this.Add(new FacebookIncomeStatementInfo() { Date = new DateTime(2019, 12, 31), Revenue = 21082, TotalCostsAndExpenses = 14044, NetIncome = 7349 });
            this.Add(new FacebookIncomeStatementInfo() { Date = new DateTime(2020, 3, 31),  Revenue = 17737, TotalCostsAndExpenses = 12803, NetIncome = 4902 });
            this.Add(new FacebookIncomeStatementInfo() { Date = new DateTime(2020, 6, 30),  Revenue = 18687, TotalCostsAndExpenses = 13677, NetIncome = 5178 });
            this.Add(new FacebookIncomeStatementInfo() { Date = new DateTime(2020, 9, 30),  Revenue = 21470, TotalCostsAndExpenses = 13717, NetIncome = 7846 });
            this.Add(new FacebookIncomeStatementInfo() { Date = new DateTime(2020, 12, 31), Revenue = 28072, TotalCostsAndExpenses = 17133, NetIncome = 11219 });            
        }
    }    
}
