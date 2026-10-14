using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public class RemotePagingService
    {
        private static readonly CustomerData[] Customers = CreateCustomers();

        public async Task<CustomersWithPageResponse> GetDataWithPagingAsync(int pageIndex, int pageSize)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));

            var validPageSize = Math.Max(1, pageSize);
            var validPageIndex = Math.Max(0, pageIndex);

            return new CustomersWithPageResponse
            {
                Items = Customers.Skip(validPageIndex * validPageSize).Take(validPageSize).ToArray(),
                TotalRecordsCount = Customers.Length,
                PageSize = validPageSize,
                PageNumber = validPageIndex,
                TotalPages = (int)Math.Ceiling((double)Customers.Length / validPageSize)
            };
        }

        private static CustomerData[] CreateCustomers()
        {
            return new[]
            {
                CreateCustomer("ALFKI", "Alfreds Futterkiste", "Maria Anders", "Sales Representative", "Obere Str. 57", "Berlin", "East", "12209", "Germany", "030-0074321"),
                CreateCustomer("ANATR", "Ana Trujillo Emparedados y helados", "Ana Trujillo", "Owner", "Avda. de la Constitución 2222", "México D.F.", "South", "05021", "Mexico", "(5) 555-4729"),
                CreateCustomer("ANTON", "Antonio Moreno Taquería", "Antonio Moreno", "Owner", "Mataderos 2312", "México D.F.", "South", "05023", "Mexico", "(5) 555-3932"),
                CreateCustomer("AROUT", "Around the Horn", "Thomas Hardy", "Sales Representative", "120 Hanover Sq.", "London", "East", "WA1 1DP", "UK", "(171) 555-7788"),
                CreateCustomer("BERGS", "Berglunds snabbköp", "Christina Berglund", "Order Administrator", "Berguvsvägen 8", "Luleå", "South", "S-958 22", "Sweden", "0921-12 34 65"),
                CreateCustomer("BLAUS", "Blauer See Delikatessen", "Hanna Moos", "Sales Representative", "Forsterstr. 57", "Mannheim", "East", "68306", "Germany", "0621-08460"),
                CreateCustomer("BLONP", "Blondesddsl père et fils", "Frédérique Citeaux", "Marketing Manager", "24, place Kléber", "Strasbourg", "East", "67000", "France", "88.60.15.31"),
                CreateCustomer("BOLID", "Bólido Comidas preparadas", "Martín Sommer", "Owner", "C/ Araquil, 67", "Madrid", "East", "28023", "Spain", "(91) 555 22 82"),
                CreateCustomer("BONAP", "Bon app'", "Laurence Lebihan", "Owner", "12, rue des Bouchers", "Marseille", "West", "13008", "France", "91.24.45.40"),
                CreateCustomer("BOTTM", "Bottom-Dollar Markets", "Elizabeth Lincoln", "Accounting Manager", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada", "(604) 555-4729"),
                CreateCustomer("BSBEV", "B's Beverages", "Victoria Ashworth", "Sales Representative", "Fauntleroy Circus", "London", "South", "EC2 5NT", "UK", "(171) 555-1212"),
                CreateCustomer("CACTU", "Cactus Comidas para llevar", "Patricio Simpson", "Sales Agent", "Cerrito 333", "Buenos Aires", "East", "1010", "Argentina", "(1) 135-5555"),
                CreateCustomer("CENTC", "Centro comercial Moctezuma", "Francisco Chang", "Marketing Manager", "Sierras de Granada 9993", "México D.F.", "South", "05022", "Mexico", "(5) 555-3392"),
                CreateCustomer("CHOPS", "Chop-suey Chinese", "Yang Wang", "Owner", "Hauptstr. 29", "Bern", "East", "3012", "Switzerland", "0452-076545"),
                CreateCustomer("COMMI", "Comércio Mineiro", "Pedro Afonso", "Sales Associate", "Av. dos Lusíadas, 23", "Sao Paulo", "SP", "05432-043", "Brazil", "(11) 555-7647"),
                CreateCustomer("CONSH", "Consolidated Holdings", "Elizabeth Brown", "Sales Representative", "Berkeley Gardens 12 Brewery", "London", "South", "WX1 6LT", "UK", "(171) 555-2282"),
                CreateCustomer("DRACD", "Drachenblut Delikatessen", "Sven Ottlieb", "Order Administrator", "Walserweg 21", "Aachen", "South", "52066", "Germany", "0241-039123"),
                CreateCustomer("DUMON", "Du monde entier", "Janine Labrune", "Owner", "67, rue des Cinquante Otages", "Nantes", "East", "44000", "France", "40.67.88.88"),
                CreateCustomer("EASTC", "Eastern Connection", "Ann Devon", "Sales Agent", "35 King George", "London", "East", "WX3 6FW", "UK", "(171) 555-0297"),
                CreateCustomer("ERNSH", "Ernst Handel", "Roland Mendel", "Sales Manager", "Kirchgasse 6", "Graz", "South", "8010", "Austria", "7675-3425"),
                CreateCustomer("FAMIA", "Familia Arquibaldo", "Aria Cruz", "Marketing Assistant", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil", "(11) 555-9857"),
                CreateCustomer("FISSA", "FISSA Fabrica Inter. Salchichas S.A.", "Diego Roel", "Accounting Manager", "C/ Moralzarzal, 86", "Madrid", "East", "28034", "Spain", "(91) 555 94 44"),
                CreateCustomer("FOLIG", "Folies gourmandes", "Martine Rancé", "Assistant Sales Agent", "184, chaussée de Tournai", "Lille", "South", "59000", "France", "20.16.10.16"),
                CreateCustomer("FOLKO", "Folk och fä HB", "Maria Larsson", "Owner", "Åkergatan 24", "Bräcke", "East", "S-844 67", "Sweden", "0695-34 67 21"),
                CreateCustomer("FRANK", "Frankenversand", "Peter Franken", "Marketing Manager", "Berliner Platz 43", "München", "East", "80805", "Germany", "089-0877310"),
                CreateCustomer("FRANR", "France restauration", "Carine Schmitt", "Marketing Manager", "54, rue Royale", "Nantes", "South", "44000", "France", "40.32.21.21"),
                CreateCustomer("FRANS", "Franchi S.p.A.", "Paolo Accorti", "Sales Representative", "Via Monte Bianco 34", "Torino", "East", "10100", "Italy", "011-4988260")
            };
        }

        private static CustomerData CreateCustomer(string customerId, string companyName, string contactName, string contactTitle, string street, string city, string region, string postalCode, string country, string phone)
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
                    Region = region,
                    PostalCode = postalCode,
                    Country = country,
                    Phone = phone
                }
            };
        }
    }

    public class CustomersWithPageResponse
    {
        public CustomerData[] Items { get; set; }
        public int TotalRecordsCount { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }
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
        public string Street { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
    }
}
