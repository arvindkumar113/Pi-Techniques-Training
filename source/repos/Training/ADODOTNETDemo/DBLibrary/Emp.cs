using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary
{
    public class Emp
    {
        public int EmpNo { get; set; }

        public string EmpName { get; set; }

        public DateTime? HireDate { get; set; }

       public decimal? Salary { get; set; }

        public override string ToString()
        {
            return string.Format($"EmpNo  : {EmpNo} Emp Name {EmpName} Salary : {Salary} HireDate : {HireDate} ");
        }
    }
}
