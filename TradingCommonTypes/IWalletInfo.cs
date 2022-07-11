namespace TradingCommonTypes
{
    public interface IWalletInfo
    {
        List<ICryptoBalance> GetWalletInfo(IExchangeUser user);
        decimal GetAccountTotalBalance(List<ICryptoBalance> balances);
        List<IDeposit> GetRecentDeposits(IExchangeUser user, DateTime startTime, DateTime endTime);
    }
}
