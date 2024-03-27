using System;
using System.Collections.Generic;
public class EmployeesNestedDataItem
{
    public double ID { get; set; }
    public double Age { get; set; }
    public double Salary { get; set; }
    public double Productivity { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string HireDate { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public List<EmployeesNestedDataItem_EmployeesItem> Employees { get; set; }
}
public class EmployeesNestedDataItem_EmployeesItem
{
    public double Age { get; set; }
    public double Salary { get; set; }
    public double Productivity { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string HireDate { get; set; }
    public double ID { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
}

public class EmployeesNestedData
    : List<EmployeesNestedDataItem>
{
    public EmployeesNestedData()
    {
        this.Add(new EmployeesNestedDataItem()
        {
            ID = 1,
            Age = 55,
            Salary = 80000,
            Productivity = 90,
            City = @"Berlin",
            Country = @"Germany",
            Phone = @"609-202-505",
            HireDate = @"2008, 3, 20",
            Name = @"John Winchester",
            Title = @"Development Manager",
            Employees = new List<EmployeesNestedDataItem_EmployeesItem>()
            {
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 43,
                    Salary = 70000,
                    Productivity = 80,
                    City = @"Hamburg",
                    Country = @"Germany",
                    Phone = @"609-444-555",
                    HireDate = @"2011, 6, 3",
                    ID = 3,
                    Name = @"Michael Burke",
                    Title = @"Senior Software Developer"
                },
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 29,
                    Salary = 60000,
                    Productivity = 80,
                    City = @"Munich",
                    Country = @"Germany",
                    Phone = @"609-333-444",
                    HireDate = @"2009, 6, 19",
                    ID = 2,
                    Name = @"Thomas Anderson",
                    Title = @"Senior Software Developer"
                },
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 31,
                    Salary = 90000,
                    Productivity = 80,
                    City = @"Warasw",
                    Country = @"Poland",
                    Phone = @"609-222-205",
                    HireDate = @"2014, 8, 18",
                    ID = 11,
                    Name = @"Monica Reyes",
                    Title = @"Software Development Team Lead"
                },
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 35,
                    Salary = 70000,
                    Productivity = 70,
                    City = @"Koln",
                    Country = @"Germany",
                    Phone = @"609-502-525",
                    HireDate = @"2015, 9, 17",
                    ID = 6,
                    Name = @"Roland Mendel",
                    Title = @"Senior Software Developer"
                }}

        });
        this.Add(new EmployeesNestedDataItem()
        {
            ID = 4,
            Age = 42,
            Salary = 90000,
            Productivity = 80,
            City = @"Kielce",
            Country = @"Poland",
            Phone = @"609-202-505",
            HireDate = @"2014, 1, 22",
            Name = @"Ana Sanders",
            Title = @"CEO",
            Employees = new List<EmployeesNestedDataItem_EmployeesItem>()
            {
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 44,
                    Salary = 80000,
                    Productivity = 80,
                    City = @"Warasw",
                    Country = @"Poland",
                    Phone = @"609-202-505",
                    HireDate = @"2014, 4, 4",
                    ID = 14,
                    Name = @"Laurence Johnson",
                    Title = @"Director"
                },
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 25,
                    Salary = 85000,
                    Productivity = 55,
                    City = @"Paris",
                    Country = @"France",
                    Phone = @"609-202-505",
                    HireDate = @"2017, 11, 9",
                    ID = 5,
                    Name = @"Elizabeth Richards",
                    Title = @"Vice President"
                },
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 39,
                    Salary = 88000,
                    Productivity = 88,
                    City = @"London",
                    Country = @"UK",
                    Phone = @"609-202-505",
                    HireDate = @"2010, 3, 22",
                    ID = 13,
                    Name = @"Trevor Ashworth",
                    Title = @"Director"
                }}

        });
        this.Add(new EmployeesNestedDataItem()
        {
            ID = 18,
            Age = 49,
            Salary = 77000,
            Productivity = 70,
            City = @"Manchester",
            Country = @"UK",
            Phone = @"222-555-577",
            HireDate = @"2014, 1, 22",
            Name = @"Victoria Lincoln",
            Title = @"Senior Accountant",
            Employees = new List<EmployeesNestedDataItem_EmployeesItem>()
            {
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 43,
                    Salary = 70000,
                    Productivity = 80,
                    City = @"Hamburg",
                    Country = @"Germany",
                    Phone = @"609-444-555",
                    HireDate = @"2011, 6, 3",
                    ID = 23,
                    Name = @"Thomas Burke",
                    Title = @"Senior Accountant"
                },
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 29,
                    Salary = 60000,
                    Productivity = 80,
                    City = @"Munich",
                    Country = @"Germany",
                    Phone = @"609-333-444",
                    HireDate = @"2009, 6, 19",
                    ID = 22,
                    Name = @"Michael Anderson",
                    Title = @"Junior Accountant"
                },
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 31,
                    Salary = 90000,
                    Productivity = 80,
                    City = @"Warasw",
                    Country = @"Poland",
                    Phone = @"609-222-205",
                    HireDate = @"2014, 8, 18",
                    ID = 21,
                    Name = @"Roland Reyes",
                    Title = @"Accountant Team Lead"
                },
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 35,
                    Salary = 70000,
                    Productivity = 70,
                    City = @"Koln",
                    Country = @"Germany",
                    Phone = @"609-502-525",
                    HireDate = @"2015, 9, 17",
                    ID = 24,
                    Name = @"Monica Mendel",
                    Title = @"Senior Software Developer"
                }}

        });
        this.Add(new EmployeesNestedDataItem()
        {
            ID = 10,
            Age = 61,
            Salary = 85000,
            Productivity = 890,
            City = @"Lyon",
            Country = @"France",
            Phone = @"259-266-887",
            HireDate = @"2010, 1, 1",
            Name = @"Yang Wang",
            Title = @"Localization Developer",
            Employees = new List<EmployeesNestedDataItem_EmployeesItem>()
            {
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 31,
                    Salary = 90000,
                    Productivity = 80,
                    City = @"Warasw",
                    Country = @"Poland",
                    Phone = @"609-222-205",
                    HireDate = @"2014, 8, 18",
                    ID = 11,
                    Name = @"Monica Reyes",
                    Title = @"Software Development Team Lead"
                },
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 35,
                    Salary = 70000,
                    Productivity = 70,
                    City = @"Koln",
                    Country = @"Germany",
                    Phone = @"609-502-525",
                    HireDate = @"2015, 9, 17",
                    ID = 6,
                    Name = @"Roland Mendel",
                    Title = @"Senior Software Developer"
                }}

        });
        this.Add(new EmployeesNestedDataItem()
        {
            ID = 35,
            Age = 35,
            Salary = 75000,
            Productivity = 75,
            City = @"Warasw",
            Country = @"Poland",
            Phone = @"688-244-844",
            HireDate = @"2014, 1, 22",
            Name = @"Janine Munoz",
            Title = @"HR",
            Employees = new List<EmployeesNestedDataItem_EmployeesItem>()
            {
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 43,
                    Salary = 70000,
                    Productivity = 80,
                    City = @"Hamburg",
                    Country = @"Germany",
                    Phone = @"609-444-555",
                    HireDate = @"2011, 6, 3",
                    ID = 3,
                    Name = @"Michael Burke",
                    Title = @"Senior Software Developer"
                },
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 31,
                    Salary = 90000,
                    Productivity = 80,
                    City = @"Warasw",
                    Country = @"Poland",
                    Phone = @"609-222-205",
                    HireDate = @"2014, 8, 18",
                    ID = 11,
                    Name = @"Monica Reyes",
                    Title = @"Software Development Team Lead"
                }}

        });
        this.Add(new EmployeesNestedDataItem()
        {
            ID = 10,
            Age = 49,
            Salary = 95000,
            Productivity = 80,
            City = @"Krakow",
            Country = @"Poland",
            Phone = @"677-266-555",
            HireDate = @"2010, 1, 1",
            Name = @"Yang Wang",
            Title = @"Sales Manager",
            Employees = new List<EmployeesNestedDataItem_EmployeesItem>()
            {
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 29,
                    Salary = 60000,
                    Productivity = 80,
                    City = @"Munich",
                    Country = @"Germany",
                    Phone = @"609-333-444",
                    HireDate = @"2009, 6, 19",
                    ID = 2,
                    Name = @"Thomas Anderson",
                    Title = @"Senior Software Developer"
                },
                new EmployeesNestedDataItem_EmployeesItem()
                {
                    Age = 35,
                    Salary = 70000,
                    Productivity = 70,
                    City = @"Koln",
                    Country = @"Germany",
                    Phone = @"609-502-525",
                    HireDate = @"2015, 9, 17",
                    ID = 6,
                    Name = @"Roland Mendel",
                    Title = @"Senior Software Developer"
                }}

        });
    }
}
