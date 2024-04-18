using System;
using System.Collections.Generic;

public class SingersNestedItem
{
    public double ID { get; set; }
    public string Artist { get; set; }
    public string Photo { get; set; }
    public double Debut { get; set; }
    public double GrammyNominations { get; set; }
    public double GrammyAwards { get; set; }
    public bool HasGrammyAward { get; set; }
    public List<SingersNestedItem_TourInfo> Tours { get; set; }
    public List<SingersNestedItem_AlbumInfo> Albums { get; set; }
}

public class SingersNestedItem_TourInfo
{
    public string Tour { get; set; }
    public string StartedOn { get; set; }
    public string Location { get; set; }
    public string Headliner { get; set; }
    public string TouredBy { get; set; }
}

public class SingersNestedItem_AlbumInfo
{
    public string Album { get; set; }
    public string LaunchDate { get; set; }
    public double BillboardReview { get; set; }
    public double USBillboard200 { get; set; }
    public string Artist { get; set; }
    public List<SingersNestedItem_SongInfo> Songs { get; set; }
}

public class SingersNestedItem_SongInfo
{
    public double Number { get; set; }
    public string Title { get; set; }
    public string Released { get; set; }
    public string Genre { get; set; }
    public string Album { get; set; }
}

public class SingersNestedData : List<SingersNestedItem>
{
    public SingersNestedData()
    {
        this.Add(new SingersNestedItem
        {
            ID = 0,
            Artist = @"Naomí Yepes",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/naomi.jpg",
            Debut = 2011,
            GrammyNominations = 6,
            GrammyAwards = 0,
            HasGrammyAward = false,
            Tours = new List<SingersNestedItem_TourInfo>()
            {
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Faithful Tour",
                    StartedOn = @"Sep 12",
                    Location = @"Worldwide",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"City Jam Sessions",
                    StartedOn = @"Aug 13",
                    Location = @"North America",
                    Headliner = @"YES",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Christmas NYC 2013",
                    StartedOn = @"Dec 13",
                    Location = @"United States",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Christmas NYC 2014",
                    StartedOn = @"Dec 14",
                    Location = @"North America",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Watermelon Tour",
                    StartedOn = @"Feb 15",
                    Location = @"Worldwide",
                    Headliner = @"YES",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Christmas NYC 2016",
                    StartedOn = @"Dec 16",
                    Location = @"United States",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"The Dragon Tour",
                    StartedOn = @"Feb 17",
                    Location = @"Worldwide",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Organic Sessions",
                    StartedOn = @"Aug 18",
                    Location = @"United States, England",
                    Headliner = @"YES",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Hope World Tour",
                    StartedOn = @"Mar 19",
                    Location = @"Worldwide",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                }}
            ,
            Albums = new List<SingersNestedItem_AlbumInfo>()
            {
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Initiation",
                    LaunchDate = @"September 3, 2013",
                    BillboardReview = 86,
                    USBillboard200 = 1,
                    Artist = @"Naomí Yepes",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                },
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Dream Driven",
                    LaunchDate = @"August 25, 2014",
                    BillboardReview = 81,
                    USBillboard200 = 1,
                    Artist = @"Naomí Yepes",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                        new SingersNestedItem_SongInfo
                        {
                            Number = 1,
                            Title = @"Intro",
                            Released = @"29 Apr 2021",
                            Genre = @"*",
                            Album = @"Dream Driven"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 2,
                            Title = @"Ferocious",
                            Released = @"28 Apr 2014",
                            Genre = @"Dance-pop R&B",
                            Album = @"Dream Driven"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 3,
                            Title = @"Going crazy",
                            Released = @"10 Feb 2015",
                            Genre = @"Dance-pop EDM",
                            Album = @"Dream Driven"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 4,
                            Title = @"Future past",
                            Released = @"14 Jul 2021",
                            Genre = @"*",
                            Album = @"Dream Driven"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 5,
                            Title = @"Roaming like them",
                            Released = @"2 Jul 2014",
                            Genre = @"Electro house Electropop",
                            Album = @"Dream Driven"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 6,
                            Title = @"Last Wishes",
                            Released = @"12 Aug 2014",
                            Genre = @"R&B",
                            Album = @"Dream Driven"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 7,
                            Title = @"Stay where you are",
                            Released = @"14 Aug 1998",
                            Genre = @"*",
                            Album = @"Dream Driven"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 8,
                            Title = @"Imaginarium",
                            Released = @"15 Sep 2013",
                            Genre = @"*",
                            Album = @"Dream Driven"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 9,
                            Title = @"Tell me",
                            Released = @"30 Sep 2014",
                            Genre = @"Synth-pop R&B",
                            Album = @"Dream Driven"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 10,
                            Title = @"Shredded into pieces",
                            Released = @"2 Sep 2011",
                            Genre = @"*",
                            Album = @"Dream Driven"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 11,
                            Title = @"Capture this moment",
                            Released = @"5 Jan 2011",
                            Genre = @"*",
                            Album = @"Dream Driven"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 12,
                            Title = @"Dream Driven",
                            Released = @"12 Dec 1999",
                            Genre = @"*",
                            Album = @"Dream Driven"
                        }}

                },
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"The dragon journey",
                    LaunchDate = @"May 20, 2016",
                    BillboardReview = 60,
                    USBillboard200 = 2,
                    Artist = @"Naomí Yepes",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                },
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Organic me",
                    LaunchDate = @"August 17, 2018",
                    BillboardReview = 82,
                    USBillboard200 = 1,
                    Artist = @"Naomí Yepes",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                        new SingersNestedItem_SongInfo
                        {
                            Number = 1,
                            Title = @"I Love",
                            Released = @"11 May 2019",
                            Genre = @"Crunk reggaeton",
                            Album = @"Organic me"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 2,
                            Title = @"Early Morning Compass",
                            Released = @"15 Jan 2020",
                            Genre = @"mystical parody-bap ",
                            Album = @"Organic me"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 3,
                            Title = @"Key Fields Forever",
                            Released = @"2 Jan 2020",
                            Genre = @"Dance-pop EDM",
                            Album = @"Organic me"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 4,
                            Title = @"Stand by Your Goblins",
                            Released = @"20 Nov 2019",
                            Genre = @"*",
                            Album = @"Organic me"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 5,
                            Title = @"Mad to Walk",
                            Released = @"12 May 2019",
                            Genre = @"Electro house Electropop",
                            Album = @"Organic me"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 6,
                            Title = @"Alice's Waiting",
                            Released = @"28 Jan 2020",
                            Genre = @"R&B",
                            Album = @"Organic me"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 7,
                            Title = @"We Shall Kiss",
                            Released = @"30 Oct 2019",
                            Genre = @"*",
                            Album = @"Organic me"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 8,
                            Title = @"Behind Single Ants",
                            Released = @"2 Oct 2019",
                            Genre = @"*",
                            Album = @"Organic me"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 9,
                            Title = @"Soap Autopsy",
                            Released = @"8 Aug 2019",
                            Genre = @"Synth-pop R&B",
                            Album = @"Organic me"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 10,
                            Title = @"Have You Met Rich?",
                            Released = @"1 Jul 2019",
                            Genre = @"ethno-tunes",
                            Album = @"Organic me"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 11,
                            Title = @"Livin' on a Banana",
                            Released = @"22 Nov 2019",
                            Genre = @"Crunk reggaeton",
                            Album = @"Organic me"
                        }}

                },
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Curiosity",
                    LaunchDate = @"December 7, 2019",
                    BillboardReview = 75,
                    USBillboard200 = 12,
                    Artist = @"Naomí Yepes",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                }}

        });
        this.Add(new SingersNestedItem
        {
            ID = 1,
            Artist = @"Babila Ebwélé",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/babila.jpg",
            Debut = 2009,
            GrammyNominations = 0,
            GrammyAwards = 11,
            HasGrammyAward = true,
            Tours = new List<SingersNestedItem_TourInfo>()
            {
                new SingersNestedItem_TourInfo
                {
                    Tour = @"The last straw",
                    StartedOn = @"May 09",
                    Location = @"Europe, Asia",
                    Headliner = @"NO",
                    TouredBy = @"Babila Ebwélé"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"No foundations",
                    StartedOn = @"Jun 04",
                    Location = @"United States, Europe",
                    Headliner = @"YES",
                    TouredBy = @"Babila Ebwélé"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Crazy eyes",
                    StartedOn = @"Jun 08",
                    Location = @"North America",
                    Headliner = @"NO",
                    TouredBy = @"Babila Ebwélé"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Zero gravity",
                    StartedOn = @"Apr 19",
                    Location = @"United States",
                    Headliner = @"NO",
                    TouredBy = @"Babila Ebwélé"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Battle with myself",
                    StartedOn = @"Mar 08",
                    Location = @"North America",
                    Headliner = @"YES",
                    TouredBy = @"Babila Ebwélé"
                }}
            ,
            Albums = new List<SingersNestedItem_AlbumInfo>()
            {
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Pushing up daisies",
                    LaunchDate = @"May 31, 2000",
                    BillboardReview = 86,
                    USBillboard200 = 42,
                    Artist = @"Babila Ebwélé",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                        new SingersNestedItem_SongInfo
                        {
                            Number = 1,
                            Title = @"Wood Shavings Forever",
                            Released = @"9 Jun 2019",
                            Genre = @"*",
                            Album = @"Pushing up daisies"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 2,
                            Title = @"Early Morning Drive",
                            Released = @"20 May 2019",
                            Genre = @"*",
                            Album = @"Pushing up daisies"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 3,
                            Title = @"Don't Natter",
                            Released = @"10 Jun 2019",
                            Genre = @"adult calypso-industrial",
                            Album = @"Pushing up daisies"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 4,
                            Title = @"Stairway to Balloons",
                            Released = @"18 Jun 2019",
                            Genre = @"calypso and mariachi",
                            Album = @"Pushing up daisies"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 5,
                            Title = @"The Number of your Apple",
                            Released = @"29 Oct 2019",
                            Genre = @"*",
                            Album = @"Pushing up daisies"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 6,
                            Title = @"Your Delightful Heart",
                            Released = @"24 Feb 2019",
                            Genre = @"*",
                            Album = @"Pushing up daisies"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 7,
                            Title = @"Nice Weather For Balloons",
                            Released = @"1 Aug 2019",
                            Genre = @"rap-hop",
                            Album = @"Pushing up daisies"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 8,
                            Title = @"The Girl From Cornwall",
                            Released = @"4 May 2019",
                            Genre = @"enigmatic rock-and-roll",
                            Album = @"Pushing up daisies"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 9,
                            Title = @"Here Without Jack",
                            Released = @"24 Oct 2019",
                            Genre = @"*",
                            Album = @"Pushing up daisies"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 10,
                            Title = @"Born Rancid",
                            Released = @"19 Mar 2019",
                            Genre = @"*",
                            Album = @"Pushing up daisies"
                        }}

                },
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Death's dead",
                    LaunchDate = @"June 8, 2016",
                    BillboardReview = 85,
                    USBillboard200 = 95,
                    Artist = @"Babila Ebwélé",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                        new SingersNestedItem_SongInfo
                        {
                            Number = 1,
                            Title = @"Men Sound Better With You",
                            Released = @"20 Oct 2019",
                            Genre = @"rap-hop",
                            Album = @"Death's dead"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 2,
                            Title = @"Ghost in My Rod",
                            Released = @"5 Oct 2019",
                            Genre = @"enigmatic rock-and-roll",
                            Album = @"Death's dead"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 3,
                            Title = @"Bed of Men",
                            Released = @"14 Nov 2019",
                            Genre = @"whimsical comedy-grass ",
                            Album = @"Death's dead"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 4,
                            Title = @"Don't Push",
                            Released = @"2 Jan 2020",
                            Genre = @"unblack electronic-trip-hop",
                            Album = @"Death's dead"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 5,
                            Title = @"Nice Weather For Men",
                            Released = @"18 Dec 2019",
                            Genre = @"*",
                            Album = @"Death's dead"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 6,
                            Title = @"Rancid Rhapsody",
                            Released = @"10 Mar 2019",
                            Genre = @"*",
                            Album = @"Death's dead"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 7,
                            Title = @"Push, Push, Push!",
                            Released = @"21 Feb 2019",
                            Genre = @"*",
                            Album = @"Death's dead"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 8,
                            Title = @"My Name is Sarah",
                            Released = @"15 Nov 2019",
                            Genre = @"*",
                            Album = @"Death's dead"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 9,
                            Title = @"The Girl From My Hotel",
                            Released = @"6 Nov 2019",
                            Genre = @"*",
                            Album = @"Death's dead"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 10,
                            Title = @"Free Box",
                            Released = @"18 Apr 2019",
                            Genre = @"splitter-funk",
                            Album = @"Death's dead"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 11,
                            Title = @"Hotel Cardiff",
                            Released = @"30 Dec 2019",
                            Genre = @"guilty pleasure ebm",
                            Album = @"Death's dead"
                        }}

                }}

        });
        this.Add(new SingersNestedItem
        {
            ID = 2,
            Artist = @"Ahmad Nazeri",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/ahmad.jpg",
            Debut = 2004,
            GrammyNominations = 3,
            GrammyAwards = 1,
            HasGrammyAward = true,
            Tours = new List<SingersNestedItem_TourInfo>()
            {
            }
            ,
            Albums = new List<SingersNestedItem_AlbumInfo>()
            {
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Emergency",
                    LaunchDate = @"March 6, 2004",
                    BillboardReview = 98,
                    USBillboard200 = 69,
                    Artist = @"Ahmad Nazeri",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                },
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Bursting bubbles",
                    LaunchDate = @"April 17, 2006",
                    BillboardReview = 69,
                    USBillboard200 = 39,
                    Artist = @"Ahmad Nazeri",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                }}

        });
        this.Add(new SingersNestedItem
        {
            ID = 3,
            Artist = @"Kimmy McIlmorie",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/kimmy.jpg",
            Debut = 2007,
            GrammyNominations = 21,
            GrammyAwards = 3,
            HasGrammyAward = true,
            Tours = new List<SingersNestedItem_TourInfo>()
            {
            }
            ,
            Albums = new List<SingersNestedItem_AlbumInfo>()
            {
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Here we go again",
                    LaunchDate = @"November 18, 2017",
                    BillboardReview = 68,
                    USBillboard200 = 1,
                    Artist = @"Kimmy McIlmorie",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                }}

        });
        this.Add(new SingersNestedItem
        {
            ID = 4,
            Artist = @"Mar Rueda",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/mar.jpg",
            Debut = 1996,
            GrammyNominations = 14,
            GrammyAwards = 2,
            HasGrammyAward = true,
            Tours = new List<SingersNestedItem_TourInfo>()
            {
            }
            ,
            Albums = new List<SingersNestedItem_AlbumInfo>()
            {
            }

        });
        this.Add(new SingersNestedItem
        {
            ID = 5,
            Artist = @"Izabella Tabakova",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/izabella.jpg",
            Debut = 2017,
            GrammyNominations = 7,
            GrammyAwards = 11,
            HasGrammyAward = true,
            Tours = new List<SingersNestedItem_TourInfo>()
            {
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Final breath",
                    StartedOn = @"Jun 13",
                    Location = @"Europe",
                    Headliner = @"YES",
                    TouredBy = @"Izabella Tabakova"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Once bitten",
                    StartedOn = @"Dec 18",
                    Location = @"Australia, United States",
                    Headliner = @"NO",
                    TouredBy = @"Izabella Tabakova"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Code word",
                    StartedOn = @"Sep 19",
                    Location = @"United States, Europe",
                    Headliner = @"NO",
                    TouredBy = @"Izabella Tabakova"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Final draft",
                    StartedOn = @"Sep 17",
                    Location = @"United States, Europe",
                    Headliner = @"YES",
                    TouredBy = @"Izabella Tabakova"
                }}
            ,
            Albums = new List<SingersNestedItem_AlbumInfo>()
            {
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Once bitten",
                    LaunchDate = @"July 16, 2007",
                    BillboardReview = 79,
                    USBillboard200 = 53,
                    Artist = @"Izabella Tabakova",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                        new SingersNestedItem_SongInfo
                        {
                            Number = 1,
                            Title = @"Whole Lotta Super Cats",
                            Released = @"21 May 2019",
                            Genre = @"*",
                            Album = @"Once bitten"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 2,
                            Title = @"Enter Becky",
                            Released = @"16 Jan 2020",
                            Genre = @"*",
                            Album = @"Once bitten"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 3,
                            Title = @"Your Cheatin' Flamingo",
                            Released = @"14 Jan 2020",
                            Genre = @"*",
                            Album = @"Once bitten"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 4,
                            Title = @"Mad to Kiss",
                            Released = @"6 Nov 2019",
                            Genre = @"Synth-pop R&B",
                            Album = @"Once bitten"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 5,
                            Title = @"Hotel Prague",
                            Released = @"20 Oct 2019",
                            Genre = @"ethno-tunes",
                            Album = @"Once bitten"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 6,
                            Title = @"Jail on My Mind",
                            Released = @"31 May 2019",
                            Genre = @"Crunk reggaeton",
                            Album = @"Once bitten"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 7,
                            Title = @"Amazing Blues",
                            Released = @"29 May 2019",
                            Genre = @"mystical parody-bap ",
                            Album = @"Once bitten"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 8,
                            Title = @"Goody Two Iron Filings",
                            Released = @"4 Jul 2019",
                            Genre = @"Electro house Electropop",
                            Album = @"Once bitten"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 9,
                            Title = @"I Love in Your Arms",
                            Released = @"7 Jun 2019",
                            Genre = @"R&B",
                            Album = @"Once bitten"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 10,
                            Title = @"Truly Madly Amazing",
                            Released = @"12 Sep 2019",
                            Genre = @"ethno-tunes",
                            Album = @"Once bitten"
                        }}

                },
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Your graciousness",
                    LaunchDate = @"November 17, 2004",
                    BillboardReview = 69,
                    USBillboard200 = 30,
                    Artist = @"Izabella Tabakova",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                        new SingersNestedItem_SongInfo
                        {
                            Number = 1,
                            Title = @"We Shall Tickle",
                            Released = @"31 Aug 2019",
                            Genre = @"old emo-garage ",
                            Album = @"Your graciousness"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 2,
                            Title = @"Snail Boogie",
                            Released = @"14 Jun 2019",
                            Genre = @"*",
                            Album = @"Your graciousness"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 3,
                            Title = @"Amazing Liz",
                            Released = @"15 Oct 2019",
                            Genre = @"*",
                            Album = @"Your graciousness"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 4,
                            Title = @"When Sexy Aardvarks Cry",
                            Released = @"1 Oct 2019",
                            Genre = @"whimsical comedy-grass ",
                            Album = @"Your graciousness"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 5,
                            Title = @"Stand By Dave",
                            Released = @"18 Aug 2019",
                            Genre = @"unblack electronic-trip-hop",
                            Album = @"Your graciousness"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 6,
                            Title = @"The Golf Course is Your Land",
                            Released = @"2 Apr 2019",
                            Genre = @"*",
                            Album = @"Your graciousness"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 7,
                            Title = @"Where Have All the Men Gone?",
                            Released = @"29 Apr 2019",
                            Genre = @"*",
                            Album = @"Your graciousness"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 8,
                            Title = @"Rhythm of the Leg",
                            Released = @"5 Aug 2019",
                            Genre = @"ethno-tunes",
                            Album = @"Your graciousness"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 9,
                            Title = @"Baby, I Need Your Hats",
                            Released = @"5 Dec 2019",
                            Genre = @"neuro-tunes",
                            Album = @"Your graciousness"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 10,
                            Title = @"Stand by Your Cat",
                            Released = @"25 Jul 2019",
                            Genre = @"*",
                            Album = @"Your graciousness"
                        }}

                },
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Dark matters",
                    LaunchDate = @"November 3, 2002",
                    BillboardReview = 79,
                    USBillboard200 = 85,
                    Artist = @"Izabella Tabakova",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                }}

        });
        this.Add(new SingersNestedItem
        {
            ID = 6,
            Artist = @"Nguyễn Diệp Chi",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/nguyen.jpg",
            Debut = 1992,
            GrammyNominations = 4,
            GrammyAwards = 2,
            HasGrammyAward = true,
            Tours = new List<SingersNestedItem_TourInfo>()
            {
            }
            ,
            Albums = new List<SingersNestedItem_AlbumInfo>()
            {
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Library of liberty",
                    LaunchDate = @"December 22, 2003",
                    BillboardReview = 93,
                    USBillboard200 = 5,
                    Artist = @"Nguyễn Diệp Chi",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                }}

        });
        this.Add(new SingersNestedItem
        {
            ID = 7,
            Artist = @"Eva Lee",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/eva.jpg",
            Debut = 2008,
            GrammyNominations = 2,
            GrammyAwards = 0,
            HasGrammyAward = false,
            Tours = new List<SingersNestedItem_TourInfo>()
            {
            }
            ,
            Albums = new List<SingersNestedItem_AlbumInfo>()
            {
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Just a tease",
                    LaunchDate = @"May 3, 2001",
                    BillboardReview = 91,
                    USBillboard200 = 29,
                    Artist = @"Eva Lee",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                }}

        });
        this.Add(new SingersNestedItem
        {
            ID = 8,
            Artist = @"Siri Jakobsson",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/siri.jpg",
            Debut = 1990,
            GrammyNominations = 2,
            GrammyAwards = 8,
            HasGrammyAward = true,
            Tours = new List<SingersNestedItem_TourInfo>()
            {
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Basket case",
                    StartedOn = @"Jan 07",
                    Location = @"Europe, Asia",
                    Headliner = @"NO",
                    TouredBy = @"Siri Jakobsson"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"The bigger fish",
                    StartedOn = @"Dec 07",
                    Location = @"United States, Europe",
                    Headliner = @"YES",
                    TouredBy = @"Siri Jakobsson"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Missed the boat",
                    StartedOn = @"Jun 09",
                    Location = @"Europe, Asia",
                    Headliner = @"NO",
                    TouredBy = @"Siri Jakobsson"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Equivalent exchange",
                    StartedOn = @"Feb 06",
                    Location = @"United States, Europe",
                    Headliner = @"YES",
                    TouredBy = @"Siri Jakobsson"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Damage control",
                    StartedOn = @"Oct 11",
                    Location = @"Australia, United States",
                    Headliner = @"NO",
                    TouredBy = @"Siri Jakobsson"
                }}
            ,
            Albums = new List<SingersNestedItem_AlbumInfo>()
            {
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Under the bus",
                    LaunchDate = @"May 14, 2000",
                    BillboardReview = 67,
                    USBillboard200 = 67,
                    Artist = @"Siri Jakobsson",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                        new SingersNestedItem_SongInfo
                        {
                            Number = 1,
                            Title = @"Jack Broke My Heart At Tesco's",
                            Released = @"19 Jan 2020",
                            Genre = @"*",
                            Album = @"Under the bus"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 2,
                            Title = @"Cat Deep, Hats High",
                            Released = @"5 Dec 2019",
                            Genre = @"*",
                            Album = @"Under the bus"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 3,
                            Title = @"In Snail We Trust",
                            Released = @"31 May 2019",
                            Genre = @"hardcore opera",
                            Album = @"Under the bus"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 4,
                            Title = @"Liz's Waiting",
                            Released = @"22 Jul 2019",
                            Genre = @"emotional C-jam ",
                            Album = @"Under the bus"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 5,
                            Title = @"Lifeless Blues",
                            Released = @"14 Jun 2019",
                            Genre = @"*",
                            Album = @"Under the bus"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 6,
                            Title = @"I Spin",
                            Released = @"26 Mar 2019",
                            Genre = @"*",
                            Album = @"Under the bus"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 7,
                            Title = @"Ring of Rock",
                            Released = @"12 Dec 2019",
                            Genre = @"*",
                            Album = @"Under the bus"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 8,
                            Title = @"Livin' on a Rock",
                            Released = @"17 Apr 2019",
                            Genre = @"*",
                            Album = @"Under the bus"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 9,
                            Title = @"Your Lifeless Heart",
                            Released = @"15 Sep 2019",
                            Genre = @"adult calypso-industrial",
                            Album = @"Under the bus"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 10,
                            Title = @"The High Street on My Mind",
                            Released = @"11 Nov 2019",
                            Genre = @"calypso and mariachi",
                            Album = @"Under the bus"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 11,
                            Title = @"Behind Ugly Curtains",
                            Released = @"8 May 2019",
                            Genre = @"*",
                            Album = @"Under the bus"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 12,
                            Title = @"Where Have All the Curtains Gone?",
                            Released = @"28 Jun 2019",
                            Genre = @"*",
                            Album = @"Under the bus"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 13,
                            Title = @"Ghost in My Apple",
                            Released = @"14 Dec 2019",
                            Genre = @"*",
                            Album = @"Under the bus"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 14,
                            Title = @"I Chatter",
                            Released = @"30 Nov 2019",
                            Genre = @"*",
                            Album = @"Under the bus"
                        }}

                }}

        });
        this.Add(new SingersNestedItem
        {
            ID = 9,
            Artist = @"Pablo Cambeiro",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/pablo.jpg",
            Debut = 2011,
            GrammyNominations = 5,
            GrammyAwards = 0,
            HasGrammyAward = false,
            Tours = new List<SingersNestedItem_TourInfo>()
            {
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Beads",
                    StartedOn = @"May 11",
                    Location = @"Worldwide",
                    Headliner = @"NO",
                    TouredBy = @"Pablo Cambeiro"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Concept art",
                    StartedOn = @"Dec 18",
                    Location = @"United States",
                    Headliner = @"YES",
                    TouredBy = @"Pablo Cambeiro"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Glass shoe",
                    StartedOn = @"Jan 20",
                    Location = @"Worldwide",
                    Headliner = @"YES",
                    TouredBy = @"Pablo Cambeiro"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Pushing buttons",
                    StartedOn = @"Feb 15",
                    Location = @"Europe, Asia",
                    Headliner = @"NO",
                    TouredBy = @"Pablo Cambeiro"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Dark matters",
                    StartedOn = @"Jan 04",
                    Location = @"Australia, United States",
                    Headliner = @"YES",
                    TouredBy = @"Pablo Cambeiro"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Greener grass",
                    StartedOn = @"Sep 09",
                    Location = @"United States, Europe",
                    Headliner = @"NO",
                    TouredBy = @"Pablo Cambeiro"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Apparatus",
                    StartedOn = @"Nov 16",
                    Location = @"Europe",
                    Headliner = @"NO",
                    TouredBy = @"Pablo Cambeiro"
                }}
            ,
            Albums = new List<SingersNestedItem_AlbumInfo>()
            {
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Fluke",
                    LaunchDate = @"August 4, 2017",
                    BillboardReview = 93,
                    USBillboard200 = 98,
                    Artist = @"Pablo Cambeiro",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                },
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Crowd control",
                    LaunchDate = @"August 26, 2003",
                    BillboardReview = 68,
                    USBillboard200 = 84,
                    Artist = @"Pablo Cambeiro",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                        new SingersNestedItem_SongInfo
                        {
                            Number = 1,
                            Title = @"My Bed on My Mind",
                            Released = @"25 Mar 2019",
                            Genre = @"ethno-tunes",
                            Album = @"Crowd control"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 2,
                            Title = @"Bright Blues",
                            Released = @"28 Sep 2019",
                            Genre = @"neuro-tunes",
                            Album = @"Crowd control"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 3,
                            Title = @"Sail, Sail, Sail!",
                            Released = @"5 Mar 2019",
                            Genre = @"*",
                            Album = @"Crowd control"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 4,
                            Title = @"Hotel My Bed",
                            Released = @"22 Mar 2019",
                            Genre = @"*",
                            Album = @"Crowd control"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 5,
                            Title = @"Gonna Make You Mash",
                            Released = @"18 May 2019",
                            Genre = @"*",
                            Album = @"Crowd control"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 6,
                            Title = @"Straight Outta America",
                            Released = @"16 Jan 2020",
                            Genre = @"hardcore opera",
                            Album = @"Crowd control"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 7,
                            Title = @"I Drive",
                            Released = @"23 Feb 2019",
                            Genre = @"emotional C-jam ",
                            Album = @"Crowd control"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 8,
                            Title = @"Like a Teddy",
                            Released = @"31 Aug 2019",
                            Genre = @"*",
                            Album = @"Crowd control"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 9,
                            Title = @"Teddy Boogie",
                            Released = @"30 Nov 2019",
                            Genre = @"*",
                            Album = @"Crowd control"
                        }}

                }}

        });
        this.Add(new SingersNestedItem
        {
            ID = 10,
            Artist = @"Athar Malakooti",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/athar.jpg",
            Debut = 2017,
            GrammyNominations = 0,
            GrammyAwards = 0,
            HasGrammyAward = false,
            Tours = new List<SingersNestedItem_TourInfo>()
            {
            }
            ,
            Albums = new List<SingersNestedItem_AlbumInfo>()
            {
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Pushing up daisies",
                    LaunchDate = @"February 24, 2016",
                    BillboardReview = 74,
                    USBillboard200 = 77,
                    Artist = @"Athar Malakooti",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                }}

        });
        this.Add(new SingersNestedItem
        {
            ID = 11,
            Artist = @"Marti Valencia",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/marti.jpg",
            Debut = 2004,
            GrammyNominations = 1,
            GrammyAwards = 1,
            HasGrammyAward = true,
            Tours = new List<SingersNestedItem_TourInfo>()
            {
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Cat eat cat world",
                    StartedOn = @"Sep 00",
                    Location = @"Worldwide",
                    Headliner = @"YES",
                    TouredBy = @"Marti Valencia"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Final straw",
                    StartedOn = @"Sep 06",
                    Location = @"United States, Europe",
                    Headliner = @"NO",
                    TouredBy = @"Marti Valencia"
                }}
            ,
            Albums = new List<SingersNestedItem_AlbumInfo>()
            {
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Nemesis",
                    LaunchDate = @"June 30, 2004",
                    BillboardReview = 94,
                    USBillboard200 = 9,
                    Artist = @"Marti Valencia",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                },
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"First chance",
                    LaunchDate = @"January 7, 2019",
                    BillboardReview = 96,
                    USBillboard200 = 19,
                    Artist = @"Marti Valencia",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                        new SingersNestedItem_SongInfo
                        {
                            Number = 1,
                            Title = @"My Name is Jason",
                            Released = @"12 Jul 2019",
                            Genre = @"*",
                            Album = @"First chance"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 2,
                            Title = @"Amazing Andy",
                            Released = @"5 Mar 2019",
                            Genre = @"*",
                            Album = @"First chance"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 3,
                            Title = @"The Number of your Knight",
                            Released = @"4 Dec 2019",
                            Genre = @"*",
                            Album = @"First chance"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 4,
                            Title = @"I Sail",
                            Released = @"3 Mar 2019",
                            Genre = @"*",
                            Album = @"First chance"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 5,
                            Title = @"Goody Two Hands",
                            Released = @"11 Oct 2019",
                            Genre = @"Electro house Electropop",
                            Album = @"First chance"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 6,
                            Title = @"Careful With That Knife",
                            Released = @"18 Dec 2019",
                            Genre = @"R&B",
                            Album = @"First chance"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 7,
                            Title = @"Four Single Ants",
                            Released = @"18 Jan 2020",
                            Genre = @"*",
                            Album = @"First chance"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 8,
                            Title = @"Kiss Forever",
                            Released = @"10 Aug 2019",
                            Genre = @"*",
                            Album = @"First chance"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 9,
                            Title = @"Rich's Waiting",
                            Released = @"15 Mar 2019",
                            Genre = @"Synth-pop R&B",
                            Album = @"First chance"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 10,
                            Title = @"Japan is Your Land",
                            Released = @"7 Mar 2019",
                            Genre = @"ethno-tunes",
                            Album = @"First chance"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 11,
                            Title = @"Pencils in My Banana",
                            Released = @"21 Jun 2019",
                            Genre = @"Crunk reggaeton",
                            Album = @"First chance"
                        },
                        new SingersNestedItem_SongInfo
                        {
                            Number = 12,
                            Title = @"I Sail in Your Arms",
                            Released = @"30 Apr 2019",
                            Genre = @"Synth-pop R&B",
                            Album = @"First chance"
                        }}

                },
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"God's advocate",
                    LaunchDate = @"April 29, 2007",
                    BillboardReview = 66,
                    USBillboard200 = 37,
                    Artist = @"Marti Valencia",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                }}

        });
        this.Add(new SingersNestedItem
        {
            ID = 12,
            Artist = @"Alicia Stanger",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/alicia.jpg",
            Debut = 2010,
            GrammyNominations = 1,
            GrammyAwards = 0,
            HasGrammyAward = false,
            Tours = new List<SingersNestedItem_TourInfo>()
            {
            }
            ,
            Albums = new List<SingersNestedItem_AlbumInfo>()
            {
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Forever alone",
                    LaunchDate = @"November 3, 2005",
                    BillboardReview = 82,
                    USBillboard200 = 7,
                    Artist = @"Alicia Stanger",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                }}

        });
        this.Add(new SingersNestedItem
        {
            ID = 13,
            Artist = @"Peter Taylor",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/peter.jpg",
            Debut = 2005,
            GrammyNominations = 0,
            GrammyAwards = 2,
            HasGrammyAward = true,
            Tours = new List<SingersNestedItem_TourInfo>()
            {
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Love",
                    StartedOn = @"Jun 04",
                    Location = @"Europe, Asia",
                    Headliner = @"YES",
                    TouredBy = @"Peter Taylor"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Fault of treasures",
                    StartedOn = @"Oct 13",
                    Location = @"North America",
                    Headliner = @"NO",
                    TouredBy = @"Peter Taylor"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"For eternity",
                    StartedOn = @"Mar 05",
                    Location = @"United States",
                    Headliner = @"YES",
                    TouredBy = @"Peter Taylor"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Time flies",
                    StartedOn = @"Jun 03",
                    Location = @"North America",
                    Headliner = @"NO",
                    TouredBy = @"Peter Taylor"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Highest difficulty",
                    StartedOn = @"Nov 01",
                    Location = @"Worldwide",
                    Headliner = @"YES",
                    TouredBy = @"Peter Taylor"
                },
                new SingersNestedItem_TourInfo
                {
                    Tour = @"Sleeping dogs",
                    StartedOn = @"May 04",
                    Location = @"United States, Europe",
                    Headliner = @"NO",
                    TouredBy = @"Peter Taylor"
                }}
            ,
            Albums = new List<SingersNestedItem_AlbumInfo>()
            {
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Decisions decisions",
                    LaunchDate = @"April 10, 2008",
                    BillboardReview = 85,
                    USBillboard200 = 35,
                    Artist = @"Peter Taylor",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                },
                new SingersNestedItem_AlbumInfo()
                {
                    Album = @"Climate changed",
                    LaunchDate = @"June 20, 2015",
                    BillboardReview = 66,
                    USBillboard200 = 89,
                    Artist = @"Peter Taylor",
                    Songs = new List<SingersNestedItem_SongInfo>()
                    {
                    }

                }}

        });
    }
}
