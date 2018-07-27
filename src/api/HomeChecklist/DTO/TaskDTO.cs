using HomeChecklist.Common;
using System;

namespace HomeChecklist.DTO
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LastDone { get; set; }
        public TimeSpan Interval { get; set; }

        public TaskDTO() { }
    }
}