using HomeChecklist.Common;
using HomeChecklist.Repository.Specifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeChecklist.Repository
{
    public interface IRepo<T> where T : Entity
    {
        Task<T> GetSingle(Specification<T> spec);
        Task<IEnumerable<T>> Get(Specification<T> spec);
        Task Insert(T t);
        Task Update(T t);
        Task Delete(Specification<T> spec);
        Task Save();
    }
}