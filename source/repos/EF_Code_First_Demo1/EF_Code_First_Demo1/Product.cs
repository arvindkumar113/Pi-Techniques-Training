using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Demo1
{
    [Table("Product")]
    
   public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }
        [Column("ProductName", TypeName="varchar")]
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
