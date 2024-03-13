using MarvelPersonalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace WildAnimalsAPI.Persistence
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
