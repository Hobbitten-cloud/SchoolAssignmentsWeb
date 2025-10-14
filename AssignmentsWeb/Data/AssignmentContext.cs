using AssignmentsWeb.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsWeb.Data
{
    public class AssignmentContext : DbContext
    {
        public DbSet<Assignment> Assignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Assignment>().HasData(
                new Assignment { Id = 1, Title = "Skibidi", Description = "dubdubdub yes yes yes"},
                new Assignment { Id = 2, Title = "Skibidi2", Description = "dubdubdub yes yes yes squared"},
                new Assignment { Id = 3, Title = "Skibidi3", Description = "dubdubdub yes yes yes cubed"}
            );

        }
        public AssignmentContext(DbContextOptions contextOptions): base (contextOptions)
        {
            
        }
    }
}
