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
        private static readonly IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
            .AddJsonFile("testsettings.json", optional: false, reloadOnChange: false)
            .Build();

        private static readonly JsonSerializerOptions jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public static List<SampleTestData> GetBrowserSamplesBaseInfo()
        {
            return BuildTestsData().TestsData;
        }

        /// <summary>
        /// Returns a message for each testsettings.json entry that does not match anything in the TOC.
        /// </summary>
        public static List<string> GetUnusedSettingsEntries()
        {
            return BuildTestsData().UnusedEntries;
        }

        private static (List<SampleTestData> TestsData, List<string> UnusedEntries) BuildTestsData()
        {
            var toc = GetToc();
            var componentsMaps = config.GetSection("componentsMaps").Get<ComponentMap[]>() ?? [];
            var excludedSamples = config.GetSection("excludeSamples").Get<ExcludedSample[]>() ?? [];
            var excludedGroups = config.GetSection("excludedGroups").Get<ExcludedGroup[]>() ?? [];
            var excludedPaths = excludedGroups.Select(r => r.Group.Replace("\\/", "@slash").Split("/", StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Replace("@slash", "/"))
                .ToArray()
            ).ToList();
            var overrideTests = config.GetSection("overrideTests").Get<TestOverride[]>() ?? [];

            // Track which config entries were applied, so stale ones can be reported.
            var usedExcludedPaths = new HashSet<string[]>();
            var usedExcludedSamples = new HashSet<ExcludedSample>();
            var usedOverrides = new HashSet<TestOverride>();

            List<SampleTestData> testsData = new();
            foreach (var group in toc.Groups)
            {
                var exGroup = excludedPaths.FirstOrDefault(p => p.Length == 1 && p[0] == group.Name);
                if (exGroup != null)
                {
                    usedExcludedPaths.Add(exGroup);
                }
                else
                {
                    var exComps = excludedPaths.Where(p => p.Length == 2 && p[0] == group.Name).ToList();
                    var groupComponents = group.Components.Where(comp =>
                    {
                        var exComp = exComps.FirstOrDefault(p => p[1] == comp.Name);
                        if (exComp != null) usedExcludedPaths.Add(exComp);
                        return exComp == null;
                    });
                    foreach (var comp in groupComponents)
                    {
                        var samples = comp.Samples?.Where(s => s.ShowLink)
                            .Where(s =>
                            {
                                var exSample = excludedSamples.FirstOrDefault(e => IsExcludedSample(e, s.Name, s.Route));
                                if (exSample != null) usedExcludedSamples.Add(exSample);
                                return exSample == null;
                            });
                        var componentName = comp.Name.Replace(" ", "");
                        var testSelector = componentsMaps.FirstOrDefault(s => s.Name.Replace(" ", "") == componentName)?.InitialSelector;

                        if (testSelector == null)
                        {
                            Console.WriteLine($"Warning: The {componentName} does not have test selector defined in testsettings.json. Using a generated one.");

                            // Use the componentName to build a test selector. Split by upper cases and then lower all first letters of words.
                            string[] splitName = Regex.Split(componentName, @"(?<!^)(?=[A-Z])");
                            splitName = splitName.Select(subName => char.ToLowerInvariant(subName[0]) + subName[1..]).ToArray();
                            testSelector = "igc-" + string.Join("-", splitName);
                        }

                        foreach (var sample in samples ?? [])
                        {
                            var overrideTest = overrideTests.FirstOrDefault(t => t.Route == sample.Route);
                            if (overrideTest != null) usedOverrides.Add(overrideTest);
                            var sampleSelector = overrideTest?.TestSelector ?? testSelector;
                            testsData.Add(new() { ComponentName = componentName, TestSelector = sampleSelector, Route = sample.Route });
                        }
                    }
                }
            }

            List<string> unusedEntries = new();
            unusedEntries.AddRange(excludedPaths.Where(p => !usedExcludedPaths.Contains(p))
                .Select(p => $"excludedGroups: '{string.Join("/", p)}' does not match any group or component."));
            unusedEntries.AddRange(excludedSamples.Where(s => !usedExcludedSamples.Contains(s))
                .Select(s => $"excludeSamples: '{s.Name}' '{s.Route}' does not match any sample."));
            unusedEntries.AddRange(overrideTests.Where(t => !usedOverrides.Contains(t))
                .Select(t => $"overrideTests: '{t.Route}' does not match any sample."));

            return (testsData, unusedEntries);
        }

        /// <summary>
        /// Matches on the fields set in the exclusion entry. Entries with neither name nor route never match.
        /// </summary>
        private static bool IsExcludedSample(ExcludedSample excluded, string? name, string? route)
        {
            if (excluded.Name == null && excluded.Route == null)
            {
                return false;
            }

            return (excluded.Name == null || excluded.Name == name)
                && (excluded.Route == null || excluded.Route == route);
        }

        private static TOC GetToc()
        {
            string toc = "IgBlazorSamples.Test.External.toc.json";
            Assembly assembly = Assembly.GetExecutingAssembly();

            using Stream stream = assembly.GetManifestResourceStream(toc)
                ?? throw new InvalidOperationException($"Embedded resource '{toc}' not found. Check the EmbeddedResource link in IgBlazorSamples.Test.csproj.");
            using StreamReader reader = new StreamReader(stream);

            return JsonSerializer.Deserialize<TOC>(reader.ReadToEnd(), jsonOptions)
                ?? throw new InvalidOperationException($"Embedded resource '{toc}' could not be deserialized.");
        }
    }
}
