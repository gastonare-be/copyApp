using Model;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PrinterService : BaseService<Printer, int>, IPrinterService

    {
        private readonly IPrinterRepository _printerRepository;
        public PrinterService(IPrinterRepository printerRepository) : base(printerRepository)
        {
            _printerRepository = printerRepository;
        }

        public void AddPrinter(string serial, string mark, int model, int copiesCounter)
        {
            _printerRepository.AddPrinter(serial, mark, model, copiesCounter);
        }

        public void DeletePrinter(int id)
        {
            _printerRepository.DeletePrinter(id);
        }

        public  List<Printer> GetAllPrinters()
        {
           return _printerRepository.GetAll();
        }

        public void UpdatePrinter(int id, string serial, string mark, int model, int copiesCounter)
        {
            _printerRepository.UpdatePrinter(id, serial, mark, model, copiesCounter);
        }
    }
}
