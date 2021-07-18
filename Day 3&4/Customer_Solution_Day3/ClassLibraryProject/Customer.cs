using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProject
{
    public class Customer
    {
        #region fields and properties

        private string customerName;
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        #endregion

        #region constructors
        public Customer()
        {
            CustomerName = "";
            City = "";
            Country = "";
        }
        public Customer(string name, string city, string country )
        {
            CustomerName = name;
            City = city;
            Country = country;
        }
        #endregion
    }
}
