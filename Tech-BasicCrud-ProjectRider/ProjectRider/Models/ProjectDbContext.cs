using Microsoft.EntityFrameworkCore;

namespace ProjectRider.Models
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=ProjectRider;Integrated Security = true;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
