using SmartTestTaskKozitski.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.BLL.Interfaces
{
    public interface IContractService
    {
        Task<IEnumerable<GetContractsDto>> GetAllAsync(int take = 100, int skip = 0);

        Task AddAsync(AddContractDto contractDto);
    }
}
