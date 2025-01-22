using SmartTestTaskKozitski.DAL.Entities;

namespace SmartTestTaskKozitski.DAL.Interfaces
{
    public interface IContractRepository : IRepository<Contract>
    {
        Task<IEnumerable<Contract>> GetByFacilityCodeAsync(long code);
    }
}
