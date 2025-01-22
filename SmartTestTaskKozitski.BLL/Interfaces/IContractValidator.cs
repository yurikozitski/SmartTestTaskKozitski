using SmartTestTaskKozitski.DAL.Entities;

namespace SmartTestTaskKozitski.BLL.Interfaces
{
    public interface IContractValidator
    {
        Task<bool> IsValid(Contract contract);
    }
}
