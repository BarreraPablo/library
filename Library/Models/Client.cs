using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Client
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [Required]
        [MaxLength(25)]
        public string Surname { get; set; }
        
        public IEnumerable<Borrowing> Borrowings { get; set; }
    }
}
