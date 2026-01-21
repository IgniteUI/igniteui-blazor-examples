using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public static class EnergyProductionData
    {
        public class Energy
        {
            public string Country { get; set; }
            public double Coal { get; set; }
            public double Oil { get; set; }
            public double Gas { get; set; }
            public double Nuclear { get; set; }
            public double Hydro { get; set; }
        }
        public static List<Energy> Generate()
        {
            var data  = new List<Energy>() {
            new Energy() { Coal = 400000000, Country = "Canada", Gas = 175000000, Hydro = 350000000, Nuclear = 225000000, Oil = 100000000 }, 
            new Energy() { Coal = 925000000, Country = "China", Gas = 350000000, Hydro = 625000000, Nuclear = 400000000, Oil = 200000000 }, 
            new Energy() { Coal = 550000000, Country = "Russia", Gas = 250000000, Hydro = 425000000, Nuclear = 475000000, Oil = 200000000 }, 
            new Energy() { Coal = 450000000, Country = "Australia", Gas = 150000000, Hydro = 350000000, Nuclear = 175000000, Oil = 100000000 }, 
            new Energy() { Coal = 800000000, Country = "United States", Gas = 475000000, Hydro = 750000000, Nuclear = 575000000, Oil = 250000000 }, 
            new Energy() { Coal = 375000000, Country = "France", Gas = 350000000, Hydro = 325000000, Nuclear = 275000000, Oil = 150000000 }
            };
            return data;
        }
    }
}
