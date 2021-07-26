using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemoInWPF
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public string Dept { get; set; }

        public override string ToString()
        {
            return string.Format($"Emp No ={EmpNo}  Emp Name = {EmpName} Address = {Address} Salary = {Salary} DeptNo = {Dept}");
        }
    }
}
