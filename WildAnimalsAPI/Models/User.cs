﻿namespace MarvelPersonalProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Rol { get; set; } = "standar";
        public string Email { get; set; }
        public string PassWord { get; set; }
    }
}
