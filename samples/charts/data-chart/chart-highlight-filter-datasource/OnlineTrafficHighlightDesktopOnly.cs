using System;
using System.Collections.Generic;
public class OnlineTrafficHighlightDesktopOnlyItem
{
    public string Category { get; set; }
    public double Value { get; set; }
}

public class OnlineTrafficHighlightDesktopOnly
    : List<OnlineTrafficHighlightDesktopOnlyItem>
{
    public OnlineTrafficHighlightDesktopOnly()
    {
        this.Add(new OnlineTrafficHighlightDesktopOnlyItem() { Category = @"Apparel", Value = 27 });
        this.Add(new OnlineTrafficHighlightDesktopOnlyItem() { Category = @"Beauty", Value = 29 });
        this.Add(new OnlineTrafficHighlightDesktopOnlyItem() { Category = @"Travel", Value = 41 });
        this.Add(new OnlineTrafficHighlightDesktopOnlyItem() { Category = @"Grocery", Value = 37 });
        this.Add(new OnlineTrafficHighlightDesktopOnlyItem() { Category = @"Energy", Value = 58 });
        this.Add(new OnlineTrafficHighlightDesktopOnlyItem() { Category = @"Home Supply", Value = 35 });
        this.Add(new OnlineTrafficHighlightDesktopOnlyItem() { Category = @"Financial", Value = 58 });
    }
}
