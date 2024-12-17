using System.ComponentModel.DataAnnotations;

namespace Pratik_Survivor.Dtos.Category
{
    public class UpdateCategoryDto
    {
        [Required]
        public string Name { get; set; }
    }
}