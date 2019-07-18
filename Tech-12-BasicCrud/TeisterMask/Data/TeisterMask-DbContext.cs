namespace TeisterMask.Data
{
    using Microsoft.EntityFrameworkCore;
    using TeisterMask.Models;

    public class TeisterMask_DbContext : DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=NameOfCurrentDataBase;Integrated Security = true;";

        public virtual DbSet<Task> Tasks { get; set; }		//mapping our Model to DataBase tables with same name!!!

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // override on ..Configuring.. 
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
