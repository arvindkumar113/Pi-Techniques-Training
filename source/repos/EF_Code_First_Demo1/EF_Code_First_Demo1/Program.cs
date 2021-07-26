using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(EFCF_ContextClass db = new EFCF_ContextClass())
            {
                Category category = new Category() { CategoryId = 101, CategoryName = "Electronic" };
                db.Categories.Add(category);

                db.SaveChanges();
                Product product1 = new Product()
                {
                    ProductId = 1,
                    ProductName = "Mobile",
                    Price = 5000,
                    Category = category,
                    Quantity = 5
                };
                Product product2 = new Product()
                {
                    ProductId = 1,
                    ProductName = "Mobile",
                    Price = 5000,
                    Category = category,
                    Quantity = 5
                };
                db.Products.Add(product1);
                db.Products.Add(product2);
            }
        }
    }
}
