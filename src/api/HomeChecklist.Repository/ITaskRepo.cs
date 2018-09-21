using HomeChecklist.Common;
using HomeChecklist.Persistence.Entities;
using HomeChecklist.Repository.Specifications;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HomeChecklist.Repository
{
    public interface ITaskRepo : IRepo<TaskItem> { }
}