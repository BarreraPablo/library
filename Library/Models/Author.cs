using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Author
    {
        [Key]
        public long Id { get; set; } 

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [Required]
        [MaxLength(25)]
        public string Surname { get; set; }

        [Required]
        public bool Active { get; set; }
        public UInt16? CountryId { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
