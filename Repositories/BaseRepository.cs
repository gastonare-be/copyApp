using Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace Repositories
{
    public abstract class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId> where TEntity : Entity<TId>, new()
    {

        protected Database Db { get; private set; }
        protected virtual BaseMapper<TEntity> Mapper => new BaseMapper<TEntity>();
        protected virtual string EntityName => typeof(TEntity).Name;
        protected virtual string GetByIdStoredProcedureName => $"mg_{EntityName}_GetById";
        protected virtual string CreateStoredProcedureName => $"mg_{EntityName}_Create";
        protected virtual string UpdateStoredProcedureName => $"mg_{EntityName}_Update";
        protected virtual string DeleteByIdStoredProcedureName => $"mg_{EntityName}_DeleteById";
        protected virtual string GetAllStoredProcedureName => $"mg_{EntityName}_GetAll";


        protected static readonly Dictionary<Type, DbType> TypeMap = new Dictionary<Type, DbType>
            {
                { typeof(bool), DbType.Boolean},
                { typeof(bool?), DbType.Boolean},
                { typeof(byte), DbType.Byte},
                { typeof(byte[]), DbType.Binary},
                { typeof(DateTime), DbType.DateTime},
                { typeof(decimal), DbType.Decimal},
                { typeof(decimal?), DbType.Decimal},
                { typeof(double), DbType.Double},
                { typeof(Guid), DbType.Guid},
                { typeof(short), DbType.Int16},
                { typeof(int), DbType.Int32},
                { typeof(int?), DbType.Int32},
                { typeof(long), DbType.Int64},
                { typeof(object), DbType.Object },
                { typeof(string), DbType.String},
                { typeof(DateTimeOffset), DbType.DateTimeOffset},
                { typeof(float), DbType.Double},
                { typeof(DateTime?), DbType.DateTime},
                { typeof(Enum), DbType.Int32},
                { typeof(char), DbType.String}
            };

        public BaseRepository(IDatabaseProviderFactory factory)
        {
            
            Db = factory.GetDb();
        }

        public virtual void Create(TEntity entity)
        {
            var command = Db.GetStoredProcCommand(CreateStoredProcedureName);
            foreach (var prop in Mapper.GetMappedProperties())
            {
                if ((prop.PropertyType.IsEnum) || (prop.PropertyType.IsNullableEnum()))
                {
                    Db.AddInParameter(command, "@" + prop.Name, DbType.Int32, prop.GetValue(entity));
                }
                else
                {
                    Db.AddInParameter(command, "@" + prop.Name, TypeMap[prop.PropertyType], prop.GetValue(entity));
                }
            }

            Db.ExecuteScalar(command);
        }

        public virtual Task CreateAsync(TEntity entity)
        {
            var command = Db.GetStoredProcCommand(CreateStoredProcedureName);
            foreach (var prop in Mapper.GetMappedProperties())
            {
                if ((prop.PropertyType.IsEnum) || (prop.PropertyType.IsNullableEnum()))
                {
                    Db.AddInParameter(command, "@" + prop.Name, DbType.Int32, prop.GetValue(entity));
                }
                else
                {
                    Db.AddInParameter(command, "@" + prop.Name, TypeMap[prop.PropertyType], prop.GetValue(entity));
                }
            }

            // Db.ExecuteScalar(command);
            return Task.Factory.FromAsync(Db.BeginExecuteScalar, Db.EndExecuteScalar, command, null);
        }

        public virtual TEntity GetById(TId id)
        {
            return Db.ExecuteSprocAccessor(GetByIdStoredProcedureName, Mapper.RowMapper, id).FirstOrDefault();
        }
        public virtual void DeleteById(TId id)
        {
            Db.ExecuteSprocAccessor(DeleteByIdStoredProcedureName, Mapper.RowMapper, id);
        }

        protected virtual void ExecuteNonQuery(string storedProceduresName, params object[] parameterValues)
        {
            Db.ExecuteNonQuery(storedProceduresName, parameterValues);
        }

        public virtual Task<TEntity> GetByIdAsync(TId id)
        {
            var accessor = Db.CreateSprocAccessor(GetByIdStoredProcedureName, Mapper.RowMapper);
            IAsyncResult async = accessor.BeginExecute(a => { }, accessor, id);

            return Task<TEntity>.Factory.FromAsync(async, EndGetById);
        }


        protected TEntity EndGetById(IAsyncResult async)
        {
            var accessor = async.AsyncState as DataAccessor<TEntity>;
            return accessor.EndExecute(async).ToList().FirstOrDefault();
        }


        protected virtual Task<IEnumerable<TEntity>> GetAsync(string storedProcedureName, params object[] parameterValues)
        {
            var accessor = Db.CreateSprocAccessor(storedProcedureName, Mapper.RowMapper);
            IAsyncResult async = accessor.BeginExecute(a => { }, accessor, parameterValues);

            return Task<IEnumerable<TEntity>>.Factory.FromAsync(async, EndGet);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return Db.ExecuteSprocAccessor(GetAllStoredProcedureName, Mapper.RowMapper).ToList();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {

            var data = await GetAsync(GetAllStoredProcedureName);
            return data.ToList();
        }

        protected IEnumerable<TEntity> EndGet(IAsyncResult async)
        {
            var accessor = async.AsyncState as DataAccessor<TEntity>;
            return accessor.EndExecute(async).ToList();
        }

        protected virtual TEntity GetFirstOrDefault(string storedProcedureName, params object[] parameterValues)
        {
            return Db.ExecuteSprocAccessor(storedProcedureName, Mapper.RowMapper, parameterValues).FirstOrDefault();
        }

        protected virtual Task<TEntity> GetFirstOrDefaultAsync(string storedProcedureName, params object[] parameterValues)
        {
            var accessor = Db.CreateSprocAccessor(storedProcedureName, Mapper.RowMapper);
            IAsyncResult async = accessor.BeginExecute(a => { }, accessor, parameterValues);

            return Task<TEntity>.Factory.FromAsync(async, EndGetFirstOrDefault);
        }

        protected TEntity EndGetFirstOrDefault(IAsyncResult async)
        {
            var accessor = async.AsyncState as DataAccessor<TEntity>;
            return accessor.EndExecute(async).ToList().FirstOrDefault();
        }

    }
}
