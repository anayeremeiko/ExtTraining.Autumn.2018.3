using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Stock
    {
        public event EventHandler<StockEventArgs> StockData = delegate { };
        
        public void Start() => new Thread(new ThreadStart(Run)).Start();

        void Run()
        {
            Random rnd = new Random();
            for (int days = 0; days < 5; days++)
            {
                StockEventArgs stocksInfo = new StockEventArgs();
                stocksInfo.USD = rnd.Next(20, 40);
                stocksInfo.Euro = rnd.Next(30, 50);
                OnNewStockData(this, stocksInfo);
                Thread.Sleep(2000);
            }
        }

        protected virtual void OnNewStockData(object sender, StockEventArgs e)
        {
            StockData?.Invoke(this, e);
        }
    }
}
