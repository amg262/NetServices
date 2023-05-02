using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
    public class Platform
    {
        [Key] // This is the primary key for the table
        [Required] // This is a required field
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Publisher { get; set; }
        
        [Required]
        public string Cost { get; set; }
    }
}