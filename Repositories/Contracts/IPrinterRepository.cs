using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
   public interface IPrinterRepository : IBaseRepository<Printer, int>
    {
     List<Printer> GetAll();
     void AddPrinter(string serial, string mark, int model, int copiesCounter);
     void DeletePrinter(int id);
     void UpdatePrinter(int id, string serial, string mark, int model, int copiesCounter);
    }
}
