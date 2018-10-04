using System;
using System.Linq.Expressions;
using HomeChecklist.Persistence.Entities;

namespace HomeChecklist.Repository.Specifications
{
    internal class RoomsByHomeSpec : Specification<Room>
    {
        private readonly int _homeId;

        public RoomsByHomeSpec(int homeId)
        {
            _homeId = homeId;
        }

        public override Expression<Func<Room, bool>> Expression =>
            t => t.HomeId == _homeId;
    }
}
