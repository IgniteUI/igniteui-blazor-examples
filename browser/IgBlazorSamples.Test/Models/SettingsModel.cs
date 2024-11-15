using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgBlazorSamples.Test.Models
{
    public class ComponentMap
    {
        public string? Name { get; set; }

        public string? InitialSelector { get; set; }
    }

    public class ExcludedGroup
    {
        public string? Group { get; set; }
    }

    public class ExcludedSample
    {
        public string? Name { get; set; }

        public string? Route { get; set; }
    }

    public class SampleTestData
    {
        public string? ComponentName { get; set; }

        public string? TestSelector { get; set; }

        public string? Route { get; set; }
    }
}
