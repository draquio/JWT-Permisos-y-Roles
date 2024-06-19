using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Permisos_y_Roles_JWT.Constants;

namespace Permisos_y_Roles_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            var listProduct = ProductConstants.Products;
            return Ok(listProduct);
        }
    }
}
