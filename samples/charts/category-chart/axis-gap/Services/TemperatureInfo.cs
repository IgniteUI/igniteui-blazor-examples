using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class TemperatureInfo
    {
        public string Month { get; set; }
        public double Temperature { get; set; }        
    }

    public class TemperatureData : List<TemperatureInfo>
    {
        public TemperatureData()
        {
            Add(new TemperatureInfo() { Month = "January",   Temperature = 3 });
            Add(new TemperatureInfo() { Month = "February",  Temperature = 4 });
            Add(new TemperatureInfo() { Month = "March",     Temperature = 9 });
            Add(new TemperatureInfo() { Month = "April",     Temperature = 15 });
            Add(new TemperatureInfo() { Month = "May",       Temperature = 21 });
            Add(new TemperatureInfo() { Month = "June",      Temperature = 26 });
            Add(new TemperatureInfo() { Month = "July",      Temperature = 29 });
            Add(new TemperatureInfo() { Month = "August",    Temperature = 28 });
            Add(new TemperatureInfo() { Month = "September", Temperature = 24 });
            Add(new TemperatureInfo() { Month = "October",   Temperature = 18 });
            Add(new TemperatureInfo() { Month = "November",  Temperature = 11 });
            Add(new TemperatureInfo() { Month = "December",  Temperature = 5 });
        }
    }
}
