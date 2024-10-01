using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IgBlazorSamples.Test.Models
{
    public class Toc
    {
        [JsonPropertyName("groups")]
        public TocGroup[] Groups { get; set; }
    }

    public class TocGroup
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("components")]
        public Component[] Components { get; set; }
    }

    public class Component
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("samples")]
        public SampleInfo[] Samples { get; set; }
    }

    public class SampleInfo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("route")]
        public string Route { get; set; }

        [JsonPropertyName("showLink")]
        public bool ShowLink { get; set; }
    }
}
