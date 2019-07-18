namespace TeisterMask.Data
{

    using Microsoft.EntityFrameworkCore;
    using TeisterMask.Models;

    public class MeisterTaskDbContext : DbContext
    {
        public const string ConnectionString = @"Server=.\SQLEXPRESS;Database=MeisterTaskDatabase; Integrated security = true;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public virtual DbSet<Task> Tasks { get; set; }
    }
}
