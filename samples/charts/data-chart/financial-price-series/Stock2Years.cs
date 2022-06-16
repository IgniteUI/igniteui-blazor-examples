using System;
using System.Collections.Generic;
public class Stock2YearsItem
{
    public string Month{ get; set; }
    public double Open{ get; set; }
    public double High{ get; set; }
    public double Low{ get; set; }
    public double Close{ get; set; }
    public double Volume{ get; set; }
}
public class Stock2Years
    : List<Stock2YearsItem>
{
    public Stock2Years()
    {
        this.Add(new Stock2YearsItem()
        {
            Month = @"2020",
            Open = 41.1,
            High = 41.6,
            Low = 41.1,
            Close = 41.4,
            Volume = 32610
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"FEB",
            Open = 41.4,
            High = 41.7,
            Low = 41.2,
            Close = 41.4,
            Volume = 28666
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"MAR",
            Open = 41.3,
            High = 41.3,
            Low = 40.7,
            Close = 41,
            Volume = 30139
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"APR",
            Open = 41.3,
            High = 41.4,
            Low = 39.6,
            Close = 39.9,
            Volume = 51409
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"MAY",
            Open = 40,
            High = 40.3,
            Low = 39.7,
            Close = 39.8,
            Volume = 37559
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"JUN",
            Open = 39.8,
            High = 39.9,
            Low = 39.2,
            Close = 39.8,
            Volume = 35919
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"JUL",
            Open = 39.9,
            High = 40.5,
            Low = 39.9,
            Close = 40.5,
            Volume = 27398
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"AUG",
            Open = 40.4,
            High = 40.7,
            Low = 39.1,
            Close = 39.4,
            Volume = 45960
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"SEP",
            Open = 39,
            High = 39.8,
            Low = 39,
            Close = 39.2,
            Volume = 34333
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"OCT",
            Open = 39.1,
            High = 39.4,
            Low = 38.9,
            Close = 39.2,
            Volume = 32006
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"NOV",
            Open = 39.3,
            High = 40,
            Low = 39,
            Close = 39.8,
            Volume = 33978
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"DEC",
            Open = 40.1,
            High = 40.4,
            Low = 39.9,
            Close = 40.4,
            Volume = 30616
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"2021",
            Open = 40,
            High = 40.2,
            Low = 39.5,
            Close = 40,
            Volume = 36689
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"FEB",
            Open = 40.1,
            High = 40.1,
            Low = 39.8,
            Close = 39.9,
            Volume = 22222
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"MAR",
            Open = 40,
            High = 40.1,
            Low = 39.8,
            Close = 40,
            Volume = 27057
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"APR",
            Open = 40,
            High = 40,
            Low = 39.5,
            Close = 39.7,
            Volume = 24602
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"MAY",
            Open = 39.7,
            High = 40,
            Low = 39.3,
            Close = 39.9,
            Volume = 42381
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"JUN",
            Open = 40.3,
            High = 40.7,
            Low = 39.8,
            Close = 39.9,
            Volume = 56883
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"JUL",
            Open = 40.1,
            High = 41.3,
            Low = 40.1,
            Close = 40.9,
            Volume = 50610
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"AUG",
            Open = 41.1,
            High = 41.2,
            Low = 40.4,
            Close = 40.5,
            Volume = 29637
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"SEP",
            Open = 39,
            High = 39.8,
            Low = 39,
            Close = 39.2,
            Volume = 34333
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"OCT",
            Open = 39.1,
            High = 39.4,
            Low = 38.9,
            Close = 39.2,
            Volume = 32006
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"NOV",
            Open = 39.3,
            High = 40,
            Low = 39,
            Close = 39.8,
            Volume = 33978
        });
        this.Add(new Stock2YearsItem()
        {
            Month = @"DEC",
            Open = 40.1,
            High = 40.4,
            Low = 39.9,
            Close = 40.4,
            Volume = 30616
        });
    }
}
