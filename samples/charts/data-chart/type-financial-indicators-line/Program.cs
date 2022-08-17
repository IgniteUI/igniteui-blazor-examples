using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

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

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // registering Infragistics Blazor
            builder.Services.AddScoped(
    typeof(IgbDataChartCoreModule),
    typeof(IgbDataChartCategoryModule),
    typeof(IgbDataChartCategoryTrendLineModule),
    typeof(IgbDataChartInteractivityModule),
    typeof(IgbFinancialPriceSeriesModule),
    typeof(IgbAbsoluteVolumeOscillatorIndicatorModule),
    typeof(IgbAccumulationDistributionIndicatorModule),
    typeof(IgbAverageDirectionalIndexIndicatorModule),
    typeof(IgbAverageTrueRangeIndicatorModule),
    typeof(IgbBollingerBandWidthIndicatorModule),
    typeof(IgbChaikinVolatilityIndicatorModule),
    typeof(IgbChaikinOscillatorIndicatorModule),
    typeof(IgbCommodityChannelIndexIndicatorModule),
    typeof(IgbDetrendedPriceOscillatorIndicatorModule),
    typeof(IgbEaseOfMovementIndicatorModule),
    typeof(IgbFastStochasticOscillatorIndicatorModule),
    typeof(IgbForceIndexIndicatorModule),
    typeof(IgbFullStochasticOscillatorIndicatorModule),
    typeof(IgbMarketFacilitationIndexIndicatorModule),
    typeof(IgbMassIndexIndicatorModule),
    typeof(IgbMedianPriceIndicatorModule),
    typeof(IgbMoneyFlowIndexIndicatorModule),
    typeof(IgbMovingAverageConvergenceDivergenceIndicatorModule),
    typeof(IgbNegativeVolumeIndexIndicatorModule),
    typeof(IgbOnBalanceVolumeIndicatorModule),
    typeof(IgbPercentagePriceOscillatorIndicatorModule),
    typeof(IgbPercentageVolumeOscillatorIndicatorModule),
    typeof(IgbPositiveVolumeIndexIndicatorModule),
    typeof(IgbPriceVolumeTrendIndicatorModule),
    typeof(IgbRateOfChangeAndMomentumIndicatorModule),
    typeof(IgbRelativeStrengthIndexIndicatorModule),
    typeof(IgbSlowStochasticOscillatorIndicatorModule),
    typeof(IgbStandardDeviationIndicatorModule),
    typeof(IgbStochRSIIndicatorModule),
    typeof(IgbTRIXIndicatorModule)
);

            await builder.Build().RunAsync();
        }
    }
}
