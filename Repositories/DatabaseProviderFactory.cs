using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DatabaseProviderFactory : IDatabaseProviderFactory
    {
        private static readonly string DefaultConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=copis;Integrated Security=True";

        public string ConnectionString { get; set; }

        public Database GetDb()
        {
            if (string.IsNullOrEmpty(DefaultConnectionString))
            {
                return new SqlDatabase(ConfigurationManager.ConnectionStrings[DefaultConnectionString].ToString());
            }

            return new SqlDatabase(DefaultConnectionString);
        }
    }

}
