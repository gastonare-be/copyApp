using Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerRepository : BaseRepository<Customer, int>, ICustomerRepository
    {
        protected virtual string GetAllCustomersStoredProcedureName => $"mg_{EntityName}_GetAll";

        public CustomerRepository(IDatabaseProviderFactory databaseProviderFactory) : base(databaseProviderFactory)
        {

        }
        public List<Customer> GetAll()
        {
            using (var command = Db.GetStoredProcCommand(GetAllCustomersStoredProcedureName))
            {
                return LoadCategories(command);
            }
        }

        public List<Customer> LoadCategories(DbCommand command)
        {
            var customers = new List<Customer>();

            using (var objDataReader = Db.ExecuteReader(command))
            {
                while (objDataReader.Read())
                {
                    var customer = Customer.MapTo(objDataReader);

                    customers.Add(customer);
                }

            }
            return customers;
        }
    }
}
