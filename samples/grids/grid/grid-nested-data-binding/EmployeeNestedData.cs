using System;
using System.Collections.Generic;
public class EmployeeNestedDataItem
{
    public double Age { get; set; }
    public List<EmployeeNestedDataItem_EmployeesItem> Employees { get; set; }
    public string HireDate { get; set; }
    public double ID { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
}
public class EmployeeNestedDataItem_EmployeesItem
{
    public double Age { get; set; }
    public string HireDate { get; set; }
    public double ID { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
}

public class EmployeeNestedData
    : List<EmployeeNestedDataItem>
{
    public EmployeeNestedData()
    {
        this.Add(new EmployeeNestedDataItem()
        {
            Age = 55,
            Employees = new List<EmployeeNestedDataItem_EmployeesItem>()
            {
                new EmployeeNestedDataItem_EmployeesItem()
                {
                    Age = 43,
                    HireDate = @"2011, 6, 3",
                    ID = 3,
                    Name = @"Michael Burke",
                    Title = @"Senior Software Developer"
                },
                new EmployeeNestedDataItem_EmployeesItem()
                {
                    Age = 29,
                    HireDate = @"2009, 6, 19",
                    ID = 2,
                    Name = @"Thomas Anderson",
                    Title = @"Senior Software Developer"
                },
                new EmployeeNestedDataItem_EmployeesItem()
                {
                    Age = 31,
                    HireDate = @"2014, 8, 18",
                    ID = 11,
                    Name = @"Monica Reyes",
                    Title = @"Software Development Team Lead"
                },
                new EmployeeNestedDataItem_EmployeesItem()
                {
                    Age = 35,
                    HireDate = @"2015, 9, 17",
                    ID = 6,
                    Name = @"Roland Mendel",
                    Title = @"Senior Software Developer"
                }}
            ,
            HireDate = @"2008, 3, 20",
            ID = 1,
            Name = @"John Winchester",
            Title = @"Development Manager"
        });
        this.Add(new EmployeeNestedDataItem()
        {
            Age = 42,
            Employees = new List<EmployeeNestedDataItem_EmployeesItem>()
            {
                new EmployeeNestedDataItem_EmployeesItem()
                {
                    Age = 44,
                    HireDate = @"2014, 4, 4",
                    ID = 14,
                    Name = @"Laurence Johnson",
                    Title = @"Director"
                },
                new EmployeeNestedDataItem_EmployeesItem()
                {
                    Age = 25,
                    HireDate = @"2017, 11, 9",
                    ID = 5,
                    Name = @"Elizabeth Richards",
                    Title = @"Vice President"
                },
                new EmployeeNestedDataItem_EmployeesItem()
                {
                    Age = 39,
                    HireDate = @"2010, 3, 22",
                    ID = 13,
                    Name = @"Trevor Ashworth",
                    Title = @"Director"
                }}
            ,
            HireDate = @"2014, 1, 22",
            ID = 4,
            Name = @"Ana Sanders",
            Title = @"CEO"
        });
        this.Add(new EmployeeNestedDataItem()
        {
            Age = 49,
            Employees = new List<EmployeeNestedDataItem_EmployeesItem>()
            {
            }
            ,
            HireDate = @"2014, 1, 22",
            ID = 18,
            Name = @"Victoria Lincoln",
            Title = @"Senior Accountant"
        });
        this.Add(new EmployeeNestedDataItem()
        {
            Age = 61,
            Employees = new List<EmployeeNestedDataItem_EmployeesItem>()
            {
            }
            ,
            HireDate = @"2010, 1, 1",
            ID = 10,
            Name = @"Yang Wang",
            Title = @"Localization Developer"
        });
        this.Add(new EmployeeNestedDataItem()
        {
            Age = 35,
            Employees = new List<EmployeeNestedDataItem_EmployeesItem>()
            {
            }
            ,
            HireDate = @"2014, 1, 22",
            ID = 35,
            Name = @"Janine Munoz",
            Title = @"HR"
        });
        this.Add(new EmployeeNestedDataItem()
        {
            Age = 49,
            Employees = new List<EmployeeNestedDataItem_EmployeesItem>()
            {
            }
            ,
            HireDate = @"2010, 1, 1",
            ID = 10,
            Name = @"Yang Wang",
            Title = @"Sales Manager"
        });
    }
}
