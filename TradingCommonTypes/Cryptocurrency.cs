namespace TradingCommonTypes
{
    public class Cryptocurrency
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public decimal Price { get; set; }

        public Cryptocurrency(string symbol, string name)
        {
            Symbol = symbol;
            Name = name;
        }
        public Cryptocurrency(string symbol, decimal price)
        {
            Symbol = symbol;
            Price = price;
        }

        public Cryptocurrency()
        {
            Name = string.Empty;
            Symbol = string.Empty;
            Price = decimal.Zero;
        }

        public override string ToString()
        {
            return string.Format($"Name: {Name}\nSymbol: {Symbol}\nPrice: {Price}\n");
        }
    }
}
