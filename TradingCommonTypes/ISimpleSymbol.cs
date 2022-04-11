namespace TradingCommonTypes
{
    public interface ISimpleSymbol
    {
        string Symbol { get; set; }
        string BaseAsset { get; set; }
        string QuoteAsset { get; set; }
    }
}
