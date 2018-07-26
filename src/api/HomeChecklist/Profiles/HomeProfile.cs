using AutoMapper;
using HomeChecklist.DTO;
using HomeChecklist.Persistence.Entities;

namespace HomeChecklist.Profiles
{
    public class HomeProfile : Profile
    {
        public HomeProfile()
        {
            CreateMap<HomeDTO, Home>()
                .ForMember(h => h.Id, m => m.MapFrom(h => h.Id))
                .ForMember(h => h.Name, m => m.MapFrom(h => h.Name));
        }
    }
}