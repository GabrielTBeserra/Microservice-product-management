using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRODUCT_MANAGEMENT_SERVICE_CROSSCUTING.DTO.Product;
using PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Product.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace PRODUCT_MANAGEMENT_SERVICE_INTERFACE.Controllers.Product
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [AllowAnonymous]
    public class ProductController : ControllerBase
    {
        private readonly IProductApplicationService _appService;

        public ProductController(IProductApplicationService appService)
        {
            _appService = appService;
        }

        [SwaggerResponse(statusCode: 200, description: "Registred", Type = typeof(string))]
        [SwaggerResponse(statusCode: 400, description: "Internal Server Error", Type = typeof(string))]
        [SwaggerResponse(statusCode: 409, description: "Conflict", Type = typeof(string))]
        [Produces("application/json")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductCreateDTO dto)
        {
            await _appService.Create(dto);
            return Ok();
        }

    }
}
