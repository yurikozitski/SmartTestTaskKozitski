using SmartTestTaskKozitski.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.DAL.Interfaces
{
    public interface IProductionFacilityRepository : IRepository<ProductionFacility>
    {
        Task<ProductionFacility> GetByCodeAsync(long code);
    }
}
