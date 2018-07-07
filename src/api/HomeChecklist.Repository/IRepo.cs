using HomeChecklist.Common;
using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository.Specifications;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HomeChecklist.Repository
{
    public interface IRepo<T> where T : Entity
    {
        T GetSingle(Specification<T> spec);
        IEnumerable<T> Get(Specification<T> spec);
        void Insert(T t);
        void Update(T t);
        void Delete(Specification<T> spec);
    }
}