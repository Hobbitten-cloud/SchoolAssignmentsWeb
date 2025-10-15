using AssignmentsWeb.Models.API.BreakingBad;
using AssignmentsWeb.Models.API.Cat;
using AssignmentsWeb.Models.API.Pokemon;
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

        public async Task<List<BreakingBad>?> GetRandomBreakingBadQuote()
        {
            var http = _httpClientFactory.CreateClient("BreakingBadClient");
            var url = $"quotes";
            var response = await http.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return await response.Content.ReadFromJsonAsync<List<BreakingBad>?>();
        }

        public async Task<List<BreakingBad>?> GetAmountOfBreakingBadQuotes(string amount)
        {
            var http = _httpClientFactory.CreateClient("BreakingBadClient");
            var url = $"quotes/{amount}";
            var response = await http.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return await response.Content.ReadFromJsonAsync<List<BreakingBad>?>();
        }

        public async Task<Pokemon?> GetPokemons()
        {
            var http = _httpClientFactory.CreateClient("PokemonClient");
            var url = $"pokemon";
            var response = await http.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return await response.Content.ReadFromJsonAsync<Pokemon?>();
        }

        public async Task<Pokemon?> GetPokemonsByUrl(string url)
        {
            var http = _httpClientFactory.CreateClient("PokemonClient");
            var response = await http.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return await response.Content.ReadFromJsonAsync<Pokemon?>();
        }

        public async Task<Cat?> GetCat()
        {
            var http = _httpClientFactory.CreateClient("CatClient");
            var url = $"cat?position=center&json=true";
            var response = await http.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return await response.Content.ReadFromJsonAsync<Cat?>();
        }
    }
}
