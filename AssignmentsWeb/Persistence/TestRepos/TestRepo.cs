using AssignmentsWeb.Models.Domain;
using AssignmentsWeb.Models.Enums;

namespace AssignmentsWeb.Persistence.TestRepos
{
    public class TestRepo
    {
        private List<Assignment> _assignments = new List<Assignment>
        {
            new Assignment
            {
                Id = 1,
                Title = "Opgave 1",
                Subjects = Subjects.Programming,
                Description = "Du skal lære om enums"
            },
            new Assignment
            {
                Id = 2,
                Title = "Opgave 2",
                Subjects = Subjects.Systemdevelopment,
                Description = "Du skal nu lære om hvad en systemudviklings metode er"
            },
            new Assignment
            {
                Id = 3,
                Title = "Opgave 3",
                Subjects = Subjects.Technology,
                Description = "Vi skal lære om binare tal"
            }
        };

        public List<Assignment> GetAll()
        {
            foreach (var assignment in _assignments)
            {

            }

            return _assignments;
        }
    }
}
