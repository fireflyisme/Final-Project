

using AutoMapper;
using DomainLayer.ViewModels;
using FirstProgram1.Data;

namespace ServiceLayer
{
    public class MappingService : Profile

    {
        public MappingService()
        {
            CreateMap<AppUser, AppUserViewModel>()
                .ForMember(destination => destination.Program, option => option.MapFrom(source => source.Program.ProgramName))
                .ReverseMap();
        }
    }
}
