using HomeChecklist.Common;
using System;

namespace HomeChecklist.Persistence.Entities
{
    public class TaskItem : Entity
    {
        public string Name { get; set; }
        public DateTime LastDone { get; set; }
        public TimeSpan Interval { get; set; }
        public bool IsActive { get; set; }

        public int RoomId { get; set; }
        public int? ResidentId { get; set; }
        
        public TaskItem() { }
    }
}