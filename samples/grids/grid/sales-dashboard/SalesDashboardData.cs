using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    // A KPI tile: the figure, its comparison, and whether the comparison is good news. IconClass
    // picks the avatar's palette family in index.css (rank-badge rank-N or icon-avg).
    public class SalesDashboardMetric
    {
        public string Label { get; set; }
        public string Value { get; set; }
        public string Delta { get; set; }
        public bool IsPositive { get; set; }
        public string Icon { get; set; }
        public string IconClass { get; set; }
    }

    public class SalesDashboardTrendPoint
    {
        public string Month { get; set; }
        public double Revenue { get; set; }
        public double TargetLine { get; set; }
    }

    public class SalesDashboardRegionShare
    {
        public string Region { get; set; }
        public double Value { get; set; }
    }

    public class SalesDashboardDealDay
    {
        public string Day { get; set; }
        public double Deals { get; set; }
    }

    // One row of the Recent Activity grid. StageClass is the pill's semantic class, decided here
    // (SalesDashboardStages.ClassFor) so the JavaScript cell template only renders it.
    public class SalesDashboardActivityRow
    {
        public string Company { get; set; }
        public string Region { get; set; }
        public string Stage { get; set; }
        public string StageClass { get; set; }
        public string Value { get; set; }
        public string Rep { get; set; }
        public string Source { get; set; }
        public string When { get; set; }
    }

    public class SalesDashboardLeader
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public string Quota { get; set; }
        public string Amount { get; set; }
        public string Delta { get; set; }
        public bool IsPositive { get; set; }

        // The top three ranks take a palette family each (index.css, rank-badge rank-N); the
        // rest keep the neutral badge.
        public string BadgeClass => Rank >= 1 && Rank <= 3 ? "rank-badge rank-" + Rank : "rank-badge";
    }

    public static class SalesDashboardStages
    {
        // Each deal stage has its own semantic pill (index.css, "Stage pills").
        public static string ClassFor(string stage)
        {
            switch (stage)
            {
                case "Closed Won": return "stage-win";
                case "Proposal Sent": return "stage-proposal";
                case "Negotiation": return "stage-negotiation";
                case "Qualified": return "stage-qualified";
                default: return "";
            }
        }
    }

    // Chart colours, one set per appearance. The charts paint to a canvas, so unlike the rest of
    // the sample they cannot read the palette through a CSS variable: every value is a literal
    // copy of a palette shade in index.css and changes along with it.
    //
    //               light                                dark
    //   Series      primary, warn, secondary, success    the same families, lighter
    //   Label       gray-700                             gray-500
    //   Gridline    gray-300                             gray-100
    //   Chip        transparent                          transparent
    //   Bubble      primary-500 + white                  primary-500 + near-black
    //
    // Series is in the donut's slice order, which is also the legend's. Chip is the canvas
    // rectangle the charts paint under an item tooltip: transparent, so the tooltip's own box is
    // the whole tooltip (events.js). Bubble is the value chip the crosshairs park on each axis.
    public class SalesDashboardChartPalette
    {
        public string[] Series { get; set; }
        public string[] Trend { get; set; }
        public string[] Deals { get; set; }
        public string Label { get; set; }
        public string Gridline { get; set; }
        public string SliceLabel { get; set; }
        public string Chip { get; set; }
        public string Bubble { get; set; }
        public string BubbleText { get; set; }

        // The chart parameters take brush lists as space-separated strings.
        public string SeriesBrushes => string.Join(" ", Series);
        public string TrendBrushes => string.Join(" ", Trend);
        public string DealsBrushes => string.Join(" ", Deals);

        public static readonly SalesDashboardChartPalette Light = new SalesDashboardChartPalette
        {
            Series = new[] { "#7f4cf6", "#b8690c", "#d84b98", "#17835f" },
            Trend = new[] { "#7f4cf6", "#17835f" },
            Deals = new[] { "#7f4cf6" },
            Label = "#445d7e",
            Gridline = "#d7dfe9",
            SliceLabel = "#445d7e",
            Chip = "transparent",
            Bubble = "#7f4cf6",
            BubbleText = "#ffffff"
        };

        public static readonly SalesDashboardChartPalette Dark = new SalesDashboardChartPalette
        {
            Series = new[] { "#a78bfa", "#e0a33c", "#f07cb8", "#35c48c" },
            Trend = new[] { "#a78bfa", "#35c48c" },
            Deals = new[] { "#a78bfa" },
            Label = "#a3bad6",
            Gridline = "#29405c",
            SliceLabel = "#a3bad6",
            Chip = "transparent",
            Bubble = "#a78bfa",
            BubbleText = "#17202b"
        };
    }

    public static class SalesDashboardData
    {
        public static List<SalesDashboardMetric> CreateMetrics()
        {
            return new List<SalesDashboardMetric>
            {
                new SalesDashboardMetric { Label = "Revenue MTD", Value = "$842.3K", Delta = "12.4% vs target", IsPositive = true, Icon = "attach_money", IconClass = "rank-badge rank-1" },
                new SalesDashboardMetric { Label = "Quota Attainment", Value = "94%", Delta = "1.3 pts vs last month", IsPositive = true, Icon = "percent", IconClass = "rank-badge rank-2" },
                new SalesDashboardMetric { Label = "Deals Closed (Mtd)", Value = "37", Delta = "6 vs last month", IsPositive = true, Icon = "tag", IconClass = "rank-badge rank-3" },
                new SalesDashboardMetric { Label = "Avg Deal Size", Value = "$22.8K", Delta = "1.9% vs last month", IsPositive = false, Icon = "diamond", IconClass = "icon-avg" }
            };
        }

        public static List<SalesDashboardTrendPoint> CreateRevenueTrend()
        {
            return new List<SalesDashboardTrendPoint>
            {
                new SalesDashboardTrendPoint { Month = "Jan", Revenue = 648, TargetLine = 635 },
                new SalesDashboardTrendPoint { Month = "Feb", Revenue = 662, TargetLine = 646 },
                new SalesDashboardTrendPoint { Month = "Mar", Revenue = 684, TargetLine = 658 },
                new SalesDashboardTrendPoint { Month = "Apr", Revenue = 702, TargetLine = 672 },
                new SalesDashboardTrendPoint { Month = "May", Revenue = 728, TargetLine = 696 },
                new SalesDashboardTrendPoint { Month = "Jun", Revenue = 760, TargetLine = 724 },
                new SalesDashboardTrendPoint { Month = "Jul", Revenue = 790, TargetLine = 752 }
            };
        }

        public static List<SalesDashboardRegionShare> CreateRevenueByRegion()
        {
            return new List<SalesDashboardRegionShare>
            {
                new SalesDashboardRegionShare { Region = "West", Value = 37 },
                new SalesDashboardRegionShare { Region = "East", Value = 32 },
                new SalesDashboardRegionShare { Region = "Central", Value = 22 },
                new SalesDashboardRegionShare { Region = "International", Value = 9 }
            };
        }

        public static List<SalesDashboardDealDay> CreateWeeklyDeals()
        {
            return new List<SalesDashboardDealDay>
            {
                new SalesDashboardDealDay { Day = "Mon", Deals = 18 },
                new SalesDashboardDealDay { Day = "Tue", Deals = 23 },
                new SalesDashboardDealDay { Day = "Wed", Deals = 16 },
                new SalesDashboardDealDay { Day = "Thu", Deals = 29 },
                new SalesDashboardDealDay { Day = "Fri", Deals = 35 },
                new SalesDashboardDealDay { Day = "Sat", Deals = 42 },
                new SalesDashboardDealDay { Day = "Sun", Deals = 25 }
            };
        }

        public static List<SalesDashboardLeader> CreateLeaderboard()
        {
            return new List<SalesDashboardLeader>
            {
                new SalesDashboardLeader { Rank = 1, Name = "Dana Voss", Quota = "128% of quota", Amount = "$312,400", Delta = "18%", IsPositive = true },
                new SalesDashboardLeader { Rank = 2, Name = "Marcus Ibe", Quota = "116% of quota", Amount = "$284,900", Delta = "8%", IsPositive = true },
                new SalesDashboardLeader { Rank = 3, Name = "Priya Shah", Quota = "104% of quota", Amount = "$256,100", Delta = "14%", IsPositive = true },
                new SalesDashboardLeader { Rank = 4, Name = "Tom Reyes", Quota = "98% of quota", Amount = "$231,700", Delta = "-2%", IsPositive = false },
                new SalesDashboardLeader { Rank = 5, Name = "Elena Cruz", Quota = "91% of quota", Amount = "$198,300", Delta = "-5%", IsPositive = false }
            };
        }

        public static List<SalesDashboardActivityRow> CreateActivityRows()
        {
            var rows = new List<SalesDashboardActivityRow>
            {
                new SalesDashboardActivityRow { Company = "Vantage Corp", Region = "West", Stage = "Closed Won", Value = "$48,200", Rep = "Dana Voss", Source = "Referral", When = "2h ago" },
                new SalesDashboardActivityRow { Company = "Northfield Retail", Region = "Central", Stage = "Proposal Sent", Value = "$22,000", Rep = "Priya Shah", Source = "Inbound", When = "5h ago" },
                new SalesDashboardActivityRow { Company = "Callisto Systems", Region = "East", Stage = "Negotiation", Value = "$67,500", Rep = "Marcus Ibe", Source = "Outbound", When = "1d ago" },
                new SalesDashboardActivityRow { Company = "Bright Path LLC", Region = "West", Stage = "Closed Won", Value = "$15,300", Rep = "Tom Reyes", Source = "Partner", When = "1d ago" },
                new SalesDashboardActivityRow { Company = "Ferro Industrial", Region = "International", Stage = "Qualified", Value = "$91,000", Rep = "Elena Cruz", Source = "Conference", When = "2d ago" }
            };

            foreach (var row in rows)
            {
                row.StageClass = SalesDashboardStages.ClassFor(row.Stage);
            }

            return rows;
        }
    }
}
