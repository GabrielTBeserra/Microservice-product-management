using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PRODUCT_MANAGEMENT_SERVICE_INTERFACE.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    [Authorize]
    public class Teste : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Asd() => Ok();

    }
}