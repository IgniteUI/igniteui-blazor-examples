using System;
using System.Collections.Generic;
using System.Drawing;

namespace Infragistics.Samples
{
    public class SampleShapeData
    {
        public static Random random = new Random();

        public static List<SampleShapeItem> Create()
        { 
            var shapeGuestBedroom = new List<Point>
            {
                new Point { X = 2, Y = 10 }, new Point { X = 7, Y = 10 }, new Point { X = 7, Y = 7 }, new Point { X = 2, Y = 7 }, new Point { X = 2, Y = 10 }
            };
            var shapeBath = new List<Point>
            {
                new Point { X = 0, Y = 10 }, new Point { X = 2, Y = 10 }, new Point { X = 2, Y = 7 }, new Point { X = 0, Y = 7 }, new Point { X = 0, Y = 10 }
            };
            var shapeKitchen = new List<Point>
            {
                new Point { X = 6, Y = 7 }, new Point { X = 10, Y = 7 }, new Point { X = 10, Y = 4 }, new Point { X = 6, Y = 4 }, new Point { X = 6, Y = 7 }
            };
            var shapeLivingRoom = new List<Point>
            {
                new Point { X = 6, Y = 4 }, new Point { X = 10, Y = 4 }, new Point { X = 10, Y = 0 }, new Point { X = 6, Y = 0 }, new Point { X = 6, Y = 4 }
            };
            var shapeMasterBedroom = new List<Point>
            {
                new Point { X = 0, Y = 0 }, new Point { X = 4, Y = 0 }, new Point { X = 4, Y = 5 }, new Point { X = 0, Y = 5 }, new Point { X = 0, Y = 0 }
            };

            var data = new List<SampleShapeItem>
            {
                new SampleShapeItem { Label = "Guest Bedroom", Points = ToPoints(shapeGuestBedroom) },
                new SampleShapeItem { Label = "Bath", Points = ToPoints(shapeBath) },
                new SampleShapeItem { Label = "Kitchen", Points = ToPoints(shapeKitchen) },
                new SampleShapeItem { Label = "Living Room", Points = ToPoints(shapeLivingRoom) },
                new SampleShapeItem { Label = "Master Bedroom", Points = ToPoints(shapeMasterBedroom) },
            };
            
            return data;
        }

        public static List<List<Point>> ToPoints(List<Point> points)
        {
            var shape = new List<List<Point>>();
            shape.Add(points);
            return shape;
        }
    }

    public class SampleShapeItem
    {
        public string Label { get; set; }

        public List<List<Point>> Points { get; set; }
    }
}