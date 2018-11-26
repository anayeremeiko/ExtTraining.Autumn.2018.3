using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Bank : IObserver
    {
        private IObservable stock;

        public string Name { get; set; }

        public Bank(string name, IObservable observable)
        {
            this.Name = name;
            stock = observable;
            stock.Register(this);
        }

        public void Update(object info, IEventStock eventStock)
        {
            var stockInfo = (StockInfo)info;
            eventStock.eventStock += Update;
        }

        private void Update(object sender, StockInfo stockInfo)
        {
            Console.WriteLine(
                stockInfo.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{stockInfo.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {stockInfo.Euro}");
        }
    }
}
