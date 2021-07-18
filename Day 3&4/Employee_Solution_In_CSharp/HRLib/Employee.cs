using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public abstract class Employee
    {
        #region Field and properties
        private string name;
        private string address;
        public static int EmpNo = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
               
        #endregion


        #region Constructor

        //static consstructor for empno
        static Employee()
        {
            EmpNo++;
        }
        //constructor without paramaeter
        public Employee()
        {
            Name = "";
            Address = "";
        }

        //constructor with 2 parameter
        public Employee(string nam, string add) 
        {
            Name = nam; //assigining name
            Address = add; //assigining address
        }
        #endregion


        #region Methods

        public abstract double CalculateSalary();

        public static int EmpNumber()
        {
            return EmpNo;
        }

        //overridding ToString() method
        public override string ToString()
        {
            return "\n Name : " + Name + " Address : " + Address + "\n ";
        }

        #endregion



    }
}
