using HomeChecklist.Common;
using System.Collections.Generic;

namespace HomeChecklist.Persistence.Entities
{
    public class Room : Entity
    {
        public string Name { get; set; }
        public int HomeId { get; set; }
    }
}