using System.Collections.Generic;

namespace WebApplication16.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BookContext : DbContext
    {
        public BookContext()
            : base("name=BookContext")
        {}
        public virtual DbSet<BOOKS> BOOKS { get; set; }
        public virtual DbSet<CATEGORIES> CATEGORIES { get; set; }
        public virtual DbSet<INTERTABLE> INTERTABLE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BOOKS>()
                .HasMany(e => e.INTERTABLE)
                .WithRequired(e => e.BOOKS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CATEGORIES>()
                .HasMany(e => e.INTERTABLE)
                .WithOptional(e => e.CATEGORIES)
                .HasForeignKey(e => e.CATID);
        }

        public List<BOOKS> GetBookList()
        {
            return this.BOOKS.ToList();
        }

        public void AddBook(BOOKS book)
        {
            BOOKS.Add(book);
            this.SaveChanges();
        }

        public void EditBook(BOOKS book)
        {
            var editItem = BOOKS.FirstOrDefault(i => i.BOOKID == book.BOOKID);
            if (editItem != null)
            {
                editItem.AUTHOR = book.AUTHOR;
                editItem.BOOKNAME = book.BOOKNAME;
                editItem.ISBN = book.ISBN;
                this.SaveChanges();
            }

        }

        public void DeleteBook(int id)
        {
            var deleteItem = BOOKS.FirstOrDefault(i => i.BOOKID == id);
            BOOKS.Remove(deleteItem);
            this.SaveChanges();
        }
    }
}
