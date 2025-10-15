using AssignmentsWeb.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsWeb.Controllers
{
    public class CatController : Controller
    {
        private readonly IHTTPService _httpService;
        public CatController(IHTTPService httpService)
        {
            _httpService = httpService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(int id) 
        {
            var cat = await _httpService.GetCatById(id);
            return View(cat);
        }

    }
}
