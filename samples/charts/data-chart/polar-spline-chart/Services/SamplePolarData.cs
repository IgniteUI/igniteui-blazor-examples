using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class SamplePolarData
    { 
        public static List<SamplePolarItem> Create()
        {
            var data = new List<SamplePolarItem>() {
                new SamplePolarItem { Direction= 0,   BoatSpeed= 70,  WindSpeed= 90 },
                new SamplePolarItem { Direction= 45,  BoatSpeed= 35,  WindSpeed= 65 },
                new SamplePolarItem { Direction= 90,  BoatSpeed= 25,  WindSpeed= 45 },
                new SamplePolarItem { Direction= 135, BoatSpeed= 15,  WindSpeed= 25 },
                new SamplePolarItem { Direction= 180, BoatSpeed= 0,   WindSpeed= 0  },
                new SamplePolarItem { Direction= 225, BoatSpeed= 15,  WindSpeed= 25 },
                new SamplePolarItem { Direction= 270, BoatSpeed= 25,  WindSpeed= 45 },
                new SamplePolarItem { Direction= 315, BoatSpeed= 35,  WindSpeed= 65 },
                new SamplePolarItem { Direction= 360, BoatSpeed= 70,  WindSpeed= 90 },
            };
            return data;
        }
    }

    public class SamplePolarItem
    {
        public double WindSpeed { get; set; }
        public double BoatSpeed { get; set; }
        public double Direction { get; set; }         
    }
}
