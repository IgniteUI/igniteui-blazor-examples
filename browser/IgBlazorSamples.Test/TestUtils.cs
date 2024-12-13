using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using IgBlazorSamples.Test.Models;
using System.Reflection;
using Infragistics.Samples.Core;
using System.Text.RegularExpressions;

namespace IgBlazorSamples.Test
{
    public class TestUtils
    {
        private static IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
            .AddJsonFile("testsettings.json", optional: false, reloadOnChange: false)
            .Build();

        private static JsonSerializerOptions jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public static List<SampleTestData> GetBrowserSamplesBaseInfo()
        {
            var toc = GetToc();
            var excludedSamples = config.GetSection("excludeSamples").Get<ExcludedSample[]>() ?? [];
            var excludedGroups = config.GetSection("excludedGroups").Get<ExcludedGroup[]>() ?? [];
            var excludedPaths = excludedGroups.Select(r => r.Group.Replace("\\/", "@slash").Split("/", StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Replace("@slash", "/"))
                .ToArray()
            );

            List<SampleTestData> testsData = new();
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
                        var componentsMaps = config.GetSection("componentsMaps").Get<ComponentMap[]>() ?? [];
                        var testSelector = componentsMaps.FirstOrDefault(s => s.Name.Replace(" ", "") == componentName)?.InitialSelector;

                        if (testSelector == null)
                        {
                            Console.WriteLine("Warning: The " + componentName + "does not have test selector defined in testsettings.json. Using a generated one.");

                            // Use the componentName to build a test selector. Split by upper cases and then lower all first letters of words.
                            string[] splitName = Regex.Split(componentName, @"(?<!^)(?=[A-Z])");
                            splitName = splitName.Select(subName => subName.Substring(0, 1).ToLower() + subName.Substring(1)).ToArray();
                            testSelector = "igc-" + string.Join("-", splitName);
                        }

                        foreach (var sample in samples ?? [])
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
            string toc = "IgBlazorSamples.Test.External.toc.json";
            Assembly assembly = Assembly.GetExecutingAssembly();

            if (assembly.GetManifestResourceNames().Contains(toc))
            {
                using Stream stream = assembly.GetManifestResourceStream(toc)!;
                using StreamReader reader = new StreamReader(stream);
                result = reader.ReadToEnd();
            }

            return JsonSerializer.Deserialize<TOC>(result, jsonOptions) ?? new();
        }
    }
}
