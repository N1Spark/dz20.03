using Microsoft.EntityFrameworkCore;
using GameLibrary;

namespace GameContextLibrary
{
    public class GameContext : DbContext
    {
        public GameContext()
        {
            //Database.EnsureCreated();
        }
        public DbSet<Game> Games { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=DESKTOP-SE38RKL;Database=GameMigrations;Integrated Security=SSPI;TrustServerCertificate=true");
        }
    }
}
