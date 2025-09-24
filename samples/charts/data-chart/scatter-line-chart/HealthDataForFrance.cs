using System;
using System.Collections.Generic;
public class HealthDataForFranceItem
{
    public double Year { get; set; }
    public double HealthExpense { get; set; }
    public double LifeExpectancy { get; set; }
    public string Name { get; set; }
}

public class HealthDataForFrance
    : List<HealthDataForFranceItem>
{
    public HealthDataForFrance()
    {
        this.Add(new HealthDataForFranceItem() { Year = 1985, HealthExpense = 2025.98, LifeExpectancy = 75.92, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 1986, HealthExpense = 2075.21, LifeExpectancy = 76.24, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 1987, HealthExpense = 2140.51, LifeExpectancy = 76.08, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 1988, HealthExpense = 2119.07, LifeExpectancy = 76.22, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 1989, HealthExpense = 2112.67, LifeExpectancy = 76.5, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 1990, HealthExpense = 2519.81, LifeExpectancy = 76.54, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 1991, HealthExpense = 2660.33, LifeExpectancy = 76.98, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 1992, HealthExpense = 2737.93, LifeExpectancy = 77.18, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 1993, HealthExpense = 2761.36, LifeExpectancy = 77.15, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 1994, HealthExpense = 2800.17, LifeExpectancy = 77.69, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 1995, HealthExpense = 2863.39, LifeExpectancy = 77.74, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 1996, HealthExpense = 3034.79, LifeExpectancy = 78.15, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 1997, HealthExpense = 3426.25, LifeExpectancy = 78.14, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 1998, HealthExpense = 3639.47, LifeExpectancy = 78.33, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 1999, HealthExpense = 3826.04, LifeExpectancy = 78.28, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2000, HealthExpense = 4003.97, LifeExpectancy = 78.63, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2001, HealthExpense = 4139.3, LifeExpectancy = 78.79, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2002, HealthExpense = 4504.06, LifeExpectancy = 78.99, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2003, HealthExpense = 4633.59, LifeExpectancy = 79.39, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2004, HealthExpense = 4734.15, LifeExpectancy = 79.84, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2005, HealthExpense = 4822.75, LifeExpectancy = 80.04, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2006, HealthExpense = 4846.36, LifeExpectancy = 80.34, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2007, HealthExpense = 4965.14, LifeExpectancy = 80.4, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2008, HealthExpense = 5149.6, LifeExpectancy = 80.59, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2009, HealthExpense = 5254.08, LifeExpectancy = 80.8, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2010, HealthExpense = 5240.42, LifeExpectancy = 81, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2011, HealthExpense = 5387.98, LifeExpectancy = 81.3, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2012, HealthExpense = 5499.09, LifeExpectancy = 81.45, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2013, HealthExpense = 5557.2, LifeExpectancy = 81.75, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2014, HealthExpense = 5730.16, LifeExpectancy = 82.1, Name = @"Norway" });
        this.Add(new HealthDataForFranceItem() { Year = 2015, HealthExpense = 5926.44, LifeExpectancy = 82.3, Name = @"Norway" });
    }
}
