using AutoMapper;
using HomeChecklist.DTO;
using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository;
using HomeChecklist.Repository.Specifications;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeChecklist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase<Room, RoomDTO>
    {
        public RoomController(IRepo<Room> roomRepo, IMapper mapper) 
            : base(roomRepo, mapper) { }

        [HttpGet]
        public RoomDTO[] GetRooms(int homeId)
        {
            var results = _repo.Get(new GetByHomeIdSpec<Room>(homeId));
            return _mapper.Map<RoomDTO[]>(results);
        }
    }
}
