using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class IncomeTaxesItem
    {
        public string Year { get; set; }
        public double Revenue { get; set; }

        public IncomeTaxesItem(string year, double revenue)
        {
            Year = year;
            Revenue = revenue;
        }
    }

    public class IncomeTaxes : List<IncomeTaxesItem>
    {
        public IncomeTaxes()
        {
            this.AddRange(new List<IncomeTaxesItem>
            {
                new IncomeTaxesItem("2021", 15),
                new IncomeTaxesItem("2022", 30),
                new IncomeTaxesItem("2023", 18),
                new IncomeTaxesItem("2024", 30),
                new IncomeTaxesItem("2025", 38)
            });
        }
    }
}
