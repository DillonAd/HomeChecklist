using HomeChecklist.Persistence;
using HomeChecklist.Persistence.Entities;

namespace HomeChecklist.Repository
{
    public class HomeRepo : Repo<Home>, IHomeRepo
    {
        public HomeRepo(HomeChecklistDbContext context) : base(context) { }
    }
}