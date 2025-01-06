using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pratik_Identity_and_Data_Protection.Models;
using Pratik_Identity_and_Data_Protection.Models.DTOs;
using System.Threading.Tasks;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly SignInManager<User> _signInManager;

        public LoginController(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

            return result.Succeeded 
                ? Ok(new { message = "Login successful" })
                : Unauthorized(new { message = "Invalid login attempt" });
        }
    }
} 