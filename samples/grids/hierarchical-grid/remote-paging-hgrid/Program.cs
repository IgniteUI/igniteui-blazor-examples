using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using IgniteUI.Blazor.Controls; // for registering Ignite UI modules

namespace Infragistics.Samples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddSingleton<NwindData>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            // registering Ignite UI modules
            builder.Services.AddIgniteUIBlazor(
                typeof(IgbInputModule),
                typeof(IgbPropertyEditorPanelModule),
                typeof(IgbHierarchicalGridModule)
            );
            await builder.Build().RunAsync();
        }
    }
}
