using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class CryptoPortfolioItem
    {
        public string Asset { get; set; }
        public double Share { get; set; }

        public CryptoPortfolioItem(string asset, double share)
        {
            Asset = asset;
            Share = share;
        }
    }

    public class CryptoPortfolio : List<CryptoPortfolioItem>
    {
        public CryptoPortfolio()
        {
            this.AddRange(new List<CryptoPortfolioItem>
            {
                new CryptoPortfolioItem("Bitcoin", 56),
                new CryptoPortfolioItem("Ethereum", 24),
                new CryptoPortfolioItem("Other", 20)
            });
        }
    }
}
