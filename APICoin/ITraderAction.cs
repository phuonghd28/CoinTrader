using System.Collections.Generic;

namespace APICoin
{
    public interface ITraderAction
    {
        List<Coin> GetTickers();
    }
}