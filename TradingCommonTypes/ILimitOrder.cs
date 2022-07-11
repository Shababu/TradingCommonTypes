namespace TradingCommonTypes
{
    public interface ILimitOrder
    {
        string Symbol { get; set; }
        long OrderId { get; set; }
        decimal Price { get; set; }
        decimal Quantity { get; set; }
        decimal ExecutedQty { get; set; }
        string Status { get; set; }
        string Side { get; set; }
        DateTime Time { get; set; }
    }
}
