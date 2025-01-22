using SmartTestTaskKozitski.DAL.Entities;

namespace SmartTestTaskKozitski.DAL.Interfaces
{
    public interface IProductionFacilityRepository : IRepository<ProductionFacility>
    {
        Task<ProductionFacility> GetByCodeAsync(long code);
    }
}
