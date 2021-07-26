using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_Assignment1
{
    [Table("Review")]
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReviewID { get; set; }


        [ForeignKey("Book")]
        public int BookID { get; set; }
        public Book Book { get; set; }


        [ForeignKey("Member")]
        public int MemberID { get; set; }
        [Column("ReviewText", TypeName ="varchar")]
        [MaxLength(50)]
        public Member Member { get; set; }


        public string ReviewText { get; set; }
       
       
    }
}
