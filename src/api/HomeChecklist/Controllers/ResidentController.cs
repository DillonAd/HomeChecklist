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

        public async Task CreateResident(ResidentDTO dto)
        {
            var resident = _mapper.Map<Resident>(dto);
            await _repo.CreateResident(resident);
        }
    }
}
