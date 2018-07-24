using HomeChecklist.Common;
using System.Collections.Generic;

namespace HomeChecklist.Persistence.Entities
{
    public class Home : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Resident> Residents { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }

        public Home()
        {
            Residents = new List<Resident>();
            Rooms = new List<Room>();
        }
    }
}