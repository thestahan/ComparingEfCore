using API.Data.SeederDtos;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<UserSeedDto, User>();
            CreateMap<AddressSeedDto, Address>();
        }
    }
}
