using System.Collections.Generic;

namespace HomeChecklist.Persistence.Entities
{
    public class Room : Entity
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }

        public Room()
        {
            Tasks = new List<Task>();
        }
    }
}