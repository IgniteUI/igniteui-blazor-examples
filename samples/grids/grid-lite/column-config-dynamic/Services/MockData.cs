using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public bool Active { get; set; }
        public string Priority { get; set; }
        public int Satisfaction { get; set; }
        public DateTime RegisteredAt { get; set; }
    }

    public class ProductInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Sold { get; set; }
        public double Rating { get; set; }
        public double Total { get; set; }
    }

    public class MockDataGenerator
    {
        private static readonly Random _random = new Random();
        private static readonly string[] namesMen = ["John", "Bob", "Mark", "Charlie", "Martin", "Bill", "Frank", "Larry", "Henry", "Steve", "Mike", "Andrew"];
        private static readonly string[] namesWomen = ["Jane", "Alice", "Diana", "Eve", "Grace", "Katie", "Irene", "Liz", "Fiona", "Pam", "Val", "Mindy"];
        private static readonly string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez" };
        private static readonly string[] priorities = { "Low", "Standard", "High" };
        private static readonly string[] productNames = { "Laptop", "Mouse", "Keyboard", "Monitor", "Headphones", "Webcam", "Microphone", "Speaker", "Tablet", "Phone" };
        private static readonly string[] productModels = ["Pro", "Plus", "Max", "Ultra", "Mini", "Lite"];

        public static string getRandomItem(string[] array)
        {
            return array[_random.Next(array.Length)];
        }

        public static List<User> CreateUsers(int count)
        {
            var counter = 1;
            var users = new List<User>();
            for (int i = 0; i < count; i++)
            {
                var imagePath = "";
                var firstName = "";
                var gender = _random.Next(0, 1);
                if (gender == 0)
                {
                    imagePath = "https://dl.infragistics.com/x/img/people/men/" + _random.Next(10, 40) + ".png";
                    firstName = getRandomItem(namesMen);
                }
                else
                {
                    imagePath = "https://dl.infragistics.com/x/img/people/women/" + _random.Next(10, 40) + ".png";
                    firstName = getRandomItem(namesWomen);
                }
                var lastName = getRandomItem(lastNames);
                
                users.Add(new User
                {
                    Id = "1000-" + (counter++) + "-" + _random.Next(1000, 9999),
                    FirstName = firstName,
                    LastName = lastName,
                    Age = _random.Next(18, 90),
                    Email = $"{firstName.ToLower()}.{lastName.ToLower()}@example.com",
                    Avatar = imagePath,
                    Active = _random.Next(2) == 1,
                    Priority = getRandomItem(priorities),
                    Satisfaction = _random.Next(0, 6),
                    RegisteredAt = DateTime.Now.AddDays(-_random.Next(1, 1000))
                });
            }
            return users;
        }

        public static List<ProductInfo> CreateProducts(int count)
        {
            var counter = 1;
            var products = new List<ProductInfo>();
            for (int i = 0; i < count; i++)
            {
                var price = Math.Round(50 + _random.NextDouble() * 450, 2);
                var sold = _random.Next(10, 100);
                var total = Math.Round(price * sold, 2);

                products.Add(new ProductInfo
                {
                    Id = "1000-" + (counter++) + "-" + _random.Next(1000, 9999),
                    Name = getRandomItem(productNames) + " " + getRandomItem(productModels),
                    Price = price,
                    Sold = sold,
                    Rating = Math.Round(_random.NextDouble() * 5, 1),
                    Total = total
                });
            }
            return products;
        }
    }
}
