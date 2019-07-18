namespace BandRegister.Data
{
    using BandRegister.Models;
    using Microsoft.EntityFrameworkCore;

    public class BandRegisterDbContext : DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=BandRegister;Integrated Security = true;";

        public virtual DbSet<Band> Bands { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
