using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public interface ICategoryService : IBaseService <Category,int>
    {
        void AddCategory(String CategoryName);
        List<Category> GetAllCategories();
    }
}
