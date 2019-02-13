using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IPrinterService : IBaseService<Printer, int>
    {
        List<Printer> GetAllPrinters();
        void AddPrinter(string serial, string mark, int model, int copiesCounter);
        void DeletePrinter(int id);
        void UpdatePrinter(int id, string serial, string mark, int model, int copiesCounter);
    }
}
