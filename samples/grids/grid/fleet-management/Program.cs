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
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            // registering Ignite UI modules. Badge, Tabs, Card, the category chart and the doughnut
            // chart appear only in the JavaScript templates (wwwroot/events.js); registering them is
            // what defines their elements, so they stay.
            builder.Services.AddIgniteUIBlazor(
                typeof(IgbGridModule),
                typeof(IgbGridToolbarModule),
                typeof(IgbGridToolbarHidingModule),
                typeof(IgbGridToolbarPinningModule),
                typeof(IgbGridToolbarAdvancedFilteringModule),
                typeof(IgbGridStateModule),
                typeof(IgbActionStripModule),
                typeof(IgbInputModule),
                typeof(IgbIconModule),
                typeof(IgbIconButtonModule),
                typeof(IgbButtonModule),
                typeof(IgbButtonGroupModule),
                typeof(IgbChipModule),
                typeof(IgbSnackbarModule),
                typeof(IgbDialogModule),
                typeof(IgbBadgeModule),
                typeof(IgbTabsModule),
                typeof(IgbCardModule),
                typeof(IgbCategoryChartModule),
                typeof(IgbDoughnutChartModule)
            );
            await builder.Build().RunAsync();
        }
    }
}
