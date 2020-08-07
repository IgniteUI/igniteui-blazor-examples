using System;
using System.Collections.Generic;
using System.Linq;

namespace Samples.Services
{    
    public class StockList : List<StockItem>
    { 
        public StockList() 
        { 
        }

        public StockList(double rangeYears)
        {
            var rangeMonths = (int)(rangeYears * 12); 
            if (rangeMonths < 1) rangeMonths = 24;

            var end = DateTime.Now;
            var start = end.AddMonths(-rangeMonths);

            Generate(start, end);
             
        }

        public StockList(int daysCount, string title, 
                         TimeSpan? interval = null, 
                         double? price = null, double? volume = null)
        {  
            var start = new DateTime(2020, 1, 1); 
            var end = start.AddDays(daysCount); 

            Generate(start, end, interval, price);
            
            this.Title = title;  
        }
          
        public StockList(int startYear, int startMonth, int startDay,
                         int endYear, int endMonth, int endDay, string title,
                         TimeSpan? interval = null, 
                         double? price = null, double? volume = null, 
                         bool includeWeekends = false)
        {    
            if (endMonth > 12)
            {
                endYear += endMonth / 12;
                endMonth = endMonth % 12;
            }

            if (startMonth > 12)
            {
                startYear += startMonth / 12;
                startMonth = startMonth % 12;
            }

            var start = new DateTime(startYear, startMonth, startDay, 16, 30, 0); 
            var end = new DateTime(endYear, endMonth, endDay, 16, 30, 0);   

            Generate(start, end, interval, price, volume, includeWeekends);
            
            this.Title = title; 
        } 
                
        public StockList(DateTime start, DateTime end, string title, 
                         TimeSpan? interval = null, 
                         double? price = null, double? volume = null, 
                         bool includeWeekends = false)
        {  
                Generate(start, end, interval, price, volume, includeWeekends);
                this.Title = title; 
        }

        string GetInfo()
        { 
            if (this.Count == 0) return " - 0000 items";
           
            var info = " {";
            if (this.TimeSpan.TotalDays >= 1 || this.TimeStart.Equals(this.TimeEnd))
            {
                info += this.TimeStart.ToString("MMM/dd/yyyy") + " - ";
                info += this.TimeEnd.ToString("MMM/dd/yyyy");
            }
            else
            {
                info += this.TimeStart.ToString("HH:mm:ss") + " - ";
                info += this.TimeEnd.ToString("HH:mm:ss");
            }
            info += "} ";
            info += this.Count.ToString("0000") + " items with ";

            if (this.TimeInterval.TotalDays >= 1)
                info += this.TimeInterval.TotalDays.ToString("00") + "d interval";
            else if (this.TimeInterval.TotalHours >= 1)
                info += this.TimeInterval.TotalHours.ToString("00") + "h interval";
            else if (this.TimeInterval.TotalMinutes >= 1)
                info += this.TimeInterval.TotalMinutes.ToString("00") + "m interval";
            else if (this.TimeInterval.TotalSeconds >= 1)
                info += this.TimeInterval.TotalSeconds.ToString("00") + "s interval";

            return info;
        }
        
        public string Title { get; set; }

        public string Info { get { return this.Title + GetInfo();} }        
        public DateTime TimeStart { get { return this.First().Time;} }     
        public DateTime TimeEnd { get { return this.Last().Time;} } 
        public TimeSpan TimeSpan { get { return this.TimeEnd.Subtract(this.TimeStart);} }
        public TimeSpan TimeInterval { get; set; }

        static Random rand = new Random();
        public StockList Filter(bool includeWeekends)
        { 
            var values = new StockList();
            values.Title = this.Title;
            values.TimeInterval = this.TimeInterval;

            foreach (var item in this)
            {
                if (includeWeekends ||
                   (item.Time.DayOfWeek != DayOfWeek.Sunday &&
                    item.Time.DayOfWeek != DayOfWeek.Saturday))
                {
                    values.Add(item);
                }
            }
            return values;
        }

        public void Generate(DateTime start, DateTime end, TimeSpan? interval = null, 
            double? price = null, double? volume = null, 
            bool includeWeekends = false)
        {
            this.Clear();

            if (interval == null)
                interval = TimeSpan.FromDays(1);

            this.TimeInterval = interval.Value;

            var priceStart = 200.0;
            if (price != null)
                priceStart = price.Value;;
             
            var priceRange = 10.0;
            var volumeStart = 10000.0;
            if (volume != null)
                volumeStart = volume.Value;;
          
            var date = start;  
            
            var v = volumeStart;
            var o = priceStart;
            var h = o + (rand.NextDouble() * 10);
            var l = o - (rand.NextDouble() * 10);
            var c = l + (rand.NextDouble() * (h - l));

            var values = new List<StockItem>();
            while (date.Ticks < end.Ticks)
            { 
                if (includeWeekends && values.Count > 0 &&
                   (date.DayOfWeek == DayOfWeek.Sunday ||
                    date.DayOfWeek == DayOfWeek.Saturday))
                {
                    var previous = values[values.Count - 1];
                    var stock = previous.Clone();                    
                    stock.Time = date;
                    
                    values.Add(stock);  
                }
                else                
                {
                    var stock = new StockItem();
                    stock.Time = date;
                    stock.Open = o;
                    stock.High = h;
                    stock.Low = l;
                    stock.Close = c;
                    stock.Volume = v;
                    
                    values.Add(stock);
                
                    o = c + ((rand.NextDouble() - 0.5) * priceRange);
                    h = o + (rand.NextDouble() * 1.001 * priceRange);
                    l = o - (rand.NextDouble() * priceRange);
                    c = l + (rand.NextDouble() * (h - l));
                    v = v + ((rand.NextDouble() - 0.5) * 300);
                } 
                date = date.Add(interval.Value);
            }

            this.AddRange(values);
        }
                  
         
    }

    
}
