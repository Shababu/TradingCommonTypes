using System.Collections.Generic;

namespace TradingCommonTypes
{
    public interface ITrader
    {
        ILimitOrder PlaceNewLimitOrder(IExchangeUser user, string symbol, Sides side, decimal quantity, decimal price);
        void AutoTrade(IExchangeUser user, List<SpotPosition> positions, bool increaseAmount);
        void UpdateOrderStatusAndId(SpotPosition position, ILimitOrder newLimitOrder);
        void IncreaseAmount(SpotPosition position);
        ILimitOrder GetOrderInfo(IExchangeUser user, string orderId, string symbol);
        string GetOrderStatus(IExchangeUser user, SpotPosition position, string symbol);
        ILimitOrder PlaceNewMarketOrder(IExchangeUser user, string symbol, Sides side, decimal quantity);
        List<ILimitOrder> GetOpenOrders(IExchangeUser user, string symbol);
        ILimitOrder CancelLimitOrder(IExchangeUser user, string symbol, string orderId); 

    }
}
