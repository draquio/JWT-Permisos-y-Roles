using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Permisos_y_Roles_JWT.Constants;
using Permisos_y_Roles_JWT.Models;

namespace Permisos_y_Roles_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var listCountry = CountryConstants.Countries;
            return Ok(listCountry);
        }
    }
}
