namespace APICoin
{
    public class Coin
    {
        public string Symbol { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Vol { get; set; }
        public double Bid { get; set; }
        public double BidSize { get; set; }
        
        public override string ToString()
        {
            return $"{Symbol} - High: {High} - Low: {Low} - Volume: {Vol} - Bid: {Bid} - Bid Size: {BidSize}";
        }
    }
}