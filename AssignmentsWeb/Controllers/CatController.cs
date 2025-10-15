using AssignmentsWeb.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsWeb.Controllers
{
    public class CatController : Controller
    {
        private readonly IHTTPService _httpService;
        public CatController (IHTTPService httpService)
        {
            _httpService = httpService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var cat = await _httpService.GetCat();
            return View(cat);
        }
    }
}
