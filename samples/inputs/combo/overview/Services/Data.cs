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
                    Id = "BG01",
                    Name = "Sofia",
                    Country = "Bulgaria",
                },
                new City {
                    Id = "US01",
                    Name = "New York",
                    Country = "United States",
                },
            };

            return data;
        }
    }
}
