using Microsoft.EntityFrameworkCore;
using SmartTestTaskKozitski.DAL.Data;
using SmartTestTaskKozitski.DAL.Entities;
using SmartTestTaskKozitski.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.DAL.Repositories
{
    public class ProcessEquipmentTypeRepository : IProcessEquipmentTypeRepository
    {
        private readonly ApplicationContext context;

        public ProcessEquipmentTypeRepository(ApplicationContext _context) 
        {
            this.context = _context;
        }

        public Task AddAsync(ProcessEquipmentType entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProcessEquipmentType>> GetAllAsync(int take = 100, int skip = 0)
        {
            throw new NotImplementedException();
        }

        public async Task<ProcessEquipmentType> GetByCodeAsync(long code)
        {
            return await this.context.ProcessEquipmentTypes.FirstAsync(x => x.Specifications.Code == code);
        }
    }
}
