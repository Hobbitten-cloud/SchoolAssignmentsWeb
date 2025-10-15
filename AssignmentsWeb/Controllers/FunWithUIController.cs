using Microsoft.AspNetCore.Mvc;

namespace AssignmentsWeb.Controllers
{
    public class FunWithUIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Spinner()
        {
            return View();
        }

        public IActionResult CarouselSlide()
        {
            return View();
        }

        public IActionResult Buttons()
        {
            return View();
        }
    }
}
