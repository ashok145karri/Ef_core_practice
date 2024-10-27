using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Ef_Core_Practice;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);
            modelBuilder.Entity<BookAuthorMap>().HasKey(u => new {u.Author_Id,u.BookId});

           /* modelBuilder.Entity<Book>().HasData(

                new Book { BookId = 1, Title = "SpiderMan", ISBN = "123ashok45", Price = 19.0m,Publisher_id=1 },
                new Book { BookId = 2, Title = "SuperMan", ISBN = "45kohsa", Price = 55.99m, Publisher_id = 1 }
            );
            var bookList = new Book[]
            {
                new Book { BookId = 3, Title = "Batman", ISBN = "8546lk", Price = 66.88m ,Publisher_id=2},
                new Book { BookId = 4, Title = "Flash", ISBN = "82grs6", Price = 2.99m,Publisher_id=3 },
                new Book { BookId = 5, Title = "captain", ISBN = "1234", Price = 2.09m,Publisher_id=3 }


            };
            modelBuilder.Entity<Book>().HasData(bookList);

            modelBuilder.Entity<Publisher>().HasData(

                new Publisher {  Publisher_Id = 1,Name="onetomany",Location="chicago" },
                new Publisher {  Publisher_Id = 2,Name="onetomanysample",Location="france" },
                new Publisher {  Publisher_Id = 3,Name="onetomanyexample",Location="china" }
                );*/
        }
    }


}
