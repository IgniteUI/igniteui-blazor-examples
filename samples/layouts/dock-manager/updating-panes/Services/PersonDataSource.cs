using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Samples
{
    public class PersonLocation
    {
        public string City { get; set; }
        public double Latitude  { get; set; }
        public double Longitude { get; set; }

        private string _Country;
        public string Country
        {
            get { return _Country; }
            set { if (_Country != value) { OnCountryChanged(value); } }
        }

        public string CountryFlag { get; set; }

        protected void OnCountryChanged(string countryName)
        {
            // syncronizing country name and country flag
            _Country = countryName;
            CountryFlag = DataGenerator.GetCountryFlag(countryName);
            OnPropertyChanged("Country");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

    public class PersonInfo : PersonLocation, INotifyPropertyChanged
    {
        public string ID { get; set; }
        public string Address { get; set; }
        public double Age { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public double Salary { get; set; }
        public double Sales { get; set; }
        public string Income { get; set; }
        public int Index { get; set; }
        public string Background { get; set; }

        public DateTime Birthday { get; set; }
        public List<PersonProductivity> Productivity { get; set; }

    }

    public class PersonProductivity
    {
        public double Value { get; set; }
        public string Month { get; set; }
    }

    public static class PersonDataSource
    {
        public static List<PersonInfo> Create(int? count)
        {
            if (count == null) count = 100;

            var locations = GetLocations();

            var managers = new List<PersonInfo>();
            for (int i = 0; i < count; i++)
            {
                var age = Math.Round(DataGenerator.GetNumber(20, 40));
                var gender = DataGenerator.GetGender();
                var firstName = DataGenerator.GetNameFirst(gender);
                var lastName = DataGenerator.GetNameLast();
                var street = DataGenerator.GetStreet();
                var email = firstName.ToLower() + "@" + DataGenerator.GetEmail();
                var photoPath = DataGenerator.GetPhoto(gender);

                var manager = new PersonInfo
                {
                    Index = i,
                    Age = age,
                    Birthday = DataGenerator.GetBirthday(),
                    Email = email,
                    Gender = gender,
                    ID = DataGenerator.Pad(1001 + i, 4),
                    Name = firstName + " " + lastName,
                    Photo = photoPath,
                    Phone = DataGenerator.GetPhone(),
                    Salary = DataGenerator.GetNumber(40, 200) * 1000,
                    Sales = DataGenerator.GetNumber(200, 980) * 1000,
                    Background = "Transparent",

                };

                var location = GetRandom(locations);
                manager.Address = street + ", " + location.City;
                manager.City = location.City;
                manager.Country = location.Country;
                manager.Latitude = location.Latitude;
                manager.Longitude = location.Longitude;
                manager.Income = DataGenerator.GetIncomeRange(manager.Salary);
                manager.Productivity = GetProductivity();

                managers.Add(manager);
            }

            return managers;
        }

        public static List<PersonProductivity> GetProductivity()
        {
            var productivity = new List<PersonProductivity>();
            var months = new List<string> {
                "JAN", "FEB", "MAR", "APR", "MAY", "JUN",
                "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };

            var value = 50.0;
            for (var i = 0; i < months.Count; i++)
            {
                value += DataGenerator.GetNumber(-5, 10);
                var prod = new PersonProductivity
                {
                    Value = value,
                    Month = months[i]
                };
                productivity.Add(prod);
            };

            return productivity;
        }

        public static PersonLocation GetRandom(List<PersonLocation> array)
        {
            var index = (int)Math.Round(DataGenerator.GetNumber(0, array.Count - 1));
            return array[index];
        }

        public static List<PersonLocation> GetLocations()
        {
            var locations = new List<PersonLocation> {
                new PersonLocation { Latitude = 54.689, Longitude = 25.276, Country = "Lithuania", City = "Vilnius" },
                new PersonLocation { Latitude = 53.900, Longitude = 27.576, Country = "Belarus", City = "Minsk" },
                new PersonLocation { Latitude = 53.342, Longitude = -6.257, Country = "Ireland", City = "Dublin" },
                new PersonLocation { Latitude = 52.516, Longitude = 13.328, Country = "Germany", City = "Berlin" },
                new PersonLocation { Latitude = 52.373, Longitude = 4.895, Country = "Netherlands", City = "Amsterdam" },
                new PersonLocation { Latitude = 52.245, Longitude = 21.012, Country = "Poland", City = "Warsaw" },
                new PersonLocation { Latitude = 51.488, Longitude = -0.178, Country = "UK", City = "London" },
                new PersonLocation { Latitude = 50.448, Longitude = 30.502, Country = "Ukraine", City = "Kiev" },
                new PersonLocation { Latitude = 50.106, Longitude = 14.457, Country = "Czech-Republic", City = "Prague" },
                new PersonLocation { Latitude = 48.882, Longitude = 2.433, Country = "France", City = "Paris" },
                new PersonLocation { Latitude = 48.202, Longitude = 16.321, Country = "Austria", City = "Vienna" },
                new PersonLocation { Latitude = 47.515, Longitude = 19.094, Country = "Hungary", City = "Budapest" },
                new PersonLocation { Latitude = 46.948, Longitude = 7.446, Country = "Switzerland", City = "Bern" },
                new PersonLocation { Latitude = 45.374, Longitude = -75.651, Country = "Canada", City = "Ottawa" },
                new PersonLocation { Latitude = 43.255, Longitude = 76.913, Country = "Kazakhstan", City = "Almaty" },
                new PersonLocation { Latitude = 42.707, Longitude = 23.332, Country = "Bulgaria", City = "Sofia" },
                new PersonLocation { Latitude = 41.722, Longitude = 44.783, Country = "Georgia", City = "Tbilisi" },
                new PersonLocation { Latitude = 40.442, Longitude = -3.691, Country = "Spain", City = "Madrid" },
                new PersonLocation { Latitude = 39.929, Longitude = 32.853, Country = "Turkey", City = "Ankara" },
                new PersonLocation { Latitude = 39.906, Longitude = 116.388, Country = "China", City = "Beijing" },
                new PersonLocation { Latitude = 39.029, Longitude = 125.758, Country = "Korea-North", City = "Pyongyang" },
                new PersonLocation { Latitude = 38.891, Longitude = -76.954, Country = "USA", City = "Washington" },
                new PersonLocation { Latitude = 37.950, Longitude = 58.390, Country = "Turkmenistan", City = "Ashkhabad" },
                new PersonLocation { Latitude = 37.542, Longitude = 126.935, Country = "Korea-South", City = "Seoul" },
                new PersonLocation { Latitude = 36.819, Longitude = 10.166, Country = "Tunisia", City = "Tunis" },
                new PersonLocation { Latitude = 35.774, Longitude = 51.448, Country = "Iran", City = "Tehran" },
                new PersonLocation { Latitude = 35.683, Longitude = 139.809, Country = "Japan", City = "Tokyo" },
                new PersonLocation { Latitude = 34.531, Longitude = 69.137, Country = "Afghanistan", City = "Kabul" },
                new PersonLocation { Latitude = 33.718, Longitude = 73.061, Country = "Pakistan", City = "Islamabad" },
                new PersonLocation { Latitude = 33.519, Longitude = 36.313, Country = "Syria", City = "Damascus" },
                new PersonLocation { Latitude = 33.334, Longitude = 44.398, Country = "Iraq", City = "Baghdad" },
                new PersonLocation { Latitude = 31.949, Longitude = 35.933, Country = "Jordan", City = "Amman" },
                new PersonLocation { Latitude = 30.078, Longitude = 31.251, Country = "Egypt", City = "Cairo" },
                new PersonLocation { Latitude = 28.569, Longitude = 77.217, Country = "India", City = "New Delhi" },
                new PersonLocation { Latitude = 27.712, Longitude = 85.313, Country = "Nepal", City = "Kathmandu" },
                new PersonLocation { Latitude = 25.204, Longitude = 51.497, Country = "Qatar", City = "Doha" },
                new PersonLocation { Latitude = 25.035, Longitude = 121.507, Country = "Taiwan", City = "Taipei" },
                new PersonLocation { Latitude = 23.710, Longitude = 90.407, Country = "Bangladesh", City = "Dhaka" },
                new PersonLocation { Latitude = 21.032, Longitude = 105.820, Country = "Vietnam", City = "Hanoi" },
                new PersonLocation { Latitude = 19.427, Longitude = -99.128, Country = "Mexico", City = "Mexico City" },
                new PersonLocation { Latitude = 18.527, Longitude = -72.343, Country = "Haiti", City = "Port-au-Prince" },
                new PersonLocation { Latitude = 18.016, Longitude = -76.797, Country = "Jamaica", City = "Kingston" },
                new PersonLocation { Latitude = 16.872, Longitude = 96.125, Country = "Myanmar", City = "Rangoon" },
                new PersonLocation { Latitude = 15.361, Longitude = 44.210, Country = "Yemen", City = "Sanaa" },
                new PersonLocation { Latitude = 14.618, Longitude = -90.525, Country = "Guatemala", City = "Guatemala" },
                new PersonLocation { Latitude = 14.099, Longitude = -87.203, Country = "Honduras", City = "Tegucigalpa" },
                new PersonLocation { Latitude = 13.746, Longitude = 100.553, Country = "Thailand", City = "Bangkok" },
                new PersonLocation { Latitude = 13.605, Longitude = 2.083, Country = "Niger", City = "Niamey" },
                new PersonLocation { Latitude = 12.653, Longitude = -7.986, Country = "Mali", City = "Bamako" },
                new PersonLocation { Latitude = 12.151, Longitude = -86.273, Country = "Nicaragua", City = "Managua" },
                new PersonLocation { Latitude = 10.496, Longitude = -66.898, Country = "Venezuela", City = "Caracas" },
                new PersonLocation { Latitude = 9.930, Longitude = -84.079, Country = "Costa-Rica", City = "San Jose" },
                new PersonLocation { Latitude = 5.559, Longitude = -0.201, Country = "Ghana", City = "Accra" },
                new PersonLocation { Latitude = 5.325, Longitude = -4.022, Country = "Ivory-Coast", City = "Abidjan" },
                new PersonLocation { Latitude = 4.630, Longitude = -74.081, Country = "Colombia", City = "Bogota" },
                new PersonLocation { Latitude = 3.865, Longitude = 11.514, Country = "Cameroon", City = "Yaounde" },
            };
            return locations;
        }

    }
}