using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pratik_Code_First_Relation.Dtos.UserDto
{
    public class UserCreateDto
    {
        [Required(ErrorMessage = "Kullanıcı adı zorunludur")]
        [MinLength(3, ErrorMessage = "Kullanıcı adı en az 3 karakter olmalıdır")]
        [MaxLength(50, ErrorMessage = "Kullanıcı adı en fazla 50 karakter olabilir")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email adresi zorunludur")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz")]
        public string Email { get; set; }
    }
}