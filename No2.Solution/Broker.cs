using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Broker
    {
        private readonly Stock stock;

        public string Name { get; set; }

        public Broker(string name, Stock stock)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.stock = stock ?? throw new ArgumentNullException(nameof(stock));
            stock.MarketChange += this.Update;
        }

        private void Update(object sender, StockInfo info)
        {
            StockInfo stockInfo = (StockInfo)info;

            Console.WriteLine(
                stockInfo.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {stockInfo.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {stockInfo.USD}");
        }

        public void StopTrade()
        {
            this.stock.MarketChange -= this.Update;
        }
    }
}
