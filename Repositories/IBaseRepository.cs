using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBaseRepository<TEntity, TId> where TEntity : Entity<TId>, new()
    {
        TEntity GetById(TId id);

        void Create(TEntity entity);

        void DeleteById(TId id);

        Task<TEntity> GetByIdAsync(TId id);

        IEnumerable<TEntity> GetAll();

        Task<IEnumerable<TEntity>> GetAllAsync();

    }
}
