using System;
using System.Linq.Expressions;

namespace HomeChecklist.Repository.Specifications
{
    internal class AndSpec<T> : Specification<T>
    {
        private readonly Specification<T> _specification1;
        private readonly Specification<T> _specification2;

        public AndSpec(Specification<T> specification1, Specification<T> specification2)
        {
            _specification1 = specification1;
            _specification2 = specification2;
        }

        public override Expression<Func<T, bool>> Expression =>
            s => _specification1.IsSatisfiedBy(s) && _specification2.IsSatisfiedBy(s);
    }
}