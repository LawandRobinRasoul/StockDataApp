namespace StockDataApp.Core.FinnhubModels
{
    public class ResultSymbol
    {
        public string Description { get; set; }
        public string DisplaySymbol { get; set; }
        public string Symbol { get; set; }
        public string Type { get; set; }
    }

    public class StockSymbolResult
    {
        public int Count { get; set; }
        public List<ResultSymbol> Result { get; set; }
    }
}
