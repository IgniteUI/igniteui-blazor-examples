using System;
using System.Collections.Generic;
public class SingersExportDataItem
{
    public double ID { get; set; }
    public string Artist { get; set; }
    public double Debut { get; set; }
    public double GrammyNominations { get; set; }
    public double GrammyAwards { get; set; }
    public bool HasGrammyAward { get; set; }
    public List<SingersExportDataItem_ToursItem> Tours { get; set; }
    public List<SingersExportDataItem_AlbumsItem> Albums { get; set; }
}
public class SingersExportDataItem_ToursItem
{
    public string Tour { get; set; }
    public string StartedOn { get; set; }
    public string Location { get; set; }
    public string Headliner { get; set; }
    public string TouredBy { get; set; }
    public List<SingersExportDataItem_ToursItem_TourDataItem> TourData { get; set; }
}
public class SingersExportDataItem_ToursItem_TourDataItem
{
    public string Country { get; set; }
    public double TicketsSold { get; set; }
    public double Attendants { get; set; }
}
public class SingersExportDataItem_AlbumsItem
{
    public string Album { get; set; }
    public string LaunchDate { get; set; }
    public double BillboardReview { get; set; }
    public double USBillboard200 { get; set; }
    public string Artist { get; set; }
    public List<SingersExportDataItem_AlbumsItem_SongsItem> Songs { get; set; }
}
public class SingersExportDataItem_AlbumsItem_SongsItem
{
    public double Number { get; set; }
    public string Title { get; set; }
    public string Released { get; set; }
    public string Genre { get; set; }
    public string Album { get; set; }
}

public class SingersExportData
    : List<SingersExportDataItem>
{
    public SingersExportData()
    {
        this.Add(new SingersExportDataItem()
        {
            ID = 0,
            Artist = @"Naomí Yepes",
            Debut = 2011,
            GrammyNominations = 6,
            GrammyAwards = 0,
            HasGrammyAward = false,
            Tours = new List<SingersExportDataItem_ToursItem>()
            {
                new SingersExportDataItem_ToursItem()
                {
                    Tour = @"Faithful Tour",
                    StartedOn = @"Sep 12",
                    Location = @"Worldwide",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes",
                    TourData = new List<SingersExportDataItem_ToursItem_TourDataItem>()
                    {
                        new SingersExportDataItem_ToursItem_TourDataItem()
                        {
                            Country = @"Belgium",
                            TicketsSold = 10000,
                            Attendants = 10000
                        },
                        new SingersExportDataItem_ToursItem_TourDataItem()
                        {
                            Country = @"USA",
                            TicketsSold = 192300,
                            Attendants = 186523
                        }}

                },
                new SingersExportDataItem_ToursItem()
                {
                    Tour = @"Faithful Tour",
                    StartedOn = @"Sep 12",
                    Location = @"Worldwide",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersExportDataItem_ToursItem()
                {
                    Tour = @"Faithful Tour",
                    StartedOn = @"Sep 12",
                    Location = @"Worldwide",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersExportDataItem_ToursItem()
                {
                    Tour = @"Faithful Tour",
                    StartedOn = @"Sep 12",
                    Location = @"Worldwide",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                }}
            ,
            Albums = new List<SingersExportDataItem_AlbumsItem>()
            {
                new SingersExportDataItem_AlbumsItem()
                {
                    Album = @"Pushing up daisies",
                    LaunchDate = @"2020-05-31T00:00:00.000Z",
                    BillboardReview = 86,
                    USBillboard200 = 42,
                    Artist = @"Naomí Yepes",
                    Songs = new List<SingersExportDataItem_AlbumsItem_SongsItem>()
                    {
                        new SingersExportDataItem_AlbumsItem_SongsItem()
                        {
                            Number = 1,
                            Title = @"Wood Shavings Forever",
                            Released = @"2019-06-09T00:00:00.000Z",
                            Genre = @"Punk",
                            Album = @"Pushing up daisies"
                        },
                        new SingersExportDataItem_AlbumsItem_SongsItem()
                        {
                            Number = 2,
                            Title = @"Forever",
                            Released = @"2019-12-23T00:00:00.000Z",
                            Genre = @"Punk",
                            Album = @"Pushing up daisies"
                        },
                        new SingersExportDataItem_AlbumsItem_SongsItem()
                        {
                            Number = 3,
                            Title = @"Forever - Remix",
                            Released = @"2019-06-07T00:00:00.000Z",
                            Genre = @"Punk",
                            Album = @"Pushing up daisies"
                        },
                        new SingersExportDataItem_AlbumsItem_SongsItem()
                        {
                            Number = 4,
                            Title = @"Pushing up daisies",
                            Released = @"2019-03-19T00:00:00.000Z",
                            Genre = @"Punk",
                            Album = @"Pushing up daisies"
                        }}

                },
                new SingersExportDataItem_AlbumsItem()
                {
                    Album = @"Pushing up daisies - Deluxe",
                    LaunchDate = @"2001-05-31T00:00:00.000Z",
                    BillboardReview = 12,
                    USBillboard200 = 2,
                    Artist = @"Naomí Yepes",
                    Songs = new List<SingersExportDataItem_AlbumsItem_SongsItem>()
                    {
                        new SingersExportDataItem_AlbumsItem_SongsItem()
                        {
                            Number = 1,
                            Title = @"Wood Shavings Forever - Remix",
                            Released = @"2020-06-09T00:00:00.000Z",
                            Genre = @"Punk",
                            Album = @"Pushing up daisies"
                        }}

                },
                new SingersExportDataItem_AlbumsItem()
                {
                    Album = @"Utopia",
                    LaunchDate = @"2021-12-19T00:00:00.000Z",
                    BillboardReview = 1,
                    USBillboard200 = 1,
                    Artist = @"Naomí Yepes",
                    Songs = new List<SingersExportDataItem_AlbumsItem_SongsItem>()
                    {
                        new SingersExportDataItem_AlbumsItem_SongsItem()
                        {
                            Number = 1,
                            Title = @"SANTORINI",
                            Released = @"2021-12-19T00:00:00.000Z",
                            Genre = @"Hip-Hop",
                            Album = @"Utopia"
                        },
                        new SingersExportDataItem_AlbumsItem_SongsItem()
                        {
                            Number = 2,
                            Title = @"HEARTBEAT",
                            Released = @"2021-12-19T00:00:00.000Z",
                            Genre = @"Hip-Hop",
                            Album = @"Utopia"
                        },
                        new SingersExportDataItem_AlbumsItem_SongsItem()
                        {
                            Number = 3,
                            Title = @"OVERSEAS",
                            Released = @"2021-12-19T00:00:00.000Z",
                            Genre = @"Hip-Hop",
                            Album = @"Utopia"
                        }}

                },
                new SingersExportDataItem_AlbumsItem()
                {
                    Album = @"Wish You Were Here",
                    LaunchDate = @"2020-07-17T00:00:00.000Z",
                    BillboardReview = 5,
                    USBillboard200 = 3,
                    Artist = @"Naomí Yepes",
                    Songs = new List<SingersExportDataItem_AlbumsItem_SongsItem>()
                    {
                        new SingersExportDataItem_AlbumsItem_SongsItem()
                        {
                            Number = 1,
                            Title = @"Zoom",
                            Released = @"2020-07-17T00:00:00.000Z",
                            Genre = @"Hip-Hop",
                            Album = @"Wish You Were Here"
                        },
                        new SingersExportDataItem_AlbumsItem_SongsItem()
                        {
                            Number = 2,
                            Title = @"Do You?",
                            Released = @"2020-07-17T00:00:00.000Z",
                            Genre = @"Hip-Hop",
                            Album = @"Wish You Were Here"
                        },
                        new SingersExportDataItem_AlbumsItem_SongsItem()
                        {
                            Number = 3,
                            Title = @"No Photos",
                            Released = @"2020-07-17T00:00:00.000Z",
                            Genre = @"Hip-Hop",
                            Album = @"Wish You Were Here"
                        }}

                }}

        });
        this.Add(new SingersExportDataItem()
        {
            ID = 1,
            Artist = @"Babila Ebwélé",
            Debut = 2009,
            GrammyNominations = 0,
            GrammyAwards = 11,
            HasGrammyAward = true,
            Tours = new List<SingersExportDataItem_ToursItem>()
            {
                new SingersExportDataItem_ToursItem()
                {
                    Tour = @"Astroworld",
                    StartedOn = @"Jul 21",
                    Location = @"Worldwide",
                    Headliner = @"NO",
                    TouredBy = @"Babila Ebwélé",
                    TourData = new List<SingersExportDataItem_ToursItem_TourDataItem>()
                    {
                        new SingersExportDataItem_ToursItem_TourDataItem()
                        {
                            Country = @"Bulgaria",
                            TicketsSold = 25000,
                            Attendants = 19822
                        },
                        new SingersExportDataItem_ToursItem_TourDataItem()
                        {
                            Country = @"Romania",
                            TicketsSold = 65021,
                            Attendants = 63320
                        }}

                }}
            ,
            Albums = new List<SingersExportDataItem_AlbumsItem>()
            {
                new SingersExportDataItem_AlbumsItem()
                {
                    Album = @"Fahrenheit",
                    LaunchDate = @"2000-05-31T00:00:00.000Z",
                    BillboardReview = 86,
                    USBillboard200 = 42,
                    Artist = @"Babila Ebwélé",
                    Songs = new List<SingersExportDataItem_AlbumsItem_SongsItem>()
                    {
                        new SingersExportDataItem_AlbumsItem_SongsItem()
                        {
                            Number = 1,
                            Title = @"Show Out",
                            Released = @"2020-07-17T00:00:00.000Z",
                            Genre = @"Hip-Hop",
                            Album = @"Fahrenheit"
                        },
                        new SingersExportDataItem_AlbumsItem_SongsItem()
                        {
                            Number = 2,
                            Title = @"Mood Swings",
                            Released = @"2020-07-17T00:00:00.000Z",
                            Genre = @"Hip-Hop",
                            Album = @"Fahrenheit"
                        },
                        new SingersExportDataItem_AlbumsItem_SongsItem()
                        {
                            Number = 3,
                            Title = @"Scenario",
                            Released = @"2020-07-17T00:00:00.000Z",
                            Genre = @"Hip-Hop",
                            Album = @"Fahrenheit"
                        }}

                }}

        });
        this.Add(new SingersExportDataItem()
        {
            ID = 3,
            Artist = @"Chloe",
            Debut = 2015,
            GrammyNominations = 3,
            GrammyAwards = 1,
            HasGrammyAward = true
        });
    }
}
