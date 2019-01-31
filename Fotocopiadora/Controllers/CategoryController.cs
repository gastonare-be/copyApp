using Fotocopiadora.Mapping;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Fotocopiadora.Controllers
{
    [Authorize]
    [RoutePrefix("api/")]

    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;
        private readonly IObjMapper _objMapper;

        public CategoryController(ICategoryService categoryService, IObjMapper objMapper)
        {
            _categoryService = categoryService;
            _objMapper = objMapper;
        }
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetAll()
        {
           _shoutoutRecipientService.UpdateResponse(shoutoutRecipientVm.ShoutoutId, shoutoutRecipientVm.ResponseText);
        }
    }
}