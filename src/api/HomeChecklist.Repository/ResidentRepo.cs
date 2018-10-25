using HomeChecklist.Persistence;
using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository.Specifications;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeChecklist.Repository
{
    public class ResidentRepo : IResidentRepo
    {
        private readonly IRepo<Resident> _repo;

        public ResidentRepo(IRepo<Resident> repo)
        {
            _repo = repo;
        }

        public async Task CreateResident(Resident resident)
        {
            await _repo.Insert(resident);
            await _repo.Save();
        }

        public async Task<Resident> GetResident(int residentId) =>
            await _repo.GetSingle(new GetEntityByIdSpec<Resident>(residentId));

        public async Task<IEnumerable<Resident>> GetResidents(int homeId) =>
            await _repo.Get(new ResidentsByHomeSpec(homeId));

        public async Task UpdateResident(Resident resident)
        {
            await _repo.Update(resident);
            await _repo.Save();
        }

        public async Task DeleteResident(int residentId)
        {
            await _repo.Delete(residentId);
            await _repo.Save();
        }
    }
}