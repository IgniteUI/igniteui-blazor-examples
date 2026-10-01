using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Infragistics.Samples
{
    // A vehicle's paint colour is a property of its photo, not of its row. Every vehicle pins one
    // folder of the photo manifest through FleetManagementVehicle.PhotoKey, and the colour the UI
    // shows is read from Colors below rather than authored per vehicle, so the swatch cannot
    // disagree with the car in the picture: there is one colour per folder, and the photo and the
    // colour are always read from the same key.
    public class FleetManagementPaintColor
    {
        public FleetManagementPaintColor(string name, string hex)
        {
            Name = name;
            Hex = hex;
        }

        // Shown in the spec grid and used in the photo's alt text.
        public string Name { get; }

        // Approximate paint colour, for the swatch beside the name.
        public string Hex { get; }
    }

    public static class FleetManagementPhotos
    {
        public const string BaseUrl = "https://www.infragistics.com/angular-grid-examples/cars/photos/";

        // The photo manifest (car_images.json of the Angular sample), verbatim: folder name to the
        // file names it holds, in fallback order. Every file in a folder is the same car, so a
        // fallback changes the angle and never the colour.
        public const string CatalogJson = """
{
  "Ford F-150 blue": [
    "Ford-F150-caleb-white-XGJBSkoqX_I-unsplash.jpg",
    "Ford-F150-caleb-white-XGJBSkoqX_I-unsplash1.jpg",
    "Ford-F150-caleb-white-XGJBSkoqX_I-unsplash2.jpg"
  ],
  "Ford F-150 red": [
    "Ford-f150-7572360_1920.jpg",
    "Ford-f150-7572360_19201.jpg",
    "Ford-f150-7572360_19202.jpg"
  ],
  "Ford Focus blue": [
    "ford-focus-5167838_1280.jpg",
    "ford-focus-5167838_12801.jpg",
    "ford-focus-5167838_12802.jpg"
  ],
  "Ford Focus dark gray": [
    "1-1-Ford-Focus-car-3300587_1280.jpg",
    "1-2-Ford-Focus-car-3300588_1280.jpg",
    "1-3-Ford-Focus-car-3300587_1280.jpg"
  ],
  "Ford Mustang blue": [
    "Ford-Mustang-automobile-1450573_1920.jpg",
    "Ford-Mustang-automobile-1450573_19201.jpg",
    "Ford-Mustang-automobile-1450573_19202.jpg"
  ],
  "Ford Mustang red": [
    "Ford-Mustang-convertible-1630448_1920.jpg",
    "Ford-Mustang-convertible-1630448_19201.jpg",
    "Ford-Mustang-convertible-1630448_19202.jpg"
  ],
  "Honda Civic": [
    "honda-civic-4967605_1920.jpg",
    "honda-civic-4967605_19201.jpg",
    "honda-civic-4967605_19202.jpg"
  ],
  "Hyundai ix35": [
    "Hyundai-ix35-5505817_1920.jpg",
    "Hyundai-ix35-5505817_19201.jpg",
    "Hyundai-ix35-5505817_19202.jpg"
  ],
  "Hyundai Kona": [
    "Hyundai-Kona-electric-4964667_1920.jpg",
    "Hyundai-Kona-electric-4964667_19201.jpg",
    "Hyundai-Kona-electric-4964667_19202.jpg"
  ],
  "Kia Ceed red": [
    "Kia-Ceed-car-3305685_1280.jpg",
    "Kia-ceed-car-3305686_1920.jpg",
    "Kia-Ceed-car-3305699_1280.jpg"
  ],
  "Kia Ceed white": [
    "Kia-Ceed-car-6097887_1920.jpg",
    "Kia-Ceed-car-6097887_19201.jpg",
    "Kia-Ceed-car-6097887_19202.jpg"
  ],
  "Kia EV6 gray": [
    "KIA-EV6-hyundai-motor-group-gKODwMitO-c-unsplash.jpg",
    "KIA-EV6-hyundai-motor-group-gKODwMitO-c-unsplash1.jpg",
    "KIA-EV6-hyundai-motor-group-gKODwMitO-c-unsplash2.jpg"
  ],
  "Kia EV6 red": [
    "KIA-EV6-hyundai-motor-group-jdjzmbw4GPg-unsplash.jpg",
    "KIA-EV6-hyundai-motor-group-jdjzmbw4GPg-unsplash1.jpg",
    "KIA-EV6-hyundai-motor-group-jdjzmbw4GPg-unsplash2.jpg"
  ],
  "Kia Soul": [
    "Kia-Soul-car-2441815_1920.jpg",
    "Kia-Soul-car-2441815_19201.jpg",
    "Kia-Soul-car-2441815_19202.jpg"
  ],
  "Kia Sportage": [
    "Kia-Sportage-2382086_1920.jpg",
    "Kia-Sportage-2382086_19201.jpg",
    "Kia-Sportage-2382086_19202.jpg"
  ],
  "Mazda 3": [
    "mazda-3-7498005_1920.jpg",
    "mazda-3-7498005_19201.jpg",
    "mazda-3-7498005_19202.jpg"
  ],
  "Mazda 6": [
    "3-1-Mazda-6-car-6122178_1920.jpg",
    "3-2-Mazda-6-car-6122177_1920.jpg",
    "3-3-Mazda-6-car-6122177_1920.jpg"
  ],
  "Mazda MX-5": [
    "2-1-Mazda-MX-5-cabriolet-3627312_1920.jpg",
    "2-2-Mazda-MX-5-cabriolet-3708152_1920.jpg",
    "2-3-Mazda-MX-5-cabriolet-3708152_1920.jpg"
  ],
  "Tesla 3 red": [
    "Tesla-3-car-8607713_1920.jpg",
    "Tesla-3-car-8607713_19201.jpg",
    "Tesla-3-car-8607713_19202.jpg"
  ],
  "Tesla 3 white 1": [
    "tesla-3-5937063_1920.jpg",
    "tesla-3-5937063_19201.jpg",
    "tesla-3-5937063_19202.jpg"
  ],
  "Tesla 3 white 2": [
    "Tesla-3-charlie-deets-AkgALppFIwo-unsplash.jpg",
    "Tesla-3-charlie-deets-AkgALppFIwo-unsplash1.jpg",
    "Tesla-3-charlie-deets-AkgALppFIwo-unsplash2.jpg"
  ],
  "Tesla 3 white 3": [
    "Tesla-3-i-m-zion-A-JEMot0hWs-unsplash.jpg",
    "Tesla-3-i-m-zion-A-JEMot0hWs-unsplash1.jpg",
    "Tesla-3-i-m-zion-A-JEMot0hWs-unsplash2.jpg"
  ],
  "Toyota Corolla": [
    "toyota-corolla-347288_1920.jpg",
    "toyota-corolla-347288_19201.jpg",
    "toyota-corolla-347288_19202.jpg"
  ],
  "Toyota RAV4 1": [
    "Toyota-RAV4-gino-marcelo-hernandez-sanchez-MN0-x2hDNrc-unsplash.jpg",
    "Toyota-RAV4-gino-marcelo-hernandez-sanchez-MN0-x2hDNrc-unsplash1.jpg",
    "Toyota-RAV4-gino-marcelo-hernandez-sanchez-MN0-x2hDNrc-unsplash2.jpg"
  ],
  "Toyota RAV4 2": [
    "Toyota-RAV4-krish-parmar-PmSwFm4Lw1c-unsplash.jpg",
    "Toyota-RAV4-krish-parmar-PmSwFm4Lw1c-unsplash1.jpg",
    "Toyota-RAV4-krish-parmar-PmSwFm4Lw1c-unsplash2.jpg"
  ],
  "Toyota RAV4 3": [
    "Toyota-RAV4-stephen-andrews-28Lmg9YaTFY-unsplash.jpg",
    "Toyota-RAV4-stephen-andrews-28Lmg9YaTFY-unsplash1.jpg",
    "Toyota-RAV4-stephen-andrews-28Lmg9YaTFY-unsplash2.jpg"
  ],
  "Toyota Tundra": [
    "toyota-tundra-1241658_1920.jpg",
    "toyota-tundra-1241658_19201.jpg",
    "toyota-tundra-1241658_19202.jpg"
  ],
  "VW Caddy 1": [
    "VW_Caddy-ollie-walls-jDo2IZm-uFc-unsplash.jpg",
    "VW_Caddy-ollie-walls-jDo2IZm-uFc-unsplash1.jpg",
    "VW_Caddy-ollie-walls-jDo2IZm-uFc-unsplash2.jpg"
  ],
  "VW Caddy 2": [
    "VW-Caddy-daniil-lyusov-fesux3IvcVo-unsplash-2.jpg",
    "VW-Caddy-daniil-lyusov-fesux3IvcVo-unsplash-21.jpg",
    "VW-Caddy-daniil-lyusov-fesux3IvcVo-unsplash-22.jpg"
  ],
  "VW Golf": [
    "vw-Golf-4332807_1280.jpg",
    "vw-Golf-4332807_12801.jpg",
    "VW-Golf-car-5671331_1280.jpg"
  ],
  "VW Passat black": [
    "VW-passat-768159_1280.jpg",
    "VW-passat-768159_12801.jpg",
    "VW-passat-768159_12802.jpg"
  ],
  "VW Passat gray": [
    "VW-Passat-car-866764_1280.jpg",
    "VW-Passat-car-866769_1280.jpg",
    "VW-Passat-car-866769_12801.jpg"
  ],
  "VW Polo": [
    "VW-Polo-pexels-hellojoshwithers-16625624.jpg",
    "VW-Polo-pexels-hellojoshwithers-166256241.jpg",
    "VW-Polo-pexels-hellojoshwithers-166256242.jpg"
  ],
  "VW Touareg 1": [
    "4-1-VW-Touareg-automobile-4061855_1920.jpg",
    "4-2-VW-Touareg-338895_1920.jpg",
    "4-3-VW-Touareg-automobile-4061855_1920.jpg"
  ],
  "VW Touareg 2": [
    "5-1-VW-Touareg-pexels-ardit-mbrati-216809103-16646414.jpg",
    "5-2-VW-Touareg-pexels-ardit-mbrati-216809103-16646416.jpg",
    "5-3-VW-Touareg-pexels-ardit-mbrati-216809103-16646412.jpg"
  ]
}
""";

        // Folder name to its file names. Entries that are not arrays of non-empty strings are
        // dropped, as the Angular sample's loader drops them.
        public static readonly IReadOnlyDictionary<string, IReadOnlyList<string>> Catalog = ParseCatalog(CatalogJson);

        // Keyed by folder name in the manifest. The two must agree: every vehicle's folder is in the
        // manifest, every folder has exactly one colour (a name and a #rrggbb swatch), and a folder
        // that names its colour records that colour.
        public static readonly IReadOnlyDictionary<string, FleetManagementPaintColor> Colors = new Dictionary<string, FleetManagementPaintColor>
        {
            // These folders state their colour, so the photo and the name cannot drift.
            ["Ford F-150 blue"] = new FleetManagementPaintColor("Blue", "#1e5aa8"),
            ["Ford F-150 red"] = new FleetManagementPaintColor("Red", "#b32024"),
            ["Ford Focus blue"] = new FleetManagementPaintColor("Blue", "#1e5aa8"),
            ["Ford Focus dark gray"] = new FleetManagementPaintColor("Dark Gray", "#4a5058"),
            ["Ford Mustang blue"] = new FleetManagementPaintColor("Blue", "#1e5aa8"),
            ["Ford Mustang red"] = new FleetManagementPaintColor("Red", "#b32024"),
            ["Kia Ceed red"] = new FleetManagementPaintColor("Red", "#b32024"),
            ["Kia Ceed white"] = new FleetManagementPaintColor("White", "#eceef0"),
            ["Kia EV6 gray"] = new FleetManagementPaintColor("Gray", "#7d858e"),
            ["Kia EV6 red"] = new FleetManagementPaintColor("Red", "#b32024"),
            ["Tesla 3 red"] = new FleetManagementPaintColor("Red", "#b32024"),
            ["Tesla 3 white 1"] = new FleetManagementPaintColor("White", "#eceef0"),
            ["Tesla 3 white 2"] = new FleetManagementPaintColor("White", "#eceef0"),
            ["Tesla 3 white 3"] = new FleetManagementPaintColor("White", "#eceef0"),
            ["VW Passat black"] = new FleetManagementPaintColor("Black", "#1c1f24"),
            ["VW Passat gray"] = new FleetManagementPaintColor("Gray", "#7d858e"),

            // These folders say nothing about the colour, so it was read off the photo.
            ["Honda Civic"] = new FleetManagementPaintColor("Midnight Blue", "#26334d"),
            ["Hyundai ix35"] = new FleetManagementPaintColor("Silver", "#c3c8cd"),
            ["Hyundai Kona"] = new FleetManagementPaintColor("Black", "#1c1f24"),
            ["Kia Soul"] = new FleetManagementPaintColor("Copper", "#9c5f36"),
            ["Kia Sportage"] = new FleetManagementPaintColor("White", "#eceef0"),
            ["Mazda 3"] = new FleetManagementPaintColor("Black", "#1c1f24"),
            ["Mazda 6"] = new FleetManagementPaintColor("Black", "#1c1f24"),
            ["Toyota Corolla"] = new FleetManagementPaintColor("Red", "#b32024"),
            ["Toyota RAV4 1"] = new FleetManagementPaintColor("Graphite", "#3f4550"),
            ["Toyota RAV4 2"] = new FleetManagementPaintColor("Silver", "#c3c8cd"),
            ["Toyota Tundra"] = new FleetManagementPaintColor("Black", "#1c1f24"),
            ["VW Caddy 1"] = new FleetManagementPaintColor("White", "#eceef0"),
            ["VW Caddy 2"] = new FleetManagementPaintColor("Dark Gray", "#4a5058"),
            ["VW Golf"] = new FleetManagementPaintColor("Bronze", "#a87840"),
            ["VW Polo"] = new FleetManagementPaintColor("Gray", "#6b7078"),
            ["VW Touareg 1"] = new FleetManagementPaintColor("White", "#eceef0"),
            ["VW Touareg 2"] = new FleetManagementPaintColor("White", "#eceef0"),

            // Same, checked the same way. No vehicle points at these two yet.
            ["Mazda MX-5"] = new FleetManagementPaintColor("Silver", "#c3c8cd"),
            ["Toyota RAV4 3"] = new FleetManagementPaintColor("Blue", "#1e78c8")
        };

        public static readonly FleetManagementPaintColor UnknownColor = new FleetManagementPaintColor("Unlisted", "#8a9099");

        public static FleetManagementPaintColor PaintColor(string photoKey)
        {
            return photoKey != null && Colors.TryGetValue(photoKey, out var color) ? color : UnknownColor;
        }

        // Every photo of a vehicle, in fallback order, all from its one pinned folder. Empty for a
        // folder the manifest does not carry: the detail then shows a placeholder, not a stand-in car.
        public static IReadOnlyList<string> PhotoUrls(FleetManagementVehicle vehicle)
        {
            if (vehicle.PhotoKey == null || !Catalog.TryGetValue(vehicle.PhotoKey, out var files))
            {
                return Array.Empty<string>();
            }

            // Uri.EscapeDataString encodes these names as encodeURIComponent does (letters, digits,
            // spaces, '-', '_' and '.').
            var folderUrl = BaseUrl + Uri.EscapeDataString(vehicle.PhotoKey);
            return files.Select(fileName => folderUrl + "/" + Uri.EscapeDataString(fileName)).ToList();
        }

        private static IReadOnlyDictionary<string, IReadOnlyList<string>> ParseCatalog(string json)
        {
            var catalog = new Dictionary<string, IReadOnlyList<string>>();
            using var document = JsonDocument.Parse(json);
            foreach (var entry in document.RootElement.EnumerateObject())
            {
                if (entry.Value.ValueKind != JsonValueKind.Array)
                {
                    continue;
                }

                var files = entry.Value.EnumerateArray()
                    .Where(item => item.ValueKind == JsonValueKind.String && item.GetString().Trim().Length > 0)
                    .Select(item => item.GetString())
                    .ToList();
                if (files.Count > 0)
                {
                    catalog[entry.Name] = files;
                }
            }

            return catalog;
        }
    }
}
