using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class Product
    {
        public string CountryFlag { get; set; }
        public string CountryName { get; set; }
        public double Margin { get; set; }
        public int OrderCount { get; set; }
        public List<OrderHistoryItem> OrderHistory { get; set; }
        public int OrderShipped { get; set; }
        public double OrderValue { get; set; }
        public DateTime OrderDate { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public double Profit { get; set; }
        //public List<ReturnRateItem> ReturnRate { get; set; }
        public string Status { get; set; }
    }

    public class ReturnRateItem
    {
        public double Balance { get; set; }
        public int Week { get; set; }
    }

    public class OrderHistoryItem
    {
        public double Sold { get; set; }
        public int Week { get; set; }
    }

    public class Products
    {
        public static List<Product> GetData(int? count)
        {
            if (count == null)
            {
                count = 20;
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

            var products = new List<Product>();
            for (int i = 0; i < count; i++)
            {
                var id = DataGenerator.Pad((int)count - i, count.ToString().Length);
                var price = Math.Round((DataGenerator.GetNumber(10000, 90000) / 100), 2);
                var orderCount = (int)DataGenerator.GetNumber(4, 30);
                var orderValue = Math.Round((price * orderCount), 2);
                var orderShipped = (int)DataGenerator.GetNumber(30, 100);
                var margin = DataGenerator.GetNumber(5, 10);
                var profit = Math.Round(orderValue * (margin / 100));
                var country = DataGenerator.GetItem(countries);

                products.Add(new Product()
                {
                    CountryFlag = DataGenerator.GetCountryFlag(country),
                    CountryName = country,
                    Margin = margin,
                    OrderCount = orderCount,
                    OrderHistory = GetOrderHistory(26),
                    OrderShipped = orderShipped,
                    OrderValue = orderValue,
                    OrderDate = DataGenerator.GetDate(),
                    ProductID = id,
                    ProductName = DataGenerator.GetItem(names),
                    ProductPrice = price,
                    Profit = profit, 
                    //ReturnRate = GetReturnRates(26),
                    Status = DataGenerator.GetItem(status)
                });
            }

            return products;
        }


        public static List<OrderHistoryItem> GetOrderHistory(int weekCount)
        {
            var items = new List<OrderHistoryItem>();
            for(int i=0; i<weekCount; i++)
            {
                double value = DataGenerator.GetNumber(0, 100);
                items.Add(new OrderHistoryItem() { Sold = value, Week = i });
            }

            return items;
        }

        public static List<ReturnRateItem> GetReturnRates(int weekCount)
        {
            var items = new List<ReturnRateItem>();
            for (int i = 0; i < weekCount; i++)
            {
                double value = DataGenerator.GetNumber(-100, 100);
                items.Add(new ReturnRateItem() { Balance = value, Week = i });
            }

            return items;
        }
    }
}
