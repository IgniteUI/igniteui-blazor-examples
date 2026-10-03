using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;

namespace Infragistics.Samples
{
    // Everything an expanded row renders. Serialized camel-cased (the chart series take their titles
    // from these member names, as in the Angular sample) into FleetManagementRecord.Detail.
    public class FleetManagementDetail
    {
        public string Make { get; set; }
        public string BodyType { get; set; }
        public FleetManagementVehicleSpecs Specs { get; set; }
        public string Doors { get; set; }
        public string Seats { get; set; }
        public string ColorName { get; set; }
        public string ColorHex { get; set; }
        public string PhotoAlt { get; set; }
        public IReadOnlyList<string> PhotoUrls { get; set; }

        public FleetManagementTripSummary TripSummary { get; set; }
        public List<FleetManagementTripRow> TripRows { get; set; }
        public string MaintenanceNotice { get; set; }
        public List<FleetManagementMaintenanceRow> MaintenanceRows { get; set; }
        public string TotalCost { get; set; }
        public string TopCostCategory { get; set; }
        public string PeakSpendMonth { get; set; }
        public List<FleetManagementCostPoint> CostDistribution { get; set; }
        public List<FleetManagementSpendPoint> MonthlySpend { get; set; }
        public FleetManagementUtilization Utilization { get; set; }
        public List<FleetManagementUtilizationPoint> UtilizationSeries { get; set; }
        public string UtilizationYoY { get; set; }
        public int UtilizationCurrentYear { get; set; }
        public int UtilizationPriorYear { get; set; }
    }

    public class FleetManagementTripSummary
    {
        public int Trips { get; set; }
        public string TotalDistance { get; set; }
        public string AvgTrip { get; set; }
    }

    public class FleetManagementTripRow
    {
        public string Date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string StartMeter { get; set; }
        public string EndMeter { get; set; }
        public string Distance { get; set; }
        public string Duration { get; set; }
        public string Driver { get; set; }
    }

    public class FleetManagementMaintenanceRow
    {
        public string Date { get; set; }
        public string Service { get; set; }
        public string Odometer { get; set; }
        public string Cost { get; set; }
        public string Status { get; set; }

        // The pill's class, from the status: success once done, warn while scheduled.
        public string Tone { get; set; }
    }

    public class FleetManagementCostPoint
    {
        public string Label { get; set; }
        public string DisplayLabel { get; set; }
        public string Percentage { get; set; }
        public double Value { get; set; }
        public string Tone { get; set; }
    }

    public class FleetManagementSpendPoint
    {
        public string Month { get; set; }
        public double Spend { get; set; }
    }

    public class FleetManagementUtilization
    {
        public string Rate { get; set; }
        public string ActiveHours { get; set; }
        public string IdleHours { get; set; }
        public int Trips { get; set; }
    }

    public class FleetManagementUtilizationPoint
    {
        public string Month { get; set; }
        public double PriorYear { get; set; }
        public double CurrentYear { get; set; }
    }

    // The figures behind the expanded row. Every one derives from the vehicle (its id, mileage, city
    // and status), so the sample does not need a data set per vehicle. A line-by-line port of the
    // Angular sample's fleetDetail functions, with its en-US number formatting.
    public static class FleetManagementDetails
    {
        private static readonly CultureInfo EnUs = CultureInfo.GetCultureInfo("en-US");

        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

        private static readonly string[] Drivers = { "M. Alvarez", "R. Chen", "S. Patel", "J. Walker", "A. Brooks", "T. Nguyen" };

        private static readonly string[] Services = { "Tire rotation & balance", "Brake fluid inspection", "Air filter replacement", "Multi-point inspection" };

        private static readonly string[] Months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        private static readonly double[] SeasonalSpend = { 118, 148, 208, 238, 218, 258, 278, 208, 188, 228, 208, 178 };

        public static string ToJson(FleetManagementDetail detail)
        {
            return JsonSerializer.Serialize(detail, JsonOptions);
        }

        // hasPhoto is false once every photo of the vehicle has failed to load in the browser.
        public static FleetManagementDetail Build(FleetManagementVehicle vehicle, bool hasPhoto, int currentYear)
        {
            var color = FleetManagementPhotos.PaintColor(vehicle.PhotoKey);
            var doorsSeats = vehicle.Specs.DoorsSeats.Split(" / ");
            var costDistribution = CostDistribution(vehicle);
            var monthlySpend = MonthlyOperatingSpend(vehicle);

            return new FleetManagementDetail
            {
                Make = vehicle.Make,
                BodyType = vehicle.Type,
                Specs = vehicle.Specs,
                Doors = doorsSeats[0],
                Seats = doorsSeats.Length > 1 ? doorsSeats[1] : "",
                ColorName = color.Name,
                ColorHex = color.Hex,

                // Colour first, so the alt text says what the picture shows.
                PhotoAlt = color.Name + " " + vehicle.Make + " " + vehicle.Model,
                PhotoUrls = hasPhoto ? FleetManagementPhotos.PhotoUrls(vehicle) : Array.Empty<string>(),

                TripSummary = TripSummary(vehicle),
                TripRows = TripHistory(vehicle),
                MaintenanceNotice = MaintenanceNotice(vehicle),
                MaintenanceRows = MaintenanceRows(vehicle),
                TotalCost = TotalCost(vehicle),
                TopCostCategory = TopCostCategory(costDistribution),
                PeakSpendMonth = PeakSpendMonth(monthlySpend),
                CostDistribution = costDistribution,
                MonthlySpend = monthlySpend,
                Utilization = UtilizationSummary(vehicle),
                UtilizationSeries = UtilizationSeries(vehicle),
                UtilizationYoY = UtilizationYoY(vehicle),

                // Relative to today, so the sample does not date itself.
                UtilizationCurrentYear = currentYear,
                UtilizationPriorYear = currentYear - 1
            };
        }

        public static int Seed(FleetManagementVehicle vehicle)
        {
            var digits = new string(vehicle.Id.Where(char.IsDigit).ToArray());
            return int.TryParse(digits, NumberStyles.None, CultureInfo.InvariantCulture, out var seed) && seed != 0 ? seed : 1;
        }

        private static string City(FleetManagementVehicle vehicle)
        {
            return vehicle.LocationCity.Split(',')[0];
        }

        private static double MileageValue(FleetManagementVehicle vehicle)
        {
            var digits = new string(vehicle.Specs.Mileage.Where(char.IsDigit).ToArray());
            return double.TryParse(digits, NumberStyles.None, CultureInfo.InvariantCulture, out var mileage) ? mileage : 0;
        }

        private static double NextServiceMileage(FleetManagementVehicle vehicle)
        {
            return Math.Ceiling((MileageValue(vehicle) + 3200) / 5000) * 5000;
        }

        private static string DriverName(FleetManagementVehicle vehicle, int offset)
        {
            return Drivers[(Seed(vehicle) + offset) % Drivers.Length];
        }

        // Math.round: halves go up.
        private static double RoundHalfUp(double value)
        {
            return Math.Floor(value + 0.5);
        }

        // toLocaleString("en-US") of a rounded number: 28,140.
        private static string WholeNumber(double value)
        {
            return RoundHalfUp(value).ToString("#,0", EnUs);
        }

        // toLocaleString("en-US", { minimumFractionDigits: 1, maximumFractionDigits: 1 }): 28,217.3.
        private static string OneDecimal(double value)
        {
            return value.ToString("#,0.0", EnUs);
        }

        // Number.toFixed(1), no grouping: 12.2.
        private static string Fixed1(double value)
        {
            return value.ToString("0.0", EnUs);
        }

        // toLocaleString("en-US") of a whole number, grouped.
        private static string Grouped(double value)
        {
            return value.ToString("#,0.###", EnUs);
        }

        private static FleetManagementTripSummary TripSummary(FleetManagementVehicle vehicle)
        {
            var seed = Seed(vehicle);
            var trips = 18 + (seed % 8);
            double totalMiles = 248 + (seed % 9) * 16;
            return new FleetManagementTripSummary
            {
                Trips = trips,
                TotalDistance = WholeNumber(totalMiles) + " mi",
                AvgTrip = Fixed1(totalMiles / trips) + " mi"
            };
        }

        private static List<FleetManagementTripRow> TripHistory(FleetManagementVehicle vehicle)
        {
            var seed = Seed(vehicle);
            var city = City(vehicle);
            var baseDistance = 8.4 + (seed % 5) * 1.3;
            var currentMileage = MileageValue(vehicle);

            // Rounded to one decimal, as Number(value.toFixed(1)) does.
            var tripDistances = new[] { baseDistance + 4.5, baseDistance + 0.1, baseDistance + 8.8, baseDistance + 8.1, baseDistance + 5.2, baseDistance + 6.6 }
                .Select(value => double.Parse(Fixed1(value), EnUs))
                .ToArray();

            // The odometer runs backwards from today's reading: each trip ends where the next one
            // (in time) starts.
            var runningMeter = currentMileage + tripDistances.Aggregate(0.0, (sum, value) => sum + value);

            FleetManagementTripRow Trip(string date, string from, string to, int index, int duration, int driverOffset)
            {
                var endMeter = runningMeter;
                var startMeter = Math.Max(0, endMeter - tripDistances[index]);
                runningMeter = startMeter;
                return new FleetManagementTripRow
                {
                    Date = date,
                    From = from,
                    To = to,
                    StartMeter = OneDecimal(startMeter) + " mi",
                    EndMeter = OneDecimal(endMeter) + " mi",
                    Distance = Fixed1(tripDistances[index]) + " mi",
                    Duration = duration + " min",
                    Driver = DriverName(vehicle, driverOffset)
                };
            }

            return new List<FleetManagementTripRow>
            {
                Trip("Jul 22", "Depot - " + city, "Client Site - " + city, 0, 24 + (seed % 9), 0),
                Trip("Jul 21", "Client Site - " + city, "Depot - " + city, 1, 19 + (seed % 6), 0),
                Trip("Jul 19", "Depot - " + city, "Warehouse - " + city, 2, 32 + (seed % 10), 1),
                Trip("Jul 17", "Warehouse - " + city, "Depot - " + city, 3, 30 + (seed % 9), 1),
                Trip("Jul 15", "Depot - " + city, "Regional Office - " + city, 4, 26 + (seed % 8), 2),
                Trip("Jul 13", "Regional Office - " + city, "Service Hub - " + city, 5, 28 + (seed % 7), 3)
            };
        }

        private static string NextService(FleetManagementVehicle vehicle)
        {
            return Services[Seed(vehicle) % Services.Length];
        }

        private static string MaintenanceNotice(FleetManagementVehicle vehicle)
        {
            return "Next service due: " + NextService(vehicle) + " \u00B7 est. " + WholeNumber(NextServiceMileage(vehicle)) + " mi";
        }

        private static List<FleetManagementMaintenanceRow> MaintenanceRows(FleetManagementVehicle vehicle)
        {
            var mileage = MileageValue(vehicle);
            var dueMileage = NextServiceMileage(vehicle);

            FleetManagementMaintenanceRow Row(string date, string service, string odometer, string cost, string status)
            {
                return new FleetManagementMaintenanceRow
                {
                    Date = date,
                    Service = service,
                    Odometer = odometer,
                    Cost = cost,
                    Status = status,
                    Tone = status == "Completed" ? "success" : "warn"
                };
            }

            return new List<FleetManagementMaintenanceRow>
            {
                Row("Jun 28, 2026", "Oil & filter change", WholeNumber(Math.Max(0, mileage - 2700)) + " mi", "$85", "Completed"),
                Row("Mar 14, 2026", "Brake pad replacement (front)", WholeNumber(Math.Max(0, mileage - 6050)) + " mi", "$340", "Completed"),
                Row("Dec 02, 2025", "Annual inspection", WholeNumber(Math.Max(0, mileage - 11500)) + " mi", "$120", "Completed"),
                Row("Aug 30, 2026", NextService(vehicle), "est. " + WholeNumber(dueMileage) + " mi", "\u2014", "Scheduled")
            };
        }

        private static List<FleetManagementCostPoint> CostItems(FleetManagementVehicle vehicle)
        {
            var seed = Seed(vehicle);
            var maintenanceBase = vehicle.Status == FleetManagementStatus.InMaintenance ? 520 : 280;

            // Slice order, and each slice's tone: the donut's brushes and the legend dots follow it.
            return new List<FleetManagementCostPoint>
            {
                new FleetManagementCostPoint { Label = "Fuel / charging", Value = 360 + (seed % 5) * 26, Tone = "fuel" },
                new FleetManagementCostPoint { Label = "Maintenance", Value = maintenanceBase + (seed % 4) * 25, Tone = "maintenance" },
                new FleetManagementCostPoint { Label = "Insurance", Value = 180 + (seed % 3) * 30, Tone = "insurance" },
                new FleetManagementCostPoint { Label = "Tolls & fees", Value = 54 + (seed % 6) * 7, Tone = "tolls" }
            };
        }

        private static List<FleetManagementCostPoint> CostDistribution(FleetManagementVehicle vehicle)
        {
            var items = CostItems(vehicle);
            var total = items.Sum(item => item.Value);
            foreach (var item in items)
            {
                var share = RoundHalfUp(item.Value / total * 100).ToString(CultureInfo.InvariantCulture) + "%";
                item.DisplayLabel = share;
                item.Percentage = share;
            }

            return items;
        }

        private static string TotalCost(FleetManagementVehicle vehicle)
        {
            return "$" + Grouped(CostItems(vehicle).Sum(item => item.Value));
        }

        // The first of the largest, as a reduce keeping the maximum does.
        private static string TopCostCategory(List<FleetManagementCostPoint> distribution)
        {
            var top = distribution[0];
            foreach (var point in distribution)
            {
                if (point.Value > top.Value)
                {
                    top = point;
                }
            }

            return top.Label + " \u00B7 " + top.Percentage;
        }

        private static string PeakSpendMonth(List<FleetManagementSpendPoint> monthlySpend)
        {
            var peak = monthlySpend[0];
            foreach (var point in monthlySpend)
            {
                if (point.Spend > peak.Spend)
                {
                    peak = point;
                }
            }

            return peak.Month + " \u00B7 $" + Grouped(peak.Spend);
        }

        private static List<FleetManagementSpendPoint> MonthlyOperatingSpend(FleetManagementVehicle vehicle)
        {
            var seed = Seed(vehicle);
            return Months.Select((month, index) =>
            {
                var variability = ((seed + index * 7) % 5) * 10;
                var maintenanceAdjustment = vehicle.Status == FleetManagementStatus.InMaintenance && (index == 6 || index == 7) ? 22 : 0;
                var utilizationAdjustment = vehicle.Status == FleetManagementStatus.Available && index >= 8 ? -12 : 0;
                return new FleetManagementSpendPoint { Month = month, Spend = SeasonalSpend[index] + variability + maintenanceAdjustment + utilizationAdjustment };
            }).ToList();
        }

        private static FleetManagementUtilization UtilizationSummary(FleetManagementVehicle vehicle)
        {
            var seed = Seed(vehicle);
            var inMaintenance = vehicle.Status == FleetManagementStatus.InMaintenance;
            var available = vehicle.Status == FleetManagementStatus.Available;
            var rateValue = Math.Max(52, 76 - (inMaintenance ? 9 : 0) - (available ? 4 : 0) + (seed % 5));
            var activeHours = 92 + (seed % 16) * 2;
            var idleHours = Math.Max(18, 44 - (seed % 7) * 2 + (available ? 8 : 0));
            return new FleetManagementUtilization
            {
                Rate = rateValue + "%",
                ActiveHours = activeHours + "h",
                IdleHours = idleHours + "h",
                Trips = 18 + (seed % 8)
            };
        }

        private static List<FleetManagementUtilizationPoint> UtilizationSeries(FleetManagementVehicle vehicle)
        {
            var seed = Seed(vehicle);
            var priorBase = 160 + (seed % 5) * 14;
            var uplift = 18 + (seed % 4) * 9;
            var inMaintenance = vehicle.Status == FleetManagementStatus.InMaintenance;
            var available = vehicle.Status == FleetManagementStatus.Available;

            FleetManagementUtilizationPoint Point(string month, int prior, int current)
            {
                return new FleetManagementUtilizationPoint { Month = month, PriorYear = priorBase + prior, CurrentYear = priorBase + current };
            }

            return new List<FleetManagementUtilizationPoint>
            {
                Point("Jan", 0, 42),
                Point("Feb", 22, 4),
                Point("Mar", 140, 118),
                Point("Apr", 316, 278),
                Point("May", 418, 472),
                Point("Jun", 502, 564),
                Point("Jul", 560, 586 + (inMaintenance ? -24 : uplift)),
                Point("Aug", 594, 650 + (available ? -22 : uplift)),
                Point("Sep", 506, 480 + (available ? -38 : 0)),
                Point("Oct", 442, 646),
                Point("Nov", 154, 354),
                Point("Dec", 52, 198)
            };
        }

        private static string UtilizationYoY(FleetManagementVehicle vehicle)
        {
            var series = UtilizationSeries(vehicle);
            var prior = series.Sum(point => point.PriorYear);
            var current = series.Sum(point => point.CurrentYear);
            if (prior == 0)
            {
                return "";
            }

            var change = (current - prior) / prior * 100;
            return (change >= 0 ? "\u2191" : "\u2193") + " " + Fixed1(Math.Abs(change)) + "% YoY";
        }
    }
}
