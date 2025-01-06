using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pratik_Identity_and_Data_Protection.Models;
using Pratik_Identity_and_Data_Protection.Models.DTOs;
using System.Threading.Tasks;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly UserManager<User> _userManager;

        public RegisterController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = new User
            {
                UserName = model.UserName,
                Email = model.Email,
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            return result.Succeeded
                ? Ok(new { message = "User created successfully" })
                : BadRequest(result.Errors);
        }
    }
}