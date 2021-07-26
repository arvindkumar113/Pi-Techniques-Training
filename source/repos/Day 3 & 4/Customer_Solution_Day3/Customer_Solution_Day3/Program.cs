using ClassLibraryProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Solution_Day3
{
    public class Program
    {

        static void GetCustomerByCityAndCountry()
        {
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter Country");
            string country = Console.ReadLine();

            CustomerCollection collectionObj = new CustomerCollection();
            Customer customer = collectionObj.customerList.Find(c => (c.City == city) && (c.Country == country)) ;
            if(customer == null)
            {
                Console.WriteLine("\nNo match found\n");
            }
            else
            {
                Console.WriteLine("Details : " + customer.CustomerName + "  " + customer.City + "  " + customer.Country + "  \n");
            }

        }
        static void GetCustomerDetailByName()
        {
            Console.WriteLine("Enter customer name");
            string name = Console.ReadLine();
            CustomerCollection obj = new CustomerCollection();

            Customer customer = obj.customerList.Find(customername => customername.CustomerName == name);
            if(customer==null)
            {
                Console.WriteLine("There is no customer with name {0}", name);
            }
            else
            {
                Console.WriteLine("Details : " + customer.CustomerName + "  " + customer.City + "  " + customer.Country + "  \n");
            }

        }
        
        static void DisplayAllCustomers()
        {
            CustomerCollection obj = new CustomerCollection();
            foreach (var item in obj.customerList)
            {
                Console.WriteLine(item.CustomerName + "  " + item.City + "  " + item.Country + "  \n");
            }
        }
        static void Main(string[] args)
        {
            int runTillZero = 1;
            while(runTillZero!=0)
            {
                Console.WriteLine(" 1 to Display all customer \n 2 to Get customer detail by name\n 3 for get customer" +
                    "detail by city and name \n 0 to exit");
                runTillZero = int.Parse(Console.ReadLine());
                switch (runTillZero)
                {
                    case 1:
                        {
                            DisplayAllCustomers();
                            break;
                        }
                    case 2:
                        {
                            GetCustomerDetailByName();
                            break;
                        }
                    case 3:
                        {
                            GetCustomerByCityAndCountry();
                            break;
                        }
                    default:
                        break;
                }
            }           
        }
    }
}
