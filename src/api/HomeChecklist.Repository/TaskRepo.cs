using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository.Specifications;

namespace HomeChecklist.Repository
{
    public class TaskRepo : ITaskRepo
    {
        private readonly IRepo<TaskItem> _repo;

        public TaskRepo(IRepo<TaskItem> repo)
        {
            _repo = repo;
        }

        public async Task CompleteTask(int id)
        {
            var task = await _repo.GetSingle(new GetEntityByIdSpec<TaskItem>(id));
            task.LastDone = DateTime.UtcNow;

            await _repo.Update(task);
        }

        public async Task CreateTask(TaskItem task)
        {
            await _repo.Insert(task);
            await _repo.Save();
        }

        public async Task<TaskItem> GetTask(int id) =>
            await _repo.GetSingle(new GetEntityByIdSpec<TaskItem>(id));

        public async Task<IEnumerable<TaskItem>> GetTasks(Room room) =>
            await _repo.Get(new TasksByRoomSpec(room));

        public async Task<IEnumerable<TaskItem>> GetActiveTasks(Room room) =>
            await _repo.Get(new TasksByRoomSpec(room).And(new ActiveTaskSpec(true)));
    }
}