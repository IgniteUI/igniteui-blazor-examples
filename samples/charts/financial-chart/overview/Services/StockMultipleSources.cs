using Samples.Services;
using System;
using System.Collections.Generic;

namespace IGFinancialChart.Samples 
{    
    public class StockMultipleSources : List<StockList>
    {
        public StockMultipleSources()
        {
            var includeWeekends = false;
            var interval = TimeSpan.FromDays(1);
            var start = new DateTime(2020, 1, 1);
            var end = new DateTime(2022, 7, 1);
            var stock1 = new StockList(start, end, "TSLA", interval, 300, 30000, includeWeekends);
            var stock2 = new StockList(start, end, "MSFT", interval, 200, 20000, includeWeekends);

            this.Add(stock1);
            this.Add(stock2);
        }
    }

    public class StockMultipleSourcesWithWeekends : List<StockList>
    {
        public StockMultipleSourcesWithWeekends()
        {
            var includeWeekends = true;
            var interval = TimeSpan.FromDays(1);
            var start = new DateTime(2020, 1, 1);
            var end = new DateTime(2021, 7, 1);
            var stock1 = new StockList(start, end, "TSLA", interval, 300, 30000, includeWeekends);
            var stock2 = new StockList(start, end, "MSFT", interval, 200, 20000, includeWeekends);

            this.Add(stock1);
            this.Add(stock2); 
        }
    }
}
