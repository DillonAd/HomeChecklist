using HomeChecklist.Persistence;
using HomeChecklist.Persistence.Entities;
using System.Threading.Tasks;

namespace HomeChecklist.Repository
{
    public class ResidentRepo : IResidentRepo
    {
        private readonly HomeChecklistDbContext _context;

        public ResidentRepo(HomeChecklistDbContext context)
        {
            _context = context;
        }

        public async Task CreateResident(Resident resident)
        {
            await _context.Residents.AddAsync(resident);
            await _context.SaveChangesAsync();
        }
    }
}