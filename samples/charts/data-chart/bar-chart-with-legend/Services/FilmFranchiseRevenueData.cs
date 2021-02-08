using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class FilmFranchiseRevenueInfo
    {
        public string Franchise { get; set; }
        public double TotalWorldBoxOfficeRevenue { get; set; }
        public double HighestGrossingMovieInSeries { get; set; }
    }

    public class FilmFranchiseRevenueData : List<FilmFranchiseRevenueInfo>
    {
        public FilmFranchiseRevenueData()
        {
            Add(new FilmFranchiseRevenueInfo() { Franchise = "Marvel Universe All Films", TotalWorldBoxOfficeRevenue = 22.55, HighestGrossingMovieInSeries = 2.8 });
            Add(new FilmFranchiseRevenueInfo() { Franchise = "Star Wars",                 TotalWorldBoxOfficeRevenue = 10.32, HighestGrossingMovieInSeries = 2.07 });
            Add(new FilmFranchiseRevenueInfo() { Franchise = "Harry Potter",              TotalWorldBoxOfficeRevenue = 9.19,  HighestGrossingMovieInSeries = 1.34 });
            Add(new FilmFranchiseRevenueInfo() { Franchise = "Avengers",                  TotalWorldBoxOfficeRevenue = 7.76,  HighestGrossingMovieInSeries = 2.8 });
            Add(new FilmFranchiseRevenueInfo() { Franchise = "Spider Man",                TotalWorldBoxOfficeRevenue = 7.22,  HighestGrossingMovieInSeries = 1.28 });
            Add(new FilmFranchiseRevenueInfo() { Franchise = "James Bond",                TotalWorldBoxOfficeRevenue = 7.12,  HighestGrossingMovieInSeries = 1.11 });
        }
    }
}
