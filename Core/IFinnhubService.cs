using StockDataApp.Core.FinnhubModels;

namespace StockDataApp.Core
{
    public interface IFinnhubService
    {
        Task<StockSymbolResult> GetStockSymbolByQueryAsync(string query);

        Task<StockQuoteResult> GetStockPriceToday(string symbol);

        Task<BasicFinancialsResult> GetBasicFinancialsAsync(string symbol);

        Task<CompanyProfileResult> GetCompanyProfileAsync(string symbol);

        Task<string> GetPeersAsync(string symbol);

        Task<string> GetRecommendationsAsync(string symbol);

        Task<string> GetFinancialsAsync(string symbol, string frequency, DateTimeOffset from, DateTimeOffset to);
    }
}

