using HomeChecklist.Common;
using System.Collections.Generic;

namespace HomeChecklist.Persistence.Entities
{
    public class Home : Entity
    {
        public string Name { get; set; }

        public Home() { }
    }
}