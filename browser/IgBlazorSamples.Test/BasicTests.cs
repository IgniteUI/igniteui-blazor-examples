using IgBlazorSamples.Test;
using Microsoft.Playwright;
using System.Text;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class PreflightTests : BlazorTest
{
    [Test]
    [Category("PreflightTest")]
    public async Task PreflightTest()
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

        await Page.GotoAsync(RootUri.AbsoluteUri);

        await Page.WaitForSelectorAsync("text=This web application demonstrates samples for Infragistics Blazor Controls running on client-side");

        Assert.That(numPageErrors == 0, $"The following errors were thrown: \n ${messages}");
    }
}


class GridLinks
{
    public static string[] FixtureArgs = {
        "/samples/grids/grid/action-strip",
        "/samples/grids/grid/advanced-filtering-options",
        "/samples/grids/grid/advanced-filtering-style",
        "/samples/grids/grid/binding-composite-data"
    };
}

[Parallelizable(ParallelScope.Self)]
[TestFixtureSource(typeof(GridLinks), nameof(GridLinks.FixtureArgs))]
public class ParamTests : BlazorTest
{
    private string goToUrl;
    public ParamTests(string goToUrl)
    {
        this.goToUrl = goToUrl;
    }

    [SetUp]
    public void InitFixture()
    {
        Context.SetDefaultTimeout(TestContext.Parameters.Get<int>("defaultTimeout", 30000));
    }

    [Test]
    public async Task BasicParamTest()
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

        await Page.GotoAsync(String.Format("{0}/{1}", RootUri.AbsoluteUri.TrimEnd('/'), goToUrl.TrimStart('/')));

        await Page.WaitForSelectorAsync("igx-grid-header");

        Assert.That(numPageErrors == 0, $"The following errors were thrown: \n ${messages}");
    }
}

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class BasicError : BlazorTest
{
    [Test]
    public async Task BasicErrorTest()
    {
        int numPageErrors = 0;
        StringBuilder messages = new();
        Page.Console += (_, value) =>
        {
            if (value.Type == "warning" && value.Text.Contains("Error:"))
            {
                if (!value.Text.Contains("Failed to load resource"))
                {
                    //I think sometimes this gets hooked early enough to get errors
                    //about the favicon maybe? Making this flaky?
                    messages.AppendLine(value.Text);
                    numPageErrors++;
                }
            }
        };

        await Page.GotoAsync($"{RootUri.AbsoluteUri}samples/grids/grid/clipboard-operations");

        await Page.WaitForSelectorAsync("igx-grid-header");

        Assert.That(numPageErrors == 0, $"The following errors were thrown: \n ${messages}");
    }
}

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class BasicPin : BlazorTest
{
    [Test]
    public async Task BasicPinTest()
    {
        await Page.GotoAsync($"{RootUri.AbsoluteUri}samples/grids/grid/column-pinning");

        await Page.WaitForSelectorAsync("igx-grid-header");

        await Page.GetByRole(AriaRole.Button, new() { Name = "2" }).ClickAsync();
        await Page.Locator("#igx-checkbox-1").GetByRole(AriaRole.Img).ClickAsync();
        await Page.Locator("#igx-checkbox-3").GetByRole(AriaRole.Img).ClickAsync();

        await Expect(Page.Locator("igx-grid-header").Nth(1)).ToContainTextAsync("Company Name");
    }
}

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class BasicResize : BlazorTest
{
    [Test]
    public async Task BasicResizeTest()
    {
        await Page.GotoAsync($"{RootUri.AbsoluteUri}samples/grids/grid/column-resizing");

        await Page.WaitForSelectorAsync("igx-grid-header");

        var companyBoundBox = await Page.GetByRole(AriaRole.Columnheader, new() { Name = "Company" }).BoundingBoxAsync();
        Assert.That(companyBoundBox?.Width, Is.EqualTo(136));

        var companyResizer = Page.Locator("#grid_-1_0_1 span").Nth(2);
        var companyResizerBoundBox = await companyResizer.BoundingBoxAsync();

        await companyResizer.HoverAsync();

        await Page.Mouse.DownAsync();
        await Page.WaitForTimeoutAsync(100);

        Assert.That(companyResizerBoundBox, Is.Not.Null);
        await Page.Mouse.MoveAsync(companyResizerBoundBox.X - 50, 0);
        await Page.WaitForTimeoutAsync(100);

        await Page.Mouse.UpAsync();
        await Page.WaitForTimeoutAsync(100);

        companyBoundBox = await Page.GetByRole(AriaRole.Columnheader, new() { Name = "Company" }).BoundingBoxAsync();
        Assert.That(companyBoundBox?.Width, Is.EqualTo(84));
    }
}

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class BasicScroll : BlazorTest
{
    [Test, Timeout(30000)]
    public async Task BasicScrollTest()
    {
        await Page.GotoAsync($"{RootUri.AbsoluteUri}samples/grids/grid/groupby-summary-options");

        await Page.WaitForSelectorAsync("igx-grid-header");

        await Page.Locator("#input-2").ClickAsync();
        await Page.GetByText("ChildLevelsOnly").ClickAsync();

        await Page.Locator("#input-3").ClickAsync();
        await Page.GetByText("Bottom").ClickAsync();

        // Method 1 - Mouse wheel manually to bottom. Slower but works on headless so far.
        await Page.Locator(".igx-grid__tbody-content").HoverAsync();

        while (!(await Page.Locator("igx-grid-summary-row").IsVisibleAsync()))
        {
            await Page.Mouse.WheelAsync(0, 100);
        }

        // Method 2 - Hold down mouse button at the end of scrollbar till visible.
        // Much faster than method 1. Doesn't work in headless atm.
        //var scrollbar = Page.Locator("igx-virtual-helper");
        //var scrollbarBoundBox = await scrollbar.BoundingBoxAsync();

        //await scrollbar.HoverAsync(new()
        //{
        //    Position = new Position()
        //    {
        //        X = 5,
        //        Y = (scrollbarBoundBox.Height - 20)
        //    }
        //});

        //await Page.Mouse.DownAsync(new() { });

        ////Scroll until the group summary row is rendered
        //await Page.WaitForSelectorAsync("igx-grid-summary-row", new() { Timeout = 5000 });
        ////Or until the last row number is rendered
        ////await Page.WaitForSelectorAsync("//*[@role='row'][@data-rowindex='500']", new() { Timeout = 5000 });

        //await Page.Mouse.UpAsync();
        //await Page.WaitForTimeoutAsync(100);

        await Expect(Page.Locator("#igx-grid-0_500_2")).ToContainTextAsync("Count 499 Min $5,030.24 Max $29,980.24 Sum $8,838,532.26 Avg $17,712.49");
    }

}