using Infragistics.Samples;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using IgniteUI.Blazor.Controls; // provides IgniteUIBlazor

// copied from Blazor .NET 6 project:
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("app");
builder.RootComponents.Add<HeadOutlet>("head::after");
// registering local browser components
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(typeof(Infragistics.Samples.Core.SampleBrowser));
builder.Services.AddScoped(typeof(Infragistics.Samples.Core.SampleTimer));
// registering Infragistics Blazor
builder.Services.AddScoped(typeof(IIgniteUIBlazor), typeof(IgniteUIBlazor));

await builder.Build().RunAsync();

// code for Blazor .NET 5 project:
//namespace Infragistics.Samples
//{
//    public class Program
//    {
//        public static async Task Main(string[] args)
//        {
//            // Console.WriteLine("SB Main() - Client");

//            var builder = WebAssemblyHostBuilder.CreateDefault(args);
//            builder.RootComponents.Add<App>("app");

//            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//            builder.Services.AddScoped(typeof(Infragistics.Samples.Core.SampleBrowser));
//            builder.Services.AddScoped(typeof(Infragistics.Samples.Core.SampleTimer));

//            // registering Infragistics Blazor
//            builder.Services.AddScoped(typeof(IIgniteUIBlazor), typeof(IgniteUIBlazor));

//            await builder.Build().RunAsync();
//        }
//    }
//}
