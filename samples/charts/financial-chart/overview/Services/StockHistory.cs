using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace Infragistics.Samples
{
    public class StocksHistory
    {
        public static async Task<List<StockPrice[]>> GetMultipleStocks()
        {
            // getting prices of multiples stocks asynchronously
            var dataSources = new List<StockPrice[]> {
                await GetAmazonStock(),
                await GetGoogleStock(),
                await GetMicrosoftStock(),
                await GetTeslaStock()
            };

            return dataSources;
        }

        /** gets Amazon stock OHLC prices from a .JSON file */
        public static async Task<StockPrice[]> GetAmazonStock() {
            var url = "https://static.infragistics.com/xplatform/data/stocks/stockAmazon.json";

            //TODO
            // setting data intent for Series Title, e.g. FinancialChart usage
            //(stockData as any).__dataIntents = {
            //  close: ["SeriesTitle/Amazon"]
            //};
            // console.log("fetchAmazonStock: ", stockData.length);

            var http = new HttpClient();
            var data = await http.GetFromJsonAsync<StockPrice[]>(url);
            //Console.WriteLine("Label" + " " + data.Length);
            //Console.WriteLine("Date" + " " + data[0].Date);
            return data;

        }

        /** gets Tesla stock OHLC prices from a .JSON file */
        public static async Task<StockPrice[]> GetTeslaStock()
        {
            var url = "https://static.infragistics.com/xplatform/data/stocks/stockTesla.json";

            //TODO
            // setting data intent for Series Title, e.g. FinancialChart usage
            //(stockData as any).__dataIntents = {
            //  close: ["SeriesTitle/Amazon"]
            //};
            // console.log("fetchAmazonStock: ", stockData.length);

            var http = new HttpClient();
            var data = await http.GetFromJsonAsync<StockPrice[]>(url);

            return data;

        }

        /** gets Microsoft stock OHLC prices from a .JSON file */
        public static async Task<StockPrice[]> GetMicrosoftStock()
        {
            var url = "https://static.infragistics.com/xplatform/data/stocks/stockMicrosoft.json";

            //TODO
            // setting data intent for Series Title, e.g. FinancialChart usage
            //(stockData as any).__dataIntents = {
            //  close: ["SeriesTitle/Amazon"]
            //};
            // console.log("fetchAmazonStock: ", stockData.length);

            var http = new HttpClient();
            var data = await http.GetFromJsonAsync<StockPrice[]>(url);

            return data;

        }

        public static async Task<StockPrice[]> GetGoogleStock()
        {
            var url = "https://static.infragistics.com/xplatform/data/stocks/stockGoogle.json";

            //TODO
            // setting data intent for Series Title, e.g. FinancialChart usage
            //(stockData as any).__dataIntents = {
            //  close: ["SeriesTitle/Amazon"]
            //};
            // console.log("fetchAmazonStock: ", stockData.length);

            var http = new HttpClient();
            var data = await http.GetFromJsonAsync<StockPrice[]>(url);

            return data;

        }
    }

    public class StockPrice
    {
		//TODO - get date to show up on xAxis
        public string Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
        public int Index { get; set; }
    }
}