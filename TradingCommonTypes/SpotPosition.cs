namespace TradingCommonTypes
{
    public class SpotPosition
    {
        public delegate void PositionStateHandler(object sender, EventArgs e);
        public event PositionStateHandler BuyOrderPlaced;
        public event PositionStateHandler SellOrderPlaced;
        public event PositionStateHandler BuyOrderExecuted;
        public event PositionStateHandler SellOrderExecuted;

        public string OrderId { get; set; }
        public string Symbol => BaseAsset + QuoteAsset;
        public string BaseAsset { get; }
        public string QuoteAsset { get; }
        public string Status { get; set; }
        public decimal BuyingPrice { get; }
        public decimal SellingPrice { get; }
        public decimal Distance => SellingPrice - BuyingPrice;
        public decimal Amount { get; set; }
        public bool IsBought { get; set; }
        public bool IsSellOrderPlaced { get; set; }
        public bool IsBuyOrderPlaced { get; set; }
        public string AmountWeb => Amount.ToString().Replace(',', '.');
        public string BuyingPriceWeb => BuyingPrice.ToString().Replace(',', '.');
        public string SellingPriceWeb => SellingPrice.ToString().Replace(',', '.');

        public SpotPosition(string baseAsset, string quoteAsset, decimal buyingPrice, decimal sellingPrice, 
                            decimal amount, bool isBought, bool isBuyOrderPlaced, bool isSellOrderPlaced)
        {
            BaseAsset = baseAsset;
            QuoteAsset = quoteAsset;
            BuyingPrice = buyingPrice;
            SellingPrice = sellingPrice;
            Amount = amount;
            IsBought = isBought;
            IsBuyOrderPlaced = isBuyOrderPlaced;
            IsSellOrderPlaced = isSellOrderPlaced;
        }

        public override string ToString()
        {
            return $"Symbol: {Symbol}\nOrder Id: {OrderId}\nStatus: {Status}\nBuying Price: {BuyingPrice}\n" +
                $"Selling Price: {SellingPrice}\nAmount: {Amount}\nDistance: {Distance}\nIs Bought: {IsBought}\n" +
                $"IsBuyOrderPlaced: {IsBuyOrderPlaced}\nIsSellOrderPlaced: {IsSellOrderPlaced}\nAmount Web: {AmountWeb}\n" +
                $"Buying Price Web: {BuyingPriceWeb}\nSelling Price Web: {SellingPriceWeb}\n";
        }

        public void InspectSpotPosition()
        {
            if(!IsBought && IsBuyOrderPlaced)
            {
                BuyOrderPlaced?.Invoke(this, new EventArgs());
            }
            else if(IsBought && IsBuyOrderPlaced && !IsSellOrderPlaced)
            {
                BuyOrderExecuted?.Invoke(this, new EventArgs());
            }
            else if (IsBought && IsBuyOrderPlaced && IsSellOrderPlaced)
            {
                SellOrderPlaced?.Invoke(this, new EventArgs());
            }
            else if (!IsBought && !IsBuyOrderPlaced && !IsSellOrderPlaced)
            {
                SellOrderExecuted?.Invoke(this, new EventArgs());
            }
        }
    }
}
