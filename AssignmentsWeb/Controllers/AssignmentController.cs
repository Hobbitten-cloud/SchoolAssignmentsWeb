
using AssignmentsWeb.Models.Domain;
using AssignmentsWeb.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsWeb.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AssignmentController : Controller
    {
        private readonly AssignmentRepository _assignmentRepository;
        public AssignmentController(AssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var assignments = _assignmentRepository.GetAll();
            return View(assignments);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var assignment = _assignmentRepository.Get(id);
            return View(assignment);
        }

        [HttpPost]
        public IActionResult Edit(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                _assignmentRepository.Update(assignment.Id, assignment);
                return RedirectToAction("Index");
            }

            // If failed validation return to the same view
            ViewBag.Action = "Edit";
            return View(assignment);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            return View("Edit", new Assignment());
        }

        [HttpPost]
        public IActionResult Create(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                _assignmentRepository.create(assignment);
                return RedirectToAction("Index");
            }

            // If failed validation return to the same view
            ViewBag.Action = "Create";
            return View(assignment);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _assignmentRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
