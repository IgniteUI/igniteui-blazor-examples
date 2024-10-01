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

    public class ExcludedRoute
    {
        public string? Route { get; set; }
    }

    public class ExcludedSample
    {
        public string? Name { get; set; }

        public string? Route { get; set; }
    }
}
