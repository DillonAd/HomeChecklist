using System;

namespace HomeChecklist.Repository.DTO
{
    public class Task
    {
        public string Name { get; set; }
        public DateTime LastDone { get; set; }
        public TimeSpan Interval { get; set; }

        public Task() { }
    }
}