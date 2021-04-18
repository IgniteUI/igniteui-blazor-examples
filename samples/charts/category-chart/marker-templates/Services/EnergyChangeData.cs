using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class EnergyChangeInfo
    {
        public string Location { get; set; }
        public double Solar { get; set; }
        public double Coal { get; set; }
        public double Hydro { get; set; }
        public double Wind { get; set; }
        public double Nuclear { get; set; }
    }

    public class EnergyChangeData : List<EnergyChangeInfo>
    {
        public EnergyChangeData()
        {
            Add(new EnergyChangeInfo { Location = "World", Solar = 23, Coal = -1, Hydro = 1, Wind = 12, Nuclear = 3 });
            Add(new EnergyChangeInfo { Location = "China", Solar = 26, Coal = 2, Hydro = 5, Wind = 10, Nuclear = 18 });
            Add(new EnergyChangeInfo { Location = "U.S.", Solar = 15, Coal = -15, Hydro = -7, Wind = 10, Nuclear = 1 });
            Add(new EnergyChangeInfo { Location = "EU", Solar = 11, Coal = -12, Hydro = -2, Wind = 14, Nuclear = -1 });
        }
    }
}
