namespace WildAnimalsAPI.Models.DTO
{
    public class CreateContinentDto
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int SurfaceKm2 { get; set; }

        public List<AnimalContinent>? AnimalContinentMappings { get; set; }
    }
}
