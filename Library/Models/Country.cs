using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Country
    {
        [Key]
        [Column(TypeName = "smallint")]
        public Int16? Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Publisher> Publishers { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
