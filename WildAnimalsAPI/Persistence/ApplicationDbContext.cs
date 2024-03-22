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
        public DbSet<AnimalContinent> AnimalContinents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimalContinent>().HasKey(ac => new { ac.AnimalId, ac.ContinentId });

            //modelBuilder.Entity<AnimalContinent>()
            //    .HasOne(ac => ac.Animal)
            //    .WithMany(a => a.Continents)
            //    .HasForeignKey(ac => ac.AnimalId);

            //modelBuilder.Entity<AnimalContinent>()
            //    .HasOne(ac => ac.Continent)
            //    .WithMany(c => c.Animals)
            //    .HasForeignKey(ac => ac.ContinentId);

            //Seed data
            modelBuilder.ApplyConfiguration(new ContinentSeed());
        }
    }
}
