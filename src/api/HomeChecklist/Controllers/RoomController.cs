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
    public class RoomController
    {
        private readonly IRoomRepo _repo;
        private readonly IMapper _mapper;

        public RoomController(IRoomRepo roomRepo, IMapper mapper) 
        {
            _repo = roomRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<RoomDTO[]> GetRooms(int homeId)
        {
            var results = await _repo.GetRooms(homeId);
            return _mapper.Map<RoomDTO[]>(results);
        }

        [HttpPost]
        public async Task CreateRoom(RoomDTO dto)
        {
            var room = _mapper.Map<Room>(dto);
            await _repo.AddRoom(room);
        }

        [HttpPut]
        public async Task UpdateRoom(RoomDTO dto)
        {
            var room = _mapper.Map<Room>(dto);
            await _repo.UpdateRoom(room);
        }

        [HttpDelete]
        public async Task DeleteRoom(int roomId)
        {
            await _repo.DeleteRoom(roomId);
        }
    }
}
