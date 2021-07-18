using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {

        #region properties

        private double basic;
        private string designation;

        public double Basic
        {
            get { return basic; }
            set 
            {
                basic = value;
                //if(basic<5000)
                //{
                //    throw new BasicSalaryException();
                //}
                //else
                //{
                //    basic = value;
                //}
            }
        }
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        #endregion

        #region Constructor

        //constructor without paramater
        public ConfirmEmployee()
        {
            Name = "";
            Address = "";
            Basic = 0;
            Designation = "";
        }

        //constructor with four parameter
        public ConfirmEmployee(string nam, string add, double salary, string desig)
        {
            Name = nam;
            Address = add;
            Basic = salary;
            Designation = desig;
        }

        #endregion



        #region methods
        public override sealed double CalculateSalary()
        {
            double NetSalary;
            double Hra;
            double Conv ;
            double PF;

            //logic for calculation of netsalary
            if (Basic > 30000)
            {
                Hra = 0.3 * basic;
                Conv = 0.3 * basic;
                PF = 0.1 * basic;

                NetSalary = Basic + Hra + Conv - PF;
            }
            else if (basic > 20000)
            {
                Hra = 0.2 * basic;
                Conv = 0.2 * basic;
                PF = 0.1 * basic;

                NetSalary = Basic + Hra + Conv - PF;
            }
            else
            {
                Hra = 0.1 * basic;
                Conv = 0.1 * basic;
                PF = 0.1 * basic;

                NetSalary = Basic + Hra + Conv - PF;
            }

            return NetSalary;
        }
        //overridding tostring method
        public override string ToString()
        {
            return "\n Name : " + Name + " Address : " + Address + " Basic Salary = " + Basic + " Designation :"
                + Designation + " NetSalary = "+CalculateSalary()+"\n";
        }


        #endregion

    }
}
