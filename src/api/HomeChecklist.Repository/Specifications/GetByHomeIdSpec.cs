using HomeChecklist.Common;
using System;
using System.Linq.Expressions;

namespace HomeChecklist.Repository.Specifications
{
    public class GetByHomeIdSpec<TEntity> : Specification<TEntity>
        where TEntity : Entity, IHomeEntity
    {
        private readonly int _homeId;

        public GetByHomeIdSpec(int homeId)
        {
            _homeId = homeId;
        }

        public override Expression<Func<TEntity, bool>> Expression =>
            e => e.HomeId == _homeId;
    }
}