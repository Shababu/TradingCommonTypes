namespace TradingCommonTypes
{
    public interface IAssetStatus
    {
        string Symbol { get; set; }
        decimal PriceChange { get; set; }
        float PriceChangePercent { get; set; }
        decimal WeightedAvgPrice { get; set; }
        decimal PrevClosePrice { get; set; }
        decimal LastPrice { get; set; }
        decimal LastQty { get; set; }
        decimal OpenPrice { get; set; }
        decimal HighPrice { get; set; }
        decimal LowPrice { get; set; }
        decimal Volume { get; set; }
        decimal QuoteVolume { get; set; }
    }
}
