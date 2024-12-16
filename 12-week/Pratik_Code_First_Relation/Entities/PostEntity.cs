using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pratik_Code_First_Relation.Entities
{
    public class PostEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Başlık alanı zorunludur")]
        [MinLength(3, ErrorMessage = "Başlık en az 3 karakter olmalıdır")]
        [MaxLength(100, ErrorMessage = "Başlık en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "İçerik alanı zorunludur")]
        [MinLength(10, ErrorMessage = "İçerik en az 10 karakter olmalıdır")]
        public string Content { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        // Her bir post sadece bir kullanıcıya ait olabilir
        public UserEntity User { get; set; }
    }
}