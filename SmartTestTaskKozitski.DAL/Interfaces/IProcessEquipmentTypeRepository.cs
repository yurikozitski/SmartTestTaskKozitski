using SmartTestTaskKozitski.DAL.Entities;

namespace SmartTestTaskKozitski.DAL.Interfaces
{
    public interface IProcessEquipmentTypeRepository : IRepository<ProcessEquipmentType>
    {
        Task<ProcessEquipmentType> GetByCodeAsync(long code);
    }
}
