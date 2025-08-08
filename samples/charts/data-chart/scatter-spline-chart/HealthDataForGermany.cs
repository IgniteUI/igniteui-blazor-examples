using System;
using System.Collections.Generic;
public class HealthDataForGermanyItem
{
    public double Year { get; set; }
    public double HealthExpense { get; set; }
    public double LifeExpectancy { get; set; }
    public string Name { get; set; }
}

public class HealthDataForGermany
    : List<HealthDataForGermanyItem>
{
    public HealthDataForGermany()
    {
        this.Add(new HealthDataForGermanyItem() { Year = 1985, HealthExpense = 2579.64, LifeExpectancy = 74.05, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 1986, HealthExpense = 2603.94, LifeExpectancy = 74.31, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 1987, HealthExpense = 2668.49, LifeExpectancy = 74.56, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 1988, HealthExpense = 2812.94, LifeExpectancy = 74.79, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 1989, HealthExpense = 2689.51, LifeExpectancy = 75.01, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 1990, HealthExpense = 2774.68, LifeExpectancy = 75.23, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 1992, HealthExpense = 2909.85, LifeExpectancy = 75.82, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 1993, HealthExpense = 2853.09, LifeExpectancy = 75.87, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 1994, HealthExpense = 2989.64, LifeExpectancy = 76.27, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 1995, HealthExpense = 3122.13, LifeExpectancy = 76.42, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 1996, HealthExpense = 3241.89, LifeExpectancy = 76.67, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 1997, HealthExpense = 3257.29, LifeExpectancy = 77.07, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 1998, HealthExpense = 3327.26, LifeExpectancy = 77.48, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 1999, HealthExpense = 3414.57, LifeExpectancy = 77.73, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2000, HealthExpense = 3536.35, LifeExpectancy = 77.93, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2001, HealthExpense = 3603.77, LifeExpectancy = 78.33, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2002, HealthExpense = 3687.38, LifeExpectancy = 78.23, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2003, HealthExpense = 3745.14, LifeExpectancy = 78.38, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2004, HealthExpense = 3704.96, LifeExpectancy = 78.68, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2005, HealthExpense = 3787.13, LifeExpectancy = 78.93, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2006, HealthExpense = 3875.14, LifeExpectancy = 79.13, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2007, HealthExpense = 3950.17, LifeExpectancy = 79.53, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2008, HealthExpense = 4079.09, LifeExpectancy = 79.74, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2009, HealthExpense = 4232.58, LifeExpectancy = 79.84, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2010, HealthExpense = 4358.61, LifeExpectancy = 79.99, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2011, HealthExpense = 4396.44, LifeExpectancy = 80.44, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2012, HealthExpense = 4516.99, LifeExpectancy = 80.54, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2013, HealthExpense = 4589.37, LifeExpectancy = 80.49, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2014, HealthExpense = 4684.49, LifeExpectancy = 81.09, Name = @"Germany" });
        this.Add(new HealthDataForGermanyItem() { Year = 2015, HealthExpense = 4772.33, LifeExpectancy = 80.64, Name = @"Germany" });
    }
}
