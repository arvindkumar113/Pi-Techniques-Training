using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DBLibrary;

namespace DatabaseApp
{
    public class EMPCRUDemo
    {
        EmpDataStore empDataStore=null;

        public EMPCRUDemo()
        {
            empDataStore = new EmpDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        void InsertEmpData()
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
                decimal? sal = Convert.ToInt64(Console.ReadLine());

                Emp empobj = new Emp() { EmpNo=empno, EmpName=empname, HireDate=hdate, Salary=sal};

                int count = empDataStore.InsertInEmp(empobj);

                if(count==1)
                {
                    Console.WriteLine("Emp record inseted successfully!");
                    Console.WriteLine("-----------");
                    DisplayAllEmps();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }

        void DisplayAllEmps()
        {
            
                List<Emp> empList = empDataStore.GetEmpsDetails();

                foreach(Emp item in empList)
                {
                    Console.WriteLine(item);
                }


            
            
        }


        void DisplayEmpByNo()
        {

        }

        static void Main(string[] args)
        {

            EMPCRUDemo empcrudemo = new EMPCRUDemo();
            Console.WriteLine("-----------All Employee Details");
            empcrudemo.DisplayAllEmps();

            Console.WriteLine("----Get Emp by EmpNo");
            empcrudemo.DisplayEmpByNo();

            Console.WriteLine("--------Insert Employee---------");
            empcrudemo.InsertEmpData();

            Console.ReadLine();

        }
    }
}
