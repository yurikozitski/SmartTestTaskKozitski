using SmartTestTaskKozitski.BLL.DTOs;

namespace SmartTestTaskKozitski.BLL.Interfaces
{
    public interface IContractService
    {
        Task<IEnumerable<GetContractsDto>> GetAllAsync(int take = 100, int skip = 0);

        Task AddAsync(AddContractDto contractDto);
    }
}
