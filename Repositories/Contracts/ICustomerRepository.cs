using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
  public  interface ICustomerRepository : IBaseRepository<Customer, int>
    {
        List<Customer> GetAll();
    }
}
