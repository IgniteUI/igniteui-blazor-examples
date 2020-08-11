using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace Samples.Services
{
    public class RealTimeDataViewModel : ObservableModel
    {
        public RealTimeDataViewModel()
        {

            this.DataUpdateInterval = TimeSpan.FromMilliseconds(50);
            this.DataUpdateTimer = new Timer { Interval = this.DataUpdateInterval.Milliseconds };
            this.DataUpdateTimer.Elapsed += OnDataUpdateTimerTick;

            _dataSettings = new RealTimeDataSettings();
            _dataSettings.DataPoints = 5000;
            _dataSettings.DateInterval = TimeSpan.FromMilliseconds(50);
            this.Data = new RealTimeDataCollection();
            this.GenerateData();

            this.LastDataPoint = RealTimeDataGenerator.LastDataPoint;
        }

        public bool IsEnabledDataFeed { get { return this.DataUpdateTimer.Enabled; } }
        //
        protected Timer DataUpdateTimer;

        protected RealTimeDataPoint LastDataPoint;
        private RealTimeDataCollection _data;
        public RealTimeDataCollection Data
        {
            get { return _data; }
            set
            {
                if (_data == value) return;
                _data = value;
                OnPropertyChanged("Data");
            }
        }

        private RealTimeDataSettings _dataSettings;
        public RealTimeDataSettings DataSettings
        {
            get { return _dataSettings; }
            set
            {
                if (_dataSettings == value) return;
                _dataSettings = value;
                OnPropertyChanged("DataSettings");
            }
        }

        private TimeSpan _dataUpdateInterval;
        public TimeSpan DataUpdateInterval
        {
            get { return _dataUpdateInterval; }
            set
            {
                if (_dataUpdateInterval == value) return;
                _dataUpdateInterval = value;
                if (this.DataUpdateTimer == null) return;
                this.DataUpdateTimer.Interval = _dataUpdateInterval.Milliseconds;
            }
        }

        #region Event Handlers

        private void OnDataUpdateTimerTick(object sender, EventArgs e)
        {
            // generate new data point using RealTimeDataGenerator
            this.LastDataPoint = RealTimeDataGenerator.GenerateDataPoint(LastDataPoint);
            // remove the first data point
            this.Data.RemoveAt(0);
            // add the new data point at the end
            this.Data.Add(LastDataPoint);
        }

        #endregion

        #region Methods
        public void GenerateData()
        {
            RealTimeDataGenerator.Settings = this.DataSettings;
            RealTimeDataGenerator.Generate();
            this.Data.Clear();
            foreach (RealTimeDataPoint dp in RealTimeDataGenerator.Data)
            {
                this.Data.Add(dp);
            }
        }
        public void StartDataFeeds()
        {
            if (!this.DataUpdateTimer.Enabled)
            {
                this.DataUpdateTimer.Start();
            }
        }
        public void StopDataFeeds()
        {
            if (this.DataUpdateTimer.Enabled)
            {
                this.DataUpdateTimer.Stop();
            }
        }
        #endregion
    }
}
