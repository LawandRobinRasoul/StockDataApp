namespace StockDataApp.Core.FinnhubModels
{
    public class StockQuoteResult
    {
        public double C { get; set; }
        public double H { get; set; }
        public double L { get; set; }
        public double O { get; set; }
        public double Pc { get; set; }
        public long T { get; set; } // Unix timestamp
    }

}
