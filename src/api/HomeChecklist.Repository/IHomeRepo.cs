using HomeChecklist.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeChecklist.Repository
{
    public interface IHomeRepo
    {
        Task<IEnumerable<Home>> GetHomes();
        Task<Home> GetHome(int id);
        Task CreateHome(Home home);
        Task UpdateHome(Home home);
        Task DeleteHome(int id);
    }
}