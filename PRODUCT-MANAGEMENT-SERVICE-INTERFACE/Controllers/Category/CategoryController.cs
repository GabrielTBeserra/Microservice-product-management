using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRODUCT_MANAGEMENT_SERVICE_CROSSCUTING.DTO.Category;
using PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Category.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PRODUCT_MANAGEMENT_SERVICE_INTERFACE.Controllers.Category
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [AllowAnonymous]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryApplicationService _appService;

        public CategoryController(ICategoryApplicationService appService)
        {
            _appService = appService;
        }

        [SwaggerResponse(statusCode: 200, description: "Registred", Type = typeof(string))]
        [SwaggerResponse(statusCode: 400, description: "Internal Server Error", Type = typeof(string))]
        [SwaggerResponse(statusCode: 409, description: "Conflict", Type = typeof(string))]
        [Produces("application/json")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryPostDTO dto)
        {
            await _appService.Create(dto);
            return Ok();
        }

        [SwaggerResponse(statusCode: 200, description: "Registred", Type = typeof(IEnumerable<ListCategoriesDTO>))]
        [SwaggerResponse(statusCode: 400, description: "Internal Server Error", Type = typeof(string))]
        [SwaggerResponse(statusCode: 409, description: "Conflict", Type = typeof(string))]
        [Produces("application/json")]
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll() => Ok(await _appService.GetAll());
    }
}
