using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Printer : Entity<int>
    {
        public string Serial { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int CopiesCounter { get; set; }

        public static Printer MapTo(IDataReader objDataReader)
        {
            var result = new Printer();

            result.Id = int.Parse(objDataReader["PrinterId"].ToString());
            result.Serial = objDataReader["Serial"].ToString();
            result.Mark = objDataReader["Mark"].ToString();
            result.Model = objDataReader["Model"].ToString();
            result.CopiesCounter = int.Parse(objDataReader["CopiesCounter"].ToString());

            return result;
        }
    }
}
