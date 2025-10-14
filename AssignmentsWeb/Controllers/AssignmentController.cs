
using AssignmentsWeb.Models.Domain;
using AssignmentsWeb.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsWeb.Controllers
{
    public class AssignmentController : Controller
    {
        private readonly AssignmentRepository _assignmentRepository;
        public AssignmentController(AssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public IActionResult Index()
        {
            var assignments = _assignmentRepository.GetAll();
            return View(assignments);
        }
    }
}
