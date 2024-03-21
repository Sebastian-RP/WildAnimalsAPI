using AutoMapper;
using MarvelPersonalProject.Models;
using WildAnimalsAPI.Models;
using WildAnimalsAPI.Models.DTO;

namespace WildAnimalsAPI
{
    public class ConfigAutoMapper : Profile
    {
        public ConfigAutoMapper()
        {
            CreateMap<CreateUserDto, User>().ReverseMap();
            CreateMap<SignInUser, User>().ReverseMap();
            CreateMap<CreateContinentDto, Continent>().ReverseMap();
        }
    }
}
