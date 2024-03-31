using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WildAnimalsAPI.Models;

namespace WildAnimalsAPI.Persistence.Seeders
{
    public class ContinentSeed : IEntityTypeConfiguration<Continent>
    {
        public void Configure(EntityTypeBuilder<Continent> builder)
        {
            builder.HasData(
                new Continent { Id = 1, Name = "Asia", Population = 4693000000, SurfaceKm2 = 44614000 },
                new Continent { Id = 2, Name = "Africa", Population = 1386000000, SurfaceKm2 = 30370000 },
                new Continent { Id = 3, Name = "America del Norte", Population = 593000000, SurfaceKm2 = 24709000 },
                new Continent { Id = 4, Name = "America del Sur", Population = 434000000, SurfaceKm2 = 17843000 },
                new Continent { Id = 5, Name = "Antártida", Population = 0, SurfaceKm2 = 14200000 },
                new Continent { Id = 6, Name = "Europa", Population = 741000000, SurfaceKm2 = 10180000 },
                new Continent { Id = 7, Name = "Oceanía", Population = 44000000, SurfaceKm2 = 8920000 }
            );
        }
    }
}
