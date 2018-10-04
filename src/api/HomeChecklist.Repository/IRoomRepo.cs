using HomeChecklist.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeChecklist.Repository
{
    public interface IRoomRepo
    {
        Task<IEnumerable<Room>> GetRooms(int homeId);
        Task AddRoom(Room room);
        Task UpdateRoom(Room room);
        Task DeleteRoom(int roomId);
    }
}