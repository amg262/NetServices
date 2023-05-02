using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
    //public class Platform // class type - more appropriate for (Entities) and this instance but Classes are mutable
    public class Platform // this could also be a record maybe
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