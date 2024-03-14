using System.ComponentModel;

namespace WildAnimalsAPI.Models.DTO
{
    public class CreateUserDto
    {
        public string UserName { get; set; }
        [DefaultValue("standar")]
        public string Rol { get; set; } = "standar";
        public string Email { get; set; }
        public string PassWord { get; set; }
    }
}
