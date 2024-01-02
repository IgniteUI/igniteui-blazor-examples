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
            Value = 100
        });
        this.Add(new OnlineTrafficHighlightTotalsItem()
        {
            Category = @"Beauty",
            Value = 100
        });
        this.Add(new OnlineTrafficHighlightTotalsItem()
        {
            Category = @"Travel",
            Value = 100
        });
        this.Add(new OnlineTrafficHighlightTotalsItem()
        {
            Category = @"Grocery",
            Value = 100
        });
        this.Add(new OnlineTrafficHighlightTotalsItem()
        {
            Category = @"Energy",
            Value = 100
        });
        this.Add(new OnlineTrafficHighlightTotalsItem()
        {
            Category = @"Home Supply",
            Value = 100
        });
        this.Add(new OnlineTrafficHighlightTotalsItem()
        {
            Category = @"Financial",
            Value = 100
        });
    }
}
