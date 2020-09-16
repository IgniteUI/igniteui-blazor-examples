using System;
using System.Collections.Generic; 

namespace Infragistics.Samples
{
    public class Employee
    {
        public string ID { get; set; }
        public string Address { get; set; }
        public double Age { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string CountryFlag { get; set; }
        public string City { get; set; }
        public string Generation { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public double Salary { get; set; }
        public double Sales { get; set; }
        public string Website { get; set; }
        public string Income { get; set; }

        public DateTime Birthday { get; set; }
        public List<Productivity> Productivity { get; set; }
    }

    public class Productivity
    {
        public double Value { get; set; }
        public int Week { get; set; }
    }

    public static class EmployeeData
    {           
        public static List<Employee> Create(int? count, bool? useProductivity)
        {
            if (count == null) count = 100;
             
            var employees = new List<Employee>();
            for (int i = 0; i < count; i++)
            {
                var age = Math.Round(DataGenerator.GetNumber(20, 40));
                var gender = DataGenerator.GetGender();
                var firstName = DataGenerator.GetNameFirst(gender);
                var lastName = DataGenerator.GetNameLast();
                var street = DataGenerator.GetStreet();
                var country = DataGenerator.GetCountry();
                var city = DataGenerator.GetCity(country);
                var generation = Math.Floor(age / 10) * 10 + "s";
                var email = firstName.ToLower() + "@" + DataGenerator.GetEmail();
                var website = firstName.ToLower() + DataGenerator.GetWebsite();

                var photoPath = DataGenerator.GetPhoto(gender);                 

                var employee = new Employee
                {
                    Address = street + ", " + city,
                    Age = age,
                    Birthday = DataGenerator.GetBirthday(),
                    City = DataGenerator.GetCity(country),
                    Country = DataGenerator.GetCountry(),
                    CountryFlag = DataGenerator.GetCountryFlag(country),
                    Email = email,
                    Gender = DataGenerator.GetGender(),
                    Generation = generation,
                    ID = DataGenerator.Pad(1001 + i, 4),
                    FirstName = firstName,
                    LastName = lastName,
                    Name = firstName + " " + lastName,
                    Photo = photoPath,
                    Phone = DataGenerator.GetPhone(),
                    Street = DataGenerator.GetStreet(),
                    Salary = DataGenerator.GetNumber(40, 200) * 1000, 
                    Sales = DataGenerator.GetNumber(200, 980) * 1000,
                    Website = website, 
                };
                employee.Income = DataGenerator.GetIncomeRange(employee.Salary);
                if (useProductivity.HasValue && useProductivity.Value)
                {
                    employee.Productivity = GetProductivity(20);
                }
                employees.Add(employee);
            }

            return employees;
        }
            
        public static List<Productivity> GetProductivity(int weekCount)
        {            
            var productivity = new List<Productivity>();

            for (var w = 1; w <= weekCount; w++)
            {
                var value = DataGenerator.GetNumber(-50, 50);
                var prod = new Productivity
                {
                    Value = value, Week = w
                };
                //Console.WriteLine("productivity " + w + " " + value);
                productivity.Add(prod);
            };
            
            return productivity;
        }
        

        
       
        public class House
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

        public static List<House> GetHouses(int? count)
        {
            if (count == null)
            {
                count = 250;
            }
            
            string[] property = { "Townhouse", "Single", "Condo", "Villa" };
            string[] emails = { "estates.com", "remax.com", "zillow.com", "realtor.com", "coldwell.com" };
            string[] countries = { "USA", "UK", "France", "Canada", "Poland", "Japan", "Germany" };
            List<House> houses = new List<House>();

            for (var i = 0; i < count; i++)
            {
                var year = DataGenerator.GetNumber(1950, 2015);
                var age = 2020 - year;

                var gender = DataGenerator.GetGender();
                var firstName = DataGenerator.GetNameFirst(gender);
                var lastName = DataGenerator.GetNameLast();
                var initials = firstName.Substring(0, 1).ToLower();
                var email = initials  + firstName.ToLower() + "@" + DataGenerator.GetItem(emails);
                var street = DataGenerator.GetStreet();
                var country = DataGenerator.GetItem(countries);
                var city = DataGenerator.GetCity(country);

                houses.Add(new House
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
                    ID = DataGenerator.Pad(i + 1, 5),
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

