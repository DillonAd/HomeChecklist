using System;
using System.Linq.Expressions;
using HomeChecklist.Persistence.Entities;

namespace HomeChecklist.Repository.Specifications
{
    internal class ActiveTaskSpec : Specification<TaskItem>
    {
        private readonly bool _isActive;

        public ActiveTaskSpec(bool isActive)
        {
            _isActive = isActive;
        }

        public override Expression<Func<TaskItem, bool>> Expression =>
            t => t.LastDone > DateTime.UtcNow;
    }
}
