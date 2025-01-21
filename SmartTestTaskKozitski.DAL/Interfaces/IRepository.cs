using SmartTestTaskKozitski.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync(int take = 100, int skip = 0);

        //Task<TEntity> GetByIdAsync(int id);

        Task AddAsync(TEntity entity);

        //void Delete(TEntity entity);

        //Task DeleteByIdAsync(int id);

        //void Update(TEntity entity);
    }
}
