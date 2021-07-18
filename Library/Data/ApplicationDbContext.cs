using Library.Enumerations;
using Library.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<HistoryBorrowing> HistoryBorrowings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HistoryBorrowing>(entity =>
            {
                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasConversion(
                        x => x.ToString(),
                        x => (BorrowingStatus)Enum.Parse(typeof(BorrowingStatus), x)
                        );
            });
        }
    }
}
