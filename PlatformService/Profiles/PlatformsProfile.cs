using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        // This is where we will define our mappings
        public PlatformsProfile()
        {
            // Source (Model / Platform model) -> Target (DTO / PlatformReadDto)
            CreateMap<Platform, PlatformReadDto>(); // This is a mapping from Platform Model to PlatformReadDto
            CreateMap<PlatformCreateDto, Platform>(); // This is a mapping from PlatformCreateDto to Platform
        }
    }
}