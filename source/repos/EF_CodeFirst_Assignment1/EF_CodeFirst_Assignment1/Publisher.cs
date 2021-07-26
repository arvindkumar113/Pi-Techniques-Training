using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace EF_CodeFirst_Assignment1
{
    [Table("Publisher")]
    public class Publisher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PublisherID { get; set; }
           
        [Column("PublisherName", TypeName ="varchar")]
        [MaxLength(20)]
        public string PublisherName { get; set; }
        [Column("Country", TypeName = "varchar")]
        [MaxLength(20)]
        public string Country { get; set; }
        public ICollection<Book> BookCollection { get; set; }
    }
}
