using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class SampleStackedData
    {
        public static List<SampleStackedItem> Create()
        {
            var data = new List<SampleStackedItem>() {

                new SampleStackedItem { Location = "China", Year = 2019, Hydro = 1269.67, Solar = 223.80, Wind = 405.70, Other = 102.83  },
                new SampleStackedItem { Location = "Europe", Year = 2019, Hydro = 632.54, Solar = 154.66, Wind = 461.59, Other = 220.34 },
                new SampleStackedItem { Location = "United States", Year = 2019, Hydro = 271.16, Solar = 108.36, Wind = 303.10, Other = 78.34  },
                new SampleStackedItem { Location = "Brazil", Year = 2019, Hydro = 399.30, Solar = 5.56, Wind = 55.83, Other = 56.25},
                new SampleStackedItem { Location = "Canadas", Year = 2019, Hydro = 381.98, Solar = 4.31, Wind = 34.17, Other = 10.81 },
              //  new SampleStackedItem { Country = "France", Coal = 375, Oil = 150, Solar = 350, Nuclear = 275, Hydro = 325 }          
        };
            return data;
        }
    }

    public class SampleStackedItem
    {
        public string Location { get; set; }
        public int Year { get; set; }
        public double Hydro { get; set; }
        public double Solar { get; set; }
        public double Wind { get; set; }
        public double Other { get; set; }
        public double Sum { get; set; }
    }
}
