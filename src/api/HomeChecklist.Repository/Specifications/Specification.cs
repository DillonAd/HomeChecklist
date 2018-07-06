using System.Linq;
using System.Linq.Expression;

namespace HomeChecklist.Repository.Specifications
{
    public abstract class ISpecification<T>
    {
        public abstract Expression<Func<T, bool> Expression { get; }

        public bool IsSatisfiedBy(T t) => Expression.AsFunc(t);
    }
}