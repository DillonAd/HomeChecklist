using HomeChecklist.Persistence;
using HomeChecklist.Persistence.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HomeChecklist.Repository
{
    public class HomeRepo : Repo<Home>
    {
        private readonly HomeChecklistDbContext _context;

        public HomeRepo(HomeChecklistDbContext context) : base(context.Homes)
        {
            _context = context;
        }
    }
}