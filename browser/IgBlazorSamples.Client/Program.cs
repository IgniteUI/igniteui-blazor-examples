using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using IgniteUI.Blazor.Controls; // provides IgniteUIBlazor

namespace Infragistics.Samples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Console.WriteLine("SB Main() - Client");

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped(typeof(Infragistics.Samples.Core.SampleBrowser));
            builder.Services.AddScoped(typeof(Infragistics.Samples.Core.SampleTimer));

            // registering Infragistics Blazor
            builder.Services.AddScoped(typeof(IIgniteUIBlazor), typeof(IgniteUIBlazor));

            await builder.Build().RunAsync();
        }
    }
}
