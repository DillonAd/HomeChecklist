using AutoMapper;
using HomeChecklist.DTO;
using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeChecklist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase<Home, HomeDTO>
    {
        public HomeController(IRepo<Home> homeRepo, IMapper mapper) 
            : base(homeRepo, mapper) { }
    }
}
