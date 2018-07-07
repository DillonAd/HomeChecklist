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
    }
}