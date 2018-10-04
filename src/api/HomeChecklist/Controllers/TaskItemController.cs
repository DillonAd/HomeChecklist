using AutoMapper;
using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository;
using Microsoft.AspNetCore.Mvc;

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
    }
}
