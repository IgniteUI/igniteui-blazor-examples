using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using Infragistics.Documents.Excel;

namespace Infragistics.Samples
{
    public class SalesEmployee
    {
        public double ID { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public List<Order> Order { get; set; }
    }

    public class Expense
    {
        public int Year { get; set; }
        public double ComputerExpense { get; set; }
        public double ResearchExpense { get; set; }
        public double TravelExpense { get; set; }
        public double SalaryExpense { get; set; }
        public double SoftwareExpense { get; set; }
    }

    public class Income
    {
        public int Year { get; set; }
        public double PhoneIncome { get; set; }
        public double ComputerIncome { get; set; }
        public double SoftwareIncome { get; set; }
        public double ServiceIncome { get; set; }
        public double RoyaltyIncome { get; set; }
    }

    public class Order : SalesEmployee
    {
        public string CustomerName { get; set; }
        public string CustomerID { get; set; }
        public double Freight { get; set; }
        public string OrderDate { get; set; }
        public double OrderID { get; set; }
        public string RequiredDate { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public string ShipName { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipRegion { get; set; }
        public double ShipVia { get; set; }
        public string ShippedDate { get; set; }
        public double ShipperID { get; set; }
        public string ShipperName { get; set; }
        public double TotalItems { get; set; }
        public double TotalPrice { get; set; }
    }
}
