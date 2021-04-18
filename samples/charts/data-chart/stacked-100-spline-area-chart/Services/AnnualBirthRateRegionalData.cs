using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class AnnualBirthRateRegionalInfo
    {
        public string Year { get; set; }
        public double Asia { get; set; }
        public double Africa { get; set; }
        public double Europe { get; set; }
        public double NorthAmerica { get; set; }
        public double SouthAmerica { get; set; }
        public double Oceania { get; set; }
    }

    public class AnnualBirthRateRegionalData : List<AnnualBirthRateRegionalInfo>
    {
        public AnnualBirthRateRegionalData()
        {
            this.Add(new AnnualBirthRateRegionalInfo() { Year = "1950", Asia = 62, Africa = 13, Europe = 10, NorthAmerica = 4, SouthAmerica = 8,  Oceania = 2 });
            this.Add(new AnnualBirthRateRegionalInfo() { Year = "1960", Asia = 68, Africa = 12, Europe = 15, NorthAmerica = 4, SouthAmerica = 9,  Oceania = 2 });
            this.Add(new AnnualBirthRateRegionalInfo() { Year = "1970", Asia = 80, Africa = 17, Europe = 11, NorthAmerica = 3, SouthAmerica = 9,  Oceania = 2 });
            this.Add(new AnnualBirthRateRegionalInfo() { Year = "1980", Asia = 77, Africa = 21, Europe = 12, NorthAmerica = 3, SouthAmerica = 10, Oceania = 2 });
            this.Add(new AnnualBirthRateRegionalInfo() { Year = "1990", Asia = 87, Africa = 24, Europe = 9,  NorthAmerica = 3, SouthAmerica = 10, Oceania = 2 });
            this.Add(new AnnualBirthRateRegionalInfo() { Year = "2000", Asia = 79, Africa = 28, Europe = 8,  NorthAmerica = 4, SouthAmerica = 9,  Oceania = 2 });
            this.Add(new AnnualBirthRateRegionalInfo() { Year = "2010", Asia = 78, Africa = 35, Europe = 10, NorthAmerica = 4, SouthAmerica = 8,  Oceania = 2 });
            this.Add(new AnnualBirthRateRegionalInfo() { Year = "2020", Asia = 75, Africa = 43, Europe = 7,  NorthAmerica = 4, SouthAmerica = 7,  Oceania = 2 });
        }
    }
}
