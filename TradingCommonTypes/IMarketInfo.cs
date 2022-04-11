using System.Collections.Generic;

namespace TradingCommonTypes
{
    public interface IMarketInfo
    {
        decimal GetPrice(string pairSymbol);
        string GetTimestamp();
        IAssetStatus Get24HourStatOnAsset(string symbol);
        List<ICandle> GetCandles(string symbol, string interval, int limit);
        List<IDepth> GetDepth(string pairSymbol, int limit);
        List<IAssetStatus> Get24HourStatOnAllAssets();
    }
}
