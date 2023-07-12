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

        public async Task<List<ProductDataItem>> GetTable()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://www.igniteui.com/api/products", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<ProductDataItem>>().ConfigureAwait(false);
            }

            return new List<ProductDataItem>();
        }
    }

    public interface IProductDataService
    {
        Task<List<ProductDataItem>> GetTable();
    }

    public class ProductDataItem
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public double SupplierID { get; set; }
        public string SupplierName { get; set; }
        public double CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public double UnitsInStock { get; set; }
        public double UnitsOnOrder { get; set; }
        public double ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string OrderDate { get; set; }
        public double Rating { get; set; }
    }
}
