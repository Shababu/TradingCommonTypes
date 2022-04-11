namespace TradingCommonTypes
{
    public interface IDepth
    {
        string Name { get; set; }
        decimal Quantity { get; set; }
        decimal Price { get; set; }
    }
}
