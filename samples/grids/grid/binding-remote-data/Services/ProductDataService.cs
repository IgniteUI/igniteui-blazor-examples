using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Net.Http.Json;

namespace Infragistics.Samples
{
    public class ProductDataService : IProductDataService
    {
        private readonly HttpClient _http;

        public ProductDataService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<NwindDataItem>> GetTable()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://www.igniteui.com/api/products", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<NwindDataItem>>().ConfigureAwait(false);
            }

            return new List<NwindDataItem>();
        }
    }

    public interface IProductDataService
    {
        Task<List<NwindDataItem>> GetTable();
    }
}
