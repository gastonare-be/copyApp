using Microsoft.AspNetCore.Mvc;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    [Route("api/CustomerPrinter")]
    [ApiController]
    public class CustomerPrinterController : BaseController
    {
        private readonly ICustomerPrinterService _customerPrinterService;

        public CustomerPrinterController(ICustomerPrinterService customerPrinterService)
        {
            _customerPrinterService = customerPrinterService;
        }

        [HttpGet]
        [Route("All")]
        public IList<CustomerPrinter> GetAll()
        {
            return _customerPrinterService.GetAllCustomerPrinter();
        }
    }
}
