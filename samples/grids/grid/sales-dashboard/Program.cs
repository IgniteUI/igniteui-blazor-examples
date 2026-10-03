using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using IgniteUI.Blazor.Controls; // for registering Ignite UI modules

namespace Infragistics.Samples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            // registering Ignite UI modules
            builder.Services.AddIgniteUIBlazor(
                typeof(IgbGridModule),
                typeof(IgbCategoryChartModule),
                typeof(IgbDoughnutChartModule),
                typeof(IgbRingSeriesModule),
                typeof(IgbCardModule),
                typeof(IgbCardContentModule),
                typeof(IgbAvatarModule),
                typeof(IgbBadgeModule),
                typeof(IgbListModule),
                typeof(IgbListItemModule),
                typeof(IgbIconModule),
                typeof(IgbIconButtonModule)
            );
            await builder.Build().RunAsync();
        }
    }
}
