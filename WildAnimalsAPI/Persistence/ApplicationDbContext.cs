using MarvelPersonalProject.Models;
using Microsoft.EntityFrameworkCore;
using WildAnimalsAPI.Models;

namespace WildAnimalsAPI.Persistence
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Continent> Continents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed data
            modelBuilder.ApplyConfiguration(new ContinentSeed());
        }
    }
}
