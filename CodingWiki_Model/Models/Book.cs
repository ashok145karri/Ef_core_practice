using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class Book
    {
        [Key]
        //Id
        public int BookId { get; set; }
        public string Title { get; set; }
        [MaxLength(20)]
        [Required]
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        [NotMapped]
        public string PriceRange { get; set; }

        //if you assign foreign key it will became child table and bookDetail will be parent table 
        /*[ForeignKey("BookDetail2")]
        public int BookDetail_Id {  get; set; }*/

        public BookDetail BookDetail2 { get; set; }

        [ForeignKey("Publisher")]
        public int Publisher_id { get; set; }

        public Publisher Publisher { get; set; }
        //many to many relationship
        public List<BookAuthorMap> BookAuthorMap { get; set; }

    }
}
