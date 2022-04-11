using System;

namespace TradingCommonTypes
{
    public interface IFilledTrade
    {
        long OrderId { get; set; }
        string Symbol { get; set; }
        decimal Price { get; set; }
        decimal Qty { get; set; }
        decimal QuoteQty { get; set; }
        decimal Commission { get; set; }
        DateTime TimeStamp { get; set; }
        bool IsBuyer { get; set; }
        bool IsMaker { get; set; }
        Sides Side { get; set; }
    }
}
