﻿using System.Collections.ObjectModel;

namespace Infragistics.Samples
{
    public class AthleteItem
    {
        public int Id { get; set; }
        public string Avatar { get; set; }
        public string Position { get; set; }
        public string Name { get; set; }
        public int AthleteNumber { get; set; }
        public int BeatsPerMinute { get; set; }
        public double TopSpeed { get; set; }
        public string Registered { get; set; }
        public int TrackProgress { get; set; }
        public string CountryFlag { get; set; }
        public string CountryName { get; set; }
    }

    public class AthletesData : ObservableCollection<AthleteItem>
    {
        public AthletesData()
        {
            this.Add(new AthleteItem()
            {
                Id = 84,
                Avatar = "assets/images/men/12.jpg",
                Position = "current",
                Name = "Abel Brun",
                AthleteNumber = 39315,
                BeatsPerMinute = 105,
                TopSpeed = 5.1,
                Registered = "2017-10-05T05:54:31 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/af.png",
                CountryName = "Afghanistan"
            }); this.Add(new AthleteItem()
            {
                Id = 65,
                Avatar = "assets/images/women/60.jpg",
                Position = "down",
                Name = "Keira Walker",
                AthleteNumber = 34116,
                BeatsPerMinute = 94,
                TopSpeed = 4.8,
                Registered = "2017-01-09T05:46:07 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/al.png",
                CountryName = "Albania"
            }); this.Add(new AthleteItem()
            {
                Id = 197,
                Avatar = "assets/images/men/93.jpg",
                Position = "current",
                Name = "Brent Lord",
                AthleteNumber = 20943,
                BeatsPerMinute = 92,
                TopSpeed = 4.8,
                Registered = "2017-01-23T06:14:22 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/dz.png",
                CountryName = "Algeria"
            }); this.Add(new AthleteItem()
            {
                Id = 66,
                Avatar = "assets/images/men/70.jpg",
                Position = "down",
                Name = "Moritz Braun",
                AthleteNumber = 48081,
                BeatsPerMinute = 107,
                TopSpeed = 6,
                Registered = "2017-06-13T12:54:56 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/ad.png",
                CountryName = "Andorra"
            }); this.Add(new AthleteItem()
            {
                Id = 58,
                Avatar = "assets/images/women/60.jpg",
                Position = "down",
                Name = "Zaina Pomp",
                AthleteNumber = 14109,
                BeatsPerMinute = 90,
                TopSpeed = 5.7,
                Registered = "2017-09-07T11:17:40 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ao.png",
                CountryName = "Angola"
            }); this.Add(new AthleteItem()
            {
                Id = 40,
                Avatar = "assets/images/men/33.jpg",
                Position = "down",
                Name = "Alberto Clark",
                AthleteNumber = 29912,
                BeatsPerMinute = 93,
                TopSpeed = 4.6,
                Registered = "2017-02-02T03:50:21 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ag.png",
                CountryName = "Antigua and Barbuda"
            }); this.Add(new AthleteItem()
            {
                Id = 138,
                Avatar = "assets/images/men/38.jpg",
                Position = "current",
                Name = "Derrick Price",
                AthleteNumber = 19792,
                BeatsPerMinute = 94,
                TopSpeed = 5.6,
                Registered = "2017-03-19T01:10:55 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/ar.png",
                CountryName = "Argentina"
            }); this.Add(new AthleteItem()
            {
                Id = 6,
                Avatar = "assets/images/women/26.jpg",
                Position = "up",
                Name = "Mira Campos",
                AthleteNumber = 39222,
                BeatsPerMinute = 95,
                TopSpeed = 5.9,
                Registered = "2017-01-11T01:41:31 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/am.png",
                CountryName = "Armenia"
            }); this.Add(new AthleteItem()
            {
                Id = 190,
                Avatar = "assets/images/women/44.jpg",
                Position = "current",
                Name = "Kiara Dubois",
                AthleteNumber = 49964,
                BeatsPerMinute = 97,
                TopSpeed = 5.6,
                Registered = "2017-09-28T04:37:56 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/au.png",
                CountryName = "Australia"
            }); this.Add(new AthleteItem()
            {
                Id = 168,
                Avatar = "assets/images/men/10.jpg",
                Position = "current",
                Name = "Calvin Hunt",
                AthleteNumber = 35535,
                BeatsPerMinute = 94,
                TopSpeed = 4.5,
                Registered = "2017-11-07T09:58:42 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/at.png",
                CountryName = "Austria"
            }); this.Add(new AthleteItem()
            {
                Id = 105,
                Avatar = "assets/images/men/5.jpg",
                Position = "down",
                Name = "Samu Hokkanen",
                AthleteNumber = 22469,
                BeatsPerMinute = 106,
                TopSpeed = 5.5,
                Registered = "2017-06-29T04:58:27 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/az.png",
                CountryName = "Azerbaijan"
            }); this.Add(new AthleteItem()
            {
                Id = 33,
                Avatar = "assets/images/men/18.jpg",
                Position = "up",
                Name = "Zackary Roy",
                AthleteNumber = 45996,
                BeatsPerMinute = 92,
                TopSpeed = 4.9,
                Registered = "2017-07-07T03:51:26 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/bs.png",
                CountryName = "Bahamas"
            }); this.Add(new AthleteItem()
            {
                Id = 83,
                Avatar = "assets/images/men/10.jpg",
                Position = "current",
                Name = "سینا مرادی",
                AthleteNumber = 10809,
                BeatsPerMinute = 105,
                TopSpeed = 5.3,
                Registered = "2017-04-05T05:27:13 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/bh.png",
                CountryName = "Bahrain"
            }); this.Add(new AthleteItem()
            {
                Id = 121,
                Avatar = "assets/images/men/45.jpg",
                Position = "current",
                Name = "Maurice Lambert",
                AthleteNumber = 17443,
                BeatsPerMinute = 96,
                TopSpeed = 5.6,
                Registered = "2017-06-05T08:19:32 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/bd.png",
                CountryName = "Bangladesh"
            }); this.Add(new AthleteItem()
            {
                Id = 111,
                Avatar = "assets/images/men/23.jpg",
                Position = "up",
                Name = "Connor Green",
                AthleteNumber = 44716,
                BeatsPerMinute = 95,
                TopSpeed = 4.4,
                Registered = "2017-06-30T11:23:25 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/bb.png",
                CountryName = "Barbados"
            }); this.Add(new AthleteItem()
            {
                Id = 75,
                Avatar = "assets/images/women/69.jpg",
                Position = "current",
                Name = "Ellen Leppo",
                AthleteNumber = 29286,
                BeatsPerMinute = 97,
                TopSpeed = 5.6,
                Registered = "2017-08-16T09:46:35 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/by.png",
                CountryName = "Belarus"
            }); this.Add(new AthleteItem()
            {
                Id = 68,
                Avatar = "assets/images/men/23.jpg",
                Position = "up",
                Name = "Sandro Carpentier",
                AthleteNumber = 23503,
                BeatsPerMinute = 96,
                TopSpeed = 5.7,
                Registered = "2017-09-30T01:01:04 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/be.png",
                CountryName = "Belgium"
            }); this.Add(new AthleteItem()
            {
                Id = 150,
                Avatar = "assets/images/men/52.jpg",
                Position = "up",
                Name = "Gustav Petersen",
                AthleteNumber = 20984,
                BeatsPerMinute = 107,
                TopSpeed = 4.6,
                Registered = "2017-01-01T07:40:19 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/bz.png",
                CountryName = "Belize"
            }); this.Add(new AthleteItem()
            {
                Id = 142,
                Avatar = "assets/images/women/63.jpg",
                Position = "current",
                Name = "Nicoline Thomsen",
                AthleteNumber = 36778,
                BeatsPerMinute = 99,
                TopSpeed = 5.5,
                Registered = "2017-03-26T10:04:29 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/bj.png",
                CountryName = "Benin"
            }); this.Add(new AthleteItem()
            {
                Id = 19,
                Avatar = "assets/images/women/6.jpg",
                Position = "current",
                Name = "Sedef Tunçeri",
                AthleteNumber = 48164,
                BeatsPerMinute = 108,
                TopSpeed = 5.6,
                Registered = "2017-03-29T11:54:15 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/bt.png",
                CountryName = "Bhutan"
            }); this.Add(new AthleteItem()
            {
                Id = 202,
                Avatar = "assets/images/women/92.jpg",
                Position = "down",
                Name = "Ilona Salonen",
                AthleteNumber = 27068,
                BeatsPerMinute = 91,
                TopSpeed = 5.4,
                Registered = "2017-07-03T06:19:47 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/bo.png",
                CountryName = "Bolivia"
            }); this.Add(new AthleteItem()
            {
                Id = 191,
                Avatar = "assets/images/women/72.jpg",
                Position = "up",
                Name = "Clarisse Rey",
                AthleteNumber = 29795,
                BeatsPerMinute = 98,
                TopSpeed = 4.9,
                Registered = "2017-06-09T08:07:19 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ba.png",
                CountryName = "Bosnia and Herzegovina"
            }); this.Add(new AthleteItem()
            {
                Id = 71,
                Avatar = "assets/images/men/74.jpg",
                Position = "down",
                Name = "Jimmie Mcguinness",
                AthleteNumber = 20729,
                BeatsPerMinute = 90,
                TopSpeed = 4.6,
                Registered = "2017-10-07T06:08:00 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/bw.png",
                CountryName = "Botswana"
            }); this.Add(new AthleteItem()
            {
                Id = 82,
                Avatar = "assets/images/men/55.jpg",
                Position = "current",
                Name = "Johann Fischer",
                AthleteNumber = 37212,
                BeatsPerMinute = 98,
                TopSpeed = 5.8,
                Registered = "2017-09-01T04:39:52 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/br.png",
                CountryName = "Brazil"
            }); this.Add(new AthleteItem()
            {
                Id = 121,
                Avatar = "assets/images/men/31.jpg",
                Position = "down",
                Name = "Ivan Ivanov",
                AthleteNumber = 11054,
                BeatsPerMinute = 108,
                TopSpeed = 5.7,
                Registered = "2017-04-18T08:03:01 -03:00",
                TrackProgress = 5,
                CountryFlag = "assets/images/grid/flags/bg.png",
                CountryName = "Bulgaria"
            }); this.Add(new AthleteItem()
            {
                Id = 144,
                Avatar = "assets/images/women/57.jpg",
                Position = "down",
                Name = "Milja Leino",
                AthleteNumber = 33563,
                BeatsPerMinute = 110,
                TopSpeed = 4.1,
                Registered = "2017-11-01T10:34:07 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/bf.png",
                CountryName = "Burkina Faso"
            }); this.Add(new AthleteItem()
            {
                Id = 71,
                Avatar = "assets/images/men/81.jpg",
                Position = "down",
                Name = "آراد جعفری",
                AthleteNumber = 34962,
                BeatsPerMinute = 90,
                TopSpeed = 4.8,
                Registered = "2017-04-22T04:20:39 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/bi.png",
                CountryName = "Burundi"
            }); this.Add(new AthleteItem()
            {
                Id = 163,
                Avatar = "assets/images/women/21.jpg",
                Position = "up",
                Name = "Pippa Roberts",
                AthleteNumber = 15588,
                BeatsPerMinute = 105,
                TopSpeed = 4.1,
                Registered = "2017-02-07T10:23:13 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/kh.png",
                CountryName = "Cambodia"
            }); this.Add(new AthleteItem()
            {
                Id = 122,
                Avatar = "assets/images/men/57.jpg",
                Position = "down",
                Name = "Jack Jean-baptiste",
                AthleteNumber = 40427,
                BeatsPerMinute = 110,
                TopSpeed = 4.3,
                Registered = "2017-11-09T08:50:06 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/cm.png",
                CountryName = "Cameroon"
            }); this.Add(new AthleteItem()
            {
                Id = 199,
                Avatar = "assets/images/women/68.jpg",
                Position = "up",
                Name = "Lucie Dumont",
                AthleteNumber = 12104,
                BeatsPerMinute = 108,
                TopSpeed = 4,
                Registered = "2017-01-08T02:13:29 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ca.png",
                CountryName = "Canada"
            }); this.Add(new AthleteItem()
            {
                Id = 136,
                Avatar = "assets/images/women/10.jpg",
                Position = "down",
                Name = "Elaine Matthews",
                AthleteNumber = 38574,
                BeatsPerMinute = 110,
                TopSpeed = 5.5,
                Registered = "2017-01-26T11:50:00 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/cv.png",
                CountryName = "Cape Verde"
            }); this.Add(new AthleteItem()
            {
                Id = 70,
                Avatar = "assets/images/women/14.jpg",
                Position = "up",
                Name = "Emily Olsen",
                AthleteNumber = 13887,
                BeatsPerMinute = 110,
                TopSpeed = 4.8,
                Registered = "2017-10-03T08:01:40 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/cf.png",
                CountryName = "Central African Republic"
            }); this.Add(new AthleteItem()
            {
                Id = 21,
                Avatar = "assets/images/men/73.jpg",
                Position = "down",
                Name = "Kuzey Aclan",
                AthleteNumber = 18583,
                BeatsPerMinute = 102,
                TopSpeed = 5.3,
                Registered = "2017-09-12T09:14:14 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/td.png",
                CountryName = "Chad"
            }); this.Add(new AthleteItem()
            {
                Id = 86,
                Avatar = "assets/images/women/82.jpg",
                Position = "current",
                Name = "Eloida Novaes",
                AthleteNumber = 30751,
                BeatsPerMinute = 107,
                TopSpeed = 4.2,
                Registered = "2017-01-02T01:04:04 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/cl.png",
                CountryName = "Chile"
            }); this.Add(new AthleteItem()
            {
                Id = 130,
                Avatar = "assets/images/women/24.jpg",
                Position = "down",
                Name = "آوا احمدی",
                AthleteNumber = 44347,
                BeatsPerMinute = 110,
                TopSpeed = 4.1,
                Registered = "2017-06-04T09:04:31 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/cn.png",
                CountryName = "China"
            }); this.Add(new AthleteItem()
            {
                Id = 127,
                Avatar = "assets/images/men/52.jpg",
                Position = "down",
                Name = "Gerardo Soto",
                AthleteNumber = 22958,
                BeatsPerMinute = 90,
                TopSpeed = 5,
                Registered = "2017-06-04T12:52:03 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/co.png",
                CountryName = "Colombia"
            }); this.Add(new AthleteItem()
            {
                Id = 125,
                Avatar = "assets/images/women/16.jpg",
                Position = "current",
                Name = "Altiva Alves",
                AthleteNumber = 31850,
                BeatsPerMinute = 106,
                TopSpeed = 5.1,
                Registered = "2017-11-09T02:43:54 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/km.png",
                CountryName = "Comoros"
            }); this.Add(new AthleteItem()
            {
                Id = 38,
                Avatar = "assets/images/women/17.jpg",
                Position = "current",
                Name = "Charlotte Meyer",
                AthleteNumber = 21442,
                BeatsPerMinute = 110,
                TopSpeed = 4.6,
                Registered = "2017-10-19T10:38:35 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/ck.png",
                CountryName = "Cook Islands"
            }); this.Add(new AthleteItem()
            {
                Id = 186,
                Avatar = "assets/images/men/42.jpg",
                Position = "up",
                Name = "Jimmy Bailey",
                AthleteNumber = 38510,
                BeatsPerMinute = 101,
                TopSpeed = 4.7,
                Registered = "2017-06-30T04:13:42 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/cr.png",
                CountryName = "Costa Rica"
            }); this.Add(new AthleteItem()
            {
                Id = 108,
                Avatar = "assets/images/men/31.jpg",
                Position = "up",
                Name = "Noah Bergeron",
                AthleteNumber = 35139,
                BeatsPerMinute = 110,
                TopSpeed = 5.6,
                Registered = "2017-06-23T01:21:21 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ci.png",
                CountryName = "Cote DIvoire"
            }); this.Add(new AthleteItem()
            {
                Id = 176,
                Avatar = "assets/images/men/35.jpg",
                Position = "down",
                Name = "Laudelino Castro",
                AthleteNumber = 12711,
                BeatsPerMinute = 106,
                TopSpeed = 4.4,
                Registered = "2017-02-08T04:03:22 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/hr.png",
                CountryName = "Croatia"
            }); this.Add(new AthleteItem()
            {
                Id = 138,
                Avatar = "assets/images/men/78.jpg",
                Position = "current",
                Name = "Oscar Calvo",
                AthleteNumber = 45078,
                BeatsPerMinute = 109,
                TopSpeed = 4.3,
                Registered = "2017-06-19T10:57:42 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/cu.png",
                CountryName = "Cuba"
            }); this.Add(new AthleteItem()
            {
                Id = 137,
                Avatar = "assets/images/men/80.jpg",
                Position = "down",
                Name = "Lance Dunn",
                AthleteNumber = 10113,
                BeatsPerMinute = 94,
                TopSpeed = 4.5,
                Registered = "2017-03-13T10:51:36 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/cy.png",
                CountryName = "Cyprus"
            }); this.Add(new AthleteItem()
            {
                Id = 173,
                Avatar = "assets/images/women/18.jpg",
                Position = "current",
                Name = "Hassana Camp",
                AthleteNumber = 14467,
                BeatsPerMinute = 104,
                TopSpeed = 5.2,
                Registered = "2017-06-02T12:21:59 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/cz.png",
                CountryName = "Czech Republic"
            }); this.Add(new AthleteItem()
            {
                Id = 46,
                Avatar = "assets/images/women/55.jpg",
                Position = "current",
                Name = "Ronja Kraft",
                AthleteNumber = 21800,
                BeatsPerMinute = 101,
                TopSpeed = 5.3,
                Registered = "2017-04-02T03:33:57 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/dk.png",
                CountryName = "Denmark"
            }); this.Add(new AthleteItem()
            {
                Id = 8,
                Avatar = "assets/images/men/14.jpg",
                Position = "up",
                Name = "Hans Möller",
                AthleteNumber = 34122,
                BeatsPerMinute = 109,
                TopSpeed = 5.6,
                Registered = "2017-06-20T06:02:49 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/dj.png",
                CountryName = "Djibouti"
            }); this.Add(new AthleteItem()
            {
                Id = 188,
                Avatar = "assets/images/women/45.jpg",
                Position = "down",
                Name = "Ceylan Duygulu",
                AthleteNumber = 21527,
                BeatsPerMinute = 99,
                TopSpeed = 4.9,
                Registered = "2017-07-13T09:06:04 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/dm.png",
                CountryName = "Dominica"
            }); this.Add(new AthleteItem()
            {
                Id = 134,
                Avatar = "assets/images/women/66.jpg",
                Position = "down",
                Name = "Anni Waisanen",
                AthleteNumber = 32133,
                BeatsPerMinute = 99,
                TopSpeed = 5,
                Registered = "2017-08-17T01:35:09 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/do.png",
                CountryName = "Dominican Republic"
            }); this.Add(new AthleteItem()
            {
                Id = 112,
                Avatar = "assets/images/women/53.jpg",
                Position = "down",
                Name = "Karen Shaw",
                AthleteNumber = 31048,
                BeatsPerMinute = 107,
                TopSpeed = 5.7,
                Registered = "2017-05-15T09:25:03 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ec.png",
                CountryName = "Ecuador"
            }); this.Add(new AthleteItem()
            {
                Id = 161,
                Avatar = "assets/images/men/38.jpg",
                Position = "current",
                Name = "Alex Martin",
                AthleteNumber = 27887,
                BeatsPerMinute = 96,
                TopSpeed = 4.2,
                Registered = "2017-10-28T04:06:33 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/eg.png",
                CountryName = "Egypt"
            }); this.Add(new AthleteItem()
            {
                Id = 196,
                Avatar = "assets/images/women/30.jpg",
                Position = "up",
                Name = "Begüm Erkekli",
                AthleteNumber = 37888,
                BeatsPerMinute = 104,
                TopSpeed = 4.6,
                Registered = "2017-10-04T03:02:35 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/sv.png",
                CountryName = "El Salvador"
            }); this.Add(new AthleteItem()
            {
                Id = 24,
                Avatar = "assets/images/men/0.jpg",
                Position = "down",
                Name = "Joan Ortega",
                AthleteNumber = 49478,
                BeatsPerMinute = 103,
                TopSpeed = 5.4,
                Registered = "2017-07-04T03:01:47 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/gq.png",
                CountryName = "Equatorial Guinea"
            }); this.Add(new AthleteItem()
            {
                Id = 174,
                Avatar = "assets/images/women/29.jpg",
                Position = "current",
                Name = "Beatriz Gallardo",
                AthleteNumber = 38538,
                BeatsPerMinute = 101,
                TopSpeed = 6,
                Registered = "2017-11-06T02:14:31 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/er.png",
                CountryName = "Eritrea"
            }); this.Add(new AthleteItem()
            {
                Id = 193,
                Avatar = "assets/images/women/59.jpg",
                Position = "down",
                Name = "Sophia Carlson",
                AthleteNumber = 44183,
                BeatsPerMinute = 102,
                TopSpeed = 5.1,
                Registered = "2017-09-04T07:03:19 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ee.png",
                CountryName = "Estonia"
            }); this.Add(new AthleteItem()
            {
                Id = 85,
                Avatar = "assets/images/men/43.jpg",
                Position = "down",
                Name = "Niilo Laurila",
                AthleteNumber = 49215,
                BeatsPerMinute = 104,
                TopSpeed = 4.5,
                Registered = "2017-04-26T01:26:36 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/et.png",
                CountryName = "Ethiopia"
            }); this.Add(new AthleteItem()
            {
                Id = 201,
                Avatar = "assets/images/men/92.jpg",
                Position = "up",
                Name = "Kaya Tekand",
                AthleteNumber = 11028,
                BeatsPerMinute = 93,
                TopSpeed = 5.2,
                Registered = "2017-04-10T09:57:13 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/fj.png",
                CountryName = "Fiji"
            }); this.Add(new AthleteItem()
            {
                Id = 123,
                Avatar = "assets/images/men/31.jpg",
                Position = "current",
                Name = "Eeli Makinen",
                AthleteNumber = 45296,
                BeatsPerMinute = 106,
                TopSpeed = 5.2,
                Registered = "2017-01-06T09:58:02 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/fi.png",
                CountryName = "Finland"
            }); this.Add(new AthleteItem()
            {
                Id = 16,
                Avatar = "assets/images/men/72.jpg",
                Position = "down",
                Name = "Felix Olsen",
                AthleteNumber = 43198,
                BeatsPerMinute = 101,
                TopSpeed = 4.2,
                Registered = "2017-09-27T01:17:14 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/fr.png",
                CountryName = "France"
            }); this.Add(new AthleteItem()
            {
                Id = 62,
                Avatar = "assets/images/men/43.jpg",
                Position = "current",
                Name = "Roman Smith",
                AthleteNumber = 15531,
                BeatsPerMinute = 106,
                TopSpeed = 4.9,
                Registered = "2017-06-14T05:12:04 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/ga.png",
                CountryName = "Gabon"
            }); this.Add(new AthleteItem()
            {
                Id = 69,
                Avatar = "assets/images/men/17.jpg",
                Position = "current",
                Name = "Emil Meißner",
                AthleteNumber = 37183,
                BeatsPerMinute = 97,
                TopSpeed = 4,
                Registered = "2017-07-15T12:32:30 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/gm.png",
                CountryName = "Gambia"
            }); this.Add(new AthleteItem()
            {
                Id = 182,
                Avatar = "assets/images/men/94.jpg",
                Position = "current",
                Name = "Gerald Schmidt",
                AthleteNumber = 47410,
                BeatsPerMinute = 102,
                TopSpeed = 5.8,
                Registered = "2017-02-20T11:53:08 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/ge.png",
                CountryName = "Georgia"
            }); this.Add(new AthleteItem()
            {
                Id = 190,
                Avatar = "assets/images/women/53.jpg",
                Position = "current",
                Name = "Gladys Van Der Steeg",
                AthleteNumber = 20216,
                BeatsPerMinute = 94,
                TopSpeed = 4.3,
                Registered = "2017-10-09T02:01:16 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/de.png",
                CountryName = "Germany"
            }); this.Add(new AthleteItem()
            {
                Id = 100,
                Avatar = "assets/images/women/20.jpg",
                Position = "current",
                Name = "Alexis Walker",
                AthleteNumber = 43183,
                BeatsPerMinute = 103,
                TopSpeed = 5.8,
                Registered = "2017-08-07T10:35:06 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/gh.png",
                CountryName = "Ghana"
            }); this.Add(new AthleteItem()
            {
                Id = 85,
                Avatar = "assets/images/men/34.jpg",
                Position = "current",
                Name = "Jeffrey Medina",
                AthleteNumber = 42905,
                BeatsPerMinute = 100,
                TopSpeed = 5.2,
                Registered = "2017-09-15T02:11:43 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/gr.png",
                CountryName = "Greece"
            }); this.Add(new AthleteItem()
            {
                Id = 169,
                Avatar = "assets/images/men/21.jpg",
                Position = "down",
                Name = "Julian Barth",
                AthleteNumber = 19011,
                BeatsPerMinute = 91,
                TopSpeed = 5.2,
                Registered = "2017-04-21T08:08:33 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/gd.png",
                CountryName = "Grenada"
            }); this.Add(new AthleteItem()
            {
                Id = 116,
                Avatar = "assets/images/women/1.jpg",
                Position = "down",
                Name = "Sevcan Kollen",
                AthleteNumber = 13728,
                BeatsPerMinute = 104,
                TopSpeed = 5.3,
                Registered = "2017-09-08T08:29:08 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/gt.png",
                CountryName = "Guatemala"
            }); this.Add(new AthleteItem()
            {
                Id = 75,
                Avatar = "assets/images/men/88.jpg",
                Position = "down",
                Name = "Rafael Gutierrez",
                AthleteNumber = 38804,
                BeatsPerMinute = 100,
                TopSpeed = 5.9,
                Registered = "2017-02-08T07:50:59 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/gn.png",
                CountryName = "Guinea"
            }); this.Add(new AthleteItem()
            {
                Id = 121,
                Avatar = "assets/images/men/48.jpg",
                Position = "current",
                Name = "Väinö Salmi",
                AthleteNumber = 29839,
                BeatsPerMinute = 107,
                TopSpeed = 5.5,
                Registered = "2017-10-21T05:57:02 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/gw.png",
                CountryName = "Guinea-Bissau"
            }); this.Add(new AthleteItem()
            {
                Id = 180,
                Avatar = "assets/images/women/90.jpg",
                Position = "up",
                Name = "Lillian Bowman",
                AthleteNumber = 35323,
                BeatsPerMinute = 103,
                TopSpeed = 4.5,
                Registered = "2017-08-31T11:55:25 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/gy.png",
                CountryName = "Guyana"
            }); this.Add(new AthleteItem()
            {
                Id = 139,
                Avatar = "assets/images/women/28.jpg",
                Position = "current",
                Name = "Annabell Barth",
                AthleteNumber = 41130,
                BeatsPerMinute = 103,
                TopSpeed = 5,
                Registered = "2017-08-24T11:58:56 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/ht.png",
                CountryName = "Haiti"
            }); this.Add(new AthleteItem()
            {
                Id = 4,
                Avatar = "assets/images/men/34.jpg",
                Position = "down",
                Name = "Mathys Martin",
                AthleteNumber = 32928,
                BeatsPerMinute = 98,
                TopSpeed = 5.5,
                Registered = "2017-05-17T12:51:47 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/va.png",
                CountryName = "Holy See (Vatican City State)"
            }); this.Add(new AthleteItem()
            {
                Id = 1,
                Avatar = "assets/images/men/65.jpg",
                Position = "down",
                Name = "Louis Stewart",
                AthleteNumber = 48131,
                BeatsPerMinute = 103,
                TopSpeed = 5.7,
                Registered = "2017-02-26T07:28:02 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/hn.png",
                CountryName = "Honduras"
            }); this.Add(new AthleteItem()
            {
                Id = 190,
                Avatar = "assets/images/women/2.jpg",
                Position = "current",
                Name = "Venla Korpela",
                AthleteNumber = 16454,
                BeatsPerMinute = 92,
                TopSpeed = 4.1,
                Registered = "2017-08-22T10:36:38 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/hu.png",
                CountryName = "Hungary"
            }); this.Add(new AthleteItem()
            {
                Id = 167,
                Avatar = "assets/images/men/81.jpg",
                Position = "down",
                Name = "Milo Charles",
                AthleteNumber = 10661,
                BeatsPerMinute = 99,
                TopSpeed = 5.4,
                Registered = "2017-07-20T09:00:22 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/is.png",
                CountryName = "Iceland"
            }); this.Add(new AthleteItem()
            {
                Id = 62,
                Avatar = "assets/images/men/9.jpg",
                Position = "current",
                Name = "Anthony Harcourt",
                AthleteNumber = 33649,
                BeatsPerMinute = 109,
                TopSpeed = 5.5,
                Registered = "2017-06-14T11:10:20 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/in.png",
                CountryName = "India"
            }); this.Add(new AthleteItem()
            {
                Id = 72,
                Avatar = "assets/images/men/31.jpg",
                Position = "up",
                Name = "Aaron Robertson",
                AthleteNumber = 30727,
                BeatsPerMinute = 95,
                TopSpeed = 4.2,
                Registered = "2017-08-23T09:37:40 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/id.png",
                CountryName = "Indonesia"
            }); this.Add(new AthleteItem()
            {
                Id = 2,
                Avatar = "assets/images/men/14.jpg",
                Position = "up",
                Name = "Bill Fox",
                AthleteNumber = 18511,
                BeatsPerMinute = 91,
                TopSpeed = 5,
                Registered = "2017-10-24T08:25:40 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/ir.png",
                CountryName = "Iran, Islamic Republic Of"
            }); this.Add(new AthleteItem()
            {
                Id = 58,
                Avatar = "assets/images/women/30.jpg",
                Position = "up",
                Name = "Veera Saari",
                AthleteNumber = 40408,
                BeatsPerMinute = 100,
                TopSpeed = 4.7,
                Registered = "2017-10-28T10:39:22 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/iq.png",
                CountryName = "Iraq"
            }); this.Add(new AthleteItem()
            {
                Id = 87,
                Avatar = "assets/images/men/35.jpg",
                Position = "current",
                Name = "Loïc Gerard",
                AthleteNumber = 31706,
                BeatsPerMinute = 102,
                TopSpeed = 4.4,
                Registered = "2017-07-28T09:10:43 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ie.png",
                CountryName = "Ireland"
            }); this.Add(new AthleteItem()
            {
                Id = 137,
                Avatar = "assets/images/women/75.jpg",
                Position = "up",
                Name = "Gloria Caballero",
                AthleteNumber = 43379,
                BeatsPerMinute = 103,
                TopSpeed = 4.3,
                Registered = "2017-08-10T08:27:45 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/il.png",
                CountryName = "Israel"
            }); this.Add(new AthleteItem()
            {
                Id = 5,
                Avatar = "assets/images/women/38.jpg",
                Position = "current",
                Name = "Gianne Godijn",
                AthleteNumber = 45945,
                BeatsPerMinute = 96,
                TopSpeed = 4.5,
                Registered = "2017-03-22T03:23:12 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/it.png",
                CountryName = "Italy"
            }); this.Add(new AthleteItem()
            {
                Id = 196,
                Avatar = "assets/images/women/17.jpg",
                Position = "current",
                Name = "Parel Zuidhof",
                AthleteNumber = 32718,
                BeatsPerMinute = 105,
                TopSpeed = 5,
                Registered = "2017-01-21T10:19:56 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/jm.png",
                CountryName = "Jamaica"
            }); this.Add(new AthleteItem()
            {
                Id = 23,
                Avatar = "assets/images/men/72.jpg",
                Position = "down",
                Name = "Gökhan Aşıkoğlu",
                AthleteNumber = 13890,
                BeatsPerMinute = 105,
                TopSpeed = 5.4,
                Registered = "2017-03-31T06:14:26 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/jp.png",
                CountryName = "Japan"
            }); this.Add(new AthleteItem()
            {
                Id = 74,
                Avatar = "assets/images/women/9.jpg",
                Position = "up",
                Name = "Minea Rantanen",
                AthleteNumber = 18835,
                BeatsPerMinute = 105,
                TopSpeed = 5,
                Registered = "2017-01-24T07:30:43 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/jo.png",
                CountryName = "Jordan"
            }); this.Add(new AthleteItem()
            {
                Id = 92,
                Avatar = "assets/images/women/4.jpg",
                Position = "down",
                Name = "Asta Hansen",
                AthleteNumber = 17222,
                BeatsPerMinute = 101,
                TopSpeed = 4.3,
                Registered = "2017-01-08T02:41:56 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/kz.png",
                CountryName = "Kazakhstan"
            }); this.Add(new AthleteItem()
            {
                Id = 191,
                Avatar = "assets/images/women/13.jpg",
                Position = "up",
                Name = "Sheryl Collins",
                AthleteNumber = 36473,
                BeatsPerMinute = 98,
                TopSpeed = 4.2,
                Registered = "2017-03-23T12:54:35 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/ke.png",
                CountryName = "Kenya"
            }); this.Add(new AthleteItem()
            {
                Id = 166,
                Avatar = "assets/images/women/74.jpg",
                Position = "current",
                Name = "Maria Parra",
                AthleteNumber = 39861,
                BeatsPerMinute = 106,
                TopSpeed = 6,
                Registered = "2017-01-30T09:22:52 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ki.png",
                CountryName = "Kiribati"
            }); this.Add(new AthleteItem()
            {
                Id = 73,
                Avatar = "assets/images/women/33.jpg",
                Position = "up",
                Name = "Annabelle Besteman",
                AthleteNumber = 30560,
                BeatsPerMinute = 105,
                TopSpeed = 5.3,
                Registered = "2017-11-11T02:04:19 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/kp.png",
                CountryName = "Korea, Democratic PeopleS Republic of"
            }); this.Add(new AthleteItem()
            {
                Id = 182,
                Avatar = "assets/images/women/14.jpg",
                Position = "up",
                Name = "Ariena Achterberg",
                AthleteNumber = 41330,
                BeatsPerMinute = 92,
                TopSpeed = 5.6,
                Registered = "2017-10-22T02:15:39 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/kr.png",
                CountryName = "Korea, Republic of"
            }); this.Add(new AthleteItem()
            {
                Id = 67,
                Avatar = "assets/images/men/50.jpg",
                Position = "current",
                Name = "Villads Larsen",
                AthleteNumber = 44677,
                BeatsPerMinute = 93,
                TopSpeed = 5.7,
                Registered = "2017-03-25T11:25:30 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/kw.png",
                CountryName = "Kuwait"
            }); this.Add(new AthleteItem()
            {
                Id = 110,
                Avatar = "assets/images/women/26.jpg",
                Position = "down",
                Name = "Emilie Morin",
                AthleteNumber = 26164,
                BeatsPerMinute = 98,
                TopSpeed = 4.9,
                Registered = "2017-02-01T04:18:19 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/kg.png",
                CountryName = "Kyrgyzstan"
            }); this.Add(new AthleteItem()
            {
                Id = 31,
                Avatar = "assets/images/men/56.jpg",
                Position = "up",
                Name = "Judd Campbell",
                AthleteNumber = 37365,
                BeatsPerMinute = 110,
                TopSpeed = 5,
                Registered = "2017-10-19T11:01:10 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/la.png",
                CountryName = "Lao PeopleS Democratic Republic"
            }); this.Add(new AthleteItem()
            {
                Id = 110,
                Avatar = "assets/images/women/13.jpg",
                Position = "current",
                Name = "Özsu Keçeci",
                AthleteNumber = 29403,
                BeatsPerMinute = 106,
                TopSpeed = 4.2,
                Registered = "2017-01-19T11:34:13 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/lv.png",
                CountryName = "Latvia"
            }); this.Add(new AthleteItem()
            {
                Id = 123,
                Avatar = "assets/images/women/12.jpg",
                Position = "up",
                Name = "آنیتا كامياران",
                AthleteNumber = 18980,
                BeatsPerMinute = 90,
                TopSpeed = 4.5,
                Registered = "2017-07-21T06:42:59 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/lb.png",
                CountryName = "Lebanon"
            }); this.Add(new AthleteItem()
            {
                Id = 138,
                Avatar = "assets/images/men/31.jpg",
                Position = "down",
                Name = "Antoine Mackay",
                AthleteNumber = 34547,
                BeatsPerMinute = 104,
                TopSpeed = 5,
                Registered = "2017-08-22T09:11:37 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ls.png",
                CountryName = "Lesotho"
            }); this.Add(new AthleteItem()
            {
                Id = 167,
                Avatar = "assets/images/men/19.jpg",
                Position = "down",
                Name = "Louis Smith",
                AthleteNumber = 31837,
                BeatsPerMinute = 98,
                TopSpeed = 5.4,
                Registered = "2017-03-19T08:12:23 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/lr.png",
                CountryName = "Liberia"
            }); this.Add(new AthleteItem()
            {
                Id = 29,
                Avatar = "assets/images/men/29.jpg",
                Position = "current",
                Name = "Selmo Caldeira",
                AthleteNumber = 21837,
                BeatsPerMinute = 110,
                TopSpeed = 4.9,
                Registered = "2017-10-20T03:40:24 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/ly.png",
                CountryName = "Libyan Arab Jamahiriya"
            }); this.Add(new AthleteItem()
            {
                Id = 35,
                Avatar = "assets/images/women/42.jpg",
                Position = "down",
                Name = "Elaine Smith",
                AthleteNumber = 38243,
                BeatsPerMinute = 108,
                TopSpeed = 4,
                Registered = "2017-06-11T12:20:41 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/li.png",
                CountryName = "Liechtenstein"
            }); this.Add(new AthleteItem()
            {
                Id = 75,
                Avatar = "assets/images/men/2.jpg",
                Position = "up",
                Name = "Fritz Sommer",
                AthleteNumber = 26210,
                BeatsPerMinute = 99,
                TopSpeed = 4.6,
                Registered = "2017-09-29T03:54:57 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/lt.png",
                CountryName = "Lithuania"
            }); this.Add(new AthleteItem()
            {
                Id = 40,
                Avatar = "assets/images/men/5.jpg",
                Position = "down",
                Name = "Carter Evans",
                AthleteNumber = 46961,
                BeatsPerMinute = 100,
                TopSpeed = 5.3,
                Registered = "2017-07-23T02:43:07 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/lu.png",
                CountryName = "Luxembourg"
            }); this.Add(new AthleteItem()
            {
                Id = 183,
                Avatar = "assets/images/women/53.jpg",
                Position = "up",
                Name = "رونیکا سلطانی نژاد",
                AthleteNumber = 35233,
                BeatsPerMinute = 99,
                TopSpeed = 4.6,
                Registered = "2017-08-13T01:05:52 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/mk.png",
                CountryName = "Macedonia, The Former Yugoslav Republic of"
            }); this.Add(new AthleteItem()
            {
                Id = 151,
                Avatar = "assets/images/women/88.jpg",
                Position = "current",
                Name = "Charlotte Mills",
                AthleteNumber = 49829,
                BeatsPerMinute = 92,
                TopSpeed = 5.3,
                Registered = "2017-05-10T04:33:10 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/mg.png",
                CountryName = "Madagascar"
            }); this.Add(new AthleteItem()
            {
                Id = 107,
                Avatar = "assets/images/men/33.jpg",
                Position = "up",
                Name = "Pedro Marquez",
                AthleteNumber = 16169,
                BeatsPerMinute = 97,
                TopSpeed = 5.4,
                Registered = "2017-11-11T05:14:31 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/mw.png",
                CountryName = "Malawi"
            }); this.Add(new AthleteItem()
            {
                Id = 65,
                Avatar = "assets/images/women/9.jpg",
                Position = "down",
                Name = "Jenny Burke",
                AthleteNumber = 15266,
                BeatsPerMinute = 99,
                TopSpeed = 5.4,
                Registered = "2017-09-11T12:20:19 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/my.png",
                CountryName = "Malaysia"
            }); this.Add(new AthleteItem()
            {
                Id = 155,
                Avatar = "assets/images/men/82.jpg",
                Position = "up",
                Name = "Justin Philippe",
                AthleteNumber = 12858,
                BeatsPerMinute = 104,
                TopSpeed = 5.7,
                Registered = "2017-03-16T02:00:35 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/mv.png",
                CountryName = "Maldives"
            }); this.Add(new AthleteItem()
            {
                Id = 165,
                Avatar = "assets/images/men/79.jpg",
                Position = "down",
                Name = "Mario Ellis",
                AthleteNumber = 18026,
                BeatsPerMinute = 99,
                TopSpeed = 5.5,
                Registered = "2017-02-13T11:53:15 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ml.png",
                CountryName = "Mali"
            }); this.Add(new AthleteItem()
            {
                Id = 107,
                Avatar = "assets/images/women/92.jpg",
                Position = "down",
                Name = "Megan Webb",
                AthleteNumber = 30713,
                BeatsPerMinute = 93,
                TopSpeed = 5.6,
                Registered = "2017-08-20T09:26:51 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/mt.png",
                CountryName = "Malta"
            }); this.Add(new AthleteItem()
            {
                Id = 52,
                Avatar = "assets/images/men/94.jpg",
                Position = "down",
                Name = "Adérito Lopes",
                AthleteNumber = 21320,
                BeatsPerMinute = 91,
                TopSpeed = 5.2,
                Registered = "2017-01-07T06:47:56 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/mh.png",
                CountryName = "Marshall Islands"
            }); this.Add(new AthleteItem()
            {
                Id = 99,
                Avatar = "assets/images/men/89.jpg",
                Position = "down",
                Name = "Victor Lévesque",
                AthleteNumber = 48375,
                BeatsPerMinute = 110,
                TopSpeed = 5.7,
                Registered = "2017-11-10T11:31:44 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/mr.png",
                CountryName = "Mauritania"
            }); this.Add(new AthleteItem()
            {
                Id = 188,
                Avatar = "assets/images/men/81.jpg",
                Position = "down",
                Name = "آراد یاسمی",
                AthleteNumber = 34370,
                BeatsPerMinute = 99,
                TopSpeed = 5.9,
                Registered = "2017-02-02T11:42:41 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/mu.png",
                CountryName = "Mauritius"
            }); this.Add(new AthleteItem()
            {
                Id = 10,
                Avatar = "assets/images/women/13.jpg",
                Position = "down",
                Name = "Maeva Bergeron",
                AthleteNumber = 15655,
                BeatsPerMinute = 94,
                TopSpeed = 5.9,
                Registered = "2017-10-03T09:42:15 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/mx.png",
                CountryName = "Mexico"
            }); this.Add(new AthleteItem()
            {
                Id = 41,
                Avatar = "assets/images/men/20.jpg",
                Position = "up",
                Name = "Oskari Karjala",
                AthleteNumber = 31498,
                BeatsPerMinute = 90,
                TopSpeed = 4.5,
                Registered = "2017-05-10T12:45:12 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/fm.png",
                CountryName = "Micronesia, Federated States of"
            }); this.Add(new AthleteItem()
            {
                Id = 51,
                Avatar = "assets/images/men/74.jpg",
                Position = "up",
                Name = "Alex Meyer",
                AthleteNumber = 44390,
                BeatsPerMinute = 94,
                TopSpeed = 4.3,
                Registered = "2017-08-04T07:05:34 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/md.png",
                CountryName = "Moldova, Republic of"
            }); this.Add(new AthleteItem()
            {
                Id = 128,
                Avatar = "assets/images/women/52.jpg",
                Position = "up",
                Name = "Sophie Lewis",
                AthleteNumber = 46222,
                BeatsPerMinute = 106,
                TopSpeed = 4.4,
                Registered = "2017-02-20T09:42:07 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/mc.png",
                CountryName = "Monaco"
            }); this.Add(new AthleteItem()
            {
                Id = 79,
                Avatar = "assets/images/women/39.jpg",
                Position = "current",
                Name = "Ashley Romero",
                AthleteNumber = 36611,
                BeatsPerMinute = 104,
                TopSpeed = 5.5,
                Registered = "2017-02-08T12:45:46 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/mn.png",
                CountryName = "Mongolia"
            }); this.Add(new AthleteItem()
            {
                Id = 124,
                Avatar = "assets/images/women/19.jpg",
                Position = "current",
                Name = "Marie Poulsen",
                AthleteNumber = 44113,
                BeatsPerMinute = 109,
                TopSpeed = 4.7,
                Registered = "2017-04-15T10:25:21 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/ma.png",
                CountryName = "Morocco"
            }); this.Add(new AthleteItem()
            {
                Id = 42,
                Avatar = "assets/images/women/83.jpg",
                Position = "down",
                Name = "Caitlin Jackson",
                AthleteNumber = 45472,
                BeatsPerMinute = 101,
                TopSpeed = 4.3,
                Registered = "2017-09-17T09:41:01 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/mz.png",
                CountryName = "Mozambique"
            }); this.Add(new AthleteItem()
            {
                Id = 15,
                Avatar = "assets/images/women/79.jpg",
                Position = "down",
                Name = "Marilou Hubert",
                AthleteNumber = 43655,
                BeatsPerMinute = 104,
                TopSpeed = 4.2,
                Registered = "2017-09-28T11:13:00 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/mm.png",
                CountryName = "Myanmar"
            }); this.Add(new AthleteItem()
            {
                Id = 63,
                Avatar = "assets/images/women/9.jpg",
                Position = "up",
                Name = "Estelle Vincent",
                AthleteNumber = 41700,
                BeatsPerMinute = 99,
                TopSpeed = 5.7,
                Registered = "2017-05-31T02:56:58 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/na.png",
                CountryName = "Namibia"
            }); this.Add(new AthleteItem()
            {
                Id = 154,
                Avatar = "assets/images/women/54.jpg",
                Position = "down",
                Name = "Rhonda Simmmons",
                AthleteNumber = 37139,
                BeatsPerMinute = 96,
                TopSpeed = 5.1,
                Registered = "2017-07-03T05:39:45 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/nr.png",
                CountryName = "Nauru"
            }); this.Add(new AthleteItem()
            {
                Id = 191,
                Avatar = "assets/images/men/42.jpg",
                Position = "current",
                Name = "آرش احمدی",
                AthleteNumber = 36948,
                BeatsPerMinute = 90,
                TopSpeed = 4.1,
                Registered = "2017-09-08T01:22:14 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/np.png",
                CountryName = "Nepal"
            }); this.Add(new AthleteItem()
            {
                Id = 141,
                Avatar = "assets/images/men/15.jpg",
                Position = "current",
                Name = "Miro Korpela",
                AthleteNumber = 40544,
                BeatsPerMinute = 104,
                TopSpeed = 5.3,
                Registered = "2017-01-10T07:12:44 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/nl.png",
                CountryName = "Netherlands"
            }); this.Add(new AthleteItem()
            {
                Id = 73,
                Avatar = "assets/images/women/4.jpg",
                Position = "up",
                Name = "Afet Kumcuoğlu",
                AthleteNumber = 33454,
                BeatsPerMinute = 106,
                TopSpeed = 5.1,
                Registered = "2017-09-16T07:05:43 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/nz.png",
                CountryName = "New Zealand"
            }); this.Add(new AthleteItem()
            {
                Id = 163,
                Avatar = "assets/images/women/52.jpg",
                Position = "up",
                Name = "Millie Cooper",
                AthleteNumber = 14610,
                BeatsPerMinute = 99,
                TopSpeed = 5.4,
                Registered = "2017-05-08T09:30:14 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/ni.png",
                CountryName = "Nicaragua"
            }); this.Add(new AthleteItem()
            {
                Id = 53,
                Avatar = "assets/images/women/51.jpg",
                Position = "current",
                Name = "Kayla Patel",
                AthleteNumber = 42780,
                BeatsPerMinute = 103,
                TopSpeed = 4.7,
                Registered = "2017-04-20T09:33:53 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/ne.png",
                CountryName = "Niger"
            }); this.Add(new AthleteItem()
            {
                Id = 58,
                Avatar = "assets/images/men/31.jpg",
                Position = "current",
                Name = "Diego Gautier",
                AthleteNumber = 26320,
                BeatsPerMinute = 97,
                TopSpeed = 4.6,
                Registered = "2017-06-11T03:50:43 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ng.png",
                CountryName = "Nigeria"
            }); this.Add(new AthleteItem()
            {
                Id = 186,
                Avatar = "assets/images/men/2.jpg",
                Position = "up",
                Name = "کوروش کامروا",
                AthleteNumber = 13506,
                BeatsPerMinute = 109,
                TopSpeed = 4.4,
                Registered = "2017-04-16T01:10:37 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/nu.png",
                CountryName = "Niue"
            }); this.Add(new AthleteItem()
            {
                Id = 101,
                Avatar = "assets/images/women/71.jpg",
                Position = "down",
                Name = "Lavínia Silva",
                AthleteNumber = 33994,
                BeatsPerMinute = 93,
                TopSpeed = 5.6,
                Registered = "2017-03-22T08:55:46 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/no.png",
                CountryName = "Norway"
            }); this.Add(new AthleteItem()
            {
                Id = 194,
                Avatar = "assets/images/men/71.jpg",
                Position = "down",
                Name = "Adrian Ibañez",
                AthleteNumber = 21968,
                BeatsPerMinute = 105,
                TopSpeed = 5.3,
                Registered = "2017-02-03T04:36:54 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/om.png",
                CountryName = "Oman"
            }); this.Add(new AthleteItem()
            {
                Id = 143,
                Avatar = "assets/images/men/38.jpg",
                Position = "up",
                Name = "رضا کوتی",
                AthleteNumber = 13640,
                BeatsPerMinute = 103,
                TopSpeed = 4.2,
                Registered = "2017-04-30T02:34:29 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/pk.png",
                CountryName = "Pakistan"
            }); this.Add(new AthleteItem()
            {
                Id = 37,
                Avatar = "assets/images/men/86.jpg",
                Position = "down",
                Name = "Clyde Matthews",
                AthleteNumber = 11955,
                BeatsPerMinute = 93,
                TopSpeed = 5.2,
                Registered = "2017-03-02T05:01:02 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/pw.png",
                CountryName = "Palau"
            }); this.Add(new AthleteItem()
            {
                Id = 176,
                Avatar = "assets/images/men/26.jpg",
                Position = "current",
                Name = "Tim Neal",
                AthleteNumber = 45860,
                BeatsPerMinute = 97,
                TopSpeed = 5.6,
                Registered = "2017-04-21T04:06:34 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/pa.png",
                CountryName = "Panama"
            }); this.Add(new AthleteItem()
            {
                Id = 110,
                Avatar = "assets/images/women/15.jpg",
                Position = "current",
                Name = "Annabell Brand",
                AthleteNumber = 39233,
                BeatsPerMinute = 93,
                TopSpeed = 5.7,
                Registered = "2017-03-01T12:21:24 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/pg.png",
                CountryName = "Papua New Guinea"
            }); this.Add(new AthleteItem()
            {
                Id = 188,
                Avatar = "assets/images/men/3.jpg",
                Position = "current",
                Name = "Foppe Delfos",
                AthleteNumber = 39679,
                BeatsPerMinute = 107,
                TopSpeed = 4.1,
                Registered = "2017-08-05T10:54:56 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/py.png",
                CountryName = "Paraguay"
            }); this.Add(new AthleteItem()
            {
                Id = 43,
                Avatar = "assets/images/men/42.jpg",
                Position = "up",
                Name = "Kent Clark",
                AthleteNumber = 32799,
                BeatsPerMinute = 106,
                TopSpeed = 5.7,
                Registered = "2017-01-24T01:00:15 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/pe.png",
                CountryName = "Peru"
            }); this.Add(new AthleteItem()
            {
                Id = 167,
                Avatar = "assets/images/women/32.jpg",
                Position = "current",
                Name = "Esma Adıvar",
                AthleteNumber = 35565,
                BeatsPerMinute = 99,
                TopSpeed = 4.2,
                Registered = "2017-06-17T12:34:29 -03:00",
                TrackProgress = 5,
                CountryFlag = "assets/images/grid/flags/ph.png",
                CountryName = "Philippines"
            }); this.Add(new AthleteItem()
            {
                Id = 123,
                Avatar = "assets/images/women/19.jpg",
                Position = "down",
                Name = "Flora Perez",
                AthleteNumber = 23907,
                BeatsPerMinute = 102,
                TopSpeed = 5.8,
                Registered = "2017-04-12T04:16:56 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/pl.png",
                CountryName = "Poland"
            }); this.Add(new AthleteItem()
            {
                Id = 76,
                Avatar = "assets/images/men/65.jpg",
                Position = "current",
                Name = "David Scott",
                AthleteNumber = 46997,
                BeatsPerMinute = 101,
                TopSpeed = 4.4,
                Registered = "2017-07-25T09:23:24 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/pt.png",
                CountryName = "Portugal"
            }); this.Add(new AthleteItem()
            {
                Id = 183,
                Avatar = "assets/images/men/74.jpg",
                Position = "down",
                Name = "Yarno Kin",
                AthleteNumber = 47324,
                BeatsPerMinute = 107,
                TopSpeed = 5.1,
                Registered = "2017-08-26T08:21:22 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ro.png",
                CountryName = "Romania"
            }); this.Add(new AthleteItem()
            {
                Id = 8,
                Avatar = "assets/images/women/15.jpg",
                Position = "down",
                Name = "Esther Kühn",
                AthleteNumber = 24868,
                BeatsPerMinute = 92,
                TopSpeed = 5.5,
                Registered = "2017-05-14T12:30:08 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/ru.png",
                CountryName = "Russian Federation"
            }); this.Add(new AthleteItem()
            {
                Id = 80,
                Avatar = "assets/images/men/90.jpg",
                Position = "down",
                Name = "Cecil Nichols",
                AthleteNumber = 20656,
                BeatsPerMinute = 100,
                TopSpeed = 5,
                Registered = "2017-04-24T01:20:34 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/rw.png",
                CountryName = "RWANDA"
            }); this.Add(new AthleteItem()
            {
                Id = 41,
                Avatar = "assets/images/women/65.jpg",
                Position = "down",
                Name = "Lilly Keuter",
                AthleteNumber = 49893,
                BeatsPerMinute = 102,
                TopSpeed = 4.5,
                Registered = "2017-01-20T02:38:39 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/kn.png",
                CountryName = "Saint Kitts and Nevis"
            }); this.Add(new AthleteItem()
            {
                Id = 200,
                Avatar = "assets/images/women/73.jpg",
                Position = "current",
                Name = "Alice Perry",
                AthleteNumber = 23750,
                BeatsPerMinute = 104,
                TopSpeed = 5.3,
                Registered = "2017-03-31T07:15:46 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/lc.png",
                CountryName = "Saint Lucia"
            }); this.Add(new AthleteItem()
            {
                Id = 51,
                Avatar = "assets/images/women/34.jpg",
                Position = "down",
                Name = "Eléa Robin",
                AthleteNumber = 26742,
                BeatsPerMinute = 90,
                TopSpeed = 4.7,
                Registered = "2017-03-30T12:34:24 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/vc.png",
                CountryName = "Saint Vincent and the Grenadines"
            }); this.Add(new AthleteItem()
            {
                Id = 163,
                Avatar = "assets/images/men/70.jpg",
                Position = "down",
                Name = "میلاد قاسمی",
                AthleteNumber = 12788,
                BeatsPerMinute = 101,
                TopSpeed = 4.1,
                Registered = "2017-03-01T07:51:17 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/ws.png",
                CountryName = "Samoa"
            }); this.Add(new AthleteItem()
            {
                Id = 72,
                Avatar = "assets/images/women/26.jpg",
                Position = "down",
                Name = "Sélène Roussel",
                AthleteNumber = 11261,
                BeatsPerMinute = 99,
                TopSpeed = 5.8,
                Registered = "2017-05-10T02:18:02 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/sm.png",
                CountryName = "San Marino"
            }); this.Add(new AthleteItem()
            {
                Id = 159,
                Avatar = "assets/images/women/66.jpg",
                Position = "up",
                Name = "Eva Dean",
                AthleteNumber = 48874,
                BeatsPerMinute = 103,
                TopSpeed = 5.7,
                Registered = "2017-03-04T01:58:52 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/st.png",
                CountryName = "Sao Tome and Principe"
            }); this.Add(new AthleteItem()
            {
                Id = 12,
                Avatar = "assets/images/women/83.jpg",
                Position = "up",
                Name = "Sara Larsen",
                AthleteNumber = 37094,
                BeatsPerMinute = 97,
                TopSpeed = 4.5,
                Registered = "2017-04-14T11:48:28 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/sa.png",
                CountryName = "Saudi Arabia"
            }); this.Add(new AthleteItem()
            {
                Id = 194,
                Avatar = "assets/images/men/11.jpg",
                Position = "down",
                Name = "Kaya Taşlı",
                AthleteNumber = 42291,
                BeatsPerMinute = 100,
                TopSpeed = 4.7,
                Registered = "2017-01-30T03:23:36 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/sn.png",
                CountryName = "Senegal"
            }); this.Add(new AthleteItem()
            {
                Id = 162,
                Avatar = "assets/images/men/5.jpg",
                Position = "down",
                Name = "Adam Bouchard",
                AthleteNumber = 38672,
                BeatsPerMinute = 99,
                TopSpeed = 4.7,
                Registered = "2017-01-04T03:04:05 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/sc.png",
                CountryName = "Seychelles"
            }); this.Add(new AthleteItem()
            {
                Id = 96,
                Avatar = "assets/images/women/37.jpg",
                Position = "up",
                Name = "Thea Edwards",
                AthleteNumber = 29141,
                BeatsPerMinute = 99,
                TopSpeed = 5.8,
                Registered = "2017-05-23T05:24:38 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/sl.png",
                CountryName = "Sierra Leone"
            }); this.Add(new AthleteItem()
            {
                Id = 93,
                Avatar = "assets/images/women/90.jpg",
                Position = "current",
                Name = "Ana Bourgeois",
                AthleteNumber = 24612,
                BeatsPerMinute = 110,
                TopSpeed = 6,
                Registered = "2017-11-02T02:17:43 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/sg.png",
                CountryName = "Singapore"
            }); this.Add(new AthleteItem()
            {
                Id = 27,
                Avatar = "assets/images/women/61.jpg",
                Position = "up",
                Name = "Layla Douglas",
                AthleteNumber = 21977,
                BeatsPerMinute = 97,
                TopSpeed = 5.4,
                Registered = "2017-04-19T11:43:38 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/si.png",
                CountryName = "Slovenia"
            }); this.Add(new AthleteItem()
            {
                Id = 178,
                Avatar = "assets/images/women/65.jpg",
                Position = "down",
                Name = "Lillian Wade",
                AthleteNumber = 10729,
                BeatsPerMinute = 110,
                TopSpeed = 4.8,
                Registered = "2017-04-07T09:53:13 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/sb.png",
                CountryName = "Solomon Islands"
            }); this.Add(new AthleteItem()
            {
                Id = 192,
                Avatar = "assets/images/women/44.jpg",
                Position = "down",
                Name = "Viivi Kujala",
                AthleteNumber = 29939,
                BeatsPerMinute = 93,
                TopSpeed = 4.1,
                Registered = "2017-05-03T02:40:05 -03:00",
                TrackProgress = 5,
                CountryFlag = "assets/images/grid/flags/so.png",
                CountryName = "Somalia"
            }); this.Add(new AthleteItem()
            {
                Id = 87,
                Avatar = "assets/images/women/72.jpg",
                Position = "up",
                Name = "Charlotte Dean",
                AthleteNumber = 45969,
                BeatsPerMinute = 105,
                TopSpeed = 5,
                Registered = "2017-02-13T05:39:15 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/za.png",
                CountryName = "South Africa"
            }); this.Add(new AthleteItem()
            {
                Id = 86,
                Avatar = "assets/images/women/45.jpg",
                Position = "down",
                Name = "Marisvalda Martins",
                AthleteNumber = 33879,
                BeatsPerMinute = 107,
                TopSpeed = 5.4,
                Registered = "2017-01-31T12:07:48 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/es.png",
                CountryName = "Spain"
            }); this.Add(new AthleteItem()
            {
                Id = 129,
                Avatar = "assets/images/women/34.jpg",
                Position = "up",
                Name = "Ella Hansen",
                AthleteNumber = 27075,
                BeatsPerMinute = 101,
                TopSpeed = 5.1,
                Registered = "2017-01-05T10:12:42 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/lk.png",
                CountryName = "Sri Lanka"
            }); this.Add(new AthleteItem()
            {
                Id = 27,
                Avatar = "assets/images/men/9.jpg",
                Position = "current",
                Name = "Johann Hinz",
                AthleteNumber = 48244,
                BeatsPerMinute = 94,
                TopSpeed = 4.3,
                Registered = "2017-03-10T07:36:56 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/sd.png",
                CountryName = "Sudan"
            }); this.Add(new AthleteItem()
            {
                Id = 113,
                Avatar = "assets/images/men/37.jpg",
                Position = "current",
                Name = "Nick Naumann",
                AthleteNumber = 25566,
                BeatsPerMinute = 109,
                TopSpeed = 5.9,
                Registered = "2017-07-12T09:01:11 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/sz.png",
                CountryName = "Swaziland"
            }); this.Add(new AthleteItem()
            {
                Id = 194,
                Avatar = "assets/images/women/62.jpg",
                Position = "up",
                Name = "آوا سلطانی نژاد",
                AthleteNumber = 45635,
                BeatsPerMinute = 98,
                TopSpeed = 4.1,
                Registered = "2017-04-10T11:39:46 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/se.png",
                CountryName = "Sweden"
            }); this.Add(new AthleteItem()
            {
                Id = 65,
                Avatar = "assets/images/women/47.jpg",
                Position = "current",
                Name = "Ilke Kisters",
                AthleteNumber = 23817,
                BeatsPerMinute = 100,
                TopSpeed = 5.9,
                Registered = "2017-01-04T02:54:53 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/ch.png",
                CountryName = "Switzerland"
            }); this.Add(new AthleteItem()
            {
                Id = 162,
                Avatar = "assets/images/women/0.jpg",
                Position = "current",
                Name = "Alex Craig",
                AthleteNumber = 21868,
                BeatsPerMinute = 94,
                TopSpeed = 4.2,
                Registered = "2017-03-19T10:20:51 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/sy.png",
                CountryName = "Syrian Arab Republic"
            }); this.Add(new AthleteItem()
            {
                Id = 161,
                Avatar = "assets/images/men/89.jpg",
                Position = "up",
                Name = "Franklin Byrd",
                AthleteNumber = 49498,
                BeatsPerMinute = 106,
                TopSpeed = 5.3,
                Registered = "2017-11-04T11:09:26 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/tw.png",
                CountryName = "Taiwan, Province of China"
            }); this.Add(new AthleteItem()
            {
                Id = 167,
                Avatar = "assets/images/women/62.jpg",
                Position = "current",
                Name = "Pippa Morris",
                AthleteNumber = 44421,
                BeatsPerMinute = 101,
                TopSpeed = 5.5,
                Registered = "2017-03-06T09:21:58 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/tj.png",
                CountryName = "Tajikistan"
            }); this.Add(new AthleteItem()
            {
                Id = 43,
                Avatar = "assets/images/women/94.jpg",
                Position = "up",
                Name = "Emma Turner",
                AthleteNumber = 39487,
                BeatsPerMinute = 110,
                TopSpeed = 5.7,
                Registered = "2017-07-30T01:33:14 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/tz.png",
                CountryName = "Tanzania, United Republic of"
            }); this.Add(new AthleteItem()
            {
                Id = 76,
                Avatar = "assets/images/women/1.jpg",
                Position = "current",
                Name = "Encarnacion Martin",
                AthleteNumber = 40912,
                BeatsPerMinute = 105,
                TopSpeed = 5.5,
                Registered = "2017-01-11T12:52:28 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/th.png",
                CountryName = "Thailand"
            }); this.Add(new AthleteItem()
            {
                Id = 93,
                Avatar = "assets/images/women/21.jpg",
                Position = "up",
                Name = "Sara Hannula",
                AthleteNumber = 22025,
                BeatsPerMinute = 102,
                TopSpeed = 4.2,
                Registered = "2017-10-09T11:32:13 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/tl.png",
                CountryName = "Timor-Leste"
            }); this.Add(new AthleteItem()
            {
                Id = 147,
                Avatar = "assets/images/men/8.jpg",
                Position = "down",
                Name = "میلاد یاسمی",
                AthleteNumber = 44023,
                BeatsPerMinute = 104,
                TopSpeed = 5.2,
                Registered = "2017-06-10T04:11:01 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/tg.png",
                CountryName = "Togo"
            }); this.Add(new AthleteItem()
            {
                Id = 131,
                Avatar = "assets/images/women/61.jpg",
                Position = "down",
                Name = "Veronika Huber",
                AthleteNumber = 18146,
                BeatsPerMinute = 103,
                TopSpeed = 5.2,
                Registered = "2017-07-13T02:23:56 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/to.png",
                CountryName = "Tonga"
            }); this.Add(new AthleteItem()
            {
                Id = 122,
                Avatar = "assets/images/women/71.jpg",
                Position = "down",
                Name = "Natalie Conrad",
                AthleteNumber = 42602,
                BeatsPerMinute = 108,
                TopSpeed = 6,
                Registered = "2017-03-18T06:35:44 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/tt.png",
                CountryName = "Trinidad and Tobago"
            }); this.Add(new AthleteItem()
            {
                Id = 113,
                Avatar = "assets/images/women/36.jpg",
                Position = "current",
                Name = "Marialba Nascimento",
                AthleteNumber = 47061,
                BeatsPerMinute = 108,
                TopSpeed = 5.2,
                Registered = "2017-09-19T05:47:21 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/tn.png",
                CountryName = "Tunisia"
            }); this.Add(new AthleteItem()
            {
                Id = 135,
                Avatar = "assets/images/men/84.jpg",
                Position = "down",
                Name = "Darryl Douglas",
                AthleteNumber = 35826,
                BeatsPerMinute = 96,
                TopSpeed = 4.6,
                Registered = "2017-07-20T11:45:52 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/tr.png",
                CountryName = "Turkey"
            }); this.Add(new AthleteItem()
            {
                Id = 130,
                Avatar = "assets/images/men/94.jpg",
                Position = "up",
                Name = "Adem Özdoğan",
                AthleteNumber = 45143,
                BeatsPerMinute = 90,
                TopSpeed = 5.5,
                Registered = "2017-02-16T07:11:52 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/tm.png",
                CountryName = "Turkmenistan"
            }); this.Add(new AthleteItem()
            {
                Id = 14,
                Avatar = "assets/images/women/84.jpg",
                Position = "up",
                Name = "Ömür Denkel",
                AthleteNumber = 31061,
                BeatsPerMinute = 104,
                TopSpeed = 4.5,
                Registered = "2017-02-18T05:32:55 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/tv.png",
                CountryName = "Tuvalu"
            }); this.Add(new AthleteItem()
            {
                Id = 43,
                Avatar = "assets/images/women/77.jpg",
                Position = "down",
                Name = "Cathalijne Van Der Ree",
                AthleteNumber = 45160,
                BeatsPerMinute = 102,
                TopSpeed = 5.4,
                Registered = "2017-02-13T05:23:49 -02:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/ug.png",
                CountryName = "Uganda"
            }); this.Add(new AthleteItem()
            {
                Id = 164,
                Avatar = "assets/images/women/51.jpg",
                Position = "current",
                Name = "Ethel Stephens",
                AthleteNumber = 18692,
                BeatsPerMinute = 94,
                TopSpeed = 4.1,
                Registered = "2017-02-13T05:03:04 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ua.png",
                CountryName = "Ukraine"
            }); this.Add(new AthleteItem()
            {
                Id = 167,
                Avatar = "assets/images/men/67.jpg",
                Position = "down",
                Name = "Aatu Ranta",
                AthleteNumber = 38049,
                BeatsPerMinute = 94,
                TopSpeed = 5.1,
                Registered = "2017-07-21T04:22:18 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/ae.png",
                CountryName = "United Arab Emirates"
            }); this.Add(new AthleteItem()
            {
                Id = 169,
                Avatar = "assets/images/men/44.jpg",
                Position = "up",
                Name = "Aziz Santos",
                AthleteNumber = 38947,
                BeatsPerMinute = 98,
                TopSpeed = 4,
                Registered = "2017-04-03T02:18:46 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/gb.png",
                CountryName = "United Kingdom"
            }); this.Add(new AthleteItem()
            {
                Id = 170,
                Avatar = "assets/images/men/60.jpg",
                Position = "up",
                Name = "Fernando Gimenez",
                AthleteNumber = 31290,
                BeatsPerMinute = 102,
                TopSpeed = 5.1,
                Registered = "2017-06-21T06:45:54 -03:00",
                TrackProgress = 3,
                CountryFlag = "assets/images/grid/flags/uz.png",
                CountryName = "Uruguay"
            }); this.Add(new AthleteItem()
            {
                Id = 124,
                Avatar = "assets/images/men/98.jpg",
                Position = "down",
                Name = "Mathieu Mathieu",
                AthleteNumber = 10555,
                BeatsPerMinute = 101,
                TopSpeed = 5.2,
                Registered = "2017-01-05T07:28:11 -02:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/uz.png",
                CountryName = "Uzbekistan"
            }); this.Add(new AthleteItem()
            {
                Id = 193,
                Avatar = "assets/images/women/9.jpg",
                Position = "down",
                Name = "Juanita Franklin",
                AthleteNumber = 13907,
                BeatsPerMinute = 91,
                TopSpeed = 6,
                Registered = "2017-10-04T02:46:46 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/vu.png",
                CountryName = "Vanuatu"
            }); this.Add(new AthleteItem()
            {
                Id = 25,
                Avatar = "assets/images/men/42.jpg",
                Position = "up",
                Name = "Stanley Hart",
                AthleteNumber = 14150,
                BeatsPerMinute = 91,
                TopSpeed = 4.5,
                Registered = "2017-08-19T03:02:33 -03:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/ve.png",
                CountryName = "Venezuela"
            }); this.Add(new AthleteItem()
            {
                Id = 131,
                Avatar = "assets/images/women/61.jpg",
                Position = "current",
                Name = "Eliza Bishop",
                AthleteNumber = 31774,
                BeatsPerMinute = 96,
                TopSpeed = 4.7,
                Registered = "2017-09-22T11:49:02 -03:00",
                TrackProgress = 4,
                CountryFlag = "assets/images/grid/flags/eh.png",
                CountryName = "Western Sahara"
            }); this.Add(new AthleteItem()
            {
                Id = 34,
                Avatar = "assets/images/women/19.jpg",
                Position = "down",
                Name = "Linda Schäfer",
                AthleteNumber = 43074,
                BeatsPerMinute = 107,
                TopSpeed = 5.1,
                Registered = "2017-01-05T11:41:20 -02:00",
                TrackProgress = 2,
                CountryFlag = "assets/images/grid/flags/ye.png",
                CountryName = "Yemen"
            });
        }
    }
}
