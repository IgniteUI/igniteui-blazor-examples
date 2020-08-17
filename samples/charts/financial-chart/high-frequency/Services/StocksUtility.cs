using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samples.Services
{
    public class StocksUtility
    {
        public static int intervalDays = 1;
        public static int intervalHours = 0;
        public static int intervalMinutes = 0;

        public static double priceStart = 200;
        public static double priceRange = 1;
        public static double volumeRange = 1000;
        public static double volumeStart = 20000000;

        public static Random rand = new Random();

        public static List<StockItem> GetStocksFrom(DateTime dateEnd, int years)
        {
            var dateStart = dateEnd.AddYears(-years);
            return GetStocksBetween(dateStart, dateEnd);
        }

        public static List<StockItem> GetStocksItems(double points)
        {
            intervalDays = 0;
            intervalHours = 1;
            intervalMinutes = 0;

            var today = DateTime.Today;
            var year = today.Year;
            var dateEnd = new DateTime(year, 11, 1);
            var dateStart = dateEnd.AddHours(-points);
            return GetStocksBetween(dateStart, dateEnd);
        }

        public static List<StockItem> GetStocksBetween(DateTime dateStart, DateTime dateEnd)
        {

            var interval = intervalDays * 24 * 60;
            interval += intervalHours * 60;
            interval += intervalMinutes;

            var time = dateStart.AddDays(0);
            var v = volumeStart;
            var o = priceStart;
            
            var h = o + (rand.NextDouble() * priceRange);
            var l = o - (rand.NextDouble() * priceRange);
            var c = l + (rand.NextDouble() * (h - l));

            List<StockItem> stock = new List<StockItem> { };
            Console.WriteLine(time);
            Console.WriteLine(dateEnd);
            while (time < dateEnd)
            {

                var stockItem =
                new StockItem{
                    Open = o, High = h, Low = l, Close = c, Volume = v 
                };

                stock.Add(stockItem);

                o = c + ((rand.NextDouble() - 0.5) * priceRange);
                if (o < 0)
                {
                    o = Math.Abs(o) + 2;
                }
                h = o + (rand.NextDouble() * priceRange);
                l = o - (rand.NextDouble() * priceRange);
                c = l + (rand.NextDouble() * (h - l));
                v = v + ((rand.NextDouble() - 0.5) * volumeRange);
                if (v < 0)
                {
                    v = Math.Abs(v) + 10000;
                }

                o = Math.Round(o * 100) / 100;
                h = Math.Round(h * 100) / 100;
                l = Math.Round(l * 100) / 100;
                c = Math.Round(c * 100) / 100;
                v = Math.Round(v * 100) / 100;

                time = time.AddMinutes(interval);
            }
            //setting data intent for Series Title
            //   (stock as any).__dataIntents = {
            //    close: ["SeriesTitle/Stock Prices"]
            //};

            return stock;
        }

        public static string toShortString(double largeValue)
        {
            double roundValue;

            if (largeValue >= 1000000)
            {
                roundValue = Math.Round(largeValue / 100000) / 10;
                return roundValue + "M";
            }
            if (largeValue >= 1000)
            {
                roundValue = Math.Round(largeValue / 100) / 10;
                return roundValue + "K";
            }

            roundValue = Math.Round(largeValue);
            return roundValue + "";
        }

        public static DateTime GetYear(DateTime date)
        {
            return new DateTime(date.Year);
        }

        public static double GetQuarter(DateTime date)
        {
            var month = date.Month;
            double d = (month + 2) / 3;
            return Math.Round(d);
        }

        public static StockItem GetLastItem(List<StockItem> array)
        {
            if (array.Count == 0)
            {
                return null;
            }
            return array.LastOrDefault();
        }

        public static List<StockItem> GetNewItem(List<StockItem> array, int ?interval)
        {
            var lastItem = GetLastItem(array);

            if (interval == null)
            {
                interval = intervalDays * 24 * 60;
                interval += intervalHours * 60;
                interval += intervalMinutes;
            }

            var time = lastItem.Date.AddMinutes(interval.Value);
            var v = lastItem.Volume;
            var o = lastItem.Open;
            var h = lastItem.High;
            var l = lastItem.Low;
            var c = lastItem.Close;

            o = c + ((rand.NextDouble() - 0.5) * priceRange);
            if (o < 0)
            {
                o = Math.Abs(o) + 2;
            }
            h = o + (rand.NextDouble() * priceRange);
            l = o - (rand.NextDouble() * priceRange);
            c = l + (rand.NextDouble() * (h - l));
            v = v + ((rand.NextDouble() - 0.5) * volumeRange);
            if (v < 0)
            {
                v = Math.Abs(v) + 10000;
            }

            var newValue = new List<StockItem> { new StockItem { Date = time, Open = o, High = h, Low = l, Close = c, Volume = v } };

            return newValue;
        }
    }

    public class StockItem
    {
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
        public int Index { get; set; }
        public string Info { get; set; }
        public int Value { get; set; }
        
        public StockItem Clone()
        {
            var copy = new StockItem();
            copy.Date = this.Date;
            copy.Open = this.Open;
            copy.High = this.High;
            copy.Low = this.Low;
            copy.Close = this.Close;
            copy.Volume = this.Volume;
            return copy;
        }
    }

}
