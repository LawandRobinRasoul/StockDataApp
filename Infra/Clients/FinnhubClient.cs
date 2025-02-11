using Microsoft.AspNetCore.Identity;
using StockDataApp.Core;
using StockDataApp.Core.FinnhubModels;

namespace StockDataApp.Infra.Clients
{
    public class FinnhubClient : IFinnhubService
    {
        //Docs: https://finnhub.io/docs/api/company-basic-financials

        private readonly HttpClient httpClient;

        public FinnhubClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<BasicFinancialsResult> GetBasicFinancialsAsync(string symbol)
        {
            var response = await httpClient.GetAsync($"api/v1/stock/metric?symbol={symbol}&metric=all");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<BasicFinancialsResult>();
        }

        public async Task<CompanyProfileResult> GetCompanyProfileAsync(string symbol)
        {
            var response = await httpClient.GetAsync($"api/v1/stock/profile2?symbol={symbol}");
            response.EnsureSuccessStatusCode();
            var model = await response.Content.ReadFromJsonAsync<CompanyProfileResult>();

            return model;
        }
        public async Task<StockQuoteResult> GetStockPriceToday(string symbol)
        {
            var response = await httpClient.GetAsync($"api/v1/quote?symbol={symbol}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<StockQuoteResult>();
        }

        public async Task<StockSymbolResult> GetStockSymbolByQueryAsync(string query)
        {
            var response = await httpClient.GetAsync($"api/v1/search?q={query}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<StockSymbolResult>();
        }

        public Task<string> GetPeersAsync(string symbol)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRecommendationsAsync(string symbol)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetFinancialsAsync(string symbol, string frequency, DateTimeOffset from, DateTimeOffset to)
        {
            throw new NotImplementedException();
        }
    }
}
