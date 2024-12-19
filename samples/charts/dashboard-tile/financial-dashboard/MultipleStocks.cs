//begin async data
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Net.Http;
    using System.Collections.ObjectModel;
    using IgniteUI.Blazor.Controls;

    public class MultipleStocks : List<TitledStockData>
    {
        public async static Task<MultipleStocks> Fetch()
        {
            var google = await MultipleStocks.GetGoogleStock();
            var amazon = await MultipleStocks.GetAmazonStock();

            var val = new MultipleStocks();
            val.Add(google);
            val.Add(amazon);
            return val;
        }

        /** gets Amazon stock OHLC prices from a .JSON file */
        public async static Task<TitledStockData> GetAmazonStock()
        {
            var url = "https://static.infragistics.com/xplatform/data/stocks/stockAmazon.json";
            var data = await Fetch(url);
            var stockData = ConvertData(data);
            stockData[0].Title = "Amazon";
            return stockData;
        }

        /** gets Tesla stock OHLC prices from a .JSON file */
        public async static Task<TitledStockData> GetTeslaStock()
        {
            var url = "https://static.infragistics.com/xplatform/data/stocks/stockTesla.json";
            var data = await Fetch(url);
            var stockData = ConvertData(data);
            stockData[0].Title = "Tesla";
            return stockData;
        }

        /** gets Microsoft stock OHLC prices from a .JSON file */
        public async static Task<TitledStockData> GetMicrosoftStock()
        {
            var url = "https://static.infragistics.com/xplatform/data/stocks/stockMicrosoft.json";
            var data = await Fetch(url);
            var stockData = ConvertData(data);
            stockData[0].Title = "Microsoft";
            return stockData;
        }

        /** gets Google stock OHLC prices from a .JSON file */
        public async static Task<TitledStockData> GetGoogleStock()
        {
            var url = "https://static.infragistics.com/xplatform/data/stocks/stockGoogle.json";
            var data = await Fetch(url);
            var stockData = ConvertData(data);
            stockData[0].Title = "Google";
            return stockData;
        }

        private async static Task<Dictionary<string, object>[]> Fetch(string url)
        {
            HttpClient client = new HttpClient();
            var str = await client.GetStringAsync(url);
            var arr = JsonSerializer.Deserialize<Dictionary<string, object>[]>(str);
            return arr;
        }

        public static TitledStockData ConvertData(Dictionary<string, object>[] arr)
        {
            var ret = new TitledStockData();

            foreach (var json in arr)
            {
                var date = ((JsonElement)json["date"]).GetString();
                var parts = date.Split('-'); // "2020-01-01"
                var item = new MultipleStocksItem();
                item.Date = new DateTime(int.Parse(parts[0]), int.Parse(parts[1]) + 1, int.Parse(parts[2]));
                item.Open = ((JsonElement)json["open"]).GetDouble();
                item.High = ((JsonElement)json["high"]).GetDouble();
                item.Low = ((JsonElement)json["low"]).GetDouble();
                item.Close = ((JsonElement)json["close"]).GetDouble();
                item.Volume = ((JsonElement)json["volume"]).GetDouble();
                ret.Add(item);
            }

            return ret;
        }
    }

    public class MultipleStocksItem
    {
        [DataSeriesMemberIntent(DataSeriesIntent.SeriesTitle)]
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
    }

    public class TitledStockData
        : ObservableCollection<MultipleStocksItem>
    {

    }
    //end async data