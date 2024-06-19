using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Permisos_y_Roles_JWT.Constants;

namespace Permisos_y_Roles_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = ("Administrador"))]
        public IActionResult Get()
        {
            var listEmployees = EmployeeConstants.Employees;
            return Ok(listEmployees);
        }
    }
}
