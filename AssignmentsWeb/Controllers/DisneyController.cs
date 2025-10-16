using AssignmentsWeb.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsWeb.Controllers
{
    public class DisneyController : Controller
    {
        private readonly IHTTPService _httpService;
        public DisneyController(IHTTPService httpService)
        {
            _httpService = httpService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string? url)
        {
            // If url is not null, get the pokemons by url, otherwise get the pokemons
            // This is used to navigate through the pokemon API and this is called a pagination with the Ternary Operator
            var disneyCharacters = string.IsNullOrWhiteSpace(url) ? await _httpService.GetDisneyCharacters() : await _httpService.GetDisneyCharactersByUrl(url);
            return View(disneyCharacters);
        }
    }
}
