using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using IgBlazorSamples.Test.Models;
using System.Reflection;

namespace IgBlazorSamples.Test
{
    class Program
    {
        private const string outputPath = "Generated";
        private static string projectRootpath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        private static IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "Properties"))
            .AddJsonFile("testGenerationSettings.json", optional: false, reloadOnChange: false)
            .Build();

        public static void Main(string[] args)
        {
            var toc = GetToc();

            var excludedSamples = config.GetSection("excludeSamples").Get<ExcludedSample[]>();
            var excludedRoutes = config.GetSection("excludedRoutes").Get<ExcludedRoute[]>();
            var excludedPaths = excludedRoutes.Select(r => r.Route.Replace("\\/", "@slash").Split("/")
                .Select(e => e.Replace("@slash", "/"))
                .Where(p => p != "")
                .ToArray()
            );

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
                        string fileContent = GenerateFileContent(componentName, samples.ToArray());
                        var filePath = Path.Combine(projectRootpath, outputPath, componentName + "Tests.cs");

                        using (StreamWriter outputFile = new StreamWriter(filePath))
                        {
                            outputFile.WriteLine(fileContent);
                        }
                    };
                }
            };
        }

        private static Toc GetToc()
        {
            string result = string.Empty;
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream("IgBlazorSamples.Test.External.toc.json"))
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }

            return JsonSerializer.Deserialize<Toc>(result);

        }

        public static string GenerateFileContent(string componentName, SampleInfo[] samples)
        {
            var sampleUrlsArg = new StringBuilder();
            sampleUrlsArg.AppendLine("[");
            for (int i = 0; i < samples.Length; i++)
            {
                var sampleUrl = $@"""{samples[i].Route}""" + (i < samples.Length - 1 ? "," : "");
                sampleUrlsArg.Append("    ").Append("    ").AppendLine(sampleUrl);
            }
            sampleUrlsArg.Append("    ").Append("];");

            var componentsMaps = config.GetSection("componentsMaps").Get<ComponentMap[]>();
            var testSelector =  componentsMaps.FirstOrDefault(s => s.Name.Replace(" ", "") == componentName)?.InitialSelector;
            var testContent = $@"
using System.Text;
using Microsoft.Playwright.NUnit;

namespace {componentName};

public static class {componentName}Urls
{{
    public static string[] SampleUrls = {sampleUrlsArg}
}}

[Parallelizable(ParallelScope.Self)]
[TestFixtureSource(typeof({componentName}Urls), nameof({componentName}Urls.SampleUrls))]
public class {componentName}Tests : PageTest
{{
    private string goToUrl;

    public {componentName}Tests(string goToUrl)
    {{
        string baseUrl = TestContext.Parameters.Get(""baseUrl"");
        this.goToUrl = String.Format(""{{0}}/{{1}}"", baseUrl.TrimEnd('/'), goToUrl.TrimStart('/'));
    }}

    [SetUp]
    public void InitFixture()
    {{
        Context.SetDefaultTimeout(TestContext.Parameters.Get<int>(""defaultTimeout"", 30000));
    }}

    [Test]
    public async Task {componentName}ErrorTest()
    {{
        int numPageErrors = 0;
        StringBuilder messages = new();
        Page.Console += (_, value) =>
        {{
            if (value.Type == ""warning"" && value.Text.Contains(""Error:""))
            {{
                messages.AppendLine(value.Text);
                numPageErrors++;
            }}
        }};
        await Page.GotoAsync(goToUrl);
        await Page.WaitForSelectorAsync(""{testSelector}"");
        Assert.That(numPageErrors == 0, $""The following errors were thrown: \\n ${{messages}}"");
    }}
}}";

            return testContent;
        }
    }
}
