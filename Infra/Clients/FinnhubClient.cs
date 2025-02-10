using Microsoft.AspNetCore.Identity;

namespace StockDataApp.Infra.Clients
{
    public class FinnhubClient
    {
        private readonly HttpClient httpClient;

        public FinnhubClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> GetStockSymbolByQueryAsync(string query)
        {
            var response = await httpClient.GetAsync($"api/v1/search?q={query}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
