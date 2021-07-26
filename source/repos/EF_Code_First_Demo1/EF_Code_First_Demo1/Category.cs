using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Demo1
{
    [Table ("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }
        [Column("CategoryName", TypeName ="varchar")]
        [MaxLength(20)]
        public string CategoryName { get; set; }
        public List<Product> productList { get; set; }
    }
}
