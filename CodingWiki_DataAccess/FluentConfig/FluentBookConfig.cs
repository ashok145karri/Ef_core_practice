using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.FluentConfig
{
    public class FluentBooKConfig:IEntityTypeConfiguration<Fluent_Book>
    {
        public void Configure(EntityTypeBuilder<Fluent_Book> modelBuilder)
        {
            modelBuilder.ToTable("Fluent_Books");
            modelBuilder.Property(u => u.ISBN).HasMaxLength(50);
            modelBuilder.Property(u => u.ISBN).IsRequired();
            modelBuilder.HasKey(u => u.BookId);
            modelBuilder.Ignore(u => u.PriceRange);
            modelBuilder.Property(u => u.Price).HasPrecision(10, 5);
            modelBuilder.HasOne(u => u.Publisher).WithMany(u => u.Books)
                .HasForeignKey(u => u.Publisher_id);

        }
    }
}
