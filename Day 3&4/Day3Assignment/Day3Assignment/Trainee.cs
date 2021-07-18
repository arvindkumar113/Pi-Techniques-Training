using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignment
{
    public class Trainee : Employee
    {
        #region Properties
        int noDays;
        double ratePerDay;


        #endregion

        #region Constructor
        public Trainee()
        {
            noDays = 0;
            ratePerDay = 0.0;

        }

        public Trainee(int days, double rate)
        {
            noDays = days;
            ratePerDay = rate;
        }

        public Trainee(string nam, string add, int days, double rate)
        {
            name = nam;
            address = add;
            noDays = days;
            ratePerDay = rate;
        }


        #endregion


        #region Methods
        public override double CalculateSal()
        {
            double salary= noDays* ratePerDay;

            return salary;
            //throw new NotImplementedException();
        }

        #endregion
    }
}
