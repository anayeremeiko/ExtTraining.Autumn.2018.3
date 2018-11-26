using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Bank
    {
        public string Name { get; set; }

        public Bank(string name, Stock s)
        {
            this.Name = name;
            Register(s);
        }

        public void Register(Stock s)
        {
            s.StockData += Update;
        }

        public void Unregister(Stock s)
        {
            s.StockData -= Update;
        }

        public void Update(object sender, StockEventArgs eventArgs)
        {
            Console.WriteLine(
                eventArgs.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{eventArgs.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {eventArgs.Euro}");
        }
    }
}
