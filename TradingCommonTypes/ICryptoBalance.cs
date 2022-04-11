namespace TradingCommonTypes
{
    public interface ICryptoBalance
    {
        string Asset { get; set; }
        decimal Total { get; set; }
        decimal Free { get; set; }
        decimal Locked { get; set; }
        decimal RubValue { get; set; }
    }
}
