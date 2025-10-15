

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

        public async Task<Root?> GetRandomCat()
        {
            var http = _httpClientFactory.CreateClient("CatAPIClient");
            var url = $"cat";
            var response = await http.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return await response.Content.ReadFromJsonAsync<Root?>();
        }

        public async Task<Root?> GetCatById(int id)
        {
            var http = _httpClientFactory.CreateClient("CatAPIClient");
            var url = $"api/cat/{id}";
            var response = await http.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return await response.Content.ReadFromJsonAsync<Root?>();
        }
    }
}
