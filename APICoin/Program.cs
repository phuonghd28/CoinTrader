using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace APICoin
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            /*var huobiTrader = new BitfinexTrader();
            var tickers = huobiTrader.GetTickers();*/
            var bitFinexTrader = new BitfinexTrader();
            var tickers = bitFinexTrader.GetTickers();
            foreach (var ticker in tickers)
            {
                Console.WriteLine(ticker.ToString());
            }
        }
    }

}
