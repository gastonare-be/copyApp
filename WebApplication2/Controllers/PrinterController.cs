using Microsoft.AspNetCore.Mvc;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    [Route("api/Printer")]
    [ApiController]
    public class PrinterController : BaseController
    {
        private readonly IPrinterService _printerService;

        public PrinterController(IPrinterService printerService)
        {
            _printerService = printerService;
        }

        [HttpGet]
        [Route("All")]
        public List<Printer> GetAll()
        {
          return _printerService.GetAllPrinters();
        }

        [HttpPost]
        [Route("")]
        public void Create(PrinterVm printerVm)
        {
          _printerService.AddPrinter(printerVm.serial, printerVm.mark, printerVm.model, printerVm.copiesCounter);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _printerService.DeletePrinter(id);
        }

        [HttpPost]
        [Route("Update")]
        public void Update(PrinterVm printerVm)
        {
            _printerService.UpdatePrinter(printerVm.Id, printerVm.serial, printerVm.mark, printerVm.model, printerVm.copiesCounter);
        }
    }
}
