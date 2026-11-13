using IgBlazorSamples.Test;
using Microsoft.Playwright;
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

[TestFixture]
[TestFixtureSource(typeof(ErrorTestsData))]
[Parallelizable(ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class ErrorTest : BlazorTest
{
    private string testSelector;
    private string goToUrl;
    public ErrorTest(string componentName, string goToUrl, string testSelector)
    {
        this.goToUrl = String.Format("{0}/{1}", RootUri.AbsoluteUri.TrimEnd('/'), goToUrl.TrimStart('/'));
        this.testSelector = testSelector;
    }

    [SetUp]
    public void InitFixture()
    {
        Context.SetDefaultTimeout(TestContext.Parameters.Get<int>("defaultTimeout", 30000));
    }

    [Test]
    [Category("SampleTest")]
    public async Task BasicErrorTest()
    {
        int numPageErrors = 0;
        StringBuilder messages = new();
        Page.Console += (_, value) =>
        {
            if (value.Type == "error" || (value.Type == "warning" && value.Text.Contains("Error:")))
            {
                if (!value.Text.Contains("Failed to load resource"))
                {
                    messages.AppendLine(value.Text);
                    numPageErrors++;
                }
            }
        };
        await Page.GotoAsync(goToUrl);

        Assert.That(numPageErrors == 0, $"The following errors were thrown: \\n ${messages}");

        // Wait for the element to be rendered, not visible: custom element hosts such as igc-tab
        // can have no box of their own, and Playwright never reports those as visible.
        await Page.WaitForSelectorAsync(testSelector, new() { State = WaitForSelectorState.Attached });

        Assert.That(numPageErrors == 0, $"The following errors were thrown: \\n ${messages}");
    }
}
