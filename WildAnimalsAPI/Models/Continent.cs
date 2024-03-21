namespace WildAnimalsAPI.Models
{
    public class Continent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Population { get; set; }
        public int SurfaceKm2 { get; set; }

        public ICollection<AnimalContinent> Animals { get; set; } = new List<AnimalContinent>();
    }
}