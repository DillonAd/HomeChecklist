using HomeChecklist.Repository;
using HomeChecklist.Repository.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeChecklist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase<Room>
    {
        public HomeController(IRepo<Room> roomRepo) : base(roomRepo) { }
    }
}
