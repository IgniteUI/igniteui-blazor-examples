using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Playwright.NUnit;

namespace IgBlazorSamples.Test;

/// <summary>
/// Base Playwright PageTest setup with in-memory Test Server application
/// </summary>
public class BlazorTest : PageTest
{
    /// <summary>
    /// Root Uri that the app can be accessed through and is being intercepted for network requests.
    /// Each test connects to it to access the samples browser.
    /// </summary>
    protected Uri RootUri = new("http://127.0.0.1");

    /// <summary>
    /// Factory to create in-memory client for the samples test application.
    /// <remarks>
    /// We use the Program.cs from IgBlazorSamples.TestServer since the factory creates only servers and IgBlazorSamples.Client is only WASM.
    /// </remarks>
    /// </summary>
    private readonly WebApplicationFactory<Program> _webAppFactory = new();

    /// <summary>
    /// Test Server in-memory client
    /// </summary>
    private HttpClient? _httpClient;

    [SetUp]
    public async Task BlazorSetup()
    {
        bool createInMemory = TestContext.Parameters.Get("useInMemoryClient", true);
        if (createInMemory)
        {
            _httpClient = _webAppFactory.CreateClient(new()
            {
                BaseAddress = RootUri,
            });

            await Context.RouteAsync($"{RootUri.AbsoluteUri}**", async route =>
            {
                // Get the request sent from Playwright
                var request = route.Request;
                var content = request.PostDataBuffer is { } postDataBuffer
                    ? new ByteArrayContent(postDataBuffer)
                    : null;

                // Convert to HTTP request for the in-memory Test Server client.
                var requestMessage = new HttpRequestMessage(new(request.Method), request.Url)
                {
                    Content = content,
                };
                foreach (var header in request.Headers)
                {
                    requestMessage.Headers.Add(header.Key, header.Value);
                }

                var response = await _httpClient.SendAsync(requestMessage);

                // Use response from the Test Server and return it back to Playwright. We intercept all so no need to check for other cases.
                var responseBody = await response.Content.ReadAsByteArrayAsync();
                var responseHeaders = response.Content.Headers.Select(h => KeyValuePair.Create(h.Key, string.Join(",", h.Value)));
                await route.FulfillAsync(new()
                {
                    BodyBytes = responseBody,
                    Headers = responseHeaders,
                    Status = (int)response.StatusCode,
                });
            });
        }
        else
        {
            RootUri = new(TestContext.Parameters.Get<string>("testUrl", "localhost:4200"));
        }

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
        _httpClient?.Dispose();

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
