using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pratik_Code_First_Basic.Data.Dto
{
    public class MovieDto
    {
        public string Title { get; set; }
        [RegularExpression(@"^(Action|Comedy|Drama)$", ErrorMessage = "Invalid Genre")]
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
    }
}