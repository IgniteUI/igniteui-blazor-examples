using System;
using System.Collections.Generic;
public class CompanyDataItem
{
    public string _id { get; set; }
    public string Company { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public double Sales_lifetimeSales { get; set; }
    public double Sales_quarterlySales { get; set; }
    public double Sales_yearlySales { get; set; }
    public double Sales_marketPotential { get; set; }
    public double Assets_cash { get; set; }
    public double Assets_accRec { get; set; }
    public double Assets_books { get; set; }
}

public class CompanyData
    : List<CompanyDataItem>
{
    public CompanyData()
    {
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee0991a4474f9ae631de",
            company = @"Sportan",
            address = @"Rapelye Street",
            city = @"Oceola",
            country = @"VU",
            sales_lifetimeSales = 40882580.18,
            sales_quarterlySales = 430845.78,
            sales_yearlySales = 1197420.17,
            sales_marketPotential = 4210805124.61,
            assets_cash = 264714.71,
            assets_accRec = 63084.44,
            assets_books = 7534.74
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee09577c39def103f509",
            company = @"Bugsall",
            address = @"Hoyt Street",
            city = @"Rosine",
            country = @"FM",
            sales_lifetimeSales = 29231147.89,
            sales_quarterlySales = 227299.97,
            sales_yearlySales = 1486467.06,
            sales_marketPotential = 2505447478.96,
            assets_cash = 370690.39,
            assets_accRec = 69242.24,
            assets_books = 12507.92
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee0924d0092051d8d45e",
            company = @"Hydrocom",
            address = @"Sunnyside Court",
            city = @"Cornfields",
            country = @"KE",
            sales_lifetimeSales = 35628528.18,
            sales_quarterlySales = 226007.91,
            sales_yearlySales = 1092555.78,
            sales_marketPotential = 4930069033.99,
            assets_cash = 403038.64,
            assets_accRec = 56183.05,
            assets_books = 8113.52
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee09115c6a228f3c8ae0",
            company = @"Eclipto",
            address = @"Remsen Avenue",
            city = @"Orin",
            country = @"TZ",
            sales_lifetimeSales = 20178683.42,
            sales_quarterlySales = 319645.81,
            sales_yearlySales = 1249194.57,
            sales_marketPotential = 2488740024.16,
            assets_cash = 237368.76,
            assets_accRec = 50048.48,
            assets_books = 13100.31
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee092ffa293f8ba4acd4",
            company = @"Paprikut",
            address = @"Bay Parkway",
            city = @"Motley",
            country = @"LR",
            sales_lifetimeSales = 25575955.42,
            sales_quarterlySales = 347046.85,
            sales_yearlySales = 1611555.66,
            sales_marketPotential = 1923959087.58,
            assets_cash = 235064.57,
            assets_accRec = 74596.25,
            assets_books = 17057.85
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee094e10ebac49bb3445",
            company = @"Unia",
            address = @"Richards Street",
            city = @"Herlong",
            country = @"DZ",
            sales_lifetimeSales = 13462122.23,
            sales_quarterlySales = 368636.73,
            sales_yearlySales = 489642.54,
            sales_marketPotential = 1679474693.72,
            assets_cash = 498174.1,
            assets_accRec = 92476.88,
            assets_books = 6961.9
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee09cf079a741a75fd81",
            company = @"Isologix",
            address = @"Williams Court",
            city = @"Marysville",
            country = @"JO",
            sales_lifetimeSales = 38448387.27,
            sales_quarterlySales = 298248.71,
            sales_yearlySales = 1904695.32,
            sales_marketPotential = 4696918929,
            assets_cash = 383266.93,
            assets_accRec = 76247.35,
            assets_books = 6818.03
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee091e9883c0d1f77f99",
            company = @"Deepends",
            address = @"Independence Avenue",
            city = @"Riegelwood",
            country = @"NO",
            sales_lifetimeSales = 13730298.02,
            sales_quarterlySales = 323612.72,
            sales_yearlySales = 953860.54,
            sales_marketPotential = 4825809829.87,
            assets_cash = 416146.08,
            assets_accRec = 62282.5,
            assets_books = 13686.42
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee098c5bd0d8806720c1",
            company = @"Quantasis",
            address = @"Berriman Street",
            city = @"Unionville",
            country = @"ID",
            sales_lifetimeSales = 19875841.19,
            sales_quarterlySales = 468274.38,
            sales_yearlySales = 1569184.18,
            sales_marketPotential = 3489758844.49,
            assets_cash = 415699.26,
            assets_accRec = 54628.5,
            assets_books = 19321.38
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee0913724154a512e5ee",
            company = @"Playce",
            address = @"India Street",
            city = @"Joppa",
            country = @"VI",
            sales_lifetimeSales = 45960329.03,
            sales_quarterlySales = 448358.99,
            sales_yearlySales = 1855678.13,
            sales_marketPotential = 2740892152.3,
            assets_cash = 447054.49,
            assets_accRec = 69204.65,
            assets_books = 23522.18
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee0978ab727bc193509a",
            company = @"Ezent",
            address = @"Decatur Street",
            city = @"Lithium",
            country = @"CV",
            sales_lifetimeSales = 43613913.07,
            sales_quarterlySales = 140288.25,
            sales_yearlySales = 594517.52,
            sales_marketPotential = 1419141218.99,
            assets_cash = 324254.03,
            assets_accRec = 78826.89,
            assets_books = 20581.79
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee097125fd1d983d9cf9",
            company = @"Corepan",
            address = @"Jefferson Street",
            city = @"Roland",
            country = @"CA",
            sales_lifetimeSales = 19334236.7,
            sales_quarterlySales = 413597.57,
            sales_yearlySales = 1871048.41,
            sales_marketPotential = 3524818686.77,
            assets_cash = 464374.02,
            assets_accRec = 68634.68,
            assets_books = 16572.39
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee09acab49d850a7d3f6",
            company = @"Quonata",
            address = @"Bristol Street",
            city = @"Belgreen",
            country = @"ER",
            sales_lifetimeSales = 21467135.56,
            sales_quarterlySales = 224717.89,
            sales_yearlySales = 657562.96,
            sales_marketPotential = 3686684834.77,
            assets_cash = 345941.49,
            assets_accRec = 51842.73,
            assets_books = 12948.79
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee099a657c6397d619bd",
            company = @"Empirica",
            address = @"Eaton Court",
            city = @"Hampstead",
            country = @"LY",
            sales_lifetimeSales = 21711544.57,
            sales_quarterlySales = 290740.22,
            sales_yearlySales = 1202336.44,
            sales_marketPotential = 2343942535.11,
            assets_cash = 331479.28,
            assets_accRec = 61027.27,
            assets_books = 6199.99
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee09cf6d97f31dd4b625",
            company = @"Eventix",
            address = @"Gain Court",
            city = @"Dowling",
            country = @"NG",
            sales_lifetimeSales = 27108803.74,
            sales_quarterlySales = 322969.25,
            sales_yearlySales = 951465.66,
            sales_marketPotential = 4841022751.3,
            assets_cash = 287818.89,
            assets_accRec = 79152.96,
            assets_books = 9047.59
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee094f28ff8ab6f86dde",
            company = @"Dogspa",
            address = @"Quay Street",
            city = @"Marne",
            country = @"TW",
            sales_lifetimeSales = 15372014.44,
            sales_quarterlySales = 376294.9,
            sales_yearlySales = 978453.71,
            sales_marketPotential = 1275418042.2,
            assets_cash = 374628.65,
            assets_accRec = 84888.29,
            assets_books = 20578.59
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee0997dfe157acaa78bb",
            company = @"Jumpstack",
            address = @"Quincy Street",
            city = @"Hobucken",
            country = @"CF",
            sales_lifetimeSales = 38882346.28,
            sales_quarterlySales = 140607.23,
            sales_yearlySales = 1197166.82,
            sales_marketPotential = 4820347822.28,
            assets_cash = 231516.29,
            assets_accRec = 87415.74,
            assets_books = 12896.54
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee0972c9c1187bb0d97d",
            company = @"Sybixtex",
            address = @"Ryder Street",
            city = @"Alderpoint",
            country = @"IO",
            sales_lifetimeSales = 21445732.45,
            sales_quarterlySales = 369036.23,
            sales_yearlySales = 499606.34,
            sales_marketPotential = 2807389991.36,
            assets_cash = 408474.47,
            assets_accRec = 65344.38,
            assets_books = 8862.63
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee098a4166f0a5a19993",
            company = @"Dognosis",
            address = @"Wolcott Street",
            city = @"Edgewater",
            country = @"GL",
            sales_lifetimeSales = 41661881.98,
            sales_quarterlySales = 141108.09,
            sales_yearlySales = 522969.48,
            sales_marketPotential = 4374478218.15,
            assets_cash = 225730.61,
            assets_accRec = 72839.21,
            assets_books = 8728.07
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee091384f263dc9b8c25",
            company = @"Twiggery",
            address = @"Irwin Street",
            city = @"Blackgum",
            country = @"ZM",
            sales_lifetimeSales = 36017506.06,
            sales_quarterlySales = 354562.4,
            sales_yearlySales = 1449893.92,
            sales_marketPotential = 1948021644.72,
            assets_cash = 376383.08,
            assets_accRec = 62385.03,
            assets_books = 14270.75
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee097fe9366d90a9066e",
            company = @"Bizmatic",
            address = @"Jerome Street",
            city = @"Sylvanite",
            country = @"MM",
            sales_lifetimeSales = 11722193.14,
            sales_quarterlySales = 213212.65,
            sales_yearlySales = 1310614.58,
            sales_marketPotential = 3463018300.01,
            assets_cash = 252123.01,
            assets_accRec = 57229.43,
            assets_books = 19165.76
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee09cb68c764dd8f5d23",
            company = @"Accel",
            address = @"Louisiana Avenue",
            city = @"Cornucopia",
            country = @"IE",
            sales_lifetimeSales = 27607249.98,
            sales_quarterlySales = 236774.12,
            sales_yearlySales = 1546611.47,
            sales_marketPotential = 2024251139.72,
            assets_cash = 294508.31,
            assets_accRec = 71612.5,
            assets_books = 18155.66
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee0918539a10bcaf6432",
            company = @"Brainquil",
            address = @"Tompkins Avenue",
            city = @"Hanover",
            country = @"MX",
            sales_lifetimeSales = 25699331.36,
            sales_quarterlySales = 186296.88,
            sales_yearlySales = 736119.79,
            sales_marketPotential = 1098592989.14,
            assets_cash = 321341.22,
            assets_accRec = 82055.95,
            assets_books = 10149.55
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee09dbdd0ea1d711b0cd",
            company = @"Eplode",
            address = @"Desmond Court",
            city = @"Lupton",
            country = @"GA",
            sales_lifetimeSales = 22446181.35,
            sales_quarterlySales = 346390.58,
            sales_yearlySales = 712190.68,
            sales_marketPotential = 2534215258.43,
            assets_cash = 266537.14,
            assets_accRec = 87164.54,
            assets_books = 24489.71
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee09d24e7b07dbfef583",
            company = @"Crustatia",
            address = @"Woodhull Street",
            city = @"Conestoga",
            country = @"GR",
            sales_lifetimeSales = 48060275.78,
            sales_quarterlySales = 319385.17,
            sales_yearlySales = 1662973.16,
            sales_marketPotential = 3562317203.73,
            assets_cash = 471269.15,
            assets_accRec = 98834.5,
            assets_books = 10641.41
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee093799fdc7340a9990",
            company = @"Buzzness",
            address = @"Guider Avenue",
            city = @"Gratton",
            country = @"MD",
            sales_lifetimeSales = 26377352.6,
            sales_quarterlySales = 439844.54,
            sales_yearlySales = 601430.59,
            sales_marketPotential = 1486755775.28,
            assets_cash = 252524.24,
            assets_accRec = 51795.96,
            assets_books = 10315.84
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee09b0bb9191f759ae94",
            company = @"Helixo",
            address = @"Logan Street",
            city = @"Broadlands",
            country = @"RE",
            sales_lifetimeSales = 31633703.02,
            sales_quarterlySales = 256392.06,
            sales_yearlySales = 602291.9,
            sales_marketPotential = 4323633265.68,
            assets_cash = 468025.56,
            assets_accRec = 95638.46,
            assets_books = 22985.41
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee099f65226772e2616e",
            company = @"Geekosis",
            address = @"Dictum Court",
            city = @"Bellamy",
            country = @"NF",
            sales_lifetimeSales = 29268437.79,
            sales_quarterlySales = 147691.1,
            sales_yearlySales = 1691764.93,
            sales_marketPotential = 1362207226.45,
            assets_cash = 434628.23,
            assets_accRec = 66871.54,
            assets_books = 12574.59
        });
        this.Add(new CompanyDataItem()
        {
            _id = @"56c2ee093096177f7e7cc9c3",
            company = @"Zipak",
            address = @"Hendrix Street",
            city = @"Enetai",
            country = @"MH",
            sales_lifetimeSales = 18691983.29,
            sales_quarterlySales = 218666.54,
            sales_yearlySales = 1038077.26,
            sales_marketPotential = 1362313421.44,
            assets_cash = 276294.7,
            assets_accRec = 59302.02,
            assets_books = 11183.04
        });
    }
}
