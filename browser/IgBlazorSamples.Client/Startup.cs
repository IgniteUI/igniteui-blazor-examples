using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infragistics.Samples
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Console.WriteLine("SB Startup()");
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            Console.WriteLine("SB Startup.ConfigureServices()");

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    //builder.WithOrigins(new[] { "http://localhost/blazor-client/" })
                    builder.WithOrigins(new[] { "http://localhost/" })
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            Console.WriteLine("SB Startup.Configure()");

            app.UseCors("CorsPolicy");

        }
    }
}

