using AssignmentsWeb.Models.Domain;
using Microsoft.AspNetCore.Identity;

namespace AssignmentsWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Navigation property for the assignments associated with the user
        //public List<Assignment>? Assignments { get; set; }
    }
}
