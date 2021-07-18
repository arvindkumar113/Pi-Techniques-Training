using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignment
{
    class ConfirmEmp : Employee
    {

        #region Property
        public double basic;
        public string designation;


        #endregion

        #region Constructor
        

        //set basic only with the property
        public ConfirmEmp()
        {
            basic = 0;
            designation = null;
        }

        public ConfirmEmp(int basic, string des)
        {
            this.basic = basic;
            this.designation = des;
        }

        public ConfirmEmp(string nam, string add, double basicSal, string des)
        {
            name = nam;
            address = add;
            basic = basicSal;
            designation = des;


        }


        #endregion



        public override double CalculateSal()
        {
            double netSalary = 0;

            double hra = 0;
            double conv = 0;
            double pf = 0;

            //If Basic >= 30000

            // Hra – 30 % of basic
            //  Conv – 30 % of basic
            // PF – 10 % of basic
            if(basic>30000)
            {
                hra = 0.3 * basic;
                conv = 0.3 * basic;
                pf = 0.1 * basic;

                netSalary = basic + hra + conv - pf;
            }
            else if (basic > 20000)
            {
                hra = 0.2 * basic;
                conv = 0.2 * basic;
                pf = 0.1 * basic;

                netSalary = basic + hra + conv - pf;
            }
            else
            {
                hra = 0.1 * basic;
                conv = 0.1 * basic;
                pf = 0.1 * basic;

                netSalary = basic + hra + conv - pf;
            }


            return netSalary;
        }
    }
}
