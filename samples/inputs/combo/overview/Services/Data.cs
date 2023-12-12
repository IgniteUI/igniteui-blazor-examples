using System;
using System.Collections;
using System.Collections.Generic;


namespace Infragistics.Samples
{
    public class City {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }

    public class SampleData {
        public static List<City> Cities = GetCities();

        public static List<City> GetCities() {
            var data = new List<City> {
                new City {
                    Id = "UK01",
                    Name = "London",
                    Country = "United Kingdom",
                },
                new City {
                    Id = "UK02",
                    Name = "Manchester",
                    Country = "United Kingdom",
                },
                new City {
                    Id = "UK03",
                    Name = "Birmingham",
                    Country = "United Kingdom",
                },
                new City {
                    Id = "UK04",
                    Name = "Glasgow",
                    Country = "United Kingdom",
                },
                new City {
                    Id = "UK05",
                    Name = "Liverpool",
                    Country = "United Kingdom",
                },
                new City {
                    Id = "US01",
                    Name = "New York",
                    Country = "United States of America",
                },
                new City {
                    Id = "US02",
                    Name = "Miami",
                    Country = "United States of America",
                },
                new City {
                    Id = "US03",
                    Name = "Philadelphia",
                    Country = "United States of America",
                },
                new City {
                    Id = "US04",
                    Name = "Chicago",
                    Country = "United States of America",
                },
                new City {
                    Id = "US05",
                    Name = "Springfield",
                    Country = "United States of America",
                },
                new City {
                    Id = "US06",
                    Name = "Los Angeles",
                    Country = "United States of America",
                },
                new City {
                    Id = "US07",
                    Name = "Houston",
                    Country = "United States of America",
                },
                new City {
                    Id = "US08",
                    Name = "Phoenix",
                    Country = "United States of America",
                },
                new City {
                    Id = "US09",
                    Name = "San Diego",
                    Country = "United States of America",
                },
                new City {
                    Id = "US10",
                    Name = "Dallas",
                    Country = "United States of America",
                },
                new City {
                    Id = "BG01",
                    Name = "Sofia",
                    Country = "Bulgaria",
                },
                new City {
                    Id = "BG02",
                    Name = "Plovdiv",
                    Country = "Bulgaria",
                },
                new City {
                    Id = "BG03",
                    Name = "Varna",
                    Country = "Bulgaria",
                },
                new City {
                    Id = "BG04",
                    Name = "Burgas",
                    Country = "Bulgaria",
                },
                new City {
                    Id = "IT01",
                    Name = "Rome",
                    Country = "Italy",
                },
                new City {
                    Id = "IT02",
                    Name = "Milan",
                    Country = "Italy",
                },
                new City {
                    Id = "IT03",
                    Name = "Naples",
                    Country = "Italy",
                },
                new City {
                    Id = "IT04",
                    Name = "Turin",
                    Country = "Italy",
                },
                new City {
                    Id = "IT05",
                    Name = "Palermo",
                    Country = "Italy",
                },
                new City {
                    Id = "IT06",
                    Name = "Florence",
                    Country = "Italy",
                },
            };

            return data;
        }
    }
}
