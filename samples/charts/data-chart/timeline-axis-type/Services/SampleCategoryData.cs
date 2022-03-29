using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class SampleCategoryData
    {
        public static List<SampleCategoryItem> Create() {
            // total olympic medals for top countries
            var data = new List<SampleCategoryItem>() {
                new SampleCategoryItem {Year = new DateTime(2021, 1, 1),   Y = 5, Details = ""},
                new SampleCategoryItem {Year = new DateTime(2022, 1, 1),   Y = 5, Details = "New Year's Day"},
                new SampleCategoryItem {Year = new DateTime(2022, 1, 17), Y = 5,  Details = "MLK Day"},
                new SampleCategoryItem {Year = new DateTime(2022, 5, 30),  Y = 5, Details = "Memorial Day"},
                new SampleCategoryItem {Year = new DateTime(2022, 7, 4), Y = 5,  Details = "Independence Day"},
                new SampleCategoryItem {Year = new DateTime(2022, 9, 5),  Y = 5, Details = "Labor Day"},
                new SampleCategoryItem {Year = new DateTime(2022, 11, 11),Y = 5,  Details = "Veterans Day"},
                new SampleCategoryItem {Year = new DateTime(2022, 11, 24), Y = 5, Details = "Thanksgiving"},
                new SampleCategoryItem {Year = new DateTime(2022, 12, 12),Y = 5,  Details = "Christmas"},
                new SampleCategoryItem {Year = new DateTime(2024, 12, 31),   Y = 5, Details = ""},

            };
            return data;
        }
    }

    public class SampleCategoryItem
    {
        public string Details { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public DateTime Year { get; set; }
    }
}
