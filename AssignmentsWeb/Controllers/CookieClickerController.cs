using Microsoft.AspNetCore.Mvc;

namespace AssignmentsWeb.Controllers
{
    public class CookieClickerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
