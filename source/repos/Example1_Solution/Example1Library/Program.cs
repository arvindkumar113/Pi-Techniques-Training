using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


using Example1_Ass_Library;
using Example1_Ass;

namespace Example1Library
{
    public class Program
    {
        EmpDataStore empDataStore = null;
        public Program()
        {
            empDataStore = new EmpDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        }

        void Display_Emp_Dept_Job()
        {
            //taking input from user
            Console.WriteLine("Enter Department Number");
            int deptno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter job");
            string job = Console.ReadLine();

            //now calling Emp_Dept_Job method
            List<Emp> empList = empDataStore.Emp_Dept_Job(deptno, job);

            try
            {

                foreach (Emp item in empList)
                {
                    Console.WriteLine(item.ToString());
                }


            }
            catch (Exception)
            {
                throw;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Emp Details based on the DeptNo and Job-------");
            Program program = new Program();
            program.Display_Emp_Dept_Job();

        }
    }
}
