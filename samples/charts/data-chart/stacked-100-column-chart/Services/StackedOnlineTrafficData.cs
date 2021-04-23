using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class StackedOnlineTrafficInfo
    {
        public string Category { get; set; }
        public double Desktop { get; set; }
        public double Mobile { get; set; }
        public double Tablet { get; set; }
        public double DesktopMarker { get; set; }
        public double MobileMarker { get; set; }
        public double TabletMarker { get; set; }
    }

    public class StackedOnlineTrafficData : List<StackedOnlineTrafficInfo>
    {
        public StackedOnlineTrafficData()
        {
            this.Add(new StackedOnlineTrafficInfo() { Category = "Apparel",     Desktop = 27, Mobile = 66, Tablet = 7 });
            this.Add(new StackedOnlineTrafficInfo() { Category = "Beauty",      Desktop = 29, Mobile = 66, Tablet = 5 });
            this.Add(new StackedOnlineTrafficInfo() { Category = "Travel",      Desktop = 41, Mobile = 51, Tablet = 8 });
            this.Add(new StackedOnlineTrafficInfo() { Category = "Grocery",     Desktop = 37, Mobile = 57, Tablet = 6 });
            this.Add(new StackedOnlineTrafficInfo() { Category = "Energy",      Desktop = 58, Mobile = 39, Tablet = 3 });
            this.Add(new StackedOnlineTrafficInfo() { Category = "Home Supply", Desktop = 35, Mobile = 56, Tablet = 8 });
            this.Add(new StackedOnlineTrafficInfo() { Category = "Financial",   Desktop = 58, Mobile = 39, Tablet = 3 });

            foreach(StackedOnlineTrafficInfo info in this)
            {
                info.DesktopMarker = info.Desktop / 2;
                info.MobileMarker = info.Desktop + (info.Mobile / 2);
                info.TabletMarker = info.Desktop + info.Mobile + (info.Tablet / 2);
            }
        }
    }
}
