using AssignmentsWeb.Data;
using AssignmentsWeb.Models.Domain;
using Microsoft.EntityFrameworkCore;


namespace AssignmentsWeb.Persistence
{
    public class AssignmentRepository
    {
        private readonly AssignmentContext _assignmentContext;
        private List<Assignment> _assignments;

        public AssignmentRepository(AssignmentContext context)
        {
            _assignmentContext = context;
        }
        public void create (Assignment assignment)
        {
            if (assignment == null) return;

            _assignmentContext.Assignments.Add(assignment);
            _assignmentContext.SaveChanges();
        }
        public void Update(int id, Assignment assignment) 
        {
            var assignmentToUpdate = Get(id);
            if (assignmentToUpdate != null) 
            {
                assignmentToUpdate.Title = assignment.Title;
                assignmentToUpdate.Description = assignment.Description;
                _assignmentContext.SaveChanges();
            }
            // look at UpdateStudent from https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
            //_assignmentContext.Entry(assignment).State = EntityState.Modified;
        }
        public Assignment Get(int id) 
        {
            //This commented out code is how we did it in DiveDeep with .include for each scuffed class
            //return _assignmentContext.Assignments
            //    .FirstOrDefault(p => p.Id == id);

            return _assignmentContext.Assignments.Find(id);
        }
        public List<Assignment> GetAll()
        {
            return _assignmentContext.Assignments.ToList();
        }
        public void Delete(int id) 
        {
            Assignment assignment = _assignmentContext.Assignments.Find(id);
            _assignmentContext.Assignments.Remove(assignment);
        }
    }
}
