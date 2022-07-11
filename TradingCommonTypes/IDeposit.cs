namespace TradingCommonTypes
{
    public interface IDeposit
    {
        long Id { get; set; }
        decimal Amount { get; set; }
        string TransactionFee { get; set; }
        string Coin { get; set; }
        int Status { get; set; }
        string Address { get; set; }
        string TxId { get; set; }
        DateTime ApplyTime { get; set; }
    }
}
