using System.Collections.Generic;

namespace TradingCommonTypes
{
    public interface IExchangeInfo
    {
        List<ISymbolInfo> ExchangeSymbolsInfo { get; set; }
        List<ISimpleSymbol> ExchangeSymbols { get; set; }

        IExchangeInfo GetExchangeInfo();
    }
}
