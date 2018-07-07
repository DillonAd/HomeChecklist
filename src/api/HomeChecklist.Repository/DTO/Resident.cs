using HomeChecklist.Common;
using System.Collections.Generic;

namespace HomeChecklist.Repository.DTO
{
    public class Resident : Entity
    {
        public string Name { get; set; }
        
        public Resident() { }

        public Resident(string name)
        {
            Name = name;
        }
    }
}