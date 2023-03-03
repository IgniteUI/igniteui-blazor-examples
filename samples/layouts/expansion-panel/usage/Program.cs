using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

// required for registering IgniteUIBlazor
using IgniteUI.Blazor.Controls;
using BlazorClientApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddIgniteUIBlazor(
    typeof(IgbIconModule),
    typeof(IgbDateTimeInputModule),
    typeof(IgbRadioGroupModule),
    typeof(IgbRadioModule),
    typeof(IgbRatingModule),
    typeof(IgbAccordionModule),
    typeof(IgbExpansionPanelModule),
    typeof(IgbCheckboxModule),
    typeof(IgbSliderModule),
    typeof(IgbRangeSliderModule)
);

await builder.Build().RunAsync();
