using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public static class DataChartSharedData
    { 
        public static List<OlympicMedals> GetOlympicMedals()
        {
            var olympicMedals = new List<OlympicMedals>();
            olympicMedals.Add(new OlympicMedals() { Year = "1996", USA = 148, CHN = 110, RUS = 95 });
            olympicMedals.Add(new OlympicMedals() { Year = "2000", USA = 142, CHN = 115, RUS = 91 });
            olympicMedals.Add(new OlympicMedals() { Year = "2004", USA = 134, CHN = 121, RUS = 86 });
            olympicMedals.Add(new OlympicMedals() { Year = "2008", USA = 131, CHN = 129, RUS = 65 });
            olympicMedals.Add(new OlympicMedals() { Year = "2012", USA = 135, CHN = 115, RUS = 77 });
            olympicMedals.Add(new OlympicMedals() { Year = "2016", USA = 146, CHN = 112, RUS = 88 });

            return olympicMedals;
        }
        
    }

    public class OlympicMedals
    {
        public int USA { get; set; }
        public int CHN { get; set; }
        public int RUS { get; set; }
        public string Year { get; set; }
    }
}
