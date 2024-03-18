using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Email
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string? EmailAddress { get; set; }
        [Required]
        public int PersonId { get; set; }
        public Person? Person { get; set; }
    }
}
