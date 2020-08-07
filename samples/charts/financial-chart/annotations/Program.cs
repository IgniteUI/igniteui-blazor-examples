using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

// required for registering InfragisticsBlazor
using Infragistics.Blazor.Controls;


namespace Samples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // registering Infragistics Blazor
            builder.Services.AddScoped(typeof(IInfragisticsBlazor), typeof(InfragisticsBlazor));

            builder.Services.AddScoped(typeof(Samples.Services.StockItem));
            builder.Services.AddScoped(typeof(Samples.Services.StockList));

            await builder.Build().RunAsync();
        }
    }
}
