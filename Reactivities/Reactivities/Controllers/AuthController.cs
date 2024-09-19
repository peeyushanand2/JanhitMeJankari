using Application;
using Domain;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;
        public AuthController()
        {
            _tokenService = new TokenService("yourSuperLongSecretKeyThatIsAtLeast32CharsLong", "MyIssuer", "MyAudience");
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserModel user)
        {
            if (user.UserName == "admin" && user.Password == "password")
            {
                user.Role = "Admin";
                var token = _tokenService.GenerateToken(user);

                return Ok(new { token });
            }
            else if (user.UserName == "user" && user.Password == "password")
            {
                user.Role = "User";
                var token = _tokenService.GenerateToken(user);
                return Ok(new { token });
            }

            return Unauthorized();
        }
    }
}
