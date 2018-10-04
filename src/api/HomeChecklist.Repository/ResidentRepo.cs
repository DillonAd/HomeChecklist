using HomeChecklist.Persistence;
using HomeChecklist.Persistence.Entities;

namespace HomeChecklist.Repository
{
    public class ResidentRepo : IResidentRepo
    {
        public ResidentRepo(HomeChecklistDbContext context) { }
    }
}