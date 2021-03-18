using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class FacebookConsolidatedInfo
    {
        public string Category { get; set; }
        public double Value { get; set; }
        public double NetIncomeValue { get; set; }
    }
    public class FacebookConsolidatedData : List<FacebookConsolidatedInfo>
    {
        public FacebookConsolidatedData()
        {
            this.Add(new FacebookConsolidatedInfo() { Category = "Revenue", Value = 55, NetIncomeValue = double.NaN });
            this.Add(new FacebookConsolidatedInfo() { Category = "Cost of Revenue", Value = 45, NetIncomeValue = double.NaN });
            this.Add(new FacebookConsolidatedInfo() { Category = "Research and Development", Value = 35, NetIncomeValue = double.NaN });
            this.Add(new FacebookConsolidatedInfo() { Category = "Marketing and Sales", Value = 28, NetIncomeValue = double.NaN });
            this.Add(new FacebookConsolidatedInfo() { Category = "General and Administrative", Value = 25, NetIncomeValue = double.NaN });
            this.Add(new FacebookConsolidatedInfo() { Category = "Total Costs and Expenses", Value = 55, NetIncomeValue = double.NaN });
            this.Add(new FacebookConsolidatedInfo() { Category = "Net Income", Value = double.NaN, NetIncomeValue = 25 });
        }
    }
}
