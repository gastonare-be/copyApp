using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Model;
using Service;
using WebApplication2.Mapping;

namespace WebApplication2.Controllers
{
    [Route("api/Category")]
    [ApiController]
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;
        private readonly IObjMapper _objMapper;

        public CategoryController(ICategoryService categoryService)
            
        {
            _categoryService = categoryService;
            
        }
        [HttpGet]
        [Route("All")]
        public List<Category> GetAll()
        {
            List<Category> list = _categoryService.GetAllCategories();
            return list;
        }
    }
}