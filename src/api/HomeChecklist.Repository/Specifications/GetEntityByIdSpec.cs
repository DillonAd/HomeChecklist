using HomeChecklist.Common;
using System;
using System.Linq.Expressions;

namespace HomeChecklist.Repository.Specifications
{
    internal class GetEntityByIdSpec<T> : Specification<T>
        where T : Entity
    {
        public override Expression<Func<T, bool>> Expression =>
            e => e.Id == _id;

        private readonly int _id;

        public GetEntityByIdSpec(int id)
        {
            _id = id;
        }
    }
}