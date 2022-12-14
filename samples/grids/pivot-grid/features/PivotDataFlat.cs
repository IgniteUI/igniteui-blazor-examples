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
            ProductUnitPrice = 12.8148609366337,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Seattle",
            Date = @"2007-01-01T00:00:00",
            Value = 94.2652032683907,
            NumberOfUnits = 282
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 49.5793751206153,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Sofia",
            Date = @"2007-01-05T00:00:00",
            Value = 70.7989226890723,
            NumberOfUnits = 296
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 3.56532735916103,
            SellerName = @"Lydia Burson",
            SellerCity = @"Tokyo",
            Date = @"2007-01-06T00:00:00",
            Value = 35.7993316072036,
            NumberOfUnits = 68
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 85.5817581459795,
            SellerName = @"David Haley",
            SellerCity = @"London",
            Date = @"2007-01-07T00:00:00",
            Value = 41.4113312686846,
            NumberOfUnits = 293
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 18.1376258461446,
            SellerName = @"John Smith",
            SellerCity = @"Seattle",
            Date = @"2007-01-08T00:00:00",
            Value = 60.4743137305949,
            NumberOfUnits = 240
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 68.3309731391869,
            SellerName = @"Larry Lieb",
            SellerCity = @"Tokyo",
            Date = @"2007-01-12T00:00:00",
            Value = 37.9207273190472,
            NumberOfUnits = 456
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 16.0562525112444,
            SellerName = @"Walter Pang",
            SellerCity = @"Sofia",
            Date = @"2007-02-09T00:00:00",
            Value = 89.1950179306767,
            NumberOfUnits = 492
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 35.235206612961,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Tokyo",
            Date = @"2007-02-16T00:00:00",
            Value = 1.86110753652691,
            NumberOfUnits = 78
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 73.2154336633233,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Mellvile",
            Date = @"2007-02-17T00:00:00",
            Value = 4.61114272689966,
            NumberOfUnits = 150
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 73.614934400476,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"London",
            Date = @"2007-02-19T00:00:00",
            Value = 36.1731772013815,
            NumberOfUnits = 262
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 47.0805446836541,
            SellerName = @"Monica Freitag",
            SellerCity = @"Sofia",
            Date = @"2007-02-21T00:00:00",
            Value = 18.6997407668735,
            NumberOfUnits = 125
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 51.2982563820194,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Sofia",
            Date = @"2007-03-04T00:00:00",
            Value = 11.6007069179792,
            NumberOfUnits = 42
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 27.4663443339366,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2007-03-04T00:00:00",
            Value = 41.2524786038569,
            NumberOfUnits = 282
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 22.3741180833309,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Berlin",
            Date = @"2007-03-17T00:00:00",
            Value = 59.8264899849084,
            NumberOfUnits = 305
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 85.2928365046591,
            SellerName = @"Glenn Landeros",
            SellerCity = @"Tokyo",
            Date = @"2007-03-23T00:00:00",
            Value = 31.4309799258741,
            NumberOfUnits = 265
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 80.6755640919672,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Mellvile",
            Date = @"2007-03-25T00:00:00",
            Value = 90.4250774022309,
            NumberOfUnits = 350
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 64.6139196421085,
            SellerName = @"Glenn Landeros",
            SellerCity = @"Mellvile",
            Date = @"2007-03-27T00:00:00",
            Value = 95.3934391473389,
            NumberOfUnits = 82
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 50.0413366360782,
            SellerName = @"Harry Tyler",
            SellerCity = @"New York",
            Date = @"2007-04-02T00:00:00",
            Value = 1.27663300432108,
            NumberOfUnits = 67
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 16.3115661667248,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Mellvile",
            Date = @"2007-04-04T00:00:00",
            Value = 25.3546736321201,
            NumberOfUnits = 370
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 49.8521715634745,
            SellerName = @"Monica Freitag",
            SellerCity = @"Berlin",
            Date = @"2007-04-12T00:00:00",
            Value = 46.315344491189,
            NumberOfUnits = 228
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 44.7616020425975,
            SellerName = @"Bryan Culver",
            SellerCity = @"Tokyo",
            Date = @"2007-04-15T00:00:00",
            Value = 82.1802735245695,
            NumberOfUnits = 272
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 44.3954126184785,
            SellerName = @"Russell Shorter",
            SellerCity = @"Berlin",
            Date = @"2007-04-18T00:00:00",
            Value = 83.9707137010855,
            NumberOfUnits = 227
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 39.28786061671,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Mellvile",
            Date = @"2007-04-18T00:00:00",
            Value = 94.2611607696215,
            NumberOfUnits = 248
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 36.5811833350832,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Tokyo",
            Date = @"2007-04-21T00:00:00",
            Value = 45.7412716214272,
            NumberOfUnits = 414
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 75.8285212217963,
            SellerName = @"Walter Pang",
            SellerCity = @"London",
            Date = @"2007-04-25T00:00:00",
            Value = 97.5931729178844,
            NumberOfUnits = 43
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 57.7570389293866,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Mellvile",
            Date = @"2007-04-26T00:00:00",
            Value = 20.9361090887972,
            NumberOfUnits = 71
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 40.2318761405683,
            SellerName = @"Stanley Brooker",
            SellerCity = @"New York",
            Date = @"2007-05-14T00:00:00",
            Value = 71.8626452944533,
            NumberOfUnits = 321
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 49.5251280020574,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"London",
            Date = @"2007-05-17T00:00:00",
            Value = 49.4513494192862,
            NumberOfUnits = 329
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 56.4608257061154,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2007-05-17T00:00:00",
            Value = 72.7047810203884,
            NumberOfUnits = 88
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 67.1297780085028,
            SellerName = @"Glenn Landeros",
            SellerCity = @"New York",
            Date = @"2007-05-26T00:00:00",
            Value = 56.169638576065,
            NumberOfUnits = 366
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 14.6289204315417,
            SellerName = @"Walter Pang",
            SellerCity = @"Sofia",
            Date = @"2007-06-02T00:00:00",
            Value = 81.322212508564,
            NumberOfUnits = 450
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 89.2609520299644,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Seattle",
            Date = @"2007-06-06T00:00:00",
            Value = 18.9627218148498,
            NumberOfUnits = 475
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 33.7523688719386,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2007-06-11T00:00:00",
            Value = 54.8708499664771,
            NumberOfUnits = 195
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 54.101630511741,
            SellerName = @"Harold Garvin",
            SellerCity = @"Sofia",
            Date = @"2007-06-17T00:00:00",
            Value = 71.6308470217655,
            NumberOfUnits = 458
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 18.4378546282825,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Sofia",
            Date = @"2007-07-04T00:00:00",
            Value = 24.1609720625733,
            NumberOfUnits = 7
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 96.1428182647297,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"New York",
            Date = @"2007-07-08T00:00:00",
            Value = 57.4979080620678,
            NumberOfUnits = 158
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 22.9904094352342,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Tokyo",
            Date = @"2007-07-09T00:00:00",
            Value = 58.795889168417,
            NumberOfUnits = 34
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 52.6640191453807,
            SellerName = @"Larry Lieb",
            SellerCity = @"Seattle",
            Date = @"2007-07-10T00:00:00",
            Value = 32.3964410612343,
            NumberOfUnits = 412
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 62.1277011288925,
            SellerName = @"John Smith",
            SellerCity = @"Sofia",
            Date = @"2007-07-15T00:00:00",
            Value = 84.9240388185363,
            NumberOfUnits = 10
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 10.722568543033,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"New York",
            Date = @"2007-07-16T00:00:00",
            Value = 52.2057482284521,
            NumberOfUnits = 466
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 4.6933130848656,
            SellerName = @"Stanley Brooker",
            SellerCity = @"London",
            Date = @"2007-07-20T00:00:00",
            Value = 34.2249673950602,
            NumberOfUnits = 248
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 43.724528301379,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Mellvile",
            Date = @"2007-07-24T00:00:00",
            Value = 45.4603450118845,
            NumberOfUnits = 307
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 76.440263947677,
            SellerName = @"Glenn Landeros",
            SellerCity = @"London",
            Date = @"2007-07-26T00:00:00",
            Value = 26.06141060873,
            NumberOfUnits = 445
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 34.2782921783059,
            SellerName = @"Bryan Culver",
            SellerCity = @"New York",
            Date = @"2007-08-01T00:00:00",
            Value = 89.2379715522928,
            NumberOfUnits = 480
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 68.5733938909012,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Berlin",
            Date = @"2007-08-02T00:00:00",
            Value = 38.0901299128729,
            NumberOfUnits = 390
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 65.0681990036127,
            SellerName = @"Larry Lieb",
            SellerCity = @"Mellvile",
            Date = @"2007-08-05T00:00:00",
            Value = 23.0472950372134,
            NumberOfUnits = 388
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 44.9384800367702,
            SellerName = @"Russell Shorter",
            SellerCity = @"Seattle",
            Date = @"2007-08-19T00:00:00",
            Value = 23.370492376094,
            NumberOfUnits = 37
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 93.4686846535041,
            SellerName = @"John Smith",
            SellerCity = @"New York",
            Date = @"2007-08-24T00:00:00",
            Value = 17.3075067891309,
            NumberOfUnits = 237
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 94.3650854725228,
            SellerName = @"Harry Tyler",
            SellerCity = @"Seattle",
            Date = @"2007-08-26T00:00:00",
            Value = 54.6210326043056,
            NumberOfUnits = 396
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 72.4087734112557,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2007-08-26T00:00:00",
            Value = 60.920718014669,
            NumberOfUnits = 3
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 80.5917513932063,
            SellerName = @"Russell Shorter",
            SellerCity = @"New York",
            Date = @"2007-09-02T00:00:00",
            Value = 85.134478139288,
            NumberOfUnits = 330
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 65.4044602836503,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2007-09-04T00:00:00",
            Value = 51.2092393595768,
            NumberOfUnits = 143
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 30.6386909124622,
            SellerName = @"Bryan Culver",
            SellerCity = @"Seattle",
            Date = @"2007-09-05T00:00:00",
            Value = 55.2145366348394,
            NumberOfUnits = 318
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 7.61671858263049,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Seattle",
            Date = @"2007-09-06T00:00:00",
            Value = 41.8046680939406,
            NumberOfUnits = 393
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 46.9468880197717,
            SellerName = @"Harold Garvin",
            SellerCity = @"Seattle",
            Date = @"2007-09-10T00:00:00",
            Value = 9.0849790764437,
            NumberOfUnits = 129
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 38.0177154848435,
            SellerName = @"Glenn Landeros",
            SellerCity = @"London",
            Date = @"2007-09-17T00:00:00",
            Value = 25.5785515185346,
            NumberOfUnits = 426
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 2.48126508783608,
            SellerName = @"Harry Tyler",
            SellerCity = @"London",
            Date = @"2007-09-18T00:00:00",
            Value = 36.3322401588467,
            NumberOfUnits = 217
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 77.5893600087563,
            SellerName = @"John Smith",
            SellerCity = @"New York",
            Date = @"2007-09-20T00:00:00",
            Value = 27.8859096709108,
            NumberOfUnits = 152
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 97.1454934203743,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Seattle",
            Date = @"2007-09-25T00:00:00",
            Value = 21.8342507825393,
            NumberOfUnits = 452
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 19.6974413095496,
            SellerName = @"Carl Costello",
            SellerCity = @"Seattle",
            Date = @"2007-10-02T00:00:00",
            Value = 98.2610602389374,
            NumberOfUnits = 499
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 32.7758949868269,
            SellerName = @"Mark Slater",
            SellerCity = @"Seattle",
            Date = @"2007-10-06T00:00:00",
            Value = 79.6241173891463,
            NumberOfUnits = 169
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 21.953632739351,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Berlin",
            Date = @"2007-10-14T00:00:00",
            Value = 69.4971831839053,
            NumberOfUnits = 386
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 35.5918120292909,
            SellerName = @"Russell Shorter",
            SellerCity = @"Sofia",
            Date = @"2007-10-14T00:00:00",
            Value = 27.7759674134552,
            NumberOfUnits = 454
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 46.9500885098009,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"New York",
            Date = @"2007-10-25T00:00:00",
            Value = 82.1365597574676,
            NumberOfUnits = 334
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 41.1349774064193,
            SellerName = @"Lydia Burson",
            SellerCity = @"Tokyo",
            Date = @"2007-10-26T00:00:00",
            Value = 54.425787531969,
            NumberOfUnits = 107
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 13.8370974053801,
            SellerName = @"Mark Slater",
            SellerCity = @"Sofia",
            Date = @"2007-11-07T00:00:00",
            Value = 86.2122938904037,
            NumberOfUnits = 275
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 64.1599938106537,
            SellerName = @"Monica Freitag",
            SellerCity = @"London",
            Date = @"2007-11-09T00:00:00",
            Value = 37.7203420911545,
            NumberOfUnits = 241
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 1.2072517076541,
            SellerName = @"Larry Lieb",
            SellerCity = @"London",
            Date = @"2007-11-11T00:00:00",
            Value = 75.2273520339408,
            NumberOfUnits = 177
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 57.8050364078046,
            SellerName = @"Monica Freitag",
            SellerCity = @"Sofia",
            Date = @"2007-11-13T00:00:00",
            Value = 58.4452354155692,
            NumberOfUnits = 494
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 39.4922345594932,
            SellerName = @"Lydia Burson",
            SellerCity = @"Mellvile",
            Date = @"2007-11-19T00:00:00",
            Value = 40.7105433944196,
            NumberOfUnits = 451
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 5.21720713247415,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Tokyo",
            Date = @"2008-01-01T00:00:00",
            Value = 91.8200022502895,
            NumberOfUnits = 125
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 53.4294414117138,
            SellerName = @"Kathe Pettel",
            SellerCity = @"London",
            Date = @"2008-01-02T00:00:00",
            Value = 30.892902720204,
            NumberOfUnits = 103
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 52.1573519577074,
            SellerName = @"Larry Lieb",
            SellerCity = @"New York",
            Date = @"2008-01-03T00:00:00",
            Value = 42.9646973698236,
            NumberOfUnits = 224
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 17.6945806563341,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Mellvile",
            Date = @"2008-01-07T00:00:00",
            Value = 47.5734782626729,
            NumberOfUnits = 498
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 80.7411119252169,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2008-01-08T00:00:00",
            Value = 15.6132638061481,
            NumberOfUnits = 142
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 95.439666973166,
            SellerName = @"Larry Lieb",
            SellerCity = @"Berlin",
            Date = @"2008-01-21T00:00:00",
            Value = 87.2099365513818,
            NumberOfUnits = 487
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 21.7789674279182,
            SellerName = @"David Haley",
            SellerCity = @"Mellvile",
            Date = @"2008-01-27T00:00:00",
            Value = 14.4481097415314,
            NumberOfUnits = 331
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 29.9074076255352,
            SellerName = @"Glenn Landeros",
            SellerCity = @"London",
            Date = @"2008-02-03T00:00:00",
            Value = 99.2355603255497,
            NumberOfUnits = 418
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 39.8397729451953,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"New York",
            Date = @"2008-02-04T00:00:00",
            Value = 61.0184083976869,
            NumberOfUnits = 214
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 40.3669903708468,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Mellvile",
            Date = @"2008-02-05T00:00:00",
            Value = 81.7401586946753,
            NumberOfUnits = 229
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 35.1982731536023,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"London",
            Date = @"2008-02-05T00:00:00",
            Value = 54.2465618598492,
            NumberOfUnits = 16
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 41.755009648276,
            SellerName = @"Harry Tyler",
            SellerCity = @"Sofia",
            Date = @"2008-02-08T00:00:00",
            Value = 17.8605546326658,
            NumberOfUnits = 216
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 0.687878998316768,
            SellerName = @"Harry Tyler",
            SellerCity = @"Sofia",
            Date = @"2008-02-09T00:00:00",
            Value = 84.9205587454702,
            NumberOfUnits = 486
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 37.5560580927674,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Tokyo",
            Date = @"2008-02-13T00:00:00",
            Value = 45.0776737858903,
            NumberOfUnits = 172
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 20.8045815680197,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"New York",
            Date = @"2008-02-21T00:00:00",
            Value = 60.5424861239933,
            NumberOfUnits = 102
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 70.6467796911703,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Seattle",
            Date = @"2008-02-24T00:00:00",
            Value = 42.8966130795407,
            NumberOfUnits = 36
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 53.2905441025694,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Mellvile",
            Date = @"2008-02-25T00:00:00",
            Value = 11.0177316288546,
            NumberOfUnits = 71
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 24.8542289830997,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Mellvile",
            Date = @"2008-02-25T00:00:00",
            Value = 16.9750144784222,
            NumberOfUnits = 53
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 64.6324524025584,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Tokyo",
            Date = @"2008-02-25T00:00:00",
            Value = 98.9615043154738,
            NumberOfUnits = 104
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 9.64383753465667,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Tokyo",
            Date = @"2008-02-26T00:00:00",
            Value = 96.2342098803419,
            NumberOfUnits = 294
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 41.0777905681533,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Sofia",
            Date = @"2008-03-03T00:00:00",
            Value = 93.683674975151,
            NumberOfUnits = 454
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 36.9778345511192,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Berlin",
            Date = @"2008-03-05T00:00:00",
            Value = 82.8165260063561,
            NumberOfUnits = 492
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 16.8308799699093,
            SellerName = @"Harry Tyler",
            SellerCity = @"New York",
            Date = @"2008-03-08T00:00:00",
            Value = 0.654079998216629,
            NumberOfUnits = 132
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 24.7168825123072,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"New York",
            Date = @"2008-03-09T00:00:00",
            Value = 88.5194761625116,
            NumberOfUnits = 225
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 65.6444979205935,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2008-03-10T00:00:00",
            Value = 69.0674314131343,
            NumberOfUnits = 422
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 70.4706702709527,
            SellerName = @"Glenn Landeros",
            SellerCity = @"London",
            Date = @"2008-03-12T00:00:00",
            Value = 97.0884484691026,
            NumberOfUnits = 303
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 65.1173483417916,
            SellerName = @"Carl Costello",
            SellerCity = @"London",
            Date = @"2008-03-13T00:00:00",
            Value = 46.4407860983353,
            NumberOfUnits = 319
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 39.5776717642218,
            SellerName = @"Harold Garvin",
            SellerCity = @"London",
            Date = @"2008-03-14T00:00:00",
            Value = 48.5441537334324,
            NumberOfUnits = 262
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 50.7144575709079,
            SellerName = @"Harold Garvin",
            SellerCity = @"Berlin",
            Date = @"2008-03-23T00:00:00",
            Value = 91.7152666448221,
            NumberOfUnits = 345
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 88.2468002793597,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2008-04-03T00:00:00",
            Value = 87.2755209390426,
            NumberOfUnits = 407
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 47.25297454151,
            SellerName = @"Walter Pang",
            SellerCity = @"Berlin",
            Date = @"2008-04-04T00:00:00",
            Value = 15.1277239039204,
            NumberOfUnits = 121
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 30.4275556609163,
            SellerName = @"Larry Lieb",
            SellerCity = @"Seattle",
            Date = @"2008-04-06T00:00:00",
            Value = 44.4254724050059,
            NumberOfUnits = 30
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 88.2431441863268,
            SellerName = @"Harold Garvin",
            SellerCity = @"Berlin",
            Date = @"2008-04-11T00:00:00",
            Value = 25.2809871105854,
            NumberOfUnits = 293
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 16.4635559620632,
            SellerName = @"David Haley",
            SellerCity = @"Sofia",
            Date = @"2008-04-12T00:00:00",
            Value = 55.0719556189477,
            NumberOfUnits = 271
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 95.2082479815969,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Sofia",
            Date = @"2008-04-18T00:00:00",
            Value = 25.7738580115949,
            NumberOfUnits = 107
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 7.7514979558771,
            SellerName = @"Bryan Culver",
            SellerCity = @"Mellvile",
            Date = @"2008-04-18T00:00:00",
            Value = 54.4845382471031,
            NumberOfUnits = 87
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 94.8262768773484,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2008-04-23T00:00:00",
            Value = 78.9546419768383,
            NumberOfUnits = 319
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 37.2118965430241,
            SellerName = @"Lydia Burson",
            SellerCity = @"New York",
            Date = @"2008-04-24T00:00:00",
            Value = 21.6129142426014,
            NumberOfUnits = 346
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 99.3088581596077,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2008-05-07T00:00:00",
            Value = 77.780686075697,
            NumberOfUnits = 382
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 96.081492582374,
            SellerName = @"Larry Lieb",
            SellerCity = @"New York",
            Date = @"2008-05-11T00:00:00",
            Value = 35.3511813261319,
            NumberOfUnits = 334
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 26.1522815684566,
            SellerName = @"Harold Garvin",
            SellerCity = @"Tokyo",
            Date = @"2008-05-13T00:00:00",
            Value = 28.8395709958112,
            NumberOfUnits = 176
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 80.8163119856344,
            SellerName = @"Mark Slater",
            SellerCity = @"Berlin",
            Date = @"2008-05-19T00:00:00",
            Value = 8.38333880919187,
            NumberOfUnits = 125
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 78.320334701948,
            SellerName = @"Russell Shorter",
            SellerCity = @"Mellvile",
            Date = @"2008-05-19T00:00:00",
            Value = 15.0375492940832,
            NumberOfUnits = 458
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 93.9965382190405,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Berlin",
            Date = @"2008-05-25T00:00:00",
            Value = 68.4720673451536,
            NumberOfUnits = 331
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 96.6001784413123,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Mellvile",
            Date = @"2008-05-27T00:00:00",
            Value = 70.9531663316084,
            NumberOfUnits = 39
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 37.6432268124275,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"London",
            Date = @"2008-06-06T00:00:00",
            Value = 97.0892499187445,
            NumberOfUnits = 238
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 46.9774695797718,
            SellerName = @"Walter Pang",
            SellerCity = @"London",
            Date = @"2008-06-07T00:00:00",
            Value = 5.67697128545352,
            NumberOfUnits = 84
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 80.1515980531236,
            SellerName = @"Mark Slater",
            SellerCity = @"Tokyo",
            Date = @"2008-06-08T00:00:00",
            Value = 24.8368413303219,
            NumberOfUnits = 363
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 43.5199616679549,
            SellerName = @"Harry Tyler",
            SellerCity = @"New York",
            Date = @"2008-06-08T00:00:00",
            Value = 58.9737211628695,
            NumberOfUnits = 479
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 56.3160178513806,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Sofia",
            Date = @"2008-06-11T00:00:00",
            Value = 87.4662861169625,
            NumberOfUnits = 404
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 81.6851681944379,
            SellerName = @"Glenn Landeros",
            SellerCity = @"London",
            Date = @"2008-06-18T00:00:00",
            Value = 80.2834164725074,
            NumberOfUnits = 478
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 90.1118466118871,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Sofia",
            Date = @"2008-06-19T00:00:00",
            Value = 2.32863645177737,
            NumberOfUnits = 285
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 99.342426471106,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Sofia",
            Date = @"2008-06-22T00:00:00",
            Value = 82.4890294496385,
            NumberOfUnits = 15
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 30.8345454422918,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Berlin",
            Date = @"2008-06-26T00:00:00",
            Value = 77.8251107678866,
            NumberOfUnits = 245
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 99.3869583585239,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Mellvile",
            Date = @"2008-07-01T00:00:00",
            Value = 8.13976875885379,
            NumberOfUnits = 376
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 73.3497729866532,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"New York",
            Date = @"2008-07-02T00:00:00",
            Value = 48.4468251692349,
            NumberOfUnits = 40
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 43.4966604893546,
            SellerName = @"Larry Lieb",
            SellerCity = @"London",
            Date = @"2008-07-10T00:00:00",
            Value = 37.8727404577065,
            NumberOfUnits = 112
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 16.3942806499052,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"New York",
            Date = @"2008-07-15T00:00:00",
            Value = 9.74060204333654,
            NumberOfUnits = 224
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 71.4022993908274,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Tokyo",
            Date = @"2008-07-16T00:00:00",
            Value = 66.4204306278473,
            NumberOfUnits = 145
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 94.6188190926885,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Mellvile",
            Date = @"2008-07-21T00:00:00",
            Value = 46.4914643887856,
            NumberOfUnits = 272
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 50.7532616847908,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"London",
            Date = @"2008-07-27T00:00:00",
            Value = 90.1144846762132,
            NumberOfUnits = 278
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 12.782123597703,
            SellerName = @"Harry Tyler",
            SellerCity = @"Seattle",
            Date = @"2008-07-27T00:00:00",
            Value = 89.1373240804008,
            NumberOfUnits = 253
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 35.7800310644228,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"New York",
            Date = @"2008-08-01T00:00:00",
            Value = 28.4064661843732,
            NumberOfUnits = 255
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 17.1338880514418,
            SellerName = @"David Haley",
            SellerCity = @"Seattle",
            Date = @"2008-08-02T00:00:00",
            Value = 0.455726543653629,
            NumberOfUnits = 46
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 22.126638806484,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Tokyo",
            Date = @"2008-08-08T00:00:00",
            Value = 58.4454098522875,
            NumberOfUnits = 279
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 62.986888765817,
            SellerName = @"Russell Shorter",
            SellerCity = @"Sofia",
            Date = @"2008-08-08T00:00:00",
            Value = 91.8027585334157,
            NumberOfUnits = 89
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 83.8380225858828,
            SellerName = @"Larry Lieb",
            SellerCity = @"Sofia",
            Date = @"2008-08-14T00:00:00",
            Value = 52.5904764200516,
            NumberOfUnits = 17
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 14.0758062778394,
            SellerName = @"Lydia Burson",
            SellerCity = @"Sofia",
            Date = @"2008-08-21T00:00:00",
            Value = 53.9121391968392,
            NumberOfUnits = 470
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 34.59108692342,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Mellvile",
            Date = @"2008-08-25T00:00:00",
            Value = 1.7413051341387,
            NumberOfUnits = 195
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 86.7273536914621,
            SellerName = @"Lydia Burson",
            SellerCity = @"New York",
            Date = @"2008-08-27T00:00:00",
            Value = 23.7829859479251,
            NumberOfUnits = 173
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 42.2365329890682,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"New York",
            Date = @"2008-09-01T00:00:00",
            Value = 51.1229278292148,
            NumberOfUnits = 472
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 25.6870714135873,
            SellerName = @"Larry Lieb",
            SellerCity = @"Seattle",
            Date = @"2008-09-06T00:00:00",
            Value = 88.372170640329,
            NumberOfUnits = 148
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 23.2085802700411,
            SellerName = @"Walter Pang",
            SellerCity = @"Mellvile",
            Date = @"2008-09-06T00:00:00",
            Value = 94.4850076895603,
            NumberOfUnits = 314
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 83.7636527529748,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2008-09-07T00:00:00",
            Value = 66.7780438283356,
            NumberOfUnits = 431
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 84.4142878821186,
            SellerName = @"Walter Pang",
            SellerCity = @"Mellvile",
            Date = @"2008-09-07T00:00:00",
            Value = 27.6391717733998,
            NumberOfUnits = 347
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 7.32913548468106,
            SellerName = @"Harry Tyler",
            SellerCity = @"Berlin",
            Date = @"2008-09-11T00:00:00",
            Value = 2.77235694358701,
            NumberOfUnits = 27
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 9.55349440199951,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Berlin",
            Date = @"2008-09-12T00:00:00",
            Value = 11.8511460776679,
            NumberOfUnits = 5
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 50.8208721647136,
            SellerName = @"Larry Lieb",
            SellerCity = @"Mellvile",
            Date = @"2008-09-19T00:00:00",
            Value = 16.4697507938695,
            NumberOfUnits = 191
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 79.8693139012294,
            SellerName = @"Bryan Culver",
            SellerCity = @"New York",
            Date = @"2008-09-25T00:00:00",
            Value = 84.2734587305568,
            NumberOfUnits = 421
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 62.2384944754832,
            SellerName = @"Carl Costello",
            SellerCity = @"Seattle",
            Date = @"2008-10-03T00:00:00",
            Value = 28.8573519926785,
            NumberOfUnits = 297
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 96.0947171301091,
            SellerName = @"Glenn Landeros",
            SellerCity = @"New York",
            Date = @"2008-10-04T00:00:00",
            Value = 15.797333380113,
            NumberOfUnits = 128
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 47.0097102443733,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Mellvile",
            Date = @"2008-10-13T00:00:00",
            Value = 37.3008439491041,
            NumberOfUnits = 210
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 35.7560529074427,
            SellerName = @"Russell Shorter",
            SellerCity = @"London",
            Date = @"2008-10-14T00:00:00",
            Value = 26.9420826467416,
            NumberOfUnits = 315
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 78.9894324629518,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"New York",
            Date = @"2008-10-19T00:00:00",
            Value = 69.8382459906108,
            NumberOfUnits = 489
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 84.3203172014655,
            SellerName = @"Walter Pang",
            SellerCity = @"Mellvile",
            Date = @"2008-10-21T00:00:00",
            Value = 61.3185628137172,
            NumberOfUnits = 47
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 25.5284822664822,
            SellerName = @"John Smith",
            SellerCity = @"Mellvile",
            Date = @"2008-10-22T00:00:00",
            Value = 69.3363781875634,
            NumberOfUnits = 92
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 23.8740329276184,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Mellvile",
            Date = @"2008-11-01T00:00:00",
            Value = 81.0919242822993,
            NumberOfUnits = 30
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 53.634575919078,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Berlin",
            Date = @"2008-11-01T00:00:00",
            Value = 15.0065147387825,
            NumberOfUnits = 132
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 68.1529020742294,
            SellerName = @"Bryan Culver",
            SellerCity = @"London",
            Date = @"2008-11-10T00:00:00",
            Value = 6.05394318981745,
            NumberOfUnits = 368
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 59.8804712108711,
            SellerName = @"Kathe Pettel",
            SellerCity = @"New York",
            Date = @"2008-11-11T00:00:00",
            Value = 39.0912905051798,
            NumberOfUnits = 482
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 5.75482128455994,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Mellvile",
            Date = @"2008-11-11T00:00:00",
            Value = 48.6630990862209,
            NumberOfUnits = 22
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 95.8492209649874,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"London",
            Date = @"2008-11-20T00:00:00",
            Value = 87.1416628300872,
            NumberOfUnits = 159
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 59.0664417292301,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Berlin",
            Date = @"2008-11-25T00:00:00",
            Value = 88.6371681413786,
            NumberOfUnits = 52
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 94.029234626344,
            SellerName = @"Harry Tyler",
            SellerCity = @"Tokyo",
            Date = @"2009-01-05T00:00:00",
            Value = 79.8305592405752,
            NumberOfUnits = 194
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 12.7948031354671,
            SellerName = @"David Haley",
            SellerCity = @"Berlin",
            Date = @"2009-01-08T00:00:00",
            Value = 42.8698582774353,
            NumberOfUnits = 100
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 37.8521287058723,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Berlin",
            Date = @"2009-01-10T00:00:00",
            Value = 48.2562405281962,
            NumberOfUnits = 252
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 79.4348882415494,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Tokyo",
            Date = @"2009-01-13T00:00:00",
            Value = 68.5050053375331,
            NumberOfUnits = 116
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 90.9181184558748,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"London",
            Date = @"2009-01-14T00:00:00",
            Value = 27.4614367761935,
            NumberOfUnits = 259
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 99.8486026189516,
            SellerName = @"Glenn Landeros",
            SellerCity = @"London",
            Date = @"2009-01-19T00:00:00",
            Value = 56.7253582909356,
            NumberOfUnits = 217
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 43.2738462664531,
            SellerName = @"Bryan Culver",
            SellerCity = @"Seattle",
            Date = @"2009-01-22T00:00:00",
            Value = 36.4720197098665,
            NumberOfUnits = 48
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 0.654369267008439,
            SellerName = @"Stanley Brooker",
            SellerCity = @"New York",
            Date = @"2009-02-02T00:00:00",
            Value = 71.4257425495543,
            NumberOfUnits = 445
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 60.4641508592591,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Mellvile",
            Date = @"2009-02-03T00:00:00",
            Value = 44.6349808688438,
            NumberOfUnits = 90
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 13.6591548629381,
            SellerName = @"Harry Tyler",
            SellerCity = @"Sofia",
            Date = @"2009-02-07T00:00:00",
            Value = 36.1515843943467,
            NumberOfUnits = 453
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 44.1607726943496,
            SellerName = @"Harry Tyler",
            SellerCity = @"Mellvile",
            Date = @"2009-02-07T00:00:00",
            Value = 85.6432799648695,
            NumberOfUnits = 450
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 94.3300966147008,
            SellerName = @"Lydia Burson",
            SellerCity = @"Sofia",
            Date = @"2009-02-07T00:00:00",
            Value = 48.1036364790535,
            NumberOfUnits = 152
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 8.7838492862805,
            SellerName = @"Harry Tyler",
            SellerCity = @"Berlin",
            Date = @"2009-02-16T00:00:00",
            Value = 46.4947271377289,
            NumberOfUnits = 119
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 79.235950894298,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Tokyo",
            Date = @"2009-02-16T00:00:00",
            Value = 29.2403552817369,
            NumberOfUnits = 463
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 18.5889242769167,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Tokyo",
            Date = @"2009-02-17T00:00:00",
            Value = 19.7616056165479,
            NumberOfUnits = 150
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 27.9011098332243,
            SellerName = @"Walter Pang",
            SellerCity = @"Berlin",
            Date = @"2009-02-19T00:00:00",
            Value = 17.5578246440542,
            NumberOfUnits = 210
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 67.1920887973123,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Tokyo",
            Date = @"2009-02-20T00:00:00",
            Value = 36.3218399865189,
            NumberOfUnits = 150
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 35.8494879379168,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"London",
            Date = @"2009-02-21T00:00:00",
            Value = 73.8886510831717,
            NumberOfUnits = 97
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 34.0737291304738,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Berlin",
            Date = @"2009-02-22T00:00:00",
            Value = 86.4171502117147,
            NumberOfUnits = 256
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 66.2999107345473,
            SellerName = @"Russell Shorter",
            SellerCity = @"London",
            Date = @"2009-02-24T00:00:00",
            Value = 52.8479152139499,
            NumberOfUnits = 172
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 14.9018784123016,
            SellerName = @"Monica Freitag",
            SellerCity = @"Mellvile",
            Date = @"2009-02-24T00:00:00",
            Value = 5.10816471889064,
            NumberOfUnits = 489
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 51.9156207572276,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Sofia",
            Date = @"2009-02-27T00:00:00",
            Value = 9.09175295806106,
            NumberOfUnits = 222
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 98.3082866288294,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Berlin",
            Date = @"2009-03-03T00:00:00",
            Value = 81.3140041573504,
            NumberOfUnits = 300
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 72.8202512826865,
            SellerName = @"Harry Tyler",
            SellerCity = @"London",
            Date = @"2009-03-03T00:00:00",
            Value = 1.3068364007896,
            NumberOfUnits = 270
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 16.2606138811729,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"London",
            Date = @"2009-03-07T00:00:00",
            Value = 81.4439182083327,
            NumberOfUnits = 263
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 93.4466885372282,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Mellvile",
            Date = @"2009-03-10T00:00:00",
            Value = 22.6618440461633,
            NumberOfUnits = 28
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 42.1427614251816,
            SellerName = @"Howard Sprouse",
            SellerCity = @"London",
            Date = @"2009-03-15T00:00:00",
            Value = 20.3884158844074,
            NumberOfUnits = 237
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 54.9838977190591,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Tokyo",
            Date = @"2009-03-16T00:00:00",
            Value = 64.0434504319185,
            NumberOfUnits = 171
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 97.3112582216557,
            SellerName = @"Kathe Pettel",
            SellerCity = @"New York",
            Date = @"2009-03-27T00:00:00",
            Value = 23.9032197389301,
            NumberOfUnits = 251
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 50.8898930395441,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"London",
            Date = @"2009-04-01T00:00:00",
            Value = 32.3240410687048,
            NumberOfUnits = 275
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 4.71444605137894,
            SellerName = @"Brandon Mckim",
            SellerCity = @"London",
            Date = @"2009-04-06T00:00:00",
            Value = 41.960918783192,
            NumberOfUnits = 311
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 70.8505471566927,
            SellerName = @"Monica Freitag",
            SellerCity = @"New York",
            Date = @"2009-04-07T00:00:00",
            Value = 82.8114936048218,
            NumberOfUnits = 217
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 96.7786524895479,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"London",
            Date = @"2009-04-09T00:00:00",
            Value = 62.226076034003,
            NumberOfUnits = 360
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 83.5057999396258,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Berlin",
            Date = @"2009-04-12T00:00:00",
            Value = 51.5879595892448,
            NumberOfUnits = 35
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 96.4138024469902,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"New York",
            Date = @"2009-04-15T00:00:00",
            Value = 80.9865561225389,
            NumberOfUnits = 294
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 70.8025897251454,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Seattle",
            Date = @"2009-04-16T00:00:00",
            Value = 35.8669334258265,
            NumberOfUnits = 436
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 94.524064517824,
            SellerName = @"Kathe Pettel",
            SellerCity = @"London",
            Date = @"2009-04-20T00:00:00",
            Value = 82.4887134984549,
            NumberOfUnits = 78
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 29.6036580249684,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2009-04-22T00:00:00",
            Value = 94.0230918089035,
            NumberOfUnits = 301
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 70.5979821600942,
            SellerName = @"Mark Slater",
            SellerCity = @"New York",
            Date = @"2009-05-02T00:00:00",
            Value = 92.5980870111837,
            NumberOfUnits = 24
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 71.6669971457063,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Seattle",
            Date = @"2009-05-04T00:00:00",
            Value = 19.2821136765564,
            NumberOfUnits = 332
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 14.5527074181255,
            SellerName = @"Mark Slater",
            SellerCity = @"Berlin",
            Date = @"2009-05-11T00:00:00",
            Value = 56.4288374299318,
            NumberOfUnits = 307
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 36.7129272020948,
            SellerName = @"Harold Garvin",
            SellerCity = @"Seattle",
            Date = @"2009-05-11T00:00:00",
            Value = 34.2653989020108,
            NumberOfUnits = 375
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 62.7458781296135,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Mellvile",
            Date = @"2009-05-12T00:00:00",
            Value = 1.97444427850397,
            NumberOfUnits = 499
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 13.699630607711,
            SellerName = @"Russell Shorter",
            SellerCity = @"London",
            Date = @"2009-05-21T00:00:00",
            Value = 42.5140213419283,
            NumberOfUnits = 337
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 46.0902745584446,
            SellerName = @"Larry Lieb",
            SellerCity = @"London",
            Date = @"2009-05-24T00:00:00",
            Value = 55.2507777489958,
            NumberOfUnits = 284
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 95.3368767608594,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Berlin",
            Date = @"2009-05-26T00:00:00",
            Value = 94.7641316311267,
            NumberOfUnits = 292
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 78.0907848282209,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Sofia",
            Date = @"2009-05-26T00:00:00",
            Value = 60.153313800764,
            NumberOfUnits = 424
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 99.3922291320712,
            SellerName = @"Mark Slater",
            SellerCity = @"Mellvile",
            Date = @"2009-06-05T00:00:00",
            Value = 28.9941448387663,
            NumberOfUnits = 271
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 86.9449185146694,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Mellvile",
            Date = @"2009-06-10T00:00:00",
            Value = 94.0419746535094,
            NumberOfUnits = 6
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 13.4957477978877,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Sofia",
            Date = @"2009-06-12T00:00:00",
            Value = 94.8922945628372,
            NumberOfUnits = 44
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 99.6485929003212,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2009-06-12T00:00:00",
            Value = 74.2049469492421,
            NumberOfUnits = 277
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 16.8774421871069,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Seattle",
            Date = @"2009-06-13T00:00:00",
            Value = 65.1211143308883,
            NumberOfUnits = 98
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 42.3769917070759,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Mellvile",
            Date = @"2009-06-22T00:00:00",
            Value = 68.6028470604694,
            NumberOfUnits = 443
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 79.5399570742343,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Seattle",
            Date = @"2009-06-26T00:00:00",
            Value = 81.434181044546,
            NumberOfUnits = 409
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 26.2529126490713,
            SellerName = @"Walter Pang",
            SellerCity = @"New York",
            Date = @"2009-07-02T00:00:00",
            Value = 68.128146216333,
            NumberOfUnits = 240
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 34.0461566271475,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Seattle",
            Date = @"2009-07-10T00:00:00",
            Value = 95.5703596563872,
            NumberOfUnits = 23
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 29.3798175777215,
            SellerName = @"Larry Lieb",
            SellerCity = @"Mellvile",
            Date = @"2009-07-12T00:00:00",
            Value = 35.8895050994537,
            NumberOfUnits = 109
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 86.6504524306629,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Berlin",
            Date = @"2009-07-13T00:00:00",
            Value = 29.8568054241393,
            NumberOfUnits = 117
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 58.3866038165924,
            SellerName = @"Mark Slater",
            SellerCity = @"New York",
            Date = @"2009-07-15T00:00:00",
            Value = 34.3696922689535,
            NumberOfUnits = 336
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 39.7596297970785,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Seattle",
            Date = @"2009-07-18T00:00:00",
            Value = 92.3961012123134,
            NumberOfUnits = 372
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 10.1100024814298,
            SellerName = @"Larry Lieb",
            SellerCity = @"Berlin",
            Date = @"2009-07-19T00:00:00",
            Value = 90.4088654510718,
            NumberOfUnits = 403
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 17.7727690980643,
            SellerName = @"Harry Tyler",
            SellerCity = @"Seattle",
            Date = @"2009-07-19T00:00:00",
            Value = 66.145469558493,
            NumberOfUnits = 144
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 21.5434081487094,
            SellerName = @"Lydia Burson",
            SellerCity = @"Seattle",
            Date = @"2009-07-19T00:00:00",
            Value = 41.7126494654048,
            NumberOfUnits = 395
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 33.5612783830433,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"New York",
            Date = @"2009-07-20T00:00:00",
            Value = 16.6100432707975,
            NumberOfUnits = 236
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 48.7630817800588,
            SellerName = @"Larry Lieb",
            SellerCity = @"Seattle",
            Date = @"2009-07-20T00:00:00",
            Value = 86.7044968934285,
            NumberOfUnits = 160
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 81.7970517938012,
            SellerName = @"David Haley",
            SellerCity = @"Sofia",
            Date = @"2009-07-20T00:00:00",
            Value = 65.782062134604,
            NumberOfUnits = 157
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 9.67370104495143,
            SellerName = @"Glenn Landeros",
            SellerCity = @"Sofia",
            Date = @"2009-07-25T00:00:00",
            Value = 0.0625649467401975,
            NumberOfUnits = 255
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 88.5755474625973,
            SellerName = @"Mark Slater",
            SellerCity = @"London",
            Date = @"2009-08-16T00:00:00",
            Value = 42.9738638657023,
            NumberOfUnits = 284
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 89.3357426344118,
            SellerName = @"Walter Pang",
            SellerCity = @"Tokyo",
            Date = @"2009-08-17T00:00:00",
            Value = 15.7312968353421,
            NumberOfUnits = 333
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 23.9876511618437,
            SellerName = @"Monica Freitag",
            SellerCity = @"Seattle",
            Date = @"2009-08-17T00:00:00",
            Value = 51.5363990569191,
            NumberOfUnits = 48
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 19.3597302396594,
            SellerName = @"Kathe Pettel",
            SellerCity = @"New York",
            Date = @"2009-08-18T00:00:00",
            Value = 82.5479551602844,
            NumberOfUnits = 399
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 9.30053084590497,
            SellerName = @"Mark Slater",
            SellerCity = @"Berlin",
            Date = @"2009-08-24T00:00:00",
            Value = 68.6077507532238,
            NumberOfUnits = 413
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 1.14898169466713,
            SellerName = @"Monica Freitag",
            SellerCity = @"Sofia",
            Date = @"2009-09-06T00:00:00",
            Value = 71.9099786933092,
            NumberOfUnits = 182
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 76.9795825597735,
            SellerName = @"Russell Shorter",
            SellerCity = @"Mellvile",
            Date = @"2009-09-06T00:00:00",
            Value = 44.8902971320275,
            NumberOfUnits = 156
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 80.6645133442546,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Mellvile",
            Date = @"2009-09-09T00:00:00",
            Value = 92.2680239622798,
            NumberOfUnits = 293
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 22.7888861311548,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Berlin",
            Date = @"2009-10-01T00:00:00",
            Value = 99.8839278239216,
            NumberOfUnits = 16
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 78.0536102028813,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Seattle",
            Date = @"2009-10-01T00:00:00",
            Value = 16.012941820553,
            NumberOfUnits = 106
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 72.9745148089596,
            SellerName = @"Glenn Landeros",
            SellerCity = @"Tokyo",
            Date = @"2009-10-06T00:00:00",
            Value = 91.5937769187585,
            NumberOfUnits = 16
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 22.0582418712127,
            SellerName = @"John Smith",
            SellerCity = @"Tokyo",
            Date = @"2009-10-07T00:00:00",
            Value = 1.83085859838447,
            NumberOfUnits = 187
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 42.791869790662,
            SellerName = @"Harry Tyler",
            SellerCity = @"Seattle",
            Date = @"2009-10-10T00:00:00",
            Value = 21.7898646936705,
            NumberOfUnits = 137
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 46.2311712774593,
            SellerName = @"Mark Slater",
            SellerCity = @"Seattle",
            Date = @"2009-10-14T00:00:00",
            Value = 14.979823871972,
            NumberOfUnits = 138
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 14.3501850377536,
            SellerName = @"Mark Slater",
            SellerCity = @"Seattle",
            Date = @"2009-10-24T00:00:00",
            Value = 65.0446162396318,
            NumberOfUnits = 256
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 40.1009556558453,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"London",
            Date = @"2009-10-24T00:00:00",
            Value = 11.0590405813693,
            NumberOfUnits = 353
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 17.1890978315794,
            SellerName = @"Lydia Burson",
            SellerCity = @"Tokyo",
            Date = @"2009-11-01T00:00:00",
            Value = 94.9500347464113,
            NumberOfUnits = 359
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 52.0310281552519,
            SellerName = @"Walter Pang",
            SellerCity = @"Tokyo",
            Date = @"2009-11-04T00:00:00",
            Value = 43.1628818359053,
            NumberOfUnits = 134
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 90.9938719547325,
            SellerName = @"Larry Lieb",
            SellerCity = @"Seattle",
            Date = @"2009-11-09T00:00:00",
            Value = 25.1620659721839,
            NumberOfUnits = 263
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 88.538379077119,
            SellerName = @"Monica Freitag",
            SellerCity = @"Seattle",
            Date = @"2009-11-11T00:00:00",
            Value = 40.9352931850288,
            NumberOfUnits = 313
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 46.481523265355,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Mellvile",
            Date = @"2009-11-16T00:00:00",
            Value = 20.4300965277618,
            NumberOfUnits = 115
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 20.4184623995882,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Berlin",
            Date = @"2009-11-17T00:00:00",
            Value = 33.0386452996352,
            NumberOfUnits = 414
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 70.8301441142476,
            SellerName = @"Kathe Pettel",
            SellerCity = @"New York",
            Date = @"2009-11-21T00:00:00",
            Value = 2.98972730664058,
            NumberOfUnits = 53
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 81.6288890231535,
            SellerName = @"John Smith",
            SellerCity = @"New York",
            Date = @"2009-11-22T00:00:00",
            Value = 86.6687795550883,
            NumberOfUnits = 472
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 9.71408142229267,
            SellerName = @"Harry Tyler",
            SellerCity = @"Mellvile",
            Date = @"2009-11-23T00:00:00",
            Value = 53.5911873232532,
            NumberOfUnits = 199
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 29.755140482334,
            SellerName = @"Harold Garvin",
            SellerCity = @"Sofia",
            Date = @"2009-11-24T00:00:00",
            Value = 27.3887979459897,
            NumberOfUnits = 241
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 33.1185376891487,
            SellerName = @"Glenn Landeros",
            SellerCity = @"New York",
            Date = @"2009-11-24T00:00:00",
            Value = 1.21203092914635,
            NumberOfUnits = 320
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 65.6359763655979,
            SellerName = @"David Haley",
            SellerCity = @"London",
            Date = @"2010-01-02T00:00:00",
            Value = 20.5225394202967,
            NumberOfUnits = 299
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 62.0852599675233,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2010-01-08T00:00:00",
            Value = 35.2569343686369,
            NumberOfUnits = 366
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 78.4744620688606,
            SellerName = @"John Smith",
            SellerCity = @"New York",
            Date = @"2010-01-10T00:00:00",
            Value = 27.7620934079225,
            NumberOfUnits = 290
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 11.5871551034912,
            SellerName = @"Lydia Burson",
            SellerCity = @"Sofia",
            Date = @"2010-01-11T00:00:00",
            Value = 61.7125259068387,
            NumberOfUnits = 350
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 33.4278158533516,
            SellerName = @"Russell Shorter",
            SellerCity = @"Sofia",
            Date = @"2010-01-14T00:00:00",
            Value = 33.6869067203658,
            NumberOfUnits = 469
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 96.1412969493034,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Sofia",
            Date = @"2010-01-21T00:00:00",
            Value = 75.6077166067472,
            NumberOfUnits = 352
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 92.1718476769383,
            SellerName = @"Larry Lieb",
            SellerCity = @"Seattle",
            Date = @"2010-01-25T00:00:00",
            Value = 38.8220244733719,
            NumberOfUnits = 47
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 93.0459558931393,
            SellerName = @"Russell Shorter",
            SellerCity = @"Tokyo",
            Date = @"2010-02-02T00:00:00",
            Value = 66.3971658639597,
            NumberOfUnits = 153
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 38.8884185063133,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Berlin",
            Date = @"2010-02-02T00:00:00",
            Value = 28.4722165337169,
            NumberOfUnits = 211
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 99.2550406601536,
            SellerName = @"Russell Shorter",
            SellerCity = @"Sofia",
            Date = @"2010-02-04T00:00:00",
            Value = 66.9755095462201,
            NumberOfUnits = 267
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 94.4183600574817,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"New York",
            Date = @"2010-02-04T00:00:00",
            Value = 71.2719668034799,
            NumberOfUnits = 91
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 19.7701877075109,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Tokyo",
            Date = @"2010-02-05T00:00:00",
            Value = 45.8602490117123,
            NumberOfUnits = 84
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 87.1271086331117,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Mellvile",
            Date = @"2010-02-11T00:00:00",
            Value = 66.7467462209737,
            NumberOfUnits = 270
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 76.21922282326,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Berlin",
            Date = @"2010-02-12T00:00:00",
            Value = 86.9610477178176,
            NumberOfUnits = 496
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 51.9355321544854,
            SellerName = @"John Smith",
            SellerCity = @"Seattle",
            Date = @"2010-02-16T00:00:00",
            Value = 47.3254078753877,
            NumberOfUnits = 24
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 21.709201215631,
            SellerName = @"Walter Pang",
            SellerCity = @"Mellvile",
            Date = @"2010-02-17T00:00:00",
            Value = 72.6563786960469,
            NumberOfUnits = 41
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 15.6659258602494,
            SellerName = @"John Smith",
            SellerCity = @"Mellvile",
            Date = @"2010-02-22T00:00:00",
            Value = 65.6362050984223,
            NumberOfUnits = 365
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 2.67735566137235,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Sofia",
            Date = @"2010-03-01T00:00:00",
            Value = 68.6297503619593,
            NumberOfUnits = 202
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 52.2564326190653,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Seattle",
            Date = @"2010-03-01T00:00:00",
            Value = 79.2489015400637,
            NumberOfUnits = 225
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 0.306599866741616,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Mellvile",
            Date = @"2010-03-03T00:00:00",
            Value = 70.0652126549115,
            NumberOfUnits = 206
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 22.3626474488353,
            SellerName = @"Larry Lieb",
            SellerCity = @"Sofia",
            Date = @"2010-03-11T00:00:00",
            Value = 54.6736846466892,
            NumberOfUnits = 158
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 94.7514695090947,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"London",
            Date = @"2010-03-14T00:00:00",
            Value = 70.4222260836615,
            NumberOfUnits = 169
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 1.12442909792272,
            SellerName = @"John Smith",
            SellerCity = @"New York",
            Date = @"2010-03-15T00:00:00",
            Value = 18.8684402587211,
            NumberOfUnits = 4
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 12.1681971997806,
            SellerName = @"Monica Freitag",
            SellerCity = @"New York",
            Date = @"2010-03-15T00:00:00",
            Value = 12.6607507060565,
            NumberOfUnits = 232
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 58.7548206368251,
            SellerName = @"Mark Slater",
            SellerCity = @"Berlin",
            Date = @"2010-03-16T00:00:00",
            Value = 78.7513239675906,
            NumberOfUnits = 421
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 43.9502779599048,
            SellerName = @"David Haley",
            SellerCity = @"Seattle",
            Date = @"2010-03-25T00:00:00",
            Value = 89.6369019009345,
            NumberOfUnits = 260
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 54.4511389706522,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Seattle",
            Date = @"2010-04-02T00:00:00",
            Value = 91.9299451131047,
            NumberOfUnits = 194
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 94.5653737497355,
            SellerName = @"Walter Pang",
            SellerCity = @"Tokyo",
            Date = @"2010-04-05T00:00:00",
            Value = 35.4152377394099,
            NumberOfUnits = 491
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 11.1211000527819,
            SellerName = @"Harold Garvin",
            SellerCity = @"London",
            Date = @"2010-04-14T00:00:00",
            Value = 29.9869050411447,
            NumberOfUnits = 256
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 18.0924166078178,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Mellvile",
            Date = @"2010-04-15T00:00:00",
            Value = 84.4573668131872,
            NumberOfUnits = 279
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 8.27759965708367,
            SellerName = @"Carl Costello",
            SellerCity = @"Berlin",
            Date = @"2010-04-15T00:00:00",
            Value = 99.5689766479512,
            NumberOfUnits = 287
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 77.894294018808,
            SellerName = @"Carl Costello",
            SellerCity = @"New York",
            Date = @"2010-04-22T00:00:00",
            Value = 58.9137158165284,
            NumberOfUnits = 363
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 55.6240158880241,
            SellerName = @"Mark Slater",
            SellerCity = @"Berlin",
            Date = @"2010-04-22T00:00:00",
            Value = 16.3176310324658,
            NumberOfUnits = 499
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 39.3389566053352,
            SellerName = @"Lydia Burson",
            SellerCity = @"Berlin",
            Date = @"2010-04-24T00:00:00",
            Value = 0.0920804217886554,
            NumberOfUnits = 109
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 7.73894568334284,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Berlin",
            Date = @"2010-05-04T00:00:00",
            Value = 99.5294287332936,
            NumberOfUnits = 25
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 62.4379060056237,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Mellvile",
            Date = @"2010-05-05T00:00:00",
            Value = 47.9538268167311,
            NumberOfUnits = 64
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 38.6960930371173,
            SellerName = @"Howard Sprouse",
            SellerCity = @"London",
            Date = @"2010-05-06T00:00:00",
            Value = 57.6676950592863,
            NumberOfUnits = 256
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 17.764891412931,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Mellvile",
            Date = @"2010-05-07T00:00:00",
            Value = 15.2710798267606,
            NumberOfUnits = 50
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 57.7715399012768,
            SellerName = @"Bryan Culver",
            SellerCity = @"Berlin",
            Date = @"2010-05-07T00:00:00",
            Value = 58.6176938650281,
            NumberOfUnits = 437
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 21.4127468976252,
            SellerName = @"Bryan Culver",
            SellerCity = @"Sofia",
            Date = @"2010-05-19T00:00:00",
            Value = 40.9520166651122,
            NumberOfUnits = 253
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 10.100512257824,
            SellerName = @"Monica Freitag",
            SellerCity = @"London",
            Date = @"2010-05-22T00:00:00",
            Value = 24.0426371451666,
            NumberOfUnits = 312
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 87.649551167921,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"London",
            Date = @"2010-05-24T00:00:00",
            Value = 12.4524083046487,
            NumberOfUnits = 82
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 42.5529655267265,
            SellerName = @"Harold Garvin",
            SellerCity = @"New York",
            Date = @"2010-06-01T00:00:00",
            Value = 32.2188693248755,
            NumberOfUnits = 467
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 79.7726707438811,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Sofia",
            Date = @"2010-06-05T00:00:00",
            Value = 69.4770410980457,
            NumberOfUnits = 74
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 1.83547618884383,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2010-06-10T00:00:00",
            Value = 14.7115019684245,
            NumberOfUnits = 81
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 15.0386840175086,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Berlin",
            Date = @"2010-06-25T00:00:00",
            Value = 18.7104082287803,
            NumberOfUnits = 88
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 43.3930698518609,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Mellvile",
            Date = @"2010-06-26T00:00:00",
            Value = 44.3231601474449,
            NumberOfUnits = 126
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 16.2364924867807,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Sofia",
            Date = @"2010-06-27T00:00:00",
            Value = 77.7216357075244,
            NumberOfUnits = 112
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 59.1922528851741,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Sofia",
            Date = @"2010-06-27T00:00:00",
            Value = 15.4449518376239,
            NumberOfUnits = 47
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 39.8581418394382,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Sofia",
            Date = @"2010-07-05T00:00:00",
            Value = 29.3091846300797,
            NumberOfUnits = 218
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 27.0444256379476,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"New York",
            Date = @"2010-07-05T00:00:00",
            Value = 29.8475043987145,
            NumberOfUnits = 34
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 14.2691450725632,
            SellerName = @"Bryan Culver",
            SellerCity = @"Sofia",
            Date = @"2010-07-13T00:00:00",
            Value = 83.4209680480049,
            NumberOfUnits = 492
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 53.3786114553821,
            SellerName = @"Harry Tyler",
            SellerCity = @"Sofia",
            Date = @"2010-07-16T00:00:00",
            Value = 41.5384453449112,
            NumberOfUnits = 464
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 21.4328872139719,
            SellerName = @"Harry Tyler",
            SellerCity = @"Seattle",
            Date = @"2010-07-17T00:00:00",
            Value = 83.2859072756422,
            NumberOfUnits = 118
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 23.970818670453,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2010-07-18T00:00:00",
            Value = 94.1482592346837,
            NumberOfUnits = 442
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 37.5230978883445,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"London",
            Date = @"2010-07-23T00:00:00",
            Value = 59.5941603926914,
            NumberOfUnits = 248
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 60.6786810144217,
            SellerName = @"Lydia Burson",
            SellerCity = @"London",
            Date = @"2010-07-23T00:00:00",
            Value = 83.4996018016243,
            NumberOfUnits = 472
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 78.0230887131873,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"New York",
            Date = @"2010-07-24T00:00:00",
            Value = 83.8676409255097,
            NumberOfUnits = 140
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 47.6352533081711,
            SellerName = @"Lydia Burson",
            SellerCity = @"Tokyo",
            Date = @"2010-07-26T00:00:00",
            Value = 86.6125727475679,
            NumberOfUnits = 118
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 58.2019802919598,
            SellerName = @"Harry Tyler",
            SellerCity = @"Sofia",
            Date = @"2010-07-27T00:00:00",
            Value = 63.9597797132841,
            NumberOfUnits = 176
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 98.3753316562508,
            SellerName = @"Russell Shorter",
            SellerCity = @"Mellvile",
            Date = @"2010-08-01T00:00:00",
            Value = 23.2771004658551,
            NumberOfUnits = 77
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 2.91859693961153,
            SellerName = @"Glenn Landeros",
            SellerCity = @"Sofia",
            Date = @"2010-08-08T00:00:00",
            Value = 74.2696866273273,
            NumberOfUnits = 105
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 98.1575848060463,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Tokyo",
            Date = @"2010-08-21T00:00:00",
            Value = 60.6481732151695,
            NumberOfUnits = 160
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 79.0367491445675,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Seattle",
            Date = @"2010-08-26T00:00:00",
            Value = 66.9235039348358,
            NumberOfUnits = 186
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 17.7901039914182,
            SellerName = @"Harold Garvin",
            SellerCity = @"Seattle",
            Date = @"2010-09-04T00:00:00",
            Value = 28.9908316121394,
            NumberOfUnits = 380
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 38.6847079911664,
            SellerName = @"John Smith",
            SellerCity = @"Tokyo",
            Date = @"2010-09-11T00:00:00",
            Value = 41.4628619986879,
            NumberOfUnits = 470
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 75.2331203665739,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Mellvile",
            Date = @"2010-09-13T00:00:00",
            Value = 42.6885162678959,
            NumberOfUnits = 348
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 55.3015930835631,
            SellerName = @"Carl Costello",
            SellerCity = @"London",
            Date = @"2010-09-14T00:00:00",
            Value = 29.3834675705915,
            NumberOfUnits = 151
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 51.3150495715975,
            SellerName = @"Kathe Pettel",
            SellerCity = @"New York",
            Date = @"2010-09-24T00:00:00",
            Value = 86.5812376544723,
            NumberOfUnits = 7
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 31.307030995985,
            SellerName = @"Monica Freitag",
            SellerCity = @"New York",
            Date = @"2010-10-07T00:00:00",
            Value = 38.9368724259254,
            NumberOfUnits = 123
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 79.9592423625101,
            SellerName = @"Mark Slater",
            SellerCity = @"Seattle",
            Date = @"2010-10-08T00:00:00",
            Value = 8.67633717538618,
            NumberOfUnits = 374
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 94.6578224164703,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Mellvile",
            Date = @"2010-10-11T00:00:00",
            Value = 96.6699889845541,
            NumberOfUnits = 178
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 41.9676100099308,
            SellerName = @"Bryan Culver",
            SellerCity = @"Sofia",
            Date = @"2010-10-22T00:00:00",
            Value = 31.4126786456502,
            NumberOfUnits = 354
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 46.5647290677599,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"New York",
            Date = @"2010-10-25T00:00:00",
            Value = 85.5404131978473,
            NumberOfUnits = 459
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 27.142422565791,
            SellerName = @"Mark Slater",
            SellerCity = @"London",
            Date = @"2010-11-02T00:00:00",
            Value = 46.4249687951174,
            NumberOfUnits = 78
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 30.2323615319246,
            SellerName = @"Walter Pang",
            SellerCity = @"Berlin",
            Date = @"2010-11-03T00:00:00",
            Value = 52.0832259916157,
            NumberOfUnits = 417
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 82.1662157690927,
            SellerName = @"Walter Pang",
            SellerCity = @"Seattle",
            Date = @"2010-11-12T00:00:00",
            Value = 15.3999604356475,
            NumberOfUnits = 208
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 13.240201125499,
            SellerName = @"Harold Garvin",
            SellerCity = @"Seattle",
            Date = @"2010-11-19T00:00:00",
            Value = 48.6144510789842,
            NumberOfUnits = 359
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 8.82965918110202,
            SellerName = @"Russell Shorter",
            SellerCity = @"New York",
            Date = @"2010-11-25T00:00:00",
            Value = 24.4904398566533,
            NumberOfUnits = 392
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 78.4260817702981,
            SellerName = @"John Smith",
            SellerCity = @"London",
            Date = @"2011-01-01T00:00:00",
            Value = 37.5964090403153,
            NumberOfUnits = 241
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 50.5900502906135,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Seattle",
            Date = @"2011-01-04T00:00:00",
            Value = 27.1853911351345,
            NumberOfUnits = 62
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 6.3079299900252,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Tokyo",
            Date = @"2011-01-06T00:00:00",
            Value = 89.6156176410688,
            NumberOfUnits = 485
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 47.4440275446717,
            SellerName = @"Bryan Culver",
            SellerCity = @"Sofia",
            Date = @"2011-01-14T00:00:00",
            Value = 4.89485562075621,
            NumberOfUnits = 470
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 6.14731172385966,
            SellerName = @"Harry Tyler",
            SellerCity = @"Seattle",
            Date = @"2011-01-23T00:00:00",
            Value = 78.5233307064154,
            NumberOfUnits = 197
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 57.5989394716914,
            SellerName = @"Larry Lieb",
            SellerCity = @"Berlin",
            Date = @"2011-01-26T00:00:00",
            Value = 59.7489598485404,
            NumberOfUnits = 353
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 37.6194079116077,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Mellvile",
            Date = @"2011-02-01T00:00:00",
            Value = 39.5911915412132,
            NumberOfUnits = 338
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 20.9958269824254,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"New York",
            Date = @"2011-02-08T00:00:00",
            Value = 92.8749361973605,
            NumberOfUnits = 17
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 11.7769003900592,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Berlin",
            Date = @"2011-02-12T00:00:00",
            Value = 61.2888651254069,
            NumberOfUnits = 429
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 64.99628464924,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Tokyo",
            Date = @"2011-02-14T00:00:00",
            Value = 24.2937369850901,
            NumberOfUnits = 385
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 19.8995369113514,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"New York",
            Date = @"2011-02-20T00:00:00",
            Value = 35.2711213916871,
            NumberOfUnits = 166
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 3.24316662887259,
            SellerName = @"Lydia Burson",
            SellerCity = @"Seattle",
            Date = @"2011-02-20T00:00:00",
            Value = 52.5691429397879,
            NumberOfUnits = 137
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 18.1803640062829,
            SellerName = @"Russell Shorter",
            SellerCity = @"New York",
            Date = @"2011-02-24T00:00:00",
            Value = 8.24380023788838,
            NumberOfUnits = 443
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 20.4427896628356,
            SellerName = @"Carl Costello",
            SellerCity = @"Seattle",
            Date = @"2011-02-26T00:00:00",
            Value = 87.3277976584285,
            NumberOfUnits = 40
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 20.5473255927429,
            SellerName = @"Glenn Landeros",
            SellerCity = @"London",
            Date = @"2011-03-05T00:00:00",
            Value = 7.27535193193487,
            NumberOfUnits = 138
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 23.7664708047018,
            SellerName = @"Lydia Burson",
            SellerCity = @"Tokyo",
            Date = @"2011-03-09T00:00:00",
            Value = 18.2431707709297,
            NumberOfUnits = 15
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 76.2531758175479,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Mellvile",
            Date = @"2011-03-09T00:00:00",
            Value = 74.4984883696299,
            NumberOfUnits = 469
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 93.2519404651839,
            SellerName = @"Russell Shorter",
            SellerCity = @"London",
            Date = @"2011-03-11T00:00:00",
            Value = 88.9964542766085,
            NumberOfUnits = 426
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 62.9924886687624,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Seattle",
            Date = @"2011-03-16T00:00:00",
            Value = 32.4708369711744,
            NumberOfUnits = 208
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 58.4988099795295,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Seattle",
            Date = @"2011-03-21T00:00:00",
            Value = 50.8492368044561,
            NumberOfUnits = 155
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 82.3833047795963,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Seattle",
            Date = @"2011-03-23T00:00:00",
            Value = 33.3697168777556,
            NumberOfUnits = 381
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 19.1687322310958,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Tokyo",
            Date = @"2011-04-12T00:00:00",
            Value = 75.1666108961993,
            NumberOfUnits = 5
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 53.5164639602958,
            SellerName = @"Walter Pang",
            SellerCity = @"London",
            Date = @"2011-04-12T00:00:00",
            Value = 14.5333742324884,
            NumberOfUnits = 221
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 97.4074014450458,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Sofia",
            Date = @"2011-04-14T00:00:00",
            Value = 84.6913678034634,
            NumberOfUnits = 39
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 74.0541336005806,
            SellerName = @"Mark Slater",
            SellerCity = @"New York",
            Date = @"2011-04-16T00:00:00",
            Value = 51.2958985992223,
            NumberOfUnits = 468
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 8.1049134061229,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Seattle",
            Date = @"2011-04-17T00:00:00",
            Value = 0.702147512092324,
            NumberOfUnits = 44
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 59.0556036490275,
            SellerName = @"John Smith",
            SellerCity = @"Mellvile",
            Date = @"2011-04-22T00:00:00",
            Value = 47.5329109688908,
            NumberOfUnits = 287
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 96.8167277503837,
            SellerName = @"Russell Shorter",
            SellerCity = @"Sofia",
            Date = @"2011-04-24T00:00:00",
            Value = 78.5457338572227,
            NumberOfUnits = 463
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 76.7129123568129,
            SellerName = @"Walter Pang",
            SellerCity = @"Seattle",
            Date = @"2011-04-24T00:00:00",
            Value = 62.9200352183171,
            NumberOfUnits = 335
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 73.4245368621426,
            SellerName = @"Walter Pang",
            SellerCity = @"Berlin",
            Date = @"2011-04-24T00:00:00",
            Value = 30.5695361134454,
            NumberOfUnits = 211
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 66.398487550392,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Seattle",
            Date = @"2011-05-03T00:00:00",
            Value = 87.3747912176767,
            NumberOfUnits = 291
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 37.014730059083,
            SellerName = @"John Smith",
            SellerCity = @"Sofia",
            Date = @"2011-05-05T00:00:00",
            Value = 40.1370411459995,
            NumberOfUnits = 1
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 21.3072483992703,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Seattle",
            Date = @"2011-05-06T00:00:00",
            Value = 46.0055965213131,
            NumberOfUnits = 120
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 19.8939418047173,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Berlin",
            Date = @"2011-05-06T00:00:00",
            Value = 72.6099307986954,
            NumberOfUnits = 382
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 16.4867584204705,
            SellerName = @"Harry Tyler",
            SellerCity = @"Seattle",
            Date = @"2011-05-07T00:00:00",
            Value = 7.76377297368076,
            NumberOfUnits = 63
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 41.6604966584875,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Seattle",
            Date = @"2011-05-12T00:00:00",
            Value = 94.3181483979887,
            NumberOfUnits = 230
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 4.97736600459431,
            SellerName = @"Larry Lieb",
            SellerCity = @"Tokyo",
            Date = @"2011-05-13T00:00:00",
            Value = 30.8913420563989,
            NumberOfUnits = 362
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 10.7490869289027,
            SellerName = @"Monica Freitag",
            SellerCity = @"New York",
            Date = @"2011-05-17T00:00:00",
            Value = 59.668867131541,
            NumberOfUnits = 430
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 66.0475761471538,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2011-05-23T00:00:00",
            Value = 91.1396276164519,
            NumberOfUnits = 204
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 60.848456370108,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Berlin",
            Date = @"2011-05-24T00:00:00",
            Value = 86.0976055665396,
            NumberOfUnits = 118
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 68.7086188088677,
            SellerName = @"Walter Pang",
            SellerCity = @"Sofia",
            Date = @"2011-06-01T00:00:00",
            Value = 14.5628930602981,
            NumberOfUnits = 17
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 40.6808912477833,
            SellerName = @"Walter Pang",
            SellerCity = @"New York",
            Date = @"2011-06-03T00:00:00",
            Value = 9.04399659905769,
            NumberOfUnits = 312
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 96.9003142774572,
            SellerName = @"Lydia Burson",
            SellerCity = @"Seattle",
            Date = @"2011-06-12T00:00:00",
            Value = 95.0383566762499,
            NumberOfUnits = 283
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 67.0312101799209,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Seattle",
            Date = @"2011-06-13T00:00:00",
            Value = 27.5874846743361,
            NumberOfUnits = 460
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 67.0923743243759,
            SellerName = @"Howard Sprouse",
            SellerCity = @"New York",
            Date = @"2011-06-14T00:00:00",
            Value = 66.2305235239819,
            NumberOfUnits = 295
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 28.0480402652398,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Mellvile",
            Date = @"2011-06-15T00:00:00",
            Value = 50.5041706145295,
            NumberOfUnits = 49
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 7.38374935806903,
            SellerName = @"Russell Shorter",
            SellerCity = @"Tokyo",
            Date = @"2011-06-24T00:00:00",
            Value = 7.87160536640864,
            NumberOfUnits = 127
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 39.2197590038272,
            SellerName = @"Mark Slater",
            SellerCity = @"Seattle",
            Date = @"2011-06-27T00:00:00",
            Value = 98.7102946260526,
            NumberOfUnits = 244
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 53.4186711317946,
            SellerName = @"Harold Garvin",
            SellerCity = @"Tokyo",
            Date = @"2011-07-01T00:00:00",
            Value = 11.2318856228291,
            NumberOfUnits = 188
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 25.5238985761646,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Seattle",
            Date = @"2011-07-06T00:00:00",
            Value = 56.1265900526785,
            NumberOfUnits = 458
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 70.2571991692564,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Mellvile",
            Date = @"2011-07-08T00:00:00",
            Value = 82.3391775052711,
            NumberOfUnits = 448
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 7.63659435679978,
            SellerName = @"Harold Garvin",
            SellerCity = @"Berlin",
            Date = @"2011-07-27T00:00:00",
            Value = 30.4619372032871,
            NumberOfUnits = 226
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 21.5123230691591,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2011-08-01T00:00:00",
            Value = 69.6182714633729,
            NumberOfUnits = 474
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 37.5963703438623,
            SellerName = @"David Haley",
            SellerCity = @"Sofia",
            Date = @"2011-08-02T00:00:00",
            Value = 62.767845142059,
            NumberOfUnits = 338
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 99.3647431020461,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"London",
            Date = @"2011-08-02T00:00:00",
            Value = 75.2439621255007,
            NumberOfUnits = 88
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 72.2329456695509,
            SellerName = @"Carl Costello",
            SellerCity = @"Berlin",
            Date = @"2011-08-04T00:00:00",
            Value = 86.2765017367324,
            NumberOfUnits = 436
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 34.253647892854,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Mellvile",
            Date = @"2011-08-06T00:00:00",
            Value = 9.21892994512754,
            NumberOfUnits = 297
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 46.8859906992344,
            SellerName = @"Russell Shorter",
            SellerCity = @"London",
            Date = @"2011-08-07T00:00:00",
            Value = 5.08746817013597,
            NumberOfUnits = 240
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 26.3691973529613,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Sofia",
            Date = @"2011-08-07T00:00:00",
            Value = 80.2413071413717,
            NumberOfUnits = 415
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 49.0728411120702,
            SellerName = @"David Haley",
            SellerCity = @"Mellvile",
            Date = @"2011-08-08T00:00:00",
            Value = 61.2005174444991,
            NumberOfUnits = 435
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 95.0586125697282,
            SellerName = @"Monica Freitag",
            SellerCity = @"Berlin",
            Date = @"2011-08-16T00:00:00",
            Value = 73.751322260942,
            NumberOfUnits = 64
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 74.1819833750753,
            SellerName = @"John Smith",
            SellerCity = @"Seattle",
            Date = @"2011-08-23T00:00:00",
            Value = 40.736002680257,
            NumberOfUnits = 21
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 82.506200011124,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2011-08-25T00:00:00",
            Value = 54.9079566052686,
            NumberOfUnits = 467
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 42.7733675310264,
            SellerName = @"Lydia Burson",
            SellerCity = @"Sofia",
            Date = @"2011-09-02T00:00:00",
            Value = 28.2302390915482,
            NumberOfUnits = 98
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 83.472341757022,
            SellerName = @"Russell Shorter",
            SellerCity = @"Mellvile",
            Date = @"2011-09-04T00:00:00",
            Value = 72.4820205347994,
            NumberOfUnits = 370
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 41.5529122769613,
            SellerName = @"Walter Pang",
            SellerCity = @"Berlin",
            Date = @"2011-09-05T00:00:00",
            Value = 80.9870070223636,
            NumberOfUnits = 94
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 74.1184084090024,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"London",
            Date = @"2011-09-09T00:00:00",
            Value = 94.8475311020611,
            NumberOfUnits = 106
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 75.4044839997797,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Sofia",
            Date = @"2011-09-11T00:00:00",
            Value = 9.88664790517029,
            NumberOfUnits = 261
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 10.2271893574983,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Seattle",
            Date = @"2011-09-17T00:00:00",
            Value = 29.3933310217193,
            NumberOfUnits = 307
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 72.9297495786705,
            SellerName = @"Harry Tyler",
            SellerCity = @"New York",
            Date = @"2011-09-17T00:00:00",
            Value = 56.9024039231718,
            NumberOfUnits = 362
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 85.1336930809234,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Tokyo",
            Date = @"2011-09-24T00:00:00",
            Value = 23.8634354080369,
            NumberOfUnits = 330
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 77.5958809431623,
            SellerName = @"Walter Pang",
            SellerCity = @"New York",
            Date = @"2011-09-26T00:00:00",
            Value = 91.8212834241899,
            NumberOfUnits = 23
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 50.3629545915699,
            SellerName = @"David Haley",
            SellerCity = @"Berlin",
            Date = @"2011-09-27T00:00:00",
            Value = 66.7664189668216,
            NumberOfUnits = 392
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 32.2904265636068,
            SellerName = @"Larry Lieb",
            SellerCity = @"Seattle",
            Date = @"2011-10-13T00:00:00",
            Value = 81.5086811229161,
            NumberOfUnits = 16
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 62.986913725262,
            SellerName = @"Lydia Burson",
            SellerCity = @"New York",
            Date = @"2011-10-13T00:00:00",
            Value = 30.9104030164473,
            NumberOfUnits = 100
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 13.4411500363802,
            SellerName = @"Carl Costello",
            SellerCity = @"Berlin",
            Date = @"2011-10-22T00:00:00",
            Value = 85.4663283496473,
            NumberOfUnits = 132
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 0.361669575963947,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2011-10-22T00:00:00",
            Value = 74.401750589908,
            NumberOfUnits = 22
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 66.2378396216025,
            SellerName = @"Walter Pang",
            SellerCity = @"New York",
            Date = @"2011-11-02T00:00:00",
            Value = 88.1351342835162,
            NumberOfUnits = 96
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 50.1464152942162,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Berlin",
            Date = @"2011-11-03T00:00:00",
            Value = 31.4315148775613,
            NumberOfUnits = 76
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 67.8830748274378,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Mellvile",
            Date = @"2011-11-04T00:00:00",
            Value = 91.0746185067457,
            NumberOfUnits = 492
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 6.55370010368233,
            SellerName = @"Harry Tyler",
            SellerCity = @"Berlin",
            Date = @"2011-11-08T00:00:00",
            Value = 51.4585359261644,
            NumberOfUnits = 49
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 35.5539850124875,
            SellerName = @"Russell Shorter",
            SellerCity = @"Mellvile",
            Date = @"2011-11-12T00:00:00",
            Value = 20.8498855218524,
            NumberOfUnits = 197
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 59.9273909628053,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Tokyo",
            Date = @"2011-11-12T00:00:00",
            Value = 70.3226974095789,
            NumberOfUnits = 484
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 67.3557070397566,
            SellerName = @"Russell Shorter",
            SellerCity = @"Tokyo",
            Date = @"2011-11-13T00:00:00",
            Value = 14.2684653002156,
            NumberOfUnits = 182
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 51.9756810050344,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"London",
            Date = @"2011-11-15T00:00:00",
            Value = 18.3714989192651,
            NumberOfUnits = 42
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 66.6745188025173,
            SellerName = @"Brandon Mckim",
            SellerCity = @"New York",
            Date = @"2011-11-19T00:00:00",
            Value = 52.7554862912537,
            NumberOfUnits = 109
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 56.1377222445503,
            SellerName = @"Harold Garvin",
            SellerCity = @"Mellvile",
            Date = @"2011-11-23T00:00:00",
            Value = 40.1715800353194,
            NumberOfUnits = 310
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 93.5307055681621,
            SellerName = @"Monica Freitag",
            SellerCity = @"Sofia",
            Date = @"2012-01-03T00:00:00",
            Value = 53.3059361173333,
            NumberOfUnits = 306
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 9.53391464871071,
            SellerName = @"Harold Garvin",
            SellerCity = @"Seattle",
            Date = @"2012-01-06T00:00:00",
            Value = 82.9525733752887,
            NumberOfUnits = 290
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 41.1171674454199,
            SellerName = @"Monica Freitag",
            SellerCity = @"Tokyo",
            Date = @"2012-01-10T00:00:00",
            Value = 29.7652628411377,
            NumberOfUnits = 499
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 9.79987862976262,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Berlin",
            Date = @"2012-01-11T00:00:00",
            Value = 10.7432314710427,
            NumberOfUnits = 7
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 64.5805622286073,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Sofia",
            Date = @"2012-01-14T00:00:00",
            Value = 34.9494885350342,
            NumberOfUnits = 220
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 47.2827450126795,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"New York",
            Date = @"2012-01-15T00:00:00",
            Value = 50.1851662761463,
            NumberOfUnits = 395
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 14.6093829602978,
            SellerName = @"Lydia Burson",
            SellerCity = @"Sofia",
            Date = @"2012-01-18T00:00:00",
            Value = 99.9983640853308,
            NumberOfUnits = 219
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 10.6812852484553,
            SellerName = @"Larry Lieb",
            SellerCity = @"Mellvile",
            Date = @"2012-01-18T00:00:00",
            Value = 91.9284968599344,
            NumberOfUnits = 229
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 64.9146081250695,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Mellvile",
            Date = @"2012-01-22T00:00:00",
            Value = 55.8073452468064,
            NumberOfUnits = 111
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 47.9091272446835,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"London",
            Date = @"2012-02-01T00:00:00",
            Value = 20.4733148778199,
            NumberOfUnits = 237
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 87.8157763685173,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Berlin",
            Date = @"2012-02-13T00:00:00",
            Value = 17.1706766901401,
            NumberOfUnits = 114
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 55.4040708837118,
            SellerName = @"Bryan Culver",
            SellerCity = @"London",
            Date = @"2012-02-23T00:00:00",
            Value = 76.7434884220098,
            NumberOfUnits = 329
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 40.7557223181965,
            SellerName = @"Howard Sprouse",
            SellerCity = @"Seattle",
            Date = @"2012-02-24T00:00:00",
            Value = 1.16606745923221,
            NumberOfUnits = 135
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 57.8275545303838,
            SellerName = @"Harold Garvin",
            SellerCity = @"New York",
            Date = @"2012-03-02T00:00:00",
            Value = 46.816691358954,
            NumberOfUnits = 187
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 14.7641990402547,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2012-03-10T00:00:00",
            Value = 17.6293212071198,
            NumberOfUnits = 286
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 12.9919173722118,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"Mellvile",
            Date = @"2012-03-11T00:00:00",
            Value = 18.2109362996234,
            NumberOfUnits = 468
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 26.0132929896998,
            SellerName = @"Monica Freitag",
            SellerCity = @"Tokyo",
            Date = @"2012-03-18T00:00:00",
            Value = 93.2307979526142,
            NumberOfUnits = 71
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 72.6239229890629,
            SellerName = @"Bryan Culver",
            SellerCity = @"Mellvile",
            Date = @"2012-03-21T00:00:00",
            Value = 61.9746424546347,
            NumberOfUnits = 251
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 44.4300027771061,
            SellerName = @"Monica Freitag",
            SellerCity = @"Berlin",
            Date = @"2012-03-25T00:00:00",
            Value = 57.1378540048086,
            NumberOfUnits = 297
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 68.1920563654006,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Berlin",
            Date = @"2012-03-25T00:00:00",
            Value = 4.19275765502488,
            NumberOfUnits = 248
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 35.3010389186912,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"Sofia",
            Date = @"2012-03-26T00:00:00",
            Value = 45.2345683915702,
            NumberOfUnits = 488
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 41.0797411301545,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Sofia",
            Date = @"2012-04-06T00:00:00",
            Value = 59.4756415856423,
            NumberOfUnits = 211
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 29.2873495860432,
            SellerName = @"Stanley Brooker",
            SellerCity = @"Seattle",
            Date = @"2012-04-14T00:00:00",
            Value = 3.12183979112741,
            NumberOfUnits = 149
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 51.9607183299776,
            SellerName = @"Lydia Burson",
            SellerCity = @"Berlin",
            Date = @"2012-04-14T00:00:00",
            Value = 9.81095578047026,
            NumberOfUnits = 99
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 57.8388750822464,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Seattle",
            Date = @"2012-04-16T00:00:00",
            Value = 14.0413360269933,
            NumberOfUnits = 225
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 25.8790903379578,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Seattle",
            Date = @"2012-04-27T00:00:00",
            Value = 95.3933740013248,
            NumberOfUnits = 408
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 4.93071782632299,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Sofia",
            Date = @"2012-05-09T00:00:00",
            Value = 40.2401977871732,
            NumberOfUnits = 417
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 3.03519638396576,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"London",
            Date = @"2012-05-24T00:00:00",
            Value = 67.7432567196634,
            NumberOfUnits = 221
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 57.5257987983179,
            SellerName = @"Mark Slater",
            SellerCity = @"New York",
            Date = @"2012-06-02T00:00:00",
            Value = 45.3478405928928,
            NumberOfUnits = 288
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 72.2604754717371,
            SellerName = @"Bryan Culver",
            SellerCity = @"Berlin",
            Date = @"2012-06-03T00:00:00",
            Value = 92.7675708163379,
            NumberOfUnits = 372
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 82.5334646657731,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Seattle",
            Date = @"2012-06-03T00:00:00",
            Value = 51.329370518834,
            NumberOfUnits = 408
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 91.5965710261821,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Mellvile",
            Date = @"2012-06-04T00:00:00",
            Value = 28.5261072816914,
            NumberOfUnits = 13
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 94.6682067563144,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Mellvile",
            Date = @"2012-06-05T00:00:00",
            Value = 31.5523860191705,
            NumberOfUnits = 487
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 46.2696579034765,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Sofia",
            Date = @"2012-06-11T00:00:00",
            Value = 85.9149635703838,
            NumberOfUnits = 276
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 18.243998018207,
            SellerName = @"Howard Sprouse",
            SellerCity = @"New York",
            Date = @"2012-06-16T00:00:00",
            Value = 40.2414140013239,
            NumberOfUnits = 490
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 48.7533504370383,
            SellerName = @"Harold Garvin",
            SellerCity = @"London",
            Date = @"2012-06-18T00:00:00",
            Value = 55.6163265163155,
            NumberOfUnits = 238
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 94.4276411991695,
            SellerName = @"David Haley",
            SellerCity = @"Tokyo",
            Date = @"2012-06-23T00:00:00",
            Value = 91.9826045129367,
            NumberOfUnits = 170
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 48.6758573673087,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Mellvile",
            Date = @"2012-07-04T00:00:00",
            Value = 72.7664424910985,
            NumberOfUnits = 132
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 82.6803708834017,
            SellerName = @"Mark Slater",
            SellerCity = @"Mellvile",
            Date = @"2012-07-05T00:00:00",
            Value = 56.7741976849615,
            NumberOfUnits = 443
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 38.1921838215516,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"New York",
            Date = @"2012-07-05T00:00:00",
            Value = 27.4828472768342,
            NumberOfUnits = 368
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 24.194019718186,
            SellerName = @"Harold Garvin",
            SellerCity = @"New York",
            Date = @"2012-07-11T00:00:00",
            Value = 38.5177375928116,
            NumberOfUnits = 39
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 3.98980141803147,
            SellerName = @"Alfredo Fetuchini",
            SellerCity = @"Tokyo",
            Date = @"2012-07-13T00:00:00",
            Value = 43.2370888736272,
            NumberOfUnits = 95
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 81.7707554817995,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"Berlin",
            Date = @"2012-07-14T00:00:00",
            Value = 42.5551266607619,
            NumberOfUnits = 42
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 74.8673559515119,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Seattle",
            Date = @"2012-07-16T00:00:00",
            Value = 61.4280205040369,
            NumberOfUnits = 200
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 85.4673036306479,
            SellerName = @"Monica Freitag",
            SellerCity = @"Seattle",
            Date = @"2012-07-16T00:00:00",
            Value = 10.458307625008,
            NumberOfUnits = 221
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 96.4154026920048,
            SellerName = @"Larry Lieb",
            SellerCity = @"New York",
            Date = @"2012-07-21T00:00:00",
            Value = 99.6392156927098,
            NumberOfUnits = 54
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 46.1994193709453,
            SellerName = @"Lydia Burson",
            SellerCity = @"Tokyo",
            Date = @"2012-07-21T00:00:00",
            Value = 55.9585726149187,
            NumberOfUnits = 173
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 99.8439830261487,
            SellerName = @"Lydia Burson",
            SellerCity = @"London",
            Date = @"2012-07-23T00:00:00",
            Value = 10.8331507122298,
            NumberOfUnits = 47
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 42.3546248312828,
            SellerName = @"Kathe Pettel",
            SellerCity = @"Mellvile",
            Date = @"2012-07-26T00:00:00",
            Value = 91.5450963617978,
            NumberOfUnits = 173
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 52.1983850524753,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Mellvile",
            Date = @"2012-08-05T00:00:00",
            Value = 98.8178437570193,
            NumberOfUnits = 323
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 45.4567000481564,
            SellerName = @"Russell Shorter",
            SellerCity = @"Sofia",
            Date = @"2012-08-07T00:00:00",
            Value = 26.0294280601802,
            NumberOfUnits = 264
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 56.771143552275,
            SellerName = @"Mark Slater",
            SellerCity = @"Sofia",
            Date = @"2012-08-09T00:00:00",
            Value = 11.4886299294832,
            NumberOfUnits = 385
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 3.56508372517539,
            SellerName = @"Harry Tyler",
            SellerCity = @"London",
            Date = @"2012-08-10T00:00:00",
            Value = 25.9519375515878,
            NumberOfUnits = 56
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 34.6018440716908,
            SellerName = @"Benjamin Dupree",
            SellerCity = @"Berlin",
            Date = @"2012-08-12T00:00:00",
            Value = 96.1509631463098,
            NumberOfUnits = 267
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 92.4029229639112,
            SellerName = @"Monica Freitag",
            SellerCity = @"Seattle",
            Date = @"2012-08-14T00:00:00",
            Value = 94.9122598836721,
            NumberOfUnits = 109
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 34.719441707581,
            SellerName = @"Mark Slater",
            SellerCity = @"Berlin",
            Date = @"2012-08-17T00:00:00",
            Value = 62.3832190234136,
            NumberOfUnits = 478
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 23.3355592579281,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"Berlin",
            Date = @"2012-08-21T00:00:00",
            Value = 57.657432163906,
            NumberOfUnits = 184
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 79.522237963752,
            SellerName = @"Brandon Mckim",
            SellerCity = @"Seattle",
            Date = @"2012-08-21T00:00:00",
            Value = 35.3496687185716,
            NumberOfUnits = 132
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 30.645626285414,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Sofia",
            Date = @"2012-08-22T00:00:00",
            Value = 95.9404697157165,
            NumberOfUnits = 142
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 89.8877651383578,
            SellerName = @"Carl Costello",
            SellerCity = @"Seattle",
            Date = @"2012-08-27T00:00:00",
            Value = 27.453476901843,
            NumberOfUnits = 46
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 83.1898490354371,
            SellerName = @"Walter Pang",
            SellerCity = @"Seattle",
            Date = @"2012-09-03T00:00:00",
            Value = 68.6052913165676,
            NumberOfUnits = 102
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 0.103541463661725,
            SellerName = @"Russell Shorter",
            SellerCity = @"Berlin",
            Date = @"2012-09-09T00:00:00",
            Value = 96.5937556683057,
            NumberOfUnits = 21
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 36.629343143026,
            SellerName = @"Monica Freitag",
            SellerCity = @"Sofia",
            Date = @"2012-09-10T00:00:00",
            Value = 4.93063489204768,
            NumberOfUnits = 442
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 92.3085672279394,
            SellerName = @"Harry Tyler",
            SellerCity = @"New York",
            Date = @"2012-09-13T00:00:00",
            Value = 99.2153110910278,
            NumberOfUnits = 254
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 28.0094152912541,
            SellerName = @"Nicholas Carmona",
            SellerCity = @"Sofia",
            Date = @"2012-09-13T00:00:00",
            Value = 49.9100303509785,
            NumberOfUnits = 251
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 60.3017789592509,
            SellerName = @"Antonio Charbonneau",
            SellerCity = @"New York",
            Date = @"2012-09-15T00:00:00",
            Value = 43.9264408982948,
            NumberOfUnits = 119
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Bikes",
            ProductUnitPrice = 33.0077453204467,
            SellerName = @"Claudia Kobayashi",
            SellerCity = @"New York",
            Date = @"2012-09-19T00:00:00",
            Value = 32.4268728645644,
            NumberOfUnits = 256
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 99.0029557603425,
            SellerName = @"John Smith",
            SellerCity = @"New York",
            Date = @"2012-09-23T00:00:00",
            Value = 35.802955709306,
            NumberOfUnits = 456
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 16.1743238177962,
            SellerName = @"Kathe Pettel",
            SellerCity = @"London",
            Date = @"2012-10-01T00:00:00",
            Value = 16.3581453339933,
            NumberOfUnits = 430
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 72.8992714886084,
            SellerName = @"David Haley",
            SellerCity = @"Berlin",
            Date = @"2012-10-02T00:00:00",
            Value = 57.0288074934058,
            NumberOfUnits = 248
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 21.6627069849813,
            SellerName = @"Harold Garvin",
            SellerCity = @"Berlin",
            Date = @"2012-10-18T00:00:00",
            Value = 28.2381287907428,
            NumberOfUnits = 440
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 28.3422471156075,
            SellerName = @"Howard Sprouse",
            SellerCity = @"New York",
            Date = @"2012-10-19T00:00:00",
            Value = 66.6415263743333,
            NumberOfUnits = 234
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 80.4687102234311,
            SellerName = @"Benjamin Meekins",
            SellerCity = @"New York",
            Date = @"2012-10-25T00:00:00",
            Value = 5.25946072547671,
            NumberOfUnits = 36
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Accessories",
            ProductUnitPrice = 97.6860876184358,
            SellerName = @"Harry Tyler",
            SellerCity = @"London",
            Date = @"2012-10-26T00:00:00",
            Value = 41.23381168639,
            NumberOfUnits = 46
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 88.7001933011693,
            SellerName = @"Elisa Longbottom",
            SellerCity = @"London",
            Date = @"2012-11-02T00:00:00",
            Value = 64.5666572100328,
            NumberOfUnits = 211
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Clothing",
            ProductUnitPrice = 67.2612272050517,
            SellerName = @"Walter Pang",
            SellerCity = @"New York",
            Date = @"2012-11-17T00:00:00",
            Value = 14.1893965723875,
            NumberOfUnits = 408
        });
        this.Add(new PivotDataFlatItem()
        {
            ProductName = @"Components",
            ProductUnitPrice = 7.14569050220106,
            SellerName = @"Walter Pang",
            SellerCity = @"New York",
            Date = @"2012-11-20T00:00:00",
            Value = 72.7793859656804,
            NumberOfUnits = 376
        });
    }
}
