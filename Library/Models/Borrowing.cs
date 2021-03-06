using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Borrowing
    { 
        [Key]
        public long? Id { get; set; }

        [Required]
        public DateTime From { get; set; }

        [Required]
        public DateTime To { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public Client Client { get; set; }
        [Required]
        public long ClientId { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }

        public Book Book { get; set; }

        [Required]
        public long BookId { get; set; }

        public IEnumerable<HistoryBorrowing> HistoryBorrowings { get; set; }
    }
}
