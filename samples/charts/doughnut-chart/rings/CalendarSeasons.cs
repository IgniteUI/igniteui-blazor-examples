using System;
using System.Collections.Generic;
namespace Data
{
    public class CalendarSeasonsItem
    {
        public double Value{ get; set; }
        public string Label{ get; set; }
    }
    public class CalendarSeasons
        : List<CalendarSeasonsItem>
    {
        public CalendarSeasons()
        {
            this.Add(new CalendarSeasonsItem()
            {
                Value = 4,
                Label = @"Winter"
            });
            this.Add(new CalendarSeasonsItem()
            {
                Value = 4,
                Label = @"Spring"
            });
            this.Add(new CalendarSeasonsItem()
            {
                Value = 4,
                Label = @"Summer"
            });
            this.Add(new CalendarSeasonsItem()
            {
                Value = 4,
                Label = @"Fall"
            });
        }
    }
}
