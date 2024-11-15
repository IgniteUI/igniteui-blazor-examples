using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using IgBlazorSamples.Test.Models;
using System.Reflection;
using Infragistics.Samples.Core;

namespace IgBlazorSamples.Test
{
    public class TestUtils
    {
        private static IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
            .AddJsonFile("testsettings.json", optional: false, reloadOnChange: false)
            .Build();

        public static List<SampleTestData> GetBrowserSamplesBaseInfo()
        {
            var toc = GetToc();
            var excludedSamples = config.GetSection("excludeSamples").Get<ExcludedSample[]>();
            var excludedGroups = config.GetSection("excludedGroups").Get<ExcludedGroup[]>();
            var excludedPaths = excludedGroups.Select(r => r.Group.Replace("\\/", "@slash").Split("/", StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Replace("@slash", "/"))
                .ToArray()
            );

            List<SampleTestData> testsData = new ();
            foreach (var group in toc.Groups)
            {
                var exGroups = excludedPaths.Select(p => p.Length == 1 ? p[0] : "").Where(p => p != "");
                var isValidGroup = !exGroups.Any(exGroup => group.Name == exGroup);
                if (isValidGroup)
                {
                    var exComp = excludedPaths.Select(p => p[0] == group.Name && p.Length == 2 ? p[1] : "").Where(p => p != "");
                    var groupComponents = group.Components.Where(comp => !exComp.Contains(comp.Name));
                    foreach (var comp in groupComponents)
                    {
                        var samples = comp.Samples?.Where(s => s.ShowLink)
                            .Where(s => !excludedSamples.Any(e => e.Name == s.Name && e.Route == s.Route));
                        var componentName = comp.Name.Replace(" ", "");
                        var componentsMaps = config.GetSection("componentsMaps").Get<ComponentMap[]>();
                        var testSelector = componentsMaps.FirstOrDefault(s => s.Name.Replace(" ", "") == componentName)?.InitialSelector;

                        foreach (var sample in samples)
                        {
                            testsData.Add(new() { ComponentName = componentName, TestSelector = testSelector, Route = sample.Route });
                        }
                    };
                }
            };

            return testsData;
        }

        private static TOC GetToc()
        {
            string result = string.Empty;
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream("IgBlazorSamples.Test.External.toc.json"))
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }

            return JsonSerializer.Deserialize<TOC>(result);
        }
    }
}
