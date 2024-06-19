using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Permisos_y_Roles_JWT.Constants;
using Permisos_y_Roles_JWT.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Permisos_y_Roles_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IConfiguration _config;
        public AuthController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        public IActionResult Login(LoginUser login)
        {
            var user = Authenticate(login);
            if (user == null)
            {
                return NotFound("Usuario no encontrado");
            }
            var token = GenerateToken(user);
            return Ok(token);
        }
        [HttpGet]
        public IActionResult Get()
        {
            var currentUser = GetCurrentUser();
            return Ok(currentUser);
        }

        private UserModel Authenticate (LoginUser login)
        {
            var currentUser = UserConstants.Users.FirstOrDefault(
                u => u.Username.ToLower() == login.Username.ToLower() 
                && u.Password == login.Password);
            if (currentUser == null) return null;
            return currentUser;
        }

        private string GenerateToken(UserModel user)
        {
            // crear token
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            // crear claims
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Username),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.GivenName, user.Firstname),
                new Claim(ClaimTypes.Surname, user.Lastname),
                new Claim(ClaimTypes.Role, user.Rol),
            };
            var token = new JwtSecurityToken(
                    _config["Jwt:Issuer"],
                    _config["Jwt:Audience"],
                    claims,
                    expires: DateTime.Now.AddMinutes(60),
                    signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private UserModel GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity == null) return null;
            var userClaims = identity.Claims;
            var user = new UserModel()
            {
                Username = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value,
                Email = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Email)?.Value,
                Firstname = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.GivenName)?.Value,
                Lastname = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Surname)?.Value,
                Rol = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Role)?.Value
            };
            return user;
        }
    }
}
