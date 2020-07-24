using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Samples
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            Console.WriteLine("ConfigureServices...");
            // NOTE here you can config data services (if any) for the sample, e.g:
            services.AddSingleton<Samples.WeatherForecastService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
