//begin data
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Collections.ObjectModel;
    using IgniteUI.Blazor.Controls;

    public class InvoicesDataExtendedDates : List<Invoice>
    {

        public InvoicesDataExtendedDates()
        {

            List<Invoice> data = new List<Invoice>()
            {
                new Invoice()
                {
                    ProductID = 1,
                    ProductName = "Chai",
                    SupplierID = 1,
                    CategoryID = 1,
                    QuantityPerUnit = "10 boxes x 20 bags",
                    UnitPrice= 18.0000,
                    UnitsInStock= 39,
                    UnitsOnOrder= 0.030,
                    ReorderLevel= 10,
                    Discontinued= false,
                    OrderDate= DateTime.Parse("2012-02-12"),
                    OrderDateDelay= DateTime.Parse("2012-02-12") + new TimeSpan(3,20,0),
                    OrderFullDate= DateTime.Parse("2012-02-12") + new TimeSpan(3,20,0)
                },
                new Invoice()
                {
                    ProductID= 2,
                    ProductName= "Chang",
                    SupplierID= 1,
                    CategoryID= 1,
                    QuantityPerUnit= "24 - 12 oz bottles",
                    UnitPrice= 19.0000,
                    UnitsInStock= 17,
                    UnitsOnOrder= 0.040,
                    ReorderLevel= 25,
                    Discontinued= true,
                    OrderDate= DateTime.Parse("2003-03-17"),
                    OrderDateDelay= DateTime.Parse("2003-03-17") + new TimeSpan(5,40,0),
                    OrderFullDate=  DateTime.Parse("2003-03-17") + new TimeSpan(5,40,0)
                },
                new Invoice()
                {
                    ProductID= 3,
                    ProductName= "Aniseed Syrup",
                    SupplierID= 1,
                    CategoryID= 2,
                    QuantityPerUnit= "12 - 550 ml bottles",
                    UnitPrice= 10.0000,
                    UnitsInStock= 13,
                    UnitsOnOrder= 0.070,
                    ReorderLevel= 25,
                    Discontinued= false,
                    OrderDate= DateTime.Parse("2006-03-17"),
                    OrderDateDelay= DateTime.Parse("2006-03-17") + new TimeSpan(1,55,0),
                    OrderFullDate= DateTime.Parse("2006-03-17") + new TimeSpan(1,55,0)
                },
                new Invoice()
                {
                    ProductID= 4,
                    ProductName= "Chef Antons Cajun Seasoning",
                    SupplierID= 2,
                    CategoryID= 2,
                    QuantityPerUnit= "48 - 6 oz jars",
                    UnitPrice= 22.0000,
                    UnitsInStock= 53,
                    UnitsOnOrder= 0.030,
                    ReorderLevel= 0,
                    Discontinued= false,
                    OrderDate= DateTime.Parse("2016-03-17"),
                    OrderDateDelay= DateTime.Parse("2016-03-17") + new TimeSpan(11,11,0),
                    OrderFullDate= DateTime.Parse("2016-03-17") + new TimeSpan(11,11,0)
                },
                new Invoice()
                {
                    ProductID= 5,
                    ProductName= "Chef Antons Gumbo Mix",
                    SupplierID= 2,
                    CategoryID= 2,
                    QuantityPerUnit= "36 boxes",
                    UnitPrice= 21.3500,
                    UnitsInStock= 0,
                    UnitsOnOrder= 0.030,
                    ReorderLevel= 0,
                    Discontinued= true,
                    OrderDate= DateTime.Parse("2011-11-11"),
                    OrderDateDelay= DateTime.Parse("2011-11-11") + new TimeSpan(11,11,0),
                    OrderFullDate= DateTime.Parse("2011-11-11") + new TimeSpan(11,11,0)
                },
                new Invoice()
                {
                    ProductID= 6,
                    ProductName= "Grandmas Boysenberry Spread",
                    SupplierID= 3,
                    CategoryID= 2,
                    QuantityPerUnit= "12 - 8 oz jars",
                    UnitPrice= 25.0000,
                    UnitsInStock= 0,
                    UnitsOnOrder= 0.030,
                    ReorderLevel= 25,
                    Discontinued= false,
                    OrderDate= DateTime.Parse("2017-12-17"),
                    OrderDateDelay= DateTime.Parse("2017-12-17") + new TimeSpan(2,15,0),
                    OrderFullDate= DateTime.Parse("2017-12-17") + new TimeSpan(2,15,0)
                },
                new Invoice()
                {
                    ProductID= 7,
                    ProductName= "Uncle Bobs Organic Dried Pears",
                    SupplierID= 3,
                    CategoryID= 7,
                    QuantityPerUnit= "12 - 1 lb pkgs.",
                    UnitPrice= 30.0000,
                    UnitsInStock= 150,
                    UnitsOnOrder= 0.030,
                    ReorderLevel= 10,
                    Discontinued= false,
                    OrderDate= DateTime.Parse("2016-07-17"),
                    OrderDateDelay= DateTime.Parse("2016-07-17") + new TimeSpan(2,15,0),
                    OrderFullDate= DateTime.Parse("2016-07-17") + new TimeSpan(2,15,0)
                },
                new Invoice()
                {
                    ProductID= 8,
                    ProductName= "Northwoods Cranberry Sauce",
                    SupplierID= 3,
                    CategoryID= 2,
                    QuantityPerUnit= "12 - 12 oz jars",
                    UnitPrice= 40.0000,
                    UnitsInStock= 6,
                    UnitsOnOrder= 0.030,
                    ReorderLevel= 0,
                    Discontinued= false,
                    OrderDate= DateTime.Parse("2018-01-17"),
                    OrderDateDelay= DateTime.Parse("2018-01-17") + new TimeSpan(2,15,0),
                    OrderFullDate= DateTime.Parse("2018-01-17") + new TimeSpan(2,15,0)
                },
                new Invoice()
                {
                    ProductID= 9,
                    ProductName= "Mishi Kobe Niku",
                    SupplierID= 4,
                    CategoryID= 6,
                    QuantityPerUnit= "18 - 500 g pkgs.",
                    UnitPrice= 97.0000,
                    UnitsInStock= 29,
                    UnitsOnOrder= 0.030,
                    ReorderLevel= 0,
                    Discontinued= true,
                    OrderDate= DateTime.Parse("2010-02-17"),
                    OrderDateDelay= DateTime.Parse("2010-02-17") + new TimeSpan(8,10,0),
                    OrderFullDate= DateTime.Parse("2010-02-17") + new TimeSpan(8,10,0)
                }
            };

            this.AddRange(data);
        }

    }

    public class Invoice
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public double UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? OrderDateDelay { get; set; }
        public DateTime? OrderFullDate { get; set; }
    }

    //end data