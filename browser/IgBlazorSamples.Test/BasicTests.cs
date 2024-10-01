using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System.Text;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class BasicError : PageTest
{
    [Test]
    public async Task BasicErrorTest()
    {
        int numPageErrors = 0;
        StringBuilder messages = new ();
        Page.Console += (_, value) => 
        {
            if (value.Type == "warning" && value.Text.Contains("Error:"))
            {
                messages.AppendLine(value.Text);
                numPageErrors++;
            }
        };

        await Page.GotoAsync("http://localhost:4200/samples/grids/grid/clipboard-operations");

        await Page.WaitForSelectorAsync("igx-grid-header");

        Assert.That(numPageErrors == 0, $"The following errors were thrown: \n ${messages}");
    }
}

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class BasicPin : PageTest
{
    [Test]
    public async Task BasicPinTest()
    {
        await Page.GotoAsync("http://localhost:4200/samples/grids/grid/column-pinning");

        await Page.WaitForSelectorAsync("igx-grid-header");

        await Page.GetByRole(AriaRole.Button, new() { Name = "2" }).ClickAsync();
        await Page.Locator("#igx-checkbox-1").GetByRole(AriaRole.Img).ClickAsync();
        await Page.Locator("#igx-checkbox-3").GetByRole(AriaRole.Img).ClickAsync();

        await Expect(Page.Locator("igx-grid-header").Nth(1)).ToContainTextAsync("Company Name");
    }
}

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class BasicResize : PageTest
{
    [Test]
    public async Task BasicResizeTest()
    {
        await Page.GotoAsync("http://localhost:4200/samples/grids/grid/column-resizing");

        await Page.WaitForSelectorAsync("igx-grid-header");

        var companyBoundBox = await Page.GetByRole(AriaRole.Columnheader, new() { Name = "Company" }).BoundingBoxAsync();
        Assert.That(companyBoundBox?.Width, Is.EqualTo(136));

        var companyResizer = Page.Locator("#grid_-1_0_1 span").Nth(2);
        var companyResizerBoundBox = await companyResizer.BoundingBoxAsync();

        await companyResizer.HoverAsync();

        await Page.Mouse.DownAsync();
        await Page.WaitForTimeoutAsync(100);

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
public class BasicScroll : PageTest
{
    [Test, Timeout(30000)]
    public async Task BasicScrollTest()
    {
        await Page.GotoAsync("http://localhost:4200/samples/grids/grid/groupby-summary-options");

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