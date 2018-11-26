using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Broker
    {
        public string Name { get; set; }

        public Broker(string name, Stock s)
        {
            this.Name = name;
            Register(s);
        }

        public void Register(Stock s)
        {
            s.StockData += Update;
        }

        private void Unregister(Stock s)
        {
            s.StockData -= Update;
        }

        public void Update(object sender, StockEventArgs eventArgs)
        {
            Console.WriteLine(
                eventArgs.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {eventArgs.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {eventArgs.USD}");
        }
    }
}
