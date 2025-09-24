using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgBlazorSamples.Test.Models
{
    /// <summary>
    /// Model for the test setting <c>componentsMaps</c> section.
    /// </summary>
    public class ComponentMap
    {
        public required string Name { get; set; }

        public string? InitialSelector { get; set; }
    }

    /// <summary>
    /// Model for the test setting <c>excludedGroups</c> section.
    /// </summary>
    public class ExcludedGroup
    {
        public required string Group { get; set; }
    }

    /// <summary>
    /// Model for the test setting <c>excludeSamples</c> section.
    /// </summary>
    public class ExcludedSample
    {
        public string? Name { get; set; }

        public string? Route { get; set; }
    }

    public class SampleTestData
    {
        public required string ComponentName { get; set; }

        public required string TestSelector { get; set; }

        public required string Route { get; set; }
    }
}
