using HomeChecklist.Persistence.Entities;
using System.Threading.Tasks;

namespace HomeChecklist.Repository
{
    public interface IResidentRepo
    {
        Task CreateResident(Resident resident);
    }
}