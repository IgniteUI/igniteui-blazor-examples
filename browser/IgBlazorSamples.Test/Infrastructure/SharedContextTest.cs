using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace IgBlazorSamples.Test;

/// <summary>
/// A browser context kept for all tests of a test worker, so its cache keeps the samples browser's files,
/// and each test's fresh page loads them from the cache instead of downloading the whole app again.
/// <remarks>
/// Playwright keeps it after a test that passed and disposes it after one that failed.
/// </remarks>
/// </summary>
public sealed class SharedContext : IWorkerService
{
    public required IBrowserContext Context { get; init; }

    public static async Task<SharedContext> CreateAsync(IBrowser browser, float defaultTimeout)
    {
        var context = await browser.NewContextAsync();
        context.SetDefaultTimeout(defaultTimeout);

        // Each test records its own chunk of this trace, saved only when the test fails.
        await context.Tracing.StartAsync(new()
        {
            Screenshots = true,
            Snapshots = true,
            Sources = true
        });

        return new() { Context = context };
    }

    public Task ResetAsync() => Task.CompletedTask;

    public async Task DisposeAsync()
    {
        try
        {
            await Context.CloseAsync();
        }
        catch (PlaywrightException)
        {
            // The browser was already closed with it.
        }
    }
}

/// <summary>
/// Base test with a new page for each test, in the browser context its test worker shares.
/// </summary>
public class SharedContextTest : BrowserTest
{
    protected Uri RootUri { get; private set; } = null!;

    protected IBrowserContext Context { get; private set; } = null!;

    protected IPage Page { get; private set; } = null!;

    [SetUp]
    public async Task SharedContextSetup()
    {
        RootUri = SamplesServer.GetTestRootUri();
        int defaultTimeout = TestContext.Parameters.Get("defaultTimeout", 30000);

        var shared = await RegisterService("SharedContext", () => SharedContext.CreateAsync(Browser, defaultTimeout));
        Context = shared.Context;

        await Context.Tracing.StartChunkAsync(new()
        {
            Title = $"{TestContext.CurrentContext.Test.ClassName}.{TestContext.CurrentContext.Test.Name}"
        });
        Page = await Context.NewPageAsync();
    }

    [TearDown]
    public async Task SharedContextTearDown()
    {
        var failed = TestContext.CurrentContext.Result.Outcome == NUnit.Framework.Interfaces.ResultState.Error
            || TestContext.CurrentContext.Result.Outcome == NUnit.Framework.Interfaces.ResultState.Failure;

        // Save the trace of the test only if it failed.
        await Context.Tracing.StopChunkAsync(new()
        {
            Path = failed ? Path.Combine(
                TestContext.CurrentContext.WorkDirectory,
                "playwright-traces",
                $"{Environment.MachineName}.{TestContext.CurrentContext.Test.Name}.zip"
            ) : null,
        });
        await Page.CloseAsync();
    }
}
