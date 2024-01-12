using System;
using System.Collections.Generic;
public class OnlineTrafficHighlightTotalsItem
{
    public string Category { get; set; }
    public double Value { get; set; }
}

public class OnlineTrafficHighlightTotals
    : List<OnlineTrafficHighlightTotalsItem>
{
    public OnlineTrafficHighlightTotals()
    {
        this.Add(new OnlineTrafficHighlightTotalsItem()
        {
            Category = @"Apparel",
            Value = 56
        });
        this.Add(new OnlineTrafficHighlightTotalsItem()
        {
            Category = @"Beauty",
            Value = 67
        });
        this.Add(new OnlineTrafficHighlightTotalsItem()
        {
            Category = @"Travel",
            Value = 80
        });
        this.Add(new OnlineTrafficHighlightTotalsItem()
        {
            Category = @"Grocery",
            Value = 62
        });
        this.Add(new OnlineTrafficHighlightTotalsItem()
        {
            Category = @"Energy",
            Value = 74
        });
        this.Add(new OnlineTrafficHighlightTotalsItem()
        {
            Category = @"Home Supply",
            Value = 65
        });
        this.Add(new OnlineTrafficHighlightTotalsItem()
        {
            Category = @"Financial",
            Value = 88
        });
    }
}
