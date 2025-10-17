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

        public void Create(Assignment assignment)
        {
            if (assignment == null) return;

            _assignmentContext.Assignments.Add(assignment);
            _assignmentContext.SaveChanges();
        }

        public void Update(int id, Assignment assignment)
        {
            // Attach the incoming entity with its original RowVersion so EF can
            // perform optimistic concurrency checks.
            // If the RowVersion in the database has changed since the entity was created
            // (i.e., another user has updated it), EF will throw a DbUpdateConcurrencyException.
            assignment.Id = id;
            _assignmentContext.Attach(assignment);
            _assignmentContext.Entry(assignment).Property(a => a.Title).IsModified = true;
            _assignmentContext.Entry(assignment).Property(a => a.Description).IsModified = true;
            _assignmentContext.Entry(assignment).Property(a => a.Subjects).IsModified = true;

            // Set the original RowVersion value for concurrency check
            // This ensures that EF compares the original RowVersion with the current one in the database
            _assignmentContext.Entry(assignment).Property(a => a.RowVersion).OriginalValue = assignment.RowVersion;
            _assignmentContext.SaveChanges();

            //// Alternative approach: Fetch the existing entity and update its properties
            //var assignmentToUpdate = Get(id);
            //if (assignmentToUpdate != null)
            //{
            //    assignmentToUpdate.Title = assignment.Title;
            //    assignmentToUpdate.Description = assignment.Description;
            //    assignmentToUpdate.Subjects = assignment.Subjects;
            //    _assignmentContext.SaveChanges();
            //}
            //// look at UpdateStudent from https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
            ////_assignmentContext.Entry(assignment).State = EntityState.Modified;
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
            _assignmentContext.SaveChanges();
        }
    }
}
