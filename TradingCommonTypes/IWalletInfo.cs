namespace TradingCommonTypes
{
    public interface IWalletInfo
    {
        List<ICryptoBalance> GetWalletInfo(IExchangeUser user);
        decimal GetAccountTotalBalance(List<ICryptoBalance> balances);
        List<IDeposit> GetRecentDeposits(IExchangeUser user, string coin, DateTime startTime, DateTime endTime);
        List<IWithdrawal> GetRecentWithdrawals(IExchangeUser user, string coin, DateTime startTime, DateTime endTime);
    }
}
