using Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerPrinterRepository : BaseRepository<CustomerPrinter, int>, ICustomerPrinterRepository
    {
        protected virtual string GetAllCustomerPrinterStoredProcedureName => $"mg_{EntityName}_GetAll";

        public CustomerPrinterRepository(IDatabaseProviderFactory factory) : base(factory)
        {
        }

        public IList<CustomerPrinter> GetAllCustomerPrinters()
        {
            using (var command = Db.GetStoredProcCommand(GetAllCustomerPrinterStoredProcedureName))
            {
                return LoadCustomerPrinter(command);
            }
        }

        private IList<CustomerPrinter> LoadCustomerPrinter(DbCommand command)
        {
            var customerPrinters = new List<CustomerPrinter>();

            using (var objDataReader = Db.ExecuteReader(command))
            {
                while (objDataReader.Read())
                {
                    var customerPrinter = CustomerPrinter.MapTo(objDataReader);

                    customerPrinters.Add(customerPrinter);
                }

            }
            return customerPrinters;
        }
    }
}
