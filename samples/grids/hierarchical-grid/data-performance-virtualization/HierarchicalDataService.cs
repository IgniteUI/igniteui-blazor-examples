using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    /// <summary>
    /// Simulates lazy remote loading with a one-second delay and local data for
    /// Northwind-style customers, 20 orders per customer, and 8 details per order.
    /// </summary>
    public class HierarchicalDataService
    {
        private static readonly CustomerData[] Customers = CreateCustomers();

        private static readonly (int ProductId, decimal UnitPrice)[] Products =
        {
            (1, 18m), (2, 19m), (3, 10m), (4, 22m),
            (5, 21.35m), (6, 25m), (7, 30m), (8, 40m),
            (9, 97m), (10, 31m), (11, 21m), (12, 38m),
            (13, 6m), (14, 23.25m), (15, 15.5m), (16, 17.45m)
        };

        private static readonly OrderData[] Orders = Customers.SelectMany((customer, customerIndex) =>
            Enumerable.Range(1, 20).Select(index => new OrderData
            {
                OrderId = 10247 + customerIndex * 20 + index,
                CustomerId = customer.CustomerId,
                ShipAddress = customer.Address,
                OrderDate = new DateTime(2025, 1, 1).AddDays(customerIndex * 3 + index * 11 + index % 4)
            })).ToArray();

        private static readonly OrderDetailData[] Details = Orders.SelectMany(order =>
            Enumerable.Range(1, 8).Select(index => new OrderDetailData
            {
                OrderId = order.OrderId,
                ProductId = Products[(order.OrderId + index) % Products.Length].ProductId,
                Quantity = 5 * (1 + (order.OrderId + index * 3) % 12),
                UnitPrice = Products[(order.OrderId + index) % Products.Length].UnitPrice,
                Discount = (order.OrderId + index) % 5 == 0 ? 0.15m
                    : (order.OrderId + index) % 3 == 0 ? 0.05m : 0m
            })).ToArray();

        public async Task<object[]> GetDataAsync(string key, object parentId)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            return key switch
            {
                "Customers" => Customers,
                "Orders" => Orders.Where(order => order.CustomerId == Convert.ToString(parentId)).ToArray(),
                "Details" => Details.Where(detail => detail.OrderId == Convert.ToInt32(parentId)).ToArray(),
                _ => throw new ArgumentException($"Unknown data collection: {key}", nameof(key))
            };
        }

        private static CustomerData[] CreateCustomers()
        {
            return new[]
            {
                CreateCustomer("ALFKI", "Alfreds Futterkiste", "Maria Anders", "Sales Representative", "Obere Str. 57", "Berlin", "Germany", "030-0074321"),
                CreateCustomer("ANATR", "Ana Trujillo Emparedados y helados", "Ana Trujillo", "Owner", "Avda. de la Constitucion 2222", "Mexico D.F.", "Mexico", "(5) 555-4729"),
                CreateCustomer("ANTON", "Antonio Moreno Taqueria", "Antonio Moreno", "Owner", "Mataderos 2312", "Mexico D.F.", "Mexico", "(5) 555-3932"),
                CreateCustomer("AROUT", "Around the Horn", "Thomas Hardy", "Sales Representative", "120 Hanover Sq.", "London", "UK", "(171) 555-7788"),
                CreateCustomer("BERGS", "Berglunds snabbkop", "Christina Berglund", "Order Administrator", "Berguvsvagen 8", "Lulea", "Sweden", "0921-12 34 65"),
                CreateCustomer("BLAUS", "Blauer See Delikatessen", "Hanna Moos", "Sales Representative", "Forsterstr. 57", "Mannheim", "Germany", "0621-08460"),
                CreateCustomer("BLONP", "Blondesddsl pere et fils", "Frederique Citeaux", "Marketing Manager", "24, place Kleber", "Strasbourg", "France", "88.60.15.31"),
                CreateCustomer("BOLID", "Bolido Comidas preparadas", "Martin Sommer", "Owner", "C/ Araquil, 67", "Madrid", "Spain", "(91) 555 22 82"),
                CreateCustomer("BONAP", "Bon app'", "Laurence Lebihan", "Owner", "12, rue des Bouchers", "Marseille", "France", "91.24.45.40"),
                CreateCustomer("BOTTM", "Bottom-Dollar Markets", "Elizabeth Lincoln", "Accounting Manager", "23 Tsawassen Blvd.", "Tsawassen", "Canada", "(604) 555-4729"),
                CreateCustomer("BSBEV", "B's Beverages", "Victoria Ashworth", "Sales Representative", "Fauntleroy Circus", "London", "UK", "(171) 555-1212"),
                CreateCustomer("CACTU", "Cactus Comidas para llevar", "Patricio Simpson", "Sales Agent", "Cerrito 333", "Buenos Aires", "Argentina", "(1) 135-5555"),
                CreateCustomer("CENTC", "Centro comercial Moctezuma", "Francisco Chang", "Marketing Manager", "Sierras de Granada 9993", "Mexico D.F.", "Mexico", "(5) 555-3392"),
                CreateCustomer("CHOPS", "Chop-suey Chinese", "Yang Wang", "Owner", "Hauptstr. 29", "Bern", "Switzerland", "0452-076545"),
                CreateCustomer("COMMI", "Comercio Mineiro", "Pedro Afonso", "Sales Associate", "Av. dos Lusiadas, 23", "Sao Paulo", "Brazil", "(11) 555-7647"),
                CreateCustomer("CONSH", "Consolidated Holdings", "Elizabeth Brown", "Sales Representative", "Berkeley Gardens 12 Brewery", "London", "UK", "(171) 555-2282"),
                CreateCustomer("DRACD", "Drachenblut Delikatessen", "Sven Ottlieb", "Order Administrator", "Walserweg 21", "Aachen", "Germany", "0241-039123"),
                CreateCustomer("DUMON", "Du monde entier", "Janine Labrune", "Owner", "67, rue des Cinquante Otages", "Nantes", "France", "40.67.88.88"),
                CreateCustomer("EASTC", "Eastern Connection", "Ann Devon", "Sales Agent", "35 King George", "London", "UK", "(171) 555-0297"),
                CreateCustomer("ERNSH", "Ernst Handel", "Roland Mendel", "Sales Manager", "Kirchgasse 6", "Graz", "Austria", "7675-3425"),
                CreateCustomer("FAMIA", "Familia Arquibaldo", "Aria Cruz", "Marketing Assistant", "Rua Oros, 92", "Sao Paulo", "Brazil", "(11) 555-9857"),
                CreateCustomer("FISSA", "FISSA Fabrica Inter. Salchichas S.A.", "Diego Roel", "Accounting Manager", "C/ Moralzarzal, 86", "Madrid", "Spain", "(91) 555 94 44"),
                CreateCustomer("FOLIG", "Folies gourmandes", "Martine Rance", "Assistant Sales Agent", "184, chaussee de Tournai", "Lille", "France", "20.16.10.16"),
                CreateCustomer("FOLKO", "Folk och fa HB", "Maria Larsson", "Owner", "Akergatan 24", "Bracke", "Sweden", "0695-34 67 21"),
                CreateCustomer("FRANK", "Frankenversand", "Peter Franken", "Marketing Manager", "Berliner Platz 43", "Munchen", "Germany", "089-0877310"),
                CreateCustomer("FRANR", "France restauration", "Carine Schmitt", "Marketing Manager", "54, rue Royale", "Nantes", "France", "40.32.21.21"),
                CreateCustomer("FRANS", "Franchi S.p.A.", "Paolo Accorti", "Sales Representative", "Via Monte Bianco 34", "Torino", "Italy", "011-4988260")
            };
        }

        private static CustomerData CreateCustomer(string customerId, string companyName,
            string contactName, string contactTitle, string street, string city, string country, string phone)
        {
            return new CustomerData
            {
                CustomerId = customerId,
                CompanyName = companyName,
                ContactName = contactName,
                ContactTitle = contactTitle,
                Address = new CustomerAddress
                {
                    Street = street,
                    City = city,
                    Country = country,
                    Phone = phone
                }
            };
        }
        public class CustomerData
        {
            public string CustomerId { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public CustomerAddress Address { get; set; }
        }

        public class CustomerAddress
        {
            public string Country { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public string Phone { get; set; }
        }

        public class OrderData
        {
            public int OrderId { get; set; }
            public string CustomerId { get; set; }
            public CustomerAddress ShipAddress { get; set; }
            public DateTime OrderDate { get; set; }
        }

        public class OrderDetailData
        {
            public int OrderId { get; set; }
            public int ProductId { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal Discount { get; set; }
        }
    }
}
