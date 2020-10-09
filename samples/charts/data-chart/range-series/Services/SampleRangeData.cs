using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class SampleRangeData
    {
        public static Random random = new Random();

        public static List<SampleRangeItem> Create()
        {
            var data = new List<SampleRangeItem>();
            var temperature = 25.0; 
            
            for (var i = 1900; i < 2020; i++)
            {
                temperature += (random.NextDouble() - 0.485) * 0.5;
                var low  = (temperature + (random.NextDouble() * 1));
                var high = (temperature - (random.NextDouble() * 1));
                var item = new SampleRangeItem(); 
                item.Year = i; 
                item.High = Math.Round(low * 10) / 10;
                item.Low = Math.Round(high * 10) / 10;
                data.Add(item);
            }
            return data;
        }
    }

    public class SampleRangeItem
    {
        public double High { get; set; }
        public double Low { get; set; }
        public int Year { get; set; }
    }
}
