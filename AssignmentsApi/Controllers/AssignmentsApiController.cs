using AssignmentsWeb.Data;
using AssignmentsWeb.Models.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AssignmentsApiController : Controller
    {
        private readonly AssignmentContext _assignmentContext;
        public AssignmentsApiController(AssignmentContext assignmentContext)
        {
            _assignmentContext = assignmentContext;
        }

        [HttpPost]
        public async Task<Assignment> Create(Assignment assignment)
        {
            if (assignment == null) throw new ArgumentNullException(nameof(assignment));
            _assignmentContext.Assignments.Add(assignment);
            await _assignmentContext.SaveChangesAsync();
            return assignment;
        }

        [HttpPost]
        public async Task<Assignment> Update(int id, Assignment assignment)
        {
            var assignmentToUpdate = await Get(id);
            if (assignmentToUpdate != null)
            {
                assignmentToUpdate.Title = assignment.Title;
                assignmentToUpdate.Description = assignment.Description;
                assignmentToUpdate.Subjects = assignment.Subjects;
                await _assignmentContext.SaveChangesAsync();
            }
            return assignment;
        }

        [HttpGet("/{id}")]
        public async Task<Assignment> Get(int id)
        {
            var assignment = await _assignmentContext.Assignments.FindAsync(id);
            return assignment;
        }

        [HttpGet]
        public async Task<List<Assignment>> GetAll()
        {
            return await _assignmentContext.Assignments.ToListAsync();
        }

        [HttpDelete, Authorize]
        public async Task<Assignment> Delete(int id)
        {
            var assignment = await _assignmentContext.Assignments.FindAsync(id);
            _assignmentContext.Assignments.Remove(assignment);
            _assignmentContext.SaveChanges();
            return assignment;
        }
    }
}
