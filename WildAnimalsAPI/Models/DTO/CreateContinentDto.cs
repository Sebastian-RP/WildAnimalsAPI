namespace WildAnimalsAPI.Models.DTO
{
    public class CreateContinentDto
    {
        public string Name { get; set; }
        public long Population { get; set; }
        public long SurfaceKm2 { get; set; }

        public List<AnimalContinent>? AnimalContinentMappings { get; set; }
    }
}
