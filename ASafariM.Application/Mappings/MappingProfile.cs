using ASafariM.Application.DTOs;
using ASafariM.Application.Mappings;
using ASafariM.Domain.Entities;
using AutoMapper;

namespace ASafariM.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Post, PostDto>();
            CreateMap<PostDto, Post>();

            CreateMap<ThemePreference, ThemePreferenceDto>();
            CreateMap<ThemePreferenceDto, ThemePreference>();
        }
    }
}
