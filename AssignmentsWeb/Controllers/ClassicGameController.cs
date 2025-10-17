using Microsoft.AspNetCore.Mvc;

namespace AssignmentsWeb.Controllers
{
    public class ClassicGameController : Controller
    {
        public IActionResult CookieClicker()
        {
            return View();
        }

        public IActionResult Tetris()
        {
            return View();
        }

        public IActionResult Snake()
        {
            return View();
        }
    }
}
