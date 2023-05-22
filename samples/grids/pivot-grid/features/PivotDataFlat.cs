using System;
using System.Collections.Generic;
public class PivotDataFlatItem
{
    public string ProductName { get; set; }
    public double ProductUnitPrice { get; set; }
    public string SellerName { get; set; }
    public string SellerCity { get; set; }
    public string Date { get; set; }
    public double Value { get; set; }
    public double NumberOfUnits { get; set; }
}

public class PivotDataFlat
    : List<PivotDataFlatItem>
{
    public PivotDataFlat()
    {
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 12.81,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Seattle",
            Date = @"2007-01-01T00:00:00",
            Value = 94.27,
            NumberOfUnits = 282
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 49.58,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Sofia",
            Date = @"2007-01-05T00:00:00",
            Value = 70.8,
            NumberOfUnits = 296
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 3.57,
            SellerName = @"Lydia Burson",
            SellerCity = @"Tokyo",
            Date = @"2007-01-06T00:00:00",
            Value = 35.8,
            NumberOfUnits = 68
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 85.58,
            SellerName = @"David Haley",
            SellerCity = @"London",
            Date = @"2007-01-07T00:00:00",
            Value = 41.41,
            NumberOfUnits = 293
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 18.14,
            SellerName = @"John Smith",
            SellerCity = @"Seattle",
            Date = @"2007-01-08T00:00:00",
            Value = 60.47,
            NumberOfUnits = 240
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 68.33,
            SellerName = @"Larry Lieb",
            SellerCity = @"Tokyo",
            Date = @"2007-01-12T00:00:00",
            Value = 37.92,
            NumberOfUnits = 456
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 16.06,
            SellerName = @"Walter Pang",
            SellerCity = @"Sofia",
            Date = @"2007-02-09T00:00:00",
            Value = 89.2,
            NumberOfUnits = 492
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 35.24,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Tokyo",
            Date = @"2007-02-16T00:00:00",
            Value = 1.86,
            NumberOfUnits = 78
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 73.22,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Mellvile",
            Date = @"2007-02-17T00:00:00",
            Value = 4.61,
            NumberOfUnits = 150
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 73.61,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"London",
            Date = @"2007-02-19T00:00:00",
            Value = 36.17,
            NumberOfUnits = 262
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 47.08,
            SellerName = @"Monica Freitag",
            SellerCity = @"Sofia",
            Date = @"2007-02-21T00:00:00",
            Value = 18.7,
            NumberOfUnits = 125
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 51.3,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Sofia",
            Date = @"2007-03-04T00:00:00",
            Value = 11.6,
            NumberOfUnits = 42
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 27.47,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2007-03-04T00:00:00",
            Value = 41.25,
            NumberOfUnits = 282
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 22.37,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Berlin",
            Date = @"2007-03-17T00:00:00",
            Value = 59.83,
            NumberOfUnits = 305
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 85.29,
            SellerName = @"Glenn Landeros",
            SellerCity = @"Tokyo",
            Date = @"2007-03-23T00:00:00",
            Value = 31.43,
            NumberOfUnits = 265
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 80.68,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Mellvile",
            Date = @"2007-03-25T00:00:00",
            Value = 90.43,
            NumberOfUnits = 350
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 64.61,
            SellerName = @"Glenn Landeros",
            SellerCity = @"Mellvile",
            Date = @"2007-03-27T00:00:00",
            Value = 95.39,
            NumberOfUnits = 82
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 50.04,
            SellerName = @"Harry Tyler",
            SellerCity = @"New York",
            Date = @"2007-04-02T00:00:00",
            Value = 1.28,
            NumberOfUnits = 67
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 16.31,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Mellvile",
            Date = @"2007-04-04T00:00:00",
            Value = 25.35,
            NumberOfUnits = 370
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 49.85,
            SellerName = @"Monica Freitag",
            SellerCity = @"Berlin",
            Date = @"2007-04-12T00:00:00",
            Value = 46.32,
            NumberOfUnits = 228
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 44.76,
            SellerName = @"Bryan Culver",
            SellerCity = @"Tokyo",
            Date = @"2007-04-15T00:00:00",
            Value = 82.18,
            NumberOfUnits = 272
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 44.4,
            SellerName = @"Russell Shorter",
            SellerCity = @"Berlin",
            Date = @"2007-04-18T00:00:00",
            Value = 83.97,
            NumberOfUnits = 227
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 39.29,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Mellvile",
            Date = @"2007-04-18T00:00:00",
            Value = 94.26,
            NumberOfUnits = 248
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 36.58,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Tokyo",
            Date = @"2007-04-21T00:00:00",
            Value = 45.74,
            NumberOfUnits = 414
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 75.83,
            SellerName = @"Walter Pang",
            SellerCity = @"London",
            Date = @"2007-04-25T00:00:00",
            Value = 97.59,
            NumberOfUnits = 43
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 57.76,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Mellvile",
            Date = @"2007-04-26T00:00:00",
            Value = 20.94,
            NumberOfUnits = 71
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 40.23,
            SellerName = @"Stanley Brooker",
            SellerCity = @"New York",
            Date = @"2007-05-14T00:00:00",
            Value = 71.86,
            NumberOfUnits = 321
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 49.53,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"London",
            Date = @"2007-05-17T00:00:00",
            Value = 49.45,
            NumberOfUnits = 329
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 56.46,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2007-05-17T00:00:00",
            Value = 72.7,
            NumberOfUnits = 88
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 67.13,
            SellerName = @"Glenn Landeros",
            SellerCity = @"New York",
            Date = @"2007-05-26T00:00:00",
            Value = 56.17,
            NumberOfUnits = 366
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 14.63,
            SellerName = @"Walter Pang",
            SellerCity = @"Sofia",
            Date = @"2007-06-02T00:00:00",
            Value = 81.32,
            NumberOfUnits = 450
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 89.26,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Seattle",
            Date = @"2007-06-06T00:00:00",
            Value = 18.96,
            NumberOfUnits = 475
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 33.75,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2007-06-11T00:00:00",
            Value = 54.87,
            NumberOfUnits = 195
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 54.1,
            SellerName = @"Harold Garvin",
            SellerCity = @"Sofia",
            Date = @"2007-06-17T00:00:00",
            Value = 71.63,
            NumberOfUnits = 458
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 18.44,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Sofia",
            Date = @"2007-07-04T00:00:00",
            Value = 24.16,
            NumberOfUnits = 7
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 96.14,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"New York",
            Date = @"2007-07-08T00:00:00",
            Value = 57.5,
            NumberOfUnits = 158
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 22.99,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Tokyo",
            Date = @"2007-07-09T00:00:00",
            Value = 58.8,
            NumberOfUnits = 34
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 52.66,
            SellerName = @"Larry Lieb",
            SellerCity = @"Seattle",
            Date = @"2007-07-10T00:00:00",
            Value = 32.4,
            NumberOfUnits = 412
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 62.13,
            SellerName = @"John Smith",
            SellerCity = @"Sofia",
            Date = @"2007-07-15T00:00:00",
            Value = 84.92,
            NumberOfUnits = 10
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 10.72,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"New York",
            Date = @"2007-07-16T00:00:00",
            Value = 52.21,
            NumberOfUnits = 466
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 4.69,
            SellerName = @"Stanley Brooker",
            SellerCity = @"London",
            Date = @"2007-07-20T00:00:00",
            Value = 34.22,
            NumberOfUnits = 248
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 43.72,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Mellvile",
            Date = @"2007-07-24T00:00:00",
            Value = 45.46,
            NumberOfUnits = 307
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 76.44,
            SellerName = @"Glenn Landeros",
            SellerCity = @"London",
            Date = @"2007-07-26T00:00:00",
            Value = 26.06,
            NumberOfUnits = 445
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 34.28,
            SellerName = @"Bryan Culver",
            SellerCity = @"New York",
            Date = @"2007-08-01T00:00:00",
            Value = 89.24,
            NumberOfUnits = 480
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 68.57,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Berlin",
            Date = @"2007-08-02T00:00:00",
            Value = 38.09,
            NumberOfUnits = 390
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 65.07,
            SellerName = @"Larry Lieb",
            SellerCity = @"Mellvile",
            Date = @"2007-08-05T00:00:00",
            Value = 23.05,
            NumberOfUnits = 388
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 44.94,
            SellerName = @"Russell Shorter",
            SellerCity = @"Seattle",
            Date = @"2007-08-19T00:00:00",
            Value = 23.37,
            NumberOfUnits = 37
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 93.47,
            SellerName = @"John Smith",
            SellerCity = @"New York",
            Date = @"2007-08-24T00:00:00",
            Value = 17.31,
            NumberOfUnits = 237
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 94.37,
            SellerName = @"Harry Tyler",
            SellerCity = @"Seattle",
            Date = @"2007-08-26T00:00:00",
            Value = 54.62,
            NumberOfUnits = 396
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 72.41,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2007-08-26T00:00:00",
            Value = 60.92,
            NumberOfUnits = 3
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 80.59,
            SellerName = @"Russell Shorter",
            SellerCity = @"New York",
            Date = @"2007-09-02T00:00:00",
            Value = 85.13,
            NumberOfUnits = 330
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 65.4,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2007-09-04T00:00:00",
            Value = 51.21,
            NumberOfUnits = 143
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 30.64,
            SellerName = @"Bryan Culver",
            SellerCity = @"Seattle",
            Date = @"2007-09-05T00:00:00",
            Value = 55.21,
            NumberOfUnits = 318
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 7.62,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Seattle",
            Date = @"2007-09-06T00:00:00",
            Value = 41.8,
            NumberOfUnits = 393
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 46.95,
            SellerName = @"Harold Garvin",
            SellerCity = @"Seattle",
            Date = @"2007-09-10T00:00:00",
            Value = 9.08,
            NumberOfUnits = 129
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 38.02,
            SellerName = @"Glenn Landeros",
            SellerCity = @"London",
            Date = @"2007-09-17T00:00:00",
            Value = 25.58,
            NumberOfUnits = 426
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 2.48,
            SellerName = @"Harry Tyler",
            SellerCity = @"London",
            Date = @"2007-09-18T00:00:00",
            Value = 36.33,
            NumberOfUnits = 217
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 77.59,
            SellerName = @"John Smith",
            SellerCity = @"New York",
            Date = @"2007-09-20T00:00:00",
            Value = 27.89,
            NumberOfUnits = 152
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 97.15,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Seattle",
            Date = @"2007-09-25T00:00:00",
            Value = 21.83,
            NumberOfUnits = 452
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 19.7,
            SellerName = @"Carl Costello",
            SellerCity = @"Seattle",
            Date = @"2007-10-02T00:00:00",
            Value = 98.26,
            NumberOfUnits = 499
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 32.78,
            SellerName = @"Mark Slater",
            SellerCity = @"Seattle",
            Date = @"2007-10-06T00:00:00",
            Value = 79.62,
            NumberOfUnits = 169
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 21.95,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Berlin",
            Date = @"2007-10-14T00:00:00",
            Value = 69.5,
            NumberOfUnits = 386
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 35.59,
            SellerName = @"Russell Shorter",
            SellerCity = @"Sofia",
            Date = @"2007-10-14T00:00:00",
            Value = 27.78,
            NumberOfUnits = 454
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 46.95,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"New York",
            Date = @"2007-10-25T00:00:00",
            Value = 82.14,
            NumberOfUnits = 334
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 41.13,
            SellerName = @"Lydia Burson",
            SellerCity = @"Tokyo",
            Date = @"2007-10-26T00:00:00",
            Value = 54.43,
            NumberOfUnits = 107
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 13.84,
            SellerName = @"Mark Slater",
            SellerCity = @"Sofia",
            Date = @"2007-11-07T00:00:00",
            Value = 86.21,
            NumberOfUnits = 275
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 64.16,
            SellerName = @"Monica Freitag",
            SellerCity = @"London",
            Date = @"2007-11-09T00:00:00",
            Value = 37.72,
            NumberOfUnits = 241
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 1.21,
            SellerName = @"Larry Lieb",
            SellerCity = @"London",
            Date = @"2007-11-11T00:00:00",
            Value = 75.23,
            NumberOfUnits = 177
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 57.81,
            SellerName = @"Monica Freitag",
            SellerCity = @"Sofia",
            Date = @"2007-11-13T00:00:00",
            Value = 58.45,
            NumberOfUnits = 494
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 39.49,
            SellerName = @"Lydia Burson",
            SellerCity = @"Mellvile",
            Date = @"2007-11-19T00:00:00",
            Value = 40.71,
            NumberOfUnits = 451
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 5.22,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Tokyo",
            Date = @"2008-01-01T00:00:00",
            Value = 91.82,
            NumberOfUnits = 125
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 53.43,
            SellerName = @"Kathe Pettel",
            SellerCity = @"London",
            Date = @"2008-01-02T00:00:00",
            Value = 30.89,
            NumberOfUnits = 103
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 52.16,
            SellerName = @"Larry Lieb",
            SellerCity = @"New York",
            Date = @"2008-01-03T00:00:00",
            Value = 42.96,
            NumberOfUnits = 224
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 17.69,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Mellvile",
            Date = @"2008-01-07T00:00:00",
            Value = 47.57,
            NumberOfUnits = 498
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 80.74,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2008-01-08T00:00:00",
            Value = 15.61,
            NumberOfUnits = 142
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 95.44,
            SellerName = @"Larry Lieb",
            SellerCity = @"Berlin",
            Date = @"2008-01-21T00:00:00",
            Value = 87.21,
            NumberOfUnits = 487
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 21.78,
            SellerName = @"David Haley",
            SellerCity = @"Mellvile",
            Date = @"2008-01-27T00:00:00",
            Value = 14.45,
            NumberOfUnits = 331
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 29.91,
            SellerName = @"Glenn Landeros",
            SellerCity = @"London",
            Date = @"2008-02-03T00:00:00",
            Value = 99.24,
            NumberOfUnits = 418
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 39.84,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"New York",
            Date = @"2008-02-04T00:00:00",
            Value = 61.02,
            NumberOfUnits = 214
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 40.37,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Mellvile",
            Date = @"2008-02-05T00:00:00",
            Value = 81.74,
            NumberOfUnits = 229
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 35.2,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"London",
            Date = @"2008-02-05T00:00:00",
            Value = 54.25,
            NumberOfUnits = 16
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 41.76,
            SellerName = @"Harry Tyler",
            SellerCity = @"Sofia",
            Date = @"2008-02-08T00:00:00",
            Value = 17.86,
            NumberOfUnits = 216
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 0.69,
            SellerName = @"Harry Tyler",
            SellerCity = @"Sofia",
            Date = @"2008-02-09T00:00:00",
            Value = 84.92,
            NumberOfUnits = 486
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 37.56,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Tokyo",
            Date = @"2008-02-13T00:00:00",
            Value = 45.08,
            NumberOfUnits = 172
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 20.8,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"New York",
            Date = @"2008-02-21T00:00:00",
            Value = 60.54,
            NumberOfUnits = 102
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 70.65,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Seattle",
            Date = @"2008-02-24T00:00:00",
            Value = 42.9,
            NumberOfUnits = 36
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 53.29,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Mellvile",
            Date = @"2008-02-25T00:00:00",
            Value = 11.02,
            NumberOfUnits = 71
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 24.85,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Mellvile",
            Date = @"2008-02-25T00:00:00",
            Value = 16.98,
            NumberOfUnits = 53
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 64.63,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Tokyo",
            Date = @"2008-02-25T00:00:00",
            Value = 98.96,
            NumberOfUnits = 104
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 9.64,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Tokyo",
            Date = @"2008-02-26T00:00:00",
            Value = 96.23,
            NumberOfUnits = 294
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 41.08,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Sofia",
            Date = @"2008-03-03T00:00:00",
            Value = 93.68,
            NumberOfUnits = 454
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 36.98,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Berlin",
            Date = @"2008-03-05T00:00:00",
            Value = 82.82,
            NumberOfUnits = 492
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 16.83,
            SellerName = @"Harry Tyler",
            SellerCity = @"New York",
            Date = @"2008-03-08T00:00:00",
            Value = 0.65,
            NumberOfUnits = 132
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 24.72,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"New York",
            Date = @"2008-03-09T00:00:00",
            Value = 88.52,
            NumberOfUnits = 225
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 65.64,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2008-03-10T00:00:00",
            Value = 69.07,
            NumberOfUnits = 422
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 70.47,
            SellerName = @"Glenn Landeros",
            SellerCity = @"London",
            Date = @"2008-03-12T00:00:00",
            Value = 97.09,
            NumberOfUnits = 303
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 65.12,
            SellerName = @"Carl Costello",
            SellerCity = @"London",
            Date = @"2008-03-13T00:00:00",
            Value = 46.44,
            NumberOfUnits = 319
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 39.58,
            SellerName = @"Harold Garvin",
            SellerCity = @"London",
            Date = @"2008-03-14T00:00:00",
            Value = 48.54,
            NumberOfUnits = 262
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 50.71,
            SellerName = @"Harold Garvin",
            SellerCity = @"Berlin",
            Date = @"2008-03-23T00:00:00",
            Value = 91.72,
            NumberOfUnits = 345
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 88.25,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2008-04-03T00:00:00",
            Value = 87.28,
            NumberOfUnits = 407
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 47.25,
            SellerName = @"Walter Pang",
            SellerCity = @"Berlin",
            Date = @"2008-04-04T00:00:00",
            Value = 15.13,
            NumberOfUnits = 121
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 30.43,
            SellerName = @"Larry Lieb",
            SellerCity = @"Seattle",
            Date = @"2008-04-06T00:00:00",
            Value = 44.43,
            NumberOfUnits = 30
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 88.24,
            SellerName = @"Harold Garvin",
            SellerCity = @"Berlin",
            Date = @"2008-04-11T00:00:00",
            Value = 25.28,
            NumberOfUnits = 293
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 16.46,
            SellerName = @"David Haley",
            SellerCity = @"Sofia",
            Date = @"2008-04-12T00:00:00",
            Value = 55.07,
            NumberOfUnits = 271
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 95.21,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Sofia",
            Date = @"2008-04-18T00:00:00",
            Value = 25.77,
            NumberOfUnits = 107
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 7.75,
            SellerName = @"Bryan Culver",
            SellerCity = @"Mellvile",
            Date = @"2008-04-18T00:00:00",
            Value = 54.48,
            NumberOfUnits = 87
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 94.83,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2008-04-23T00:00:00",
            Value = 78.95,
            NumberOfUnits = 319
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 37.21,
            SellerName = @"Lydia Burson",
            SellerCity = @"New York",
            Date = @"2008-04-24T00:00:00",
            Value = 21.61,
            NumberOfUnits = 346
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 99.31,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2008-05-07T00:00:00",
            Value = 77.78,
            NumberOfUnits = 382
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 96.08,
            SellerName = @"Larry Lieb",
            SellerCity = @"New York",
            Date = @"2008-05-11T00:00:00",
            Value = 35.35,
            NumberOfUnits = 334
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 26.15,
            SellerName = @"Harold Garvin",
            SellerCity = @"Tokyo",
            Date = @"2008-05-13T00:00:00",
            Value = 28.84,
            NumberOfUnits = 176
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 80.82,
            SellerName = @"Mark Slater",
            SellerCity = @"Berlin",
            Date = @"2008-05-19T00:00:00",
            Value = 8.38,
            NumberOfUnits = 125
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 78.32,
            SellerName = @"Russell Shorter",
            SellerCity = @"Mellvile",
            Date = @"2008-05-19T00:00:00",
            Value = 15.04,
            NumberOfUnits = 458
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 94,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Berlin",
            Date = @"2008-05-25T00:00:00",
            Value = 68.47,
            NumberOfUnits = 331
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 96.6,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Mellvile",
            Date = @"2008-05-27T00:00:00",
            Value = 70.95,
            NumberOfUnits = 39
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 37.64,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"London",
            Date = @"2008-06-06T00:00:00",
            Value = 97.09,
            NumberOfUnits = 238
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 46.98,
            SellerName = @"Walter Pang",
            SellerCity = @"London",
            Date = @"2008-06-07T00:00:00",
            Value = 5.68,
            NumberOfUnits = 84
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 80.15,
            SellerName = @"Mark Slater",
            SellerCity = @"Tokyo",
            Date = @"2008-06-08T00:00:00",
            Value = 24.84,
            NumberOfUnits = 363
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 43.52,
            SellerName = @"Harry Tyler",
            SellerCity = @"New York",
            Date = @"2008-06-08T00:00:00",
            Value = 58.97,
            NumberOfUnits = 479
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 56.32,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Sofia",
            Date = @"2008-06-11T00:00:00",
            Value = 87.47,
            NumberOfUnits = 404
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 81.69,
            SellerName = @"Glenn Landeros",
            SellerCity = @"London",
            Date = @"2008-06-18T00:00:00",
            Value = 80.28,
            NumberOfUnits = 478
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 90.11,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Sofia",
            Date = @"2008-06-19T00:00:00",
            Value = 2.33,
            NumberOfUnits = 285
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 99.34,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Sofia",
            Date = @"2008-06-22T00:00:00",
            Value = 82.49,
            NumberOfUnits = 15
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 30.83,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Berlin",
            Date = @"2008-06-26T00:00:00",
            Value = 77.83,
            NumberOfUnits = 245
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 99.39,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Mellvile",
            Date = @"2008-07-01T00:00:00",
            Value = 8.14,
            NumberOfUnits = 376
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 73.35,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"New York",
            Date = @"2008-07-02T00:00:00",
            Value = 48.45,
            NumberOfUnits = 40
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 43.5,
            SellerName = @"Larry Lieb",
            SellerCity = @"London",
            Date = @"2008-07-10T00:00:00",
            Value = 37.87,
            NumberOfUnits = 112
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 16.39,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"New York",
            Date = @"2008-07-15T00:00:00",
            Value = 9.74,
            NumberOfUnits = 224
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 71.4,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Tokyo",
            Date = @"2008-07-16T00:00:00",
            Value = 66.42,
            NumberOfUnits = 145
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 94.62,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Mellvile",
            Date = @"2008-07-21T00:00:00",
            Value = 46.49,
            NumberOfUnits = 272
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 50.75,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"London",
            Date = @"2008-07-27T00:00:00",
            Value = 90.11,
            NumberOfUnits = 278
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 12.78,
            SellerName = @"Harry Tyler",
            SellerCity = @"Seattle",
            Date = @"2008-07-27T00:00:00",
            Value = 89.14,
            NumberOfUnits = 253
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 35.78,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"New York",
            Date = @"2008-08-01T00:00:00",
            Value = 28.41,
            NumberOfUnits = 255
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 17.13,
            SellerName = @"David Haley",
            SellerCity = @"Seattle",
            Date = @"2008-08-02T00:00:00",
            Value = 0.46,
            NumberOfUnits = 46
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 22.13,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Tokyo",
            Date = @"2008-08-08T00:00:00",
            Value = 58.45,
            NumberOfUnits = 279
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 62.99,
            SellerName = @"Russell Shorter",
            SellerCity = @"Sofia",
            Date = @"2008-08-08T00:00:00",
            Value = 91.8,
            NumberOfUnits = 89
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 83.84,
            SellerName = @"Larry Lieb",
            SellerCity = @"Sofia",
            Date = @"2008-08-14T00:00:00",
            Value = 52.59,
            NumberOfUnits = 17
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 14.08,
            SellerName = @"Lydia Burson",
            SellerCity = @"Sofia",
            Date = @"2008-08-21T00:00:00",
            Value = 53.91,
            NumberOfUnits = 470
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 34.59,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Mellvile",
            Date = @"2008-08-25T00:00:00",
            Value = 1.74,
            NumberOfUnits = 195
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 86.73,
            SellerName = @"Lydia Burson",
            SellerCity = @"New York",
            Date = @"2008-08-27T00:00:00",
            Value = 23.78,
            NumberOfUnits = 173
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 42.24,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"New York",
            Date = @"2008-09-01T00:00:00",
            Value = 51.12,
            NumberOfUnits = 472
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 25.69,
            SellerName = @"Larry Lieb",
            SellerCity = @"Seattle",
            Date = @"2008-09-06T00:00:00",
            Value = 88.37,
            NumberOfUnits = 148
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 23.21,
            SellerName = @"Walter Pang",
            SellerCity = @"Mellvile",
            Date = @"2008-09-06T00:00:00",
            Value = 94.49,
            NumberOfUnits = 314
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 83.76,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2008-09-07T00:00:00",
            Value = 66.78,
            NumberOfUnits = 431
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 84.41,
            SellerName = @"Walter Pang",
            SellerCity = @"Mellvile",
            Date = @"2008-09-07T00:00:00",
            Value = 27.64,
            NumberOfUnits = 347
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 7.33,
            SellerName = @"Harry Tyler",
            SellerCity = @"Berlin",
            Date = @"2008-09-11T00:00:00",
            Value = 2.77,
            NumberOfUnits = 27
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 9.55,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Berlin",
            Date = @"2008-09-12T00:00:00",
            Value = 11.85,
            NumberOfUnits = 5
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 50.82,
            SellerName = @"Larry Lieb",
            SellerCity = @"Mellvile",
            Date = @"2008-09-19T00:00:00",
            Value = 16.47,
            NumberOfUnits = 191
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 79.87,
            SellerName = @"Bryan Culver",
            SellerCity = @"New York",
            Date = @"2008-09-25T00:00:00",
            Value = 84.27,
            NumberOfUnits = 421
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 62.24,
            SellerName = @"Carl Costello",
            SellerCity = @"Seattle",
            Date = @"2008-10-03T00:00:00",
            Value = 28.86,
            NumberOfUnits = 297
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 96.09,
            SellerName = @"Glenn Landeros",
            SellerCity = @"New York",
            Date = @"2008-10-04T00:00:00",
            Value = 15.8,
            NumberOfUnits = 128
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 47.01,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Mellvile",
            Date = @"2008-10-13T00:00:00",
            Value = 37.3,
            NumberOfUnits = 210
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 35.76,
            SellerName = @"Russell Shorter",
            SellerCity = @"London",
            Date = @"2008-10-14T00:00:00",
            Value = 26.94,
            NumberOfUnits = 315
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 78.99,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"New York",
            Date = @"2008-10-19T00:00:00",
            Value = 69.84,
            NumberOfUnits = 489
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 84.32,
            SellerName = @"Walter Pang",
            SellerCity = @"Mellvile",
            Date = @"2008-10-21T00:00:00",
            Value = 61.32,
            NumberOfUnits = 47
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 25.53,
            SellerName = @"John Smith",
            SellerCity = @"Mellvile",
            Date = @"2008-10-22T00:00:00",
            Value = 69.34,
            NumberOfUnits = 92
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 23.87,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Mellvile",
            Date = @"2008-11-01T00:00:00",
            Value = 81.09,
            NumberOfUnits = 30
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 53.63,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Berlin",
            Date = @"2008-11-01T00:00:00",
            Value = 15.01,
            NumberOfUnits = 132
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 68.15,
            SellerName = @"Bryan Culver",
            SellerCity = @"London",
            Date = @"2008-11-10T00:00:00",
            Value = 6.05,
            NumberOfUnits = 368
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 59.88,
            SellerName = @"Kathe Pettel",
            SellerCity = @"New York",
            Date = @"2008-11-11T00:00:00",
            Value = 39.09,
            NumberOfUnits = 482
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 5.75,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Mellvile",
            Date = @"2008-11-11T00:00:00",
            Value = 48.66,
            NumberOfUnits = 22
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 95.85,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"London",
            Date = @"2008-11-20T00:00:00",
            Value = 87.14,
            NumberOfUnits = 159
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 59.07,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Berlin",
            Date = @"2008-11-25T00:00:00",
            Value = 88.64,
            NumberOfUnits = 52
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 94.03,
            SellerName = @"Harry Tyler",
            SellerCity = @"Tokyo",
            Date = @"2009-01-05T00:00:00",
            Value = 79.83,
            NumberOfUnits = 194
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 12.79,
            SellerName = @"David Haley",
            SellerCity = @"Berlin",
            Date = @"2009-01-08T00:00:00",
            Value = 42.87,
            NumberOfUnits = 100
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 37.85,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Berlin",
            Date = @"2009-01-10T00:00:00",
            Value = 48.26,
            NumberOfUnits = 252
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 79.43,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Tokyo",
            Date = @"2009-01-13T00:00:00",
            Value = 68.51,
            NumberOfUnits = 116
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 90.92,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"London",
            Date = @"2009-01-14T00:00:00",
            Value = 27.46,
            NumberOfUnits = 259
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 99.85,
            SellerName = @"Glenn Landeros",
            SellerCity = @"London",
            Date = @"2009-01-19T00:00:00",
            Value = 56.73,
            NumberOfUnits = 217
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 43.27,
            SellerName = @"Bryan Culver",
            SellerCity = @"Seattle",
            Date = @"2009-01-22T00:00:00",
            Value = 36.47,
            NumberOfUnits = 48
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 0.65,
            SellerName = @"Stanley Brooker",
            SellerCity = @"New York",
            Date = @"2009-02-02T00:00:00",
            Value = 71.43,
            NumberOfUnits = 445
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 60.46,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Mellvile",
            Date = @"2009-02-03T00:00:00",
            Value = 44.63,
            NumberOfUnits = 90
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 13.66,
            SellerName = @"Harry Tyler",
            SellerCity = @"Sofia",
            Date = @"2009-02-07T00:00:00",
            Value = 36.15,
            NumberOfUnits = 453
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 44.16,
            SellerName = @"Harry Tyler",
            SellerCity = @"Mellvile",
            Date = @"2009-02-07T00:00:00",
            Value = 85.64,
            NumberOfUnits = 450
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 94.33,
            SellerName = @"Lydia Burson",
            SellerCity = @"Sofia",
            Date = @"2009-02-07T00:00:00",
            Value = 48.1,
            NumberOfUnits = 152
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 8.78,
            SellerName = @"Harry Tyler",
            SellerCity = @"Berlin",
            Date = @"2009-02-16T00:00:00",
            Value = 46.49,
            NumberOfUnits = 119
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 79.24,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Tokyo",
            Date = @"2009-02-16T00:00:00",
            Value = 29.24,
            NumberOfUnits = 463
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 18.59,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Tokyo",
            Date = @"2009-02-17T00:00:00",
            Value = 19.76,
            NumberOfUnits = 150
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 27.9,
            SellerName = @"Walter Pang",
            SellerCity = @"Berlin",
            Date = @"2009-02-19T00:00:00",
            Value = 17.56,
            NumberOfUnits = 210
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 67.19,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Tokyo",
            Date = @"2009-02-20T00:00:00",
            Value = 36.32,
            NumberOfUnits = 150
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 35.85,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"London",
            Date = @"2009-02-21T00:00:00",
            Value = 73.89,
            NumberOfUnits = 97
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 34.07,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Berlin",
            Date = @"2009-02-22T00:00:00",
            Value = 86.42,
            NumberOfUnits = 256
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 66.3,
            SellerName = @"Russell Shorter",
            SellerCity = @"London",
            Date = @"2009-02-24T00:00:00",
            Value = 52.85,
            NumberOfUnits = 172
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 14.9,
            SellerName = @"Monica Freitag",
            SellerCity = @"Mellvile",
            Date = @"2009-02-24T00:00:00",
            Value = 5.11,
            NumberOfUnits = 489
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 51.92,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Sofia",
            Date = @"2009-02-27T00:00:00",
            Value = 9.09,
            NumberOfUnits = 222
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 98.31,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Berlin",
            Date = @"2009-03-03T00:00:00",
            Value = 81.31,
            NumberOfUnits = 300
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 72.82,
            SellerName = @"Harry Tyler",
            SellerCity = @"London",
            Date = @"2009-03-03T00:00:00",
            Value = 1.31,
            NumberOfUnits = 270
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 16.26,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"London",
            Date = @"2009-03-07T00:00:00",
            Value = 81.44,
            NumberOfUnits = 263
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 93.45,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Mellvile",
            Date = @"2009-03-10T00:00:00",
            Value = 22.66,
            NumberOfUnits = 28
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 42.14,
            SellerName = @"Howard Sprouse",
            SellerCity = @"London",
            Date = @"2009-03-15T00:00:00",
            Value = 20.39,
            NumberOfUnits = 237
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 54.98,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Tokyo",
            Date = @"2009-03-16T00:00:00",
            Value = 64.04,
            NumberOfUnits = 171
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 97.31,
            SellerName = @"Kathe Pettel",
            SellerCity = @"New York",
            Date = @"2009-03-27T00:00:00",
            Value = 23.9,
            NumberOfUnits = 251
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 50.89,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"London",
            Date = @"2009-04-01T00:00:00",
            Value = 32.32,
            NumberOfUnits = 275
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 4.71,
            SellerName = @"Brandon Mckim",
            SellerCity = @"London",
            Date = @"2009-04-06T00:00:00",
            Value = 41.96,
            NumberOfUnits = 311
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 70.85,
            SellerName = @"Monica Freitag",
            SellerCity = @"New York",
            Date = @"2009-04-07T00:00:00",
            Value = 82.81,
            NumberOfUnits = 217
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 96.78,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"London",
            Date = @"2009-04-09T00:00:00",
            Value = 62.23,
            NumberOfUnits = 360
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 83.51,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Berlin",
            Date = @"2009-04-12T00:00:00",
            Value = 51.59,
            NumberOfUnits = 35
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 96.41,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"New York",
            Date = @"2009-04-15T00:00:00",
            Value = 80.99,
            NumberOfUnits = 294
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 70.8,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Seattle",
            Date = @"2009-04-16T00:00:00",
            Value = 35.87,
            NumberOfUnits = 436
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 94.52,
            SellerName = @"Kathe Pettel",
            SellerCity = @"London",
            Date = @"2009-04-20T00:00:00",
            Value = 82.49,
            NumberOfUnits = 78
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 29.6,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2009-04-22T00:00:00",
            Value = 94.02,
            NumberOfUnits = 301
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 70.6,
            SellerName = @"Mark Slater",
            SellerCity = @"New York",
            Date = @"2009-05-02T00:00:00",
            Value = 92.6,
            NumberOfUnits = 24
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 71.67,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Seattle",
            Date = @"2009-05-04T00:00:00",
            Value = 19.28,
            NumberOfUnits = 332
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 14.55,
            SellerName = @"Mark Slater",
            SellerCity = @"Berlin",
            Date = @"2009-05-11T00:00:00",
            Value = 56.43,
            NumberOfUnits = 307
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 36.71,
            SellerName = @"Harold Garvin",
            SellerCity = @"Seattle",
            Date = @"2009-05-11T00:00:00",
            Value = 34.27,
            NumberOfUnits = 375
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 62.75,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Mellvile",
            Date = @"2009-05-12T00:00:00",
            Value = 1.97,
            NumberOfUnits = 499
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 13.7,
            SellerName = @"Russell Shorter",
            SellerCity = @"London",
            Date = @"2009-05-21T00:00:00",
            Value = 42.51,
            NumberOfUnits = 337
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 46.09,
            SellerName = @"Larry Lieb",
            SellerCity = @"London",
            Date = @"2009-05-24T00:00:00",
            Value = 55.25,
            NumberOfUnits = 284
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 95.34,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Berlin",
            Date = @"2009-05-26T00:00:00",
            Value = 94.76,
            NumberOfUnits = 292
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 78.09,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Sofia",
            Date = @"2009-05-26T00:00:00",
            Value = 60.15,
            NumberOfUnits = 424
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 99.39,
            SellerName = @"Mark Slater",
            SellerCity = @"Mellvile",
            Date = @"2009-06-05T00:00:00",
            Value = 28.99,
            NumberOfUnits = 271
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 86.94,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Mellvile",
            Date = @"2009-06-10T00:00:00",
            Value = 94.04,
            NumberOfUnits = 6
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 13.5,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Sofia",
            Date = @"2009-06-12T00:00:00",
            Value = 94.89,
            NumberOfUnits = 44
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 99.65,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2009-06-12T00:00:00",
            Value = 74.2,
            NumberOfUnits = 277
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 16.88,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Seattle",
            Date = @"2009-06-13T00:00:00",
            Value = 65.12,
            NumberOfUnits = 98
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 42.38,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Mellvile",
            Date = @"2009-06-22T00:00:00",
            Value = 68.6,
            NumberOfUnits = 443
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 79.54,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Seattle",
            Date = @"2009-06-26T00:00:00",
            Value = 81.43,
            NumberOfUnits = 409
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 26.25,
            SellerName = @"Walter Pang",
            SellerCity = @"New York",
            Date = @"2009-07-02T00:00:00",
            Value = 68.13,
            NumberOfUnits = 240
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 34.05,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Seattle",
            Date = @"2009-07-10T00:00:00",
            Value = 95.57,
            NumberOfUnits = 23
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 29.38,
            SellerName = @"Larry Lieb",
            SellerCity = @"Mellvile",
            Date = @"2009-07-12T00:00:00",
            Value = 35.89,
            NumberOfUnits = 109
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 86.65,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Berlin",
            Date = @"2009-07-13T00:00:00",
            Value = 29.86,
            NumberOfUnits = 117
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 58.39,
            SellerName = @"Mark Slater",
            SellerCity = @"New York",
            Date = @"2009-07-15T00:00:00",
            Value = 34.37,
            NumberOfUnits = 336
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 39.76,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Seattle",
            Date = @"2009-07-18T00:00:00",
            Value = 92.4,
            NumberOfUnits = 372
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 10.11,
            SellerName = @"Larry Lieb",
            SellerCity = @"Berlin",
            Date = @"2009-07-19T00:00:00",
            Value = 90.41,
            NumberOfUnits = 403
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 17.77,
            SellerName = @"Harry Tyler",
            SellerCity = @"Seattle",
            Date = @"2009-07-19T00:00:00",
            Value = 66.15,
            NumberOfUnits = 144
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 21.54,
            SellerName = @"Lydia Burson",
            SellerCity = @"Seattle",
            Date = @"2009-07-19T00:00:00",
            Value = 41.71,
            NumberOfUnits = 395
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 33.56,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"New York",
            Date = @"2009-07-20T00:00:00",
            Value = 16.61,
            NumberOfUnits = 236
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 48.76,
            SellerName = @"Larry Lieb",
            SellerCity = @"Seattle",
            Date = @"2009-07-20T00:00:00",
            Value = 86.7,
            NumberOfUnits = 160
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 81.8,
            SellerName = @"David Haley",
            SellerCity = @"Sofia",
            Date = @"2009-07-20T00:00:00",
            Value = 65.78,
            NumberOfUnits = 157
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 9.67,
            SellerName = @"Glenn Landeros",
            SellerCity = @"Sofia",
            Date = @"2009-07-25T00:00:00",
            Value = 0.06,
            NumberOfUnits = 255
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 88.58,
            SellerName = @"Mark Slater",
            SellerCity = @"London",
            Date = @"2009-08-16T00:00:00",
            Value = 42.97,
            NumberOfUnits = 284
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 89.34,
            SellerName = @"Walter Pang",
            SellerCity = @"Tokyo",
            Date = @"2009-08-17T00:00:00",
            Value = 15.73,
            NumberOfUnits = 333
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 23.99,
            SellerName = @"Monica Freitag",
            SellerCity = @"Seattle",
            Date = @"2009-08-17T00:00:00",
            Value = 51.54,
            NumberOfUnits = 48
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 19.36,
            SellerName = @"Kathe Pettel",
            SellerCity = @"New York",
            Date = @"2009-08-18T00:00:00",
            Value = 82.55,
            NumberOfUnits = 399
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 9.3,
            SellerName = @"Mark Slater",
            SellerCity = @"Berlin",
            Date = @"2009-08-24T00:00:00",
            Value = 68.61,
            NumberOfUnits = 413
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 1.15,
            SellerName = @"Monica Freitag",
            SellerCity = @"Sofia",
            Date = @"2009-09-06T00:00:00",
            Value = 71.91,
            NumberOfUnits = 182
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 76.98,
            SellerName = @"Russell Shorter",
            SellerCity = @"Mellvile",
            Date = @"2009-09-06T00:00:00",
            Value = 44.89,
            NumberOfUnits = 156
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 80.66,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Mellvile",
            Date = @"2009-09-09T00:00:00",
            Value = 92.27,
            NumberOfUnits = 293
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 22.79,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Berlin",
            Date = @"2009-10-01T00:00:00",
            Value = 99.88,
            NumberOfUnits = 16
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 78.05,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Seattle",
            Date = @"2009-10-01T00:00:00",
            Value = 16.01,
            NumberOfUnits = 106
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 72.97,
            SellerName = @"Glenn Landeros",
            SellerCity = @"Tokyo",
            Date = @"2009-10-06T00:00:00",
            Value = 91.59,
            NumberOfUnits = 16
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 22.06,
            SellerName = @"John Smith",
            SellerCity = @"Tokyo",
            Date = @"2009-10-07T00:00:00",
            Value = 1.83,
            NumberOfUnits = 187
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 42.79,
            SellerName = @"Harry Tyler",
            SellerCity = @"Seattle",
            Date = @"2009-10-10T00:00:00",
            Value = 21.79,
            NumberOfUnits = 137
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 46.23,
            SellerName = @"Mark Slater",
            SellerCity = @"Seattle",
            Date = @"2009-10-14T00:00:00",
            Value = 14.98,
            NumberOfUnits = 138
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 14.35,
            SellerName = @"Mark Slater",
            SellerCity = @"Seattle",
            Date = @"2009-10-24T00:00:00",
            Value = 65.04,
            NumberOfUnits = 256
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 40.1,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"London",
            Date = @"2009-10-24T00:00:00",
            Value = 11.06,
            NumberOfUnits = 353
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 17.19,
            SellerName = @"Lydia Burson",
            SellerCity = @"Tokyo",
            Date = @"2009-11-01T00:00:00",
            Value = 94.95,
            NumberOfUnits = 359
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 52.03,
            SellerName = @"Walter Pang",
            SellerCity = @"Tokyo",
            Date = @"2009-11-04T00:00:00",
            Value = 43.16,
            NumberOfUnits = 134
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 90.99,
            SellerName = @"Larry Lieb",
            SellerCity = @"Seattle",
            Date = @"2009-11-09T00:00:00",
            Value = 25.16,
            NumberOfUnits = 263
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 88.54,
            SellerName = @"Monica Freitag",
            SellerCity = @"Seattle",
            Date = @"2009-11-11T00:00:00",
            Value = 40.94,
            NumberOfUnits = 313
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 46.48,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Mellvile",
            Date = @"2009-11-16T00:00:00",
            Value = 20.43,
            NumberOfUnits = 115
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 20.42,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Berlin",
            Date = @"2009-11-17T00:00:00",
            Value = 33.04,
            NumberOfUnits = 414
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 70.83,
            SellerName = @"Kathe Pettel",
            SellerCity = @"New York",
            Date = @"2009-11-21T00:00:00",
            Value = 2.99,
            NumberOfUnits = 53
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 81.63,
            SellerName = @"John Smith",
            SellerCity = @"New York",
            Date = @"2009-11-22T00:00:00",
            Value = 86.67,
            NumberOfUnits = 472
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 9.71,
            SellerName = @"Harry Tyler",
            SellerCity = @"Mellvile",
            Date = @"2009-11-23T00:00:00",
            Value = 53.59,
            NumberOfUnits = 199
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 29.76,
            SellerName = @"Harold Garvin",
            SellerCity = @"Sofia",
            Date = @"2009-11-24T00:00:00",
            Value = 27.39,
            NumberOfUnits = 241
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 33.12,
            SellerName = @"Glenn Landeros",
            SellerCity = @"New York",
            Date = @"2009-11-24T00:00:00",
            Value = 1.21,
            NumberOfUnits = 320
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 65.64,
            SellerName = @"David Haley",
            SellerCity = @"London",
            Date = @"2010-01-02T00:00:00",
            Value = 20.52,
            NumberOfUnits = 299
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 62.09,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2010-01-08T00:00:00",
            Value = 35.26,
            NumberOfUnits = 366
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 78.47,
            SellerName = @"John Smith",
            SellerCity = @"New York",
            Date = @"2010-01-10T00:00:00",
            Value = 27.76,
            NumberOfUnits = 290
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 11.59,
            SellerName = @"Lydia Burson",
            SellerCity = @"Sofia",
            Date = @"2010-01-11T00:00:00",
            Value = 61.71,
            NumberOfUnits = 350
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 33.43,
            SellerName = @"Russell Shorter",
            SellerCity = @"Sofia",
            Date = @"2010-01-14T00:00:00",
            Value = 33.69,
            NumberOfUnits = 469
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 96.14,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Sofia",
            Date = @"2010-01-21T00:00:00",
            Value = 75.61,
            NumberOfUnits = 352
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 92.17,
            SellerName = @"Larry Lieb",
            SellerCity = @"Seattle",
            Date = @"2010-01-25T00:00:00",
            Value = 38.82,
            NumberOfUnits = 47
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 93.05,
            SellerName = @"Russell Shorter",
            SellerCity = @"Tokyo",
            Date = @"2010-02-02T00:00:00",
            Value = 66.4,
            NumberOfUnits = 153
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 38.89,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Berlin",
            Date = @"2010-02-02T00:00:00",
            Value = 28.47,
            NumberOfUnits = 211
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 99.26,
            SellerName = @"Russell Shorter",
            SellerCity = @"Sofia",
            Date = @"2010-02-04T00:00:00",
            Value = 66.98,
            NumberOfUnits = 267
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 94.42,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"New York",
            Date = @"2010-02-04T00:00:00",
            Value = 71.27,
            NumberOfUnits = 91
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 19.77,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Tokyo",
            Date = @"2010-02-05T00:00:00",
            Value = 45.86,
            NumberOfUnits = 84
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 87.13,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Mellvile",
            Date = @"2010-02-11T00:00:00",
            Value = 66.75,
            NumberOfUnits = 270
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 76.22,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Berlin",
            Date = @"2010-02-12T00:00:00",
            Value = 86.96,
            NumberOfUnits = 496
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 51.94,
            SellerName = @"John Smith",
            SellerCity = @"Seattle",
            Date = @"2010-02-16T00:00:00",
            Value = 47.33,
            NumberOfUnits = 24
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 21.71,
            SellerName = @"Walter Pang",
            SellerCity = @"Mellvile",
            Date = @"2010-02-17T00:00:00",
            Value = 72.66,
            NumberOfUnits = 41
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 15.67,
            SellerName = @"John Smith",
            SellerCity = @"Mellvile",
            Date = @"2010-02-22T00:00:00",
            Value = 65.64,
            NumberOfUnits = 365
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 2.68,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Sofia",
            Date = @"2010-03-01T00:00:00",
            Value = 68.63,
            NumberOfUnits = 202
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 52.26,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Seattle",
            Date = @"2010-03-01T00:00:00",
            Value = 79.25,
            NumberOfUnits = 225
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 0.31,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Mellvile",
            Date = @"2010-03-03T00:00:00",
            Value = 70.07,
            NumberOfUnits = 206
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 22.36,
            SellerName = @"Larry Lieb",
            SellerCity = @"Sofia",
            Date = @"2010-03-11T00:00:00",
            Value = 54.67,
            NumberOfUnits = 158
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 94.75,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"London",
            Date = @"2010-03-14T00:00:00",
            Value = 70.42,
            NumberOfUnits = 169
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 1.12,
            SellerName = @"John Smith",
            SellerCity = @"New York",
            Date = @"2010-03-15T00:00:00",
            Value = 18.87,
            NumberOfUnits = 4
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 12.17,
            SellerName = @"Monica Freitag",
            SellerCity = @"New York",
            Date = @"2010-03-15T00:00:00",
            Value = 12.66,
            NumberOfUnits = 232
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 58.75,
            SellerName = @"Mark Slater",
            SellerCity = @"Berlin",
            Date = @"2010-03-16T00:00:00",
            Value = 78.75,
            NumberOfUnits = 421
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 43.95,
            SellerName = @"David Haley",
            SellerCity = @"Seattle",
            Date = @"2010-03-25T00:00:00",
            Value = 89.64,
            NumberOfUnits = 260
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 54.45,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Seattle",
            Date = @"2010-04-02T00:00:00",
            Value = 91.93,
            NumberOfUnits = 194
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 94.57,
            SellerName = @"Walter Pang",
            SellerCity = @"Tokyo",
            Date = @"2010-04-05T00:00:00",
            Value = 35.42,
            NumberOfUnits = 491
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 11.12,
            SellerName = @"Harold Garvin",
            SellerCity = @"London",
            Date = @"2010-04-14T00:00:00",
            Value = 29.99,
            NumberOfUnits = 256
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 18.09,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Mellvile",
            Date = @"2010-04-15T00:00:00",
            Value = 84.46,
            NumberOfUnits = 279
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 8.28,
            SellerName = @"Carl Costello",
            SellerCity = @"Berlin",
            Date = @"2010-04-15T00:00:00",
            Value = 99.57,
            NumberOfUnits = 287
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 77.89,
            SellerName = @"Carl Costello",
            SellerCity = @"New York",
            Date = @"2010-04-22T00:00:00",
            Value = 58.91,
            NumberOfUnits = 363
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 55.62,
            SellerName = @"Mark Slater",
            SellerCity = @"Berlin",
            Date = @"2010-04-22T00:00:00",
            Value = 16.32,
            NumberOfUnits = 499
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 39.34,
            SellerName = @"Lydia Burson",
            SellerCity = @"Berlin",
            Date = @"2010-04-24T00:00:00",
            Value = 0.09,
            NumberOfUnits = 109
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 7.74,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Berlin",
            Date = @"2010-05-04T00:00:00",
            Value = 99.53,
            NumberOfUnits = 25
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 62.44,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Mellvile",
            Date = @"2010-05-05T00:00:00",
            Value = 47.95,
            NumberOfUnits = 64
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 38.7,
            SellerName = @"Howard Sprouse",
            SellerCity = @"London",
            Date = @"2010-05-06T00:00:00",
            Value = 57.67,
            NumberOfUnits = 256
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 17.76,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Mellvile",
            Date = @"2010-05-07T00:00:00",
            Value = 15.27,
            NumberOfUnits = 50
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 57.77,
            SellerName = @"Bryan Culver",
            SellerCity = @"Berlin",
            Date = @"2010-05-07T00:00:00",
            Value = 58.62,
            NumberOfUnits = 437
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 21.41,
            SellerName = @"Bryan Culver",
            SellerCity = @"Sofia",
            Date = @"2010-05-19T00:00:00",
            Value = 40.95,
            NumberOfUnits = 253
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 10.1,
            SellerName = @"Monica Freitag",
            SellerCity = @"London",
            Date = @"2010-05-22T00:00:00",
            Value = 24.04,
            NumberOfUnits = 312
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 87.65,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"London",
            Date = @"2010-05-24T00:00:00",
            Value = 12.45,
            NumberOfUnits = 82
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 42.55,
            SellerName = @"Harold Garvin",
            SellerCity = @"New York",
            Date = @"2010-06-01T00:00:00",
            Value = 32.22,
            NumberOfUnits = 467
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 79.77,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Sofia",
            Date = @"2010-06-05T00:00:00",
            Value = 69.48,
            NumberOfUnits = 74
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 1.84,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2010-06-10T00:00:00",
            Value = 14.71,
            NumberOfUnits = 81
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 15.04,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Berlin",
            Date = @"2010-06-25T00:00:00",
            Value = 18.71,
            NumberOfUnits = 88
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 43.39,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Mellvile",
            Date = @"2010-06-26T00:00:00",
            Value = 44.32,
            NumberOfUnits = 126
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 16.24,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Sofia",
            Date = @"2010-06-27T00:00:00",
            Value = 77.72,
            NumberOfUnits = 112
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 59.19,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Sofia",
            Date = @"2010-06-27T00:00:00",
            Value = 15.44,
            NumberOfUnits = 47
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 39.86,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Sofia",
            Date = @"2010-07-05T00:00:00",
            Value = 29.31,
            NumberOfUnits = 218
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 27.04,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"New York",
            Date = @"2010-07-05T00:00:00",
            Value = 29.85,
            NumberOfUnits = 34
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 14.27,
            SellerName = @"Bryan Culver",
            SellerCity = @"Sofia",
            Date = @"2010-07-13T00:00:00",
            Value = 83.42,
            NumberOfUnits = 492
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 53.38,
            SellerName = @"Harry Tyler",
            SellerCity = @"Sofia",
            Date = @"2010-07-16T00:00:00",
            Value = 41.54,
            NumberOfUnits = 464
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 21.43,
            SellerName = @"Harry Tyler",
            SellerCity = @"Seattle",
            Date = @"2010-07-17T00:00:00",
            Value = 83.29,
            NumberOfUnits = 118
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 23.97,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2010-07-18T00:00:00",
            Value = 94.15,
            NumberOfUnits = 442
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 37.52,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"London",
            Date = @"2010-07-23T00:00:00",
            Value = 59.59,
            NumberOfUnits = 248
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 60.68,
            SellerName = @"Lydia Burson",
            SellerCity = @"London",
            Date = @"2010-07-23T00:00:00",
            Value = 83.5,
            NumberOfUnits = 472
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 78.02,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"New York",
            Date = @"2010-07-24T00:00:00",
            Value = 83.87,
            NumberOfUnits = 140
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 47.64,
            SellerName = @"Lydia Burson",
            SellerCity = @"Tokyo",
            Date = @"2010-07-26T00:00:00",
            Value = 86.61,
            NumberOfUnits = 118
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 58.2,
            SellerName = @"Harry Tyler",
            SellerCity = @"Sofia",
            Date = @"2010-07-27T00:00:00",
            Value = 63.96,
            NumberOfUnits = 176
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 98.38,
            SellerName = @"Russell Shorter",
            SellerCity = @"Mellvile",
            Date = @"2010-08-01T00:00:00",
            Value = 23.28,
            NumberOfUnits = 77
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 2.92,
            SellerName = @"Glenn Landeros",
            SellerCity = @"Sofia",
            Date = @"2010-08-08T00:00:00",
            Value = 74.27,
            NumberOfUnits = 105
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 98.16,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Tokyo",
            Date = @"2010-08-21T00:00:00",
            Value = 60.65,
            NumberOfUnits = 160
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 79.04,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Seattle",
            Date = @"2010-08-26T00:00:00",
            Value = 66.92,
            NumberOfUnits = 186
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 17.79,
            SellerName = @"Harold Garvin",
            SellerCity = @"Seattle",
            Date = @"2010-09-04T00:00:00",
            Value = 28.99,
            NumberOfUnits = 380
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 38.68,
            SellerName = @"John Smith",
            SellerCity = @"Tokyo",
            Date = @"2010-09-11T00:00:00",
            Value = 41.46,
            NumberOfUnits = 470
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 75.23,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Mellvile",
            Date = @"2010-09-13T00:00:00",
            Value = 42.69,
            NumberOfUnits = 348
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 55.3,
            SellerName = @"Carl Costello",
            SellerCity = @"London",
            Date = @"2010-09-14T00:00:00",
            Value = 29.38,
            NumberOfUnits = 151
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 51.32,
            SellerName = @"Kathe Pettel",
            SellerCity = @"New York",
            Date = @"2010-09-24T00:00:00",
            Value = 86.58,
            NumberOfUnits = 7
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 31.31,
            SellerName = @"Monica Freitag",
            SellerCity = @"New York",
            Date = @"2010-10-07T00:00:00",
            Value = 38.94,
            NumberOfUnits = 123
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 79.96,
            SellerName = @"Mark Slater",
            SellerCity = @"Seattle",
            Date = @"2010-10-08T00:00:00",
            Value = 8.68,
            NumberOfUnits = 374
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 94.66,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Mellvile",
            Date = @"2010-10-11T00:00:00",
            Value = 96.67,
            NumberOfUnits = 178
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 41.97,
            SellerName = @"Bryan Culver",
            SellerCity = @"Sofia",
            Date = @"2010-10-22T00:00:00",
            Value = 31.41,
            NumberOfUnits = 354
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 46.56,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"New York",
            Date = @"2010-10-25T00:00:00",
            Value = 85.54,
            NumberOfUnits = 459
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 27.14,
            SellerName = @"Mark Slater",
            SellerCity = @"London",
            Date = @"2010-11-02T00:00:00",
            Value = 46.42,
            NumberOfUnits = 78
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 30.23,
            SellerName = @"Walter Pang",
            SellerCity = @"Berlin",
            Date = @"2010-11-03T00:00:00",
            Value = 52.08,
            NumberOfUnits = 417
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 82.17,
            SellerName = @"Walter Pang",
            SellerCity = @"Seattle",
            Date = @"2010-11-12T00:00:00",
            Value = 15.4,
            NumberOfUnits = 208
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 13.24,
            SellerName = @"Harold Garvin",
            SellerCity = @"Seattle",
            Date = @"2010-11-19T00:00:00",
            Value = 48.61,
            NumberOfUnits = 359
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 8.83,
            SellerName = @"Russell Shorter",
            SellerCity = @"New York",
            Date = @"2010-11-25T00:00:00",
            Value = 24.49,
            NumberOfUnits = 392
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 78.43,
            SellerName = @"John Smith",
            SellerCity = @"London",
            Date = @"2011-01-01T00:00:00",
            Value = 37.6,
            NumberOfUnits = 241
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 50.59,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Seattle",
            Date = @"2011-01-04T00:00:00",
            Value = 27.19,
            NumberOfUnits = 62
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 6.31,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Tokyo",
            Date = @"2011-01-06T00:00:00",
            Value = 89.62,
            NumberOfUnits = 485
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 47.44,
            SellerName = @"Bryan Culver",
            SellerCity = @"Sofia",
            Date = @"2011-01-14T00:00:00",
            Value = 4.89,
            NumberOfUnits = 470
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 6.15,
            SellerName = @"Harry Tyler",
            SellerCity = @"Seattle",
            Date = @"2011-01-23T00:00:00",
            Value = 78.52,
            NumberOfUnits = 197
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 57.6,
            SellerName = @"Larry Lieb",
            SellerCity = @"Berlin",
            Date = @"2011-01-26T00:00:00",
            Value = 59.75,
            NumberOfUnits = 353
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 37.62,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Mellvile",
            Date = @"2011-02-01T00:00:00",
            Value = 39.59,
            NumberOfUnits = 338
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 21,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"New York",
            Date = @"2011-02-08T00:00:00",
            Value = 92.87,
            NumberOfUnits = 17
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 11.78,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Berlin",
            Date = @"2011-02-12T00:00:00",
            Value = 61.29,
            NumberOfUnits = 429
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 65,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Tokyo",
            Date = @"2011-02-14T00:00:00",
            Value = 24.29,
            NumberOfUnits = 385
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 19.9,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"New York",
            Date = @"2011-02-20T00:00:00",
            Value = 35.27,
            NumberOfUnits = 166
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 3.24,
            SellerName = @"Lydia Burson",
            SellerCity = @"Seattle",
            Date = @"2011-02-20T00:00:00",
            Value = 52.57,
            NumberOfUnits = 137
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 18.18,
            SellerName = @"Russell Shorter",
            SellerCity = @"New York",
            Date = @"2011-02-24T00:00:00",
            Value = 8.24,
            NumberOfUnits = 443
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 20.44,
            SellerName = @"Carl Costello",
            SellerCity = @"Seattle",
            Date = @"2011-02-26T00:00:00",
            Value = 87.33,
            NumberOfUnits = 40
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 20.55,
            SellerName = @"Glenn Landeros",
            SellerCity = @"London",
            Date = @"2011-03-05T00:00:00",
            Value = 7.28,
            NumberOfUnits = 138
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 23.77,
            SellerName = @"Lydia Burson",
            SellerCity = @"Tokyo",
            Date = @"2011-03-09T00:00:00",
            Value = 18.24,
            NumberOfUnits = 15
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 76.25,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Mellvile",
            Date = @"2011-03-09T00:00:00",
            Value = 74.5,
            NumberOfUnits = 469
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 93.25,
            SellerName = @"Russell Shorter",
            SellerCity = @"London",
            Date = @"2011-03-11T00:00:00",
            Value = 89,
            NumberOfUnits = 426
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 62.99,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Seattle",
            Date = @"2011-03-16T00:00:00",
            Value = 32.47,
            NumberOfUnits = 208
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 58.5,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Seattle",
            Date = @"2011-03-21T00:00:00",
            Value = 50.85,
            NumberOfUnits = 155
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 82.38,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Seattle",
            Date = @"2011-03-23T00:00:00",
            Value = 33.37,
            NumberOfUnits = 381
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 19.17,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Tokyo",
            Date = @"2011-04-12T00:00:00",
            Value = 75.17,
            NumberOfUnits = 5
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 53.52,
            SellerName = @"Walter Pang",
            SellerCity = @"London",
            Date = @"2011-04-12T00:00:00",
            Value = 14.53,
            NumberOfUnits = 221
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 97.41,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Sofia",
            Date = @"2011-04-14T00:00:00",
            Value = 84.69,
            NumberOfUnits = 39
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 74.05,
            SellerName = @"Mark Slater",
            SellerCity = @"New York",
            Date = @"2011-04-16T00:00:00",
            Value = 51.3,
            NumberOfUnits = 468
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 8.1,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Seattle",
            Date = @"2011-04-17T00:00:00",
            Value = 0.7,
            NumberOfUnits = 44
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 59.06,
            SellerName = @"John Smith",
            SellerCity = @"Mellvile",
            Date = @"2011-04-22T00:00:00",
            Value = 47.53,
            NumberOfUnits = 287
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 96.82,
            SellerName = @"Russell Shorter",
            SellerCity = @"Sofia",
            Date = @"2011-04-24T00:00:00",
            Value = 78.55,
            NumberOfUnits = 463
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 76.71,
            SellerName = @"Walter Pang",
            SellerCity = @"Seattle",
            Date = @"2011-04-24T00:00:00",
            Value = 62.92,
            NumberOfUnits = 335
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 73.42,
            SellerName = @"Walter Pang",
            SellerCity = @"Berlin",
            Date = @"2011-04-24T00:00:00",
            Value = 30.57,
            NumberOfUnits = 211
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 66.4,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Seattle",
            Date = @"2011-05-03T00:00:00",
            Value = 87.37,
            NumberOfUnits = 291
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 37.01,
            SellerName = @"John Smith",
            SellerCity = @"Sofia",
            Date = @"2011-05-05T00:00:00",
            Value = 40.14,
            NumberOfUnits = 1
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 21.31,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Seattle",
            Date = @"2011-05-06T00:00:00",
            Value = 46.01,
            NumberOfUnits = 120
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 19.89,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Berlin",
            Date = @"2011-05-06T00:00:00",
            Value = 72.61,
            NumberOfUnits = 382
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 16.49,
            SellerName = @"Harry Tyler",
            SellerCity = @"Seattle",
            Date = @"2011-05-07T00:00:00",
            Value = 7.76,
            NumberOfUnits = 63
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 41.66,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Seattle",
            Date = @"2011-05-12T00:00:00",
            Value = 94.32,
            NumberOfUnits = 230
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 4.98,
            SellerName = @"Larry Lieb",
            SellerCity = @"Tokyo",
            Date = @"2011-05-13T00:00:00",
            Value = 30.89,
            NumberOfUnits = 362
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 10.75,
            SellerName = @"Monica Freitag",
            SellerCity = @"New York",
            Date = @"2011-05-17T00:00:00",
            Value = 59.67,
            NumberOfUnits = 430
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 66.05,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2011-05-23T00:00:00",
            Value = 91.14,
            NumberOfUnits = 204
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 60.85,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Berlin",
            Date = @"2011-05-24T00:00:00",
            Value = 86.1,
            NumberOfUnits = 118
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 68.71,
            SellerName = @"Walter Pang",
            SellerCity = @"Sofia",
            Date = @"2011-06-01T00:00:00",
            Value = 14.56,
            NumberOfUnits = 17
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 40.68,
            SellerName = @"Walter Pang",
            SellerCity = @"New York",
            Date = @"2011-06-03T00:00:00",
            Value = 9.04,
            NumberOfUnits = 312
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 96.9,
            SellerName = @"Lydia Burson",
            SellerCity = @"Seattle",
            Date = @"2011-06-12T00:00:00",
            Value = 95.04,
            NumberOfUnits = 283
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 67.03,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Seattle",
            Date = @"2011-06-13T00:00:00",
            Value = 27.59,
            NumberOfUnits = 460
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 67.09,
            SellerName = @"Howard Sprouse",
            SellerCity = @"New York",
            Date = @"2011-06-14T00:00:00",
            Value = 66.23,
            NumberOfUnits = 295
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 28.05,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Mellvile",
            Date = @"2011-06-15T00:00:00",
            Value = 50.5,
            NumberOfUnits = 49
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 7.38,
            SellerName = @"Russell Shorter",
            SellerCity = @"Tokyo",
            Date = @"2011-06-24T00:00:00",
            Value = 7.87,
            NumberOfUnits = 127
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 39.22,
            SellerName = @"Mark Slater",
            SellerCity = @"Seattle",
            Date = @"2011-06-27T00:00:00",
            Value = 98.71,
            NumberOfUnits = 244
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 53.42,
            SellerName = @"Harold Garvin",
            SellerCity = @"Tokyo",
            Date = @"2011-07-01T00:00:00",
            Value = 11.23,
            NumberOfUnits = 188
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 25.52,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Seattle",
            Date = @"2011-07-06T00:00:00",
            Value = 56.13,
            NumberOfUnits = 458
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 70.26,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Mellvile",
            Date = @"2011-07-08T00:00:00",
            Value = 82.34,
            NumberOfUnits = 448
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 7.64,
            SellerName = @"Harold Garvin",
            SellerCity = @"Berlin",
            Date = @"2011-07-27T00:00:00",
            Value = 30.46,
            NumberOfUnits = 226
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 21.51,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2011-08-01T00:00:00",
            Value = 69.62,
            NumberOfUnits = 474
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 37.6,
            SellerName = @"David Haley",
            SellerCity = @"Sofia",
            Date = @"2011-08-02T00:00:00",
            Value = 62.77,
            NumberOfUnits = 338
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 99.36,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"London",
            Date = @"2011-08-02T00:00:00",
            Value = 75.24,
            NumberOfUnits = 88
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 72.23,
            SellerName = @"Carl Costello",
            SellerCity = @"Berlin",
            Date = @"2011-08-04T00:00:00",
            Value = 86.28,
            NumberOfUnits = 436
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 34.25,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Mellvile",
            Date = @"2011-08-06T00:00:00",
            Value = 9.22,
            NumberOfUnits = 297
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 46.89,
            SellerName = @"Russell Shorter",
            SellerCity = @"London",
            Date = @"2011-08-07T00:00:00",
            Value = 5.09,
            NumberOfUnits = 240
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 26.37,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Sofia",
            Date = @"2011-08-07T00:00:00",
            Value = 80.24,
            NumberOfUnits = 415
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 49.07,
            SellerName = @"David Haley",
            SellerCity = @"Mellvile",
            Date = @"2011-08-08T00:00:00",
            Value = 61.2,
            NumberOfUnits = 435
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 95.06,
            SellerName = @"Monica Freitag",
            SellerCity = @"Berlin",
            Date = @"2011-08-16T00:00:00",
            Value = 73.75,
            NumberOfUnits = 64
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 74.18,
            SellerName = @"John Smith",
            SellerCity = @"Seattle",
            Date = @"2011-08-23T00:00:00",
            Value = 40.74,
            NumberOfUnits = 21
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 82.51,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2011-08-25T00:00:00",
            Value = 54.91,
            NumberOfUnits = 467
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 42.77,
            SellerName = @"Lydia Burson",
            SellerCity = @"Sofia",
            Date = @"2011-09-02T00:00:00",
            Value = 28.23,
            NumberOfUnits = 98
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 83.47,
            SellerName = @"Russell Shorter",
            SellerCity = @"Mellvile",
            Date = @"2011-09-04T00:00:00",
            Value = 72.48,
            NumberOfUnits = 370
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 41.55,
            SellerName = @"Walter Pang",
            SellerCity = @"Berlin",
            Date = @"2011-09-05T00:00:00",
            Value = 80.99,
            NumberOfUnits = 94
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 74.12,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2011-09-09T00:00:00",
            Value = 94.85,
            NumberOfUnits = 106
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 75.4,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Sofia",
            Date = @"2011-09-11T00:00:00",
            Value = 9.89,
            NumberOfUnits = 261
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 10.23,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Seattle",
            Date = @"2011-09-17T00:00:00",
            Value = 29.39,
            NumberOfUnits = 307
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 72.93,
            SellerName = @"Harry Tyler",
            SellerCity = @"New York",
            Date = @"2011-09-17T00:00:00",
            Value = 56.9,
            NumberOfUnits = 362
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 85.13,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Tokyo",
            Date = @"2011-09-24T00:00:00",
            Value = 23.86,
            NumberOfUnits = 330
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 77.6,
            SellerName = @"Walter Pang",
            SellerCity = @"New York",
            Date = @"2011-09-26T00:00:00",
            Value = 91.82,
            NumberOfUnits = 23
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 50.36,
            SellerName = @"David Haley",
            SellerCity = @"Berlin",
            Date = @"2011-09-27T00:00:00",
            Value = 66.77,
            NumberOfUnits = 392
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 32.29,
            SellerName = @"Larry Lieb",
            SellerCity = @"Seattle",
            Date = @"2011-10-13T00:00:00",
            Value = 81.51,
            NumberOfUnits = 16
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 62.99,
            SellerName = @"Lydia Burson",
            SellerCity = @"New York",
            Date = @"2011-10-13T00:00:00",
            Value = 30.91,
            NumberOfUnits = 100
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 13.44,
            SellerName = @"Carl Costello",
            SellerCity = @"Berlin",
            Date = @"2011-10-22T00:00:00",
            Value = 85.47,
            NumberOfUnits = 132
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 0.36,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2011-10-22T00:00:00",
            Value = 74.4,
            NumberOfUnits = 22
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 66.24,
            SellerName = @"Walter Pang",
            SellerCity = @"New York",
            Date = @"2011-11-02T00:00:00",
            Value = 88.14,
            NumberOfUnits = 96
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 50.15,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Berlin",
            Date = @"2011-11-03T00:00:00",
            Value = 31.43,
            NumberOfUnits = 76
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 67.88,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Mellvile",
            Date = @"2011-11-04T00:00:00",
            Value = 91.07,
            NumberOfUnits = 492
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 6.55,
            SellerName = @"Harry Tyler",
            SellerCity = @"Berlin",
            Date = @"2011-11-08T00:00:00",
            Value = 51.46,
            NumberOfUnits = 49
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 35.55,
            SellerName = @"Russell Shorter",
            SellerCity = @"Mellvile",
            Date = @"2011-11-12T00:00:00",
            Value = 20.85,
            NumberOfUnits = 197
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 59.93,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Tokyo",
            Date = @"2011-11-12T00:00:00",
            Value = 70.32,
            NumberOfUnits = 484
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 67.36,
            SellerName = @"Russell Shorter",
            SellerCity = @"Tokyo",
            Date = @"2011-11-13T00:00:00",
            Value = 14.27,
            NumberOfUnits = 182
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 51.98,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"London",
            Date = @"2011-11-15T00:00:00",
            Value = 18.37,
            NumberOfUnits = 42
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 66.67,
            SellerName = @"Brandon Mckim",
            SellerCity = @"New York",
            Date = @"2011-11-19T00:00:00",
            Value = 52.76,
            NumberOfUnits = 109
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 56.14,
            SellerName = @"Harold Garvin",
            SellerCity = @"Mellvile",
            Date = @"2011-11-23T00:00:00",
            Value = 40.17,
            NumberOfUnits = 310
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 93.53,
            SellerName = @"Monica Freitag",
            SellerCity = @"Sofia",
            Date = @"2012-01-03T00:00:00",
            Value = 53.31,
            NumberOfUnits = 306
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 9.53,
            SellerName = @"Harold Garvin",
            SellerCity = @"Seattle",
            Date = @"2012-01-06T00:00:00",
            Value = 82.95,
            NumberOfUnits = 290
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 41.12,
            SellerName = @"Monica Freitag",
            SellerCity = @"Tokyo",
            Date = @"2012-01-10T00:00:00",
            Value = 29.77,
            NumberOfUnits = 499
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 9.8,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Berlin",
            Date = @"2012-01-11T00:00:00",
            Value = 10.74,
            NumberOfUnits = 7
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 64.58,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Sofia",
            Date = @"2012-01-14T00:00:00",
            Value = 34.95,
            NumberOfUnits = 220
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 47.28,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"New York",
            Date = @"2012-01-15T00:00:00",
            Value = 50.19,
            NumberOfUnits = 395
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 14.61,
            SellerName = @"Lydia Burson",
            SellerCity = @"Sofia",
            Date = @"2012-01-18T00:00:00",
            Value = 100,
            NumberOfUnits = 219
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 10.68,
            SellerName = @"Larry Lieb",
            SellerCity = @"Mellvile",
            Date = @"2012-01-18T00:00:00",
            Value = 91.93,
            NumberOfUnits = 229
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 64.91,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Mellvile",
            Date = @"2012-01-22T00:00:00",
            Value = 55.81,
            NumberOfUnits = 111
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 47.91,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"London",
            Date = @"2012-02-01T00:00:00",
            Value = 20.47,
            NumberOfUnits = 237
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 87.82,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Berlin",
            Date = @"2012-02-13T00:00:00",
            Value = 17.17,
            NumberOfUnits = 114
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 55.4,
            SellerName = @"Bryan Culver",
            SellerCity = @"London",
            Date = @"2012-02-23T00:00:00",
            Value = 76.74,
            NumberOfUnits = 329
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 40.76,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Seattle",
            Date = @"2012-02-24T00:00:00",
            Value = 1.17,
            NumberOfUnits = 135
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 57.83,
            SellerName = @"Harold Garvin",
            SellerCity = @"New York",
            Date = @"2012-03-02T00:00:00",
            Value = 46.82,
            NumberOfUnits = 187
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 14.76,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2012-03-10T00:00:00",
            Value = 17.63,
            NumberOfUnits = 286
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 12.99,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Mellvile",
            Date = @"2012-03-11T00:00:00",
            Value = 18.21,
            NumberOfUnits = 468
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 26.01,
            SellerName = @"Monica Freitag",
            SellerCity = @"Tokyo",
            Date = @"2012-03-18T00:00:00",
            Value = 93.23,
            NumberOfUnits = 71
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 72.62,
            SellerName = @"Bryan Culver",
            SellerCity = @"Mellvile",
            Date = @"2012-03-21T00:00:00",
            Value = 61.97,
            NumberOfUnits = 251
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 44.43,
            SellerName = @"Monica Freitag",
            SellerCity = @"Berlin",
            Date = @"2012-03-25T00:00:00",
            Value = 57.14,
            NumberOfUnits = 297
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 68.19,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Berlin",
            Date = @"2012-03-25T00:00:00",
            Value = 4.19,
            NumberOfUnits = 248
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 35.3,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Sofia",
            Date = @"2012-03-26T00:00:00",
            Value = 45.23,
            NumberOfUnits = 488
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 41.08,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Sofia",
            Date = @"2012-04-06T00:00:00",
            Value = 59.48,
            NumberOfUnits = 211
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 29.29,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Seattle",
            Date = @"2012-04-14T00:00:00",
            Value = 3.12,
            NumberOfUnits = 149
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 51.96,
            SellerName = @"Lydia Burson",
            SellerCity = @"Berlin",
            Date = @"2012-04-14T00:00:00",
            Value = 9.81,
            NumberOfUnits = 99
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 57.84,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Seattle",
            Date = @"2012-04-16T00:00:00",
            Value = 14.04,
            NumberOfUnits = 225
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 25.88,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2012-04-27T00:00:00",
            Value = 95.39,
            NumberOfUnits = 408
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 4.93,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Sofia",
            Date = @"2012-05-09T00:00:00",
            Value = 40.24,
            NumberOfUnits = 417
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 3.04,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"London",
            Date = @"2012-05-24T00:00:00",
            Value = 67.74,
            NumberOfUnits = 221
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 57.53,
            SellerName = @"Mark Slater",
            SellerCity = @"New York",
            Date = @"2012-06-02T00:00:00",
            Value = 45.35,
            NumberOfUnits = 288
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 72.26,
            SellerName = @"Bryan Culver",
            SellerCity = @"Berlin",
            Date = @"2012-06-03T00:00:00",
            Value = 92.77,
            NumberOfUnits = 372
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 82.53,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Seattle",
            Date = @"2012-06-03T00:00:00",
            Value = 51.33,
            NumberOfUnits = 408
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 91.6,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Mellvile",
            Date = @"2012-06-04T00:00:00",
            Value = 28.53,
            NumberOfUnits = 13
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 94.67,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Mellvile",
            Date = @"2012-06-05T00:00:00",
            Value = 31.55,
            NumberOfUnits = 487
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 46.27,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Sofia",
            Date = @"2012-06-11T00:00:00",
            Value = 85.91,
            NumberOfUnits = 276
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 18.24,
            SellerName = @"Howard Sprouse",
            SellerCity = @"New York",
            Date = @"2012-06-16T00:00:00",
            Value = 40.24,
            NumberOfUnits = 490
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 48.75,
            SellerName = @"Harold Garvin",
            SellerCity = @"London",
            Date = @"2012-06-18T00:00:00",
            Value = 55.62,
            NumberOfUnits = 238
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 94.43,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2012-06-23T00:00:00",
            Value = 91.98,
            NumberOfUnits = 170
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 48.68,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Mellvile",
            Date = @"2012-07-04T00:00:00",
            Value = 72.77,
            NumberOfUnits = 132
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 82.68,
            SellerName = @"Mark Slater",
            SellerCity = @"Mellvile",
            Date = @"2012-07-05T00:00:00",
            Value = 56.77,
            NumberOfUnits = 443
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 38.19,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"New York",
            Date = @"2012-07-05T00:00:00",
            Value = 27.48,
            NumberOfUnits = 368
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 24.19,
            SellerName = @"Harold Garvin",
            SellerCity = @"New York",
            Date = @"2012-07-11T00:00:00",
            Value = 38.52,
            NumberOfUnits = 39
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 3.99,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Tokyo",
            Date = @"2012-07-13T00:00:00",
            Value = 43.24,
            NumberOfUnits = 95
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 81.77,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Berlin",
            Date = @"2012-07-14T00:00:00",
            Value = 42.56,
            NumberOfUnits = 42
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 74.87,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Seattle",
            Date = @"2012-07-16T00:00:00",
            Value = 61.43,
            NumberOfUnits = 200
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 85.47,
            SellerName = @"Monica Freitag",
            SellerCity = @"Seattle",
            Date = @"2012-07-16T00:00:00",
            Value = 10.46,
            NumberOfUnits = 221
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 96.42,
            SellerName = @"Larry Lieb",
            SellerCity = @"New York",
            Date = @"2012-07-21T00:00:00",
            Value = 99.64,
            NumberOfUnits = 54
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 46.2,
            SellerName = @"Lydia Burson",
            SellerCity = @"Tokyo",
            Date = @"2012-07-21T00:00:00",
            Value = 55.96,
            NumberOfUnits = 173
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 99.84,
            SellerName = @"Lydia Burson",
            SellerCity = @"London",
            Date = @"2012-07-23T00:00:00",
            Value = 10.83,
            NumberOfUnits = 47
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 42.35,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Mellvile",
            Date = @"2012-07-26T00:00:00",
            Value = 91.55,
            NumberOfUnits = 173
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 52.2,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Mellvile",
            Date = @"2012-08-05T00:00:00",
            Value = 98.82,
            NumberOfUnits = 323
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 45.46,
            SellerName = @"Russell Shorter",
            SellerCity = @"Sofia",
            Date = @"2012-08-07T00:00:00",
            Value = 26.03,
            NumberOfUnits = 264
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 56.77,
            SellerName = @"Mark Slater",
            SellerCity = @"Sofia",
            Date = @"2012-08-09T00:00:00",
            Value = 11.49,
            NumberOfUnits = 385
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 3.57,
            SellerName = @"Harry Tyler",
            SellerCity = @"London",
            Date = @"2012-08-10T00:00:00",
            Value = 25.95,
            NumberOfUnits = 56
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 34.6,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Berlin",
            Date = @"2012-08-12T00:00:00",
            Value = 96.15,
            NumberOfUnits = 267
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 92.4,
            SellerName = @"Monica Freitag",
            SellerCity = @"Seattle",
            Date = @"2012-08-14T00:00:00",
            Value = 94.91,
            NumberOfUnits = 109
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 34.72,
            SellerName = @"Mark Slater",
            SellerCity = @"Berlin",
            Date = @"2012-08-17T00:00:00",
            Value = 62.38,
            NumberOfUnits = 478
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 23.34,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Berlin",
            Date = @"2012-08-21T00:00:00",
            Value = 57.66,
            NumberOfUnits = 184
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 79.52,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Seattle",
            Date = @"2012-08-21T00:00:00",
            Value = 35.35,
            NumberOfUnits = 132
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 30.65,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Sofia",
            Date = @"2012-08-22T00:00:00",
            Value = 95.94,
            NumberOfUnits = 142
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 89.89,
            SellerName = @"Carl Costello",
            SellerCity = @"Seattle",
            Date = @"2012-08-27T00:00:00",
            Value = 27.45,
            NumberOfUnits = 46
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 83.19,
            SellerName = @"Walter Pang",
            SellerCity = @"Seattle",
            Date = @"2012-09-03T00:00:00",
            Value = 68.61,
            NumberOfUnits = 102
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 0.1,
            SellerName = @"Russell Shorter",
            SellerCity = @"Berlin",
            Date = @"2012-09-09T00:00:00",
            Value = 96.59,
            NumberOfUnits = 21
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 36.63,
            SellerName = @"Monica Freitag",
            SellerCity = @"Sofia",
            Date = @"2012-09-10T00:00:00",
            Value = 4.93,
            NumberOfUnits = 442
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 92.31,
            SellerName = @"Harry Tyler",
            SellerCity = @"New York",
            Date = @"2012-09-13T00:00:00",
            Value = 99.22,
            NumberOfUnits = 254
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 28.01,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Sofia",
            Date = @"2012-09-13T00:00:00",
            Value = 49.91,
            NumberOfUnits = 251
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 60.3,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"New York",
            Date = @"2012-09-15T00:00:00",
            Value = 43.93,
            NumberOfUnits = 119
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 33.01,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"New York",
            Date = @"2012-09-19T00:00:00",
            Value = 32.43,
            NumberOfUnits = 256
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 99,
            SellerName = @"John Smith",
            SellerCity = @"New York",
            Date = @"2012-09-23T00:00:00",
            Value = 35.8,
            NumberOfUnits = 456
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 16.17,
            SellerName = @"Kathe Pettel",
            SellerCity = @"London",
            Date = @"2012-10-01T00:00:00",
            Value = 16.36,
            NumberOfUnits = 430
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 72.9,
            SellerName = @"David Haley",
            SellerCity = @"Berlin",
            Date = @"2012-10-02T00:00:00",
            Value = 57.03,
            NumberOfUnits = 248
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 21.66,
            SellerName = @"Harold Garvin",
            SellerCity = @"Berlin",
            Date = @"2012-10-18T00:00:00",
            Value = 28.24,
            NumberOfUnits = 440
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 28.34,
            SellerName = @"Howard Sprouse",
            SellerCity = @"New York",
            Date = @"2012-10-19T00:00:00",
            Value = 66.64,
            NumberOfUnits = 234
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 80.47,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"New York",
            Date = @"2012-10-25T00:00:00",
            Value = 5.26,
            NumberOfUnits = 36
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 97.69,
            SellerName = @"Harry Tyler",
            SellerCity = @"London",
            Date = @"2012-10-26T00:00:00",
            Value = 41.23,
            NumberOfUnits = 46
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 88.7,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"London",
            Date = @"2012-11-02T00:00:00",
            Value = 64.57,
            NumberOfUnits = 211
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 67.26,
            SellerName = @"Walter Pang",
            SellerCity = @"New York",
            Date = @"2012-11-17T00:00:00",
            Value = 14.19,
            NumberOfUnits = 408
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 7.15,
            SellerName = @"Walter Pang",
            SellerCity = @"New York",
            Date = @"2012-11-20T00:00:00",
            Value = 72.78,
            NumberOfUnits = 376
        });
    }
}
