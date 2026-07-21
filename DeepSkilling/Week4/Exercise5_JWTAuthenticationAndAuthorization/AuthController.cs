using Microsoft.AspNetCore.Mvc;
using InventoryApi.Services;

namespace InventoryApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtService _jwtService;

        public AuthController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request.Username == "admin" && request.Password == "Admin@123")
            {
                var token = _jwtService.GenerateToken(request.Username, "Admin");
                return Ok(new { Token = token, Message = "Authentication Successful" });
            }
            return Unauthorized(new { Message = "Invalid username or password." });
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
