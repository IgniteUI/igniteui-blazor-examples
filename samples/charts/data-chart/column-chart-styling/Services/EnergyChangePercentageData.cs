using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class EnergyChangePercentageInfo
    {
        public string Location { get; set; }
        public double Solar { get; set; }
        public double Coal { get; set; }
        public double Hydropower { get; set; }
        public double Wind { get; set; }
        public double Nuclear { get; set; }
    }

    public class EnergyChangePercentageData : List<EnergyChangePercentageInfo>
    {
        public EnergyChangePercentageData()
        {
            Add(new EnergyChangePercentageInfo() { Location = "World", Solar = 23, Coal = -1,   Hydropower =  1,  Wind = 12, Nuclear = 3 });
            Add(new EnergyChangePercentageInfo() { Location = "China", Solar = 26, Coal =  2,   Hydropower =  5,  Wind = 10, Nuclear = 18 });
            Add(new EnergyChangePercentageInfo() { Location = "U.S.",  Solar = 15, Coal = -15,  Hydropower = -7,  Wind = 10, Nuclear = 1 });
            Add(new EnergyChangePercentageInfo() { Location = "EU",    Solar = 11, Coal = -12,  Hydropower =  -2, Wind = 14, Nuclear = -1 });            
        }
    }
}
