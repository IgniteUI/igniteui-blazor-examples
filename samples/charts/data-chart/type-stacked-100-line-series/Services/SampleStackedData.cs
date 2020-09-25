using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class SampleStackedData
    {
        public static List<SampleStackedItem> Create()
        {
            var data = new List<SampleStackedItem>() {
                new SampleStackedItem { Country = "Canada", Coal = 400, Oil = 100, Solar = 175, Nuclear = 225, Hydro = 350 },
                new SampleStackedItem { Country = "China", Coal = 925, Oil = 200, Solar = 350, Nuclear = 400, Hydro = 625 },
                new SampleStackedItem { Country = "Russia", Coal = 550, Oil = 200, Solar = 250, Nuclear = 475, Hydro = 425 },
                new SampleStackedItem { Country = "Australia", Coal = 450, Oil = 100, Solar = 150, Nuclear = 175, Hydro = 350 },
                new SampleStackedItem { Country = "United States", Coal = 800, Oil = 250, Solar = 475, Nuclear = 575, Hydro = 750 },
                new SampleStackedItem { Country = "France", Coal = 375, Oil = 150, Solar = 350, Nuclear = 275, Hydro = 325 }
            };
            return data;
        }
    }

    public class SampleStackedItem
    {
        public double Coal { get; set; }
        public double Oil { get; set; }
        public double Solar { get; set; }
        public double Nuclear { get; set; }
        public double Hydro { get; set; }
        public string Country { get; set; }
    }
}
