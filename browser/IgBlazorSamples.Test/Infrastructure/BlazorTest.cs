using Microsoft.Playwright.NUnit;

namespace IgBlazorSamples.Test;

/// <summary>
/// Base Playwright PageTest setup with the samples browser test server
/// </summary>
public class BlazorTest : PageTest
{
    /// <summary>
    /// Root Uri of the samples browser, which each test connects to.
    /// </summary>
    protected Uri RootUri = null!;

    [SetUp]
    public async Task BlazorSetup()
    {
        RootUri = SamplesServer.GetTestRootUri();

        // Prepare each test for tracing, in case it fails.
        // Required for each test, since we don't know if it's gonna fail or not.
        await Context.Tracing.StartAsync(new()
        {
            Title = $"{TestContext.CurrentContext.Test.ClassName}.{TestContext.CurrentContext.Test.Name}",
            Screenshots = true,
            Snapshots = true,
            Sources = true
        });
    }

    [TearDown]
    public async Task BlazorTearDown()
    {
        // Check if test failed based on the outcome.
        var failed = TestContext.CurrentContext.Result.Outcome == NUnit.Framework.Interfaces.ResultState.Error
            || TestContext.CurrentContext.Result.Outcome == NUnit.Framework.Interfaces.ResultState.Failure;

        // Finish the test tracing and set the save path of the trace if it failed.
        // Otherwise do not provide path and the trace will not be saved.
        await Context.Tracing.StopAsync(new()
        {
            Path = failed ? Path.Combine(
                TestContext.CurrentContext.WorkDirectory,
                "playwright-traces",
                $"{Environment.MachineName}.{TestContext.CurrentContext.Test.Name}.zip"
            ) : null,
        });
    }
}
