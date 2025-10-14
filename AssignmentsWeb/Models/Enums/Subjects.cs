using System.ComponentModel.DataAnnotations;

namespace AssignmentsWeb.Models.Enums
{
    public enum Subjects
    {
        [Display(Name = "Programmering")]
        Programming,
        [Display(Name = "Teknologi")]
        Technology,
        [Display(Name = "Systemudvikling")]
        Systemdevelopment
    }
}
