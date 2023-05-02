using System;
using System.Collections.Generic;
public class NwindDataItem
{
    public int ID { get; set; }
    public string ProductName { get; set; }
    public double SupplierID { get; set; }
    public string SupplierName { get; set; }
    public double CategoryID { get; set; }
    public string CategoryName { get; set; }
    public string QuantityPerUnit { get; set; }
    public double UnitPrice { get; set; }
    public double UnitsInStock { get; set; }
    public double UnitsOnOrder { get; set; }
    public double ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
    public string OrderDate { get; set; }
    public double Rating { get; set; }
}

