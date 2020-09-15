using IgniteUI.Blazor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class SalesPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string Territory { get; set; }
        public int Index { get; set; }
        public double AvgSale { get; set; }
        public double AvgSaleHeat { get; set; }
        public double Change { get; set; }
        public double PercentChange { get; set; }
        public double YearToDateSales { get; set; }
        public DateTime DateValue { get; set; }

        public double KPI_0 { get; set; }
        public double KPI_1 { get; set; }
        public double KPI_2 { get; set; }
        public double KPI_3 { get; set; }
        public double KPI_4 { get; set; }
        public double KPI_5 { get; set; }
        public double KPI_6 { get; set; }
        public double KPI_7 { get; set; }
    }

    public class SalesPersonData
    {
        public static List<SalesPerson> GenerateSalesPeople(int number)
        {
            string[] firstNames = new string[] {
           "Kyle",
           "Gina",
           "Irene",
           "Katie",
           "Michael",
           "Oscar",
           "Ralph",
           "Torrey",
           "William",
           "Bill",
           "Daniel",
           "Frank",
           "Brenda",
           "Danielle",
           "Fiona",
           "Howard",
           "Jack",
           "Larry",
           "Holly",
           "Jennifer",
           "Liz",
           "Pete",
           "Steve",
           "Vince",
           "Zeke"
            };

            string[] lastNames = new string[] {
                "Adams",
            "Crowley",
            "Ellis",
            "Gable",
            "Irvine",
            "Keefe",
            "Mendoza",
            "Owens",
            "Rooney",
            "Waddell",
            "Thomas",
            "Betts",
            "Doran",
            "Fitzgerald",
            "Holmes",
            "Jefferson",
            "Landry",
            "Newberry",
            "Perez",
            "Spencer",
            "Vargas",
            "Grimes",
            "Edwards",
            "Stark",
            "Cruise",
            "Fitz",
            "Chief",
            "Blanc",
            "Perry",
            "Stone",
            "Williams",
            "Lane",
            "Jobs"
            };

            string[] genders = new string[] {
                "GUY",
                "GIRL",
                "GIRL",
                "GIRL",
                "GUY",
                "GUY",
                "GUY",
                "GUY",
                "GUY",
                "GUY",
                "GUY",
                "GUY",
                "GIRL",
                "GIRL",
                "GIRL",
                "GUY",
                "GUY",
                "GUY",
                "GIRL",
                "GIRL",
                "GIRL",
                "GUY",
                "GUY",
                "GUY",
                "GUY"
            };

            string[] territories = new string[]{
                "Australia",
                "Canada",
                "Egypt",
                "Greece",
                "Italy",
                "Kenya",
                "Mexico",
                "Oman",
                "Qatar",
                "Sweden",
                "Uruguay",
                "Yemen",
                "Bulgaria",
                "Denmark",
                "France",
                "Hungary",
                "Japan",
                "Latvia",
                "Netherlands",
                "Portugal",
                "Russia",
                "Turkey",
                "Venezuela",
                "Zimbabwe"
            };

            List<SalesPerson> items = new List<SalesPerson>();

            Random r = new Random();

            for (int i = 0; i < number; i++)
            {
                SalesPerson item = new SalesPerson();
                int firstIndex = (int)Math.Round(r.NextDouble() * (firstNames.Length - 1));

                item.Index = i;
                item.FirstName = firstNames[firstIndex];
                item.LastName = lastNames[(int)Math.Round(r.NextDouble() * (lastNames.Length - 1))];
                item.Name = item.FirstName + item.LastName;

                int randomIndex = (int)Math.Round(r.NextDouble() * (firstNames.Length - 1));

                if (randomIndex == 0)
                {
                    randomIndex = 1;
                }

                string value = randomIndex.ToString();
                if (randomIndex < 10)
                {
                    value = "0" + value;
                }

                item.ImageName = SalesPersonData.CreateUri(genders[firstIndex] + value + ".png");
                item.Territory = territories[(int)Math.Round(r.NextDouble() * (territories.Length - 1))];
                item.AvgSale = Math.Round((r.NextDouble() * 800)) + 200.0;
                item.Change = (r.NextDouble() * 40.0) - 20.0;
                item.PercentChange = 0;
                item.YearToDateSales = Math.Round(r.NextDouble() * 50000);

                item.DateValue = DateTime.Today.AddDays(number * -1);

                for (int j = 0; j < 8; j++)
                {
                    PropertyInfo info = typeof(SalesPerson).GetProperty("KPI_" + j.ToString());
                    info.SetValue(item, Math.Round(r.NextDouble() * 100));
                }

                items.Add(item);
            }

            return items;
        }

        public static string CreateUri(string value)
        {
            return "https://static.infragistics.com/xplatform/images/people/" + value;
        }
    }
}
