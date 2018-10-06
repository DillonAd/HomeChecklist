using System;
using System.Linq.Expressions;
using HomeChecklist.Persistence.Entities;

namespace HomeChecklist.Repository.Specifications
{
    internal class TasksByRoomSpec : Specification<TaskItem>
    {
        private readonly int _roomId;

        public TasksByRoomSpec(int roomId)
        {
            _roomId = roomId;
        }

        public override Expression<Func<TaskItem, bool>> Expression =>
            t => t.RoomId == _roomId;
    }
}
