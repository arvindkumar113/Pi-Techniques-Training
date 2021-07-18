using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignment
{
    public abstract class Employee
    {
        public string name;
        public string address;
        public static int empNo=0;


        static Employee()
        {
            empNo++;
        }
        public Employee()
        {
            name = "";
            address = "";
        }



        public Employee(string name, string address)
        {
            this.name = name;
            this.address = address;
            empNo++;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        #region Method
        public abstract double CalculateSal();

        public static int EmpNumber()
        {
            return empNo;
        }
        
        #endregion


    }
}
