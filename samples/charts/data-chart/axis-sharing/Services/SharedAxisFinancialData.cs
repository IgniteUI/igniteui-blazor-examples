using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class SharedAxisFinancialData
    {
        public static Random random = new Random();
        public static List<SharedAxisFinancialItem> Create(int itemsCount = 365)
        {
            var data = new List<SharedAxisFinancialItem>();
           
            // initial values
            var v = 10000.0;
            var o = 500.0;
            var h = Math.Round(o + (random.NextDouble() * 5));
            var l = Math.Round(o - (random.NextDouble() * 5));
            var c = Math.Round(l + (random.NextDouble() * (h - l)));

            var today = DateTime.Now;
            var end = new DateTime(today.Year, today.Month, today.Day);
            var time = end.AddDays(-itemsCount);

            for (var i = 0; i < itemsCount; i++)
            {
                var date = time.ToShortDateString();
                var label = GetShortDate(time, false);
                // adding new data item
                var item = new SharedAxisFinancialItem();
                item.Time = time;
                item.Date = date;
                item.Label = label;
                item.Close = c;
                item.Open = o;
                item.High = h;
                item.Low = l;
                item.Volume = v;
                data.Add(item);
                
                // generating new values
                var mod = random.NextDouble() - 0.49;
                o = Math.Round(o + (mod * 5 * 4));
                o = Math.Max(o, 500);
                o = Math.Min(o, 675);

                v = Math.Round(v + (mod * 5 * 100));
                h = Math.Round(o + (random.NextDouble() * 15));
                l = Math.Round(o - (random.NextDouble() * 15));
                c = Math.Round(l + (random.NextDouble() * (h - l)));
                time = time.AddDays(1);
            }
            return data;
        }

        public static string GetShortDate(DateTime dt, bool showYear)
        {
            var months = new List<string> {
                "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };
            var ind = dt.Month - 1;
            var day = dt.Day;
            var label = months[ind] + " " + day;
            if (showYear)
            {
                label += " " + dt.Year;
            }
            return label;
        }
    }

    public class SharedAxisFinancialItem
    {
        public double High { get; set; }
        public double Low { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }

        public string Label { get; set; }
        public string Date { get; set; }
        public DateTime Time { get; set; }
    }
}
