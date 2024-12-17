using System.ComponentModel.DataAnnotations;

namespace Pratik_Survivor.Dtos.Category
{
    public class CreateCategoryDto
    {
        [Required]
        public string Name { get; set; }
    }
}