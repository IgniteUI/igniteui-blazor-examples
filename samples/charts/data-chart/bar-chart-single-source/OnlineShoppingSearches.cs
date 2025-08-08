using System;
using System.Collections.Generic;
public class OnlineShoppingSearchesItem
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Label { get; set; }
    public double Percent { get; set; }
    public string Shop { get; set; }
}

public class OnlineShoppingSearches
    : List<OnlineShoppingSearchesItem>
{
    public OnlineShoppingSearches()
    {
        this.Add(new OnlineShoppingSearchesItem() { X = 63, Y = 0, Label = @"63%", Percent = 63, Shop = @"Amazon" });
        this.Add(new OnlineShoppingSearchesItem() { X = 48, Y = 1, Label = @"48%", Percent = 48, Shop = @"Search Engines" });
        this.Add(new OnlineShoppingSearchesItem() { X = 33, Y = 2, Label = @"33%", Percent = 33, Shop = @"Retailer Sites" });
        this.Add(new OnlineShoppingSearchesItem() { X = 25, Y = 3, Label = @"25%", Percent = 25, Shop = @"Marketplaces" });
        this.Add(new OnlineShoppingSearchesItem() { X = 21, Y = 4, Label = @"21%", Percent = 21, Shop = @"Brand Website" });
        this.Add(new OnlineShoppingSearchesItem() { X = 10, Y = 5, Label = @"10%", Percent = 10, Shop = @"Comparison Sites" });
        this.Add(new OnlineShoppingSearchesItem() { X = 8, Y = 6, Label = @"8%", Percent = 8, Shop = @"Social Media" });
        this.Add(new OnlineShoppingSearchesItem() { X = 2, Y = 7, Label = @"2%", Percent = 2, Shop = @"Other" });
    }
}
