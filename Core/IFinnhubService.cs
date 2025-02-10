using StockDataApp.Core.FinnhubModels;

namespace StockDataApp.Core
{
    public interface IFinnhubService
    {
        Task<StockSymbolResult> GetStockSymbolByQueryAsync(string query);

        Task<string> GetStockPriceToday(string symbol);

        Task<BasicFinancialsResult> GetBasicFinancialsAsync(string symbol);

        Task<string> GetPeersAsync(string symbol);

        Task<string> GetCompanyProfileAsync(string symbol);

        Task<string> GetRecommendationsAsync(string symbol);

        Task<string> GetFinancialsAsync(string symbol, string frequency, DateTimeOffset from, DateTimeOffset to);
    }
}
