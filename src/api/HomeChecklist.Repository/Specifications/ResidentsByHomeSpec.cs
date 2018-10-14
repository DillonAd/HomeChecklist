using System;
using System.Linq.Expressions;
using HomeChecklist.Persistence.Entities;

namespace HomeChecklist.Repository.Specifications
{
    internal class ResidentsByHomeSpec : Specification<Resident>
    {
        private readonly int _homeId;

        public ResidentsByHomeSpec(int homeId)
        {
            _homeId = homeId;
        }

        public override Expression<Func<Resident, bool>> Expression =>
            t => t.HomeId == _homeId;
    }
}
