using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_Assignment1
{
    [Table("Member")]
    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberID { get; set; }
        [Column("MemberName", TypeName ="varchar")]
        [MaxLength(20)]
        [Required]
        public string MemberName { get; set; }

    }
}
