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
    public class ProductionFacilityRepository : IProductionFacilityRepository
    {
        private readonly ApplicationContext context;

        public ProductionFacilityRepository(ApplicationContext _context)
        {
            this.context = _context;
        }

        public Task AddAsync(ProductionFacility entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductionFacility>> GetAllAsync(int take = 100, int skip = 0)
        {
            return await this.context.ProductionFacilities
               .Skip(skip)
               .Take(take)
               .ToListAsync();
        }

        public async Task<ProductionFacility> GetByCodeAsync(long code)
        {
            return await this.context.ProductionFacilities.FirstAsync(x => x.Specifications.Code == code);
        }
    }
}
