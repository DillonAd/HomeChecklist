using AutoMapper;
using HomeChecklist.DTO;
using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HomeChecklist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemController
    {
        private readonly ITaskRepo _repo;
        private readonly IMapper _mapper;

        public TaskItemController(ITaskRepo taskRepo, IMapper mapper) 
        {
            _repo = taskRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task GetTasks(int roomId)
        {
            var tasks = await _repo.GetTasks(roomId);
        }

        [HttpPost]
        public async Task CreateTask(TaskDTO dto)
        {
            var task = _mapper.Map<TaskItem>(dto);
            await _repo.CreateTask(task);
        }

        [HttpPut]
        public async Task UpdateTask(TaskDTO dto)
        {
            var task = _mapper.Map<TaskItem>(dto);
            await _repo.UpdateTask(task);
        }

        [HttpDelete]
        public async Task CompleteTask(int taskId)
        {
            await _repo.CompleteTask(taskId);
        }
    }
}
