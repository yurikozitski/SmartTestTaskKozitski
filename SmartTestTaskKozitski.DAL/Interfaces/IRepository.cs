using SmartTestTaskKozitski.DAL.Entities;

namespace SmartTestTaskKozitski.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync(int take = 100, int skip = 0);

        //Task<TEntity> GetByIdAsync(int id);

        Task AddAsync(TEntity entity);

        //void Delete(TEntity entity);

        //Task DeleteByIdAsync(int id);

        //void Update(TEntity entity);
    }
}
