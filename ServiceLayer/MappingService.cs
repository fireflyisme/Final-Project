

using AutoMapper;
using DomainLayer.ViewModels;
using Inventory1.Data;

namespace ServiceLayer
{
    public class MappingService : Profile

    {
        public MappingService()
        {
            CreateMap<AppUser, AppUserViewModel>()
                .ForMember(destination => destination.Program, option => option.MapFrom(source => source.Programs.ProgramName))
                .ReverseMap();
        }
    }
}
