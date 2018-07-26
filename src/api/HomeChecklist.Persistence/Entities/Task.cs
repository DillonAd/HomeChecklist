using HomeChecklist.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeChecklist.Persistence.Entities
{
    public class Task : Entity
    {
        public string Name { get; set; }
        public DateTime LastDone { get; set; }
        public TimeSpan Interval { get; set; }

        public int HomeId { get; set; }
        public int? ResidentId { get; set; }
        

        public Task() { }
    }
}