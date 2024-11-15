using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Playwright.NUnit;

namespace IgBlazorSamples.Test;

public class BlazorTest : PageTest
{
    // Root Uri that the app can be accessed through and is being intercepted for netword requests. Each test connects to it to access the samples browser.
    protected static readonly Uri RootUri = new("http://127.0.0.1");
    // We use the Program.cs from the IgBlazorSamples.TestServer since WebApplicationFactory is used to create only servers and IgBlazorSamples.Client is only wasm app.
    private readonly WebApplicationFactory<Program> _webAppFactory = new();
    private HttpClient? _httpClient;

    [SetUp]
    public async Task BlazorSetup()
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

            // Create request to pass to the Test Server we have in memory based on the Playwright one.
            var requestMessage = new HttpRequestMessage(new(request.Method), request.Url)
            {
                Content = content,
            };
            foreach (var header in request.Headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            // Provide the Test Server with the request we passed from Playwright. Then wait and save the response.
            var response = await _httpClient.SendAsync(requestMessage);

            // Get the responce data from the Test Server and return it back to Playwright. We intercept all so no need to check for other cases.
            var responseBody = await response.Content.ReadAsByteArrayAsync();
            var responseHeaders = response.Content.Headers.Select(h => KeyValuePair.Create(h.Key, string.Join(",", h.Value)));
            await route.FulfillAsync(new()
            {
                BodyBytes = responseBody,
                Headers = responseHeaders,
                Status = (int)response.StatusCode,
            });

            // Prepare each test for tracing, in case it fails. This is required as a part of it.
            // We have to do it for each test, since we don't know if its gonna fail or on.
            await Context.Tracing.StartAsync(new()
            {
                Title = $"{TestContext.CurrentContext.Test.ClassName}.{TestContext.CurrentContext.Test.Name}",
                Screenshots = true,
                Snapshots = true,
                Sources = true
            });
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
        // Otherwise do not provide it and the trace will not be saved and discarded.
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
