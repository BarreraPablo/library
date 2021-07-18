using Library.Enumerations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class HistoryBorrowing
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public BorrowingStatus Status { get; set; }

        [Required]
        public DateTime From { get; set; }
        public DateTime? To { get; set; }

        [Required]
        public long BorrowingId { get; set; }
        public Borrowing Borrowing { get; set; }

    }
}
