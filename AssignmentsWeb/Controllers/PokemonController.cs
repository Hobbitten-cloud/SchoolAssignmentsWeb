using AssignmentsWeb.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsWeb.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IHTTPService _httpService;
        public PokemonController(IHTTPService httpService)
        {
            _httpService = httpService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var pokemons = await _httpService.GetPokemons();
            return View(pokemons);
        }
    }
}
