using AutoMapper;
using MyToDoAPI.Model;
using MyToDoAPI.Model.Dto;

namespace MyToDoAPI.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
