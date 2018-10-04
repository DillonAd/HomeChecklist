using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository.Specifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeChecklist.Repository
{
    public class HomeRepo : IHomeRepo
    {
        private readonly IRepo<Home> _repo;

        public HomeRepo(IRepo<Home> repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Home>> GetHomes() =>
            await _repo.Get(new GetAllSpec<Home>());

        public async Task<Home> GetHome(int id) =>
            await _repo.GetSingle(new GetEntityByIdSpec<Home>(id));

        public async Task CreateHome(Home home)
        {
            await _repo.Insert(home);
            await _repo.Save();
        }

        public async Task UpdateHome(Home home)
        {
            await _repo.Update(home);
            await _repo.Save();
        }

        public async Task DeleteHome(int id)
        {
            await _repo.Delete(new GetEntityByIdSpec<Home>(id));
            await _repo.Save();
        }
    }
}