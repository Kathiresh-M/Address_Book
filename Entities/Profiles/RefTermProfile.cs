using AutoMapper;
using Entities.Dto;
using Entities.Models;

namespace Entities.Profiles
{
    public class RefTermProfile : Profile
    {
        public RefTermProfile()
        {
            CreateMap<RefTerm, RefTermDto>().ReverseMap();
        }
    }
}
