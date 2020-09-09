using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class DataGridSharedData
    {
        public static Random Rand = new Random();

        public class Employee
        {
            public string ID { get; set; }
            public string Address { get; set; }
            public double Age { get; set; }
            public DateTime Birthday { get; set; }
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
            public List<object> Productivity { get; set; } 
            public double Salary { get; set; }
            public double Sales { get; set; }
            public string Website { get; set; }
            public string Income { get; set; }
        }

        public static List<Employee> GetEmployees(int? count)
        {
            if(count == null)
            {
                count = 250;
            }

            var employees = new List<Employee>() { };

            int maleCount = 0;
            int femaleCount = 0;
           
            for (int i = 0; i < count; i++)
            {
                var age = Math.Round(GetRandomNumber(20, 40));
                var gender = GetRandomGender();
                var firstName = GetRandomNameFirst(gender);
                var lastName = GetRandomNameLast();
                var street = GetRandomStreet();
                var country = GetRandomItem(countries);
                var city = GetRandomCity(country);
                var generation = Math.Floor(age / 10) * 10 + "s";
                var email = firstName.ToLower() + "@" + GetRandomItem(emails);
                var website = firstName.ToLower() + "-" + GetRandomItem(websites);

                var photoPath = "";

                if (gender == "male")
                {
                    maleCount++;
                    if (maleCount > 26)
                    {
                        maleCount = 1;
                    }
                    photoPath = GetPhotoMale(maleCount);
                }
                else
                {
                    femaleCount++;
                    if (femaleCount > 24)
                    {
                        femaleCount = 1;
                    }
                    photoPath = GetPhotoFemale(femaleCount);
                }

                Employee employee = new Employee
                {
                    Address = street + "," + city,
                    Age = age,
                    Birthday = GetBirthday(),
                    City = GetRandomCity(country),
                    Country = GetRandomItem(countries),
                    CountryFlag = GetCountryFlag(country),
                    Email = email,
                    FirstName = firstName,
                    Gender = GetRandomGender(),
                    Generation = generation,
                    ID = Pad(i + 1, 5),
                    LastName = lastName,
                    Name = firstName + lastName,
                    Phone = GetRandomPhone(),
                    Photo = photoPath,
                    Street = GetRandomStreet(),
                    Salary = GetRandomNumber(40, 200) * 1000, 
                    Sales = GetRandomNumber(200, 980) * 1000,
                    Website = website,
                    //TODO
                    //Productivity = GetProductivity(Rand.Next())
                  
                };

                if (employee.Salary < 50000)
                {
                    employee.Income = "Low";
                }
                else if (employee.Salary < 100000)
                {
                    employee.Income = "Average";
                }
                else
                {
                    employee.Income = "High";
                }

                employees.Add(employee);

            }
            return employees;
        }


        private static string[] websites = { ".com", ".gov", ".edu", ".org" };
        private static string[] emails = { "gmail.com", "yahoo.com", "twitter.com" };
        private static string[] genders = {"male", "female"};
        private static string[] maleNames = {"Kyle", "Oscar", "Ralph", "Mike", "Bill", "Frank", "Howard", "Jack", "Larry", "Pete", "Steve", "Vince", "Mark", "Alex", "Max", "Brian", "Chris", "Andrew", "Martin", "Mike", "Steve", "Glenn", "Bruce"};
        private static string[] femaleNames = {"Gina", "Irene", "Katie", "Brenda", "Casey", "Fiona", "Holly", "Kate", "Liz", "Pamela", "Nelly", "Marisa", "Monica", "Anna", "Jessica", "Sofia", "Isabella", "Margo", "Jane", "Audrey", "Sally", "Melanie", "Greta", "Aurora", "Sally"};
        private static string[] lastNames = {"Adams", "Crowley", "Ellis", "Martinez", "Irvine", "Maxwell", "Clark", "Owens", "Rooney", "Lincoln", "Thomas", "Spacey", "MOrgan", "King", "Newton", "Fitzgerald", "Holmes", "Jefferson", "Landry", "Berry", "Perez", "Spencer", "Starr", "Carter", "Edwards", "Stark", "Johnson", "Fitz", "Chief", "Blanc", "Perry", "Stone", "Williams", "Lane", "Jobs", "Adams", "Power", "Tesla"};
        private static string[] countries = {"USA", "UK", "France", "Canada", "Poland"};
        private static string[] citiesUS = {"New York", "Los Angeles", "Miami", "San Francisco", "San Diego", "Las Vegas"};
        private static string[] citiesUK = {"London", "Liverpool", "Manchester"};
        private static string[] citiesFR = {"Paris", "Marseille", "Lyon"};
        private static string[] citiesCA = {"Toronto", "Vancouver", "Montreal"};
        private static string[] citiesPL = {"Krakow", "Warsaw", "Wroclaw", "Gdansk"};
        private static string[] citiesJP = {"Tokyo", "Osaka", "Kyoto", "Yokohama"};
        private static string[] citiesGR = {"Berlin", "Bonn", "Cologne", "Munich", "Hamburg"};
        private static string[] roadSuffixes = {"Road", "Street", "Way"};
        private static string[] roadNames = {"Main", "Garden", "Broad", "Oak", "Cedar", "Park", "Pine", "Elm", "Market", "Hill"};


        public static double GetRandomNumber(double min, double max)
        {
            Random Rand = new Random();
            return Math.Round(min + (Rand.NextDouble() * (max - min)));
        }

        public static string GetRandomItem(string[] array)
        {
            var index = (int)Math.Round(GetRandomNumber(0, array.Length - 1));
            return array[index];
        }

        public static string GetRandomPhone() {
            var phoneCode = GetRandomNumber(100, 900);
            var phoneNum1 = GetRandomNumber(100, 900);
            var phoneNum2 = GetRandomNumber(1000, 9000);
            var phone = phoneCode + "-" + phoneNum1 + "-" + phoneNum2;
            return phone;
        }

        public static string GetRandomGender() {
            return GetRandomItem(genders);
        }

        public static string GetRandomNameFirst(string gender) {
            if (gender == "male") {
                return GetRandomItem(maleNames);
            }
                else {
                    return GetRandomItem(femaleNames);
            }
        }

        public static string GetRandomNameLast()
        {
            return GetRandomItem(lastNames);
        }

        public static string GetRandomCity(string country) {
            if (country == "Canada") {
                return GetRandomItem(citiesCA);
            } else if (country == "France") {
                        return GetRandomItem(citiesFR);
            } else if (country == "Poland") {
                        return GetRandomItem(citiesPL);
            } else if (country == "USA") {
                        return GetRandomItem(citiesUS);
            } else if (country == "Japan") {
                        return GetRandomItem(citiesJP);
            } else if (country == "Germany") {
                        return GetRandomItem(citiesGR);
            } else { // if (country === "United Kingdom") {
                        return GetRandomItem(citiesUK);
            }
        }

        public static string GetRandomStreet() {
            var num = Math.Round(GetRandomNumber(100, 300)).ToString();
            var road = GetRandomItem(roadNames);
            var suffix = GetRandomItem(roadSuffixes);
            return num + " " + road + " " + suffix;
        }
        
        public static DateTime GetBirthday()
        {
            //TODO add age
            var today = new DateTime();
            var year = today.Year;
            var month = GetRandomNumber(1, 9);
            var day = GetRandomNumber(10, 27);
            return new DateTime(year, (int)month, (int)day);
        }
        private static DateTime GetRandomDate(DateTime start, DateTime end)
        {
            start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(Rand.Next(range));
        }

        public class Productivity
        {
            public double Value { get; set; }
            public int Week { get; set; }
        }

        public static List<object> GetProductivity(double? weekCount)
        {
            if (weekCount == null)
            {
                weekCount = 52;
            }
            var productivity = new List<object>();
            for (var w = 0; w < weekCount; w++)
            {
                var value = GetRandomNumber(-50, 50);
                productivity.Add(new Productivity
                {
                    Value = value, 
                    Week = w
                });
            };
            
            return productivity;
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

        public static string GetPhotoMale(int id) {
            return "https://static.infragistics.com/xplatform/images/people//GUY" + Pad(id, 2) + ".png";
        }

        public static string GetPhotoFemale(int id) {
            return "https://static.infragistics.com/xplatform/images/people/GIRL" + Pad(id, 2) + ".png";
        }

        public static string GetGenderPhoto(string gender) {
            return "https://static.infragistics.com/xplatform/images/genders/" + gender + ".png";
        }

        public static string GetCountryFlag(string country) {
            return "https://static.infragistics.com/xplatform/images/flags/" + country + ".png";
        }

        public class Sale
        {
            public double BundlePrice { get; set; }
            public double ProductPrice { get; set; }
            public double Margin { get; set; }
            public DateTime OrderDate { get; set; }
            public double OrderItems { get; set; }
            public double OrderValue { get; set; }
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public double Profit { get; set; }
            public string Country { get; set; }
            public string CountryFlag { get; set; }
            public string City { get; set; }
            public string Status { get; set; }
        }

        public static List<Sale> GetSales(int? count)
        {
            if (count == null)
            {
                count = 250;
            }

            string[] names = {
                "Intel CPU", "AMD CPU",
                "Intel Motherboard", "AMD Motherboard", "NVIDIA Motherboard",
                "NVIDIA GPU", "GIGABYTE GPU", "Asus GPU", "AMD GPU", "MSI GPU",
                "Corsair Memory", "Patriot Memory", "Skill Memory",
                "Samsung HDD", "WD HDD", "Seagate HDD", "Intel HDD",
                "Samsung SSD", "WD SSD", "Seagate SSD", "Intel SSD",
                "Samsung Monitor", "Asus Monitor", "LG Monitor", "HP Monitor" };
            string[] countries = { "USA", "UK", "France", "Canada", "Poland", "Japan", "Germany" };
            string[] status = { "Packing", "Shipped", "Delivered" };
            List<Sale> sales = new List<Sale>();

            for (var i = 0; i < count; i++)
            {
                var price = GetRandomNumber(100, 900);
                var items = GetRandomNumber(10, 80);
                var value = price * items;
                var margin = GetRandomNumber(3, 10);
                var profit = Math.Round((price * margin / 100) * items);
                var country = GetRandomItem(countries);
                sales.Add(new Sale {
                                BundlePrice = price,
                                ProductPrice = price,
                                Margin = margin,
                                OrderDate = GetRandomDate(new DateTime(2012, 0, 1), new DateTime()),
                                OrderItems = items,
                                OrderValue = value, //  Math.round(value / 1000) + "," + Math.round(value % 1000),
                                ProductID = 1001 + i,
                                ProductName = GetRandomItem(names),
                                Profit = profit,
                                Country = country,
                                CountryFlag = GetCountryFlag(country),
                                Status = GetRandomItem(status)
                            });
            }
            return sales;
        }

        public class House : Employee
        {
            public double Baths { get; set; }
            public double Built { get; set; }
            public string Property { get; set; }
            public double Rooms { get; set; }
            public DateTime SaleDate { get; set; }
            public string Agent { get; set; }
            public double Area { get; set; }
            public double Price { get; set; }

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
                var year = GetRandomNumber(1950, 2015);
                var age = 2020 - year;

                var gender = GetRandomGender();
                var firstName = GetRandomNameFirst(gender);
                var lastName = GetRandomNameLast();
                var initials = firstName.Substring(0, 1).ToLower();
                var email = initials  + firstName.ToLower() + "@" + GetRandomItem(emails);
                var street = GetRandomStreet();
                var country = GetRandomItem(countries);
                var city = GetRandomCity(country);

                houses.Add(new House
                {
                    Address = street,
                    Age = age,
                    Agent = firstName + " " + lastName,
                    Area = GetRandomNumber(50, 300),
                    Baths = GetRandomNumber(1, 3),
                    Built = year,
                    City = city,
                    Country = country,
                    CountryFlag = GetCountryFlag(country),
                    Email = email,
                    ID = Pad(i + 1, 5),
                    Phone = GetRandomPhone(),
                    Price = GetRandomNumber(210, 900) * 1000,
                    Property = GetRandomItem(property),
                    Rooms = GetRandomNumber(2, 5), 
                    SaleDate = GetRandomDate(new DateTime(2012, 0, 1), new DateTime()),
                    Street = street
                });
            }
            return houses;
        }
    }
}

