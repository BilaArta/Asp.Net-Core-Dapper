using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
        [Required]
        [MaxLength(50)]
        public string Country { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
