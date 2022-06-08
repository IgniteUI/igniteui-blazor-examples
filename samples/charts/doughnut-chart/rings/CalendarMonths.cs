using System;
using System.Collections.Generic;
public class CalendarMonthsItem
{
    public double Value{ get; set; }
    public string Label{ get; set; }
}
public class CalendarMonths
    : List<CalendarMonthsItem>
{
    public CalendarMonths()
    {
        this.Add(new CalendarMonthsItem()
        {
            Value = 1,
            Label = @"December"
        });
        this.Add(new CalendarMonthsItem()
        {
            Value = 1,
            Label = @"January"
        });
        this.Add(new CalendarMonthsItem()
        {
            Value = 1,
            Label = @"February"
        });
        this.Add(new CalendarMonthsItem()
        {
            Value = 1,
            Label = @"March"
        });
        this.Add(new CalendarMonthsItem()
        {
            Value = 1,
            Label = @"April"
        });
        this.Add(new CalendarMonthsItem()
        {
            Value = 1,
            Label = @"May"
        });
        this.Add(new CalendarMonthsItem()
        {
            Value = 1,
            Label = @"June"
        });
        this.Add(new CalendarMonthsItem()
        {
            Value = 1,
            Label = @"July"
        });
        this.Add(new CalendarMonthsItem()
        {
            Value = 1,
            Label = @"August"
        });
        this.Add(new CalendarMonthsItem()
        {
            Value = 1,
            Label = @"September"
        });
        this.Add(new CalendarMonthsItem()
        {
            Value = 1,
            Label = @"October"
        });
        this.Add(new CalendarMonthsItem()
        {
            Value = 1,
            Label = @"November"
        });
    }
}
