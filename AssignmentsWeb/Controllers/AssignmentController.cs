
using AssignmentsWeb.Models.Domain;
using AssignmentsWeb.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsWeb.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index()
        {
            var testRepo = new TestRepo();
            return View(testRepo.GetAll());
        }
    }
}
