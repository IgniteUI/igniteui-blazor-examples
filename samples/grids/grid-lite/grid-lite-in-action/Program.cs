using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
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
            // Avatar and Rating render only inside the grid's JavaScript cell templates, where no
            // Blazor component requests them, so registering their modules is what defines them.
            builder.Services.AddIgniteUIBlazor(
                typeof(IgbChipModule),
                typeof(IgbButtonModule),
                typeof(IgbIconButtonModule),
                typeof(IgbAvatarModule),
                typeof(IgbRatingModule)
            );

            await builder.Build().RunAsync();
        }
    }
}
