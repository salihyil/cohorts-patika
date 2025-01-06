using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Pratik_Identity_and_Data_Protection.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Email is required")]
        public override string? Email { get; set; }
    }
}