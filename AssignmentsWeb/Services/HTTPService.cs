

using AssignmentsWeb.Models.API;
using AssignmentsWeb.Services.Interfaces;

namespace AssignmentsWeb.Services
{
    public class HTTPService : IHTTPService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HTTPService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<Root>?> GetRandomBreakingBadQuote()
        {
            var http = _httpClientFactory.CreateClient("BreakingBadClient");
            var url = $"quotes";
            var response = await http.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return await response.Content.ReadFromJsonAsync<List<Root>?>();
        }

        public async Task<List<Root>?> GetAmountOfBreakingBadQuotes(string amount)
        {
            var http = _httpClientFactory.CreateClient("BreakingBadClient");
            var url = $"quotes/{amount}";
            var response = await http.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return await response.Content.ReadFromJsonAsync<List<Root>?>();
        }
    }
}
