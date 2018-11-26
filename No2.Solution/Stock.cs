using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Stock : IObservable
    {
        private StockInfo stocksInfo;

        private EventHandler<StockInfo> stockWork;
   
        private readonly List<IObserver> observers;

        public Stock()
        {
            observers = new List<IObserver>();
            stocksInfo = new StockInfo();

            OnStartStokWork(stocksInfo);
        }

        public virtual void OnStartStokWork(StockInfo args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            stockWork?.Invoke(this, args);
        }
        public void Register(IObserver observer) => stockWork += EventInfoChange;

        public void Unregister(IObserver observer) => stockWork -= EventInfoChange;

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update(stocksInfo, );
            }
        }

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            Notify();
        }

        public void EventInfoChange(object sender, StockInfo e)
        {
            Console.WriteLine("Stock changing currectly!!!");
        }
    }
}
