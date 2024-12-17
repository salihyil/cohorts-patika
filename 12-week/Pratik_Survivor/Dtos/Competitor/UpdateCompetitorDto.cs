using System.ComponentModel.DataAnnotations;

namespace Pratik_Survivor.Dtos.Competitor
{
    public class UpdateCompetitorDto
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public int CategoryId { get; set; }
    }
} 