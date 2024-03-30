using System.ComponentModel;

namespace WildAnimalsAPI.Models.DTO
{
    public class CreateAnimalDto
    {
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

        [DefaultValue("formato: '1;2;3'")]
        public string Locations { get; set; }
    }
}
