using Model;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CustomerPrinterService : BaseService<CustomerPrinter, int>, ICustomerPrinterService
    {
        private readonly ICustomerPrinterRepository _customerPrinterRepository;

        public CustomerPrinterService(ICustomerPrinterRepository customerPrinterRepository) : base(customerPrinterRepository)
        {
            _customerPrinterRepository = customerPrinterRepository;
        }

        public IList<CustomerPrinter> GetAllCustomerPrinter()
        {
          return _customerPrinterRepository.GetAllCustomerPrinters();
        }
    }
}
