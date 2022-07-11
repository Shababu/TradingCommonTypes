namespace TradingCommonTypes
{
    public interface ISymbolInfo : ISimpleSymbol
    {
        decimal QuotePrecision { get; set; }
        List<ISymbolFilter> Filters { get; set; }
    }
}
