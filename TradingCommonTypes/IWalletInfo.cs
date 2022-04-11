using System.Collections.Generic;

namespace TradingCommonTypes
{
    public interface IWalletInfo
    {
        string BaseUrl { get; }
        string AccountInfoUrl { get; }
        List<ICryptoBalance> GetWalletInfo(IExchangeUser user);
        decimal GetAccountTotalBalance(List<ICryptoBalance> balances);
    }
}
