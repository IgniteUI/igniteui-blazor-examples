namespace Infragistics.Samples
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Reactive.Subjects;
    using System.Threading.Tasks;

    public class RemotePagingService
    {
        public BehaviorSubject<List<object>> RemoteData { get; } = new BehaviorSubject<List<object>>(new List<object>());
        public BehaviorSubject<int> DataLength { get; } = new BehaviorSubject<int>(0);
        private readonly string Url = "https://www.igniteui.com/api/products";
        private readonly HttpClient _httpClient;

        public RemotePagingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<object>> GetData(int index = 0, int perPage = 10)
        {
            string queryString = $"?$skip={index}&$top={perPage}&$count=true";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(Url + queryString);
                response.EnsureSuccessStatusCode(); // Throw for non-success status codes

                List<object> data = await response.Content.ReadAsAsync<List<object>>();
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data: {ex.Message}");
                throw; // Propagate the error further
            }
        }

        public async Task<int> GetDataLength()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(Url);
                response.EnsureSuccessStatusCode(); // Throw for non-success status codes

                List<object> data = await response.Content.ReadAsAsync<List<object>>();
                return data.Count; // Assuming the length is directly accessible in the JSON response
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data length: {ex.Message}");
                throw; // Propagate the error further
            }
        }
    }

}
