using HomeChecklist.Persistence;
using HomeChecklist.Persistence.Entities;

namespace HomeChecklist.Repository
{
    public class RoomRepo : Repo<Room>, IRoomRepo
    {
        public RoomRepo(HomeChecklistDbContext context) : base(context) { }
    }
}