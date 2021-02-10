using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class OnlineShoppingInfo
    {
        public string Shop { get; set; }
        public double Percent { get; set; }
        
    }

    public class OnlineShoppingData : List<OnlineShoppingInfo>
    {
        public OnlineShoppingData()
        {
            Add(new OnlineShoppingInfo() { Shop = "Amazon",                      Percent = 63 });
            Add(new OnlineShoppingInfo() { Shop = "Search Engines",              Percent = 48 });
            Add(new OnlineShoppingInfo() { Shop = "Retailer Sites",              Percent = 33 });
            Add(new OnlineShoppingInfo() { Shop = "Other Marketplaces",          Percent = 25 });
            Add(new OnlineShoppingInfo() { Shop = "At the Website of the Brand", Percent = 21 });
            Add(new OnlineShoppingInfo() { Shop = "Comparison Sites",            Percent = 10 });
            Add(new OnlineShoppingInfo() { Shop = "Social Media",                Percent = 8 });
            Add(new OnlineShoppingInfo() { Shop = "Other",                       Percent = 2 });
        }
    }
}
