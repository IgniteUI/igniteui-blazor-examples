using IgniteUI.Blazor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Infragistics.Samples
{
    public enum MapRegion
    {
        Caribbean,
        UnitedStates,
        UnitedKingdom,
        European,
        SouthAfrica,
        Poland,
        Australia,
        Japan,
        Uruguay,
        Egypt,
        Hawaii
    }

    public class MapUtils
    {
        public static Dictionary<MapRegion, Rect> Regions;

        public static void NavigateTo(IgbGeographicMap map, MapRegion region)
        {
            Rect rect = Regions[region];
            map.ZoomToGeographic(rect);
        }

        public static string ToPixel(double number)
        {
            string s = Math.Abs(number).ToString("N0");
            return s + " px";
        }

        public static string ToLng(double number)
        {
            number = Clamp(number, -180, 180);

            string s = Math.Abs(number).ToString("N1");
            if (number < 100)
            {
                s = "  " + s;
            }

            if (number > 0)
            {
                return s + "°E";
            }
            else
            {
                return s + "°W";
            }
        }

        public static string ToLat(double number)
        {
            number = Clamp(number, -90, 90);

            string s = Math.Abs(number).ToString("N1");

            if(number < 100)
            {
                s = "  " + s;
            }

            if (number > 0)
            {
                return s + "°N";
            }
            else
            {
                return s + "°S";
            }
        }

        public static double Clamp(double number, double min, double max)
        {
            return Math.Max(min, Math.Min(max, number));
        }

        public static double Pad(double number, double places)
        {
            //TODO
            return 0;
        }

        public static string GetBingKey()
        {
            return "Avlo7qsH1zZZI0XNpTwZ4XwvUJmCbd-mczMeUXVAW9kYYOKdmBIVRe8aoO02Xctq";
        }

        public static Dictionary<MapRegion, Rect> GetRegions()
        {
            if(Regions == null || Regions.Count == 0)
            {
                CreateRegions();
            }

            return Regions;
        }

        private static void AddRegion(MapRegion name, Rect geoRect)
        {
            Regions.Add(name, geoRect);
        }

        private static void CreateRegions()
        {
            Regions = new Dictionary<MapRegion, Rect>();
            AddRegion(MapRegion.Australia, new Rect() { Left= 81.5, Top= -52.0, Width= 98.0, Height= 56.0 });
            AddRegion(MapRegion.Caribbean, new Rect() { Left= -92.9, Top= 5.4, Width= 35.1, Height= 25.8 });
            AddRegion(MapRegion.Egypt, new Rect() { Left= 19.3, Top= 19.9, Width= 19.3, Height= 13.4 });
            AddRegion(MapRegion.European, new Rect() { Left= -36.0, Top= 31.0, Width= 98.0, Height= 38.0 });
            AddRegion(MapRegion.Japan, new Rect() { Left= 122.7, Top= 29.4, Width= 27.5, Height= 17.0 });
            AddRegion(MapRegion.Hawaii, new Rect() { Left= -161.2, Top= 18.5, Width= 6.6, Height= 4.8 });
            AddRegion(MapRegion.Poland, new Rect() { Left= 13.0, Top= 48.0, Width= 11.0, Height= 9.0 });
            AddRegion(MapRegion.SouthAfrica, new Rect() { Left= 9.0, Top= -37.1, Width= 26.0, Height= 17.8 });
            AddRegion(MapRegion.UnitedStates, new Rect() { Left= -134.5, Top= 16.0, Width= 70.0, Height= 37.0 });
            AddRegion(MapRegion.UnitedKingdom, new Rect() { Left= -15.0, Top= 49.5, Width= 22.5, Height= 8.0 });
            AddRegion(MapRegion.Uruguay, new Rect() { Left= -62.1, Top= -35.7, Width= 10.6, Height= 7.0 });
        }
    }
}
