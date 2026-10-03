using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Samples
{
    // The three states a vehicle can be in. The names are also the text the Status column shows.
    public static class FleetManagementStatus
    {
        public const string Active = "Active";
        public const string Available = "Available";
        public const string InMaintenance = "In Maintenance";

        public static readonly IReadOnlyList<string> All = new[] { Active, Available, InMaintenance };
    }

    public class FleetManagementVehicleSpecs
    {
        public string Engine { get; set; }
        public string Generation { get; set; }
        public int Year { get; set; }
        public string FuelType { get; set; }
        public string Power { get; set; }
        public string Mileage { get; set; }
        public string DoorsSeats { get; set; }
        public string Cubature { get; set; }
        public string Transmission { get; set; }
        public string Msrp { get; set; }
        public string TollPassId { get; set; }
    }

    public class FleetManagementVehicle
    {
        public string Id { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }

        // The folder of the photo manifest (FleetManagementPhotos.CatalogJson) the vehicle's photos
        // come from. The paint colour is read from the same key, so the swatch cannot disagree with
        // the car in the picture.
        public string PhotoKey { get; set; }
        public string Vin { get; set; }
        public string Status { get; set; }
        public string LocationCity { get; set; }
        public string LocationGps { get; set; }
        public FleetManagementVehicleSpecs Specs { get; set; }

        // Status is the only field that changes, so a shallow copy is enough.
        public FleetManagementVehicle Copy()
        {
            return (FleetManagementVehicle)MemberwiseClone();
        }
    }

    public static class FleetManagementFleet
    {
        public static readonly IReadOnlyList<FleetManagementVehicle> SeedVehicles = new List<FleetManagementVehicle>
        {
            new FleetManagementVehicle { Id = "A00101", LicensePlate = "KVG 8850", Make = "Ford", Model = "Focus", Type = "Hatchback", PhotoKey = "Ford Focus blue", Vin = "1FADP3F24HL312717", Status = FleetManagementStatus.Active, LocationCity = "New York, NY", LocationGps = "40.743828, -74.037982", Specs = new FleetManagementVehicleSpecs { Engine = "1.5 TSI", Generation = "Focus Mk4", Year = 2020, FuelType = "Gasoline", Power = "150 hp", Mileage = "28,140 mi", DoorsSeats = "5 / 5", Cubature = "1,498 cm\u00B3", Transmission = "Automatic", Msrp = "$24,700", TollPassId = "EZ-193482" } },
            new FleetManagementVehicle { Id = "A00102", LicensePlate = "5VLZ 91", Make = "Ford", Model = "Focus", Type = "Hatchback", PhotoKey = "Ford Focus dark gray", Vin = "WF0KXXGCKCY565571", Status = FleetManagementStatus.Active, LocationCity = "Boston, MA", LocationGps = "42.352104, -71.075238", Specs = new FleetManagementVehicleSpecs { Engine = "1.0 EcoBoost", Generation = "Focus Mk3", Year = 2019, FuelType = "Gasoline", Power = "125 hp", Mileage = "32,905 mi", DoorsSeats = "5 / 5", Cubature = "999 cm\u00B3", Transmission = "Manual", Msrp = "$20,900", TollPassId = "EZ-402112" } },
            new FleetManagementVehicle { Id = "A00103", LicensePlate = "C10 EFF", Make = "VW", Model = "Passat", Type = "Station Wagon", PhotoKey = "VW Passat gray", Vin = "1VWZYZ33DER623111", Status = FleetManagementStatus.Available, LocationCity = "Camden, NJ", LocationGps = "39.926602, -75.105908", Specs = new FleetManagementVehicleSpecs { Engine = "1.6 GDI", Generation = "Passat B8", Year = 2021, FuelType = "Gasoline", Power = "128 hp", Mileage = "18,200 mi", DoorsSeats = "4 / 5", Cubature = "1,591 cm\u00B3", Transmission = "Automatic", Msrp = "$21,900", TollPassId = "EZ-000000" } },
            new FleetManagementVehicle { Id = "A00104", LicensePlate = "KUM 0269", Make = "VW", Model = "Passat", Type = "Station Wagon", PhotoKey = "VW Passat black", Vin = "1VWZYZ33ZWE623426", Status = FleetManagementStatus.Active, LocationCity = "Philadelphia, PA", LocationGps = "39.992220, -75.141041", Specs = new FleetManagementVehicleSpecs { Engine = "2.0 TDI", Generation = "Passat B8", Year = 2019, FuelType = "Diesel", Power = "150 hp", Mileage = "35,900 mi", DoorsSeats = "4 / 5", Cubature = "1,968 cm\u00B3", Transmission = "Automatic", Msrp = "$23,500", TollPassId = "EZ-733492" } },
            new FleetManagementVehicle { Id = "A00105", LicensePlate = "NJ XR2188", Make = "VW", Model = "Golf", Type = "Hatchback", PhotoKey = "VW Golf", Vin = "WVWZZZAUZLW042105", Status = FleetManagementStatus.Active, LocationCity = "Newark, NJ", LocationGps = "40.735657, -74.172363", Specs = new FleetManagementVehicleSpecs { Engine = "1.5 TSI", Generation = "Golf Mk8", Year = 2022, FuelType = "Gasoline", Power = "148 hp", Mileage = "16,720 mi", DoorsSeats = "5 / 5", Cubature = "1,498 cm\u00B3", Transmission = "Automatic", Msrp = "$26,400", TollPassId = "EZ-220511" } },
            new FleetManagementVehicle { Id = "A00106", LicensePlate = "PA QN4731", Make = "VW", Model = "Polo", Type = "Hatchback", PhotoKey = "VW Polo", Vin = "WVWZZZAWZMU018406", Status = FleetManagementStatus.Available, LocationCity = "Allentown, PA", LocationGps = "40.608430, -75.490183", Specs = new FleetManagementVehicleSpecs { Engine = "1.0 TSI", Generation = "Polo AW", Year = 2021, FuelType = "Gasoline", Power = "95 hp", Mileage = "22,410 mi", DoorsSeats = "5 / 5", Cubature = "999 cm\u00B3", Transmission = "Manual", Msrp = "$19,800", TollPassId = "EZ-194774" } },
            new FleetManagementVehicle { Id = "A00107", LicensePlate = "CT LB9912", Make = "Mazda", Model = "3", Type = "Sedan", PhotoKey = "Mazda 3", Vin = "JM1BPAML1N1527107", Status = FleetManagementStatus.Active, LocationCity = "Hartford, CT", LocationGps = "41.765274, -72.678776", Specs = new FleetManagementVehicleSpecs { Engine = "2.5 Skyactiv-G", Generation = "BP", Year = 2022, FuelType = "Gasoline", Power = "186 hp", Mileage = "14,980 mi", DoorsSeats = "4 / 5", Cubature = "2,488 cm\u00B3", Transmission = "Automatic", Msrp = "$25,650", TollPassId = "EZ-871306" } },
            new FleetManagementVehicle { Id = "A00108", LicensePlate = "NY UJ6409", Make = "Mazda", Model = "6", Type = "Sedan", PhotoKey = "Mazda 6", Vin = "JM1GL1VM9L1524108", Status = FleetManagementStatus.Available, LocationCity = "Buffalo, NY", LocationGps = "42.885440, -78.878372", Specs = new FleetManagementVehicleSpecs { Engine = "2.5 Skyactiv-G", Generation = "GL", Year = 2020, FuelType = "Gasoline", Power = "187 hp", Mileage = "31,260 mi", DoorsSeats = "4 / 5", Cubature = "2,488 cm\u00B3", Transmission = "Automatic", Msrp = "$27,300", TollPassId = "EZ-774650" } },
            new FleetManagementVehicle { Id = "A00109", LicensePlate = "MA BK7315", Make = "Kia", Model = "Soul", Type = "Compact SUV", PhotoKey = "Kia Soul", Vin = "KNDJ23AU7N7189109", Status = FleetManagementStatus.Active, LocationCity = "Lowell, MA", LocationGps = "42.633425, -71.316170", Specs = new FleetManagementVehicleSpecs { Engine = "2.0 MPI", Generation = "SK3", Year = 2022, FuelType = "Gasoline", Power = "147 hp", Mileage = "13,940 mi", DoorsSeats = "5 / 5", Cubature = "1,999 cm\u00B3", Transmission = "CVT", Msrp = "$23,100", TollPassId = "EZ-539102" } },
            new FleetManagementVehicle { Id = "A00110", LicensePlate = "RI FV8820", Make = "Hyundai", Model = "Kona", Type = "SUV", PhotoKey = "Hyundai Kona", Vin = "KM8K53A36NU891110", Status = FleetManagementStatus.InMaintenance, LocationCity = "Warwick, RI", LocationGps = "41.700101, -71.416168", Specs = new FleetManagementVehicleSpecs { Engine = "2.0 MPI", Generation = "OS", Year = 2021, FuelType = "Gasoline", Power = "147 hp", Mileage = "27,130 mi", DoorsSeats = "5 / 5", Cubature = "1,999 cm\u00B3", Transmission = "Automatic", Msrp = "$24,450", TollPassId = "EZ-608992" } },
            new FleetManagementVehicle { Id = "A00111", LicensePlate = "CT YE5513", Make = "Hyundai", Model = "ix35", Type = "SUV", PhotoKey = "Hyundai ix35", Vin = "TMAJU81U8DJ271111", Status = FleetManagementStatus.Available, LocationCity = "New Haven, CT", LocationGps = "41.308273, -72.927879", Specs = new FleetManagementVehicleSpecs { Engine = "2.0 CRDi", Generation = "LM", Year = 2018, FuelType = "Diesel", Power = "136 hp", Mileage = "41,380 mi", DoorsSeats = "5 / 5", Cubature = "1,995 cm\u00B3", Transmission = "Automatic", Msrp = "$22,700", TollPassId = "EZ-331750" } },
            new FleetManagementVehicle { Id = "A00112", LicensePlate = "NY PK2044", Make = "Honda", Model = "Civic", Type = "Sedan", PhotoKey = "Honda Civic", Vin = "2HGFE2F54NH341112", Status = FleetManagementStatus.Active, LocationCity = "Albany, NY", LocationGps = "42.652580, -73.756233", Specs = new FleetManagementVehicleSpecs { Engine = "2.0 i-VTEC", Generation = "FE", Year = 2022, FuelType = "Gasoline", Power = "158 hp", Mileage = "18,860 mi", DoorsSeats = "4 / 5", Cubature = "1,996 cm\u00B3", Transmission = "CVT", Msrp = "$24,280", TollPassId = "EZ-284512" } },
            new FleetManagementVehicle { Id = "A00113", LicensePlate = "NJ TW6921", Make = "Toyota", Model = "Corolla", Type = "Sedan", PhotoKey = "Toyota Corolla", Vin = "JTDB4MEE7NJ121113", Status = FleetManagementStatus.Available, LocationCity = "Jersey City, NJ", LocationGps = "40.717754, -74.043143", Specs = new FleetManagementVehicleSpecs { Engine = "2.0 Dynamic Force", Generation = "E210", Year = 2022, FuelType = "Gasoline", Power = "169 hp", Mileage = "15,540 mi", DoorsSeats = "4 / 5", Cubature = "1,987 cm\u00B3", Transmission = "CVT", Msrp = "$23,950", TollPassId = "EZ-746104" } },
            new FleetManagementVehicle { Id = "A00114", LicensePlate = "NY PU6172", Make = "Kia", Model = "Sportage", Type = "SUV", PhotoKey = "Kia Sportage", Vin = "KNDPU3AF2P7014114", Status = FleetManagementStatus.Available, LocationCity = "Yonkers, NY", LocationGps = "40.931210, -73.898747", Specs = new FleetManagementVehicleSpecs { Engine = "2.5 GDI", Generation = "Sportage NQ5", Year = 2023, FuelType = "Gasoline", Power = "187 hp", Mileage = "9,420 mi", DoorsSeats = "5 / 5", Cubature = "2,497 cm\u00B3", Transmission = "Automatic", Msrp = "$29,300", TollPassId = "EZ-163590" } },
            new FleetManagementVehicle { Id = "A00115", LicensePlate = "PA HG3370", Make = "Toyota", Model = "RAV4", Type = "SUV", PhotoKey = "Toyota RAV4 1", Vin = "2T3P1RFV3NW181115", Status = FleetManagementStatus.Active, LocationCity = "Reading, PA", LocationGps = "40.335648, -75.926872", Specs = new FleetManagementVehicleSpecs { Engine = "2.5 Dynamic Force", Generation = "RAV4 XA50", Year = 2022, FuelType = "Gasoline", Power = "203 hp", Mileage = "17,940 mi", DoorsSeats = "5 / 5", Cubature = "2,487 cm\u00B3", Transmission = "Automatic", Msrp = "$32,400", TollPassId = "EZ-921143" } },
            new FleetManagementVehicle { Id = "A00116", LicensePlate = "MA CF7201", Make = "Toyota", Model = "RAV4", Type = "SUV", PhotoKey = "Toyota RAV4 2", Vin = "2T3P1RFV1NW181116", Status = FleetManagementStatus.InMaintenance, LocationCity = "Cambridge, MA", LocationGps = "42.366978, -71.105615", Specs = new FleetManagementVehicleSpecs { Engine = "2.5 Dynamic Force", Generation = "RAV4 XA50", Year = 2021, FuelType = "Gasoline", Power = "203 hp", Mileage = "29,540 mi", DoorsSeats = "5 / 5", Cubature = "2,487 cm\u00B3", Transmission = "Automatic", Msrp = "$31,850", TollPassId = "EZ-903374" } },
            new FleetManagementVehicle { Id = "A00117", LicensePlate = "NJ JM4258", Make = "Tesla", Model = "3", Type = "Sedan", PhotoKey = "Tesla 3 white 1", Vin = "5YJ3E1EA4NF391117", Status = FleetManagementStatus.Active, LocationCity = "Hoboken, NJ", LocationGps = "40.743991, -74.032364", Specs = new FleetManagementVehicleSpecs { Engine = "Dual Motor EV", Generation = "Model 3 Highland", Year = 2024, FuelType = "Electric", Power = "283 kW", Mileage = "8,120 mi", DoorsSeats = "4 / 5", Cubature = "N/A", Transmission = "Single-speed", Msrp = "$39,990", TollPassId = "EZ-112709" } },
            new FleetManagementVehicle { Id = "A00118", LicensePlate = "RI DS4307", Make = "VW", Model = "Touareg", Type = "SUV", PhotoKey = "VW Touareg 1", Vin = "3VV2B7AX4NM091118", Status = FleetManagementStatus.Available, LocationCity = "Providence, RI", LocationGps = "41.824577, -71.412118", Specs = new FleetManagementVehicleSpecs { Engine = "3.0 V6", Generation = "Touareg CR", Year = 2022, FuelType = "Gasoline", Power = "340 hp", Mileage = "14,250 mi", DoorsSeats = "5 / 7", Cubature = "2,995 cm\u00B3", Transmission = "Automatic", Msrp = "$30,900", TollPassId = "EZ-640125" } },
            new FleetManagementVehicle { Id = "A00119", LicensePlate = "CT DR1542", Make = "VW", Model = "Touareg", Type = "SUV", PhotoKey = "VW Touareg 2", Vin = "WVGZZZCRZND091119", Status = FleetManagementStatus.Active, LocationCity = "Bridgeport, CT", LocationGps = "41.179226, -73.189438", Specs = new FleetManagementVehicleSpecs { Engine = "3.0 V6 TDI", Generation = "Touareg CR", Year = 2021, FuelType = "Diesel", Power = "286 hp", Mileage = "23,500 mi", DoorsSeats = "5 / 7", Cubature = "2,967 cm\u00B3", Transmission = "Automatic", Msrp = "$47,900", TollPassId = "EZ-518620" } },
            new FleetManagementVehicle { Id = "A00120", LicensePlate = "PA MX2803", Make = "Ford", Model = "Focus", Type = "Hatchback", PhotoKey = "Ford Focus dark gray", Vin = "WF0NXXGCHNML29120", Status = FleetManagementStatus.Available, LocationCity = "Scranton, PA", LocationGps = "41.408969, -75.662412", Specs = new FleetManagementVehicleSpecs { Engine = "1.5 EcoBoost", Generation = "Focus Mk4", Year = 2021, FuelType = "Gasoline", Power = "150 hp", Mileage = "20,640 mi", DoorsSeats = "5 / 5", Cubature = "1,498 cm\u00B3", Transmission = "Automatic", Msrp = "$24,900", TollPassId = "EZ-457201" } },
            new FleetManagementVehicle { Id = "A00121", LicensePlate = "MA QL7740", Make = "Kia", Model = "EV6", Type = "Crossover", PhotoKey = "Kia EV6 gray", Vin = "KNDC34LA3N5121121", Status = FleetManagementStatus.Active, LocationCity = "Springfield, MA", LocationGps = "42.101483, -72.589811", Specs = new FleetManagementVehicleSpecs { Engine = "RWD EV", Generation = "EV6", Year = 2023, FuelType = "Electric", Power = "168 kW", Mileage = "11,390 mi", DoorsSeats = "5 / 5", Cubature = "N/A", Transmission = "Single-speed", Msrp = "$42,600", TollPassId = "EZ-690144" } },
            new FleetManagementVehicle { Id = "A00122", LicensePlate = "NY BP3006", Make = "Ford", Model = "Mustang", Type = "Coupe", PhotoKey = "Ford Mustang red", Vin = "1FA6P8TH1N5101122", Status = FleetManagementStatus.InMaintenance, LocationCity = "Rochester, NY", LocationGps = "43.156578, -77.608849", Specs = new FleetManagementVehicleSpecs { Engine = "2.3 EcoBoost", Generation = "S650", Year = 2024, FuelType = "Gasoline", Power = "315 hp", Mileage = "6,950 mi", DoorsSeats = "2 / 4", Cubature = "2,261 cm\u00B3", Transmission = "Automatic", Msrp = "$41,200", TollPassId = "EZ-305609" } },
            new FleetManagementVehicle { Id = "A00123", LicensePlate = "MA GX6243", Make = "VW", Model = "Caddy", Type = "Van", PhotoKey = "VW Caddy 1", Vin = "NM0LS7E21N1561123", Status = FleetManagementStatus.Active, LocationCity = "Worcester, MA", LocationGps = "42.262593, -71.802293", Specs = new FleetManagementVehicleSpecs { Engine = "2.0 TDI", Generation = "Caddy V", Year = 2022, FuelType = "Diesel", Power = "122 hp", Mileage = "19,770 mi", DoorsSeats = "4 / 2", Cubature = "1,968 cm\u00B3", Transmission = "Automatic", Msrp = "$31,250", TollPassId = "EZ-150763" } },
            new FleetManagementVehicle { Id = "A00124", LicensePlate = "RI NT4184", Make = "VW", Model = "Caddy", Type = "Van", PhotoKey = "VW Caddy 2", Vin = "WV1ZZZ2KZPX081124", Status = FleetManagementStatus.Available, LocationCity = "Pawtucket, RI", LocationGps = "41.878711, -71.382555", Specs = new FleetManagementVehicleSpecs { Engine = "2.0 TDI", Generation = "Caddy V", Year = 2023, FuelType = "Diesel", Power = "122 hp", Mileage = "10,260 mi", DoorsSeats = "4 / 2", Cubature = "1,968 cm\u00B3", Transmission = "Automatic", Msrp = "$32,300", TollPassId = "EZ-722430" } },
            new FleetManagementVehicle { Id = "A00125", LicensePlate = "CT XM6102", Make = "Toyota", Model = "Tundra", Type = "Pickup", PhotoKey = "Toyota Tundra", Vin = "5TFMA5DB4NX011125", Status = FleetManagementStatus.Active, LocationCity = "Stamford, CT", LocationGps = "41.053430, -73.538734", Specs = new FleetManagementVehicleSpecs { Engine = "3.5 Twin-Turbo V6", Generation = "XK70", Year = 2022, FuelType = "Gasoline", Power = "389 hp", Mileage = "24,880 mi", DoorsSeats = "4 / 5", Cubature = "3,445 cm\u00B3", Transmission = "Automatic", Msrp = "$49,500", TollPassId = "EZ-248901" } },
            new FleetManagementVehicle { Id = "A00126", LicensePlate = "PA CP7618", Make = "Ford", Model = "F-150", Type = "Pickup", PhotoKey = "Ford F-150 blue", Vin = "1FTFW1E83NFA11226", Status = FleetManagementStatus.Available, LocationCity = "Erie, PA", LocationGps = "42.129224, -80.085060", Specs = new FleetManagementVehicleSpecs { Engine = "3.5 EcoBoost", Generation = "P702", Year = 2023, FuelType = "Gasoline", Power = "400 hp", Mileage = "13,500 mi", DoorsSeats = "4 / 5", Cubature = "3,496 cm\u00B3", Transmission = "Automatic", Msrp = "$52,900", TollPassId = "EZ-640318" } }
        };

        // A fresh copy of every vehicle, as the fleet opens (and as Reset puts it back).
        public static List<FleetManagementVehicle> CreateVehicles()
        {
            return SeedVehicles.Select(vehicle => vehicle.Copy()).ToList();
        }
    }

    // One grid row. C# applies every rule (the badge variant, the pulse, the whole expanded row) and
    // the JavaScript templates in wwwroot/events.js only format what is here. Detail is JSON text:
    // on Blazor Server, arrays of primitives in grid data arrive as null.
    public class FleetManagementRecord
    {
        public string Id { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Vin { get; set; }
        public string Status { get; set; }
        public string LocationCity { get; set; }

        // The Status column's dot: its igc-badge variant, and whether it pulses (the state that needs
        // acting on). Both change together with Status, so the Status cell template renders again.
        public string StatusVariant { get; set; }
        public bool StatusPulse { get; set; }

        // Everything the expanded row shows (FleetManagementDetails.Build), serialized once per vehicle,
        // status and photo availability.
        public string Detail { get; set; }
    }
}
