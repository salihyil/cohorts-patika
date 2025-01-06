using System.ComponentModel.DataAnnotations;

namespace Pratik_Jwt.Dtos;

public class RegisterDto
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}