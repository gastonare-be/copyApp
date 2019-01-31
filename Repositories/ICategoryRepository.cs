using Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
  public  interface ICategoryRepository : IBaseRepository<Category, int>
    {
      void AddCategory(String CategoryName);
      List<Category> GetAllCategories();
       
    }
}
