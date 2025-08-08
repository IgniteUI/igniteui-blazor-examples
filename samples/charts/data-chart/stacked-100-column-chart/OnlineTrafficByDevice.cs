using System;
using System.Collections.Generic;
public class OnlineTrafficByDeviceItem
{
    public string Category { get; set; }
    public double Desktop { get; set; }
    public double Mobile { get; set; }
    public double Tablet { get; set; }
}

public class OnlineTrafficByDevice
    : List<OnlineTrafficByDeviceItem>
{
    public OnlineTrafficByDevice()
    {
        this.Add(new OnlineTrafficByDeviceItem() { Category = @"Apparel", Desktop = 27, Mobile = 66, Tablet = 7 });
        this.Add(new OnlineTrafficByDeviceItem() { Category = @"Beauty", Desktop = 29, Mobile = 66, Tablet = 5 });
        this.Add(new OnlineTrafficByDeviceItem() { Category = @"Travel", Desktop = 41, Mobile = 51, Tablet = 8 });
        this.Add(new OnlineTrafficByDeviceItem() { Category = @"Grocery", Desktop = 37, Mobile = 57, Tablet = 6 });
        this.Add(new OnlineTrafficByDeviceItem() { Category = @"Energy", Desktop = 58, Mobile = 39, Tablet = 3 });
        this.Add(new OnlineTrafficByDeviceItem() { Category = @"Home Supply", Desktop = 35, Mobile = 56, Tablet = 8 });
        this.Add(new OnlineTrafficByDeviceItem() { Category = @"Financial", Desktop = 58, Mobile = 39, Tablet = 3 });
    }
}
