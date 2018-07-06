using System.Collections.Generic;

namespace HomeChecklist.Repository.DTO
{
    public class Resident
    {
        public string Name { get; set; }
        
        public Resident() { }

        public Resident(string name)
        {
            Name = name;
        }
    }
}