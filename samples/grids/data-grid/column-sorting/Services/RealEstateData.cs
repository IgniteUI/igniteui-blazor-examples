using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class RealEstate
    {
        public string ID { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string CountryFlag { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public double Age { get; set; }
        public double Baths { get; set; }
        public double Built { get; set; }
        public string Property { get; set; }
        public double Rooms { get; set; }
        public string Agent { get; set; }
        public double Area { get; set; }
        public double Price { get; set; }
        public DateTime SaleDate { get; set; }
    }

    public static class RealEstateData
    {
        public static List<RealEstate> Create(int? count)
        {
            if (count == null) count = 100;

            string[] property = { "Townhouse", "Single", "Condo", "Villa" };
            string[] emails = { "estates.com", "remax.com", "zillow.com", "realtor.com", "coldwell.com" };
            string[] countries = { "USA", "UK", "France", "Canada", "Poland", "Japan", "Germany" };
            var houses = new List<RealEstate>();

            for (var i = 0; i < count; i++)
            {
                var year = DataGenerator.GetNumber(1950, 2015);
                var age = 2020 - year;

                var gender = DataGenerator.GetGender();
                var firstName = DataGenerator.GetNameFirst(gender);
                var lastName = DataGenerator.GetNameLast();
                var initials = firstName.Substring(0, 1).ToLower();
                var email = initials + firstName.ToLower() + "@" + DataGenerator.GetItem(emails);
                var street = DataGenerator.GetStreet();
                var country = DataGenerator.GetItem(countries);
                var city = DataGenerator.GetCity(country);

                houses.Add(new RealEstate
                {
                    Address = street,
                    Age = age,
                    Agent = firstName + " " + lastName,
                    Area = DataGenerator.GetNumber(50, 300),
                    Baths = DataGenerator.GetNumber(1, 3),
                    Built = year,
                    City = city,
                    Country = country,
                    CountryFlag = DataGenerator.GetCountryFlag(country),
                    Email = email,
                    ID = DataGenerator.Pad(i + 1001, 4),
                    Phone = DataGenerator.GetPhone(),
                    Price = DataGenerator.GetNumber(210, 900) * 1000,
                    Property = DataGenerator.GetItem(property),
                    Rooms = DataGenerator.GetNumber(2, 5),
                    SaleDate = DataGenerator.GetDate(),
                    Street = street
                });
            }
            return houses;
        }
    }
}