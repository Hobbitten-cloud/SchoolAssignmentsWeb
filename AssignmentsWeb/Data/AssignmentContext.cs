using AssignmentsWeb.Models;
using AssignmentsWeb.Models.Domain;
using AssignmentsWeb.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsWeb.Data
{
    public class AssignmentContext : IdentityDbContext<IdentityUser>
    {
        public AssignmentContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<IdentityUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Base data for Assignments
            modelBuilder.Entity<Assignment>().HasData(
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
                },
                new Assignment
                {
                    Id = 4,
                    Title = "Opgave 4",
                    Subjects = Subjects.Programming,
                    Description = "Vi skal nu snakke sammen med APIer"
                }
            );

        }
    }
}
