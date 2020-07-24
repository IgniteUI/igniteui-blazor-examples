using Microsoft.AspNetCore.Blazor.Hosting;
using System;

namespace Samples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("CreateHostBuilder...");
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();
    }
}
