using Model;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{

    public  class CategoryService : BaseService<Category, int>, ICategoryService

        {
      
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void AddCategory(string CategoryName)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll().ToList();    
        }
    }
}
