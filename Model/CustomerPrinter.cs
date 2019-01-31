using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CustomerPrinter : Entity<int>
    {
        public int CustomerId { get; set; }
        public int PrinterId { get; set; }
        public string Name { get; set; }
        public int Dni { get; set; }
        public string Mark { get; set; }
        public int Model { get; set; }
        public string Serial { get; set; }

        public static CustomerPrinter MapTo(IDataReader objDataReader)
        {
            var result = new CustomerPrinter();

            result.Id = int.Parse(objDataReader["CustomerPrinterId"].ToString());
            result.CustomerId = int.Parse(objDataReader["CustomerId"].ToString());
            result.PrinterId = int.Parse(objDataReader["PrinterId"].ToString());
            result.Name = objDataReader["Name"].ToString();
            result.Dni = int.Parse(objDataReader["Dni"].ToString());
            result.Mark = objDataReader["Mark"].ToString();
            result.Model = int.Parse(objDataReader["Model"].ToString());
            result.Serial = objDataReader["Serial"].ToString();
            return result;
        }
    }
}
