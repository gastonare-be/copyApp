using Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;

namespace Repositories
{
    public class BaseMapper<T> where T : new()
    {
        public IRowMapper<T> RowMapper => CreateRowMapper();

        private IRowMapper<T> CreateRowMapper()
        {
            var aux = MapBuilder<T>.MapAllProperties();
            var entityType = typeof(T);

            foreach (var property in entityType.GetProperties())
            {
                if (property.Name.Equals("Id"))
                {
                    aux.Map(property).WithFunc(x => x.GetValue(x.GetOrdinal(($"{entityType.Name}Id"))));
                }
                if (property.GetCustomAttribute(typeof(NotMappedAttribute), false) != null)
                {
                    aux.DoNotMap(property);
                }
                else
                {
                    var type = property.PropertyType;
                    if (type.IsEnum)
                    {
                        MapEnum(aux, type, property);
                    }
                    else if (type.IsNullableEnum())
                    {
                        MapEnum(aux, type.GetNulleableType(), property);
                    }
                }

            }

            return aux.Build();
        }

        private void MapEnum(IMapBuilderContext<T> aux, Type type, PropertyInfo property)
        {
            aux.Map(property).WithFunc(
                rec => rec.IsDBNull(rec.GetOrdinal(property.Name)) ? null : Enum.ToObject(type, rec.GetInt32(rec.GetOrdinal(property.Name)))
                                     )
                      ;
        }

        public IMapBuilderContext<T> MapBuilderContext => MapBuilder<T>.MapAllProperties();

        public IEnumerable<PropertyInfo> GetMappedProperties()
        {
            return
                typeof(T).GetProperties()
                    .Where(
                        property =>
                            !property.IsDefined(typeof(NotMappedAttribute), false) &&
                            !property.IsDefined(typeof(DatabaseGeneratedAttribute), false))
                    .ToList();
        }

    }
}
