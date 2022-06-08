using System;
using System.Collections.Generic;
public class HighestGrossingMoviesItem
{
    public string Franchise{ get; set; }
    public double TotalRevenue{ get; set; }
    public double HighestGrossing{ get; set; }
}
public class HighestGrossingMovies
    : List<HighestGrossingMoviesItem>
{
    public HighestGrossingMovies()
    {
        this.Add(new HighestGrossingMoviesItem()
        {
            Franchise = @"Marvel Universe",
            TotalRevenue = 22.55,
            HighestGrossing = 2.8
        });
        this.Add(new HighestGrossingMoviesItem()
        {
            Franchise = @"Star Wars",
            TotalRevenue = 10.32,
            HighestGrossing = 2.07
        });
        this.Add(new HighestGrossingMoviesItem()
        {
            Franchise = @"Harry Potter",
            TotalRevenue = 9.19,
            HighestGrossing = 1.34
        });
        this.Add(new HighestGrossingMoviesItem()
        {
            Franchise = @"Avengers",
            TotalRevenue = 7.76,
            HighestGrossing = 2.8
        });
        this.Add(new HighestGrossingMoviesItem()
        {
            Franchise = @"Spider Man",
            TotalRevenue = 7.22,
            HighestGrossing = 1.28
        });
        this.Add(new HighestGrossingMoviesItem()
        {
            Franchise = @"James Bond",
            TotalRevenue = 7.12,
            HighestGrossing = 1.11
        });
    }
}
