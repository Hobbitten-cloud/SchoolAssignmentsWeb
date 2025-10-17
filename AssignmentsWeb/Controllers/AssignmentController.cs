
using AssignmentsWeb.Models.Domain;
using AssignmentsWeb.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsWeb.Controllers
{
    //[Authorize(Roles = "Admin")]
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
            ViewBag.Action = "edit";
            var assignment = _assignmentRepository.Get(id);
            return View(assignment);
        }

        [HttpPost]
        public IActionResult Edit(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _assignmentRepository.Update(assignment.Id, assignment);
                    return RedirectToAction("Index");
                }
                catch (DbUpdateConcurrencyException)
                {
                    // Concurrency conflict: refresh token, keep user's edits, ask to save again
                    // Get the current database values
                    var databaseEntity = _assignmentRepository.Get(assignment.Id);

                    // Update the RowVersion to the current database value
                    if (databaseEntity != null)
                    {
                        assignment.RowVersion = databaseEntity.RowVersion; // refresh token
                    }

                    // Add a model error to inform the user
                    ModelState.AddModelError(string.Empty, "Denne opgave blev ændret af en anden bruger. Gennemse og gem igen.");
                    ViewBag.Action = "edit";
                    return View(assignment);
                }
            }

            // If failed validation return to the same view
            ViewBag.Action = "edit";
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
                _assignmentRepository.Create(assignment);
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
