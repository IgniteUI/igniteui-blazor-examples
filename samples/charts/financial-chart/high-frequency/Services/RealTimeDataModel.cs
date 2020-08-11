using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Samples.Services;

    /// <summary>
    /// Observable Collection of Real-Time Data Points
    /// </summary>
    public class RealTimeDataCollection : ObservableCollection<RealTimeDataPoint>
    { }
    /// <summary>
    /// Represents Real-Time Data Point  
    /// </summary>
    public class RealTimeDataPoint
    {
        #region Constructors
        public RealTimeDataPoint(DateTime date, double value)
        {
            Date = date;
            Value = value;
        }

        public RealTimeDataPoint()
            : this(new DateTime(2010, 1, 1), 1000)
        { }

        public RealTimeDataPoint(string date, double value)
            : this(DateTime.Parse(date, System.Globalization.CultureInfo.InvariantCulture), value)
        { }

        public RealTimeDataPoint(RealTimeDataPoint dataPoint)
        {
            Date = dataPoint.Date;
            Value = dataPoint.Value;
            Index = dataPoint.Index;
        }
        #endregion

        #region Properties

        public int Index { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }

        #endregion
    }

    /// <summary>
    /// Represents settings for generating Real-Time Data
    /// </summary>
    public class RealTimeDataSettings : ObservableModel
    {
        public RealTimeDataSettings()
        {
            DataPoints = 50;

            ValueStart = 2000;
            ValueRange = 50;
            ValueSample = 4;

            DateInterval = TimeSpan.FromSeconds(1);
            DateStart = new DateTime(2010, 1, 1);
        }

        #region Properties
        private int _dataPoints;
        public int DataPoints
        {
            get { return _dataPoints; }
            set { _dataPoints = value; OnPropertyChanged("DataPoints"); }
        }

        /// <summary>
        /// Determines range for used to generate random Value value 
        /// </summary>
        public int ValueRange { get; set; }
        /// <summary>
        /// Determines number of samples used to generate random Value values
        /// </summary>
        public int ValueSample { get; set; }
        /// <summary>
        /// Determines starting Value value for the first StockMarketDataPoint object
        /// </summary>
        public double ValueStart { get; set; }

        /// <summary>
        /// Determines time intervals between StockMarketDataPoint objects
        /// </summary>
        public TimeSpan DateInterval { get; set; }
        /// <summary>
        /// Determines starting date value for the first StockMarketDataPoint object
        /// </summary>
        public DateTime DateStart { get; set; }
        #endregion
    }
    /// <summary>
    /// Generates data points for Real-Time Data 
    /// </summary>
    public static class RealTimeDataGenerator
    {
        static RealTimeDataGenerator()
        {
            Generator = new Random();
            Settings = new RealTimeDataSettings();
            Data = GenerateData();
        }
        private static readonly Random Generator;
        #region Properties
        public static RealTimeDataSettings Settings { get; set; }
        public static List<RealTimeDataPoint> Data { get; set; }
        public static RealTimeDataPoint LastDataPoint { get; set; }

        #endregion
        public static void Generate()
        {
            Data = GenerateData();
        }
        public static List<RealTimeDataPoint> GenerateData(RealTimeDataSettings newSettings)
        {
            Settings = newSettings;
            return GenerateData();
        }

        public static List<RealTimeDataPoint> GenerateData()
        {
            // first data point
            RealTimeDataPoint dataPoint = new RealTimeDataPoint
            {
                Index = 0,
                Value = Settings.ValueStart,
                Date = Settings.DateStart
            };
            List<RealTimeDataPoint> data = new List<RealTimeDataPoint>();
            for (int i = 0; i < Settings.DataPoints; i++)
            {
                data.Add(dataPoint);
                dataPoint = GenerateDataPoint(dataPoint);
            }
            return data;
        }
        public static List<RealTimeDataPoint> GenerateData(RealTimeDataPoint dataPoint)
        {
            List<RealTimeDataPoint> data = new List<RealTimeDataPoint>();
            for (int i = 0; i < Settings.DataPoints; i++)
            {
                data.Add(dataPoint);
                dataPoint = GenerateDataPoint(dataPoint);
            }
            return data;
        }
        public static RealTimeDataPoint GenerateDataPoint()
        {
            RealTimeDataPoint newDataPoint = GenerateDataPoint(LastDataPoint);
            return newDataPoint;
        }

        public static RealTimeDataPoint GenerateDataPoint(RealTimeDataPoint dataPoint)
        {

            DateTime date = dataPoint.Date.Add(Settings.DateInterval);
            int index = dataPoint.Index + 1;

            double value = dataPoint.Value;
            if (Generator.NextDouble() > .5)
            {
                value += Generator.NextDouble();
            }
            else
            {
                value -= Generator.NextDouble();
            }

            LastDataPoint = new RealTimeDataPoint
            {
                Index = index,
                Date = date,
                Value = value
            };
            return LastDataPoint;
        }

    }