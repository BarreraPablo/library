using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Publisher
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        public UInt16? CountryId { get; set; }
        public Int16? Foundation { get; set; }

        public bool Status { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
