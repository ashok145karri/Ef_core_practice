using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class Fluent_Book
    {
        //[Key]
        //Id
        public int BookId { get; set; }
        public string Title { get; set; }
        //[MaxLength(20)]
        //[Required]
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        //[NotMapped]
        public string PriceRange { get; set; }

        //if you assign foreign key it will became child table and bookDetail will be parent table 
        //[ForeignKey("BookDetail2")]
        //public int BookDetail_Id {  get; set; }

        public Fluent_BookDetail BookDetail2 { get; set; }

        public int Publisher_id { get; set; }

        public Fluent_Publisher Publisher { get; set; }
        //many to many relationship
        //public List<Fluent_BookAuthorMap> BookAuthorMap { get; set; }--line-35
        public List<Fluent_BookAuthorMap> BookAuthorMap { get; set; }
       // public List<Fluent_Author> Authors { get; set; }--for skipping the table by commenting above line
    }
}
