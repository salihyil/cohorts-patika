using System.ComponentModel.DataAnnotations;

namespace Pratik_Cilgin_Muzisyenler.Models
{
    public class Musicians
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(20, ErrorMessage = "Name cannot be longer than 20 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Profession is required")]
        [StringLength(30, ErrorMessage = "Profession cannot be longer than 30 characters")]
        public string Profession { get; set; }
        [Required(ErrorMessage = "Fun Feature is required")]
        [StringLength(50, ErrorMessage = "Fun Feature cannot be longer than 50 characters")]
        public string FunFeature { get; set; }
    }
}