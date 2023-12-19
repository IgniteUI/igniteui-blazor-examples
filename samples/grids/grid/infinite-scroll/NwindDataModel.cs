using Newtonsoft.Json;
using System;
using System.Collections.Generic;
public class NwinCustomdDataItem
{
    public double ProductID { get; set; }
    public string ProductName { get; set; }
    public double SupplierID { get; set; }
    public double CategoryID { get; set; }
    public string QuantityPerUnit { get; set; }
    public double UnitPrice { get; set; }
    public double UnitsInStock { get; set; }
    public double UnitsOnOrder { get; set; }
    public double ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
    public string OrderDate { get; set; }
    public double Rating { get; set; }
    public List<NwinCustomdDataItem_LocationsItem> Locations { get; set; }
}
public class NwinCustomdDataItem_LocationsItem
{
    public string Shop { get; set; }
    public string LastInventory { get; set; }
}

public class NwindModel
{
    [JsonProperty("@odata.count")]
    public int Count { get; set; } = 77;

    [JsonProperty("value")]
    public List<NwinCustomdDataItem> Value { get; set; }
}