using IgBlazorSamples.Test;
using IgBlazorSamples.Test.Models;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System.Text;

namespace SampleErrorTests;

class ErrorTestsData : System.Collections.IEnumerable
{
    public System.Collections.IEnumerator GetEnumerator() {
        var data = TestUtils.GetBrowserSamplesBaseInfo();
        foreach(var item in data)
        {
            yield return new object[] { item.ComponentName, item.Route, item.TestSelector };
        }
    }
}

[Parallelizable(ParallelScope.Self)]
[TestFixtureSource(typeof(ErrorTestsData))]
public class ErrorTest : PageTest
{
    private string testSelector;
    private string goToUrl;
    public ErrorTest(string componentName, string goToUrl, string testSelector)
    {
        string baseUrl = TestContext.Parameters.Get("baseUrl");
        this.goToUrl = String.Format("{0}/{1}", baseUrl.TrimEnd('/'), goToUrl.TrimStart('/'));
        this.testSelector = testSelector;
    }

    [SetUp]
    public void InitFixture()
    {
        Context.SetDefaultTimeout(TestContext.Parameters.Get<int>("defaultTimeout", 30000));
    }

    [Test]
    public async Task BasicErrorTest()
    {
        int numPageErrors = 0;
        StringBuilder messages = new();
        Page.Console += (_, value) =>
        {
            if (value.Type == "warning" && value.Text.Contains("Error:"))
            {
                messages.AppendLine(value.Text);
                numPageErrors++;
            }
        };

        await Page.GotoAsync(goToUrl);

        await Page.WaitForSelectorAsync(testSelector);

        Assert.That(numPageErrors == 0, $"The following errors were thrown: \n ${messages}");
    }
}
