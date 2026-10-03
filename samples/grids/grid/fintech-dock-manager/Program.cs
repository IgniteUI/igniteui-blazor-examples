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
            // registering Ignite UI modules. Badge and LinearProgress also appear in the JavaScript cell
            // templates (wwwroot/events.js); registering them is what defines their elements, so they stay.
            builder.Services.AddIgniteUIBlazor(
                typeof(IgbDockManagerModule),
                typeof(IgbGridModule),
                typeof(IgbGridToolbarModule),
                typeof(IgbGridToolbarActionsModule),
                typeof(IgbGridToolbarAdvancedFilteringModule),
                typeof(IgbGridToolbarPinningModule),
                typeof(IgbGridToolbarHidingModule),
                typeof(IgbGridToolbarExporterModule),
                typeof(IgbActionStripModule),
                typeof(IgbFinancialChartModule),
                typeof(IgbNavDrawerModule),
                typeof(IgbNavDrawerItemModule),
                typeof(IgbButtonModule),
                typeof(IgbButtonGroupModule),
                typeof(IgbToggleButtonModule),
                typeof(IgbIconModule),
                typeof(IgbIconButtonModule),
                typeof(IgbBadgeModule),
                typeof(IgbAvatarModule),
                typeof(IgbSwitchModule),
                typeof(IgbInputModule),
                typeof(IgbComboModule),
                typeof(IgbSelectModule),
                typeof(IgbSelectItemModule),
                typeof(IgbTabsModule),
                typeof(IgbTabModule),
                typeof(IgbListModule),
                typeof(IgbListItemModule),
                typeof(IgbChipModule),
                typeof(IgbDialogModule),
                typeof(IgbSnackbarModule),
                typeof(IgbLinearProgressModule)
            );
            await builder.Build().RunAsync();
        }
    }
}
