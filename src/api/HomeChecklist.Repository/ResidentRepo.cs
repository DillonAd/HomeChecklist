using HomeChecklist.Persistence;
using HomeChecklist.Persistence.Entities;

namespace HomeChecklist.Repository
{
    public class ResidentRepo : Repo<Resident>, IResidentRepo
    {
        public ResidentRepo(HomeChecklistDbContext context) : base(context) { }
    }
}