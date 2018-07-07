using HomeChecklist.Common;
using HomeChecklist.Repository;
using HomeChecklist.Repository.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeChecklist
{
    public class ControllerBase<T> where T : Entity
    {
        private readonly IRepo<T> _repo;

        public ControllerBase(IRepo<T> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return null;//return _repo.Get();
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}