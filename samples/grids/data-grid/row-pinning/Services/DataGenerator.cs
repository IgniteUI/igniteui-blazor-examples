using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Samples
{
    public static class DataGenerator
    {
        readonly static string[] websites = { ".com", ".gov", ".edu", ".org" };
        readonly static string[] emails = { "gmail.com", "yahoo.com", "twitter.com" };
        readonly static string[] genders = { "male", "female" };
        readonly static string[] maleNames = { "Kyle", "Oscar", "Ralph", "Mike", "Bill", "Frank", "Howard", "Jack", "Larry", "Pete", "Steve", "Vince", "Mark", "Alex", "Max", "Brian", "Chris", "Andrew", "Martin", "Mike", "Steve", "Glenn", "Bruce" };
        readonly static string[] femaleNames = { "Gina", "Irene", "Katie", "Brenda", "Casey", "Fiona", "Holly", "Kate", "Liz", "Pamela", "Nelly", "Marisa", "Monica", "Anna", "Jessica", "Sofia", "Isabella", "Margo", "Jane", "Audrey", "Sally", "Melanie", "Greta", "Aurora", "Sally" };
        readonly static string[] lastNames = { "Adams", "Crowley", "Ellis", "Martinez", "Irvine", "Maxwell", "Clark", "Owens", "Rooney", "Lincoln", "Thomas", "Spacey", "MOrgan", "King", "Newton", "Fitzgerald", "Holmes", "Jefferson", "Landry", "Berry", "Perez", "Spencer", "Starr", "Carter", "Edwards", "Stark", "Johnson", "Fitz", "Chief", "Blanc", "Perry", "Stone", "Williams", "Lane", "Jobs", "Adams", "Power", "Tesla" };
        readonly static string[] countries = { "USA", "UK", "France", "Canada", "Poland" };
        readonly static string[] citiesUS = { "New York", "Los Angeles", "Miami", "San Francisco", "San Diego", "Las Vegas" };
        readonly static string[] citiesUK = { "London", "Liverpool", "Manchester" };
        readonly static string[] citiesFR = { "Paris", "Marseille", "Lyon" };
        readonly static string[] citiesCA = { "Toronto", "Vancouver", "Montreal" };
        readonly static string[] citiesPL = { "Krakow", "Warsaw", "Wroclaw", "Gdansk" };
        readonly static string[] citiesJP = { "Tokyo", "Osaka", "Kyoto", "Yokohama" };
        readonly static string[] citiesGR = { "Berlin", "Bonn", "Cologne", "Munich", "Hamburg" };
        readonly static string[] roadSuffixes = { "Road", "Street", "Way" };
        readonly static string[] roadNames = { "Main", "Garden", "Broad", "Oak", "Cedar", "Park", "Pine", "Elm", "Market", "Hill" };

        public static Random Rand = new Random();

        public static string GetWebsite()
        {
            return GetItem(websites);
        }

        public static string GetEmail()
        {
            return GetItem(emails);
        }

        public static double GetNumber(double min, double max)
        {
            return Math.Round(min + (Rand.NextDouble() * (max - min)));
        }

        public static int GetInteger(double min, double max)
        {
            return (int)GetNumber(min, max);
        }

        public static string GetPhone()
        {
            var phoneCode = GetNumber(100, 900);
            var phoneNum1 = GetNumber(100, 900);
            var phoneNum2 = GetNumber(1000, 9000);
            var phone = phoneCode + "-" + phoneNum1 + "-" + phoneNum2;
            return phone;
        }

        public static string GetGender()
        {
            return GetItem(genders);
        }

        public static string GetNameFirst(string gender)
        {
            if (gender == "male")
                return GetItem(maleNames);
            else
                return GetItem(femaleNames);
        }

        public static string GetNameLast()
        {
            return GetItem(lastNames);
        }

        public static string GetItem(string[] array)
        {
            var index = (int)Math.Round(GetNumber(0, array.Length - 1));
            return array[index];
        }

        public static string GetCountry()
        {
            return GetItem(countries);
        }

        public static string GetCity(string country)
        {
            if (country == "Canada")
            {
                return GetItem(citiesCA);
            }
            else if (country == "France")
            {
                return GetItem(citiesFR);
            }
            else if (country == "Poland")
            {
                return GetItem(citiesPL);
            }
            else if (country == "USA")
            {
                return GetItem(citiesUS);
            }
            else if (country == "Japan")
            {
                return GetItem(citiesJP);
            }
            else if (country == "Germany")
            {
                return GetItem(citiesGR);
            }
            else
            { // if (country === "United Kingdom") {
                return GetItem(citiesUK);
            }
        }

        public static string GetStreet()
        {
            var num = Math.Round(GetNumber(100, 300)).ToString();
            var road = GetItem(roadNames);
            var suffix = GetItem(roadSuffixes);
            return num + " " + road + " " + suffix;
        }

        public static DateTime GetBirthday()
        {
            var year = DateTime.Now.Year - GetInteger(30, 50);
            var month = GetNumber(10, 12);
            var day = GetNumber(20, 27);
            return new DateTime(year, (int)month, (int)day);
        }

        public static DateTime GetDate()
        {
            var year = DateTime.Now.Year;
            var month = GetNumber(10, 12);
            var day = GetNumber(20, 27);
            return new DateTime(year, (int)month, (int)day);
        }

        public static string Pad(int num, int size)
        {
            var s = num + "";
            while (s.Length < size)
            {
                s = "0" + s;
            }
            return s;
        }

        public static string GetPhotoMale(int id)
        {
            return "https://static.infragistics.com/xplatform/images/people/GUY" + Pad(id, 2) + ".png";
        }

        public static string GetPhotoFemale(int id)
        {
            return "https://static.infragistics.com/xplatform/images/people/GIRL" + Pad(id, 2) + ".png";
        }

        private static int maleCount = 0;
        private static int femaleCount = 0;
        public static string GetPhoto(string gender)
        {
            if (gender == "male")
            {
                maleCount++;
                if (maleCount > 24) maleCount = 1;
                return GetPhotoMale(maleCount);
            }
            else
            {
                femaleCount++;
                if (femaleCount > 24) femaleCount = 1;
                return GetPhotoFemale(femaleCount);
            }
        }

        public static string GetGenderPhoto(string gender)
        {
            return "https://static.infragistics.com/xplatform/images/genders/" + gender + ".png";
        }

        public static string GetCountryFlag(string country)
        {
            return "https://static.infragistics.com/xplatform/images/flags/" + country + ".png";
        }

        public static string GetIncomeRange(double salary)
        {
            if (salary < 50000)
            {
                return "Low";
            }
            else if (salary < 100000)
            {
                return "Average";
            }
            else
            {
                return "High";
            }
        }

    }

}