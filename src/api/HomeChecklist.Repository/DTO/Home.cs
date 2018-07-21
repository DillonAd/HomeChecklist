using HomeChecklist.Common;
using HomeChecklist.Persistence.Entities;
using System.Collections.Generic;

namespace HomeChecklist.Repository.DTO
{
    public class Home : Entity
    {
        public string Name { get; set; }
        public List<Resident> Residents { get; set; }
        public List<Room> Rooms { get; set; }

        public Home()
        {
            Residents = new List<Resident>();
            Rooms = new List<Room>();
        }
    }
}