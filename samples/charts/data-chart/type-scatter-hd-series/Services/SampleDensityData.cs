using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class SampleDensityData
    {
        public static Random random = new Random();

        public static List<SampleDensityPoint> Create()
        {
            var amount = 25000;
            var data = new List<SampleDensityPoint>();
            generate(data, amount / 2, 0, 0, 75000, 20000);
            generate(data, amount / 4, 0, 0, 100000, 25000);
            generate(data, amount / 8, 0, 0, 150000, 30000);
            generate(data, amount / 8, 0, 0, 200000, 75000);
           
            return data;
        }

        public static void generate(
            List<SampleDensityPoint> data, int count,
            int centerX, int centerY, int spreadX, int spreadY) {

            for (var i = 0; i <= count; i++)
            {
                var rangeX = random.NextDouble() * spreadX;
                var rangeY = random.NextDouble() * spreadY;
                var prop = random.NextDouble();
                var flip = 1;

                if (prop < .25) {
                    rangeX *= flip;
                    rangeY *= flip;
                }
                else if (prop >= .25 && prop < .5) {
                    rangeX *= -flip;
                    rangeY *= flip;
                }
                else if (prop >= .5 && prop < .75) {
                    rangeX *= flip;
                    rangeY *= -flip;
                }
                else {
                    rangeX *= -flip;
                    rangeY *= -flip;
                }

                var dispersionX = random.NextDouble() + 0.12;
                var dispersionY = random.NextDouble() + 0.12;
                var x = Math.Round(centerX + (rangeX * dispersionX));
                var y = Math.Round(centerY + (rangeY * dispersionY));

                data.Add(new SampleDensityPoint { X = x, Y = y });
            }
        }
    }

    public class SampleDensityPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}