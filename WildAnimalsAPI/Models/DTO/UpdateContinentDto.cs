namespace WildAnimalsAPI.Models.DTO
{
    public class UpdateContinentDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public long Population { get; set; }
        public long SurfaceKm2 { get; set; }
    }
}
