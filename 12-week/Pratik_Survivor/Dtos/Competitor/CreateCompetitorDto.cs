using System.ComponentModel.DataAnnotations;

namespace Pratik_Survivor.Dtos.Competitor
{
    public class CreateCompetitorDto
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public int CategoryId { get; set; }
    }
} 