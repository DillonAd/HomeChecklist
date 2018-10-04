using HomeChecklist.Common;
using HomeChecklist.Persistence;
using HomeChecklist.Repository.Specifications;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeChecklist.Repository
{
    public class Repo<T> : IRepo<T> where T : Entity
    {
        private readonly HomeChecklistDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repo(HomeChecklistDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T> GetSingle(Specification<T> spec)
        {
            return await _dbSet.FirstOrDefaultAsync(spec.Expression);
        }

        public async Task<IEnumerable<T>> Get(Specification<T> spec)
        {
            return await _dbSet.Where(spec.Expression).ToListAsync();
        }

        public async Task Insert(T t)
        {
            await _dbSet.AddAsync(t);
        }

        public async Task Update(T t)
        {
            await Task.FromResult(_dbSet.Update(t));
        }

        public async Task Delete(Specification<T> spec)
        {
            var targets = await Get(spec);

            foreach(var target in targets)
            {
                _dbSet.Remove(target);
            }
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}