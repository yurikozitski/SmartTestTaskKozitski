using SmartTestTaskKozitski.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.DAL.Interfaces
{
    public interface IProcessEquipmentTypeRepository : IRepository<ProcessEquipmentType>
    {
        Task<ProcessEquipmentType> GetByCodeAsync(long code);
    }
}
