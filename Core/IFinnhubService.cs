namespace StockDataApp.Core
{
    public interface IFinnhubService
    {
        Task<string> GetStockSymbolByQueryAsync(string query);

        Task<string> GetStockPriceToday(string symbol);

        Task<string> GetBasicFinancialsAsync(string symbol);

        Task<string> GetPeersAsync(string symbol);

        Task<string> GetCompanyProfileAsync(string symbol);

        Task<string> GetRecommendationsAsync(string symbol);

        Task<string> GetFinancialsAsync(string symbol, string frequency, FromKeyedServicesAttribute, DateTimeOffset from, DateTimeOffset to);
    }
}
