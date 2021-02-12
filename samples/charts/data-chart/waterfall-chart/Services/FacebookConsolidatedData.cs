using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class FacebookConsolidatedInfo
    {
        public string Category { get; set; }
        public double Value { get; set; }
    }
    public class FacebookConsolidatedData : List<FacebookConsolidatedInfo>
    {
        public FacebookConsolidatedData()
        {
            this.Add(new FacebookConsolidatedInfo() { Category = "Revenue", Value = 55 });
            this.Add(new FacebookConsolidatedInfo() { Category = "Cost of Revenue", Value = 45 });
            this.Add(new FacebookConsolidatedInfo() { Category = "Research and Development", Value = 35 });
            this.Add(new FacebookConsolidatedInfo() { Category = "Marketing and Sales", Value = 28 });
            this.Add(new FacebookConsolidatedInfo() { Category = "General and Administrative", Value = 25 });
            this.Add(new FacebookConsolidatedInfo() { Category = "Total Costs and Expenses", Value = 55 });
            //this.Add(new FacebookConsolidatedInfo() { Consolidation = "Income from Operations", Value = 55 });
            //this.Add(new FacebookConsolidatedInfo() { Consolidation = "Interest and Other Income", Value = 55 });
            //this.Add(new FacebookConsolidatedInfo() { Consolidation = "Income Before Provision for Income Taxes", Value = 55 });
            //this.Add(new FacebookConsolidatedInfo() { Consolidation = "Income Before Provision for Income Taxes", Value = 55 });
            //this.Add(new FacebookConsolidatedInfo() { Consolidation = "Income Before Provision for Income Taxes", Value = 55 });



        }
    }
}
