namespace TradingCommonTypes
{
    public interface IExchangeUser
    {
        string ApiPublicKey { get; }
        string ApiPrivateKey { get; }

        string Sign(string totalParams);
    }
}
