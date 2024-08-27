using System;
using System.Collections.Generic;
public class FootballPlayerStatsItem
{
    public string Attribute { get; set; }
    public double Ronaldo { get; set; }
    public double Messi { get; set; }
}

public class FootballPlayerStats
    : List<FootballPlayerStatsItem>
{
    public FootballPlayerStats()
    {
        this.Add(new FootballPlayerStatsItem()
        {
            Attribute = @"Dribbling",
            Ronaldo = 8,
            Messi = 10
        });
        this.Add(new FootballPlayerStatsItem()
        {
            Attribute = @"Passing",
            Ronaldo = 8,
            Messi = 10
        });
        this.Add(new FootballPlayerStatsItem()
        {
            Attribute = @"Finishing",
            Ronaldo = 10,
            Messi = 10
        });
        this.Add(new FootballPlayerStatsItem()
        {
            Attribute = @"Free Kicks",
            Ronaldo = 8,
            Messi = 9
        });
        this.Add(new FootballPlayerStatsItem()
        {
            Attribute = @"Penalties",
            Ronaldo = 9,
            Messi = 7
        });
        this.Add(new FootballPlayerStatsItem()
        {
            Attribute = @"Physical",
            Ronaldo = 10,
            Messi = 7
        });
        this.Add(new FootballPlayerStatsItem()
        {
            Attribute = @"Team Play",
            Ronaldo = 7,
            Messi = 9
        });
        this.Add(new FootballPlayerStatsItem()
        {
            Attribute = @"Heading",
            Ronaldo = 9,
            Messi = 6
        });
    }
}
