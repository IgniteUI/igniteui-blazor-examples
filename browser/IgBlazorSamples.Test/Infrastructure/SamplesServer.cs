using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace IgBlazorSamples.Test;

/// <summary>
/// One samples browser server for the whole test run, started on first use on a free local port.
/// <remarks>
/// It runs on Kestrel, so the browser loads the app straight from it, with its HTTP cache working,
/// rather than having each request intercepted and answered from .NET.
/// We use the Program.cs from IgBlazorSamples.TestServer since the factory creates only servers and IgBlazorSamples.Client is only WASM.
/// </remarks>
/// </summary>
public static class SamplesServer
{
    private static readonly WebApplicationFactory<Program> factory = new();

    private static readonly Lazy<Uri> rootUri = new(() =>
    {
        factory.UseKestrel(0);
        factory.StartServer();
        var addresses = factory.Services.GetRequiredService<IServer>().Features.Get<IServerAddressesFeature>()!.Addresses;
        return new(addresses.First());
    });

    /// <summary>
    /// Root Uri of the server, which tests connect to to access the samples browser.
    /// </summary>
    public static Uri RootUri => rootUri.Value;

    /// <summary>
    /// Root Uri of the samples browser under test: <see cref="RootUri"/>,
    /// or the testUrl run parameter when useInMemoryClient is false and the samples browser runs separately.
    /// </summary>
    public static Uri GetTestRootUri()
    {
        return TestContext.Parameters.Get("useInMemoryClient", true)
            ? RootUri
            : new(TestContext.Parameters.Get("testUrl", "http://localhost:4200"));
    }
}
