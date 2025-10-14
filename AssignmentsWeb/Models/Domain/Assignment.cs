using AssignmentsWeb.Models.Enums;

namespace AssignmentsWeb.Models.Domain
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Subjects Subjects { get; set; }
    }
}
