using HomeChecklist.Common;
using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository.Specifications;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HomeChecklist.Repository
{
    public class Repo<T> where T : Entity, IRepo<T>
    {
        private readonly DbSet<T> _dbSet;

        public Repo(DbSet<T> dbSet)
        {
            _dbSet = dbSet;
        }

        public T GetSingle(Specification<T> spec)
        {
            return _dbSet.FirstOrDefault(spec.Expression);
        }

        public IEnumerable<T> Get(Specification<T> spec)
        {
            return _dbSet.Where(spec.Expression);
        }

        public void Insert(T t)
        {
            _dbSet.Add(t);
        }

        public void Update(T t)
        {
            _dbSet.Update(t);
        }

        public void Delete(Specification<T> spec)
        {
            var targets = Get(spec);

            foreach(var target in targets)
            {
                _dbSet.Remove(target);
            }
        }
    }
}