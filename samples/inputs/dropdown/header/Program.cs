using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

// required for registering IgniteUIBlazor
using IgniteUI.Blazor.Controls;

namespace Infragistics.Samples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // registering Infragistics Blazor
            builder.Services.AddIgniteUIBlazor(
                typeof(IgbDropdownModule),
                typeof(IgbDropdownItemModule),
                typeof(IgbDropdownHeaderModule),
                typeof(IgbButtonModule)
   );

            await builder.Build().RunAsync();
        }
    }
}
