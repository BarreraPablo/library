using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public long? Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public Publisher Publisher { get; set; }

        public Language Language { get; set; }
        public Country Country { get; set; }
        public long? AuthorId { get; set; }
        public UInt16? GenreId { get; set; }
        public long? PublisherId { get; set; }

        [Required]
        public long LanguageId { get; set; }
        public UInt16? CountryId { get; set; }
    }
}
