using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignment
{
    class Program
    {

        static void Main(string[] args)
        {

            //Employee emp = new Employee("Arvind", "Darbhanga");
            //Console.WriteLine("Employee name is : " + emp.name + " and address is : " + emp.address);


            //ConfirmEmp emp = new ConfirmEmp("Arvind", "Developer", 22500, "Developer");
            //Console.WriteLine("Name : " + emp.name + " Address : " + emp.address + " Designation : " +
            //    emp.designation + "Salary : " + emp.CalculateSal() + " Employee number is : " + ConfirmEmp.EmpNumber());


            //ConfirmEmp emp1 = new ConfirmEmp("Arvind", "Developer", 22500, "Developer");
            //Console.WriteLine("Name : " + emp1.name + " Address : " + emp1.address + " Designation : " +
            ////    emp1.designation + "Salary : " + emp1.CalculateSal() + " Employee number is : " + ConfirmEmp.EmpNumber());



            ////Trainee tr = new Trainee("Arvind", "Darbhanga", 60, 750);
            ////Console.WriteLine(" Trainee Name : " + tr.name + " Address : " + tr.address + " Salary : " + tr.CalculateSal()+" Employee Number : "+Trainee.EmpNumber());


            Nullable<int> runtillzero = 1;

            while (runtillzero != 0)
            {
                Console.WriteLine("-----  Menu ----");
                Console.WriteLine("Enter 0 to exit from App");
                Console.WriteLine("Enter 1 to display all employe");
                Console.WriteLine("Enter 2 to Insert Confirmed Employee");
                Console.WriteLine("Enter 3 to Insert Trainee");
                Console.WriteLine("Enter 4 to Delete Employee");
                Console.WriteLine("Enter 5 to display Employee by number");
                runtillzero = int.Parse(Console.ReadLine());

                List<ConfirmEmp> empList = new List<ConfirmEmp>();
                List<Trainee> traineeList = new List<Trainee>();

                //create only employee class list


                switch (runtillzero)
                {
                    case 1:
                        {
                            for (int index = 0; index < empList.Count; index++)
                            {
                                Console.WriteLine(" Name : " + empList[index].name + " Address : " + empList[index].address +
                                    " Designation : " + empList[index].designation + " Salary : " + empList[index].CalculateSal());
                            }
                            for (int index = 0; index < traineeList.Count; index++)
                            {
                                Console.WriteLine(" Name : " + traineeList[index].name + "Address : " + traineeList[index].address +
                                    "Salary : " + traineeList[index].CalculateSal());
                            }

                            break;
                        };
                    case 2:
                        {
                            Console.WriteLine("Enter name of Confirm Employee");
                            string nam = Console.ReadLine();
                            Console.WriteLine("Enter address of Confirm employee");
                            string add = Console.ReadLine();
                            Console.WriteLine("Enter designation of employee");
                            string des = Console.ReadLine();
                            Console.WriteLine("Enter the basic salary");
                            double basicPay = double.Parse(Console.ReadLine());

                            if (basicPay < 5000)
                            {
                                //it should be implemented in the class only
                                throw new BasicSalaryException("Basic salary can't be less than 5000");
                            }
                            else
                            {
                                empList.Add(new ConfirmEmp { name = nam, address = add, designation = des, basic = basicPay });
                            }

                            break;
                        }
                    case 3:
                        {

                            break;
                        };
                    case 4:
                        {



                            break;
                        };
                    case 5:
                        {


                            break;
                        };
                    default:
                        {
                            Console.WriteLine("Exit Successful");
                            break;
                        }
                }



            }


            Console.ReadLine();
        }
    }
}
