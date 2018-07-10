using HomeChecklist.Common;
using HomeChecklist.Repository;
using HomeChecklist.Repository.DTO;
using HomeChecklist.Repository.Specifications;
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
        public IEnumerable<T> Get()
        {
            return _repo.Get(new GetAllSpec<T>());
        }

        [HttpGet("{id}")]
        public T Get(int id)
        {
            return _repo.GetSingle(new GetEntityByIdSpec<T>(id));
        }

        [HttpPost]
        public void Post([FromBody] T t)
        {
            _repo.Insert(t);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] T t)
        {
            _repo.Update(t);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.Delete(new GetEntityByIdSpec<T>(id));
        }
    }
}