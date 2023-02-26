using System.ComponentModel.DataAnnotations;
namespace testartech.Models
{
    public class Local
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(60,ErrorMessage = "This field must contain between 3 and 60 characters")]
        [MinLength(3,ErrorMessage = "This field must contain between 3 and 60 characters")]
        public string? Name { get; set; }
        
        public string? Type { get; set; }
        public TimeSpan Opening { get; set; }
        public TimeSpan Closure { get; set; }
    }
}
