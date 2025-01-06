using IdentityTest;
using Microsoft.AspNetCore.Mvc;
using Pratik_Jwt.Contexts;
using Pratik_Jwt.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Pratik_Jwt.Dtos;

namespace Pratik_Jwt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(JwtDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto user)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
            if (existingUser != null)
                return BadRequest("User already exists");

            _context.Users.Add(new User { Email = user.Email, Password = user.Password });
            await _context.SaveChangesAsync();
            return Ok(new { message = "User created successfully" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email && u.Password == user.Password);
            if (existingUser == null)
                return BadRequest(new { message = "Invalid credentials" });

            var token = Helper.GenerateJwtToken(user.Email, _configuration["Jwt:Key"], _configuration["Jwt:Issuer"], _configuration["Jwt:Audience"]);

            return Ok(new { message = "Login successful", token });
        }

        [HttpGet("protected")]
        [Authorize]
        public IActionResult Protected()
        {
            return Ok(new { message = "This is a protected route" });
        }


    }
}