using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace Infragistics.Samples
{
    public class RemotePagingService
    {
        private readonly HttpClient _httpClient;
        private const string CustomersUrl = "https://data-northwind.indigo.design/Customers/GetCustomersWithPage";

        public RemotePagingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CustomersWithPageResponse> GetDataWithPagingAsync(int pageIndex, int pageSize)
        {
            var url = BuildUrl(CustomersUrl, pageIndex, pageSize);
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<CustomersWithPageResponse>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        private string BuildUrl(string baseUrl, int pageIndex, int pageSize)
        {
            return $"{baseUrl}?pageIndex={pageIndex}&size={pageSize}";
        }
    }

    public class CustomersWithPageResponse
    {
        public CustomerData[] Items { get; set; }
        public int TotalRecordsCount { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }
    }

    public class CustomerData
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public CustomerAddress Address { get; set; }
    }

    public class CustomerAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
    }
}
