using EF_Code_First_Demo1.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Demo1
{
    public class EFCF_ContextClass:DbContext
    {
        public EFCF_ContextClass() : base("name=efcfconnstr")
        { 

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
