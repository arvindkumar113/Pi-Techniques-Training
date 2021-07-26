using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace EF_CodeFirst_Assignment1
{
    public class BookDBContext:DbContext
    {
        public BookDBContext() : base("efcfconnstr")
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Review> Review { get; set; }
        
    }
}
