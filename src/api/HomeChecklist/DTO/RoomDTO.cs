using HomeChecklist.Common;
using System.Collections.Generic;

namespace HomeChecklist.DTO
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HomeId { get; set; }
    }
}