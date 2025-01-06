using System.ComponentModel.DataAnnotations;

namespace Pratik_Identity_and_Data_Protection.Models.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}