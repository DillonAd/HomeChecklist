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
        protected readonly IRepo<TEntity> _repo;
        protected readonly IMapper _mapper;

        public ControllerBase(IRepo<TEntity> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<TDto[]> Get()
        {
            var results = await _repo.Get(new GetAllSpec<TEntity>());
            return _mapper.Map<TDto[]>(results);
        }

        [HttpGet("{id}")]
        public async Task<TDto> Get(int id)
        {
            var result = await _repo.GetSingle(new GetEntityByIdSpec<TEntity>(id));
            return _mapper.Map<TDto>(result);
        }

        [HttpPost]
        public async Task Post([FromBody] TDto t)
        {
            var input = _mapper.Map<TEntity>(t);
            await _repo.Insert(input);
            await _repo.Save();
        }

        [HttpPut]
        public async Task Put([FromBody] TDto t)
        {
            var input = _mapper.Map<TEntity>(t);
            await _repo.Update(input);
            await _repo.Save();
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _repo.Delete(new GetEntityByIdSpec<TEntity>(id));
            await _repo.Save();
        }
    }
}