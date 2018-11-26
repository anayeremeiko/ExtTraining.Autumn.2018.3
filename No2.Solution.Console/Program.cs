using No2.Solution;

namespace No2.Solution.Console
{
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();

            var bank = new Bank("Bank", stock);
            var broker = new Broker("Broker", stock);

            stock.Market();
            Thread.Sleep(500);
            stock.Market();
            Thread.Sleep(500);
            broker.StopTrade();
            stock.Market();

            System.Console.ReadLine();
        }
    }
}
