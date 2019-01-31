using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Category : Entity<int>
    {
        public string CategoryName { get; set; }

        public static Category MapTo(IDataReader objDataReader)
        {
            var result = new Category();

            result.Id = int.Parse(objDataReader["CategoryId"].ToString());
            result.CategoryName = objDataReader["CategoryName"].ToString();
            
            return result;
        }
    }
}
