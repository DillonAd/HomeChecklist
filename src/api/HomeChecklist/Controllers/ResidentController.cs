using HomeChecklist.Repository;
using HomeChecklist.Repository.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeChecklist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidentController : ControllerBase<Resident>
    {
        public ResidentController(IRepo<Resident> residentRepo) : base(residentRepo) { }
    }
}
