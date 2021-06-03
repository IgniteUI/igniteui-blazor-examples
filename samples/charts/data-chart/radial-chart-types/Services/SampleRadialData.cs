using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class SampleRadialData
    {
        public static List<SampleRadialItem> Create()
        {
            var data = new List<SampleRadialItem>() {
                new SampleRadialItem { Spending= 20, Budget= 60, Department= "Admin" },
                new SampleRadialItem { Spending = 80, Budget = 40, Department = "Sales" },
                new SampleRadialItem { Spending = 30, Budget = 60, Department = "IT" },
                new SampleRadialItem { Spending = 80, Budget = 40, Department = "Marketing" },
                new SampleRadialItem { Spending = 40, Budget = 60, Department = "Research" },
                new SampleRadialItem { Spending = 60, Budget = 20, Department = "Support" },
            };
            return data;
        }
    }

    public class SampleRadialItem
    {
        public double Budget { get; set; }
        public double Spending { get; set; }
        public string Department { get; set; }         
    }
}
