using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? City { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Street { get; set; }
        [Required]
        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        public string? ZipCode{ get; set; }
        [Required]
        public int PersonId { get; set; }
        public Person? Person { get; set; }
    }
}
