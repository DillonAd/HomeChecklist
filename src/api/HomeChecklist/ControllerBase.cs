using AutoMapper;
using HomeChecklist.Common;
using HomeChecklist.Repository;
using HomeChecklist.Repository.Specifications;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeChecklist
{
    public class ControllerBase<TEntity, TDto> 
        where TEntity : Entity
        where TDto : class
    {
        private readonly IRepo<TEntity> _repo;
        private readonly IMapper _mapper;

        public ControllerBase(IRepo<TEntity> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<TDto> Get()
        {
            var results = _repo.Get(new GetAllSpec<TEntity>());
            return _mapper.Map<IEnumerable<TDto>>(results);
        }

        [HttpGet("{id}")]
        public TDto Get(int id)
        {
            var result = _repo.GetSingle(new GetEntityByIdSpec<TEntity>(id));
            return _mapper.Map<TDto>(result);
        }

        [HttpPost]
        public void Post([FromBody] TDto t)
        {
            var input = _mapper.Map<TEntity>(t);
            _repo.Insert(input);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TDto t)
        {
            var input = _mapper.Map<TEntity>(t);
            _repo.Update(input);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.Delete(new GetEntityByIdSpec<TEntity>(id));
        }
    }
}