using AutoMapper;
using HomeChecklist.DTO;
using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeChecklist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController
    {
        private readonly IHomeRepo _repo;
        private readonly IMapper _mapper;

        public HomeController(IHomeRepo homeRepo, IMapper mapper)
        {
            _repo = homeRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<HomeDTO>> GetHomes()
        {
            var homes = await _repo.GetHomes();
            return _mapper.Map<IEnumerable<HomeDTO>>(homes);
        }

        [HttpGet("{id}")]
        public async Task<HomeDTO> GetHome(int id)
        {
            var home = await _repo.GetHome(id);
            return _mapper.Map<HomeDTO>(home);
        }

        [HttpPost]
        public async Task CreateHome([FromBody]  HomeDTO dto)
        {
            var home = _mapper.Map<Home>(dto);
            await _repo.CreateHome(home);
        }

        [HttpPut]
        public async Task UpdateHome([FromBody]  HomeDTO dto)
        {
            var home = _mapper.Map<Home>(dto);
            await _repo.UpdateHome(home);
        }

        [HttpDelete("{id}")]
        public async Task DeleteHome(int id) =>
            await _repo.DeleteHome(id);
    }
}
