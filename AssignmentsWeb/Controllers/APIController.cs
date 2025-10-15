using AssignmentsWeb.Models.API;
using AssignmentsWeb.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsWeb.Controllers
{
    public class APIController : Controller
    {
        private readonly IHTTPService _httpService;
        public APIController(IHTTPService httpService)
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

        [HttpGet]
        public IActionResult RandomQuote()
        {
            return View();
        }

    }
}
