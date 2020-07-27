using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

using Infragistics.Blazor.Controls;

namespace Samples
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            Console.WriteLine("App Startup...");
            // NOTE here you can config data services (if any) for the sample, e.g:
            services.AddSingleton<Samples.WeatherForecastService>();

            // services.AddInfragisticsBlazor();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }

    // public static class ServiceExtensions
    // {
    //     public static void AddInfragisticsBlazor(this IServiceCollection services)
    //     {
    //         services.AddScoped(typeof(IInfragisticsBlazor), typeof(InfragisticsBlazor));
    //     }
    // }
}
