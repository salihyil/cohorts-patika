using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pratik_Code_First_Relation.Entities
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Bir user'ın birden fazla post'u olabilir
        public List<PostEntity> Posts { get; set; }
    }
}