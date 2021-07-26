using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProject
{
   public class CustomerCollection
    {
        public List<Customer> customerList = new List<Customer>();

        public CustomerCollection()
        {
            customerList.Add(new Customer { CustomerName = "Arvind", City = "Patna", Country = "India" });
            customerList.Add(new Customer { CustomerName = "Kaushal", City = "Mumbai", Country = "India" });
            customerList.Add(new Customer { CustomerName = "Mithilesh", City = "Pune", Country = "India" });
            customerList.Add(new Customer { CustomerName = "Sumit", City = "Delhi", Country = "India" }); 
            customerList.Add(new Customer { CustomerName = "Kundan", City = "Chennai", Country = "India" });
            customerList.Add(new Customer { CustomerName = "Aman", City = "Patna", Country = "India" }); 
            customerList.Add(new Customer { CustomerName = "Prakash", City = "Delhi", Country = "India" });
            customerList.Add(new Customer { CustomerName = "Sonu", City = "Delhi", Country = "India" }); 
            customerList.Add(new Customer { CustomerName = "Bhavana", City = "Mumbai", Country = "India" });
            customerList.Add(new Customer { CustomerName = "Raushni", City = "Pune", Country = "India" });

        }
    }
}
