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
            // registering Ignite UI modules
            builder.Services.AddIgniteUIBlazor(
                typeof(IgbThemeProviderModule),
                typeof(IgbAccordionModule),
                typeof(IgbAvatarModule),
                typeof(IgbButtonModule),
                typeof(IgbButtonGroupModule),
                typeof(IgbDialogModule),
                typeof(IgbExpansionPanelModule),
                typeof(IgbIconModule),
                typeof(IgbIconButtonModule),
                typeof(IgbInputModule),
                typeof(IgbSwitchModule),
                typeof(IgbToggleButtonModule),
                typeof(IgbGridModule),
                typeof(IgbTreeGridModule),
                typeof(IgbHierarchicalGridModule),
                typeof(IgbPivotGridModule)
            );
            await builder.Build().RunAsync();
        }
    }
}
