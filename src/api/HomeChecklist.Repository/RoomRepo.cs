using System.Collections.Generic;
using System.Threading.Tasks;
using HomeChecklist.Persistence;
using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository.Specifications;

namespace HomeChecklist.Repository
{
    public class RoomRepo : IRoomRepo
    {
        private readonly IRepo<Room> _repo;

        public RoomRepo(IRepo<Room> repo)
        {
            _repo = repo;
        }

        public async Task AddRoom(Room room)
        {
            await _repo.Insert(room);
            await _repo.Save();
        }

        public async Task DeleteRoom(int roomId)
        {
            await _repo.Delete(new GetEntityByIdSpec<Room>(roomId));
            await _repo.Save();
        }

        public Task<IEnumerable<Room>> GetRooms(int homeId)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateRoom(Room room)
        {
            throw new System.NotImplementedException();
        }
    }
}