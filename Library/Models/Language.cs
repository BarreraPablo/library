using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Language
    {
        [Key]
        public long? Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
