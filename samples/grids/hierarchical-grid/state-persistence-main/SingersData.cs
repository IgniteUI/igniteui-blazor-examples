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
    public List<SingersDataItem_AlbumsItem_SongsItem> Songs { get; set; }
}
public class SingersDataItem_AlbumsItem_SongsItem
{
    public double Number { get; set; }
    public string Title { get; set; }
    public string Released { get; set; }
    public string Genre { get; set; }
    public string Album { get; set; }
}

public class SingersData
    : List<SingersDataItem>
{
    public SingersData()
    {
        this.Add(new SingersDataItem() { ID = 0, Artist = @"Naomí Yepes", Photo = @"https://static.infragistics.com/xplatform/images/people/names/naomi.jpg", Debut = 2011, GrammyNominations = 6, GrammyAwards = 0, HasGrammyAward = false, Tours = new List<SingersDataItem_ToursItem>()
        {
            new SingersDataItem_ToursItem() { Tour = @"Faithful Tour", StartedOn = @"Sep 12", Location = @"Worldwide", Headliner = @"NO", TouredBy = @"Naomí Yepes" },
            new SingersDataItem_ToursItem() { Tour = @"City Jam Sessions", StartedOn = @"Aug 13", Location = @"North America", Headliner = @"YES", TouredBy = @"Naomí Yepes" },
            new SingersDataItem_ToursItem() { Tour = @"Christmas NYC 2013", StartedOn = @"Dec 13", Location = @"United States", Headliner = @"NO", TouredBy = @"Naomí Yepes" },
            new SingersDataItem_ToursItem() { Tour = @"Christmas NYC 2014", StartedOn = @"Dec 14", Location = @"North America", Headliner = @"NO", TouredBy = @"Naomí Yepes" },
            new SingersDataItem_ToursItem() { Tour = @"Watermelon Tour", StartedOn = @"Feb 15", Location = @"Worldwide", Headliner = @"YES", TouredBy = @"Naomí Yepes" },
            new SingersDataItem_ToursItem() { Tour = @"Christmas NYC 2016", StartedOn = @"Dec 16", Location = @"United States", Headliner = @"NO", TouredBy = @"Naomí Yepes" },
            new SingersDataItem_ToursItem() { Tour = @"The Dragon Tour", StartedOn = @"Feb 17", Location = @"Worldwide", Headliner = @"NO", TouredBy = @"Naomí Yepes" },
            new SingersDataItem_ToursItem() { Tour = @"Organic Sessions", StartedOn = @"Aug 18", Location = @"United States, England", Headliner = @"YES", TouredBy = @"Naomí Yepes" },
            new SingersDataItem_ToursItem() { Tour = @"Hope World Tour", StartedOn = @"Mar 19", Location = @"Worldwide", Headliner = @"NO", TouredBy = @"Naomí Yepes" }}
        , Albums = new List<SingersDataItem_AlbumsItem>()
        {
            new SingersDataItem_AlbumsItem() { Album = @"Initiation", LaunchDate = @"September 3, 2013", BillboardReview = 86, USBillboard200 = 1, Artist = @"Naomí Yepes", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Lonely Falling", Released = @"01 May 2019", Genre = @"*", Album = @"Initiation" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Bright Breaking", Released = @"25 Jul 2019", Genre = @"Electro house Electropop", Album = @"Initiation" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"River of Whisper", Released = @"29 Jan 2020", Genre = @"Electro house Electropop", Album = @"Initiation" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Sky of Storm", Released = @"07 May 2019", Genre = @"Electro house Electropop", Album = @"Initiation" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Electric River", Released = @"20 Jan 2020", Genre = @"R&B", Album = @"Initiation" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Storm of Storm", Released = @"01 Sep 2019", Genre = @"Crunk reggaeton", Album = @"Initiation" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Fire of Dream", Released = @"12 Sep 2019", Genre = @"Electro house Electropop", Album = @"Initiation" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Burning in the Light", Released = @"15 Apr 2019", Genre = @"*", Album = @"Initiation" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Burning in the Storm", Released = @"10 Sep 2019", Genre = @"Electro house Electropop", Album = @"Initiation" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Shadow of Whisper", Released = @"06 Jan 2019", Genre = @"Crunk reggaeton", Album = @"Initiation" }}
             },
            new SingersDataItem_AlbumsItem() { Album = @"Dream Driven", LaunchDate = @"August 25, 2014", BillboardReview = 81, USBillboard200 = 1, Artist = @"Naomí Yepes", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Intro", Released = @"10 Sep 2019", Genre = @"*", Album = @"Dream Driven" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Ferocious", Released = @"28 Apr 2014", Genre = @"Dance-pop R&B", Album = @"Dream Driven" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Going crazy", Released = @"10 Feb 2015", Genre = @"Dance-pop EDM", Album = @"Dream Driven" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Future past", Released = @"20 Sep 2011", Genre = @"*", Album = @"Dream Driven" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Roaming like them", Released = @"2 Jul 2014", Genre = @"Electro house Electropop", Album = @"Dream Driven" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Last Wishes", Released = @"12 Aug 2014", Genre = @"R&B", Album = @"Dream Driven" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Stay where you are", Released = @"14 Sep 2013", Genre = @"*", Album = @"Dream Driven" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Imaginarium", Released = @"20 Sep 2021", Genre = @"*", Album = @"Dream Driven" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Tell me", Released = @"30 Sep 2014", Genre = @"Synth-pop R&B", Album = @"Dream Driven" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Shredded into pieces", Released = @"11 Sep 2015", Genre = @"*", Album = @"Dream Driven" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 11, Title = @"Capture this moment", Released = @"13 Sep 2016", Genre = @"*", Album = @"Dream Driven" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 12, Title = @"Dream Driven", Released = @"14 Sep 2014", Genre = @"*", Album = @"Dream Driven" }}
             },
            new SingersDataItem_AlbumsItem() { Album = @"The dragon journey", LaunchDate = @"May 20, 2016", BillboardReview = 60, USBillboard200 = 2, Artist = @"Naomí Yepes", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Calling in the Storm", Released = @"12 Mar 2019", Genre = @"Electro house Electropop", Album = @"The dragon journey" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Hiding in the Dream", Released = @"23 Mar 2019", Genre = @"R&B", Album = @"The dragon journey" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Electric Heart", Released = @"17 Mar 2019", Genre = @"ethno-tunes", Album = @"The dragon journey" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Shadow of Echo", Released = @"20 Feb 2019", Genre = @"ethno-tunes", Album = @"The dragon journey" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Flying in the Storm", Released = @"08 Apr 2019", Genre = @"R&B", Album = @"The dragon journey" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Dark Waiting", Released = @"20 Oct 2019", Genre = @"Synth-pop R&B", Album = @"The dragon journey" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Fire of River", Released = @"20 Feb 2019", Genre = @"Synth-pop R&B", Album = @"The dragon journey" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Wild Crying", Released = @"14 Jun 2019", Genre = @"R&B", Album = @"The dragon journey" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Bright Dancing", Released = @"14 Mar 2019", Genre = @"Electro house Electropop", Album = @"The dragon journey" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Golden Waiting", Released = @"12 Sep 2019", Genre = @"Synth-pop R&B", Album = @"The dragon journey" }}
             },
            new SingersDataItem_AlbumsItem() { Album = @"Organic me", LaunchDate = @"August 17, 2018", BillboardReview = 82, USBillboard200 = 1, Artist = @"Naomí Yepes", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"I Love", Released = @"11 May 2019", Genre = @"Crunk reggaeton", Album = @"Organic me" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Early Morning Compass", Released = @"15 Jan 2020", Genre = @"mystical parody-bap ", Album = @"Organic me" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Key Fields Forever", Released = @"2 Jan 2020", Genre = @"Dance-pop EDM", Album = @"Organic me" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Stand by Your Goblins", Released = @"20 Nov 2019", Genre = @"*", Album = @"Organic me" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Mad to Walk", Released = @"12 May 2019", Genre = @"Electro house Electropop", Album = @"Organic me" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Alice's Waiting", Released = @"28 Jan 2020", Genre = @"R&B", Album = @"Organic me" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"We Shall Kiss", Released = @"30 Oct 2019", Genre = @"*", Album = @"Organic me" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Behind Single Ants", Released = @"2 Oct 2019", Genre = @"*", Album = @"Organic me" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Soap Autopsy", Released = @"8 Aug 2019", Genre = @"Synth-pop R&B", Album = @"Organic me" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Have You Met Rich?", Released = @"1 Jul 2019", Genre = @"ethno-tunes", Album = @"Organic me" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 11, Title = @"Livin' on a Banana", Released = @"22 Nov 2019", Genre = @"Crunk reggaeton", Album = @"Organic me" }}
             },
            new SingersDataItem_AlbumsItem() { Album = @"Curiosity", LaunchDate = @"December 7, 2019", BillboardReview = 75, USBillboard200 = 12, Artist = @"Naomí Yepes", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Storm of Dream", Released = @"05 Jan 2019", Genre = @"*", Album = @"Curiosity" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Echo of Dream", Released = @"28 Jan 2019", Genre = @"Synth-pop R&B", Album = @"Curiosity" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Light of Shadow", Released = @"07 Feb 2019", Genre = @"Synth-pop R&B", Album = @"Curiosity" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Storm of Heart", Released = @"05 Jan 2020", Genre = @"Electro house Electropop", Album = @"Curiosity" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Shadow of River", Released = @"27 Feb 2019", Genre = @"*", Album = @"Curiosity" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Wicked Dancing", Released = @"17 Jan 2020", Genre = @"ethno-tunes", Album = @"Curiosity" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"River of Light", Released = @"22 Feb 2019", Genre = @"R&B", Album = @"Curiosity" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Lonely Breaking", Released = @"09 Sep 2019", Genre = @"ethno-tunes", Album = @"Curiosity" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Furious Flying", Released = @"08 Jun 2019", Genre = @"R&B", Album = @"Curiosity" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Hiding in the Storm", Released = @"27 May 2019", Genre = @"Electro house Electropop", Album = @"Curiosity" }}
             }}
         });
        this.Add(new SingersDataItem() { ID = 1, Artist = @"Babila Ebwélé", Photo = @"https://static.infragistics.com/xplatform/images/people/names/babila.jpg", Debut = 2009, GrammyNominations = 0, GrammyAwards = 11, HasGrammyAward = true, Tours = new List<SingersDataItem_ToursItem>()
        {
            new SingersDataItem_ToursItem() { Tour = @"The last straw", StartedOn = @"May 09", Location = @"Europe, Asia", Headliner = @"NO", TouredBy = @"Babila Ebwélé" },
            new SingersDataItem_ToursItem() { Tour = @"No foundations", StartedOn = @"Jun 04", Location = @"United States, Europe", Headliner = @"YES", TouredBy = @"Babila Ebwélé" },
            new SingersDataItem_ToursItem() { Tour = @"Crazy eyes", StartedOn = @"Jun 08", Location = @"North America", Headliner = @"NO", TouredBy = @"Babila Ebwélé" },
            new SingersDataItem_ToursItem() { Tour = @"Zero gravity", StartedOn = @"Apr 19", Location = @"United States", Headliner = @"NO", TouredBy = @"Babila Ebwélé" },
            new SingersDataItem_ToursItem() { Tour = @"Battle with myself", StartedOn = @"Mar 08", Location = @"North America", Headliner = @"YES", TouredBy = @"Babila Ebwélé" }}
        , Albums = new List<SingersDataItem_AlbumsItem>()
        {
            new SingersDataItem_AlbumsItem() { Album = @"Pushing up daisies", LaunchDate = @"May 31, 2000", BillboardReview = 86, USBillboard200 = 42, Artist = @"Babila Ebwélé", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Wood Shavings Forever", Released = @"9 Jun 2019", Genre = @"*", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Early Morning Drive", Released = @"20 May 2019", Genre = @"*", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Don't Natter", Released = @"10 Jun 2019", Genre = @"adult calypso-industrial", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Stairway to Balloons", Released = @"18 Jun 2019", Genre = @"calypso and mariachi", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"The Number of your Apple", Released = @"29 Oct 2019", Genre = @"*", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Your Delightful Heart", Released = @"24 Feb 2019", Genre = @"*", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Nice Weather For Balloons", Released = @"1 Aug 2019", Genre = @"rap-hop", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"The Girl From Cornwall", Released = @"4 May 2019", Genre = @"enigmatic rock-and-roll", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Here Without Jack", Released = @"24 Oct 2019", Genre = @"*", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Born Rancid", Released = @"19 Mar 2019", Genre = @"*", Album = @"Pushing up daisies" }}
             },
            new SingersDataItem_AlbumsItem() { Album = @"Death's dead", LaunchDate = @"June 8, 2016", BillboardReview = 85, USBillboard200 = 95, Artist = @"Babila Ebwélé", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Men Sound Better With You", Released = @"20 Oct 2019", Genre = @"rap-hop", Album = @"Death's dead" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Ghost in My Rod", Released = @"5 Oct 2019", Genre = @"enigmatic rock-and-roll", Album = @"Death's dead" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Bed of Men", Released = @"14 Nov 2019", Genre = @"whimsical comedy-grass ", Album = @"Death's dead" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Don't Push", Released = @"2 Jan 2020", Genre = @"unblack electronic-trip-hop", Album = @"Death's dead" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Nice Weather For Men", Released = @"18 Dec 2019", Genre = @"*", Album = @"Death's dead" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Rancid Rhapsody", Released = @"10 Mar 2019", Genre = @"*", Album = @"Death's dead" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Push, Push, Push!", Released = @"21 Feb 2019", Genre = @"*", Album = @"Death's dead" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"My Name is Sarah", Released = @"15 Nov 2019", Genre = @"*", Album = @"Death's dead" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"The Girl From My Hotel", Released = @"6 Nov 2019", Genre = @"*", Album = @"Death's dead" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Free Box", Released = @"18 Apr 2019", Genre = @"splitter-funk", Album = @"Death's dead" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 11, Title = @"Hotel Cardiff", Released = @"30 Dec 2019", Genre = @"guilty pleasure ebm", Album = @"Death's dead" }}
             }}
         });
        this.Add(new SingersDataItem() { ID = 2, Artist = @"Ahmad Nazeri", Photo = @"https://static.infragistics.com/xplatform/images/people/names/ahmad.jpg", Debut = 2004, GrammyNominations = 3, GrammyAwards = 1, HasGrammyAward = true, Tours = new List<SingersDataItem_ToursItem>()
        {
        }
        , Albums = new List<SingersDataItem_AlbumsItem>()
        {
            new SingersDataItem_AlbumsItem() { Album = @"Emergency", LaunchDate = @"March 6, 2004", BillboardReview = 98, USBillboard200 = 69, Artist = @"Ahmad Nazeri", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Gentle Falling", Released = @"26 Apr 2019", Genre = @"Crunk reggaeton", Album = @"Emergency" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Calling in the Fire", Released = @"03 Sep 2019", Genre = @"ethno-tunes", Album = @"Emergency" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Fire of Shadow", Released = @"05 Jan 2019", Genre = @"ethno-tunes", Album = @"Emergency" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Dancing in the Dream", Released = @"15 Apr 2019", Genre = @"R&B", Album = @"Emergency" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Calling in the Shadow", Released = @"09 Oct 2019", Genre = @"R&B", Album = @"Emergency" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Falling in the Sky", Released = @"08 Mar 2019", Genre = @"ethno-tunes", Album = @"Emergency" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Calling in the Storm", Released = @"05 Dec 2019", Genre = @"ethno-tunes", Album = @"Emergency" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Falling in the River", Released = @"19 Aug 2019", Genre = @"Electro house Electropop", Album = @"Emergency" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Electric Fire", Released = @"30 Nov 2019", Genre = @"Crunk reggaeton", Album = @"Emergency" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Lonely River", Released = @"11 Nov 2019", Genre = @"Electro house Electropop", Album = @"Emergency" }}
             },
            new SingersDataItem_AlbumsItem() { Album = @"Bursting bubbles", LaunchDate = @"April 17, 2006", BillboardReview = 69, USBillboard200 = 39, Artist = @"Ahmad Nazeri", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Lonely Dream", Released = @"11 Dec 2019", Genre = @"ethno-tunes", Album = @"Bursting bubbles" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Fire of River", Released = @"01 Aug 2019", Genre = @"Synth-pop R&B", Album = @"Bursting bubbles" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Wicked Falling", Released = @"25 Jan 2019", Genre = @"*", Album = @"Bursting bubbles" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Crying in the Shadow", Released = @"04 Jan 2019", Genre = @"Synth-pop R&B", Album = @"Bursting bubbles" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Wild Burning", Released = @"10 May 2019", Genre = @"ethno-tunes", Album = @"Bursting bubbles" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Waiting in the Heart", Released = @"07 Aug 2019", Genre = @"ethno-tunes", Album = @"Bursting bubbles" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Fire of Fire", Released = @"16 May 2019", Genre = @"Electro house Electropop", Album = @"Bursting bubbles" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Bright Heart", Released = @"14 Mar 2019", Genre = @"Synth-pop R&B", Album = @"Bursting bubbles" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Lonely Fire", Released = @"15 Oct 2019", Genre = @"R&B", Album = @"Bursting bubbles" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Sky of Dream", Released = @"20 Jun 2019", Genre = @"ethno-tunes", Album = @"Bursting bubbles" }}
             }}
         });
        this.Add(new SingersDataItem() { ID = 3, Artist = @"Kimmy McIlmorie", Photo = @"https://static.infragistics.com/xplatform/images/people/names/kimmy.jpg", Debut = 2007, GrammyNominations = 21, GrammyAwards = 3, HasGrammyAward = true, Tours = new List<SingersDataItem_ToursItem>()
        {
        }
        , Albums = new List<SingersDataItem_AlbumsItem>()
        {
            new SingersDataItem_AlbumsItem() { Album = @"Here we go again", LaunchDate = @"November 18, 2017", BillboardReview = 68, USBillboard200 = 1, Artist = @"Kimmy McIlmorie", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Storm of Sky", Released = @"04 Mar 2019", Genre = @"ethno-tunes", Album = @"Here we go again" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Dream of Shadow", Released = @"03 Jan 2019", Genre = @"ethno-tunes", Album = @"Here we go again" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Dream of Shadow", Released = @"19 Dec 2019", Genre = @"Electro house Electropop", Album = @"Here we go again" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Golden Fire", Released = @"20 Jan 2019", Genre = @"R&B", Album = @"Here we go again" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Running in the Light", Released = @"03 Jan 2020", Genre = @"Synth-pop R&B", Album = @"Here we go again" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Flying in the Heart", Released = @"17 Jan 2019", Genre = @"*", Album = @"Here we go again" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Fire of Storm", Released = @"26 Jan 2019", Genre = @"ethno-tunes", Album = @"Here we go again" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Calling in the Sky", Released = @"28 Oct 2019", Genre = @"Synth-pop R&B", Album = @"Here we go again" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Flying in the Shadow", Released = @"30 Mar 2019", Genre = @"ethno-tunes", Album = @"Here we go again" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Golden Dancing", Released = @"12 Oct 2019", Genre = @"ethno-tunes", Album = @"Here we go again" }}
             }}
         });
        this.Add(new SingersDataItem() { ID = 4, Artist = @"Mar Rueda", Photo = @"https://static.infragistics.com/xplatform/images/people/names/mar.jpg", Debut = 1996, GrammyNominations = 14, GrammyAwards = 2, HasGrammyAward = true, Tours = new List<SingersDataItem_ToursItem>()
        {
        }
        , Albums = new List<SingersDataItem_AlbumsItem>()
        {
        }
         });
        this.Add(new SingersDataItem() { ID = 5, Artist = @"Izabella Tabakova", Photo = @"https://static.infragistics.com/xplatform/images/people/names/izabella.jpg", Debut = 2017, GrammyNominations = 7, GrammyAwards = 11, HasGrammyAward = true, Tours = new List<SingersDataItem_ToursItem>()
        {
            new SingersDataItem_ToursItem() { Tour = @"Final breath", StartedOn = @"Jun 13", Location = @"Europe", Headliner = @"YES", TouredBy = @"Izabella Tabakova" },
            new SingersDataItem_ToursItem() { Tour = @"Once bitten", StartedOn = @"Dec 18", Location = @"Australia, United States", Headliner = @"NO", TouredBy = @"Izabella Tabakova" },
            new SingersDataItem_ToursItem() { Tour = @"Code word", StartedOn = @"Sep 19", Location = @"United States, Europe", Headliner = @"NO", TouredBy = @"Izabella Tabakova" },
            new SingersDataItem_ToursItem() { Tour = @"Final draft", StartedOn = @"Sep 17", Location = @"United States, Europe", Headliner = @"YES", TouredBy = @"Izabella Tabakova" }}
        , Albums = new List<SingersDataItem_AlbumsItem>()
        {
            new SingersDataItem_AlbumsItem() { Album = @"Once bitten", LaunchDate = @"July 16, 2007", BillboardReview = 79, USBillboard200 = 53, Artist = @"Izabella Tabakova", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Whole Lotta Super Cats", Released = @"21 May 2019", Genre = @"*", Album = @"Once bitten" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Enter Becky", Released = @"16 Jan 2020", Genre = @"*", Album = @"Once bitten" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Your Cheatin' Flamingo", Released = @"14 Jan 2020", Genre = @"*", Album = @"Once bitten" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Mad to Kiss", Released = @"6 Nov 2019", Genre = @"Synth-pop R&B", Album = @"Once bitten" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Hotel Prague", Released = @"20 Oct 2019", Genre = @"ethno-tunes", Album = @"Once bitten" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Jail on My Mind", Released = @"31 May 2019", Genre = @"Crunk reggaeton", Album = @"Once bitten" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Amazing Blues", Released = @"29 May 2019", Genre = @"mystical parody-bap ", Album = @"Once bitten" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Goody Two Iron Filings", Released = @"4 Jul 2019", Genre = @"Electro house Electropop", Album = @"Once bitten" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"I Love in Your Arms", Released = @"7 Jun 2019", Genre = @"R&B", Album = @"Once bitten" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Truly Madly Amazing", Released = @"12 Sep 2019", Genre = @"ethno-tunes", Album = @"Once bitten" }}
             },
            new SingersDataItem_AlbumsItem() { Album = @"Your graciousness", LaunchDate = @"November 17, 2004", BillboardReview = 69, USBillboard200 = 30, Artist = @"Izabella Tabakova", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"We Shall Tickle", Released = @"31 Aug 2019", Genre = @"old emo-garage ", Album = @"Your graciousness" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Snail Boogie", Released = @"14 Jun 2019", Genre = @"*", Album = @"Your graciousness" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Amazing Liz", Released = @"15 Oct 2019", Genre = @"*", Album = @"Your graciousness" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"When Sexy Aardvarks Cry", Released = @"1 Oct 2019", Genre = @"whimsical comedy-grass ", Album = @"Your graciousness" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Stand By Dave", Released = @"18 Aug 2019", Genre = @"unblack electronic-trip-hop", Album = @"Your graciousness" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"The Golf Course is Your Land", Released = @"2 Apr 2019", Genre = @"*", Album = @"Your graciousness" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Where Have All the Men Gone?", Released = @"29 Apr 2019", Genre = @"*", Album = @"Your graciousness" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Rhythm of the Leg", Released = @"5 Aug 2019", Genre = @"ethno-tunes", Album = @"Your graciousness" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Baby, I Need Your Hats", Released = @"5 Dec 2019", Genre = @"neuro-tunes", Album = @"Your graciousness" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Stand by Your Cat", Released = @"25 Jul 2019", Genre = @"*", Album = @"Your graciousness" }}
             },
            new SingersDataItem_AlbumsItem() { Album = @"Dark matters", LaunchDate = @"November 3, 2002", BillboardReview = 79, USBillboard200 = 85, Artist = @"Izabella Tabakova", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Hiding in the Light", Released = @"24 Jan 2019", Genre = @"Synth-pop R&B", Album = @"Dark matters" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Furious River", Released = @"13 Jan 2020", Genre = @"Electro house Electropop", Album = @"Dark matters" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Wild Crying", Released = @"27 Feb 2019", Genre = @"Electro house Electropop", Album = @"Dark matters" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Light of Dream", Released = @"01 Jun 2019", Genre = @"Crunk reggaeton", Album = @"Dark matters" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Light of Dream", Released = @"24 Aug 2019", Genre = @"*", Album = @"Dark matters" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Storm of Light", Released = @"26 Feb 2019", Genre = @"*", Album = @"Dark matters" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Dark Storm", Released = @"18 Jan 2020", Genre = @"R&B", Album = @"Dark matters" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Dark Calling", Released = @"20 Mar 2019", Genre = @"Crunk reggaeton", Album = @"Dark matters" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Sky of Whisper", Released = @"30 Jan 2019", Genre = @"ethno-tunes", Album = @"Dark matters" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Dancing in the Light", Released = @"28 Nov 2019", Genre = @"Synth-pop R&B", Album = @"Dark matters" }}
             }}
         });
        this.Add(new SingersDataItem() { ID = 6, Artist = @"Nguyễn Diệp Chi", Photo = @"https://static.infragistics.com/xplatform/images/people/names/nguyen.jpg", Debut = 1992, GrammyNominations = 4, GrammyAwards = 2, HasGrammyAward = true, Tours = new List<SingersDataItem_ToursItem>()
        {
        }
        , Albums = new List<SingersDataItem_AlbumsItem>()
        {
            new SingersDataItem_AlbumsItem() { Album = @"Library of liberty", LaunchDate = @"December 22, 2003", BillboardReview = 93, USBillboard200 = 5, Artist = @"Nguyễn Diệp Chi", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Echo of River", Released = @"05 Mar 2019", Genre = @"Synth-pop R&B", Album = @"Library of liberty" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Heart of River", Released = @"12 Jan 2020", Genre = @"Electro house Electropop", Album = @"Library of liberty" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Dark Light", Released = @"09 Aug 2019", Genre = @"Electro house Electropop", Album = @"Library of liberty" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Dark Fire", Released = @"22 Jun 2019", Genre = @"R&B", Album = @"Library of liberty" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Flying in the Fire", Released = @"22 Jul 2019", Genre = @"*", Album = @"Library of liberty" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Shadow of Heart", Released = @"02 Jan 2020", Genre = @"*", Album = @"Library of liberty" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Fire of Fire", Released = @"27 Jan 2019", Genre = @"*", Album = @"Library of liberty" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Falling in the River", Released = @"05 Aug 2019", Genre = @"Crunk reggaeton", Album = @"Library of liberty" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Fire of Light", Released = @"31 Dec 2019", Genre = @"ethno-tunes", Album = @"Library of liberty" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Bright Flying", Released = @"24 Jan 2019", Genre = @"*", Album = @"Library of liberty" }}
             }}
         });
        this.Add(new SingersDataItem() { ID = 7, Artist = @"Eva Lee", Photo = @"https://static.infragistics.com/xplatform/images/people/names/eva.jpg", Debut = 2008, GrammyNominations = 2, GrammyAwards = 0, HasGrammyAward = false, Tours = new List<SingersDataItem_ToursItem>()
        {
        }
        , Albums = new List<SingersDataItem_AlbumsItem>()
        {
            new SingersDataItem_AlbumsItem() { Album = @"Just a tease", LaunchDate = @"May 3, 2001", BillboardReview = 91, USBillboard200 = 29, Artist = @"Eva Lee", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Dancing in the Shadow", Released = @"02 Aug 2019", Genre = @"ethno-tunes", Album = @"Just a tease" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Silent Whisper", Released = @"09 Jul 2019", Genre = @"*", Album = @"Just a tease" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Crying in the Whisper", Released = @"30 May 2019", Genre = @"Crunk reggaeton", Album = @"Just a tease" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"River of Light", Released = @"10 Jan 2019", Genre = @"Electro house Electropop", Album = @"Just a tease" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Golden River", Released = @"15 Nov 2019", Genre = @"*", Album = @"Just a tease" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Burning in the Shadow", Released = @"18 Apr 2019", Genre = @"Crunk reggaeton", Album = @"Just a tease" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Shadow of Sky", Released = @"06 Sep 2019", Genre = @"Crunk reggaeton", Album = @"Just a tease" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Gentle Waiting", Released = @"05 Dec 2019", Genre = @"R&B", Album = @"Just a tease" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Bright River", Released = @"27 Jan 2020", Genre = @"R&B", Album = @"Just a tease" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Heart of Storm", Released = @"07 Jan 2019", Genre = @"Synth-pop R&B", Album = @"Just a tease" }}
             }}
         });
        this.Add(new SingersDataItem() { ID = 8, Artist = @"Siri Jakobsson", Photo = @"https://static.infragistics.com/xplatform/images/people/names/siri.jpg", Debut = 1990, GrammyNominations = 2, GrammyAwards = 8, HasGrammyAward = true, Tours = new List<SingersDataItem_ToursItem>()
        {
            new SingersDataItem_ToursItem() { Tour = @"Basket case", StartedOn = @"Jan 07", Location = @"Europe, Asia", Headliner = @"NO", TouredBy = @"Siri Jakobsson" },
            new SingersDataItem_ToursItem() { Tour = @"The bigger fish", StartedOn = @"Dec 07", Location = @"United States, Europe", Headliner = @"YES", TouredBy = @"Siri Jakobsson" },
            new SingersDataItem_ToursItem() { Tour = @"Missed the boat", StartedOn = @"Jun 09", Location = @"Europe, Asia", Headliner = @"NO", TouredBy = @"Siri Jakobsson" },
            new SingersDataItem_ToursItem() { Tour = @"Equivalent exchange", StartedOn = @"Feb 06", Location = @"United States, Europe", Headliner = @"YES", TouredBy = @"Siri Jakobsson" },
            new SingersDataItem_ToursItem() { Tour = @"Damage control", StartedOn = @"Oct 11", Location = @"Australia, United States", Headliner = @"NO", TouredBy = @"Siri Jakobsson" }}
        , Albums = new List<SingersDataItem_AlbumsItem>()
        {
            new SingersDataItem_AlbumsItem() { Album = @"Under the bus", LaunchDate = @"May 14, 2000", BillboardReview = 67, USBillboard200 = 67, Artist = @"Siri Jakobsson", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Jack Broke My Heart At Tesco's", Released = @"19 Jan 2020", Genre = @"*", Album = @"Under the bus" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Cat Deep, Hats High", Released = @"5 Dec 2019", Genre = @"*", Album = @"Under the bus" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"In Snail We Trust", Released = @"31 May 2019", Genre = @"hardcore opera", Album = @"Under the bus" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Liz's Waiting", Released = @"22 Jul 2019", Genre = @"emotional C-jam ", Album = @"Under the bus" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Lifeless Blues", Released = @"14 Jun 2019", Genre = @"*", Album = @"Under the bus" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"I Spin", Released = @"26 Mar 2019", Genre = @"*", Album = @"Under the bus" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Ring of Rock", Released = @"12 Dec 2019", Genre = @"*", Album = @"Under the bus" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Livin' on a Rock", Released = @"17 Apr 2019", Genre = @"*", Album = @"Under the bus" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Your Lifeless Heart", Released = @"15 Sep 2019", Genre = @"adult calypso-industrial", Album = @"Under the bus" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"The High Street on My Mind", Released = @"11 Nov 2019", Genre = @"calypso and mariachi", Album = @"Under the bus" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 11, Title = @"Behind Ugly Curtains", Released = @"8 May 2019", Genre = @"*", Album = @"Under the bus" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 12, Title = @"Where Have All the Curtains Gone?", Released = @"28 Jun 2019", Genre = @"*", Album = @"Under the bus" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 13, Title = @"Ghost in My Apple", Released = @"14 Dec 2019", Genre = @"*", Album = @"Under the bus" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 14, Title = @"I Chatter", Released = @"30 Nov 2019", Genre = @"*", Album = @"Under the bus" }}
             }}
         });
        this.Add(new SingersDataItem() { ID = 9, Artist = @"Pablo Cambeiro", Photo = @"https://static.infragistics.com/xplatform/images/people/names/pablo.jpg", Debut = 2011, GrammyNominations = 5, GrammyAwards = 0, HasGrammyAward = false, Tours = new List<SingersDataItem_ToursItem>()
        {
            new SingersDataItem_ToursItem() { Tour = @"Beads", StartedOn = @"May 11", Location = @"Worldwide", Headliner = @"NO", TouredBy = @"Pablo Cambeiro" },
            new SingersDataItem_ToursItem() { Tour = @"Concept art", StartedOn = @"Dec 18", Location = @"United States", Headliner = @"YES", TouredBy = @"Pablo Cambeiro" },
            new SingersDataItem_ToursItem() { Tour = @"Glass shoe", StartedOn = @"Jan 20", Location = @"Worldwide", Headliner = @"YES", TouredBy = @"Pablo Cambeiro" },
            new SingersDataItem_ToursItem() { Tour = @"Pushing buttons", StartedOn = @"Feb 15", Location = @"Europe, Asia", Headliner = @"NO", TouredBy = @"Pablo Cambeiro" },
            new SingersDataItem_ToursItem() { Tour = @"Dark matters", StartedOn = @"Jan 04", Location = @"Australia, United States", Headliner = @"YES", TouredBy = @"Pablo Cambeiro" },
            new SingersDataItem_ToursItem() { Tour = @"Greener grass", StartedOn = @"Sep 09", Location = @"United States, Europe", Headliner = @"NO", TouredBy = @"Pablo Cambeiro" },
            new SingersDataItem_ToursItem() { Tour = @"Apparatus", StartedOn = @"Nov 16", Location = @"Europe", Headliner = @"NO", TouredBy = @"Pablo Cambeiro" }}
        , Albums = new List<SingersDataItem_AlbumsItem>()
        {
            new SingersDataItem_AlbumsItem() { Album = @"Fluke", LaunchDate = @"August 4, 2017", BillboardReview = 93, USBillboard200 = 98, Artist = @"Pablo Cambeiro", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Dancing in the Echo", Released = @"03 Oct 2019", Genre = @"Crunk reggaeton", Album = @"Fluke" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Dream of Dream", Released = @"03 Mar 2019", Genre = @"*", Album = @"Fluke" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Calling in the Echo", Released = @"16 Sep 2019", Genre = @"*", Album = @"Fluke" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Light of Light", Released = @"25 May 2019", Genre = @"Electro house Electropop", Album = @"Fluke" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Bright Light", Released = @"21 Mar 2019", Genre = @"R&B", Album = @"Fluke" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Storm of Echo", Released = @"17 Jul 2019", Genre = @"Synth-pop R&B", Album = @"Fluke" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Lonely Calling", Released = @"10 Apr 2019", Genre = @"ethno-tunes", Album = @"Fluke" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Gentle Falling", Released = @"28 Nov 2019", Genre = @"Synth-pop R&B", Album = @"Fluke" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Wild Flying", Released = @"26 Nov 2019", Genre = @"Crunk reggaeton", Album = @"Fluke" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Sky of Dream", Released = @"29 May 2019", Genre = @"R&B", Album = @"Fluke" }}
             },
            new SingersDataItem_AlbumsItem() { Album = @"Crowd control", LaunchDate = @"August 26, 2003", BillboardReview = 68, USBillboard200 = 84, Artist = @"Pablo Cambeiro", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"My Bed on My Mind", Released = @"25 Mar 2019", Genre = @"ethno-tunes", Album = @"Crowd control" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Bright Blues", Released = @"28 Sep 2019", Genre = @"neuro-tunes", Album = @"Crowd control" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Sail, Sail, Sail!", Released = @"5 Mar 2019", Genre = @"*", Album = @"Crowd control" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Hotel My Bed", Released = @"22 Mar 2019", Genre = @"*", Album = @"Crowd control" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Gonna Make You Mash", Released = @"18 May 2019", Genre = @"*", Album = @"Crowd control" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Straight Outta America", Released = @"16 Jan 2020", Genre = @"hardcore opera", Album = @"Crowd control" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"I Drive", Released = @"23 Feb 2019", Genre = @"emotional C-jam ", Album = @"Crowd control" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Like a Teddy", Released = @"31 Aug 2019", Genre = @"*", Album = @"Crowd control" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Teddy Boogie", Released = @"30 Nov 2019", Genre = @"*", Album = @"Crowd control" }}
             }}
         });
        this.Add(new SingersDataItem() { ID = 10, Artist = @"Athar Malakooti", Photo = @"https://static.infragistics.com/xplatform/images/people/names/athar.jpg", Debut = 2017, GrammyNominations = 0, GrammyAwards = 0, HasGrammyAward = false, Tours = new List<SingersDataItem_ToursItem>()
        {
        }
        , Albums = new List<SingersDataItem_AlbumsItem>()
        {
            new SingersDataItem_AlbumsItem() { Album = @"Pushing up daisies", LaunchDate = @"February 24, 2016", BillboardReview = 74, USBillboard200 = 77, Artist = @"Athar Malakooti", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Hiding in the Whisper", Released = @"03 Apr 2019", Genre = @"R&B", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Wicked Light", Released = @"21 Aug 2019", Genre = @"R&B", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Flying in the River", Released = @"03 Feb 2020", Genre = @"Synth-pop R&B", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Wicked Hiding", Released = @"15 Sep 2019", Genre = @"Synth-pop R&B", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Lonely Light", Released = @"13 May 2019", Genre = @"Electro house Electropop", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Bright Dancing", Released = @"10 Apr 2019", Genre = @"Synth-pop R&B", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Gentle Dream", Released = @"21 May 2019", Genre = @"*", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Sky of Echo", Released = @"09 Jun 2019", Genre = @"Synth-pop R&B", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Breaking in the Sky", Released = @"27 Dec 2019", Genre = @"Crunk reggaeton", Album = @"Pushing up daisies" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Whisper of Shadow", Released = @"04 Jan 2019", Genre = @"ethno-tunes", Album = @"Pushing up daisies" }}
             }}
         });
        this.Add(new SingersDataItem() { ID = 11, Artist = @"Marti Valencia", Photo = @"https://static.infragistics.com/xplatform/images/people/names/marti.jpg", Debut = 2004, GrammyNominations = 1, GrammyAwards = 1, HasGrammyAward = true, Tours = new List<SingersDataItem_ToursItem>()
        {
            new SingersDataItem_ToursItem() { Tour = @"Cat eat cat world", StartedOn = @"Sep 00", Location = @"Worldwide", Headliner = @"YES", TouredBy = @"Marti Valencia" },
            new SingersDataItem_ToursItem() { Tour = @"Final straw", StartedOn = @"Sep 06", Location = @"United States, Europe", Headliner = @"NO", TouredBy = @"Marti Valencia" }}
        , Albums = new List<SingersDataItem_AlbumsItem>()
        {
            new SingersDataItem_AlbumsItem() { Album = @"Nemesis", LaunchDate = @"June 30, 2004", BillboardReview = 94, USBillboard200 = 9, Artist = @"Marti Valencia", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Hiding in the Sky", Released = @"26 Nov 2019", Genre = @"Synth-pop R&B", Album = @"Nemesis" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Waiting in the Echo", Released = @"10 Jul 2019", Genre = @"ethno-tunes", Album = @"Nemesis" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Wicked Shadow", Released = @"29 Jul 2019", Genre = @"Synth-pop R&B", Album = @"Nemesis" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Crying in the Whisper", Released = @"09 Apr 2019", Genre = @"*", Album = @"Nemesis" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Echo of Storm", Released = @"19 Nov 2019", Genre = @"Crunk reggaeton", Album = @"Nemesis" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Shadow of Sky", Released = @"24 Jul 2019", Genre = @"Crunk reggaeton", Album = @"Nemesis" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Golden Hiding", Released = @"12 Dec 2019", Genre = @"Electro house Electropop", Album = @"Nemesis" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Wild Dancing", Released = @"17 Aug 2019", Genre = @"Synth-pop R&B", Album = @"Nemesis" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Bright Burning", Released = @"30 Aug 2019", Genre = @"Electro house Electropop", Album = @"Nemesis" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Flying in the River", Released = @"02 Sep 2019", Genre = @"*", Album = @"Nemesis" }}
             },
            new SingersDataItem_AlbumsItem() { Album = @"First chance", LaunchDate = @"January 7, 2019", BillboardReview = 96, USBillboard200 = 19, Artist = @"Marti Valencia", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"My Name is Jason", Released = @"12 Jul 2019", Genre = @"*", Album = @"First chance" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Amazing Andy", Released = @"5 Mar 2019", Genre = @"*", Album = @"First chance" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"The Number of your Knight", Released = @"4 Dec 2019", Genre = @"*", Album = @"First chance" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"I Sail", Released = @"3 Mar 2019", Genre = @"*", Album = @"First chance" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Goody Two Hands", Released = @"11 Oct 2019", Genre = @"Electro house Electropop", Album = @"First chance" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Careful With That Knife", Released = @"18 Dec 2019", Genre = @"R&B", Album = @"First chance" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Four Single Ants", Released = @"18 Jan 2020", Genre = @"*", Album = @"First chance" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Kiss Forever", Released = @"10 Aug 2019", Genre = @"*", Album = @"First chance" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Rich's Waiting", Released = @"15 Mar 2019", Genre = @"Synth-pop R&B", Album = @"First chance" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Japan is Your Land", Released = @"7 Mar 2019", Genre = @"ethno-tunes", Album = @"First chance" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 11, Title = @"Pencils in My Banana", Released = @"21 Jun 2019", Genre = @"Crunk reggaeton", Album = @"First chance" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 12, Title = @"I Sail in Your Arms", Released = @"30 Apr 2019", Genre = @"Synth-pop R&B", Album = @"First chance" }}
             },
            new SingersDataItem_AlbumsItem() { Album = @"God's advocate", LaunchDate = @"April 29, 2007", BillboardReview = 66, USBillboard200 = 37, Artist = @"Marti Valencia", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Wild River", Released = @"11 Jan 2019", Genre = @"*", Album = @"God's advocate" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Wicked Whisper", Released = @"16 Feb 2019", Genre = @"Electro house Electropop", Album = @"God's advocate" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Storm of Heart", Released = @"11 Aug 2019", Genre = @"*", Album = @"God's advocate" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Golden Dancing", Released = @"02 Mar 2019", Genre = @"Crunk reggaeton", Album = @"God's advocate" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Calling in the Sky", Released = @"10 Sep 2019", Genre = @"Electro house Electropop", Album = @"God's advocate" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Calling in the Heart", Released = @"12 Jan 2019", Genre = @"ethno-tunes", Album = @"God's advocate" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Running in the Storm", Released = @"10 Nov 2019", Genre = @"Synth-pop R&B", Album = @"God's advocate" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Wild Sky", Released = @"10 Apr 2019", Genre = @"R&B", Album = @"God's advocate" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Crying in the Shadow", Released = @"02 Mar 2019", Genre = @"R&B", Album = @"God's advocate" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Whisper of River", Released = @"12 May 2019", Genre = @"*", Album = @"God's advocate" }}
             }}
         });
        this.Add(new SingersDataItem() { ID = 12, Artist = @"Alicia Stanger", Photo = @"https://static.infragistics.com/xplatform/images/people/names/alicia.jpg", Debut = 2010, GrammyNominations = 1, GrammyAwards = 0, HasGrammyAward = false, Tours = new List<SingersDataItem_ToursItem>()
        {
        }
        , Albums = new List<SingersDataItem_AlbumsItem>()
        {
            new SingersDataItem_AlbumsItem() { Album = @"Forever alone", LaunchDate = @"November 3, 2005", BillboardReview = 82, USBillboard200 = 7, Artist = @"Alicia Stanger", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Shadow of Light", Released = @"24 Mar 2019", Genre = @"ethno-tunes", Album = @"Forever alone" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Running in the Echo", Released = @"03 May 2019", Genre = @"Crunk reggaeton", Album = @"Forever alone" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Gentle Dream", Released = @"24 Aug 2019", Genre = @"Crunk reggaeton", Album = @"Forever alone" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Furious River", Released = @"24 Apr 2019", Genre = @"ethno-tunes", Album = @"Forever alone" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Wild Whisper", Released = @"09 Mar 2019", Genre = @"ethno-tunes", Album = @"Forever alone" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Whisper of Sky", Released = @"24 Jul 2019", Genre = @"Crunk reggaeton", Album = @"Forever alone" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Lonely Storm", Released = @"01 May 2019", Genre = @"Crunk reggaeton", Album = @"Forever alone" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Dancing in the River", Released = @"17 Dec 2019", Genre = @"*", Album = @"Forever alone" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Electric Fire", Released = @"17 Oct 2019", Genre = @"Electro house Electropop", Album = @"Forever alone" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Electric Sky", Released = @"25 Sep 2019", Genre = @"ethno-tunes", Album = @"Forever alone" }}
             }}
         });
        this.Add(new SingersDataItem() { ID = 13, Artist = @"Peter Taylor", Photo = @"https://static.infragistics.com/xplatform/images/people/names/peter.jpg", Debut = 2005, GrammyNominations = 0, GrammyAwards = 2, HasGrammyAward = true, Tours = new List<SingersDataItem_ToursItem>()
        {
            new SingersDataItem_ToursItem() { Tour = @"Love", StartedOn = @"Jun 04", Location = @"Europe, Asia", Headliner = @"YES", TouredBy = @"Peter Taylor" },
            new SingersDataItem_ToursItem() { Tour = @"Fault of treasures", StartedOn = @"Oct 13", Location = @"North America", Headliner = @"NO", TouredBy = @"Peter Taylor" },
            new SingersDataItem_ToursItem() { Tour = @"For eternity", StartedOn = @"Mar 05", Location = @"United States", Headliner = @"YES", TouredBy = @"Peter Taylor" },
            new SingersDataItem_ToursItem() { Tour = @"Time flies", StartedOn = @"Jun 03", Location = @"North America", Headliner = @"NO", TouredBy = @"Peter Taylor" },
            new SingersDataItem_ToursItem() { Tour = @"Highest difficulty", StartedOn = @"Nov 01", Location = @"Worldwide", Headliner = @"YES", TouredBy = @"Peter Taylor" },
            new SingersDataItem_ToursItem() { Tour = @"Sleeping dogs", StartedOn = @"May 04", Location = @"United States, Europe", Headliner = @"NO", TouredBy = @"Peter Taylor" }}
        , Albums = new List<SingersDataItem_AlbumsItem>()
        {
            new SingersDataItem_AlbumsItem() { Album = @"Decisions decisions", LaunchDate = @"April 10, 2008", BillboardReview = 85, USBillboard200 = 35, Artist = @"Peter Taylor", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Calling in the Dream", Released = @"01 Aug 2019", Genre = @"R&B", Album = @"Decisions decisions" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Electric Burning", Released = @"10 Sep 2019", Genre = @"Electro house Electropop", Album = @"Decisions decisions" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Dark Flying", Released = @"28 Apr 2019", Genre = @"*", Album = @"Decisions decisions" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Gentle Sky", Released = @"20 Nov 2019", Genre = @"ethno-tunes", Album = @"Decisions decisions" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Gentle Calling", Released = @"13 Jan 2019", Genre = @"Crunk reggaeton", Album = @"Decisions decisions" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Golden Falling", Released = @"14 Feb 2019", Genre = @"Crunk reggaeton", Album = @"Decisions decisions" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Silent River", Released = @"13 Feb 2019", Genre = @"R&B", Album = @"Decisions decisions" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Furious Calling", Released = @"11 Jun 2019", Genre = @"Synth-pop R&B", Album = @"Decisions decisions" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Running in the Echo", Released = @"06 Nov 2019", Genre = @"Electro house Electropop", Album = @"Decisions decisions" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Furious River", Released = @"12 Mar 2019", Genre = @"*", Album = @"Decisions decisions" }}
             },
            new SingersDataItem_AlbumsItem() { Album = @"Climate changed", LaunchDate = @"June 20, 2015", BillboardReview = 66, USBillboard200 = 89, Artist = @"Peter Taylor", Songs = new List<SingersDataItem_AlbumsItem_SongsItem>()
            {
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 1, Title = @"Dark Crying", Released = @"27 Apr 2019", Genre = @"Electro house Electropop", Album = @"Climate changed" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 2, Title = @"Dark Waiting", Released = @"14 Nov 2019", Genre = @"Synth-pop R&B", Album = @"Climate changed" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 3, Title = @"Furious Waiting", Released = @"23 May 2019", Genre = @"*", Album = @"Climate changed" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 4, Title = @"Running in the Echo", Released = @"29 Nov 2019", Genre = @"Crunk reggaeton", Album = @"Climate changed" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 5, Title = @"Dream of Sky", Released = @"31 Oct 2019", Genre = @"Crunk reggaeton", Album = @"Climate changed" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 6, Title = @"Hiding in the Heart", Released = @"09 Aug 2019", Genre = @"R&B", Album = @"Climate changed" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 7, Title = @"Sky of Storm", Released = @"01 Jun 2019", Genre = @"R&B", Album = @"Climate changed" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 8, Title = @"Light of Storm", Released = @"17 Jan 2020", Genre = @"ethno-tunes", Album = @"Climate changed" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 9, Title = @"Light of Sky", Released = @"26 May 2019", Genre = @"*", Album = @"Climate changed" },
                new SingersDataItem_AlbumsItem_SongsItem() { Number = 10, Title = @"Golden River", Released = @"19 Jun 2019", Genre = @"*", Album = @"Climate changed" }}
             }}
         });
    }
}
