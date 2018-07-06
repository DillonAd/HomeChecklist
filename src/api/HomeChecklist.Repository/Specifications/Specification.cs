using System;
using System.Linq;
using System.Linq.Expressions;

namespace HomeChecklist.Repository.Specifications
{
    public abstract class Specification<T>
    {
        public abstract Expression<Func<T, bool>> Expression { get; }

        public bool IsSatisfiedBy(T t) => Expression.Compile().Invoke(t);
    }
}