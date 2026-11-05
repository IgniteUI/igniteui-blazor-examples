using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class CryptoBalanceHistoryItem
    {
        public string Period { get; set; }
        public double Exchange { get; set; }
        public double Assets { get; set; }

        public CryptoBalanceHistoryItem(string period, double exchange, double assets)
        {
            Period = period;
            Exchange = exchange;
            Assets = assets;
        }
    }

    public class CryptoBalanceHistory : List<CryptoBalanceHistoryItem>
    {
        public CryptoBalanceHistory()
        {
            this.AddRange(new List<CryptoBalanceHistoryItem>
            {
                new CryptoBalanceHistoryItem("2021", 7, 5),
                new CryptoBalanceHistoryItem("Jul 2021", 10, 8),
                new CryptoBalanceHistoryItem("2022", 12, 10),
                new CryptoBalanceHistoryItem("Jul 2022", 20, 15),
                new CryptoBalanceHistoryItem("2023", 20, 13),
                new CryptoBalanceHistoryItem("Jul 2023", 28, 8),
                new CryptoBalanceHistoryItem("2024", 55, 24),
                new CryptoBalanceHistoryItem("Jul 2024", 58, 16),
                new CryptoBalanceHistoryItem("2025", 43, 18)
            });
        }
    }
}
