using HomeChecklist.Persistence;
using HomeChecklist.Persistence.Entities;

namespace HomeChecklist.Repository
{
    public class TaskRepo : Repo<TaskItem>, ITaskRepo
    {
        public TaskRepo(HomeChecklistDbContext context) : base(context) { }
    }
}