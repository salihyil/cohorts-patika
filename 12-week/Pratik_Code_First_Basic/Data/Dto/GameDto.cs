using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pratik_Code_First_Basic.Data.Dto
{
    public class GameDto
    {
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50)]
        public string Name { get; set; }

        [RegularExpression("(?i)^(PC|PlayStation|Xbox|Nintendo Switch|Mobile)$", ErrorMessage = "Platform must be PC, PlayStation, Xbox, Nintendo Switch or Mobile"),]
        public string Platform { get; set; }

        [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10")]
        public decimal Rating { get; set; }
    }
}

 