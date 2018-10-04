using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository.Specifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeChecklist.Repository
{
    public interface ITaskRepo
    {
        Task<TaskItem> GetTask(int id);
        Task<IEnumerable<TaskItem>> GetTasks(Room room);
        Task CreateTask(TaskItem task);
        Task CompleteTask(int id);
    }
}