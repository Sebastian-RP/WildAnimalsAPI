namespace WildAnimalsAPI.Models
{
    public class Continent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public long Population { get; set; }
        public long SurfaceKm2 { get; set; }

        public ICollection<AnimalContinent> AnimalContinents { get; set; } = new List<AnimalContinent>();
    }
}