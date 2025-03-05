using IgBlazorSamples.Test;
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
        Page.Console += (test, value) =>
        {
            if (value.Type == "error" || (value.Type == "warning" && value.Text.Contains("Error:")))
            {
                throw new Exception(value.Text);
            }
        };

        await Page.GotoAsync(goToUrl);

        try
        {
            await Page.WaitForSelectorAsync(testSelector);
        }
        catch (Exception ex)
        {
            Assert.That(String.IsNullOrEmpty(ex?.Message), $"The following errors were thrown: \n ${ex?.Message}");
        }
    }
}
