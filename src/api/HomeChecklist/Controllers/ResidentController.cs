﻿using AutoMapper;
using HomeChecklist.DTO;
using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HomeChecklist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidentController
    {
        private readonly IResidentRepo _repo;
        private readonly IMapper _mapper;

        public ResidentController(IResidentRepo residentRepo, IMapper mapper)
        {
            _repo = residentRepo;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task CreateResident(ResidentDTO dto)
        {
            var resident = _mapper.Map<Resident>(dto);
            await _repo.CreateResident(resident);
        }

        [HttpGet]
        public async Task<ResidentDTO[]> GetResidents(int homeId)
        {
            var residents = await _repo.GetResidents(homeId);
            return _mapper.Map<ResidentDTO[]>(residents);
        }

        [HttpGet("{residentId}")]
        public async Task<ResidentDTO> GetResident(int residentId)
        {
            var resident = await _repo.GetResident(residentId);
            return _mapper.Map<ResidentDTO>(resident);
        }

        [HttpPut]
        public async Task UpdateResident(ResidentDTO dto)
        {
            var resident = _mapper.Map<Resident>(dto);
            await _repo.UpdateResident(resident);
        }

        [HttpDelete]
        public async Task DeleteResident(int residentId) =>
            await _repo.DeleteResident(residentId);
    }
}
