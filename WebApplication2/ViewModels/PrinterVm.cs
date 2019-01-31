using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.ViewModels
{
    public class PrinterVm
    {
       public int Id { get; set; }
       public string serial { get; set; }
       public string mark { get; set; }
       public int model { get; set; }
       public int copiesCounter { get; set; }
    }
}
