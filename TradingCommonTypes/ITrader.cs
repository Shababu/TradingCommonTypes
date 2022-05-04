namespace TradingCommonTypes
{
    public interface ITrader
    {
        ILimitOrder PlaceNewLimitOrder(IExchangeUser user, string symbol, Sides side, decimal quantity, decimal price);
        ILimitOrder PlaceNewMarketOrder(IExchangeUser user, string symbol, Sides side, decimal quantity);
        ILimitOrder GetOrderInfo(IExchangeUser user, string orderId, string symbol);
        string GetOrderStatus(IExchangeUser user, SpotPosition position, string symbol);
        List<ILimitOrder> GetOpenOrders(IExchangeUser user, string symbol);
        void PlaceInitialOrders(IExchangeUser user, List<SpotPosition> positions);
        void AutoTrade(IExchangeUser user, List<SpotPosition> positions, bool increaseAmount);
        void UpdateOrderStatusAndId(SpotPosition position, ILimitOrder newLimitOrder);
    }
}
