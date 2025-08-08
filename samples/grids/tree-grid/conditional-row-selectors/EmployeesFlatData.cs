using System;
using System.Collections.Generic;
public class EmployeesFlatDataItem
{
    public double Age { get; set; }
    public string HireDate { get; set; }
    public double ID { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public bool OnPTO { get; set; }
    public double ParentID { get; set; }
    public string Title { get; set; }
}

public class EmployeesFlatData
    : List<EmployeesFlatDataItem>
{
    public EmployeesFlatData()
    {
        this.Add(new EmployeesFlatDataItem() { Age = 55, HireDate = @"2008-03-20", ID = 1, Name = @"Johnathan Winchester", Phone = @"0251-031259", OnPTO = false, ParentID = -1, Title = @"Development Manager" });
        this.Add(new EmployeesFlatDataItem() { Age = 42, HireDate = @"2014-01-22", ID = 4, Name = @"Ana Sanders", Phone = @"(21) 555-0091", OnPTO = true, ParentID = -1, Title = @"CEO" });
        this.Add(new EmployeesFlatDataItem() { Age = 49, HireDate = @"2014-01-22", ID = 18, Name = @"Victoria Lincoln", Phone = @"(071) 23 67 22 20", OnPTO = true, ParentID = -1, Title = @"Accounting Manager" });
        this.Add(new EmployeesFlatDataItem() { Age = 61, HireDate = @"2010-01-01", ID = 10, Name = @"Yang Wang", Phone = @"(21) 555-0091", OnPTO = false, ParentID = -1, Title = @"Localization Manager" });
        this.Add(new EmployeesFlatDataItem() { Age = 43, HireDate = @"2011-06-03", ID = 3, Name = @"Michael Burke", Phone = @"0452-076545", OnPTO = true, ParentID = 1, Title = @"Senior Software Developer" });
        this.Add(new EmployeesFlatDataItem() { Age = 29, HireDate = @"2009-06-19", ID = 2, Name = @"Thomas Anderson", Phone = @"(14) 555-8122", OnPTO = false, ParentID = 1, Title = @"Senior Software Developer" });
        this.Add(new EmployeesFlatDataItem() { Age = 31, HireDate = @"2014-08-18", ID = 11, Name = @"Monica Reyes", Phone = @"7675-3425", OnPTO = false, ParentID = 1, Title = @"Software Development Team Lead" });
        this.Add(new EmployeesFlatDataItem() { Age = 35, HireDate = @"2015-09-17", ID = 6, Name = @"Roland Mendel", Phone = @"(505) 555-5939", OnPTO = false, ParentID = 11, Title = @"Senior Software Developer" });
        this.Add(new EmployeesFlatDataItem() { Age = 44, HireDate = @"2009-10-11", ID = 12, Name = @"Sven Cooper", Phone = @"0695-34 67 21", OnPTO = true, ParentID = 11, Title = @"Senior Software Developer" });
        this.Add(new EmployeesFlatDataItem() { Age = 44, HireDate = @"2014-04-04", ID = 14, Name = @"Laurence Johnson", Phone = @"981-443655", OnPTO = false, ParentID = 4, Title = @"Director" });
        this.Add(new EmployeesFlatDataItem() { Age = 25, HireDate = @"2017-11-09", ID = 5, Name = @"Elizabeth Richards", Phone = @"(2) 283-2951", OnPTO = true, ParentID = 4, Title = @"Vice President" });
        this.Add(new EmployeesFlatDataItem() { Age = 39, HireDate = @"2010-03-22", ID = 13, Name = @"Trevor Ashworth", Phone = @"981-443655", OnPTO = true, ParentID = 5, Title = @"Director" });
        this.Add(new EmployeesFlatDataItem() { Age = 44, HireDate = @"2014-04-04", ID = 17, Name = @"Antonio Moreno", Phone = @"(505) 555-5939", OnPTO = false, ParentID = 18, Title = @"Senior Accountant" });
        this.Add(new EmployeesFlatDataItem() { Age = 50, HireDate = @"2007-11-18", ID = 7, Name = @"Pedro Rodriguez", Phone = @"035-640230", OnPTO = false, ParentID = 10, Title = @"Senior Localization Developer" });
        this.Add(new EmployeesFlatDataItem() { Age = 27, HireDate = @"2016-02-19", ID = 8, Name = @"Casey Harper", Phone = @"0342-023176", OnPTO = true, ParentID = 10, Title = @"Senior Localization" });
        this.Add(new EmployeesFlatDataItem() { Age = 25, HireDate = @"2017-11-09", ID = 15, Name = @"Patricia Simpson", Phone = @"069-0245984", OnPTO = false, ParentID = 7, Title = @"Localization Intern" });
        this.Add(new EmployeesFlatDataItem() { Age = 39, HireDate = @"2010-03-22", ID = 9, Name = @"Francisco Chang", Phone = @"(91) 745 6200", OnPTO = false, ParentID = 7, Title = @"Localization Intern" });
        this.Add(new EmployeesFlatDataItem() { Age = 25, HireDate = @"2018-03-18", ID = 16, Name = @"Peter Lewis", Phone = @"069-0245984", OnPTO = true, ParentID = 7, Title = @"Localization Intern" });
    }
}
