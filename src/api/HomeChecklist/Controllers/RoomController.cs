using AutoMapper;
using HomeChecklist.DTO;
using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeChecklist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase<Room, RoomDTO>
    {
        public RoomController(IRepo<Room> roomRepo, IMapper mapper) 
            : base(roomRepo, mapper) { }
    }
}
