using System;
using System.Collections.Generic;
public class SingersDataItem
{
    public double ID { get; set; }
    public string Artist { get; set; }
    public string Photo { get; set; }
    public double Debut { get; set; }
    public double GrammyNominations { get; set; }
    public double GrammyAwards { get; set; }
    public bool HasGrammyAward { get; set; }
    public List<SingersDataItem_ToursItem> Tours { get; set; }
    public List<SingersDataItem_AlbumsItem> Albums { get; set; }
}
public class SingersDataItem_ToursItem
{
    public string Tour { get; set; }
    public string StartedOn { get; set; }
    public string Location { get; set; }
    public string Headliner { get; set; }
    public string TouredBy { get; set; }
}
public class SingersDataItem_AlbumsItem
{
    public string Album { get; set; }
    public string LaunchDate { get; set; }
    public double BillboardReview { get; set; }
    public double USBillboard200 { get; set; }
    public string Artist { get; set; }
}

public class SingersData
    : List<SingersDataItem>
{
    public SingersData()
    {
        this.Add(new SingersDataItem()
        {
            ID = 0,
            Artist = @"Naomí Yepes",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/naomi.jpg",
            Debut = 2011,
            GrammyNominations = 6,
            GrammyAwards = 0,
            HasGrammyAward = false,
            Tours = new List<SingersDataItem_ToursItem>()
            {
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Faithful Tour",
                    StartedOn = @"Sep 12",
                    Location = @"Worldwide",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"City Jam Sessions",
                    StartedOn = @"Aug 13",
                    Location = @"North America",
                    Headliner = @"YES",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Christmas NYC 2013",
                    StartedOn = @"Dec 13",
                    Location = @"United States",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Christmas NYC 2014",
                    StartedOn = @"Dec 14",
                    Location = @"North America",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Watermelon Tour",
                    StartedOn = @"Feb 15",
                    Location = @"Worldwide",
                    Headliner = @"YES",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Christmas NYC 2016",
                    StartedOn = @"Dec 16",
                    Location = @"United States",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"The Dragon Tour",
                    StartedOn = @"Feb 17",
                    Location = @"Worldwide",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Organic Sessions",
                    StartedOn = @"Aug 18",
                    Location = @"United States, England",
                    Headliner = @"YES",
                    TouredBy = @"Naomí Yepes"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Hope World Tour",
                    StartedOn = @"Mar 19",
                    Location = @"Worldwide",
                    Headliner = @"NO",
                    TouredBy = @"Naomí Yepes"
                }}
            ,
            Albums = new List<SingersDataItem_AlbumsItem>()
            {
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Initiation",
                    LaunchDate = @"September 3, 2013",
                    BillboardReview = 86,
                    USBillboard200 = 1,
                    Artist = @"Naomí Yepes"
                },
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Dream Driven",
                    LaunchDate = @"August 25, 2014",
                    BillboardReview = 81,
                    USBillboard200 = 1,
                    Artist = @"Naomí Yepes"
                },
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"The dragon journey",
                    LaunchDate = @"May 20, 2016",
                    BillboardReview = 60,
                    USBillboard200 = 2,
                    Artist = @"Naomí Yepes"
                },
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Organic me",
                    LaunchDate = @"August 17, 2018",
                    BillboardReview = 82,
                    USBillboard200 = 1,
                    Artist = @"Naomí Yepes"
                },
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Curiosity",
                    LaunchDate = @"December 7, 2019",
                    BillboardReview = 75,
                    USBillboard200 = 12,
                    Artist = @"Naomí Yepes"
                }}

        });
        this.Add(new SingersDataItem()
        {
            ID = 1,
            Artist = @"Babila Ebwélé",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/babila.jpg",
            Debut = 2009,
            GrammyNominations = 0,
            GrammyAwards = 11,
            HasGrammyAward = true,
            Tours = new List<SingersDataItem_ToursItem>()
            {
                new SingersDataItem_ToursItem()
                {
                    Tour = @"The last straw",
                    StartedOn = @"May 09",
                    Location = @"Europe, Asia",
                    Headliner = @"NO",
                    TouredBy = @"Babila Ebwélé"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"No foundations",
                    StartedOn = @"Jun 04",
                    Location = @"United States, Europe",
                    Headliner = @"YES",
                    TouredBy = @"Babila Ebwélé"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Crazy eyes",
                    StartedOn = @"Jun 08",
                    Location = @"North America",
                    Headliner = @"NO",
                    TouredBy = @"Babila Ebwélé"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Zero gravity",
                    StartedOn = @"Apr 19",
                    Location = @"United States",
                    Headliner = @"NO",
                    TouredBy = @"Babila Ebwélé"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Battle with myself",
                    StartedOn = @"Mar 08",
                    Location = @"North America",
                    Headliner = @"YES",
                    TouredBy = @"Babila Ebwélé"
                }}
            ,
            Albums = new List<SingersDataItem_AlbumsItem>()
            {
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Pushing up daisies",
                    LaunchDate = @"May 31, 2000",
                    BillboardReview = 86,
                    USBillboard200 = 42,
                    Artist = @"Babila Ebwélé"
                },
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Death's dead",
                    LaunchDate = @"June 8, 2016",
                    BillboardReview = 85,
                    USBillboard200 = 95,
                    Artist = @"Babila Ebwélé"
                }}

        });
        this.Add(new SingersDataItem()
        {
            ID = 2,
            Artist = @"Ahmad Nazeri",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/ahmad.jpg",
            Debut = 2004,
            GrammyNominations = 3,
            GrammyAwards = 1,
            HasGrammyAward = true,
            Tours = new List<SingersDataItem_ToursItem>()
            {
            }
            ,
            Albums = new List<SingersDataItem_AlbumsItem>()
            {
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Emergency",
                    LaunchDate = @"March 6, 2004",
                    BillboardReview = 98,
                    USBillboard200 = 69,
                    Artist = @"Ahmad Nazeri"
                },
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Bursting bubbles",
                    LaunchDate = @"April 17, 2006",
                    BillboardReview = 69,
                    USBillboard200 = 39,
                    Artist = @"Ahmad Nazeri"
                }}

        });
        this.Add(new SingersDataItem()
        {
            ID = 3,
            Artist = @"Kimmy McIlmorie",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/kimmy.jpg",
            Debut = 2007,
            GrammyNominations = 21,
            GrammyAwards = 3,
            HasGrammyAward = true,
            Tours = new List<SingersDataItem_ToursItem>()
            {
            }
            ,
            Albums = new List<SingersDataItem_AlbumsItem>()
            {
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Here we go again",
                    LaunchDate = @"November 18, 2017",
                    BillboardReview = 68,
                    USBillboard200 = 1,
                    Artist = @"Kimmy McIlmorie"
                }}

        });
        this.Add(new SingersDataItem()
        {
            ID = 4,
            Artist = @"Mar Rueda",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/mar.jpg",
            Debut = 1996,
            GrammyNominations = 14,
            GrammyAwards = 2,
            HasGrammyAward = true,
            Tours = new List<SingersDataItem_ToursItem>()
            {
            }
            ,
            Albums = new List<SingersDataItem_AlbumsItem>()
            {
            }

        });
        this.Add(new SingersDataItem()
        {
            ID = 5,
            Artist = @"Izabella Tabakova",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/izabella.jpg",
            Debut = 2017,
            GrammyNominations = 7,
            GrammyAwards = 11,
            HasGrammyAward = true,
            Tours = new List<SingersDataItem_ToursItem>()
            {
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Final breath",
                    StartedOn = @"Jun 13",
                    Location = @"Europe",
                    Headliner = @"YES",
                    TouredBy = @"Izabella Tabakova"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Once bitten",
                    StartedOn = @"Dec 18",
                    Location = @"Australia, United States",
                    Headliner = @"NO",
                    TouredBy = @"Izabella Tabakova"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Code word",
                    StartedOn = @"Sep 19",
                    Location = @"United States, Europe",
                    Headliner = @"NO",
                    TouredBy = @"Izabella Tabakova"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Final draft",
                    StartedOn = @"Sep 17",
                    Location = @"United States, Europe",
                    Headliner = @"YES",
                    TouredBy = @"Izabella Tabakova"
                }}
            ,
            Albums = new List<SingersDataItem_AlbumsItem>()
            {
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Once bitten",
                    LaunchDate = @"July 16, 2007",
                    BillboardReview = 79,
                    USBillboard200 = 53,
                    Artist = @"Izabella Tabakova"
                },
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Your graciousness",
                    LaunchDate = @"November 17, 2004",
                    BillboardReview = 69,
                    USBillboard200 = 30,
                    Artist = @"Izabella Tabakova"
                },
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Dark matters",
                    LaunchDate = @"November 3, 2002",
                    BillboardReview = 79,
                    USBillboard200 = 85,
                    Artist = @"Izabella Tabakova"
                }}

        });
        this.Add(new SingersDataItem()
        {
            ID = 6,
            Artist = @"Nguyễn Diệp Chi",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/nguyen.jpg",
            Debut = 1992,
            GrammyNominations = 4,
            GrammyAwards = 2,
            HasGrammyAward = true,
            Tours = new List<SingersDataItem_ToursItem>()
            {
            }
            ,
            Albums = new List<SingersDataItem_AlbumsItem>()
            {
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Library of liberty",
                    LaunchDate = @"December 22, 2003",
                    BillboardReview = 93,
                    USBillboard200 = 5,
                    Artist = @"Nguyễn Diệp Chi"
                }}

        });
        this.Add(new SingersDataItem()
        {
            ID = 7,
            Artist = @"Eva Lee",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/eva.jpg",
            Debut = 2008,
            GrammyNominations = 2,
            GrammyAwards = 0,
            HasGrammyAward = false,
            Tours = new List<SingersDataItem_ToursItem>()
            {
            }
            ,
            Albums = new List<SingersDataItem_AlbumsItem>()
            {
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Just a tease",
                    LaunchDate = @"May 3, 2001",
                    BillboardReview = 91,
                    USBillboard200 = 29,
                    Artist = @"Eva Lee"
                }}

        });
        this.Add(new SingersDataItem()
        {
            ID = 8,
            Artist = @"Siri Jakobsson",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/siri.jpg",
            Debut = 1990,
            GrammyNominations = 2,
            GrammyAwards = 8,
            HasGrammyAward = true,
            Tours = new List<SingersDataItem_ToursItem>()
            {
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Basket case",
                    StartedOn = @"Jan 07",
                    Location = @"Europe, Asia",
                    Headliner = @"NO",
                    TouredBy = @"Siri Jakobsson"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"The bigger fish",
                    StartedOn = @"Dec 07",
                    Location = @"United States, Europe",
                    Headliner = @"YES",
                    TouredBy = @"Siri Jakobsson"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Missed the boat",
                    StartedOn = @"Jun 09",
                    Location = @"Europe, Asia",
                    Headliner = @"NO",
                    TouredBy = @"Siri Jakobsson"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Equivalent exchange",
                    StartedOn = @"Feb 06",
                    Location = @"United States, Europe",
                    Headliner = @"YES",
                    TouredBy = @"Siri Jakobsson"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Damage control",
                    StartedOn = @"Oct 11",
                    Location = @"Australia, United States",
                    Headliner = @"NO",
                    TouredBy = @"Siri Jakobsson"
                }}
            ,
            Albums = new List<SingersDataItem_AlbumsItem>()
            {
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Under the bus",
                    LaunchDate = @"May 14, 2000",
                    BillboardReview = 67,
                    USBillboard200 = 67,
                    Artist = @"Siri Jakobsson"
                }}

        });
        this.Add(new SingersDataItem()
        {
            ID = 9,
            Artist = @"Pablo Cambeiro",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/pablo.jpg",
            Debut = 2011,
            GrammyNominations = 5,
            GrammyAwards = 0,
            HasGrammyAward = false,
            Tours = new List<SingersDataItem_ToursItem>()
            {
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Beads",
                    StartedOn = @"May 11",
                    Location = @"Worldwide",
                    Headliner = @"NO",
                    TouredBy = @"Pablo Cambeiro"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Concept art",
                    StartedOn = @"Dec 18",
                    Location = @"United States",
                    Headliner = @"YES",
                    TouredBy = @"Pablo Cambeiro"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Glass shoe",
                    StartedOn = @"Jan 20",
                    Location = @"Worldwide",
                    Headliner = @"YES",
                    TouredBy = @"Pablo Cambeiro"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Pushing buttons",
                    StartedOn = @"Feb 15",
                    Location = @"Europe, Asia",
                    Headliner = @"NO",
                    TouredBy = @"Pablo Cambeiro"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Dark matters",
                    StartedOn = @"Jan 04",
                    Location = @"Australia, United States",
                    Headliner = @"YES",
                    TouredBy = @"Pablo Cambeiro"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Greener grass",
                    StartedOn = @"Sep 09",
                    Location = @"United States, Europe",
                    Headliner = @"NO",
                    TouredBy = @"Pablo Cambeiro"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Apparatus",
                    StartedOn = @"Nov 16",
                    Location = @"Europe",
                    Headliner = @"NO",
                    TouredBy = @"Pablo Cambeiro"
                }}
            ,
            Albums = new List<SingersDataItem_AlbumsItem>()
            {
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Fluke",
                    LaunchDate = @"August 4, 2017",
                    BillboardReview = 93,
                    USBillboard200 = 98,
                    Artist = @"Pablo Cambeiro"
                },
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Crowd control",
                    LaunchDate = @"August 26, 2003",
                    BillboardReview = 68,
                    USBillboard200 = 84,
                    Artist = @"Pablo Cambeiro"
                }}

        });
        this.Add(new SingersDataItem()
        {
            ID = 10,
            Artist = @"Athar Malakooti",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/athar.jpg",
            Debut = 2017,
            GrammyNominations = 0,
            GrammyAwards = 0,
            HasGrammyAward = false,
            Tours = new List<SingersDataItem_ToursItem>()
            {
            }
            ,
            Albums = new List<SingersDataItem_AlbumsItem>()
            {
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Pushing up daisies",
                    LaunchDate = @"February 24, 2016",
                    BillboardReview = 74,
                    USBillboard200 = 77,
                    Artist = @"Athar Malakooti"
                }}

        });
        this.Add(new SingersDataItem()
        {
            ID = 11,
            Artist = @"Marti Valencia",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/marti.jpg",
            Debut = 2004,
            GrammyNominations = 1,
            GrammyAwards = 1,
            HasGrammyAward = true,
            Tours = new List<SingersDataItem_ToursItem>()
            {
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Cat eat cat world",
                    StartedOn = @"Sep 00",
                    Location = @"Worldwide",
                    Headliner = @"YES",
                    TouredBy = @"Marti Valencia"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Final straw",
                    StartedOn = @"Sep 06",
                    Location = @"United States, Europe",
                    Headliner = @"NO",
                    TouredBy = @"Marti Valencia"
                }}
            ,
            Albums = new List<SingersDataItem_AlbumsItem>()
            {
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Nemesis",
                    LaunchDate = @"June 30, 2004",
                    BillboardReview = 94,
                    USBillboard200 = 9,
                    Artist = @"Marti Valencia"
                },
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"First chance",
                    LaunchDate = @"January 7, 2019",
                    BillboardReview = 96,
                    USBillboard200 = 19,
                    Artist = @"Marti Valencia"
                },
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"God's advocate",
                    LaunchDate = @"April 29, 2007",
                    BillboardReview = 66,
                    USBillboard200 = 37,
                    Artist = @"Marti Valencia"
                }}

        });
        this.Add(new SingersDataItem()
        {
            ID = 12,
            Artist = @"Alicia Stanger",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/alicia.jpg",
            Debut = 2010,
            GrammyNominations = 1,
            GrammyAwards = 0,
            HasGrammyAward = false,
            Tours = new List<SingersDataItem_ToursItem>()
            {
            }
            ,
            Albums = new List<SingersDataItem_AlbumsItem>()
            {
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Forever alone",
                    LaunchDate = @"November 3, 2005",
                    BillboardReview = 82,
                    USBillboard200 = 7,
                    Artist = @"Alicia Stanger"
                }}

        });
        this.Add(new SingersDataItem()
        {
            ID = 13,
            Artist = @"Peter Taylor",
            Photo = @"https://static.infragistics.com/xplatform/images/people/names/peter.jpg",
            Debut = 2005,
            GrammyNominations = 0,
            GrammyAwards = 2,
            HasGrammyAward = true,
            Tours = new List<SingersDataItem_ToursItem>()
            {
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Love",
                    StartedOn = @"Jun 04",
                    Location = @"Europe, Asia",
                    Headliner = @"YES",
                    TouredBy = @"Peter Taylor"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Fault of treasures",
                    StartedOn = @"Oct 13",
                    Location = @"North America",
                    Headliner = @"NO",
                    TouredBy = @"Peter Taylor"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"For eternity",
                    StartedOn = @"Mar 05",
                    Location = @"United States",
                    Headliner = @"YES",
                    TouredBy = @"Peter Taylor"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Time flies",
                    StartedOn = @"Jun 03",
                    Location = @"North America",
                    Headliner = @"NO",
                    TouredBy = @"Peter Taylor"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Highest difficulty",
                    StartedOn = @"Nov 01",
                    Location = @"Worldwide",
                    Headliner = @"YES",
                    TouredBy = @"Peter Taylor"
                },
                new SingersDataItem_ToursItem()
                {
                    Tour = @"Sleeping dogs",
                    StartedOn = @"May 04",
                    Location = @"United States, Europe",
                    Headliner = @"NO",
                    TouredBy = @"Peter Taylor"
                }}
            ,
            Albums = new List<SingersDataItem_AlbumsItem>()
            {
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Decisions decisions",
                    LaunchDate = @"April 10, 2008",
                    BillboardReview = 85,
                    USBillboard200 = 35,
                    Artist = @"Peter Taylor"
                },
                new SingersDataItem_AlbumsItem()
                {
                    Album = @"Climate changed",
                    LaunchDate = @"June 20, 2015",
                    BillboardReview = 66,
                    USBillboard200 = 89,
                    Artist = @"Peter Taylor"
                }}

        });
    }
}
