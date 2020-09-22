using System;
using System.Collections.Generic;

namespace Infragistics.Samples{
    public static class DataChartSharedData
    {
        public class Energy {
            public string Country { get; set; }
            public double Coal { get; set; }
            public double Oil { get; set; }
            public double Gas { get; set; }
            public double Nuclear { get; set; }
            public double Hydro { get; set; }
        }

        public static List<Energy> GetEnergyProduction() {
            var dp = new Energy { Country = "", Coal = 400000000};

            var data = new List<Energy>() {
                new Energy { Country = "Canada", Coal = 400000000, Oil = 100000000, Gas = 175000000, Nuclear = 225000000, Hydro = 350000000 },
                new Energy { Country = "China", Coal = 925000000, Oil = 200000000, Gas = 350000000, Nuclear = 400000000, Hydro = 625000000 },
                new Energy { Country = "Russia", Coal = 550000000, Oil = 200000000, Gas = 250000000, Nuclear = 475000000, Hydro = 425000000 },
                new Energy { Country = "Australia", Coal = 450000000, Oil = 100000000, Gas = 150000000, Nuclear = 175000000, Hydro = 350000000 },
                new Energy { Country = "United States", Coal = 800000000, Oil = 250000000, Gas = 475000000, Nuclear = 575000000, Hydro = 750000000 },
                new Energy { Country = "France", Coal = 375000000, Oil = 150000000, Gas = 350000000, Nuclear = 275000000, Hydro = 325000000 }
            };
            return data;
        }
    }
}
