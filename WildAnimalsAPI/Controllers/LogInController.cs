using AutoMapper;
using MarvelPersonalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WildAnimalsAPI.Models.DTO;
using WildAnimalsAPI.Persistence;

namespace MarvelPersonalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        private readonly IConfiguration _Configuration;
        private readonly ApplicationDbContext _DbContext;
        private readonly IMapper _Mapper;

        public LogInController(
            IConfiguration Configuration,
            ApplicationDbContext Dbcontext,
            IMapper Mapper
            )
        {
            _Configuration = Configuration;
            _DbContext = Dbcontext;
            _Mapper = Mapper;
        }

        [HttpPost("SignIn")]
        public async Task<ActionResult> SingIn([FromBody] SignInUser currentUser)
        {
            if (currentUser == null)
            {
                return BadRequest("Debe agregar la informacion del usuario");
            }

            User existUser = await _DbContext.Users.FirstOrDefaultAsync(u => u.UserName == currentUser.UserName && u.PassWord == currentUser.PassWord);

            if (existUser == null)
            {
                return BadRequest("El usuario o contraseña no coinciden");
            }

            var jwt = _Configuration.GetSection("Jwt").Get<Jwt>();

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new Claim("Id", existUser.Id.ToString()),
                new Claim("UserName", existUser.UserName),
                new Claim("Rol", existUser.Rol),
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

        [HttpPost("SignUp")]
        public async Task<ActionResult> SingUp([FromBody] CreateUserDto newUser)
        {
            if (newUser == null)
            {
                return BadRequest("Debe agregar la informacion del nuevo usuario");
            }

            var existUser = await _DbContext.Users.AnyAsync(x => x.UserName == newUser.UserName);

            if (existUser)
            {
                return BadRequest("El nombre de usuario a crear ya existe");
            }

            User NewUserMapped = _Mapper.Map<User>(newUser);

            _DbContext.Users.Add(NewUserMapped);
            await _DbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("best")]
        [Authorize]
        public ActionResult<string> devuelve()
        {
            return Ok();
        }
    }
}
