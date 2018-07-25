using HomeChecklist.Common;
using System.Collections.Generic;

namespace HomeChecklist.DTO
{
    public class RoomDTO
    {
        public string Name { get; set; }
        public List<TaskDTO> Tasks { get; set; }

        public RoomDTO()
        {
            Tasks = new List<TaskDTO>();
        }
    }
}