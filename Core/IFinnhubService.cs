namespace StockDataApp.Core
{
    public interface IFinnhubService
    {
        Task<string> GetStockSymbolByQueryAsync(string query);
    }
}
