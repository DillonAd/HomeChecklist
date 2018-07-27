using AutoMapper;
using HomeChecklist.DTO;
using HomeChecklist.Persistence.Entities;

namespace HomeChecklist.Profiles
{
    public class ResidentProfile : Profile
    {
        public ResidentProfile()
        {
            CreateMap<ResidentDTO, Resident>()
                .ForMember(r => r.Id, m => m.MapFrom(r => r.Id))
                .ForMember(r => r.Name, m => m.MapFrom(r => r.Name))
                .ForMember(r => r.HomeId, m => m.MapFrom(r => r.HomeId));
        }
    }
}