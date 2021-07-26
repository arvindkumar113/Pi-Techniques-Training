using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Trainee : Employee
    {
        #region Properties
        int noOfDays;
        double ratePerDay;

        public int NoOfDays
        {
            get { return noOfDays; }
            set { noOfDays = value; }
        }
        public double RatePerDay
        {
            get { return ratePerDay; }
            set { ratePerDay = value; }
        }

        #endregion

        #region Constructor

        //constructor without parameter
        public Trainee()
        {
            Name = "";
            Address = "";
            NoOfDays = 0;
            RatePerDay = 0;
        }

        //constructor with four parameter
        public Trainee(string nam, string add, int days, double rate)
        {
            Name = nam;
            Address = add;
            NoOfDays = days;
            RatePerDay = rate;
        }
       
        #endregion


        #region Methods

        //method to calculation of salary
        public override double CalculateSalary()
        {
            double NetSalary;

            //logic for calculation of trainee salary
            NetSalary = NoOfDays * RatePerDay;

            return NetSalary;
        }

        //overridding tostring method
        public override string ToString()
        {
            return "\n Name : " + Name + " Address : " + Address + " No Of Days worked = "+NoOfDays+
                " Rate = "+RatePerDay+" NetSalary = "+CalculateSalary()+"\n";
        }

        #endregion
    }
}
