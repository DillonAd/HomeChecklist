using System;
using System.Linq.Expressions;
using HomeChecklist.Persistence.Entities;

namespace HomeChecklist.Repository.Specifications
{
    internal class TasksByRoomSpec : Specification<TaskItem>
    {
        private readonly Room _room;

        public TasksByRoomSpec(Room room)
        {
            _room = room;
        }

        public override Expression<Func<TaskItem, bool>> Expression =>
            t => t.RoomId == _room.Id;
    }
}
