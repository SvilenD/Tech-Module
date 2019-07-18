namespace ToDoList.Data
{

    using Microsoft.EntityFrameworkCore;
    using ToDoList.Models;

    public class ToDoDbContext : DbContext
    {
        private const string ConnectionString = @"Server =.\SQLEXPRESS; Database = ToDoListDatabase; Integrated Security = true";

        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
