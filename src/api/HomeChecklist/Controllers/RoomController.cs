﻿using HomeChecklist.Repository;
using HomeChecklist.Repository.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeChecklist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase<Room>
    {
        public RoomController(IRepo<Room> roomRepo) : base(roomRepo) { }
    }
}