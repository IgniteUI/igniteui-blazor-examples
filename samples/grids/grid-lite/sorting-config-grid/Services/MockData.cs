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
        private static readonly string[] _firstNames = { "Alice", "Bob", "Charlie", "Diana", "Edward", "Fiona", "George", "Hannah", "Ian", "Julia" };
        private static readonly string[] _lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez" };
        private static readonly string[] _priorities = { "Low", "Standard", "High" };
        private static readonly string[] _productNames = { "Laptop", "Mouse", "Keyboard", "Monitor", "Headphones", "Webcam", "Microphone", "Speaker", "Tablet", "Phone" };

        public static List<User> CreateUsers(int count)
        {
            var users = new List<User>();
            for (int i = 0; i < count; i++)
            {
                var firstName = _firstNames[_random.Next(_firstNames.Length)];
                var lastName = _lastNames[_random.Next(_lastNames.Length)];
                
                users.Add(new User
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = firstName,
                    LastName = lastName,
                    Age = _random.Next(18, 90),
                    Email = $"{firstName.ToLower()}.{lastName.ToLower()}@example.com",
                    Avatar = $"https://i.pravatar.cc/150?img={_random.Next(1, 70)}",
                    Active = _random.Next(2) == 1,
                    Priority = _priorities[_random.Next(_priorities.Length)],
                    Satisfaction = _random.Next(0, 6),
                    RegisteredAt = DateTime.Now.AddDays(-_random.Next(1, 1000))
                });
            }
            return users;
        }

        public static List<ProductInfo> CreateProducts(int count)
        {
            var products = new List<ProductInfo>();
            for (int i = 0; i < count; i++)
            {
                var price = Math.Round(50 + _random.NextDouble() * 450, 2);
                var sold = _random.Next(10, 100);
                var total = Math.Round(price * sold, 2);

                products.Add(new ProductInfo
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = $"{_productNames[_random.Next(_productNames.Length)]} {_random.Next(1, 100)}",
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
