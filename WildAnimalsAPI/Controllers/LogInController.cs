using MarvelPersonalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MarvelPersonalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        public IConfiguration _configuration;

        public LogInController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public ActionResult<string> SingIn([FromBody] Object optData)
        {
            var data =  JsonConvert.DeserializeObject<dynamic>(optData.ToString());

            var userName = data.UserName.ToString();
            var passWord = data.PassWord.ToString();

            //intermedio aca es donde debe ir a la base de datos y validar, si retorna data o no, valida en el if de abajo

            if (userName == null)
            {
                return NoContent();
            }

            var jwt = _configuration.GetSection("Jwt").Get<Jwt>();

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new Claim("Id", "miIdUser"), //recordar agregar el id dinamico
                new Claim("UserName", "miUserName"), //recordar agregar el UserName dinamico
                new Claim("Rol", "standar"), //recordar poner el rol dinamico
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                jwt.Issuer,
                jwt.Audience,
                claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: signIn
                );

            var bearerToken = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(bearerToken);
        }

        [HttpGet("best")]
        [Authorize]
        public ActionResult<string> devuelve()
        {
            return Ok("aca hay buena información ---");
        }
    }
}
