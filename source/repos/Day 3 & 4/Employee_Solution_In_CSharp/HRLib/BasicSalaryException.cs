using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class BasicSalaryException:Exception
    {
        //public BasicSalaryException() { }

        public BasicSalaryException() : base(String.Format("Basic Salary can't be less than 5000"))
        {

        }
    }
}
