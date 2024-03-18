namespace WildAnimalsAPI.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public int AverageHeightMin { get; set; }
        public int AverageHeightMax { get; set; }
        public string Description { get; set; }
        public int AverageSpeedMin { get; set; }
        public int AverageSpeedMax { get; set; }
        public int AverageWeightMin { get; set; }
        public int AverageWeightMax { get; set; }
        public int EstimatedPopulationSize { get; set; }
        public int AverageLifespanMin { get; set; }
        public int AverageLifespanMax { get; set; }
        public string Diet { get; set; }

        public List<AnimalContinentMapping> AnimalContinentMappings { get; set; }
    }
}
