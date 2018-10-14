using HomeChecklist.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeChecklist.Repository
{
    public interface IResidentRepo
    {
        Task CreateResident(Resident resident);
        Task<Resident> GetResident(int residentId);
        Task<IEnumerable<Resident>> GetResidents(int homeId);
        Task UpdateResident(Resident resident);
    }
}