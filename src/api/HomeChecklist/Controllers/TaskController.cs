using HomeChecklist.Repository;
using HomeChecklist.Repository.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeChecklist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase<Task>
    {
        public TaskController(IRepo<Task> taskRepo) : base(taskRepo) { }
    }
}
