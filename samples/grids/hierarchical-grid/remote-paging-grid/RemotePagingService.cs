using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Infragistics.Samples
{
    public class RemotePagingService
    {
        private readonly HttpClient _httpClient;
        private const string ProductsUrl = "https://services.odata.org/V4/Northwind/Northwind.svc/Products";

        public RemotePagingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ProductsWithPageResponse> GetDataWithPagingAsync(int pageIndex, int pageSize)
        {
            var skip = pageIndex * pageSize;
            var url = $"{ProductsUrl}?$count=true&$top={pageSize}&$skip={skip}&$expand=Order_Details&$orderby=ProductID";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var odataResponse = JsonSerializer.Deserialize<ODataResponse>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return new ProductsWithPageResponse
            {
                Items = odataResponse.Value,
                TotalRecordsCount = odataResponse.ODataCount,
                PageSize = pageSize,
                PageNumber = pageIndex
            };
        }

        private class ODataResponse
        {
            [JsonPropertyName("@odata.count")]
            public int ODataCount { get; set; }

            public ProductData[] Value { get; set; }
        }
    }

    public class ProductsWithPageResponse
    {
        public ProductData[] Items { get; set; }
        public int TotalRecordsCount { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }

    public class ProductData
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public OrderDetail[] Order_Details { get; set; }
    }

    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
    }
}
