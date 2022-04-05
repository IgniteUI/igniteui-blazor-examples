using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class SampleTimelineData
    {
        public static List<SampleTimelineItem> Create() {
            var data = new List<SampleTimelineItem>() {
                new SampleTimelineItem { Year = "23 June, 2016", Date = new DateTime(2016, 6, 23),   Y = 5, Details = "UK votes to exit the EU"},
                new SampleTimelineItem { Year = "29 March, 2017", Date = new DateTime(2017, 3, 29), Y = 5,  Details = "The UK triggers Article 50"},
                new SampleTimelineItem { Year = "19 June, 2017", Date = new DateTime(2017, 6, 19),  Y = 5, Details = "Brexit negotiations begin"},
                new SampleTimelineItem { Year = "19 March, 2018", Date = new DateTime(2018, 3, 19), Y = 5,  Details = "The EU and the UK agree on a transition phase"},
                new SampleTimelineItem { Year = "25 November, 2018", Date = new DateTime(2018, 12, 25),  Y = 5, Details = "Draft withdrawl deal agreed"},
                new SampleTimelineItem { Year = "29 October, 2019", Date = new DateTime(2019, 10, 29),Y = 5,  Details = "EU heads of state and government approve postponing the Brexit date"},
                new SampleTimelineItem { Year = "31 December, 2020", Date = new DateTime(2020, 12, 31), Y = 5, Details = "Transition period ends"},
            };
            return data;
        }
    }

    public class SampleTimelineItem
    {
        public string Details { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string Year { get; set; }
        public DateTime Date { get; set; }
    }
}
