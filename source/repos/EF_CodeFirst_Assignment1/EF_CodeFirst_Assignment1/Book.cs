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
    [Table("Book")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookID { get; set; }
        [Column("BookName", TypeName ="varchar")]
        [MaxLength(20)]
        [Required]
        public string BookName { get; set; }

        [ForeignKey("Publisher")]
        public string PublisherName { get; set; }
        public Publisher publisher { get; set; }
    }
}
