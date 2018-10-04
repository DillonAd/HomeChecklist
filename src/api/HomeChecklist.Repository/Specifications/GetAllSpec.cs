using HomeChecklist.Common;
using System;
using System.Linq.Expressions;

namespace HomeChecklist.Repository.Specifications
{
    internal class GetAllSpec<T> : Specification<T>
        where T : Entity
    {
        public override Expression<Func<T, bool>> Expression =>
            e => e.Id == e.Id;
    }
}