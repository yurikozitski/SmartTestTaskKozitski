using System;
using System.Collections.Generic;
using SmartTestTaskKozitski.DAL.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.DAL.Interfaces
{
    public interface IContractRepository : IRepository<Contract>
    {
        Task<IEnumerable<Contract>> GetByFacilityCodeAsync(long code);
    }
}
