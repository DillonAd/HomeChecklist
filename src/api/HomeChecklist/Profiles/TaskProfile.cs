using AutoMapper;
using HomeChecklist.DTO;
using HomeChecklist.Persistence.Entities;

namespace HomeChecklist.Profiles
{
    public class TaskProfile : Profile
    {
        public TaskProfile()
        {
            CreateMap<TaskDTO, TaskItem>()
                .ForMember(t => t.Id, m => m.MapFrom(t => t.Id))
                .ForMember(t => t.Name, m => m.MapFrom(t => t.Name))
                .ForMember(t => t.Interval, m => m.MapFrom(t => t.Interval))
                .ForMember(t => t.LastDone, m => m.MapFrom(t => t.LastDone))
                .ForMember(t => t.RoomId, m => m.Ignore())
                .ForMember(t => t.ResidentId, m => m.Ignore());
        }
    }
}