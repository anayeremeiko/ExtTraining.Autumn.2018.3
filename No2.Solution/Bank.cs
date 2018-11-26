using System;

namespace No2.Solution
{
    public class Bank
    {

        public string Name { get; set; }

        public Bank(string name, Stock stock)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            if (stock == null)
            {
                throw new ArgumentNullException(nameof(stock));
            }

            stock.MarketChange += this.Update;
        }

        private void Update(object sender, StockInfo info)
        {
            Console.WriteLine(
                info.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{info.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {info.Euro}");
        }
    }
}
