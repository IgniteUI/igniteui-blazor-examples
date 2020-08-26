using System; 
using System.Linq; 
using System.Net.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Infragistics.Blazor.Controls;

namespace Infragistics.Samples
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Console.WriteLine("SB Startup ");
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            
            // required for Infragistics Blazor controls:
            services.AddScoped(typeof(IInfragisticsBlazor), typeof(InfragisticsBlazor));

            // Server Side Blazor doesn't register HttpClient by default
            if (!services.Any(x => x.ServiceType == typeof(HttpClient)))
            {
                // Setup HttpClient for server side in a client side compatible fashion
                services.AddScoped<HttpClient>(s =>
                {
                    // Creating the URI helper needs to wait until the JS Runtime is initialized, so defer it.      
                    var uriHelper = s.GetRequiredService<NavigationManager>();
                    return new HttpClient { BaseAddress = new Uri(uriHelper.BaseUri) };
                });

                services.AddScoped(typeof(Samples.Shared.Services.SampleBrowser));
                //services.AddSingleton<Samples.Shared.Services.SampleBrowser>();
                services.AddSingleton<Samples.Shared.Services.SampleTimer>();
                services.AddSingleton<WeatherForecastService>();
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //{
        //    Console.WriteLine("SB Startup Configure app/env/log");

        //    if (env.IsDevelopment())
        //    {
        //        app.UseDeveloperExceptionPage();
        //    }
        //    else
        //    {
        //        app.UseExceptionHandler("/Error");
        //        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        //        app.UseHsts();
        //    }

        //    app.UseHttpsRedirection();
        //    app.UseStaticFiles();

        //    app.UseRouting();
        //    app.UsePathBase("/blazor-server");
        //    app.UseEndpoints(endpoints =>
        //    {
        //        endpoints.MapBlazorHub();
        //        endpoints.MapFallbackToPage("/_Host");
        //    });
        //}

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            ILoggerFactory loggerFactory)
        {
            Console.WriteLine("SB Startup Configure app/env/log");
            //loggerFactory.AddProvider(new CustomLoggerProvider(new CustomLoggerConfiguration()));

            // Custom registration with a configuration object.
            // Default registration.
            loggerFactory.AddProvider(new ColorConsoleLoggerProvider(
                                      new ColorConsoleLoggerConfiguration
                                      {
                                          LogLevel = LogLevel.Information,
                                          Color = ConsoleColor.DarkGreen
                                      }));

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UsePathBase("/blazor-server");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }

    }
}
