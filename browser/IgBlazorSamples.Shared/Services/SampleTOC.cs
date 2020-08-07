using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samples.Shared.Services
{
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
