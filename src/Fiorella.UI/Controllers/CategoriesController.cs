using Fiorella.Business.Exceptions;
using Fiorella.Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiorella.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var categories=await _categoryService.GetAllAsync();
                return Ok(categories);
            }
            catch (NotFoundException ex)
            {

                return NotFound(ex.Message);
            }
        }
    }
}
