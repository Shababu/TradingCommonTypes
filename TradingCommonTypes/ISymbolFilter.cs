namespace TradingCommonTypes
{
    public interface ISymbolFilter
    {
        string FilterType { get; set; }
        decimal MinPrice { get; set; }
        decimal MaxPrice { get; set; }
        decimal PriceScale { get; set; }
        decimal MinQty { get; set; }
        decimal MinVal { get; set; }
    }
}
