using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samples.Services
{
    

class StocksUtility {

    public int intervalDays = 1;
    public int intervalHours = 0;
    public int intervalMinutes = 0;

    public double priceStart = 200;
    public double priceRange = 1;
    public double volumeRange = 1000;
    public double volumeStart = 20000000;

    public Stock[] GetStocksFrom(DateTime dateEnd, int years) {
        var dateStart = AddYears(dateEnd, -years);
        return GetStocksBetween(dateStart, dateEnd);
    }

    public Stock[] GetStocksItems(int points) {
        intervalDays = 0;
        intervalHours = 1;
        intervalMinutes = 0;

        var today = DateTime.Today;
        var year = today.Year;
        var dateEnd = new DateTime(year, 11, 1);
        var dateStart = AddHours(dateEnd, -points);
        return GetStocksBetween(dateStart, dateEnd);
    }

    public Stock[] GetStocksBetween(DateTime dateStart, DateTime dateEnd) {

        var interval = intervalDays * 24 * 60;
        interval += intervalHours * 60;
        interval += intervalMinutes;

        var time = AddDays(dateStart, 0);
        var v = volumeStart;
        var o = priceStart;
            Random random = new Random();
        var h = o + (random.Next() * priceRange);
        var l = o - (random.Next() * priceRange);
        var c = l + (random.Next() * (h - l));

        var stock = new Stock[] { };
            while (time < dateEnd) {

                stock = new Stock[]{
                new Stock{
                    open = o,
                    high = h,
                    low = l,
                    close = c,
                    volume = v } };

            o = c + ((random.Next() - 0.5) * priceRange);
            if (o < 0) {
                o = Math.Abs(o) + 2;
            }
            h = o + (random.Next() * priceRange);
            l = o - (random.Next() * priceRange);
            c = l + (random.Next() * (h - l));
            v = v + ((random.Next() - 0.5) * volumeRange);
            if (v < 0) {
                v = Math.Abs(v) + 10000;
            }

            o = Math.Round(o * 100) / 100;
            h = Math.Round(h * 100) / 100;
            l = Math.Round(l * 100) / 100;
            c = Math.Round(c * 100) / 100;
            v = Math.Round(v * 100) / 100;

            time = AddMinutes(time, interval);
        }
            //setting data intent for Series Title
        //   (stock as any).__dataIntents = {
        //    close: ["SeriesTitle/Stock Prices"]
        //};

            return stock;
    }

    public DateTime AddMinutes(DateTime date, int minutes) {
        return new DateTime(date.Day + minutes * 60 * 1000);
    }

    public DateTime AddHours(DateTime date, int hours) {
        return new DateTime(date.Day + hours * 60 * 60 * 1000);
    }

    public DateTime AddDays(DateTime date, int days) {
        return new DateTime(date.Day + days * 24 * 60 * 60 * 1000);
    }

    public DateTime AddYears(DateTime date, int years) {
        return new DateTime(date.Year + years, date.Month, date.Day);
    }

    public string toShortString(double largeValue) {
        double roundValue;

        if (largeValue >= 1000000) {
            roundValue = Math.Round(largeValue / 100000) / 10;
            return roundValue + "M";
        }
        if (largeValue >= 1000) {
            roundValue = Math.Round(largeValue / 100) / 10;
            return roundValue + "K";
        }

        roundValue = Math.Round(largeValue);
        return roundValue + "";
    }

    public DateTime GetYear(DateTime date) {
        return new DateTime(date.Year);
    }

    public Double GetQuarter(DateTime date) {
        var month = date.Month;
        Double d = (month + 2) / 3;
            return Math.Round(d);
    }

    public Stock GetLastItem(Stock[] array) {
        if (array.Length == 0) {
            return null;
        }
            return array[array.Length - 1];
    }

    public Stock[] GetNewItem(Stock[] array, int interval)
    {
        var lastItem = GetLastItem(array);

        if (interval == null)
        {
            interval = intervalDays * 24 * 60;
            interval += intervalHours * 60;
            interval += intervalMinutes;
        }

        var time = AddMinutes(lastItem.time.Date, interval);
        var v = lastItem.volume;
        var o = lastItem.open;
        var h = lastItem.high;
        var l = lastItem.low;
        var c = lastItem.close;

        Random random = new Random();

        o = c + ((random.Next() - 0.5) * priceRange);
        if (o < 0)
        {
            o = Math.Abs(o) + 2;
        }
        h = o + (random.Next() * priceRange);
        l = o - (random.Next() * priceRange);
        c = l + (random.Next() * (h - l));
        v = v + ((random.Next() - 0.5) * volumeRange);
        if (v < 0)
        {
            v = Math.Abs(v) + 10000;
        }

        var newValue = new Stock[] { new Stock { time = time, open = o, high = h, low = l, close = c, volume = v } };

        return newValue;
    }
    }

class Stock
    {
        public DateTime time;
        public double volume;
        public double open;
        public double high;
        public double low;
        public double close;
        public string info;
        public double value;
        public int index;
    }

}
