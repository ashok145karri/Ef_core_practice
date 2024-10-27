using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Model.Models
{
    public class Fluent_Publisher
    {
        //[Key]
        public int Publisher_Id { get; set; }
        //[Required]
        public string Name { get; set; }
        public string Location { get; set; }
        //what if publisher want to get all the books published by publisher it work as a navigator property
        public List<Fluent_Book> Books { get; set; }
    }
}
