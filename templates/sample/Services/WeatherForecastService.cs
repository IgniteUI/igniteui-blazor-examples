using System;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

// NOTE make sure data sources are implemented under Samples namespace:
namespace Infragistics.Samples
{
    public class WeatherForecastService
    {
        protected HttpClient Http;
        public WeatherForecastService(HttpClient httpClient)
        {
            this.Http = httpClient;
        }

        public async Task<WeatherForecast[]> LoadAsync()
        {
            var wwwrootFilePath = "data/WeatherForecast.json";
            var data = await Http.GetJsonAsync<WeatherForecast[]>(wwwrootFilePath);

            return data;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public Task<WeatherForecast[]> FilterAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
