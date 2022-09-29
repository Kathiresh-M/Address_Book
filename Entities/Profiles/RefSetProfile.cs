using AutoMapper;
using Entities.Dto;
using Entities.Models;

namespace Entities.Profiles
{
    public class RefSetProfile : Profile
    {
        public RefSetProfile()
        {
            CreateMap<RefSet, RefSetDto>().ReverseMap();
        }
    }
}
