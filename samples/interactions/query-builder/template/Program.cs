using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

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

            // registering Infragistics Blazor
            builder.Services.AddIgniteUIBlazor(
                typeof(IgbQueryBuilderModule),
                typeof(IgbDatePickerModule),
                typeof(IgbDateTimeInputModule),
                typeof(IgbSelectModule),
                typeof(IgbRadioGroupModule),
                typeof(IgbRadioModule),
                typeof(IgbInputModule),
                typeof(IgbIconModule)
            );

            await builder.Build().RunAsync();
        }
    }
}
