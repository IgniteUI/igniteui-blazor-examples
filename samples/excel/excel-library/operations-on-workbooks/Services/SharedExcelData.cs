using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Components.Web;

using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using Infragistics.Documents.Excel;

namespace Infragistics.Samples
{
    public class Employee
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public double Salary { get; set; }
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
}
