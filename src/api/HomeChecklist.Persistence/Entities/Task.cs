using HomeChecklist.Common;
using System;

namespace HomeChecklist.Persistence.Entities
{
    public class Task : Entity
    {
        public string Name { get; set; }
        public DateTime LastDone { get; set; }
        public TimeSpan Interval { get; set; }

        public Task() { }
    }
}