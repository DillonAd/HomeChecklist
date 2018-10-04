using AutoMapper;
using HomeChecklist.DTO;
using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository;
using Microsoft.AspNetCore.Mvc;

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
    }
}
