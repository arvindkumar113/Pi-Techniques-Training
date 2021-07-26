using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using EmployeeLibrary;


namespace Week3Assigment
{
    public class Program
    {
        EmpDataStore empDataStore = null;
        public Program()
        {
            empDataStore = new EmpDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        }







        static void Main(string[] args)
        {
            Console.WriteLine("-----------Emp Details based on the DeptNo and Job-------");
            Program program = new Program();
            program.Display_Emp_Dept_Job();

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


            foreach (Emp item in empList)
            {
                Console.WriteLine(item);
            }



        }

    }
}
