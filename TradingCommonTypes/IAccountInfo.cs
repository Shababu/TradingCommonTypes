namespace TradingCommonTypes
{
    public interface IAccountInfo
    {
        string BaseUrl { get; }
        string TradeUrl { get; }
        List<IFilledTrade> GetTrades(IExchangeUser user, string symbol);
    }
}
