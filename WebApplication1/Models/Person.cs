using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string? FirstName { get; set; }
        [Required]
        [MaxLength(25)]
        public string? LastName { get; set; }
        public List<Email>? Emails { get; set; } = new List<Email>();
        public List<Address>? Addresses { get; set; } = new List<Address>();

    }
}
