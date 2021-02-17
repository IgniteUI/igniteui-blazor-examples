using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class RenewableElectricityStackedInfo
    {
        public string Year { get; set; }
        public double USA { get; set; }
        public double Europe { get; set; }
        public double China { get; set; }
        public double USAMarker { get; set; }
        public double EuropeMarker { get; set; }
        public double ChinaMarker { get; set; }
        public double Sum { get; set; }
    }

    public class RenewableElectricityStackedData : List<RenewableElectricityStackedInfo>
    {
        public RenewableElectricityStackedData()
        {
            this.Add(new RenewableElectricityStackedInfo() { Year = "2014", USA = 30, Europe = 40, China = 45 });
            this.Add(new RenewableElectricityStackedInfo() { Year = "2015", USA = 20, Europe = 80, China = 50 });
            this.Add(new RenewableElectricityStackedInfo() { Year = "2016", USA = 50, Europe = 15, China = 90 });
            this.Add(new RenewableElectricityStackedInfo() { Year = "2017", USA = 50, Europe = 80, China = 130 });
            this.Add(new RenewableElectricityStackedInfo() { Year = "2018", USA = 35, Europe = 40, China = 135 });
            this.Add(new RenewableElectricityStackedInfo() { Year = "2019", USA = 40, Europe = 80, China = 95 });

            foreach(RenewableElectricityStackedInfo info in this)
            {
                info.USAMarker = info.USA / 2;
                info.EuropeMarker = info.USA + (info.Europe / 2);
                info.ChinaMarker = info.USA + info.Europe + (info.China / 2);
                info.Sum = info.USA + info.Europe + info.China;
            }
        }
    }
}
