﻿using HomeChecklist.Repository;
using HomeChecklist.Repository.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeChecklist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IRepo<Home> _homeRepo;

        public HomeController(IRepo<Home> homeRepo)
        {
            _homeRepo = homeRepo;
        }

        // GET api/home
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/home/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/home
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/home/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/home/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
