using System;
using System.Collections.Generic;
public class StockGoogleItem
{
    public string Date{ get; set; }
    public double Open{ get; set; }
    public double High{ get; set; }
    public double Low{ get; set; }
    public double Close{ get; set; }
    public double Volume{ get; set; }
}
public class StockGoogle
    : List<StockGoogleItem>
{
    public StockGoogle()
    {
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-01",
            Open = 559.6,
            High = 568.2,
            Low = 558.4,
            Close = 566.9,
            Volume = 2182626
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-02",
            Open = 562.4,
            High = 571.8,
            Low = 561.4,
            Close = 567,
            Volume = 2088804
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-03",
            Open = 569.9,
            High = 587.3,
            Low = 564.1,
            Close = 569.7,
            Volume = 5087530
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-04",
            Open = 574.6,
            High = 577.8,
            Low = 543,
            Close = 543.1,
            Volume = 6377658
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-07",
            Open = 540.7,
            High = 548.5,
            Low = 527.1,
            Close = 538.1,
            Volume = 4389569
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-08",
            Open = 542.6,
            High = 555,
            Low = 541.6,
            Close = 554.9,
            Volume = 3152406
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-09",
            Open = 559.6,
            High = 565.4,
            Low = 553,
            Close = 564.1,
            Volume = 3324742
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-10",
            Open = 565,
            High = 565,
            Low = 539.9,
            Close = 541,
            Volume = 4027743
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-11",
            Open = 532.5,
            High = 540,
            Low = 526.5,
            Close = 530.6,
            Volume = 3916171
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-14",
            Open = 538.3,
            High = 544.1,
            Low = 529.6,
            Close = 532.5,
            Volume = 2568020
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-15",
            Open = 536.8,
            High = 538.5,
            Low = 518.5,
            Close = 536.4,
            Volume = 3847453
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-16",
            Open = 543,
            High = 557,
            Low = 540,
            Close = 556.5,
            Volume = 4879889
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-17",
            Open = 548.8,
            High = 549.5,
            Low = 531.1,
            Close = 536.1,
            Volume = 6795393
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-21",
            Open = 536.1,
            High = 536.7,
            Low = 525.6,
            Close = 528.6,
            Volume = 2561214
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-22",
            Open = 528.6,
            High = 537.2,
            Low = 527.5,
            Close = 534.8,
            Volume = 2359421
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-23",
            Open = 533.8,
            High = 533.9,
            Low = 526.3,
            Close = 526.9,
            Volume = 2051066
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-24",
            Open = 530.1,
            High = 531.6,
            Low = 522.1,
            Close = 525.2,
            Volume = 1881965
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-25",
            Open = 522.5,
            High = 524.7,
            Low = 515.4,
            Close = 516.2,
            Volume = 2097264
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-28",
            Open = 517.2,
            High = 518.6,
            Low = 502.8,
            Close = 517.1,
            Volume = 3326429
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-29",
            Open = 516.9,
            High = 529.5,
            Low = 516.3,
            Close = 527.7,
            Volume = 2692489
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-03-30",
            Open = 527.6,
            High = 528,
            Low = 522.5,
            Close = 526.7,
            Volume = 1746904
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-01",
            Open = 527.1,
            High = 532.9,
            Low = 523.9,
            Close = 531.4,
            Volume = 1900432
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-02",
            Open = 533.8,
            High = 534,
            Low = 525.6,
            Close = 527.9,
            Volume = 1685042
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-05",
            Open = 524.8,
            High = 528.9,
            Low = 521.3,
            Close = 527.8,
            Volume = 1021408
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-06",
            Open = 525.2,
            High = 526.8,
            Low = 515.1,
            Close = 515.1,
            Volume = 1684381
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-07",
            Open = 515.8,
            High = 516.7,
            Low = 503.3,
            Close = 510,
            Volume = 3216077
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-08",
            Open = 508.5,
            High = 517.2,
            Low = 506.4,
            Close = 511,
            Volume = 2016131
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-09",
            Open = 510.8,
            High = 519.9,
            Low = 504.2,
            Close = 518.7,
            Volume = 2432783
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-12",
            Open = 523.5,
            High = 530.2,
            Low = 519,
            Close = 529.9,
            Volume = 1908392
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-13",
            Open = 530.9,
            High = 536.1,
            Low = 529.5,
            Close = 533.1,
            Volume = 1648907
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-14",
            Open = 533,
            High = 533,
            Low = 525.3,
            Close = 526.6,
            Volume = 1191863
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-15",
            Open = 525.7,
            High = 525.9,
            Low = 517.4,
            Close = 520,
            Volume = 1703758
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-16",
            Open = 521.4,
            High = 521.8,
            Low = 515.4,
            Close = 520.6,
            Volume = 1481688
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-19",
            Open = 519.7,
            High = 529.8,
            Low = 517.6,
            Close = 528.9,
            Volume = 1276362
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-20",
            Open = 529.7,
            High = 536.2,
            Low = 526.3,
            Close = 529.8,
            Volume = 1780113
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-21",
            Open = 532.9,
            High = 539.2,
            Low = 531.9,
            Close = 538.9,
            Volume = 1193389
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-22",
            Open = 541.1,
            High = 547.6,
            Low = 540.8,
            Close = 545.1,
            Volume = 1611837
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-23",
            Open = 547.3,
            High = 553.6,
            Low = 543.7,
            Close = 552.7,
            Volume = 1929632
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-27",
            Open = 556,
            High = 566,
            Low = 554.4,
            Close = 566,
            Volume = 2100298
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-28",
            Open = 564.6,
            High = 567.8,
            Low = 561,
            Close = 561.7,
            Volume = 1647717
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-29",
            Open = 563.4,
            High = 564,
            Low = 558.7,
            Close = 560.1,
            Volume = 1350657
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-04-30",
            Open = 560.8,
            High = 561.4,
            Low = 555.9,
            Close = 559.9,
            Volume = 1766794
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-02",
            Open = 560.7,
            High = 560.9,
            Low = 545.7,
            Close = 553.9,
            Volume = 1434989
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-03",
            Open = 551,
            High = 552.3,
            Low = 542.5,
            Close = 544.9,
            Volume = 1861921
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-04",
            Open = 541.5,
            High = 548.6,
            Low = 538.8,
            Close = 544.7,
            Volume = 1812084
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-05",
            Open = 546.4,
            High = 555,
            Low = 544.5,
            Close = 553.9,
            Volume = 1684886
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-06",
            Open = 558.1,
            High = 558.1,
            Low = 548.9,
            Close = 556.3,
            Volume = 1732592
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-09",
            Open = 557.1,
            High = 562.9,
            Low = 556,
            Close = 562.1,
            Volume = 1463676
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-10",
            Open = 560.5,
            High = 563.6,
            Low = 557.9,
            Close = 560.5,
            Volume = 1349444
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-11",
            Open = 558,
            High = 559.9,
            Low = 555,
            Close = 558.8,
            Volume = 1097380
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-12",
            Open = 557.3,
            High = 558,
            Low = 548.5,
            Close = 551.4,
            Volume = 1457104
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-13",
            Open = 552.3,
            High = 552.3,
            Low = 545.6,
            Close = 551.8,
            Volume = 1217176
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-16",
            Open = 549.3,
            High = 549.6,
            Low = 541.5,
            Close = 544.3,
            Volume = 1704027
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-17",
            Open = 544.2,
            High = 545.3,
            Low = 539.3,
            Close = 543,
            Volume = 1445878
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-18",
            Open = 544.9,
            High = 553.6,
            Low = 544,
            Close = 553.4,
            Volume = 1737343
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-19",
            Open = 554.2,
            High = 555,
            Low = 548.5,
            Close = 554.9,
            Volume = 2451341
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-20",
            Open = 556.9,
            High = 557.6,
            Low = 550.4,
            Close = 556.4,
            Volume = 4496962
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-23",
            Open = 555.1,
            High = 565,
            Low = 554.3,
            Close = 565,
            Volume = 1534659
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-24",
            Open = 565.2,
            High = 572.6,
            Low = 561,
            Close = 564.6,
            Volume = 2201789
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-25",
            Open = 565.3,
            High = 580,
            Low = 565.2,
            Close = 578.6,
            Volume = 1964447
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-26",
            Open = 581,
            High = 582.5,
            Low = 571.9,
            Close = 576,
            Volume = 1737210
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-27",
            Open = 577.2,
            High = 579.9,
            Low = 573.8,
            Close = 577.2,
            Volume = 2231174
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-05-30",
            Open = 578.7,
            High = 579.6,
            Low = 574.8,
            Close = 575.3,
            Volume = 1310909
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-01",
            Open = 578.3,
            High = 584.4,
            Low = 576.6,
            Close = 582.7,
            Volume = 1446309
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-02",
            Open = 583.4,
            High = 585.4,
            Low = 580.4,
            Close = 582.3,
            Volume = 1054936
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-03",
            Open = 583.4,
            High = 585,
            Low = 580.9,
            Close = 584.7,
            Volume = 712210
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-07",
            Open = 583.8,
            High = 586.4,
            Low = 579.6,
            Close = 582.3,
            Volume = 1061833
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-08",
            Open = 577.7,
            High = 579.5,
            Low = 566.1,
            Close = 571.1,
            Volume = 1908647
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-09",
            Open = 571.6,
            High = 576.7,
            Low = 569.4,
            Close = 576.1,
            Volume = 1113907
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-10",
            Open = 565.9,
            High = 576.6,
            Low = 565,
            Close = 571.1,
            Volume = 1353317
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-11",
            Open = 571.9,
            High = 580.9,
            Low = 571.4,
            Close = 579.2,
            Volume = 1617569
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-14",
            Open = 582.6,
            High = 585.2,
            Low = 578,
            Close = 584.9,
            Volume = 1852290
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-15",
            Open = 585.7,
            High = 585.8,
            Low = 576.6,
            Close = 584.8,
            Volume = 1618815
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-16",
            Open = 588,
            High = 588.4,
            Low = 582.2,
            Close = 582.7,
            Volume = 1394560
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-17",
            Open = 579.5,
            High = 581,
            Low = 568.6,
            Close = 573.7,
            Volume = 3015475
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-18",
            Open = 593,
            High = 596.8,
            Low = 582,
            Close = 595.1,
            Volume = 4006389
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-21",
            Open = 591.8,
            High = 594.4,
            Low = 585.2,
            Close = 589.5,
            Volume = 2060334
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-22",
            Open = 590.7,
            High = 599.6,
            Low = 590.6,
            Close = 594.7,
            Volume = 1694787
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-23",
            Open = 593.2,
            High = 597.9,
            Low = 592.5,
            Close = 596,
            Volume = 1229846
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-24",
            Open = 596.5,
            High = 599.5,
            Low = 591.8,
            Close = 593.4,
            Volume = 1033341
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-25",
            Open = 590.4,
            High = 591.9,
            Low = 587,
            Close = 589,
            Volume = 932724
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-28",
            Open = 588.1,
            High = 592.5,
            Low = 584.8,
            Close = 590.6,
            Volume = 984161
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-29",
            Open = 588.8,
            High = 589.7,
            Low = 583.5,
            Close = 585.6,
            Volume = 1346647
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-30",
            Open = 586.5,
            High = 589.5,
            Low = 584,
            Close = 587.4,
            Volume = 1013932
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-06-31",
            Open = 580.6,
            High = 583.6,
            Low = 570,
            Close = 571.6,
            Volume = 2099516
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-01",
            Open = 570.4,
            High = 576,
            Low = 562.9,
            Close = 566.1,
            Volume = 1950171
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-04",
            Open = 569,
            High = 575.4,
            Low = 564.1,
            Close = 573.1,
            Volume = 1427169
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-05",
            Open = 570,
            High = 572,
            Low = 562.6,
            Close = 565.1,
            Volume = 1556685
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-06",
            Open = 561.8,
            High = 570.7,
            Low = 560,
            Close = 566.4,
            Volume = 1330877
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-07",
            Open = 568,
            High = 569.9,
            Low = 561.1,
            Close = 563.4,
            Volume = 1108900
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-08",
            Open = 563.6,
            High = 570.3,
            Low = 560.4,
            Close = 568.8,
            Volume = 1492491
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-11",
            Open = 570,
            High = 570.5,
            Low = 566,
            Close = 567.9,
            Volume = 1215968
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-12",
            Open = 564.5,
            High = 565.9,
            Low = 560.9,
            Close = 562.7,
            Volume = 1537758
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-13",
            Open = 567.3,
            High = 575,
            Low = 565.8,
            Close = 574.8,
            Volume = 1437922
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-14",
            Open = 576.2,
            High = 577.9,
            Low = 570.9,
            Close = 574.6,
            Volume = 982926
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-15",
            Open = 577.9,
            High = 579.4,
            Low = 570.5,
            Close = 573.5,
            Volume = 1517056
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-18",
            Open = 576.1,
            High = 584.5,
            Low = 576,
            Close = 582.2,
            Volume = 1282531
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-19",
            Open = 585,
            High = 587.3,
            Low = 584,
            Close = 586.9,
            Volume = 979298
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-20",
            Open = 585.9,
            High = 586.7,
            Low = 582.6,
            Close = 584.5,
            Volume = 1034779
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-21",
            Open = 583.8,
            High = 584.5,
            Low = 581.1,
            Close = 583.4,
            Volume = 912854
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-22",
            Open = 583.6,
            High = 585.2,
            Low = 580.6,
            Close = 582.6,
            Volume = 789484
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-25",
            Open = 584.7,
            High = 585,
            Low = 579,
            Close = 580.2,
            Volume = 1358810
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-26",
            Open = 581.3,
            High = 581.8,
            Low = 576.6,
            Close = 577.9,
            Volume = 1635465
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-27",
            Open = 577.3,
            High = 578.5,
            Low = 570.1,
            Close = 571,
            Volume = 1700161
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-28",
            Open = 569.6,
            High = 573.3,
            Low = 567.1,
            Close = 569.2,
            Volume = 1295963
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-07-29",
            Open = 571.3,
            High = 572,
            Low = 567.1,
            Close = 571.6,
            Volume = 1081231
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-02",
            Open = 571.9,
            High = 577.8,
            Low = 571.2,
            Close = 577.3,
            Volume = 1576830
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-03",
            Open = 580,
            High = 583,
            Low = 575,
            Close = 577.9,
            Volume = 1214586
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-04",
            Open = 580,
            High = 586,
            Low = 579.2,
            Close = 582,
            Volume = 1459956
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-05",
            Open = 584,
            High = 586.5,
            Low = 582,
            Close = 586.1,
            Volume = 1629477
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-08",
            Open = 586.6,
            High = 591.8,
            Low = 586.3,
            Close = 589.7,
            Volume = 1429101
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-09",
            Open = 588.9,
            High = 589,
            Low = 580,
            Close = 581,
            Volume = 1286722
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-10",
            Open = 581.5,
            High = 583.5,
            Low = 576.9,
            Close = 583.1,
            Volume = 975145
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-11",
            Open = 580.4,
            High = 581.8,
            Low = 576.3,
            Close = 581.4,
            Volume = 1217721
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-12",
            Open = 581,
            High = 581.6,
            Low = 574.5,
            Close = 575.6,
            Volume = 1597677
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-15",
            Open = 572.9,
            High = 575,
            Low = 568.2,
            Close = 573.1,
            Volume = 1596224
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-16",
            Open = 572.8,
            High = 581.5,
            Low = 572.7,
            Close = 580,
            Volume = 1478306
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-17",
            Open = 580,
            High = 587.5,
            Low = 578.8,
            Close = 584.8,
            Volume = 1690994
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-18",
            Open = 587,
            High = 589.5,
            Low = 585,
            Close = 589.3,
            Volume = 1442012
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-19",
            Open = 591.5,
            High = 596.5,
            Low = 589.5,
            Close = 596.1,
            Volume = 3727045
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-22",
            Open = 593.8,
            High = 594,
            Low = 583.5,
            Close = 587.4,
            Volume = 1687710
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-23",
            Open = 586.9,
            High = 586.9,
            Low = 581,
            Close = 581.1,
            Volume = 1467703
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-24",
            Open = 581.5,
            High = 589.6,
            Low = 580.5,
            Close = 588,
            Volume = 1724537
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-25",
            Open = 587.5,
            High = 588,
            Low = 574.2,
            Close = 575.1,
            Volume = 1925350
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-26",
            Open = 576.1,
            High = 579.3,
            Low = 574.7,
            Close = 577.1,
            Volume = 1439807
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-29",
            Open = 571.8,
            High = 578.2,
            Low = 571.2,
            Close = 576.4,
            Volume = 1281204
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-08-30",
            Open = 576.9,
            High = 579.9,
            Low = 572.9,
            Close = 577.4,
            Volume = 1618437
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-01",
            Open = 576,
            High = 577.6,
            Low = 567,
            Close = 568.3,
            Volume = 1445027
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-02",
            Open = 567.3,
            High = 571.9,
            Low = 563.3,
            Close = 570.1,
            Volume = 1175307
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-03",
            Open = 573,
            High = 577.2,
            Low = 572.5,
            Close = 575.3,
            Volume = 1138636
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-06",
            Open = 578.8,
            High = 581,
            Low = 574.4,
            Close = 577.4,
            Volume = 1211320
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-07",
            Open = 574.4,
            High = 575.3,
            Low = 563.7,
            Close = 563.7,
            Volume = 1906427
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-08",
            Open = 565.6,
            High = 573.9,
            Low = 557.5,
            Close = 572.5,
            Volume = 1987888
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-09",
            Open = 571.2,
            High = 571.5,
            Low = 559.1,
            Close = 560.9,
            Volume = 2519693
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-10",
            Open = 557.7,
            High = 565.1,
            Low = 544,
            Close = 544.5,
            Volume = 3078634
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-13",
            Open = 545,
            High = 549.5,
            Low = 533.1,
            Close = 533.2,
            Volume = 2578676
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-14",
            Open = 538.9,
            High = 547.2,
            Low = 533.2,
            Close = 537.9,
            Volume = 2217230
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-15",
            Open = 531,
            High = 532.8,
            Low = 518.3,
            Close = 530,
            Volume = 3712536
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-16",
            Open = 519,
            High = 529.4,
            Low = 515,
            Close = 524.5,
            Volume = 3698423
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-17",
            Open = 527.3,
            High = 531,
            Low = 508.5,
            Close = 511.2,
            Volume = 5530674
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-20",
            Open = 509.4,
            High = 521.8,
            Low = 508.1,
            Close = 520.8,
            Volume = 2605505
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-21",
            Open = 525.2,
            High = 526.8,
            Low = 519.1,
            Close = 526.5,
            Volume = 2332531
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-22",
            Open = 529.9,
            High = 539.8,
            Low = 528.8,
            Close = 532.7,
            Volume = 2917183
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-23",
            Open = 539.3,
            High = 547.2,
            Low = 535.9,
            Close = 544,
            Volume = 2345296
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-24",
            Open = 544.4,
            High = 544.9,
            Low = 535.8,
            Close = 539.8,
            Volume = 1972047
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-27",
            Open = 537,
            High = 544.4,
            Low = 537,
            Close = 540.8,
            Volume = 1184973
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-28",
            Open = 543,
            High = 549,
            Low = 541.6,
            Close = 548.9,
            Volume = 1273372
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-29",
            Open = 550,
            High = 554.2,
            Low = 547,
            Close = 549.3,
            Volume = 1767107
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-30",
            Open = 549,
            High = 552.8,
            Low = 543.5,
            Close = 550.3,
            Volume = 1451667
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-09-31",
            Open = 559.4,
            High = 559.6,
            Low = 554.8,
            Close = 559.1,
            Volume = 2032887
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-03",
            Open = 555.5,
            High = 557.9,
            Low = 553.2,
            Close = 555.2,
            Volume = 1378511
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-04",
            Open = 553,
            High = 555.5,
            Low = 549.3,
            Close = 554.1,
            Volume = 1240761
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-05",
            Open = 556.8,
            High = 556.8,
            Low = 544,
            Close = 545.9,
            Volume = 2026740
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-06",
            Open = 545.5,
            High = 546.9,
            Low = 541,
            Close = 542,
            Volume = 1329604
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-07",
            Open = 546.2,
            High = 546.2,
            Low = 538.7,
            Close = 541,
            Volume = 1629259
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-10",
            Open = 541.5,
            High = 549.6,
            Low = 541,
            Close = 547.5,
            Volume = 1131546
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-11",
            Open = 548.5,
            High = 551.9,
            Low = 546.3,
            Close = 550.3,
            Volume = 964866
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-12",
            Open = 550.4,
            High = 550.5,
            Low = 545.2,
            Close = 547.3,
            Volume = 1126594
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-13",
            Open = 549.8,
            High = 549.8,
            Low = 543.5,
            Close = 545.4,
            Volume = 1335719
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-14",
            Open = 546.7,
            High = 546.7,
            Low = 542.1,
            Close = 544.4,
            Volume = 1285991
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-17",
            Open = 543.6,
            High = 543.8,
            Low = 534.1,
            Close = 536.5,
            Volume = 1721282
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-18",
            Open = 537.5,
            High = 541.9,
            Low = 534.2,
            Close = 535,
            Volume = 1957664
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-19",
            Open = 535,
            High = 538.2,
            Low = 530.1,
            Close = 537,
            Volume = 1388440
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-20",
            Open = 531.3,
            High = 535.1,
            Low = 531.1,
            Close = 534.8,
            Volume = 1559131
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-21",
            Open = 541.6,
            High = 542.1,
            Low = 536.6,
            Close = 537.5,
            Volume = 2218249
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-24",
            Open = 537.6,
            High = 542.7,
            Low = 535.6,
            Close = 539.3,
            Volume = 1701682
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-25",
            Open = 539,
            High = 544,
            Low = 538.6,
            Close = 541.1,
            Volume = 1784967
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-26",
            Open = 540.9,
            High = 541.5,
            Low = 537,
            Close = 540.4,
            Volume = 1519503
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-10-28",
            Open = 540.6,
            High = 542,
            Low = 536.6,
            Close = 541.8,
            Volume = 1145231
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-01",
            Open = 538.9,
            High = 541.4,
            Low = 531.9,
            Close = 533.8,
            Volume = 2109599
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-02",
            Open = 533.5,
            High = 535.5,
            Low = 529.8,
            Close = 533.8,
            Volume = 1522481
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-03",
            Open = 531.4,
            High = 536,
            Low = 529.3,
            Close = 531.3,
            Volume = 1279288
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-04",
            Open = 531.2,
            High = 537.3,
            Low = 528.6,
            Close = 537.3,
            Volume = 1392208
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-05",
            Open = 531,
            High = 532.9,
            Low = 524.3,
            Close = 525.3,
            Volume = 2558649
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-08",
            Open = 527.1,
            High = 531,
            Low = 523.8,
            Close = 527,
            Volume = 2327127
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-09",
            Open = 522.1,
            High = 534.2,
            Low = 520.5,
            Close = 533.4,
            Volume = 1871268
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-10",
            Open = 533.1,
            High = 536.3,
            Low = 525.6,
            Close = 526.1,
            Volume = 1716835
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-11",
            Open = 527.8,
            High = 533.9,
            Low = 527.1,
            Close = 528.3,
            Volume = 1610964
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-12",
            Open = 523.5,
            High = 528.5,
            Low = 518.7,
            Close = 518.7,
            Volume = 1989117
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-15",
            Open = 522.7,
            High = 523.1,
            Low = 513.3,
            Close = 513.8,
            Volume = 2812786
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-16",
            Open = 511.6,
            High = 513,
            Low = 489,
            Close = 495.4,
            Volume = 3953371
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-17",
            Open = 497,
            High = 507,
            Low = 496.8,
            Close = 504.9,
            Volume = 2875281
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-18",
            Open = 513,
            High = 513.9,
            Low = 504.7,
            Close = 511.1,
            Volume = 2918730
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-19",
            Open = 511.5,
            High = 517.7,
            Low = 506.9,
            Close = 516.4,
            Volume = 3680148
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-22",
            Open = 516.1,
            High = 526.5,
            Low = 516.1,
            Close = 524.9,
            Volume = 2723599
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-23",
            Open = 527,
            High = 534.6,
            Low = 526.3,
            Close = 530.6,
            Volume = 2191567
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-24",
            Open = 530.5,
            High = 531.8,
            Low = 527,
            Close = 528.8,
            Volume = 704035
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-26",
            Open = 528.8,
            High = 534.3,
            Low = 527.3,
            Close = 534,
            Volume = 1037727
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-29",
            Open = 532.2,
            High = 535.5,
            Low = 530,
            Close = 530.3,
            Volume = 2276104
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-30",
            Open = 528.1,
            High = 531.1,
            Low = 527.1,
            Close = 530.4,
            Volume = 873923
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2014-11-31",
            Open = 531.3,
            High = 532.6,
            Low = 525.8,
            Close = 526.4,
            Volume = 1371819
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-02",
            Open = 529,
            High = 531.3,
            Low = 524.1,
            Close = 524.8,
            Volume = 1446662
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-05",
            Open = 523.3,
            High = 524.3,
            Low = 513.1,
            Close = 513.9,
            Volume = 2054238
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-06",
            Open = 515,
            High = 516.2,
            Low = 501.1,
            Close = 502,
            Volume = 2891950
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-07",
            Open = 507,
            High = 507.2,
            Low = 499.6,
            Close = 501.1,
            Volume = 2059366
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-08",
            Open = 498,
            High = 503.5,
            Low = 491,
            Close = 502.7,
            Volume = 3344395
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-09",
            Open = 504.8,
            High = 504.9,
            Low = 494.8,
            Close = 496.2,
            Volume = 2065715
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-12",
            Open = 494.9,
            High = 496,
            Low = 487.6,
            Close = 492.6,
            Volume = 2320446
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-13",
            Open = 498.8,
            High = 503,
            Low = 492.4,
            Close = 496.2,
            Volume = 2365687
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-14",
            Open = 494.6,
            High = 503.2,
            Low = 493,
            Close = 500.9,
            Volume = 2229638
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-15",
            Open = 505.6,
            High = 505.7,
            Low = 497.8,
            Close = 501.8,
            Volume = 2711355
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-16",
            Open = 500,
            High = 508.2,
            Low = 500,
            Close = 508.1,
            Volume = 2292043
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-20",
            Open = 511,
            High = 512.5,
            Low = 506,
            Close = 506.9,
            Volume = 2225922
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-21",
            Open = 507.3,
            High = 519.3,
            Low = 506.2,
            Close = 518,
            Volume = 2262455
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-22",
            Open = 521.5,
            High = 536.3,
            Low = 519.7,
            Close = 534.4,
            Volume = 2669558
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-23",
            Open = 535.6,
            High = 542.2,
            Low = 533,
            Close = 540,
            Volume = 2275485
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-26",
            Open = 538.5,
            High = 539,
            Low = 529.7,
            Close = 535.2,
            Volume = 1539524
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-27",
            Open = 530,
            High = 530.7,
            Low = 518.2,
            Close = 518.6,
            Volume = 1898844
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-28",
            Open = 522.8,
            High = 523,
            Low = 510,
            Close = 510,
            Volume = 1679230
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-29",
            Open = 511,
            High = 511.1,
            Low = 501.2,
            Close = 510.7,
            Volume = 4174924
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-00-30",
            Open = 515.9,
            High = 539.9,
            Low = 515.5,
            Close = 534.5,
            Volume = 5590977
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-02",
            Open = 531.7,
            High = 533,
            Low = 518.5,
            Close = 528.5,
            Volume = 2841976
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-03",
            Open = 528,
            High = 533.4,
            Low = 523.3,
            Close = 529.2,
            Volume = 2033085
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-04",
            Open = 529.2,
            High = 532.7,
            Low = 521.3,
            Close = 522.8,
            Volume = 1659125
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-05",
            Open = 523.8,
            High = 528.5,
            Low = 522.1,
            Close = 527.6,
            Volume = 1844687
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-06",
            Open = 527.6,
            High = 537.2,
            Low = 526.4,
            Close = 531,
            Volume = 1758650
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-09",
            Open = 528,
            High = 532,
            Low = 526,
            Close = 527.8,
            Volume = 1264276
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-10",
            Open = 529.3,
            High = 537.7,
            Low = 526.9,
            Close = 536.9,
            Volume = 1745076
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-11",
            Open = 535.3,
            High = 538.5,
            Low = 533.4,
            Close = 536,
            Volume = 1373970
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-12",
            Open = 537.3,
            High = 544.8,
            Low = 534.7,
            Close = 542.9,
            Volume = 1615824
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-13",
            Open = 543.4,
            High = 549.9,
            Low = 543.1,
            Close = 549,
            Volume = 1895126
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-17",
            Open = 546.8,
            High = 550,
            Low = 541.1,
            Close = 542.8,
            Volume = 1612439
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-18",
            Open = 541.4,
            High = 545.5,
            Low = 537.5,
            Close = 539.7,
            Volume = 1449089
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-19",
            Open = 538,
            High = 543.1,
            Low = 538,
            Close = 542.9,
            Volume = 987478
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-20",
            Open = 543.1,
            High = 543.8,
            Low = 535.8,
            Close = 539,
            Volume = 1441212
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-23",
            Open = 536,
            High = 536.4,
            Low = 529.4,
            Close = 531.9,
            Volume = 1453907
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-24",
            Open = 530,
            High = 536.8,
            Low = 528.3,
            Close = 536.1,
            Volume = 1002393
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-25",
            Open = 535.9,
            High = 546.2,
            Low = 535.4,
            Close = 543.9,
            Volume = 1821041
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-26",
            Open = 543.2,
            High = 556.1,
            Low = 541.5,
            Close = 555.5,
            Volume = 2305219
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-01-27",
            Open = 554.2,
            High = 564.7,
            Low = 552.9,
            Close = 558.4,
            Volume = 2403553
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-02",
            Open = 560.5,
            High = 572.1,
            Low = 558.8,
            Close = 571.3,
            Volume = 2123796
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-03",
            Open = 570.5,
            High = 575.4,
            Low = 566.5,
            Close = 573.6,
            Volume = 1700084
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-04",
            Open = 571.9,
            High = 577.1,
            Low = 568,
            Close = 573.4,
            Volume = 1871694
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-05",
            Open = 575,
            High = 577.9,
            Low = 573.4,
            Close = 575.3,
            Volume = 1385818
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-06",
            Open = 574.9,
            High = 576.7,
            Low = 566.8,
            Close = 567.7,
            Volume = 1654561
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-09",
            Open = 566.9,
            High = 570.3,
            Low = 563.5,
            Close = 568.9,
            Volume = 1059336
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-10",
            Open = 564.3,
            High = 564.9,
            Low = 554.7,
            Close = 555,
            Volume = 1787357
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-11",
            Open = 555.1,
            High = 558.1,
            Low = 550.7,
            Close = 551.2,
            Volume = 1815763
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-12",
            Open = 553.5,
            High = 556.4,
            Low = 550.5,
            Close = 555.5,
            Volume = 1385772
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-13",
            Open = 553.5,
            High = 558.4,
            Low = 544.2,
            Close = 547.3,
            Volume = 1698872
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-16",
            Open = 551,
            High = 556.9,
            Low = 546,
            Close = 554.5,
            Volume = 1636493
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-17",
            Open = 551.7,
            High = 553.8,
            Low = 548,
            Close = 550.8,
            Volume = 1800570
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-18",
            Open = 552.5,
            High = 559.8,
            Low = 547,
            Close = 559.5,
            Volume = 2128714
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-19",
            Open = 559.4,
            High = 560.8,
            Low = 556.1,
            Close = 558,
            Volume = 1194049
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-20",
            Open = 561.6,
            High = 561.7,
            Low = 559,
            Close = 560.4,
            Volume = 2609690
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-23",
            Open = 560.4,
            High = 562.4,
            Low = 555.8,
            Close = 558.8,
            Volume = 1639306
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-24",
            Open = 562.6,
            High = 574.6,
            Low = 561.2,
            Close = 570.2,
            Volume = 2576234
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-25",
            Open = 570.5,
            High = 572.3,
            Low = 558.7,
            Close = 558.8,
            Volume = 2146384
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-26",
            Open = 557.6,
            High = 558.9,
            Low = 550.6,
            Close = 555.2,
            Volume = 1568331
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-27",
            Open = 553,
            High = 555.3,
            Low = 548.1,
            Close = 548.3,
            Volume = 1892323
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-30",
            Open = 551.6,
            High = 553.5,
            Low = 548.2,
            Close = 552,
            Volume = 1283958
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-02-31",
            Open = 550,
            High = 554.7,
            Low = 546.7,
            Close = 548,
            Volume = 1583677
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-01",
            Open = 548.6,
            High = 551.1,
            Low = 539.5,
            Close = 542.6,
            Volume = 1957718
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-02",
            Open = 540.9,
            High = 540.9,
            Low = 533.9,
            Close = 535.5,
            Volume = 1711737
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-06",
            Open = 532.2,
            High = 538.4,
            Low = 529.6,
            Close = 536.8,
            Volume = 1320767
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-07",
            Open = 538.1,
            High = 542.7,
            Low = 536,
            Close = 537,
            Volume = 1299298
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-08",
            Open = 538.4,
            High = 543.9,
            Low = 538.4,
            Close = 541.6,
            Volume = 1175332
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-09",
            Open = 541,
            High = 542,
            Low = 535.5,
            Close = 540.8,
            Volume = 1553586
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-10",
            Open = 542.3,
            High = 542.3,
            Low = 537.3,
            Close = 540,
            Volume = 1405574
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-13",
            Open = 538.4,
            High = 544.1,
            Low = 537.3,
            Close = 539.2,
            Volume = 1640809
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-14",
            Open = 536.3,
            High = 537.6,
            Low = 528.1,
            Close = 530.4,
            Volume = 2597043
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-15",
            Open = 528.7,
            High = 534.7,
            Low = 523.2,
            Close = 532.5,
            Volume = 2312512
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-16",
            Open = 529.9,
            High = 535.6,
            Low = 529.6,
            Close = 533.8,
            Volume = 1296304
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-17",
            Open = 528.7,
            High = 529.8,
            Low = 521,
            Close = 524,
            Volume = 2145955
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-20",
            Open = 525.6,
            High = 536.1,
            Low = 524.5,
            Close = 535.4,
            Volume = 1675487
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-21",
            Open = 537.5,
            High = 539.4,
            Low = 533.7,
            Close = 534,
            Volume = 1839668
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-22",
            Open = 534.4,
            High = 541.1,
            Low = 531.8,
            Close = 539.4,
            Volume = 1589248
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-23",
            Open = 541,
            High = 551,
            Low = 540.2,
            Close = 547,
            Volume = 4173376
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-24",
            Open = 566.1,
            High = 571.1,
            Low = 557.3,
            Close = 565.1,
            Volume = 4919031
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-27",
            Open = 563.4,
            High = 566,
            Low = 553.2,
            Close = 555.4,
            Volume = 2398039
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-28",
            Open = 554.6,
            High = 556,
            Low = 550.4,
            Close = 553.7,
            Volume = 1490983
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-29",
            Open = 550.5,
            High = 553.7,
            Low = 546.9,
            Close = 549.1,
            Volume = 1698761
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-03-30",
            Open = 547.9,
            High = 548.6,
            Low = 535,
            Close = 537.3,
            Volume = 2082214
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-01",
            Open = 538.4,
            High = 539.5,
            Low = 532.1,
            Close = 537.9,
            Volume = 1768181
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-04",
            Open = 538.5,
            High = 544.1,
            Low = 535.1,
            Close = 540.8,
            Volume = 1307960
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-05",
            Open = 538.2,
            High = 539.7,
            Low = 530.4,
            Close = 530.8,
            Volume = 1383068
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-06",
            Open = 531.2,
            High = 532.4,
            Low = 521.1,
            Close = 524.2,
            Volume = 1566987
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-07",
            Open = 524,
            High = 533.5,
            Low = 521.8,
            Close = 530.7,
            Volume = 1546278
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-08",
            Open = 536.6,
            High = 541.1,
            Low = 536,
            Close = 538.2,
            Volume = 1527615
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-11",
            Open = 538.4,
            High = 542,
            Low = 535.4,
            Close = 535.7,
            Volume = 905285
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-12",
            Open = 531.6,
            High = 533.2,
            Low = 525.3,
            Close = 529,
            Volume = 1634174
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-13",
            Open = 530.6,
            High = 534.3,
            Low = 528.7,
            Close = 529.6,
            Volume = 1253063
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-14",
            Open = 533.8,
            High = 539,
            Low = 532.4,
            Close = 538.4,
            Volume = 1403935
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-15",
            Open = 539.2,
            High = 539.3,
            Low = 530.4,
            Close = 533.9,
            Volume = 1971343
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-18",
            Open = 532,
            High = 534.8,
            Low = 528.9,
            Close = 532.3,
            Volume = 2003421
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-19",
            Open = 534,
            High = 540.7,
            Low = 533,
            Close = 537.4,
            Volume = 1966947
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-20",
            Open = 538.5,
            High = 542.9,
            Low = 533,
            Close = 539.3,
            Volume = 1430826
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-21",
            Open = 538,
            High = 543.8,
            Low = 536,
            Close = 542.5,
            Volume = 1462695
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-22",
            Open = 540.1,
            High = 544.2,
            Low = 539.5,
            Close = 540.1,
            Volume = 1176214
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-26",
            Open = 538.1,
            High = 539,
            Low = 529.9,
            Close = 532.3,
            Volume = 2406512
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-27",
            Open = 532.8,
            High = 540.5,
            Low = 531.7,
            Close = 539.8,
            Volume = 1525019
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-28",
            Open = 538,
            High = 540.6,
            Low = 536.3,
            Close = 539.8,
            Volume = 1029849
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-04-29",
            Open = 537.4,
            High = 538.6,
            Low = 531.5,
            Close = 532.1,
            Volume = 2597407
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-01",
            Open = 536.8,
            High = 536.8,
            Low = 529.8,
            Close = 534,
            Volume = 1904332
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-02",
            Open = 532.9,
            High = 543,
            Low = 531.3,
            Close = 539.2,
            Volume = 1938989
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-03",
            Open = 539.9,
            High = 543.5,
            Low = 537.1,
            Close = 540.3,
            Volume = 1717036
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-04",
            Open = 537.8,
            High = 540.6,
            Low = 534.3,
            Close = 536.7,
            Volume = 1348337
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-05",
            Open = 536.4,
            High = 537.2,
            Low = 532.5,
            Close = 533.3,
            Volume = 1388220
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-08",
            Open = 533.3,
            High = 534.1,
            Low = 526.2,
            Close = 526.8,
            Volume = 1524139
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-09",
            Open = 527.6,
            High = 529.2,
            Low = 523,
            Close = 526.7,
            Volume = 1455266
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-10",
            Open = 529.4,
            High = 538.4,
            Low = 529.4,
            Close = 536.7,
            Volume = 1814958
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-11",
            Open = 538.4,
            High = 539,
            Low = 533,
            Close = 534.6,
            Volume = 1217536
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-12",
            Open = 531.6,
            High = 533.1,
            Low = 530.2,
            Close = 532.3,
            Volume = 955789
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-15",
            Open = 528,
            High = 528.3,
            Low = 524,
            Close = 527.2,
            Volume = 1632702
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-16",
            Open = 528.4,
            High = 529.6,
            Low = 525.6,
            Close = 528.1,
            Volume = 1071814
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-17",
            Open = 529.4,
            High = 531,
            Low = 525.1,
            Close = 529.3,
            Volume = 1294216
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-18",
            Open = 531,
            High = 538.1,
            Low = 530.8,
            Close = 536.7,
            Volume = 1833109
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-19",
            Open = 537.2,
            High = 538.3,
            Low = 533,
            Close = 536.7,
            Volume = 1893497
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-22",
            Open = 539.6,
            High = 543.7,
            Low = 537.5,
            Close = 538.2,
            Volume = 1250282
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-23",
            Open = 539.6,
            High = 541.5,
            Low = 535.3,
            Close = 540.5,
            Volume = 1197450
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-24",
            Open = 540,
            High = 540,
            Low = 535.7,
            Close = 537.8,
            Volume = 1286608
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-25",
            Open = 538.9,
            High = 540.9,
            Low = 535.2,
            Close = 535.2,
            Volume = 1335697
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-26",
            Open = 537.3,
            High = 537.8,
            Low = 531.4,
            Close = 531.7,
            Volume = 2109130
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-29",
            Open = 525,
            High = 528.6,
            Low = 520.5,
            Close = 521.5,
            Volume = 1937821
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-05-30",
            Open = 526,
            High = 526.3,
            Low = 520.5,
            Close = 520.5,
            Volume = 2235595
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-01",
            Open = 524.7,
            High = 525.7,
            Low = 518.2,
            Close = 521.8,
            Volume = 1961354
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-02",
            Open = 521.1,
            High = 524.6,
            Low = 521.1,
            Close = 523.4,
            Volume = 1235903
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-06",
            Open = 519.5,
            High = 525.3,
            Low = 519,
            Close = 522.9,
            Volume = 1280525
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-07",
            Open = 523.1,
            High = 526.2,
            Low = 515.2,
            Close = 525,
            Volume = 1597229
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-08",
            Open = 521,
            High = 522.7,
            Low = 516.1,
            Close = 516.8,
            Volume = 1296699
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-09",
            Open = 523.1,
            High = 523.8,
            Low = 520.4,
            Close = 520.7,
            Volume = 1842347
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-10",
            Open = 526.3,
            High = 532.6,
            Low = 525.5,
            Close = 530.1,
            Volume = 1956682
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-13",
            Open = 532.9,
            High = 547.1,
            Low = 532.4,
            Close = 546.5,
            Volume = 2206475
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-14",
            Open = 546.8,
            High = 565.9,
            Low = 546.7,
            Close = 561.1,
            Volume = 3244066
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-15",
            Open = 560.1,
            High = 566.5,
            Low = 556.8,
            Close = 560.2,
            Volume = 1784554
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-16",
            Open = 565.1,
            High = 580.7,
            Low = 565,
            Close = 579.9,
            Volume = 4768318
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-17",
            Open = 649,
            High = 674.5,
            Low = 645,
            Close = 672.9,
            Volume = 11164943
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-20",
            Open = 659.2,
            High = 668.9,
            Low = 653,
            Close = 663,
            Volume = 5860872
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-21",
            Open = 655.2,
            High = 673,
            Low = 654.3,
            Close = 662.3,
            Volume = 3377196
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-22",
            Open = 660.9,
            High = 678.6,
            Low = 659,
            Close = 662.1,
            Volume = 3929309
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-23",
            Open = 661.3,
            High = 663.6,
            Low = 641,
            Close = 644.3,
            Volume = 3029109
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-24",
            Open = 647,
            High = 648.2,
            Low = 622.5,
            Close = 623.6,
            Volume = 3625747
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-27",
            Open = 621,
            High = 634.3,
            Low = 620.5,
            Close = 627.3,
            Volume = 2675381
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-28",
            Open = 632.8,
            High = 632.8,
            Low = 623.3,
            Close = 628,
            Volume = 1727327
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-29",
            Open = 628.8,
            High = 633.4,
            Low = 622.6,
            Close = 631.9,
            Volume = 1575069
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-30",
            Open = 630,
            High = 635.2,
            Low = 622,
            Close = 632.6,
            Volume = 1474203
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-06-31",
            Open = 631.4,
            High = 632.9,
            Low = 625.5,
            Close = 625.6,
            Volume = 1706149
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-03",
            Open = 625.3,
            High = 633.1,
            Low = 625.3,
            Close = 631.2,
            Volume = 1304511
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-04",
            Open = 628.4,
            High = 634.8,
            Low = 627.2,
            Close = 629.3,
            Volume = 1490881
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-05",
            Open = 634.3,
            High = 647.9,
            Low = 633.2,
            Close = 643.8,
            Volume = 2334266
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-06",
            Open = 645,
            High = 645.4,
            Low = 632.3,
            Close = 642.7,
            Volume = 1572600
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-07",
            Open = 640.2,
            High = 642.7,
            Low = 629.7,
            Close = 635.3,
            Volume = 1403865
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-10",
            Open = 639.5,
            High = 643.4,
            Low = 631.3,
            Close = 633.7,
            Volume = 1809205
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-11",
            Open = 669.2,
            High = 674.9,
            Low = 654.3,
            Close = 660.8,
            Volume = 5029203
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-12",
            Open = 663.1,
            High = 665,
            Low = 652.3,
            Close = 659.6,
            Volume = 2940803
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-13",
            Open = 659.3,
            High = 664.5,
            Low = 651.7,
            Close = 656.5,
            Volume = 1810749
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-14",
            Open = 655,
            High = 659.9,
            Low = 652.7,
            Close = 657.1,
            Volume = 1072061
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-17",
            Open = 656.8,
            High = 661.4,
            Low = 651.2,
            Close = 660.9,
            Volume = 1051699
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-18",
            Open = 661.9,
            High = 664,
            Low = 653.5,
            Close = 656.1,
            Volume = 1456059
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-19",
            Open = 656.6,
            High = 667,
            Low = 654.2,
            Close = 660.9,
            Volume = 2134098
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-20",
            Open = 655.5,
            High = 663,
            Low = 642.9,
            Close = 646.8,
            Volume = 2855299
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-21",
            Open = 639.8,
            High = 640,
            Low = 612.3,
            Close = 612.5,
            Volume = 4265183
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-24",
            Open = 573,
            High = 614,
            Low = 565,
            Close = 589.6,
            Volume = 5770302
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-25",
            Open = 614.9,
            High = 617.5,
            Low = 581.1,
            Close = 582.1,
            Volume = 3537966
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-26",
            Open = 610.4,
            High = 631.7,
            Low = 599,
            Close = 628.6,
            Volume = 4235891
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-27",
            Open = 639.4,
            High = 643.6,
            Low = 622,
            Close = 637.6,
            Volume = 3491336
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-28",
            Open = 632.8,
            High = 636.9,
            Low = 624.6,
            Close = 630.4,
            Volume = 1978733
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-07-31",
            Open = 627.5,
            High = 635.8,
            Low = 617.7,
            Close = 618.3,
            Volume = 2176737
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-01",
            Open = 602.4,
            High = 612.9,
            Low = 594.1,
            Close = 597.8,
            Volume = 3702105
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-02",
            Open = 605.6,
            High = 614.3,
            Low = 599.7,
            Close = 614.3,
            Volume = 2575620
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-03",
            Open = 617,
            High = 619.7,
            Low = 602.8,
            Close = 606.3,
            Volume = 1759572
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-04",
            Open = 600,
            High = 603.5,
            Low = 595.3,
            Close = 600.7,
            Volume = 2089453
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-08",
            Open = 612.5,
            High = 616.3,
            Low = 604.1,
            Close = 614.7,
            Volume = 2279538
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-09",
            Open = 621.2,
            High = 626.5,
            Low = 609.6,
            Close = 612.7,
            Volume = 1702094
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-10",
            Open = 613.1,
            High = 624.2,
            Low = 611.4,
            Close = 621.4,
            Volume = 1900526
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-11",
            Open = 619.8,
            High = 625.8,
            Low = 617.4,
            Close = 625.8,
            Volume = 1373545
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-14",
            Open = 625.7,
            High = 625.9,
            Low = 619.4,
            Close = 623.2,
            Volume = 1702271
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-15",
            Open = 626.7,
            High = 638.7,
            Low = 623.8,
            Close = 635.1,
            Volume = 2084397
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-16",
            Open = 635.5,
            High = 638,
            Low = 632.3,
            Close = 636,
            Volume = 1286454
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-17",
            Open = 637.8,
            High = 650.9,
            Low = 635,
            Close = 642.9,
            Volume = 2274690
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-18",
            Open = 636.8,
            High = 640,
            Low = 627,
            Close = 629.3,
            Volume = 5133386
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-21",
            Open = 634.4,
            High = 636.5,
            Low = 625.9,
            Close = 635.4,
            Volume = 1788506
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-22",
            Open = 627,
            High = 627.5,
            Low = 615.4,
            Close = 622.7,
            Volume = 2562869
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-23",
            Open = 622,
            High = 628.9,
            Low = 620,
            Close = 622.4,
            Volume = 1470949
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-24",
            Open = 616.6,
            High = 627.3,
            Low = 612.4,
            Close = 625.8,
            Volume = 2240098
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-25",
            Open = 629.8,
            High = 629.8,
            Low = 611,
            Close = 612,
            Volume = 2174009
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-28",
            Open = 610.3,
            High = 614.6,
            Low = 589.4,
            Close = 594.9,
            Volume = 3127667
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-29",
            Open = 597.3,
            High = 605,
            Low = 590.2,
            Close = 595,
            Volume = 2310284
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-08-30",
            Open = 603.3,
            High = 608.8,
            Low = 600.7,
            Close = 608.4,
            Volume = 2413441
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-01",
            Open = 608.4,
            High = 612.1,
            Low = 599.9,
            Close = 611.3,
            Volume = 1867601
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-02",
            Open = 607.2,
            High = 627.3,
            Low = 603.1,
            Close = 626.9,
            Volume = 2684805
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-05",
            Open = 632,
            High = 643,
            Low = 627,
            Close = 641.5,
            Volume = 1787880
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-06",
            Open = 638.8,
            High = 649.3,
            Low = 636.5,
            Close = 645.4,
            Volume = 2166264
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-07",
            Open = 649.2,
            High = 650.6,
            Low = 632.1,
            Close = 642.4,
            Volume = 2089776
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-08",
            Open = 641.4,
            High = 644.5,
            Low = 625.6,
            Close = 639.2,
            Volume = 2180441
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-09",
            Open = 640,
            High = 646,
            Low = 635.3,
            Close = 643.6,
            Volume = 1645844
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-12",
            Open = 642.1,
            High = 648.5,
            Low = 639,
            Close = 646.7,
            Volume = 1275206
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-13",
            Open = 643.1,
            High = 657.8,
            Low = 643.1,
            Close = 652.3,
            Volume = 1790704
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-14",
            Open = 653.2,
            High = 659.4,
            Low = 648.9,
            Close = 651.2,
            Volume = 1412040
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-15",
            Open = 654.7,
            High = 663.1,
            Low = 654.5,
            Close = 661.7,
            Volume = 1830524
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-16",
            Open = 664.1,
            High = 665,
            Low = 657.2,
            Close = 662.2,
            Volume = 1606138
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-19",
            Open = 661.2,
            High = 666.8,
            Low = 659.6,
            Close = 666.1,
            Volume = 1465339
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-20",
            Open = 664,
            High = 664.7,
            Low = 644.2,
            Close = 650.3,
            Volume = 2490016
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-21",
            Open = 654.1,
            High = 655.9,
            Low = 641.7,
            Close = 642.6,
            Volume = 1791099
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-22",
            Open = 646.7,
            High = 657.8,
            Low = 644,
            Close = 651.8,
            Volume = 3782103
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-23",
            Open = 727.5,
            High = 730,
            Low = 701.5,
            Close = 702,
            Volume = 6642504
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-26",
            Open = 701.5,
            High = 719.1,
            Low = 701.3,
            Close = 712.8,
            Volume = 2701629
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-27",
            Open = 707.4,
            High = 713.6,
            Low = 704.5,
            Close = 708.5,
            Volume = 2224309
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-28",
            Open = 707.3,
            High = 713,
            Low = 703.1,
            Close = 713,
            Volume = 2176623
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-29",
            Open = 710.5,
            High = 718.3,
            Low = 710,
            Close = 716.9,
            Volume = 1454128
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-09-30",
            Open = 715.7,
            High = 718,
            Low = 710,
            Close = 710.8,
            Volume = 1903980
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-02",
            Open = 711.1,
            High = 721.6,
            Low = 705.9,
            Close = 721.1,
            Volume = 1871073
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-03",
            Open = 718.9,
            High = 724.6,
            Low = 714.7,
            Close = 722.2,
            Volume = 1560770
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-04",
            Open = 722,
            High = 733.1,
            Low = 721.9,
            Close = 728.1,
            Volume = 1704575
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-05",
            Open = 729.5,
            High = 739.5,
            Low = 729.5,
            Close = 731.3,
            Volume = 1860367
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-06",
            Open = 731.5,
            High = 735.4,
            Low = 727,
            Close = 733.8,
            Volume = 1509656
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-09",
            Open = 730.2,
            High = 734.7,
            Low = 719.4,
            Close = 724.9,
            Volume = 2065619
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-10",
            Open = 724.4,
            High = 730.6,
            Low = 718.5,
            Close = 728.3,
            Volume = 1603937
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-11",
            Open = 732.5,
            High = 741,
            Low = 730.2,
            Close = 735.4,
            Volume = 1366375
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-12",
            Open = 731,
            High = 737.8,
            Low = 728.6,
            Close = 731.2,
            Volume = 1668048
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-13",
            Open = 729.2,
            High = 731.1,
            Low = 716.7,
            Close = 717,
            Volume = 2062982
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-16",
            Open = 715.6,
            High = 729.5,
            Low = 711.3,
            Close = 729,
            Volume = 1891074
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-17",
            Open = 729.3,
            High = 731.8,
            Low = 723,
            Close = 725.3,
            Volume = 1491709
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-18",
            Open = 727.6,
            High = 741.4,
            Low = 727,
            Close = 740,
            Volume = 1671588
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-19",
            Open = 738.7,
            High = 742,
            Low = 737.4,
            Close = 738.4,
            Volume = 1327109
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-20",
            Open = 746.5,
            High = 757.9,
            Low = 743,
            Close = 756.6,
            Volume = 2212302
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-23",
            Open = 757.5,
            High = 762.7,
            Low = 751.8,
            Close = 756,
            Volume = 1414487
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-24",
            Open = 752,
            High = 755.3,
            Low = 737.6,
            Close = 748.3,
            Volume = 2333130
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-25",
            Open = 748.1,
            High = 752,
            Low = 746.1,
            Close = 748.1,
            Volume = 1122224
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-27",
            Open = 748.5,
            High = 753.4,
            Low = 747.5,
            Close = 750.3,
            Volume = 838518
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-10-30",
            Open = 748.8,
            High = 754.9,
            Low = 741.3,
            Close = 742.6,
            Volume = 2035261
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-01",
            Open = 747.1,
            High = 769,
            Low = 746.7,
            Close = 767,
            Volume = 2129940
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-02",
            Open = 768.9,
            High = 776,
            Low = 759,
            Close = 762.4,
            Volume = 2195686
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-03",
            Open = 766,
            High = 769,
            Low = 745.6,
            Close = 752.5,
            Volume = 2590641
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-04",
            Open = 753.1,
            High = 768.5,
            Low = 750,
            Close = 766.8,
            Volume = 2757283
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-07",
            Open = 767.8,
            High = 768.7,
            Low = 755.1,
            Close = 763.3,
            Volume = 1812314
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-08",
            Open = 757.9,
            High = 764.8,
            Low = 754.2,
            Close = 762.4,
            Volume = 1829475
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-09",
            Open = 759.2,
            High = 764.2,
            Low = 737,
            Close = 751.6,
            Volume = 2699990
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-10",
            Open = 752.9,
            High = 755.9,
            Low = 743.8,
            Close = 749.5,
            Volume = 1988380
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-11",
            Open = 741.2,
            High = 745.7,
            Low = 736.8,
            Close = 738.9,
            Volume = 2224410
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-14",
            Open = 741.8,
            High = 748.7,
            Low = 724.2,
            Close = 747.8,
            Volume = 2412497
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-15",
            Open = 753,
            High = 758.1,
            Low = 743,
            Close = 743.4,
            Volume = 2666229
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-16",
            Open = 750,
            High = 760.6,
            Low = 739.4,
            Close = 758.1,
            Volume = 1993251
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-17",
            Open = 762.4,
            High = 762.7,
            Low = 749,
            Close = 749.4,
            Volume = 1553418
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-18",
            Open = 746.5,
            High = 754.1,
            Low = 738.1,
            Close = 739.3,
            Volume = 3148743
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-21",
            Open = 746.1,
            High = 750,
            Low = 740,
            Close = 747.8,
            Volume = 1525703
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-22",
            Open = 751.6,
            High = 754.9,
            Low = 745.5,
            Close = 750,
            Volume = 1365520
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-23",
            Open = 753.5,
            High = 754.2,
            Low = 744,
            Close = 750.3,
            Volume = 1566726
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-24",
            Open = 749.5,
            High = 751.4,
            Low = 746.6,
            Close = 748.4,
            Volume = 527223
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-28",
            Open = 752.9,
            High = 763,
            Low = 749.5,
            Close = 762.5,
            Volume = 1515716
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-29",
            Open = 766.7,
            High = 780,
            Low = 766.4,
            Close = 776.6,
            Volume = 1765012
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-30",
            Open = 776.6,
            High = 777.6,
            Low = 766.9,
            Close = 771,
            Volume = 1293521
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2015-11-31",
            Open = 769.5,
            High = 769.5,
            Low = 758.3,
            Close = 758.9,
            Volume = 1500923
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-04",
            Open = 743,
            High = 744.1,
            Low = 731.3,
            Close = 741.8,
            Volume = 3258199
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-05",
            Open = 746.5,
            High = 752,
            Low = 738.6,
            Close = 742.6,
            Volume = 1950691
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-06",
            Open = 730,
            High = 747.2,
            Low = 728.9,
            Close = 743.6,
            Volume = 1947034
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-07",
            Open = 730.3,
            High = 738.5,
            Low = 719.1,
            Close = 726.4,
            Volume = 2963741
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-08",
            Open = 731.5,
            High = 733.2,
            Low = 713,
            Close = 714.5,
            Volume = 2450857
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-11",
            Open = 716.6,
            High = 718.9,
            Low = 703.5,
            Close = 716,
            Volume = 2090621
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-12",
            Open = 721.7,
            High = 728.8,
            Low = 717.3,
            Close = 726.1,
            Volume = 2024509
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-13",
            Open = 730.9,
            High = 734.7,
            Low = 698.6,
            Close = 700.6,
            Volume = 2468295
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-14",
            Open = 705.4,
            High = 721.9,
            Low = 689.1,
            Close = 714.7,
            Volume = 2211853
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-15",
            Open = 692.3,
            High = 706.7,
            Low = 685.4,
            Close = 694.5,
            Volume = 3592449
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-19",
            Open = 703.3,
            High = 710,
            Low = 693.4,
            Close = 701.8,
            Volume = 2258479
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-20",
            Open = 688.6,
            High = 706.9,
            Low = 673.3,
            Close = 698.5,
            Volume = 3439386
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-21",
            Open = 702.2,
            High = 719.2,
            Low = 694.5,
            Close = 706.6,
            Volume = 2410263
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-22",
            Open = 723.6,
            High = 728.1,
            Low = 720.1,
            Close = 725.3,
            Volume = 2006528
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-25",
            Open = 723.6,
            High = 729.7,
            Low = 710,
            Close = 711.7,
            Volume = 1704641
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-26",
            Open = 713.9,
            High = 718.3,
            Low = 706.5,
            Close = 713,
            Volume = 1324300
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-27",
            Open = 713.7,
            High = 718.2,
            Low = 694.4,
            Close = 700,
            Volume = 2139970
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-28",
            Open = 722.2,
            High = 733.7,
            Low = 712.4,
            Close = 731,
            Volume = 2658016
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-00-29",
            Open = 731.5,
            High = 745,
            Low = 726.8,
            Close = 743,
            Volume = 3394935
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-01",
            Open = 750.5,
            High = 757.9,
            Low = 743.3,
            Close = 752,
            Volume = 4801816
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-02",
            Open = 784.5,
            High = 789.9,
            Low = 764.6,
            Close = 764.6,
            Volume = 6332431
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-03",
            Open = 770.2,
            High = 774.5,
            Low = 720.5,
            Close = 727,
            Volume = 6162333
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-04",
            Open = 722.8,
            High = 727,
            Low = 701.9,
            Close = 708,
            Volume = 5145855
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-05",
            Open = 703.9,
            High = 704,
            Low = 680.1,
            Close = 683.6,
            Volume = 5069985
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-08",
            Open = 667.9,
            High = 684,
            Low = 663.1,
            Close = 682.7,
            Volume = 4212541
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-09",
            Open = 672.3,
            High = 699.9,
            Low = 668.8,
            Close = 678.1,
            Volume = 3604335
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-10",
            Open = 686.9,
            High = 701.3,
            Low = 682.1,
            Close = 684.1,
            Volume = 2627379
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-11",
            Open = 675,
            High = 689.4,
            Low = 668.9,
            Close = 683.1,
            Volume = 3007223
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-12",
            Open = 690.3,
            High = 693.8,
            Low = 678.6,
            Close = 682.4,
            Volume = 2129831
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-16",
            Open = 693,
            High = 698,
            Low = 685,
            Close = 691,
            Volume = 2497024
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-17",
            Open = 699,
            High = 709.8,
            Low = 691.4,
            Close = 708.4,
            Volume = 2466808
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-18",
            Open = 710,
            High = 712.4,
            Low = 696,
            Close = 697.4,
            Volume = 1859130
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-19",
            Open = 695,
            High = 703.1,
            Low = 694,
            Close = 700.9,
            Volume = 1582260
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-22",
            Open = 707.5,
            High = 713.2,
            Low = 702.5,
            Close = 706.5,
            Volume = 1946067
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-23",
            Open = 701.5,
            High = 708.4,
            Low = 693.6,
            Close = 695.9,
            Volume = 1999699
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-24",
            Open = 688.9,
            High = 700,
            Low = 680.8,
            Close = 699.6,
            Volume = 1958611
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-25",
            Open = 700,
            High = 706,
            Low = 690.6,
            Close = 705.8,
            Volume = 1631855
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-26",
            Open = 708.6,
            High = 713.4,
            Low = 700.9,
            Close = 705.1,
            Volume = 2239978
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-01-29",
            Open = 700.3,
            High = 710.9,
            Low = 697.7,
            Close = 697.8,
            Volume = 2280280
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-01",
            Open = 703.6,
            High = 718.8,
            Low = 699.8,
            Close = 718.8,
            Volume = 2147442
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-02",
            Open = 719,
            High = 720,
            Low = 712,
            Close = 718.9,
            Volume = 1627753
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-03",
            Open = 718.7,
            High = 719.5,
            Low = 706,
            Close = 712.4,
            Volume = 1956761
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-04",
            Open = 715,
            High = 716.5,
            Low = 706,
            Close = 710.9,
            Volume = 1967873
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-07",
            Open = 706.9,
            High = 708.1,
            Low = 686.9,
            Close = 695.2,
            Volume = 2985094
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-08",
            Open = 688.6,
            High = 703.8,
            Low = 685.3,
            Close = 694,
            Volume = 2063357
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-09",
            Open = 698.5,
            High = 705.7,
            Low = 694,
            Close = 705.2,
            Volume = 1418704
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-10",
            Open = 708.1,
            High = 716.4,
            Low = 703.4,
            Close = 712.8,
            Volume = 2829412
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-11",
            Open = 720,
            High = 726.9,
            Low = 717.1,
            Close = 726.8,
            Volume = 1963907
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-14",
            Open = 726.8,
            High = 735.5,
            Low = 725.1,
            Close = 730.5,
            Volume = 1716910
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-15",
            Open = 726.9,
            High = 732.3,
            Low = 724.8,
            Close = 728.3,
            Volume = 1720965
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-16",
            Open = 726.4,
            High = 737.5,
            Low = 724.5,
            Close = 736.1,
            Volume = 1572329
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-17",
            Open = 736.5,
            High = 743.1,
            Low = 736,
            Close = 737.8,
            Volume = 1856800
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-18",
            Open = 741.9,
            High = 742,
            Low = 731.8,
            Close = 737.6,
            Volume = 2796376
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-21",
            Open = 736.5,
            High = 742.5,
            Low = 733.5,
            Close = 742.1,
            Volume = 1831839
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-22",
            Open = 737.5,
            High = 745,
            Low = 737.5,
            Close = 740.8,
            Volume = 1264396
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-23",
            Open = 742.4,
            High = 745.7,
            Low = 736.1,
            Close = 738.1,
            Volume = 1421861
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-24",
            Open = 732,
            High = 737.8,
            Low = 731,
            Close = 735.3,
            Volume = 1564782
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-28",
            Open = 736.8,
            High = 739,
            Low = 732.5,
            Close = 733.5,
            Volume = 1299812
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-29",
            Open = 734.6,
            High = 747.3,
            Low = 728.8,
            Close = 744.8,
            Volume = 1902128
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-30",
            Open = 750.1,
            High = 757.9,
            Low = 748.7,
            Close = 750.5,
            Volume = 1780998
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-02-31",
            Open = 749.3,
            High = 750.9,
            Low = 740.9,
            Close = 745,
            Volume = 1712375
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-01",
            Open = 738.6,
            High = 750.3,
            Low = 737,
            Close = 749.9,
            Volume = 1574870
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-04",
            Open = 750.1,
            High = 752.8,
            Low = 742.4,
            Close = 745.3,
            Volume = 1131843
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-05",
            Open = 738,
            High = 742.8,
            Low = 735.4,
            Close = 737.8,
            Volume = 1129829
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-06",
            Open = 735.8,
            High = 746.2,
            Low = 735.6,
            Close = 745.7,
            Volume = 1050193
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-07",
            Open = 745.4,
            High = 747,
            Low = 736.3,
            Close = 740.3,
            Volume = 1429504
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-08",
            Open = 744,
            High = 745.5,
            Low = 735.5,
            Close = 739.1,
            Volume = 1285755
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-11",
            Open = 743,
            High = 745,
            Low = 736,
            Close = 736.1,
            Volume = 1211762
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-12",
            Open = 738,
            High = 743.8,
            Low = 731,
            Close = 743.1,
            Volume = 1349734
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-13",
            Open = 749.2,
            High = 754.4,
            Low = 744.3,
            Close = 751.7,
            Volume = 1707095
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-14",
            Open = 754,
            High = 757.3,
            Low = 752.7,
            Close = 753.2,
            Volume = 1130971
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-15",
            Open = 754,
            High = 761,
            Low = 752.7,
            Close = 759,
            Volume = 1800413
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-18",
            Open = 760.5,
            High = 768,
            Low = 757.3,
            Close = 766.6,
            Volume = 1555953
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-19",
            Open = 769.5,
            High = 769.9,
            Low = 749.3,
            Close = 753.9,
            Volume = 2027642
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-20",
            Open = 758,
            High = 758.1,
            Low = 750,
            Close = 752.7,
            Volume = 1525591
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-21",
            Open = 755.4,
            High = 760.5,
            Low = 749.5,
            Close = 759.1,
            Volume = 2743620
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-22",
            Open = 726.3,
            High = 736.1,
            Low = 713.6,
            Close = 718.8,
            Volume = 5939199
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-25",
            Open = 716.1,
            High = 723.9,
            Low = 715.6,
            Close = 723.1,
            Volume = 1955567
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-26",
            Open = 725.4,
            High = 725.8,
            Low = 703,
            Close = 708.1,
            Volume = 2727185
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-27",
            Open = 707.3,
            High = 709,
            Low = 692.4,
            Close = 705.8,
            Volume = 3086722
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-28",
            Open = 708.3,
            High = 714.2,
            Low = 689.5,
            Close = 691,
            Volume = 2851108
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-03-29",
            Open = 690.7,
            High = 697.6,
            Low = 689,
            Close = 693,
            Volume = 2484273
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-02",
            Open = 697.6,
            High = 700.6,
            Low = 691,
            Close = 698.2,
            Volume = 1644126
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-03",
            Open = 696.9,
            High = 697.8,
            Low = 692,
            Close = 692.4,
            Volume = 1530993
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-04",
            Open = 690.5,
            High = 699.8,
            Low = 689,
            Close = 695.7,
            Volume = 1688569
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-05",
            Open = 697.7,
            High = 702.3,
            Low = 695.7,
            Close = 701.4,
            Volume = 1677405
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-06",
            Open = 698.4,
            High = 711.9,
            Low = 698.1,
            Close = 711.1,
            Volume = 1826146
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-09",
            Open = 712,
            High = 718.7,
            Low = 710,
            Close = 712.9,
            Volume = 1508423
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-10",
            Open = 716.8,
            High = 723.5,
            Low = 715.7,
            Close = 723.2,
            Volume = 1563105
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-11",
            Open = 723.4,
            High = 724.5,
            Low = 712.8,
            Close = 715.3,
            Volume = 1686823
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-12",
            Open = 717.1,
            High = 719.3,
            Low = 709,
            Close = 713.3,
            Volume = 1360732
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-13",
            Open = 711.9,
            High = 716.7,
            Low = 709.3,
            Close = 710.8,
            Volume = 1307338
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-16",
            Open = 709.1,
            High = 718.5,
            Low = 705.6,
            Close = 716.5,
            Volume = 1316177
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-17",
            Open = 716,
            High = 721.5,
            Low = 704.1,
            Close = 706.2,
            Volume = 1999456
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-18",
            Open = 703.7,
            High = 711.6,
            Low = 700.6,
            Close = 706.6,
            Volume = 1763394
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-19",
            Open = 702.4,
            High = 706,
            Low = 696.8,
            Close = 700.3,
            Volume = 1656321
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-20",
            Open = 701.6,
            High = 714.6,
            Low = 700.5,
            Close = 709.7,
            Volume = 1816027
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-23",
            Open = 706.5,
            High = 711.5,
            Low = 704.2,
            Close = 704.2,
            Volume = 1320927
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-24",
            Open = 706.9,
            High = 721,
            Low = 706.9,
            Close = 720.1,
            Volume = 1920411
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-25",
            Open = 720.8,
            High = 727.5,
            Low = 719.7,
            Close = 725.3,
            Volume = 1629198
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-26",
            Open = 722.9,
            High = 728.3,
            Low = 720.3,
            Close = 724.1,
            Volume = 1542866
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-27",
            Open = 724,
            High = 733.9,
            Low = 724,
            Close = 732.7,
            Volume = 1974026
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-04-31",
            Open = 731.7,
            High = 739.7,
            Low = 731.3,
            Close = 735.7,
            Volume = 2129545
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-01",
            Open = 734.5,
            High = 737.2,
            Low = 730.7,
            Close = 734.1,
            Volume = 1253593
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-02",
            Open = 732.5,
            High = 733,
            Low = 724.2,
            Close = 730.4,
            Volume = 1341807
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-03",
            Open = 729.3,
            High = 729.5,
            Low = 720.6,
            Close = 722.3,
            Volume = 1226253
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-06",
            Open = 724.9,
            High = 724.9,
            Low = 714.6,
            Close = 716.5,
            Volume = 1566059
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-07",
            Open = 719.8,
            High = 722,
            Low = 716.5,
            Close = 716.6,
            Volume = 1336754
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-08",
            Open = 724,
            High = 728.6,
            Low = 720.6,
            Close = 728.3,
            Volume = 1583701
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-09",
            Open = 722.9,
            High = 729.5,
            Low = 722.3,
            Close = 728.6,
            Volume = 988914
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-10",
            Open = 719.5,
            High = 725.9,
            Low = 716.4,
            Close = 719.4,
            Volume = 1216443
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-13",
            Open = 716.5,
            High = 725.4,
            Low = 716.5,
            Close = 718.4,
            Volume = 1258930
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-14",
            Open = 716.5,
            High = 722.5,
            Low = 713.1,
            Close = 718.3,
            Volume = 1306065
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-15",
            Open = 719,
            High = 723,
            Low = 717.3,
            Close = 718.9,
            Volume = 1214517
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-16",
            Open = 714.9,
            High = 716.6,
            Low = 703.3,
            Close = 710.4,
            Volume = 1982471
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-17",
            Open = 708.6,
            High = 708.8,
            Low = 688.5,
            Close = 691.7,
            Volume = 3402357
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-20",
            Open = 698.8,
            High = 702.5,
            Low = 693.4,
            Close = 693.7,
            Volume = 2082538
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-21",
            Open = 698.4,
            High = 702.8,
            Low = 692,
            Close = 695.9,
            Volume = 1465634
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-22",
            Open = 699.1,
            High = 700.9,
            Low = 693.1,
            Close = 697.5,
            Volume = 1184318
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-23",
            Open = 697.5,
            High = 702,
            Low = 687,
            Close = 701.9,
            Volume = 2171415
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-24",
            Open = 675.2,
            High = 689.4,
            Low = 673.5,
            Close = 675.2,
            Volume = 4449022
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-27",
            Open = 671,
            High = 672.3,
            Low = 663.3,
            Close = 668.3,
            Volume = 2641085
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-28",
            Open = 679,
            High = 680.3,
            Low = 673,
            Close = 680,
            Volume = 2173762
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-29",
            Open = 683,
            High = 687.4,
            Low = 681.4,
            Close = 684.1,
            Volume = 1932561
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-05-30",
            Open = 685.5,
            High = 692.3,
            Low = 683.6,
            Close = 692.1,
            Volume = 1597714
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-01",
            Open = 692.2,
            High = 700.6,
            Low = 692.1,
            Close = 699.2,
            Volume = 1344710
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-05",
            Open = 696.1,
            High = 696.9,
            Low = 688.9,
            Close = 694.5,
            Volume = 1462616
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-06",
            Open = 690,
            High = 701.7,
            Low = 689.1,
            Close = 697.8,
            Volume = 1411925
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-07",
            Open = 698.1,
            High = 698.2,
            Low = 688.2,
            Close = 695.4,
            Volume = 1304200
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-08",
            Open = 699.5,
            High = 705.7,
            Low = 696.4,
            Close = 705.6,
            Volume = 1575166
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-11",
            Open = 708,
            High = 716.5,
            Low = 707.2,
            Close = 715.1,
            Volume = 1111762
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-12",
            Open = 719.1,
            High = 722.9,
            Low = 715.9,
            Close = 720.6,
            Volume = 1336921
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-13",
            Open = 723.6,
            High = 724,
            Low = 716.9,
            Close = 717,
            Volume = 935876
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-14",
            Open = 721.6,
            High = 722.2,
            Low = 718,
            Close = 721,
            Volume = 950193
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-15",
            Open = 725.7,
            High = 725.7,
            Low = 719.1,
            Close = 719.9,
            Volume = 1279339
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-18",
            Open = 722.7,
            High = 736.1,
            Low = 721.2,
            Close = 733.8,
            Volume = 1295476
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-19",
            Open = 729.9,
            High = 737,
            Low = 729,
            Close = 737,
            Volume = 1227486
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-20",
            Open = 737.3,
            High = 742.1,
            Low = 737.1,
            Close = 741.2,
            Volume = 1289671
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-21",
            Open = 740.4,
            High = 741.7,
            Low = 735.8,
            Close = 738.6,
            Volume = 1026306
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-22",
            Open = 741.9,
            High = 743.2,
            Low = 736.6,
            Close = 742.7,
            Volume = 1259823
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-25",
            Open = 740.7,
            High = 742.6,
            Low = 737.5,
            Close = 739.8,
            Volume = 1032432
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-26",
            Open = 739,
            High = 741.7,
            Low = 734.3,
            Close = 738.4,
            Volume = 1186738
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-27",
            Open = 738.3,
            High = 744.5,
            Low = 737,
            Close = 741.8,
            Volume = 1512517
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-28",
            Open = 747,
            High = 748.6,
            Low = 739.3,
            Close = 745.9,
            Volume = 3530169
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-06-29",
            Open = 772.7,
            High = 778.5,
            Low = 766.8,
            Close = 768.8,
            Volume = 3841482
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-01",
            Open = 761.1,
            High = 780.4,
            Low = 761.1,
            Close = 772.9,
            Volume = 2700470
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-02",
            Open = 768.7,
            High = 775.8,
            Low = 767.9,
            Close = 771.1,
            Volume = 1784525
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-03",
            Open = 767.2,
            High = 773.2,
            Low = 766.8,
            Close = 773.2,
            Volume = 1287421
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-04",
            Open = 772.2,
            High = 774.1,
            Low = 768.8,
            Close = 771.6,
            Volume = 1140254
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-05",
            Open = 773.8,
            High = 783,
            Low = 772.3,
            Close = 782.2,
            Volume = 1801205
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-08",
            Open = 782,
            High = 782.6,
            Low = 778.1,
            Close = 781.8,
            Volume = 1107857
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-09",
            Open = 781.1,
            High = 788.9,
            Low = 780.6,
            Close = 784.3,
            Volume = 1318894
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-10",
            Open = 783.8,
            High = 786.8,
            Low = 782.8,
            Close = 784.7,
            Volume = 786363
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-11",
            Open = 785,
            High = 789.8,
            Low = 783,
            Close = 784.9,
            Volume = 975113
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-12",
            Open = 781.5,
            High = 783.4,
            Low = 780.4,
            Close = 783.2,
            Volume = 740498
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-15",
            Open = 783.8,
            High = 787.5,
            Low = 780.1,
            Close = 782.4,
            Volume = 938186
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-16",
            Open = 780.3,
            High = 781,
            Low = 773.4,
            Close = 777.1,
            Volume = 1028047
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-17",
            Open = 777.3,
            High = 780.8,
            Low = 773.5,
            Close = 779.9,
            Volume = 924226
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-18",
            Open = 780,
            High = 782.9,
            Low = 777,
            Close = 777.5,
            Volume = 719429
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-19",
            Open = 775,
            High = 777.1,
            Low = 773.1,
            Close = 775.4,
            Volume = 861546
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-22",
            Open = 773.3,
            High = 774.5,
            Low = 770,
            Close = 772.1,
            Volume = 951362
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-23",
            Open = 775.5,
            High = 776.4,
            Low = 771.8,
            Close = 772.1,
            Volume = 928232
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-24",
            Open = 770.6,
            High = 774.5,
            Low = 767.1,
            Close = 769.6,
            Volume = 1071999
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-25",
            Open = 767,
            High = 771.9,
            Low = 763.2,
            Close = 769.4,
            Volume = 926883
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-26",
            Open = 769,
            High = 776.1,
            Low = 765.9,
            Close = 769.5,
            Volume = 1166681
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-29",
            Open = 768.7,
            High = 775,
            Low = 766.6,
            Close = 772.1,
            Volume = 847565
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-30",
            Open = 769.3,
            High = 774.5,
            Low = 766.8,
            Close = 769.1,
            Volume = 1130029
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-07-31",
            Open = 767,
            High = 769.1,
            Low = 765.4,
            Close = 767,
            Volume = 1248556
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-01",
            Open = 769.3,
            High = 771,
            Low = 764.3,
            Close = 768.8,
            Volume = 925131
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-02",
            Open = 773,
            High = 773.9,
            Low = 768.4,
            Close = 771.5,
            Volume = 1072658
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-06",
            Open = 773.5,
            High = 782,
            Low = 771,
            Close = 780.1,
            Volume = 1442822
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-07",
            Open = 780,
            High = 782.7,
            Low = 776.2,
            Close = 780.4,
            Volume = 894021
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-08",
            Open = 778.6,
            High = 780.4,
            Low = 773.6,
            Close = 775.3,
            Volume = 1270264
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-09",
            Open = 770.1,
            High = 773.2,
            Low = 759.7,
            Close = 759.7,
            Volume = 1885496
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-12",
            Open = 755.1,
            High = 770.3,
            Low = 754,
            Close = 769,
            Volume = 1310986
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-13",
            Open = 764.5,
            High = 766.2,
            Low = 755.8,
            Close = 759.7,
            Volume = 1395046
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-14",
            Open = 759.6,
            High = 767.7,
            Low = 759.1,
            Close = 762.5,
            Volume = 1094490
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-15",
            Open = 762.9,
            High = 773.8,
            Low = 760,
            Close = 771.8,
            Volume = 1346751
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-16",
            Open = 769.8,
            High = 769.8,
            Low = 764.7,
            Close = 768.9,
            Volume = 2049338
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-19",
            Open = 772.4,
            High = 774,
            Low = 764.4,
            Close = 765.7,
            Volume = 1172824
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-20",
            Open = 769,
            High = 773.3,
            Low = 768.5,
            Close = 771.4,
            Volume = 978631
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-21",
            Open = 772.7,
            High = 777.2,
            Low = 768.3,
            Close = 776.2,
            Volume = 1167810
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-22",
            Open = 780,
            High = 789.9,
            Low = 778.4,
            Close = 787.2,
            Volume = 1486223
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-23",
            Open = 786.6,
            High = 788.9,
            Low = 784.1,
            Close = 786.9,
            Volume = 1411937
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-26",
            Open = 782.7,
            High = 782.7,
            Low = 773.1,
            Close = 774.2,
            Volume = 1533206
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-27",
            Open = 775.5,
            High = 786,
            Low = 774.3,
            Close = 783,
            Volume = 1153247
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-28",
            Open = 777.9,
            High = 781.8,
            Low = 775,
            Close = 781.6,
            Volume = 1109834
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-29",
            Open = 781.4,
            High = 785.8,
            Low = 774.2,
            Close = 775,
            Volume = 1314746
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-08-30",
            Open = 776.3,
            High = 780.9,
            Low = 774.1,
            Close = 777.3,
            Volume = 1585333
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-03",
            Open = 774.3,
            High = 776.1,
            Low = 769.5,
            Close = 772.6,
            Volume = 1278821
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-04",
            Open = 776,
            High = 778.7,
            Low = 772.9,
            Close = 776.4,
            Volume = 1201350
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-05",
            Open = 779.3,
            High = 782.1,
            Low = 775.6,
            Close = 776.5,
            Volume = 1461151
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-06",
            Open = 779,
            High = 780.5,
            Low = 775.5,
            Close = 776.9,
            Volume = 1070692
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-07",
            Open = 779.7,
            High = 779.7,
            Low = 770.8,
            Close = 775.1,
            Volume = 933158
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-10",
            Open = 777.7,
            High = 789.4,
            Low = 775.9,
            Close = 785.9,
            Volume = 1174923
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-11",
            Open = 786.7,
            High = 792.3,
            Low = 780.6,
            Close = 783.1,
            Volume = 1372461
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-12",
            Open = 783.8,
            High = 788.1,
            Low = 782.1,
            Close = 786.1,
            Volume = 937435
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-13",
            Open = 781.2,
            High = 781.2,
            Low = 773,
            Close = 778.2,
            Volume = 1365277
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-14",
            Open = 781.6,
            High = 784,
            Low = 776,
            Close = 778.5,
            Volume = 852487
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-17",
            Open = 779.8,
            High = 785.9,
            Low = 777.5,
            Close = 780,
            Volume = 1092973
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-18",
            Open = 787.9,
            High = 801.6,
            Low = 785.6,
            Close = 795.3,
            Volume = 2056903
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-19",
            Open = 798.9,
            High = 804.6,
            Low = 797.6,
            Close = 801.6,
            Volume = 1766798
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-20",
            Open = 803.3,
            High = 804,
            Low = 796,
            Close = 797,
            Volume = 1757528
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-21",
            Open = 795,
            High = 799.5,
            Low = 794,
            Close = 799.4,
            Volume = 1266181
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-24",
            Open = 804.9,
            High = 815.2,
            Low = 804.8,
            Close = 813.1,
            Volume = 1697514
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-25",
            Open = 816.7,
            High = 816.7,
            Low = 805.1,
            Close = 807.7,
            Volume = 1576404
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-26",
            Open = 806.3,
            High = 807,
            Low = 796.3,
            Close = 799.1,
            Volume = 1647733
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-27",
            Open = 801,
            High = 803.5,
            Low = 791.5,
            Close = 795.4,
            Volume = 2749221
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-28",
            Open = 808.4,
            High = 815.5,
            Low = 793.6,
            Close = 795.4,
            Volume = 4269902
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-09-31",
            Open = 795.5,
            High = 796.9,
            Low = 784,
            Close = 784.5,
            Volume = 2427284
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-01",
            Open = 782.9,
            High = 789.5,
            Low = 775.5,
            Close = 783.6,
            Volume = 2406356
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-02",
            Open = 778.2,
            High = 781.6,
            Low = 763.5,
            Close = 768.7,
            Volume = 1918414
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-03",
            Open = 767.3,
            High = 770,
            Low = 759,
            Close = 762.1,
            Volume = 1943175
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-04",
            Open = 750.7,
            High = 770.4,
            Low = 750.6,
            Close = 762,
            Volume = 2134812
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-07",
            Open = 774.5,
            High = 785.2,
            Low = 772.5,
            Close = 782.5,
            Volume = 1585070
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-08",
            Open = 783.4,
            High = 795.6,
            Low = 780.2,
            Close = 790.5,
            Volume = 1366873
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-09",
            Open = 779.9,
            High = 791.2,
            Low = 771.7,
            Close = 785.3,
            Volume = 2607121
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-10",
            Open = 791.2,
            High = 791.2,
            Low = 752.2,
            Close = 762.6,
            Volume = 4745183
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-11",
            Open = 756.5,
            High = 760.8,
            Low = 750.4,
            Close = 754,
            Volume = 2431815
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-14",
            Open = 755.6,
            High = 757.9,
            Low = 727.5,
            Close = 736.1,
            Volume = 3654385
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-15",
            Open = 747,
            High = 764.4,
            Low = 747,
            Close = 758.5,
            Volume = 2384001
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-16",
            Open = 755.2,
            High = 766.4,
            Low = 750.5,
            Close = 764.5,
            Volume = 1472594
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-17",
            Open = 766.9,
            High = 772.7,
            Low = 764.2,
            Close = 771.2,
            Volume = 1286961
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-18",
            Open = 771.4,
            High = 775,
            Low = 760,
            Close = 760.5,
            Volume = 1547145
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-21",
            Open = 762.6,
            High = 769.7,
            Low = 760.6,
            Close = 769.2,
            Volume = 1330639
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-22",
            Open = 772.6,
            High = 777,
            Low = 767,
            Close = 768.3,
            Volume = 1593108
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-23",
            Open = 767.7,
            High = 768.3,
            Low = 755.3,
            Close = 761,
            Volume = 1478417
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-25",
            Open = 764.3,
            High = 765,
            Low = 760.5,
            Close = 761.7,
            Volume = 587421
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-28",
            Open = 760,
            High = 779.5,
            Low = 759.8,
            Close = 768.2,
            Volume = 2188151
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-29",
            Open = 771.5,
            High = 778.5,
            Low = 768.2,
            Close = 770.8,
            Volume = 1616618
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-10-30",
            Open = 770.1,
            High = 773,
            Low = 754.8,
            Close = 758,
            Volume = 2392890
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-01",
            Open = 757.4,
            High = 759.9,
            Low = 737,
            Close = 747.9,
            Volume = 3017947
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-02",
            Open = 744.6,
            High = 754,
            Low = 743.1,
            Close = 750.5,
            Volume = 1452484
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-05",
            Open = 757.7,
            High = 763.9,
            Low = 752.9,
            Close = 762.5,
            Volume = 1394223
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-06",
            Open = 764.7,
            High = 768.8,
            Low = 757.3,
            Close = 759.1,
            Volume = 1690689
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-07",
            Open = 761,
            High = 771.4,
            Low = 755.8,
            Close = 771.2,
            Volume = 1760966
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-08",
            Open = 772.5,
            High = 778.2,
            Low = 767.2,
            Close = 776.4,
            Volume = 1488059
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-09",
            Open = 780,
            High = 789.4,
            Low = 779,
            Close = 789.3,
            Volume = 1821914
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-12",
            Open = 785,
            High = 791.3,
            Low = 784.4,
            Close = 789.3,
            Volume = 2104117
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-13",
            Open = 793.9,
            High = 804.4,
            Low = 793.3,
            Close = 796.1,
            Volume = 2145209
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-14",
            Open = 797.4,
            High = 804,
            Low = 794,
            Close = 797.1,
            Volume = 1704150
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-15",
            Open = 797.3,
            High = 803,
            Low = 792.9,
            Close = 797.9,
            Volume = 1626499
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-16",
            Open = 800.4,
            High = 800.9,
            Low = 790.3,
            Close = 790.8,
            Volume = 2443796
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-19",
            Open = 790.2,
            High = 797.7,
            Low = 786.3,
            Close = 794.2,
            Volume = 1232087
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-20",
            Open = 796.8,
            High = 798.6,
            Low = 793.3,
            Close = 796.4,
            Volume = 951014
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-21",
            Open = 795.8,
            High = 796.7,
            Low = 787.1,
            Close = 794.6,
            Volume = 1211346
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-22",
            Open = 792.4,
            High = 793.3,
            Low = 788.6,
            Close = 791.3,
            Volume = 972169
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-23",
            Open = 790.9,
            High = 792.7,
            Low = 787.3,
            Close = 789.9,
            Volume = 623944
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-27",
            Open = 790.7,
            High = 797.9,
            Low = 787.7,
            Close = 791.5,
            Volume = 789321
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-28",
            Open = 793.7,
            High = 794.2,
            Low = 783.2,
            Close = 785,
            Volume = 1153824
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-29",
            Open = 783.3,
            High = 785.9,
            Low = 778.9,
            Close = 782.8,
            Volume = 744272
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2016-11-30",
            Open = 782.8,
            High = 782.8,
            Low = 770.4,
            Close = 771.8,
            Volume = 1769950
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-03",
            Open = 778.8,
            High = 789.6,
            Low = 775.8,
            Close = 786.1,
            Volume = 1657268
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-04",
            Open = 788.4,
            High = 791.3,
            Low = 783.2,
            Close = 786.9,
            Volume = 1072958
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-05",
            Open = 786.1,
            High = 794.5,
            Low = 785,
            Close = 794,
            Volume = 1335167
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-06",
            Open = 795.3,
            High = 807.9,
            Low = 792.2,
            Close = 806.1,
            Volume = 1640170
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-09",
            Open = 806.4,
            High = 810,
            Low = 802.8,
            Close = 806.6,
            Volume = 1274645
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-10",
            Open = 807.9,
            High = 809.1,
            Low = 803.5,
            Close = 804.8,
            Volume = 1176780
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-11",
            Open = 805,
            High = 808.1,
            Low = 801.4,
            Close = 807.9,
            Volume = 1065936
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-12",
            Open = 807.1,
            High = 807.4,
            Low = 799.2,
            Close = 806.4,
            Volume = 1353057
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-13",
            Open = 807.5,
            High = 811.2,
            Low = 806.7,
            Close = 807.9,
            Volume = 1099215
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-17",
            Open = 807.1,
            High = 807.1,
            Low = 800.4,
            Close = 804.6,
            Volume = 1362115
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-18",
            Open = 805.8,
            High = 806.2,
            Low = 801,
            Close = 806.1,
            Volume = 1294407
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-19",
            Open = 805.1,
            High = 809.5,
            Low = 801.8,
            Close = 802.2,
            Volume = 919325
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-20",
            Open = 806.9,
            High = 806.9,
            Low = 801.7,
            Close = 805,
            Volume = 1670045
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-23",
            Open = 807.3,
            High = 820.9,
            Low = 803.7,
            Close = 819.3,
            Volume = 1963628
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-24",
            Open = 822.3,
            High = 825.9,
            Low = 817.8,
            Close = 823.9,
            Volume = 1474010
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-25",
            Open = 829.6,
            High = 835.8,
            Low = 825.1,
            Close = 835.7,
            Volume = 1627304
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-26",
            Open = 837.8,
            High = 838,
            Low = 827,
            Close = 832.1,
            Volume = 2973891
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-27",
            Open = 834.7,
            High = 842,
            Low = 820.4,
            Close = 823.3,
            Volume = 2965771
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-30",
            Open = 814.7,
            High = 815.8,
            Low = 799.8,
            Close = 802.3,
            Volume = 3246573
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-00-31",
            Open = 796.9,
            High = 801.3,
            Low = 790.5,
            Close = 796.8,
            Volume = 2160556
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-01",
            Open = 799.7,
            High = 801.2,
            Low = 791.2,
            Close = 795.7,
            Volume = 2029744
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-02",
            Open = 793.8,
            High = 802.7,
            Low = 792,
            Close = 798.5,
            Volume = 1532138
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-03",
            Open = 803,
            High = 806,
            Low = 800.4,
            Close = 801.5,
            Volume = 1463448
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-06",
            Open = 799.7,
            High = 801.7,
            Low = 795.3,
            Close = 801.3,
            Volume = 1184483
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-07",
            Open = 804,
            High = 810.5,
            Low = 801.8,
            Close = 807,
            Volume = 1241221
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-08",
            Open = 807,
            High = 811.8,
            Low = 803.2,
            Close = 808.4,
            Volume = 1155990
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-09",
            Open = 809.5,
            High = 810.7,
            Low = 804.5,
            Close = 809.6,
            Volume = 990391
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-10",
            Open = 811.7,
            High = 815.3,
            Low = 809.8,
            Close = 813.7,
            Volume = 1134976
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-13",
            Open = 816,
            High = 821,
            Low = 815.5,
            Close = 819.2,
            Volume = 1213324
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-14",
            Open = 819,
            High = 823,
            Low = 816,
            Close = 820.5,
            Volume = 1054732
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-15",
            Open = 819.4,
            High = 823,
            Low = 818.5,
            Close = 819,
            Volume = 1313617
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-16",
            Open = 819.9,
            High = 824.4,
            Low = 819,
            Close = 824.2,
            Volume = 1287626
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-17",
            Open = 823,
            High = 828.1,
            Low = 821.7,
            Close = 828.1,
            Volume = 1611039
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-21",
            Open = 828.7,
            High = 833.5,
            Low = 828.4,
            Close = 831.7,
            Volume = 1262337
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-22",
            Open = 828.7,
            High = 833.3,
            Low = 828.6,
            Close = 830.8,
            Volume = 987248
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-23",
            Open = 830.1,
            High = 832.5,
            Low = 822.9,
            Close = 831.3,
            Volume = 1472771
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-24",
            Open = 827.7,
            High = 829,
            Low = 824.2,
            Close = 828.6,
            Volume = 1392202
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-27",
            Open = 824.5,
            High = 830.5,
            Low = 824,
            Close = 829.3,
            Volume = 1101466
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-01-28",
            Open = 825.6,
            High = 828.5,
            Low = 820.2,
            Close = 823.2,
            Volume = 2260769
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-01",
            Open = 828.9,
            High = 836.3,
            Low = 827.3,
            Close = 835.2,
            Volume = 1496540
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-02",
            Open = 833.9,
            High = 834.5,
            Low = 829.6,
            Close = 830.6,
            Volume = 942476
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-03",
            Open = 830.6,
            High = 831.4,
            Low = 825.8,
            Close = 829.1,
            Volume = 896378
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-06",
            Open = 827,
            High = 828.9,
            Low = 822.4,
            Close = 827.8,
            Volume = 1109037
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-07",
            Open = 827.4,
            High = 833.4,
            Low = 826.5,
            Close = 831.9,
            Volume = 1037630
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-08",
            Open = 833.5,
            High = 838.1,
            Low = 831.8,
            Close = 835.4,
            Volume = 989773
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-09",
            Open = 836,
            High = 842,
            Low = 834.2,
            Close = 838.7,
            Volume = 1261517
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-10",
            Open = 843.3,
            High = 844.9,
            Low = 839.5,
            Close = 843.3,
            Volume = 1704024
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-13",
            Open = 844,
            High = 848.7,
            Low = 843.3,
            Close = 845.5,
            Volume = 1223647
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-14",
            Open = 843.6,
            High = 847.2,
            Low = 840.8,
            Close = 845.6,
            Volume = 780198
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-15",
            Open = 847.6,
            High = 848.6,
            Low = 840.8,
            Close = 847.2,
            Volume = 1381474
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-16",
            Open = 849,
            High = 850.9,
            Low = 846.1,
            Close = 848.8,
            Volume = 977560
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-17",
            Open = 851.6,
            High = 853.4,
            Low = 847.1,
            Close = 852.1,
            Volume = 1716471
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-20",
            Open = 850,
            High = 850.2,
            Low = 845.1,
            Close = 848.4,
            Volume = 1231521
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-21",
            Open = 851.4,
            High = 853.5,
            Low = 829,
            Close = 830.5,
            Volume = 2463484
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-22",
            Open = 831.9,
            High = 835.5,
            Low = 827.2,
            Close = 829.6,
            Volume = 1401465
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-23",
            Open = 821,
            High = 822.6,
            Low = 812.3,
            Close = 817.6,
            Volume = 3487056
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-24",
            Open = 820.1,
            High = 821.9,
            Low = 808.9,
            Close = 814.4,
            Volume = 1981006
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-27",
            Open = 807,
            High = 821.6,
            Low = 803.4,
            Close = 819.5,
            Volume = 1894990
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-28",
            Open = 820.4,
            High = 826,
            Low = 814,
            Close = 820.9,
            Volume = 1620542
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-29",
            Open = 825,
            High = 832.8,
            Low = 822.4,
            Close = 831.4,
            Volume = 1786321
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-30",
            Open = 833.5,
            High = 833.7,
            Low = 829,
            Close = 831.5,
            Volume = 1055339
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-02-31",
            Open = 829,
            High = 831.6,
            Low = 827.4,
            Close = 829.6,
            Volume = 1401893
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-03",
            Open = 829.2,
            High = 840.9,
            Low = 829.2,
            Close = 838.5,
            Volume = 1671503
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-04",
            Open = 831.4,
            High = 835.2,
            Low = 829,
            Close = 834.6,
            Volume = 1045363
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-05",
            Open = 835.5,
            High = 842.5,
            Low = 830.7,
            Close = 831.4,
            Volume = 1555328
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-06",
            Open = 832.4,
            High = 836.4,
            Low = 826.5,
            Close = 827.9,
            Volume = 1254433
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-07",
            Open = 828,
            High = 828.5,
            Low = 820.5,
            Close = 824.7,
            Volume = 1057253
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-10",
            Open = 825.4,
            High = 829.4,
            Low = 823.8,
            Close = 824.7,
            Volume = 978905
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-11",
            Open = 824.7,
            High = 827.4,
            Low = 817,
            Close = 823.4,
            Volume = 1079732
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-12",
            Open = 821.9,
            High = 826.7,
            Low = 821,
            Close = 824.3,
            Volume = 900480
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-13",
            Open = 822.1,
            High = 826.4,
            Low = 821.4,
            Close = 823.6,
            Volume = 1122362
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-17",
            Open = 825,
            High = 837.8,
            Low = 824.5,
            Close = 837.2,
            Volume = 895015
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-18",
            Open = 834.2,
            High = 838.9,
            Low = 832.7,
            Close = 836.8,
            Volume = 836722
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-19",
            Open = 839.8,
            High = 842.2,
            Low = 836.3,
            Close = 838.2,
            Volume = 954330
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-20",
            Open = 841.4,
            High = 845.2,
            Low = 839.3,
            Close = 841.6,
            Volume = 959031
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-21",
            Open = 842.9,
            High = 843.9,
            Low = 840.6,
            Close = 843.2,
            Volume = 1323583
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-24",
            Open = 851.2,
            High = 863.5,
            Low = 849.9,
            Close = 862.8,
            Volume = 1372541
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-25",
            Open = 865,
            High = 875,
            Low = 862.8,
            Close = 872.3,
            Volume = 1671972
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-26",
            Open = 874.2,
            High = 876,
            Low = 867.8,
            Close = 871.7,
            Volume = 1237167
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-27",
            Open = 873.6,
            High = 875.4,
            Low = 870.4,
            Close = 874.3,
            Volume = 2026816
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-03-28",
            Open = 910.7,
            High = 916.9,
            Low = 905.8,
            Close = 906,
            Volume = 3276255
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-01",
            Open = 901.9,
            High = 915.7,
            Low = 901.5,
            Close = 912.6,
            Volume = 2115993
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-02",
            Open = 909.6,
            High = 920.8,
            Low = 909.5,
            Close = 916.4,
            Volume = 1587219
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-03",
            Open = 914.9,
            High = 928.1,
            Low = 912.5,
            Close = 927,
            Volume = 1499532
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-04",
            Open = 926.1,
            High = 935.9,
            Low = 924.6,
            Close = 931.7,
            Volume = 1422144
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-05",
            Open = 933.5,
            High = 934.9,
            Low = 925.2,
            Close = 927.1,
            Volume = 1911275
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-08",
            Open = 926.1,
            High = 936.9,
            Low = 925.3,
            Close = 934.3,
            Volume = 1329825
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-09",
            Open = 937,
            High = 937.5,
            Low = 929.5,
            Close = 932.2,
            Volume = 1581809
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-10",
            Open = 932,
            High = 932,
            Low = 925.2,
            Close = 928.8,
            Volume = 1173925
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-11",
            Open = 925.3,
            High = 932.5,
            Low = 923,
            Close = 930.6,
            Volume = 835386
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-12",
            Open = 931.5,
            High = 933.4,
            Low = 927.9,
            Close = 932.2,
            Volume = 1050601
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-15",
            Open = 933,
            High = 938.3,
            Low = 929.3,
            Close = 937.1,
            Volume = 1108496
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-16",
            Open = 940,
            High = 943.1,
            Low = 937.6,
            Close = 943,
            Volume = 969479
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-17",
            Open = 935.7,
            High = 939.3,
            Low = 918.1,
            Close = 919.6,
            Volume = 2362072
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-18",
            Open = 921,
            High = 933.2,
            Low = 918.8,
            Close = 930.2,
            Volume = 1596897
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-19",
            Open = 931.5,
            High = 937.8,
            Low = 931,
            Close = 934,
            Volume = 1393024
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-22",
            Open = 935,
            High = 941.9,
            Low = 935,
            Close = 941.9,
            Volume = 1120385
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-23",
            Open = 947.9,
            High = 951.5,
            Low = 942.6,
            Close = 948.8,
            Volume = 1270817
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-24",
            Open = 953,
            High = 955.1,
            Low = 949.5,
            Close = 955,
            Volume = 1034199
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-25",
            Open = 957.3,
            High = 972.6,
            Low = 955.5,
            Close = 969.5,
            Volume = 1660474
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-26",
            Open = 969.7,
            High = 975,
            Low = 965,
            Close = 971.5,
            Volume = 1252010
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-30",
            Open = 970.3,
            High = 976.2,
            Low = 969.5,
            Close = 975.9,
            Volume = 1466654
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-04-31",
            Open = 975,
            High = 979.3,
            Low = 960.2,
            Close = 964.9,
            Volume = 2448067
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-01",
            Open = 969,
            High = 971.5,
            Low = 960,
            Close = 967,
            Volume = 1410458
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-02",
            Open = 969.5,
            High = 975.9,
            Low = 966,
            Close = 975.6,
            Volume = 1750955
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-05",
            Open = 976.5,
            High = 986.9,
            Low = 975.1,
            Close = 983.7,
            Volume = 1252106
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-06",
            Open = 983.2,
            High = 988.3,
            Low = 975.1,
            Close = 976.6,
            Volume = 1814624
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-07",
            Open = 979.6,
            High = 984.1,
            Low = 975.8,
            Close = 981.1,
            Volume = 1453874
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-08",
            Open = 982.4,
            High = 984.6,
            Low = 977.2,
            Close = 983.4,
            Volume = 1481916
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-09",
            Open = 984.5,
            High = 984.5,
            Low = 935.6,
            Close = 949.8,
            Volume = 3309389
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-12",
            Open = 939.6,
            High = 949.4,
            Low = 915.2,
            Close = 942.9,
            Volume = 3763529
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-13",
            Open = 951.9,
            High = 960,
            Low = 944.1,
            Close = 953.4,
            Volume = 2013337
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-14",
            Open = 959.9,
            High = 961.1,
            Low = 942.3,
            Close = 950.8,
            Volume = 1489715
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-15",
            Open = 934,
            High = 943.3,
            Low = 924.4,
            Close = 942.3,
            Volume = 2133050
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-16",
            Open = 940,
            High = 942,
            Low = 931.6,
            Close = 939.8,
            Volume = 3094711
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-19",
            Open = 950,
            High = 960,
            Low = 949,
            Close = 957.4,
            Volume = 1533336
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-20",
            Open = 957.5,
            High = 961.6,
            Low = 950,
            Close = 950.6,
            Volume = 1125990
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-21",
            Open = 953.6,
            High = 960.1,
            Low = 950.8,
            Close = 959.5,
            Volume = 1202233
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-22",
            Open = 958.7,
            High = 960.7,
            Low = 954.5,
            Close = 957.1,
            Volume = 941958
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-23",
            Open = 956.8,
            High = 966,
            Low = 954.2,
            Close = 965.6,
            Volume = 1527856
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-26",
            Open = 969.9,
            High = 973.3,
            Low = 950.8,
            Close = 952.3,
            Volume = 1598355
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-27",
            Open = 942.5,
            High = 948.3,
            Low = 926.9,
            Close = 927.3,
            Volume = 2579930
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-28",
            Open = 929,
            High = 942.8,
            Low = 916,
            Close = 940.5,
            Volume = 2721406
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-29",
            Open = 929.9,
            High = 931.3,
            Low = 910.6,
            Close = 917.8,
            Volume = 3299176
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-05-30",
            Open = 926,
            High = 926,
            Low = 908.3,
            Close = 908.7,
            Volume = 2090226
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-03",
            Open = 912.2,
            High = 913.9,
            Low = 894.8,
            Close = 898.7,
            Volume = 1710373
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-05",
            Open = 901.8,
            High = 914.5,
            Low = 898.5,
            Close = 911.7,
            Volume = 1813884
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-06",
            Open = 904.1,
            High = 914.9,
            Low = 899.7,
            Close = 906.7,
            Volume = 1424503
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-07",
            Open = 908.9,
            High = 921.5,
            Low = 908.9,
            Close = 918.6,
            Volume = 1637785
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-10",
            Open = 921.8,
            High = 930.4,
            Low = 919.6,
            Close = 928.8,
            Volume = 1192825
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-11",
            Open = 929.5,
            High = 931.4,
            Low = 922,
            Close = 930.1,
            Volume = 1113235
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-12",
            Open = 938.7,
            High = 946.3,
            Low = 934.5,
            Close = 943.8,
            Volume = 1532144
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-13",
            Open = 946.3,
            High = 954.5,
            Low = 943,
            Close = 947.2,
            Volume = 1294687
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-14",
            Open = 952,
            High = 956.9,
            Low = 948,
            Close = 956,
            Volume = 1053774
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-17",
            Open = 957,
            High = 960.7,
            Low = 949.2,
            Close = 953.4,
            Volume = 1165537
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-18",
            Open = 953,
            High = 968,
            Low = 950.6,
            Close = 965.4,
            Volume = 1153964
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-19",
            Open = 967.8,
            High = 973,
            Low = 964,
            Close = 970.9,
            Volume = 1224540
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-20",
            Open = 975,
            High = 975.9,
            Low = 961.5,
            Close = 968.1,
            Volume = 1624463
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-21",
            Open = 962.3,
            High = 973.2,
            Low = 960.1,
            Close = 972.9,
            Volume = 1711000
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-24",
            Open = 972.2,
            High = 986.2,
            Low = 970.8,
            Close = 980.3,
            Volume = 3248347
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-25",
            Open = 953.8,
            High = 959.7,
            Low = 945.4,
            Close = 950.7,
            Volume = 4660979
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-26",
            Open = 954.7,
            High = 955,
            Low = 942.3,
            Close = 947.8,
            Volume = 2088256
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-27",
            Open = 951.8,
            High = 951.8,
            Low = 920,
            Close = 934.1,
            Volume = 3212996
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-28",
            Open = 929.4,
            High = 943.8,
            Low = 927.5,
            Close = 941.5,
            Volume = 1846351
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-06-31",
            Open = 941.9,
            High = 943.6,
            Low = 926,
            Close = 930.5,
            Volume = 1970095
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-01",
            Open = 932.4,
            High = 937.5,
            Low = 929.3,
            Close = 930.8,
            Volume = 1277734
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-02",
            Open = 928.6,
            High = 932.6,
            Low = 916.7,
            Close = 930.4,
            Volume = 1824448
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-03",
            Open = 930.3,
            High = 932.2,
            Low = 922.2,
            Close = 923.6,
            Volume = 1202512
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-04",
            Open = 926.8,
            High = 930.3,
            Low = 923,
            Close = 928,
            Volume = 1082267
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-07",
            Open = 929.1,
            High = 931.7,
            Low = 926.5,
            Close = 929.4,
            Volume = 1032239
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-08",
            Open = 927.1,
            High = 935.8,
            Low = 925.6,
            Close = 926.8,
            Volume = 1061579
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-09",
            Open = 920.6,
            High = 926,
            Low = 917.3,
            Close = 922.9,
            Volume = 1192081
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-10",
            Open = 917.5,
            High = 919.3,
            Low = 906.1,
            Close = 907.2,
            Volume = 1823967
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-11",
            Open = 908,
            High = 917.8,
            Low = 905.6,
            Close = 914.4,
            Volume = 1206782
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-14",
            Open = 922.5,
            High = 924.7,
            Low = 918.2,
            Close = 922.7,
            Volume = 1064530
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-15",
            Open = 924.2,
            High = 926.5,
            Low = 919.8,
            Close = 922.2,
            Volume = 883369
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-16",
            Open = 925.3,
            High = 932.7,
            Low = 923.4,
            Close = 927,
            Volume = 1006711
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-17",
            Open = 925.8,
            High = 926.9,
            Low = 911,
            Close = 911,
            Volume = 1277238
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-18",
            Open = 910.3,
            High = 915.3,
            Low = 907.1,
            Close = 910.7,
            Volume = 1342689
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-21",
            Open = 910,
            High = 913,
            Low = 903.4,
            Close = 906.7,
            Volume = 943441
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-22",
            Open = 912.7,
            High = 925.9,
            Low = 911.5,
            Close = 924.7,
            Volume = 1166737
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-23",
            Open = 921.9,
            High = 929.9,
            Low = 919.4,
            Close = 927,
            Volume = 1090248
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-24",
            Open = 928.7,
            High = 930.8,
            Low = 915.5,
            Close = 921.3,
            Volume = 1270306
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-25",
            Open = 923.5,
            High = 925.6,
            Low = 915.5,
            Close = 915.9,
            Volume = 1053376
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-28",
            Open = 916,
            High = 919.2,
            Low = 911.9,
            Close = 913.8,
            Volume = 1086484
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-29",
            Open = 905.1,
            High = 923.3,
            Low = 905,
            Close = 921.3,
            Volume = 1185564
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-30",
            Open = 920,
            High = 930.8,
            Low = 919.6,
            Close = 929.6,
            Volume = 1301225
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-07-31",
            Open = 931.8,
            High = 942,
            Low = 931.8,
            Close = 939.3,
            Volume = 1582579
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-01",
            Open = 941.1,
            High = 942.5,
            Low = 935.1,
            Close = 937.3,
            Volume = 947374
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-05",
            Open = 933.1,
            High = 937,
            Low = 922,
            Close = 928.5,
            Volume = 1348292
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-06",
            Open = 930.1,
            High = 930.9,
            Low = 919.3,
            Close = 927.8,
            Volume = 1527650
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-07",
            Open = 931.7,
            High = 936.4,
            Low = 923.6,
            Close = 936,
            Volume = 1212743
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-08",
            Open = 936.5,
            High = 937,
            Low = 924.9,
            Close = 926.5,
            Volume = 1011538
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-11",
            Open = 934.3,
            High = 938.4,
            Low = 926.9,
            Close = 929.1,
            Volume = 1266991
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-12",
            Open = 932.6,
            High = 933.5,
            Low = 923.9,
            Close = 932.1,
            Volume = 1134397
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-13",
            Open = 930.7,
            High = 937.3,
            Low = 929.9,
            Close = 935.1,
            Volume = 1102631
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-14",
            Open = 931.3,
            High = 932.8,
            Low = 924,
            Close = 925.1,
            Volume = 1397644
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-15",
            Open = 924.7,
            High = 926.5,
            Low = 916.4,
            Close = 920.3,
            Volume = 2505430
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-18",
            Open = 920,
            High = 922.1,
            Low = 910.6,
            Close = 915,
            Volume = 1306922
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-19",
            Open = 917.4,
            High = 922.4,
            Low = 912.5,
            Close = 921.8,
            Volume = 936654
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-20",
            Open = 923,
            High = 933.9,
            Low = 922,
            Close = 931.6,
            Volume = 1669763
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-21",
            Open = 933,
            High = 936.5,
            Low = 923.8,
            Close = 932.5,
            Volume = 1290607
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-22",
            Open = 927.8,
            High = 934.7,
            Low = 926.5,
            Close = 928.5,
            Volume = 1052704
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-25",
            Open = 925.5,
            High = 926.4,
            Low = 909.7,
            Close = 921,
            Volume = 1856822
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-26",
            Open = 923.7,
            High = 930.8,
            Low = 921.1,
            Close = 924.9,
            Volume = 1666861
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-27",
            Open = 927.7,
            High = 949.9,
            Low = 927.7,
            Close = 944.5,
            Volume = 2212600
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-28",
            Open = 941.4,
            High = 950.7,
            Low = 940.5,
            Close = 949.5,
            Volume = 1020312
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-08-29",
            Open = 952,
            High = 959.8,
            Low = 951.5,
            Close = 959.1,
            Volume = 1580994
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-02",
            Open = 960,
            High = 962.5,
            Low = 947.8,
            Close = 953.3,
            Volume = 1283444
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-03",
            Open = 954,
            High = 958,
            Low = 949.1,
            Close = 957.8,
            Volume = 888346
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-04",
            Open = 957,
            High = 960.4,
            Low = 950.7,
            Close = 951.7,
            Volume = 952391
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-05",
            Open = 955.5,
            High = 970.9,
            Low = 955.2,
            Close = 970,
            Volume = 1213816
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-06",
            Open = 966.7,
            High = 979.5,
            Low = 963.4,
            Close = 978.9,
            Volume = 1173882
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-09",
            Open = 980,
            High = 985.4,
            Low = 976.1,
            Close = 977,
            Volume = 891355
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-10",
            Open = 980,
            High = 981.6,
            Low = 966.1,
            Close = 972.6,
            Volume = 968362
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-11",
            Open = 973.7,
            High = 990.7,
            Low = 972.3,
            Close = 989.3,
            Volume = 1693274
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-12",
            Open = 987.5,
            High = 994.1,
            Low = 985,
            Close = 987.8,
            Volume = 1262793
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-13",
            Open = 992,
            High = 997.2,
            Low = 989,
            Close = 989.7,
            Volume = 1169777
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-16",
            Open = 992.1,
            High = 993.9,
            Low = 984,
            Close = 992,
            Volume = 910543
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-17",
            Open = 990.3,
            High = 996.4,
            Low = 988.6,
            Close = 992.2,
            Volume = 1290186
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-18",
            Open = 991.8,
            High = 996.7,
            Low = 987,
            Close = 992.8,
            Volume = 1057581
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-19",
            Open = 986,
            High = 988.9,
            Low = 978.4,
            Close = 984.5,
            Volume = 1313575
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-20",
            Open = 989.4,
            High = 991,
            Low = 984.6,
            Close = 988.2,
            Volume = 1183186
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-23",
            Open = 989.5,
            High = 989.5,
            Low = 966.1,
            Close = 968.5,
            Volume = 1478448
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-24",
            Open = 970,
            High = 972.2,
            Low = 961,
            Close = 970.5,
            Volume = 1212153
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-25",
            Open = 968.4,
            High = 976.1,
            Low = 960.5,
            Close = 973.3,
            Volume = 1211262
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-26",
            Open = 980,
            High = 987.6,
            Low = 972.2,
            Close = 972.6,
            Volume = 2042149
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-27",
            Open = 1009.2,
            High = 1048.4,
            Low = 1008.2,
            Close = 1019.3,
            Volume = 5167689
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-30",
            Open = 1014,
            High = 1025,
            Low = 1007.5,
            Close = 1017.1,
            Volume = 2085062
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-09-31",
            Open = 1015.2,
            High = 1024,
            Low = 1010.4,
            Close = 1016.6,
            Volume = 1331391
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-01",
            Open = 1017.2,
            High = 1029.7,
            Low = 1017,
            Close = 1025.5,
            Volume = 1373444
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-02",
            Open = 1021.8,
            High = 1028.1,
            Low = 1013,
            Close = 1025.6,
            Volume = 1048970
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-03",
            Open = 1022.1,
            High = 1032.7,
            Low = 1020.3,
            Close = 1032.5,
            Volume = 1076350
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-06",
            Open = 1029,
            High = 1034.9,
            Low = 1025,
            Close = 1025.9,
            Volume = 1125185
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-07",
            Open = 1027.3,
            High = 1034,
            Low = 1025.1,
            Close = 1033.3,
            Volume = 1112331
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-08",
            Open = 1030.5,
            High = 1043.5,
            Low = 1028.5,
            Close = 1039.8,
            Volume = 1088716
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-09",
            Open = 1034,
            High = 1034,
            Low = 1019.7,
            Close = 1031.3,
            Volume = 1245246
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-10",
            Open = 1026.5,
            High = 1030.8,
            Low = 1025.3,
            Close = 1028.1,
            Volume = 720676
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-13",
            Open = 1023.4,
            High = 1031.6,
            Low = 1022.6,
            Close = 1025.8,
            Volume = 885779
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-14",
            Open = 1022.6,
            High = 1026.8,
            Low = 1014.1,
            Close = 1026,
            Volume = 959222
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-15",
            Open = 1019.2,
            High = 1024.1,
            Low = 1015.4,
            Close = 1020.9,
            Volume = 853992
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-16",
            Open = 1022.5,
            High = 1035.9,
            Low = 1022.5,
            Close = 1032.5,
            Volume = 1129688
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-17",
            Open = 1034,
            High = 1034.4,
            Low = 1017.8,
            Close = 1019.1,
            Volume = 1397064
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-20",
            Open = 1020.3,
            High = 1022.6,
            Low = 1017.5,
            Close = 1018.4,
            Volume = 953470
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-21",
            Open = 1023.3,
            High = 1035.1,
            Low = 1022.7,
            Close = 1034.5,
            Volume = 1096999
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-22",
            Open = 1035,
            High = 1039.7,
            Low = 1031.4,
            Close = 1036,
            Volume = 746878
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-24",
            Open = 1035.9,
            High = 1043.2,
            Low = 1035,
            Close = 1040.6,
            Volume = 536996
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-27",
            Open = 1040,
            High = 1055.5,
            Low = 1038.4,
            Close = 1054.2,
            Volume = 1307881
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-28",
            Open = 1055.1,
            High = 1062.4,
            Low = 1040,
            Close = 1047.4,
            Volume = 1424394
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-29",
            Open = 1042.7,
            High = 1044.1,
            Low = 1015.6,
            Close = 1021.7,
            Volume = 2459426
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-10-30",
            Open = 1022.4,
            High = 1028.5,
            Low = 1015,
            Close = 1021.4,
            Volume = 1724031
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-01",
            Open = 1015.8,
            High = 1022.5,
            Low = 1002,
            Close = 1010.2,
            Volume = 1909566
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-04",
            Open = 1012.7,
            High = 1016.1,
            Low = 995.6,
            Close = 998.7,
            Volume = 1906439
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-05",
            Open = 995.9,
            High = 1020.6,
            Low = 988.3,
            Close = 1005.1,
            Volume = 2067318
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-06",
            Open = 1001.5,
            High = 1025,
            Low = 1001.1,
            Close = 1018.4,
            Volume = 1271964
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-07",
            Open = 1020.4,
            High = 1034.2,
            Low = 1018.1,
            Close = 1030.9,
            Volume = 1458242
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-08",
            Open = 1037.5,
            High = 1042,
            Low = 1032.5,
            Close = 1037,
            Volume = 1290774
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-11",
            Open = 1035.5,
            High = 1043.8,
            Low = 1032,
            Close = 1041.1,
            Volume = 1192838
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-12",
            Open = 1039.6,
            High = 1050.3,
            Low = 1033.7,
            Close = 1040.5,
            Volume = 1279659
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-13",
            Open = 1046.1,
            High = 1046.7,
            Low = 1038.4,
            Close = 1040.6,
            Volume = 1282677
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-14",
            Open = 1045,
            High = 1058.5,
            Low = 1043.1,
            Close = 1049.2,
            Volume = 1558835
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-15",
            Open = 1054.6,
            High = 1067.6,
            Low = 1049.5,
            Close = 1064.2,
            Volume = 3275931
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-18",
            Open = 1066.1,
            High = 1078.5,
            Low = 1062,
            Close = 1077.1,
            Volume = 1554552
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-19",
            Open = 1075.2,
            High = 1076.8,
            Low = 1063.5,
            Close = 1070.7,
            Volume = 1338725
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-20",
            Open = 1071.8,
            High = 1073.4,
            Low = 1061.5,
            Close = 1065,
            Volume = 1268582
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-21",
            Open = 1065,
            High = 1069.3,
            Low = 1061.8,
            Close = 1063.6,
            Volume = 995703
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-22",
            Open = 1061.1,
            High = 1064.2,
            Low = 1059.4,
            Close = 1060.1,
            Volume = 755095
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-26",
            Open = 1058.1,
            High = 1060.1,
            Low = 1050.2,
            Close = 1056.7,
            Volume = 761237
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-27",
            Open = 1057.4,
            High = 1058.4,
            Low = 1048,
            Close = 1049.4,
            Volume = 1271911
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-28",
            Open = 1051.6,
            High = 1054.8,
            Low = 1044.8,
            Close = 1048.1,
            Volume = 837121
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2017-11-29",
            Open = 1046.7,
            High = 1049.7,
            Low = 1044.9,
            Close = 1046.4,
            Volume = 887511
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-02",
            Open = 1048.3,
            High = 1066.9,
            Low = 1045.2,
            Close = 1065,
            Volume = 1237564
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-03",
            Open = 1064.3,
            High = 1086.3,
            Low = 1063.2,
            Close = 1082.5,
            Volume = 1430170
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-04",
            Open = 1088,
            High = 1093.6,
            Low = 1084,
            Close = 1086.4,
            Volume = 1004605
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-05",
            Open = 1094,
            High = 1104.3,
            Low = 1092,
            Close = 1102.2,
            Volume = 1279123
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-08",
            Open = 1102.2,
            High = 1111.3,
            Low = 1101.6,
            Close = 1106.9,
            Volume = 1047603
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-09",
            Open = 1109.4,
            High = 1110.6,
            Low = 1101.2,
            Close = 1106.3,
            Volume = 902541
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-10",
            Open = 1097.1,
            High = 1104.6,
            Low = 1096.1,
            Close = 1102.6,
            Volume = 1042793
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-11",
            Open = 1106.3,
            High = 1106.5,
            Low = 1099.6,
            Close = 1105.5,
            Volume = 978292
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-12",
            Open = 1102.4,
            High = 1124.3,
            Low = 1101.2,
            Close = 1122.3,
            Volume = 1720533
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-16",
            Open = 1132.5,
            High = 1139.9,
            Low = 1117.8,
            Close = 1121.8,
            Volume = 1575261
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-17",
            Open = 1126.2,
            High = 1132.6,
            Low = 1117,
            Close = 1132,
            Volume = 1202639
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-18",
            Open = 1131.4,
            High = 1132.5,
            Low = 1117.5,
            Close = 1129.8,
            Volume = 1198234
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-19",
            Open = 1131.8,
            High = 1137.9,
            Low = 1128.3,
            Close = 1137.5,
            Volume = 1778229
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-22",
            Open = 1137.5,
            High = 1159.9,
            Low = 1135.1,
            Close = 1155.8,
            Volume = 1617975
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-23",
            Open = 1159.8,
            High = 1171.6,
            Low = 1158.8,
            Close = 1170,
            Volume = 1333056
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-24",
            Open = 1177.3,
            High = 1179.9,
            Low = 1161,
            Close = 1164.2,
            Volume = 1416625
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-25",
            Open = 1172.5,
            High = 1175.9,
            Low = 1162.8,
            Close = 1170.4,
            Volume = 1480540
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-26",
            Open = 1175.1,
            High = 1175.8,
            Low = 1158.1,
            Close = 1175.8,
            Volume = 2018755
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-29",
            Open = 1176.5,
            High = 1186.9,
            Low = 1172,
            Close = 1175.6,
            Volume = 1378913
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-30",
            Open = 1167.8,
            High = 1176.5,
            Low = 1163.5,
            Close = 1163.7,
            Volume = 1556346
        });
        this.Add(new StockGoogleItem()
        {
            Date = @"2018-00-31",
            Open = 1170.6,
            High = 1173,
            Low = 1159.1,
            Close = 1169.9,
            Volume = 1538688
        });
    }
}
