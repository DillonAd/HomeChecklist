using HomeChecklist.Common;
using System.Collections.Generic;

namespace HomeChecklist.Repository.DTO
{
    public class ResidentDTO
    {
        public string Name { get; set; }
        
        public ResidentDTO() { }

        public ResidentDTO(string name)
        {
            Name = name;
        }
    }
}