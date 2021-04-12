using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class FilmFranchiseInfo
    {
        public string Franchise { get; set; }
        public double TotalRevenue { get; set; }
        public double HighestGrossing { get; set; }
    }

    public class FilmFranchiseData : List<FilmFranchiseInfo>
    {
        public FilmFranchiseData()
        {
            Add(new FilmFranchiseInfo { Franchise = "Marvel Universe", TotalRevenue = 22.55, HighestGrossing = 2.8 });
            Add(new FilmFranchiseInfo { Franchise = "Star Wars",       TotalRevenue = 10.32, HighestGrossing = 2.07 });
            Add(new FilmFranchiseInfo { Franchise = "Harry Potter",    TotalRevenue = 9.19,  HighestGrossing = 1.34 });
            Add(new FilmFranchiseInfo { Franchise = "Avengers",        TotalRevenue = 7.76,  HighestGrossing = 2.8 });
            Add(new FilmFranchiseInfo { Franchise = "Spider Man",      TotalRevenue = 7.22,  HighestGrossing = 1.28 });
            Add(new FilmFranchiseInfo { Franchise = "James Bond",      TotalRevenue = 7.12,  HighestGrossing = 1.11 });
        }
    }
}
