using HomeChecklist.Common;
using System.Collections.Generic;

namespace HomeChecklist.DTO
{
    public class HomeDTO : Entity
    {
        public string Name { get; set; }
        public List<ResidentDTO> Residents { get; set; }
        public List<RoomDTO> Rooms { get; set; }

        public HomeDTO()
        {
            Residents = new List<ResidentDTO>();
            Rooms = new List<RoomDTO>();
        }
    }
}