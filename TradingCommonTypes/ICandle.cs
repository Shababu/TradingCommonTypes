using System;

namespace TradingCommonTypes
{
    public interface ICandle
    {
        DateTime OpenTime { get; set; }
        double Open { get; set; }
        double High { get; set; }
        double Low { get; set; }
        double Close { get; set; }
        double Volume { get; set; }
    }
}
