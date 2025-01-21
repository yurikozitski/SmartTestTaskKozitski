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
    public class ContractRepository : IContractRepository
    {
        private readonly ApplicationContext context;

        public ContractRepository(ApplicationContext _context)
        {
            this.context = _context;
        }

        public async Task AddAsync(Contract entity)
        {
            var facility = await this.context.ProductionFacilities
                .FirstAsync(x => x.Specifications.Code == entity.ProductionFacility.Specifications.Code);

            var equipment = await this.context.ProcessEquipmentTypes
                .FirstAsync(x => x.Specifications.Code == entity.ProcessEquipmentType.Specifications.Code);

            entity.ProductionFacility = facility;
            entity.ProcessEquipmentType = equipment;

            await this.context.Contracts.AddAsync(entity);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Contract>> GetAllAsync(int take = 100, int skip = 0)
        {
            return await this.context.Contracts
                .Include(c => c.ProductionFacility)
                .Include(c => c.ProcessEquipmentType)
                .Skip(skip)
                .Take(take)
                .ToListAsync();
        }

        public async Task<IEnumerable<Contract>> GetByFacilityCodeAsync(long code)
        {
            return await this.context.Contracts
                .Include(c => c.ProcessEquipmentType)
                .Where(c => c.ProductionFacility.Specifications.Code == code)
                .ToListAsync();
        }
    }
}
