using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infragistics.Samples.Core
{
    public class TOC : ObservableObject
    {
        public TocGroup[] Groups { get; set; }
    }

    public class TocItem : ObservableObject
    {
        public string Name { get; set; }
        public bool IsExpanded { get; set; }

        public TocItem()
        {
            IsExpanded = false;
        }
    }

    public class TocGroup : TocItem
    {
        //public string Name { get; set; }
        //public bool IsExpanded { get; set; }
        public TocComponent[] Components { get; set; }

        public TocGroup()
        {
            IsExpanded = false;
        }
    }

    public class TocComponent : TocItem
    {
        public string Group { get; set; }
        //public string Name { get; set; }
        //public bool IsExpanded { get; set; }

        public TocSample[] Samples { get; set; }

        public TocComponent()
        {
            IsExpanded = false;
             
        }
    }

    public class TocSample : TocItem
    {
        //public string Name { get; set; }
        public string Route { get; set; }
        public string Component { get; set; }
        public string Group { get; set; }
        //public bool IsExpanded { get; set; }
        public bool ShowLink { get; set; }

        public TocSample()
        {
            IsExpanded = false;
        }
    }

    public class SampleTOC : ObservableObject
    {
        /// <summary>Gets or set toc file name with routing path for the component, e.g. radial-gauge.toc </summary>
        internal string File { get; set; }
        /// <summary>Gets or set name of the component, e.g. Category Chart, Radial Gauge </summary>
        public string Name { get; set; }
        /// <summary>Gets or set category group of the component, e.g. Charts, Gauges </summary>
        public string Group { get; set; }
        /// <summary>Gets or set name of help topic related to the component </summary>
        public string Topic { get; set; }

        // public SampleGroup[] Groups { get; set; }
        public SampleInfo[] Samples { get; set; }

        public string IsNew { get; set; }
        public string IsCTP { get; set; }
        public string IsUPD { get; set; }

        public SampleTOC()
        {
            IsExpanded = true;
        }

        private bool _IsExpanded;
        public bool IsExpanded
        {
            get { return _IsExpanded; }
            set { _IsExpanded = value; NotifyPropertyChanged(); }
        }
    }

    public class SampleGroup : List<SampleTOC>
    {
        public bool IsExpanded { get; set; }
        public string Name { get; set; }
    }

    public class SampleInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Component { get; set; }

        public string IsNew { get; set; }
        public string IsCTP { get; set; }
        public string IsUPD { get; set; }
    }
}
