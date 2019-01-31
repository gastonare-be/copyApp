using Common;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public abstract class BaseService<TEntity, TId> : IBaseService<TEntity, TId> where TEntity : Entity<TId>, new()
    {
        protected readonly IBaseRepository<TEntity, TId> _repository;
      
        public BaseService(IBaseRepository<TEntity, TId> repository)
        {
            _repository = repository;
        }

        public TEntity GetById(TId id)
        {
            return _repository.GetById(id);
        }

        public Task<TEntity> GetByIdAsync(TId id)
        {
            return _repository.GetByIdAsync(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

    }
}
