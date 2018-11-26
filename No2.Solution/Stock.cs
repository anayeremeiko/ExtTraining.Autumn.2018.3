using System;

namespace No2.Solution
{
    public class Stock
    {
        private readonly StockInfo stocksInfo;

        public event EventHandler<StockInfo> MarketChange; 

        public Stock()
        {
            this.stocksInfo = new StockInfo();
        }

        public void Market()
        {
            Random rnd = new Random();
            this.stocksInfo.USD = rnd.Next(20, 40);
            this.stocksInfo.Euro = rnd.Next(30, 50);
            this.MarketChange?.Invoke(this, new StockInfo(){USD = this.stocksInfo.USD, Euro = this.stocksInfo.Euro});
        }
    }
}
