using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class EnergyRenewableInfo
    {
        public string Year { get; set; }
        public int Europe { get; set; }
        public int China { get; set; }
        public int USA { get; set; }
    }

    public class EnergyRenewableData : List<EnergyRenewableInfo>
    {
        public EnergyRenewableData()
        {            
            Add(new EnergyRenewableInfo() { Year = "2009", Europe = 31, China = 21, USA = 19 });
            Add(new EnergyRenewableInfo() { Year = "2010", Europe = 43, China = 26, USA = 24 });
            Add(new EnergyRenewableInfo() { Year = "2011", Europe = 66, China = 29, USA = 28 });
            Add(new EnergyRenewableInfo() { Year = "2012", Europe = 69, China = 32, USA = 26 });
            Add(new EnergyRenewableInfo() { Year = "2013", Europe = 58, China = 47, USA = 38 });
            Add(new EnergyRenewableInfo() { Year = "2014", Europe = 40, China = 46, USA = 31 });
            Add(new EnergyRenewableInfo() { Year = "2015", Europe = 78, China = 50, USA = 19 });
            Add(new EnergyRenewableInfo() { Year = "2016", Europe = 13, China = 90, USA = 52 });
            Add(new EnergyRenewableInfo() { Year = "2017", Europe = 78, China = 132, USA = 50 });
            Add(new EnergyRenewableInfo() { Year = "2018", Europe = 40, China = 134, USA = 34 });
            Add(new EnergyRenewableInfo() { Year = "2019", Europe = 80, China = 96, USA = 38 });            
        }
    }
}
