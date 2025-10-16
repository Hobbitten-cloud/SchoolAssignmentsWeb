using AssignmentsWeb.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace AssignmentsWeb.Models.Domain
{
    public class Assignment
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Subjects? Subjects { get; set; }
    }
}
