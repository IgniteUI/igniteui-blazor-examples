using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class SampleCategoryData
    {
        public static List<SampleCategoryItem> Create() {
            // total olympic medals for top countries
            var data = new List<SampleCategoryItem>() {
                new SampleCategoryItem {Year = "1996", USA= 148, CHN= 110, RUS= 95},
                new SampleCategoryItem {Year = "2000", USA= 142, CHN= 115, RUS= 91},
                new SampleCategoryItem {Year = "2004", USA= 134, CHN= 121, RUS= 86},
                new SampleCategoryItem {Year = "2008", USA= 131, CHN= 129, RUS= 65},
                new SampleCategoryItem {Year = "2012", USA= 135, CHN= 115, RUS= 77},
                new SampleCategoryItem {Year = "2016", USA= 146, CHN= 112, RUS= 88},
            };
            return data;
        }
    }

    public class SampleCategoryItem
    {    
        public int USA { get; set; }
        public int CHN { get; set; }
        public int RUS { get; set; }

        public string Year { get; set; }
    }
}
