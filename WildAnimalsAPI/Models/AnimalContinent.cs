namespace WildAnimalsAPI.Models
{
    public class AnimalContinent
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public Animal? Animal { get; set; }
        public int ContinentId { get; set; }
        public Continent? Continent { get; set; }
    }
}
