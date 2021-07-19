using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class EMP_CRUD_DEMO
    {
        EmpDataStore empDataStore=null;

        public EMP_CRUD_DEMO()
        {
            empDataStore = new EmpDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }


        //Display all employe
        public void DisplayAll()
        {
            try
            {
                List<Emp> empList = empDataStore.GetAllEmployeeDetails();

                foreach (Emp item in empList)
                {
                    Console.WriteLine(item.EmpNo + " " + item.EmpName + " " + item.HireDate + " " + item.Salary + " \n");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }


        //method to insert data into employee
        public void InsertIntoEmp()
        {
            try
            {
                Console.WriteLine("Insert Emp No");
                int empno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter emp name");
                string empname = Console.ReadLine();
                Console.WriteLine("Enter hire date");
                DateTime? hdate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter Salary");
                decimal? sal = decimal.Parse(Console.ReadLine());

                Emp empobj = new Emp() { EmpNo = empno, EmpName = empname, HireDate = hdate, Salary = sal };

                bool result = empDataStore.InsertInEmp(empobj);

                if (result == true)
                {
                    Console.WriteLine("Emp record inseted successfully!");
                    Console.WriteLine("-----------");
                    DisplayAll();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        //method to insert employee data using stored procedure
        public void InsertEmployee_SP()
        {
            try
            {
                Console.WriteLine("Insert Emp No");
                int empno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter emp name");
                string empname = Console.ReadLine();
                Console.WriteLine("Enter hire date");
                DateTime? hdate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter Salary");
                decimal? sal = decimal.Parse(Console.ReadLine());

                Emp empobj = new Emp() { EmpNo = empno, EmpName = empname, HireDate = hdate, Salary = sal };

                bool result = empDataStore.InsertEmployeeUsing_StoredProcedure(empobj);

                if (result == true)
                {
                    Console.WriteLine("Emp record inseted successfully!");
                    Console.WriteLine("-----------");
                    DisplayAll();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }


        //method to find employee by employee_number
        public void GetEmployeeByNumber()
        {
            try
            {
                Console.WriteLine("Enter Employee Number");
                int empnumber = int.Parse(Console.ReadLine());

                Emp employee = new Emp();
                employee = empDataStore.GetEmpByEmpNo(empnumber);

                Console.WriteLine(employee.ToString());

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




    }
}
