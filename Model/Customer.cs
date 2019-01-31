using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer : Entity<int>
    {
        public string Name { get; set; }
        public int Dni { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Printer> Printers { get; set; }

        public static Customer MapTo(IDataReader objDataReader)
        {
            var result = new Customer();
            
            result.Id = int.Parse(objDataReader["CustomerId"].ToString());
            result.Name = objDataReader["Name"].ToString();
            result.Dni = int.Parse(objDataReader["Dni"].ToString());
            result.BirthDate = DateTime.Parse(objDataReader["BirthDate"].ToString());
            result.Printers = new List<Printer>();

            return result;
        }

    }
}
