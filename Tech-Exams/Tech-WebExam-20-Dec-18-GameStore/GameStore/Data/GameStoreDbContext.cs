using GameStore.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Data
{
    public class GameStoreDbContext:DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=GameStore;Integrated Security = true;";

        public virtual DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
