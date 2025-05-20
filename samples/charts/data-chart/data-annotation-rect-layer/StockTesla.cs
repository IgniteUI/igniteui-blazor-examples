using System;
using System.Collections.Generic;
public class StockTeslaItem
{
    public string Date { get; set; }
    public double Open { get; set; }
    public double High { get; set; }
    public double Low { get; set; }
    public double Close { get; set; }
    public double Volume { get; set; }
    public double Change { get; set; }
    public double Index { get; set; }
}

public class StockTesla
    : List<StockTeslaItem>
{
    public StockTesla()
    {
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-01-10",
            Open = 20.4,
            High = 23,
            Low = 19.8,
            Close = 23,
            Volume = 779333701,
            Change = 12.7,
            Index = 0
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-01-22",
            Open = 22.8,
            High = 23.5,
            Low = 19.7,
            Close = 19.9,
            Volume = 911781100,
            Change = -12.6,
            Index = 1
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-01-31",
            Open = 19.5,
            High = 20.8,
            Low = 18.6,
            Close = 20.5,
            Volume = 926375717,
            Change = 5,
            Index = 2
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-02-11",
            Open = 20.4,
            High = 21.6,
            Low = 19.9,
            Close = 20.9,
            Volume = 687520471,
            Change = 2.4,
            Index = 3
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-02-21",
            Open = 21.1,
            High = 21.2,
            Low = 19.4,
            Close = 19.4,
            Volume = 597552272,
            Change = -7.9,
            Index = 4
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-03-04",
            Open = 19.6,
            High = 21.3,
            Low = 18.9,
            Close = 19,
            Volume = 1218669201,
            Change = -3.1,
            Index = 5
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-03-13",
            Open = 18.8,
            High = 19.5,
            Low = 18,
            Close = 19.3,
            Volume = 1034156904,
            Change = 2.5,
            Index = 6
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-03-22",
            Open = 19.5,
            High = 19.7,
            Low = 17.6,
            Close = 17.6,
            Volume = 980694095,
            Change = -9.5,
            Index = 7
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-04-02",
            Open = 17.3,
            High = 19.3,
            Low = 17,
            Close = 19.1,
            Volume = 788473494,
            Change = 10.1,
            Index = 8
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-04-11",
            Open = 19.2,
            High = 19.7,
            Low = 17.4,
            Close = 17.9,
            Volume = 1165555442,
            Change = -6.6,
            Index = 9
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-04-23",
            Open = 18,
            High = 18.3,
            Low = 17,
            Close = 17.6,
            Volume = 870373200,
            Change = -2.3,
            Index = 10
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-05-02",
            Open = 17.6,
            High = 17.7,
            Low = 15.4,
            Close = 16.3,
            Volume = 1629432326,
            Change = -7.5,
            Index = 11
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-05-13",
            Open = 16.3,
            High = 17.2,
            Low = 15,
            Close = 15.1,
            Volume = 1131045605,
            Change = -6.9,
            Index = 12
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-05-22",
            Open = 15.3,
            High = 15.6,
            Low = 12.8,
            Close = 12.8,
            Volume = 1455503588,
            Change = -15.9,
            Index = 13
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-06-03",
            Open = 13,
            High = 13.3,
            Low = 11.8,
            Close = 11.9,
            Volume = 1415442268,
            Change = -7.9,
            Index = 14
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-06-12",
            Open = 12.1,
            High = 14.9,
            Low = 12,
            Close = 14,
            Volume = 1515000443,
            Change = 15.6,
            Index = 15
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-06-21",
            Open = 14,
            High = 15.6,
            Low = 13.8,
            Close = 14.8,
            Volume = 1009123371,
            Change = 5.5,
            Index = 16
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-07-02",
            Open = 14.9,
            High = 15.5,
            Low = 14.5,
            Close = 15,
            Volume = 766921642,
            Change = 0.6,
            Index = 17
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-07-12",
            Open = 16,
            High = 16.4,
            Low = 15.2,
            Close = 16.3,
            Volume = 887983836,
            Change = 2.4,
            Index = 18
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-07-23",
            Open = 16.5,
            High = 17.5,
            Low = 16.3,
            Close = 17.3,
            Volume = 788941000,
            Change = 4.9,
            Index = 19
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-08-01",
            Open = 17.3,
            High = 17.7,
            Low = 14.8,
            Close = 15.6,
            Volume = 1175082297,
            Change = -9.8,
            Index = 20
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-08-12",
            Open = 15.4,
            High = 16,
            Low = 15,
            Close = 15.3,
            Volume = 560129569,
            Change = -1,
            Index = 21
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-08-21",
            Open = 15.3,
            High = 15.7,
            Low = 14.1,
            Close = 14.7,
            Volume = 677293701,
            Change = -3.5,
            Index = 22
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-08-30",
            Open = 14.9,
            High = 15.5,
            Low = 14.1,
            Close = 15,
            Volume = 650239370,
            Change = 1.3,
            Index = 23
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-09-11",
            Open = 14.9,
            High = 16.5,
            Low = 14.6,
            Close = 16.5,
            Volume = 636766167,
            Change = 10.3,
            Index = 24
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-09-20",
            Open = 16.5,
            High = 16.9,
            Low = 15.9,
            Close = 16,
            Volume = 572802643,
            Change = -2.9,
            Index = 25
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-10-01",
            Open = 16,
            High = 16.6,
            Low = 14.6,
            Close = 16.3,
            Volume = 931821239,
            Change = 2,
            Index = 26
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-10-10",
            Open = 16.2,
            High = 16.6,
            Low = 15,
            Close = 16.3,
            Volume = 891798049,
            Change = 0.6,
            Index = 27
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-10-21",
            Open = 16.5,
            High = 17.7,
            Low = 16.5,
            Close = 16.9,
            Volume = 713093463,
            Change = 2.6,
            Index = 28
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-10-30",
            Open = 17,
            High = 22.7,
            Low = 16.7,
            Close = 21,
            Volume = 1752943598,
            Change = 23.9,
            Index = 29
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-11-08",
            Open = 20.9,
            High = 22.8,
            Low = 20.6,
            Close = 22.5,
            Volume = 834957256,
            Change = 7.7,
            Index = 30
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-11-19",
            Open = 22.9,
            High = 24,
            Low = 22.8,
            Close = 24,
            Volume = 738746390,
            Change = 4.5,
            Index = 31
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-11-29",
            Open = 24,
            High = 24.1,
            Low = 21.8,
            Close = 22,
            Volume = 870685288,
            Change = -8.4,
            Index = 32
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-12-10",
            Open = 22,
            High = 23.4,
            Low = 21.8,
            Close = 23.3,
            Volume = 712016613,
            Change = 5.9,
            Index = 33
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-12-19",
            Open = 23.5,
            High = 27.1,
            Low = 23.4,
            Close = 26.9,
            Volume = 1203765433,
            Change = 14.8,
            Index = 34
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2019-12-31",
            Open = 27.4,
            High = 29,
            Low = 26.7,
            Close = 27.9,
            Volume = 1195073357,
            Change = 2,
            Index = 35
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-01-10",
            Open = 28.3,
            High = 33.3,
            Low = 28.1,
            Close = 31.9,
            Volume = 1925386078,
            Change = 12.6,
            Index = 36
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-01-22",
            Open = 32.9,
            High = 39.6,
            Low = 32.8,
            Close = 38,
            Volume = 2364043518,
            Change = 15.4,
            Index = 37
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-01-31",
            Open = 37.6,
            High = 43.5,
            Low = 36,
            Close = 43.4,
            Volume = 1835141382,
            Change = 15.3,
            Index = 38
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-02-11",
            Open = 44.9,
            High = 64.6,
            Low = 44.9,
            Close = 51.6,
            Volume = 3748903126,
            Change = 14.9,
            Index = 39
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-02-21",
            Open = 51.9,
            High = 63,
            Low = 49,
            Close = 60.1,
            Volume = 1921517039,
            Change = 15.8,
            Index = 40
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-03-03",
            Open = 55.9,
            High = 57.6,
            Low = 40.8,
            Close = 49.7,
            Volume = 2121850940,
            Change = -11.1,
            Index = 41
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-03-12",
            Open = 50.9,
            High = 51.1,
            Low = 36.4,
            Close = 37.4,
            Volume = 1553329923,
            Change = -26.6,
            Index = 42
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-03-23",
            Open = 39.7,
            High = 40.5,
            Low = 23.4,
            Close = 29,
            Volume = 2487688157,
            Change = -27,
            Index = 43
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-04-01",
            Open = 31.8,
            High = 37.3,
            Low = 31.6,
            Close = 32.1,
            Volume = 1785601357,
            Change = 0.9,
            Index = 44
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-04-13",
            Open = 32.1,
            High = 43.5,
            Low = 29.8,
            Close = 43.4,
            Volume = 1860352620,
            Change = 35.3,
            Index = 45
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-04-22",
            Open = 46.6,
            High = 51.7,
            Low = 44.9,
            Close = 48.8,
            Volume = 2056797321,
            Change = 4.7,
            Index = 46
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-05-01",
            Open = 48.5,
            High = 58,
            Low = 45.5,
            Close = 46.8,
            Volume = 2093959203,
            Change = -3.6,
            Index = 47
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-05-12",
            Open = 46.7,
            High = 56.2,
            Low = 46.5,
            Close = 54,
            Volume = 1611543246,
            Change = 15.5,
            Index = 48
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-05-21",
            Open = 54.7,
            High = 55.6,
            Low = 50.9,
            Close = 55.2,
            Volume = 1262468113,
            Change = 0.8,
            Index = 49
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-06-02",
            Open = 54.8,
            High = 60.6,
            Low = 52.3,
            Close = 58.8,
            Volume = 1160487993,
            Change = 7.2,
            Index = 50
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-06-11",
            Open = 59.2,
            High = 68.5,
            Low = 57.2,
            Close = 64.9,
            Volume = 1270377400,
            Change = 9.5,
            Index = 51
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-06-22",
            Open = 65.3,
            High = 67.9,
            Low = 60.6,
            Close = 66.3,
            Volume = 1217946366,
            Change = 1.5,
            Index = 52
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-07-01",
            Open = 66.6,
            High = 75.7,
            Low = 62.5,
            Close = 74.6,
            Volume = 1120591270,
            Change = 12.1,
            Index = 53
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-07-13",
            Open = 81.4,
            High = 119.7,
            Low = 79,
            Close = 99.8,
            Volume = 2244920779,
            Change = 22.6,
            Index = 54
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-07-22",
            Open = 103.7,
            High = 111.7,
            Low = 95.4,
            Close = 106.2,
            Volume = 1662846099,
            Change = 2.3,
            Index = 55
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-07-31",
            Open = 111.9,
            High = 112.6,
            Low = 91.1,
            Close = 95.4,
            Volume = 1573159944,
            Change = -14.8,
            Index = 56
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-08-11",
            Open = 96.6,
            High = 101.8,
            Low = 91,
            Close = 91.6,
            Volume = 798587331,
            Change = -5.2,
            Index = 57
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-08-20",
            Open = 98,
            High = 134.8,
            Low = 95.7,
            Close = 133.5,
            Volume = 1866534416,
            Change = 36.2,
            Index = 58
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-08-31",
            Open = 136.3,
            High = 166.7,
            Low = 128.5,
            Close = 166.1,
            Volume = 2008507459,
            Change = 21.9,
            Index = 59
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-09-10",
            Open = 167.4,
            High = 167.5,
            Low = 110,
            Close = 123.8,
            Volume = 1992227059,
            Change = -26,
            Index = 60
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-09-21",
            Open = 127.3,
            High = 154,
            Low = 120.2,
            Close = 149.8,
            Volume = 1758737696,
            Change = 17.7,
            Index = 61
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-09-30",
            Open = 143.2,
            High = 145.9,
            Low = 117.1,
            Close = 143,
            Volume = 1459893236,
            Change = -0.1,
            Index = 62
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-10-09",
            Open = 146.9,
            High = 149.6,
            Low = 135.4,
            Close = 144.7,
            Volume = 985545158,
            Change = -1.5,
            Index = 63
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-10-20",
            Open = 147.3,
            High = 155.3,
            Low = 139.7,
            Close = 140.6,
            Volume = 773077727,
            Change = -4.5,
            Index = 64
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-10-29",
            Open = 140.9,
            High = 148.4,
            Low = 135.3,
            Close = 136.9,
            Volume = 615339122,
            Change = -2.8,
            Index = 65
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-11-09",
            Open = 135.6,
            High = 150.8,
            Low = 126.4,
            Close = 140.4,
            Volume = 669171368,
            Change = 3.5,
            Index = 66
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-11-18",
            Open = 140,
            High = 165.3,
            Low = 132,
            Close = 162.2,
            Volume = 760451265,
            Change = 15.8,
            Index = 67
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-11-30",
            Open = 164,
            High = 202.6,
            Low = 162.5,
            Close = 189.2,
            Volume = 1046371155,
            Change = 15.4,
            Index = 68
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-12-09",
            Open = 199.2,
            High = 218.1,
            Low = 180.4,
            Close = 201.5,
            Volume = 1055933265,
            Change = 1.2,
            Index = 69
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-12-18",
            Open = 191.5,
            High = 231.7,
            Low = 188.8,
            Close = 231.7,
            Volume = 1593943601,
            Change = 21,
            Index = 70
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2020-12-30",
            Open = 222.1,
            High = 232.2,
            Low = 204.7,
            Close = 231.6,
            Volume = 791942570,
            Change = 4.3,
            Index = 71
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-01-11",
            Open = 233.3,
            High = 294.8,
            Low = 230.4,
            Close = 270.4,
            Volume = 1084025779,
            Change = 15.9,
            Index = 72
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-01-21",
            Open = 277,
            High = 289.3,
            Low = 273,
            Close = 281.7,
            Volume = 663774487,
            Change = 1.7,
            Index = 73
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-02-01",
            Open = 278.1,
            High = 300.1,
            Low = 260,
            Close = 279.9,
            Volume = 595397009,
            Change = 0.7,
            Index = 74
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-02-10",
            Open = 281.6,
            High = 293.5,
            Low = 266.7,
            Close = 268.3,
            Volume = 445813486,
            Change = -4.7,
            Index = 75
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-02-22",
            Open = 270.8,
            High = 276.6,
            Low = 236.7,
            Close = 238.2,
            Volume = 496372009,
            Change = -12.1,
            Index = 76
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-03-03",
            Open = 220.7,
            High = 290.7,
            Low = 206.3,
            Close = 217.7,
            Volume = 793689739,
            Change = -1.3,
            Index = 77
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-03-12",
            Open = 218.6,
            High = 291.3,
            Low = 179.8,
            Close = 231.2,
            Volume = 1215209162,
            Change = 5.8,
            Index = 78
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-03-23",
            Open = 231.4,
            High = 237.7,
            Low = 208.2,
            Close = 220.7,
            Volume = 744776145,
            Change = -4.6,
            Index = 79
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-04-01",
            Open = 222.6,
            High = 230.8,
            Low = 197,
            Close = 220.6,
            Volume = 730733684,
            Change = -0.9,
            Index = 80
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-04-13",
            Open = 235.9,
            High = 254.3,
            Low = 222.6,
            Close = 254.1,
            Volume = 646721884,
            Change = 7.7,
            Index = 81
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-04-22",
            Open = 256.9,
            High = 260.3,
            Low = 230.6,
            Close = 239.9,
            Volume = 740840774,
            Change = -6.6,
            Index = 82
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-05-03",
            Open = 239.9,
            High = 249.8,
            Low = 222,
            Close = 228.3,
            Volume = 623423313,
            Change = -4.8,
            Index = 83
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-05-12",
            Open = 226.3,
            High = 230,
            Low = 195.6,
            Close = 196.6,
            Volume = 643844974,
            Change = -13.1,
            Index = 84
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-05-21",
            Open = 200.5,
            High = 202.2,
            Low = 182.3,
            Close = 193.6,
            Volume = 729192883,
            Change = -3.4,
            Index = 85
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-06-02",
            Open = 193.9,
            High = 211.9,
            Low = 191.2,
            Close = 201.7,
            Volume = 545095944,
            Change = 4,
            Index = 86
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-06-11",
            Open = 200.6,
            High = 207.7,
            Low = 190.4,
            Close = 203.3,
            Volume = 478366128,
            Change = 1.3,
            Index = 87
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-06-22",
            Open = 204.1,
            High = 210.5,
            Low = 197.8,
            Close = 207.9,
            Volume = 454698495,
            Change = 1.9,
            Index = 88
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-07-01",
            Open = 210.7,
            High = 232.5,
            Low = 210,
            Close = 226,
            Volume = 558441596,
            Change = 7.3,
            Index = 89
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-07-13",
            Open = 226.3,
            High = 233.3,
            Low = 206.8,
            Close = 222.8,
            Volume = 470942387,
            Change = -1.5,
            Index = 90
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-07-22",
            Open = 223.6,
            High = 226.2,
            Low = 207.1,
            Close = 216.4,
            Volume = 372195097,
            Change = -3.2,
            Index = 91
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-08-02",
            Open = 215.5,
            High = 242.3,
            Low = 209.1,
            Close = 236.6,
            Volume = 547284685,
            Change = 9.8,
            Index = 92
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-08-11",
            Open = 239.7,
            High = 241.6,
            Low = 232.5,
            Close = 235.9,
            Volume = 315341455,
            Change = -1.6,
            Index = 93
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-08-20",
            Open = 235.4,
            High = 243.3,
            Low = 216.3,
            Close = 226.8,
            Volume = 392227478,
            Change = -3.7,
            Index = 94
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-08-31",
            Open = 228.5,
            High = 246.8,
            Low = 226.9,
            Close = 245.2,
            Volume = 337503634,
            Change = 7.3,
            Index = 95
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-09-10",
            Open = 244.7,
            High = 254.8,
            Low = 241.4,
            Close = 245.4,
            Volume = 328100734,
            Change = 0.3,
            Index = 96
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-09-21",
            Open = 246.7,
            High = 253.7,
            Low = 236.3,
            Close = 246.5,
            Volume = 420153012,
            Change = -0.1,
            Index = 97
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-09-30",
            Open = 247.8,
            High = 266.3,
            Low = 246.4,
            Close = 258.5,
            Volume = 422393262,
            Change = 4.3,
            Index = 98
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-10-11",
            Open = 259.5,
            High = 269,
            Low = 254.5,
            Close = 264,
            Volume = 392144589,
            Change = 1.7,
            Index = 99
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-10-20",
            Open = 267,
            High = 292.6,
            Low = 265.5,
            Close = 288.6,
            Volume = 368796877,
            Change = 8.1,
            Index = 100
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-10-29",
            Open = 285.3,
            High = 371.7,
            Low = 285.2,
            Close = 371.3,
            Volume = 825862313,
            Change = 30.1,
            Index = 101
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-11-09",
            Open = 381.7,
            High = 414.5,
            Low = 337.2,
            Close = 341.2,
            Volume = 818978542,
            Change = -10.6,
            Index = 102
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-11-18",
            Open = 336.8,
            High = 373.2,
            Low = 326.2,
            Close = 365.5,
            Volume = 613304311,
            Change = 8.5,
            Index = 103
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-11-30",
            Open = 366.3,
            High = 400.6,
            Low = 354,
            Close = 381.6,
            Volume = 515052382,
            Change = 4.2,
            Index = 104
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-12-09",
            Open = 386.9,
            High = 390.9,
            Low = 316.8,
            Close = 334.6,
            Volume = 473333567,
            Change = -13.5,
            Index = 105
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-12-20",
            Open = 336.2,
            High = 340.3,
            Low = 297.8,
            Close = 300,
            Volume = 524367113,
            Change = -10.8,
            Index = 106
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2021-12-30",
            Open = 305.6,
            High = 373,
            Low = 295.4,
            Close = 356.8,
            Volume = 492530059,
            Change = 16.7,
            Index = 107
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-01-10",
            Open = 357.8,
            High = 402.7,
            Low = 326.7,
            Close = 352.7,
            Volume = 592103938,
            Change = -1.4,
            Index = 108
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-01-20",
            Open = 351.2,
            High = 371.9,
            Low = 331.3,
            Close = 332.1,
            Volume = 532857144,
            Change = -5.4,
            Index = 109
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-01-31",
            Open = 332.1,
            High = 334.8,
            Low = 264,
            Close = 312.2,
            Volume = 833589022,
            Change = -6,
            Index = 110
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-02-09",
            Open = 311.7,
            High = 315.9,
            Low = 293.5,
            Close = 310.7,
            Volume = 456395505,
            Change = -0.3,
            Index = 111
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-02-18",
            Open = 302.8,
            High = 314.6,
            Low = 279.2,
            Close = 285.7,
            Volume = 446153356,
            Change = -5.7,
            Index = 112
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-03-02",
            Open = 278,
            High = 296.6,
            Low = 233.3,
            Close = 293.3,
            Volume = 638352514,
            Change = 5.5,
            Index = 113
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-03-11",
            Open = 292.9,
            High = 295.5,
            Low = 260.7,
            Close = 265.1,
            Volume = 466566467,
            Change = -9.5,
            Index = 114
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-03-22",
            Open = 260.2,
            High = 332.6,
            Low = 252,
            Close = 331.3,
            Volume = 576869668,
            Change = 27.3,
            Index = 115
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-03-31",
            Open = 326.6,
            High = 371.6,
            Low = 325.5,
            Close = 359.2,
            Volume = 536607263,
            Change = 10,
            Index = 116
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-04-11",
            Open = 360.4,
            High = 384.3,
            Low = 324.9,
            Close = 325.3,
            Volume = 499682510,
            Change = -9.7,
            Index = 117
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-04-21",
            Open = 332.5,
            High = 364.1,
            Low = 324.4,
            Close = 336.3,
            Volume = 457210487,
            Change = 1.1,
            Index = 118
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-05-02",
            Open = 338.3,
            High = 345,
            Low = 273.9,
            Close = 301,
            Volume = 639990965,
            Change = -11,
            Index = 119
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-05-11",
            Open = 301.1,
            High = 318.5,
            Low = 242.4,
            Close = 244.7,
            Volume = 583211967,
            Change = -18.7,
            Index = 120
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-05-20",
            Open = 233.7,
            High = 262.4,
            Low = 211,
            Close = 221.3,
            Volume = 721880082,
            Change = -5.3,
            Index = 121
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-06-01",
            Open = 218.3,
            High = 259.6,
            Low = 206.9,
            Close = 246.8,
            Volume = 644596235,
            Change = 13,
            Index = 122
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-06-10",
            Open = 244.2,
            High = 264.2,
            Low = 227.9,
            Close = 232.2,
            Volume = 633672873,
            Change = -4.9,
            Index = 123
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-06-22",
            Open = 223.2,
            High = 246.8,
            Low = 208.7,
            Close = 236.1,
            Volume = 744240764,
            Change = 5.8,
            Index = 124
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-07-01",
            Open = 237.9,
            High = 252.1,
            Low = 218.9,
            Close = 227.3,
            Volume = 631776422,
            Change = -4.5,
            Index = 125
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-07-13",
            Open = 223,
            High = 255,
            Low = 216.2,
            Close = 237,
            Volume = 625812242,
            Change = 6.3,
            Index = 126
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-07-22",
            Open = 234.9,
            High = 280.8,
            Low = 229.3,
            Close = 272.2,
            Volume = 646037224,
            Change = 15.9,
            Index = 127
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-08-02",
            Open = 272.2,
            High = 311.9,
            Low = 256.3,
            Close = 300.6,
            Volume = 611660612,
            Change = 10.4,
            Index = 128
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-08-11",
            Open = 305,
            High = 313.6,
            Low = 279.4,
            Close = 286.6,
            Volume = 616204291,
            Change = -6,
            Index = 129
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-08-22",
            Open = 289.4,
            High = 314.7,
            Low = 285,
            Close = 289.9,
            Volume = 490658060,
            Change = 0.2,
            Index = 130
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-08-31",
            Open = 291.5,
            High = 303.6,
            Low = 271.8,
            Close = 275.6,
            Volume = 376152572,
            Change = -5.4,
            Index = 131
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-09-12",
            Open = 272.6,
            High = 305.5,
            Low = 265.7,
            Close = 304.4,
            Volume = 367924580,
            Change = 11.7,
            Index = 132
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-09-21",
            Open = 292.9,
            High = 313.8,
            Low = 290.4,
            Close = 300.8,
            Volume = 477171180,
            Change = 2.7,
            Index = 133
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-09-30",
            Open = 299.9,
            High = 301.3,
            Low = 262.5,
            Close = 265.2,
            Volume = 454307920,
            Change = -11.5,
            Index = 134
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-10-11",
            Open = 254.5,
            High = 257.5,
            Low = 215,
            Close = 216.5,
            Volume = 593078170,
            Change = -14.9,
            Index = 135
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-10-20",
            Open = 215.3,
            High = 229.8,
            Low = 202,
            Close = 207.3,
            Volume = 592158560,
            Change = -3.7,
            Index = 136
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-10-31",
            Open = 206.4,
            High = 233.8,
            Low = 198.6,
            Close = 227.5,
            Volume = 550341050,
            Change = 10.2,
            Index = 137
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-11-09",
            Open = 234,
            High = 237.4,
            Low = 177.1,
            Close = 177.6,
            Volume = 630702790,
            Change = -24.1,
            Index = 138
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-11-18",
            Open = 189.9,
            High = 200.8,
            Low = 176.6,
            Close = 180.2,
            Volume = 637579480,
            Change = -5.1,
            Index = 139
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-11-30",
            Open = 175.8,
            High = 194.8,
            Low = 166.2,
            Close = 194.7,
            Volume = 617126140,
            Change = 10.7,
            Index = 140
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-12-09",
            Open = 197.1,
            High = 198.9,
            Low = 169.1,
            Close = 179,
            Volume = 625675690,
            Change = -9.1,
            Index = 141
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-12-20",
            Open = 176.1,
            High = 177.4,
            Low = 137.7,
            Close = 137.8,
            Volume = 986660100,
            Change = -21.7,
            Index = 142
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2022-12-30",
            Open = 139.3,
            High = 141.3,
            Low = 108.2,
            Close = 123.2,
            Volume = 1331911900,
            Change = -11.6,
            Index = 143
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-01-11",
            Open = 118.5,
            High = 126,
            Low = 101.8,
            Close = 123.2,
            Volume = 1332426500,
            Change = 4,
            Index = 144
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-01-23",
            Open = 122.6,
            High = 145.4,
            Low = 115.6,
            Close = 143.8,
            Volume = 1244541500,
            Change = 17.3,
            Index = 145
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-02-01",
            Open = 143,
            High = 183.8,
            Low = 138.1,
            Close = 181.4,
            Volume = 1534337700,
            Change = 26.9,
            Index = 146
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-02-10",
            Open = 187.3,
            High = 214,
            Low = 182.6,
            Close = 196.9,
            Volume = 1423167800,
            Change = 5.1,
            Index = 147
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-02-22",
            Open = 194.4,
            High = 217.6,
            Low = 187.6,
            Close = 200.9,
            Volume = 1386211900,
            Change = 3.3,
            Index = 148
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-03-03",
            Open = 203.9,
            High = 211.2,
            Low = 186,
            Close = 197.8,
            Volume = 1095786600,
            Change = -3,
            Index = 149
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-03-14",
            Open = 198.5,
            High = 198.6,
            Low = 163.9,
            Close = 183.3,
            Volume = 1101144600,
            Change = -7.7,
            Index = 150
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-03-23",
            Open = 180.8,
            High = 200.7,
            Low = 176,
            Close = 192.2,
            Volume = 978213300,
            Change = 6.3,
            Index = 151
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-04-03",
            Open = 191.6,
            High = 207.8,
            Low = 185.4,
            Close = 194.8,
            Volume = 909718040,
            Change = 1.6,
            Index = 152
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-04-13",
            Open = 197.3,
            High = 198.7,
            Low = 176.1,
            Close = 185.9,
            Volume = 905319000,
            Change = -5.8,
            Index = 153
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-04-24",
            Open = 184,
            High = 189.7,
            Low = 158.6,
            Close = 162.6,
            Volume = 905416980,
            Change = -11.6,
            Index = 154
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-05-03",
            Open = 159.8,
            High = 165.5,
            Low = 152.4,
            Close = 160.6,
            Volume = 881897100,
            Change = 0.5,
            Index = 155
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-05-12",
            Open = 162.7,
            High = 177.4,
            Low = 159.6,
            Close = 168,
            Volume = 785510430,
            Change = 3.2,
            Index = 156
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-05-23",
            Open = 167.7,
            High = 193,
            Low = 164.4,
            Close = 185.8,
            Volume = 864025390,
            Change = 10.8,
            Index = 157
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-06-02",
            Open = 182.2,
            High = 217.2,
            Low = 178.2,
            Close = 214,
            Volume = 988496020,
            Change = 17.4,
            Index = 158
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-06-13",
            Open = 217.8,
            High = 259.7,
            Low = 212.5,
            Close = 258.7,
            Volume = 1161622400,
            Change = 18.8,
            Index = 159
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-06-23",
            Open = 260.2,
            High = 277,
            Low = 247.3,
            Close = 256.6,
            Volume = 1220407300,
            Change = -1.4,
            Index = 160
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-07-05",
            Open = 250.1,
            High = 284.2,
            Low = 240.7,
            Close = 282.5,
            Volume = 999163700,
            Change = 13,
            Index = 161
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-07-14",
            Open = 278.1,
            High = 285.3,
            Low = 265.1,
            Close = 281.4,
            Volume = 774400400,
            Change = 1.2,
            Index = 162
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-07-25",
            Open = 286.6,
            High = 299.3,
            Low = 254.1,
            Close = 265.3,
            Volume = 973076400,
            Change = -7.4,
            Index = 163
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-08-03",
            Open = 263.2,
            High = 269.1,
            Low = 250.5,
            Close = 259.3,
            Volume = 678809820,
            Change = -1.5,
            Index = 164
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-08-14",
            Open = 261,
            High = 264.8,
            Low = 233.8,
            Close = 239.8,
            Volume = 716008860,
            Change = -8.1,
            Index = 165
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-08-23",
            Open = 238.7,
            High = 240.8,
            Low = 212.4,
            Close = 236.9,
            Volume = 825055300,
            Change = -0.8,
            Index = 166
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-09-01",
            Open = 238.7,
            High = 261.2,
            Low = 228.2,
            Close = 245,
            Volume = 811502630,
            Change = 2.7,
            Index = 167
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-09-13",
            Open = 245,
            High = 278.4,
            Low = 243.3,
            Close = 271.3,
            Volume = 902643400,
            Change = 10.7,
            Index = 168
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-09-22",
            Open = 271.3,
            High = 279,
            Low = 244.5,
            Close = 244.9,
            Volume = 816639600,
            Change = -9.7,
            Index = 169
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-10-03",
            Open = 243.4,
            High = 254.8,
            Low = 234.6,
            Close = 246.5,
            Volume = 814604700,
            Change = 1.3,
            Index = 170
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-10-12",
            Open = 248.1,
            High = 268.9,
            Low = 247.6,
            Close = 258.9,
            Volume = 806250900,
            Change = 4.3,
            Index = 171
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-10-23",
            Open = 258.9,
            High = 259.6,
            Low = 202.5,
            Close = 212.1,
            Volume = 869390890,
            Change = -18.1,
            Index = 172
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-11-01",
            Open = 216.5,
            High = 222,
            Low = 194.1,
            Close = 205.7,
            Volume = 811468170,
            Change = -5,
            Index = 173
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-11-10",
            Open = 213,
            High = 226.4,
            Low = 205.7,
            Close = 214.6,
            Volume = 859763700,
            Change = 0.8,
            Index = 174
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-11-21",
            Open = 215.6,
            High = 246.7,
            Low = 211.6,
            Close = 241.2,
            Volume = 959006600,
            Change = 11.9,
            Index = 175
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-12-01",
            Open = 242,
            High = 252.8,
            Low = 231.4,
            Close = 238.8,
            Volume = 832910200,
            Change = -1.3,
            Index = 176
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-12-12",
            Open = 235.8,
            High = 246.7,
            Low = 233.3,
            Close = 237,
            Volume = 772018400,
            Change = 0.5,
            Index = 177
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2023-12-21",
            Open = 234.2,
            High = 259.8,
            Low = 228.2,
            Close = 254.5,
            Volume = 900893400,
            Change = 8.7,
            Index = 178
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-01-03",
            Open = 256.8,
            High = 265.1,
            Low = 236.3,
            Close = 238.4,
            Volume = 727005170,
            Change = -7.1,
            Index = 179
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-01-12",
            Open = 239.2,
            High = 242.7,
            Low = 217.2,
            Close = 218.9,
            Volume = 697536380,
            Change = -8.5,
            Index = 180
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-01-24",
            Open = 215.1,
            High = 223.5,
            Low = 206.3,
            Close = 207.8,
            Volume = 777303400,
            Change = -3.4,
            Index = 181
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-02-02",
            Open = 189.7,
            High = 196.4,
            Low = 180.1,
            Close = 187.9,
            Volume = 846092780,
            Change = -0.9,
            Index = 182
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-02-13",
            Open = 184.3,
            High = 194.7,
            Low = 175,
            Close = 184,
            Volume = 718274070,
            Change = -0.1,
            Index = 183
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-02-23",
            Open = 185.3,
            High = 203.2,
            Low = 183.4,
            Close = 192,
            Volume = 693352670,
            Change = 3.6,
            Index = 184
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-03-05",
            Open = 192.3,
            High = 205.6,
            Low = 177.6,
            Close = 180.7,
            Volume = 742344460,
            Change = -6,
            Index = 185
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-03-14",
            Open = 180,
            High = 182.9,
            Low = 160.5,
            Close = 162.5,
            Volume = 701227950,
            Change = -9.7,
            Index = 186
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-03-25",
            Open = 163.2,
            High = 178.2,
            Low = 160.8,
            Close = 172.6,
            Volume = 589466660,
            Change = 5.8,
            Index = 187
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-04-04",
            Open = 178.6,
            High = 184.2,
            Low = 163.3,
            Close = 171.1,
            Volume = 676969950,
            Change = -4.2,
            Index = 188
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-04-15",
            Open = 169.1,
            High = 179.2,
            Low = 160.5,
            Close = 161.5,
            Volume = 694829970,
            Change = -4.5,
            Index = 189
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-04-24",
            Open = 156.7,
            High = 168,
            Low = 138.8,
            Close = 162.1,
            Volume = 775433710,
            Change = 3.4,
            Index = 190
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-05-03",
            Open = 159,
            High = 198.9,
            Low = 158.4,
            Close = 181.2,
            Volume = 864614000,
            Change = 14,
            Index = 191
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-05-14",
            Open = 183.8,
            High = 187.6,
            Low = 167.8,
            Close = 177.6,
            Volume = 531409380,
            Change = -3.4,
            Index = 192
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-05-23",
            Open = 179.9,
            High = 186.9,
            Low = 171.4,
            Close = 173.7,
            Volume = 554203970,
            Change = -3.4,
            Index = 193
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-06-04",
            Open = 174.8,
            High = 182.7,
            Low = 173.2,
            Close = 174.8,
            Volume = 453828370,
            Change = 0,
            Index = 194
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-06-13",
            Open = 175.4,
            High = 191.1,
            Low = 167.4,
            Close = 182.5,
            Volume = 509090870,
            Change = 4.1,
            Index = 195
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-06-25",
            Open = 185.8,
            High = 188.8,
            Low = 176.9,
            Close = 187.4,
            Volume = 505399520,
            Change = 0.8,
            Index = 196
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-07-05",
            Open = 186.5,
            High = 252.4,
            Low = 186.4,
            Close = 251.5,
            Volume = 925723660,
            Change = 34.8,
            Index = 197
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-07-16",
            Open = 247.7,
            High = 271,
            Low = 233.1,
            Close = 256.6,
            Volume = 1097390000,
            Change = 3.6,
            Index = 198
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-07-25",
            Open = 252.7,
            High = 258.5,
            Low = 214.7,
            Close = 220.2,
            Volume = 795590700,
            Change = -12.9,
            Index = 199
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-08-05",
            Open = 221.2,
            High = 234.7,
            Low = 182,
            Close = 198.9,
            Volume = 658914080,
            Change = -10.1,
            Index = 200
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-08-14",
            Open = 200.8,
            High = 208.5,
            Low = 191.5,
            Close = 201.4,
            Volume = 479168160,
            Change = 0.3,
            Index = 201
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-08-23",
            Open = 205,
            High = 228.2,
            Low = 204.8,
            Close = 220.3,
            Volume = 560235700,
            Change = 7.5,
            Index = 202
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-09-04",
            Open = 218.8,
            High = 222.2,
            Low = 202.6,
            Close = 219.4,
            Volume = 469284350,
            Change = 0.3,
            Index = 203
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-09-13",
            Open = 223.5,
            High = 235,
            Low = 210.5,
            Close = 230.3,
            Volume = 592950440,
            Change = 3,
            Index = 204
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-09-24",
            Open = 229.3,
            High = 257.2,
            Low = 223.5,
            Close = 254.3,
            Volume = 577086700,
            Change = 10.9,
            Index = 205
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-10-03",
            Open = 252.5,
            High = 264.9,
            Low = 237.8,
            Close = 240.7,
            Volume = 546148740,
            Change = -4.7,
            Index = 206
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-10-14",
            Open = 246.7,
            High = 251,
            Low = 213.7,
            Close = 219.2,
            Volume = 589440130,
            Change = -11.2,
            Index = 207
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-10-23",
            Open = 220,
            High = 224.3,
            Low = 212.1,
            Close = 213.6,
            Volume = 384561880,
            Change = -2.9,
            Index = 208
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-11-01",
            Open = 244.7,
            High = 273.5,
            Low = 242.6,
            Close = 249,
            Volume = 732392780,
            Change = 1.8,
            Index = 209
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-11-12",
            Open = 244.6,
            High = 358.6,
            Low = 238.9,
            Close = 328.5,
            Volume = 991653160,
            Change = 34.3,
            Index = 210
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-11-21",
            Open = 335.8,
            High = 348.5,
            Low = 309.2,
            Close = 339.6,
            Volume = 700324320,
            Change = 1.1,
            Index = 211
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-12-03",
            Open = 341.1,
            High = 361.9,
            Low = 326.6,
            Close = 351.4,
            Volume = 478645220,
            Change = 3,
            Index = 212
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-12-12",
            Open = 353,
            High = 429.3,
            Low = 348.6,
            Close = 418.1,
            Volume = 599082110,
            Change = 18.4,
            Index = 213
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2024-12-23",
            Open = 420,
            High = 481.5,
            Low = 415.4,
            Close = 430.6,
            Volume = 807128120,
            Change = 2.5,
            Index = 214
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2025-01-03",
            Open = 435.9,
            High = 465.3,
            Low = 373,
            Close = 410.4,
            Volume = 565769940,
            Change = -5.8,
            Index = 215
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2025-01-15",
            Open = 423.2,
            High = 429.8,
            Low = 377.3,
            Close = 428.2,
            Volume = 530063170,
            Change = 1.2,
            Index = 216
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2025-01-27",
            Open = 423.5,
            High = 439.7,
            Low = 389,
            Close = 397.2,
            Volume = 476854060,
            Change = -6.2,
            Index = 217
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2025-02-05",
            Open = 396.9,
            High = 420,
            Low = 374.4,
            Close = 378.2,
            Volume = 507024510,
            Change = -4.7,
            Index = 218
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2025-02-14",
            Open = 373,
            High = 380.6,
            Low = 325.1,
            Close = 355.8,
            Volume = 607376290,
            Change = -4.6,
            Index = 219
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2025-02-26",
            Open = 355,
            High = 367.3,
            Low = 288,
            Close = 290.8,
            Volume = 549149490,
            Change = -18.1,
            Index = 220
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2025-03-07",
            Open = 291.2,
            High = 303.9,
            Low = 250.7,
            Close = 262.7,
            Volume = 754567280,
            Change = -9.8,
            Index = 221
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2025-03-18",
            Open = 252.5,
            High = 253.4,
            Low = 217,
            Close = 225.3,
            Volume = 944623000,
            Change = -10.8,
            Index = 222
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2025-03-27",
            Open = 231.6,
            High = 291.8,
            Low = 229.2,
            Close = 273.1,
            Volume = 982018670,
            Change = 17.9,
            Index = 223
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2025-04-07",
            Open = 275.6,
            High = 285,
            Low = 214.2,
            Close = 233.3,
            Volume = 1117950500,
            Change = -15.3,
            Index = 224
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2025-04-16",
            Open = 245,
            High = 274.7,
            Low = 217.8,
            Close = 241.6,
            Volume = 993815820,
            Change = -1.4,
            Index = 225
        });
        this.Add(new StockTeslaItem()
        {
            Date = @"2025-04-28",
            Open = 243.5,
            High = 294.9,
            Low = 222.8,
            Close = 285.9,
            Volume = 866169890,
            Change = 17.4,
            Index = 226
        });
    }
}
