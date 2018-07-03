using System.Collections.Generic;

namespace HomeChecklist.Persistence.Entities
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