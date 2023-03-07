using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class SaleInfo
    {
        public DateTime OrderDate { get; set; }
        public string ID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public double BundlePrice { get; set; }
        public double Margin { get; set; }
        public double OrderItems { get; set; }
        public double OrderValue { get; set; }
        public double Profit { get; set; }
        public string Country { get; set; }
        public string CountryFlag { get; set; }
        public string City { get; set; }
        public string Status { get; set; }
    }

    public class SalesDataService
    {
        public static List<SaleInfo> Create(int? count)
        {
            if (count == null) count = 100;

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

            var sales = new List<SaleInfo>();
            for (var i = 0; i < count; i++)
            {
                var price = DataGenerator.GetNumber(100, 900);
                var items = DataGenerator.GetNumber(10, 80);
                var value = price * items;
                var margin = DataGenerator.GetNumber(3, 10);
                var profit = Math.Round((price * margin / 100) * items);
                var country = DataGenerator.GetItem(countries);
                var city = DataGenerator.GetCity(country);

                sales.Add(new SaleInfo
                {
                    ID = DataGenerator.Pad(1001 + i, 4),
                    BundlePrice = price,
                    ProductPrice = price,
                    Margin = margin,
                    OrderDate = DataGenerator.GetDate(),
                    OrderItems = items,
                    OrderValue = value,
                    ProductName = DataGenerator.GetItem(names),
                    Profit = profit,
                    City = city,
                    Country = country,
                    CountryFlag = DataGenerator.GetCountryFlag(country),
                    Status = DataGenerator.GetItem(status)
                });
            }
            return sales;
        }
    }
}