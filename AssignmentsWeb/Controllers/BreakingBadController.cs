using AssignmentsWeb.Models.API;
using AssignmentsWeb.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsWeb.Controllers
{
    public class BreakingBadController : Controller
    {
        private readonly IHTTPService _httpService;
        public BreakingBadController(IHTTPService httpService)
        {
            _httpService = httpService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string amount) 
        {
            var breakingBadQuotes = await _httpService.GetAmountOfBreakingBadQuotes(amount);
            return View(breakingBadQuotes);
        }
    }
}
