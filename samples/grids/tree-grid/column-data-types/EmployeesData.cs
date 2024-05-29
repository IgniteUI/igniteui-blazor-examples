//begin data
using System;
using System.Collections.Generic;

public class EmployeesData : List<Employee>
{
    public EmployeesData()
    {
        List<Employee> data = new List<Employee>()
        {
            new Employee()
            {
                Age = 55,
                HireDate= DateTime.Parse("2008-03-20"),
                HireTime = DateTime.Parse("2008-03-20") + new TimeSpan(12,0,0),
                HireFullDate= DateTime.Parse("2008-03-20") + new TimeSpan(12,0,0),
                ID = 1,
                Name = "Johnathan Winchester",
                OnPTO = false,
                ParentID = -1,
                Avatar = "https://static.infragistics.com/xplatform/images/people/men/5.jpg",
                Salary = 15,
                CompletedTasks = 0.15,
                Title = "Development Manager"
            },
            new Employee()
            {
                Age = 42,
                HireDate = DateTime.Parse("2014-01-22"),
                HireTime = DateTime.Parse("2014-01-22") + new TimeSpan(12,0,0),
                HireFullDate = DateTime.Parse("2014-01-22") + new TimeSpan(12,0,0),
                ID = 4,
                Name = "Ana Sanders",
                OnPTO = true,
                ParentID = -1,
                Avatar = "https://static.infragistics.com/xplatform/images/people/women/4.jpg",
                Salary = 39,
                CompletedTasks = 0.39,
                Title = "CEO"
            },
            new Employee()
            {
                Age = 49,
                HireDate = DateTime.Parse("2014-01-22"),
                HireTime = DateTime.Parse("2014-01-22") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2014-01-22") + new TimeSpan(14,0,0),
                ID = 18,
                Name = "Victoria Lincoln",
                OnPTO = true,
                ParentID = -1,
                Avatar = "https://static.infragistics.com/xplatform/images/people/women/2.jpg",
                Salary = 52,
                CompletedTasks = 0.52,
                Title = "Accounting Manager"
            },
            new Employee()
            {
                Age = 61,
                HireDate = DateTime.Parse("2010-01-01"),
                HireTime = DateTime.Parse("2010-01-01") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2010-01-01") + new TimeSpan(14,0,0),
                ID = 10,
                Name = "Yang Wang",
                OnPTO = false,
                ParentID = -1,
                Avatar = "https://static.infragistics.com/xplatform/images/people/men/4.jpg",
                Salary = 13,
                CompletedTasks = 0.13,
                Title = "Localization Manager"
            },
            new Employee()
            {
                Age = 43,
                HireDate = DateTime.Parse("2011-06-03"),
                HireTime = DateTime.Parse("2011-06-03") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2011-06-03") + new TimeSpan(14,0,0),
                ID = 3,
                Name = "Michael Burke",
                OnPTO = true,
                ParentID = 1,
                Avatar = "https://static.infragistics.com/xplatform/images/people/men/1.jpg",
                Salary = 22,
                CompletedTasks = 0.22,
                Title = "Senior Software Developer"
            },
            new Employee()
            {
                Age = 29,
                HireDate = DateTime.Parse("2009-06-19"),
                HireTime = DateTime.Parse("2009-06-19") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2009-06-19") + new TimeSpan(14,0,0),
                ID = 2,
                Name = "Thomas Anderson",
                OnPTO = false,
                ParentID = 1,
                Avatar = "https://static.infragistics.com/xplatform/images/people/men/2.jpg",
                Salary = 30,
                CompletedTasks = 0.3,
                Title = "Senior Software Developer"
            },
            new Employee()
            {
                Age = 31,
                HireDate = DateTime.Parse("2014-08-18"),
                HireTime = DateTime.Parse("2014-08-18") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2014-08-18") + new TimeSpan(14,0,0),
                ID = 11,
                Name = "Monica Reyes",
                OnPTO = false,
                ParentID = 1,
                Avatar = "https://static.infragistics.com/xplatform/images/people/women/3.jpg",
                Salary = 45,
                CompletedTasks = 0.45,
                Title = "Software Development Team Lead"
            },
            new Employee()
            {
                Age = 35,
                HireDate = DateTime.Parse("2015-09-17"),
                HireTime = DateTime.Parse("2015-09-17") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2015-09-17") + new TimeSpan(14,0,0),
                ID = 6,
                Name = "Roland Mendel",
                OnPTO = false,
                ParentID = 11,
                Avatar = "https://static.infragistics.com/xplatform/images/people/men/3.jpg",
                Salary = 35,
                CompletedTasks = 0.35,
                Title = "Senior Software Developer"
            },
            new Employee()
            {
                Age = 44,
                HireDate = DateTime.Parse("2009-10-11"),
                HireTime = DateTime.Parse("2009-10-11") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2009-10-11") + new TimeSpan(14,0,0),
                ID = 12,
                Name = "Sven Cooper",
                OnPTO = true,
                ParentID = 11,
                Avatar = "https://static.infragistics.com/xplatform/images/people/men/6.jpg",
                Salary = 29,
                CompletedTasks = 0.29,
                Title = "Senior Software Developer"
            },
            new Employee()
            {
                Age = 44,
                HireDate = DateTime.Parse("2014-04-04"),
                HireTime = DateTime.Parse("2014-04-04") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2014-04-04") + new TimeSpan(14,0,0),
                ID = 14,
                Name = "Laurence Johnson",
                OnPTO = false,
                ParentID = 4,
                Avatar = "https://static.infragistics.com/xplatform/images/people/men/7.jpg",
                Salary = 63,
                CompletedTasks = 0.63,
                Title = "Director"
            },
            new Employee()
            {
                Age = 25,
                HireDate = DateTime.Parse("2017-11-09"),
                HireTime = DateTime.Parse("2017-11-09") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2017-11-09") + new TimeSpan(14,0,0),
                ID = 5,
                Name = "Elizabeth Richards",
                OnPTO = true,
                ParentID = 4,
                Avatar = "https://static.infragistics.com/xplatform/images/people/women/1.jpg",
                Salary = 67,
                CompletedTasks = 0.67,
                Title = "Vice President"
            },
            new Employee()
            {
                Age = 39,
                HireDate = DateTime.Parse("2010-03-22"),
                HireTime = DateTime.Parse("2010-03-22") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2010-03-22") + new TimeSpan(14,0,0),
                ID = 13,
                Name = "Trevor Ashworth",
                OnPTO = true,
                ParentID = 5,
                Avatar = "https://static.infragistics.com/xplatform/images/people/men/8.jpg",
                Salary = 70,
                CompletedTasks = 0.7,
                Title = "Director"
            },
            new Employee()
            {
                Age = 44,
                HireDate = DateTime.Parse("2014-04-04"),
                HireTime = DateTime.Parse("2014-04-04") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2014-04-04") + new TimeSpan(14,0,0),
                ID = 17,
                Name = "Antonio Moreno",
                OnPTO = false,
                ParentID = 18,
                Avatar = "https://static.infragistics.com/xplatform/images/people/men/9.jpg",
                Salary = 52,
                CompletedTasks = 0.52,
                Title = "Senior Accountant"
            },
            new Employee()
            {
                Age = 50,
                HireDate = DateTime.Parse("2007-11-18"),
                HireTime = DateTime.Parse("2007-11-18") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2007-11-18") + new TimeSpan(14,0,0),
                ID = 7,
                Name = "Pedro Rodriguez",
                OnPTO = false,
                ParentID = 10,
                Avatar = "https://static.infragistics.com/xplatform/images/people/men/10.jpg",
                Salary = 43,
                CompletedTasks = 0.43,
                Title = "Senior Localization Developer"
            },
            new Employee()
            {
                Age = 27,
                HireDate = DateTime.Parse("2016-02-19"),
                HireTime = DateTime.Parse("2016-02-19") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2016-02-19") + new TimeSpan(14,0,0),
                ID = 8,
                Name = "Casey Harper",
                OnPTO = true,
                ParentID = 10,
                Avatar = "https://static.infragistics.com/xplatform/images/people/women/5.jpg",
                Salary = 35,
                CompletedTasks = 0.35,
                Title = "Senior Localization"
            },
            new Employee()
            {
                Age = 25,
                HireDate = DateTime.Parse("2017-11-09"),
                HireTime = DateTime.Parse("2017-11-09") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2017-11-09") + new TimeSpan(14,0,0),
                ID = 15,
                Name = "Patricia Simpson",
                OnPTO = false,
                ParentID = 7,
                Avatar = "https://static.infragistics.com/xplatform/images/people/women/6.jpg",
                Salary = 15,
                CompletedTasks = 0.15,
                Title = "Localization Intern"
            },
            new Employee()
            {
                Age = 39,
                HireDate = DateTime.Parse("2010-03-22"),
                HireTime = DateTime.Parse("2010-03-22") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2010-03-22") + new TimeSpan(14,0,0),
                ID = 9,
                Name = "Francisco Chang",
                OnPTO = false,
                ParentID = 7,
                Avatar = "https://static.infragistics.com/xplatform/images/people/men/26.jpg",
                Salary = 15,
                CompletedTasks = 0.15,
                Title = "Localization Intern"
            },
            new Employee()
            {
               Age = 25,
                HireDate = DateTime.Parse("2018-03-18"),
                HireTime = DateTime.Parse("2018-03-18") + new TimeSpan(14,0,0),
                HireFullDate = DateTime.Parse("2018-03-18") + new TimeSpan(14,0,0),
                ID = 16,
                Name = "Peter Lewis",
                OnPTO = true,
                ParentID = 7,
                Avatar = "https://static.infragistics.com/xplatform/images/people/men/27.jpg",
                Salary = 15,
                CompletedTasks = 0.15,
                Title = "Localization Intern"
            }
        };
 
        this.AddRange(data);
    }
}

public class Employee
{
    public int ID { get; set; }
    public int ParentID { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Avatar { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }
    public double CompletedTasks { get; set; }
    public bool OnPTO { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime HireTime { get; set; }
    public DateTime HireFullDate { get; set; }
}

//end data