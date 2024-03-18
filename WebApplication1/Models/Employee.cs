using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [MaxLength(50)]
        public string Position { get; set; }
        [Required]
        public int CompanyId { get; set; }
    }
}
