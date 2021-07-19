using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_HRAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            LINQAssignmentEntities db = new LINQAssignmentEntities();
            db.Database.Log = Console.WriteLine;


            ////1.LIST ALL THE DATA FROM THE EMPLOYEE TABLE
            //IEnumerable<EMP> query1 = from employee in db.EMPs select employee;
            //foreach(var item in query1)
            //{
            //    Console.WriteLine($"{item.EMPNO} \t {item.ENAME} +\t{item.DEPTNO} \t {item.JOB}\t {item.SAL} \t{item.COMM}\t {item.HIREDATE}\t  \n\n");
            //}

            ////2.	LIST ALL THE DATA FROM THE EMPLOYEE TABLE ORDER BY JOB
            //IEnumerable<EMP> query2 = from employee in db.EMPs orderby employee.JOB select employee;
            //foreach (var item in query2)
            //{
            //    Console.WriteLine($"{item.EMPNO} \t {item.ENAME} +\t{item.DEPTNO} \t {item.JOB}\t {item.SAL} \t{item.COMM}\t {item.HIREDATE}\t  \n\n");
            //}

            ////3.LIST ALL THE DATA FROM THE EMPLOYEE TABLE WHOSE NAME START WITH S
            //IEnumerable<EMP> query3 = from employee in db.EMPs where employee.ENAME.StartsWith("S") select employee;
            //foreach (var item in query3)
            //{
            //    Console.WriteLine($"{item.EMPNO} \t {item.ENAME} +\t{item.DEPTNO} \t {item.JOB}\t {item.SAL} \t{item.COMM}\t {item.HIREDATE}\t  \n\n");
            //}

            ////4.	LIST DISTINCT JOB
            //var query4 = (from employee in db.EMPs select employee.JOB).Distinct();
            //foreach (var item in query4)
            //{
            //    Console.WriteLine(item);
            //}

            //5.FIND THE DETAILS OF ALL MANAGER(IN ANY DEPT) AND ALL CLERKS IN DEPT 10
            //var query5 = from employee in db.EMPs where employee.JOB == "mANAGER" || (employee.JOB == "clerk" && employee.DEPTNO == 10) select employee;
            //foreach (var item in query5)
            //{
            //    Console.WriteLine($"{item.EMPNO} \t {item.ENAME} +\t{item.DEPTNO} \t {item.JOB}\t {item.SAL} \t{item.COMM}\t {item.HIREDATE}\t  \n\n");
            //}

            //6.FIND THE EMPLOYEES WHO DO NOT RECEIVE A COMMISSION
            //var query6 = from employee in db.EMPs where employee.COMM == 0 || employee.COMM == null select employee;
            //foreach (var item in query6)
            //{
            //    Console.WriteLine($"{item.EMPNO} \t {item.ENAME} +\t{item.DEPTNO} \t {item.JOB}\t {item.SAL} \t{item.COMM}\t {item.HIREDATE}\t  \n\n");
            //}

            //7.FIND ALL EMPLOYEES WHOSE NET EARNINGS(SAL + COMM) IS GREATER THAN RS. 2000
            //var query7 = from employee in db.EMPs where (employee.SAL) + (employee.COMM == DBNull.Value ? 0 : employee.COMM) > 2000 select employee;
            //foreach (var item in query7)
            //{
            //    Console.WriteLine($"{item.EMPNO} \t {item.ENAME} +\t{item.DEPTNO} \t {item.JOB}\t {item.SAL} \t{item.COMM}\t {item.HIREDATE}\t  \n\n");
            //}

            ////8.FIND ALL EMPLOYEE HIRED IN MONTH OF FEBUARY (OF ANY YEAR)
            //var query8 = from employee in db.EMPs where employee.HIREDATE.Value.Month == 2 select employee;
            //foreach (var item in query8)
            //{
            //    Console.WriteLine($"{item.EMPNO} \t {item.ENAME} +\t{item.DEPTNO} \t {item.JOB}\t {item.SAL} \t{item.COMM}\t {item.HIREDATE}\t  \n\n");
            //}

            //9.LIST TOTAL SALARY FOR THE ORGANIZATION
            //var totalsalry = (from employee in db.EMPs select employee.SAL).Sum();
            //Console.WriteLine($"Total Salary = {totalsalry}");

            //10.LIST TOTAL EMPLOYEES WORKS IN EACH DEPARTMENT
            //var query10 = from employee in db.EMPs
            //              group employee by employee.DEPTNO into e1
            //              select new
            //              { e1.Key, Count = e1.Count() };
            //foreach (var item in query10)
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Count + "\n");
            //}

            //11.LIST FIRST THREE HIGHEST PAID EMPLOYEES
            //var query11 = (from employee in db.EMPs
            //               orderby employee.SAL descending
            //               select employee).Take(3);
            //foreach (var item in query11)
            //{
            //    Console.WriteLine($"{item.EMPNO} \t {item.ENAME} +\t{item.DEPTNO} \t {item.JOB}\t {item.SAL} \t{item.COMM}\t {item.HIREDATE}\t  \n\n");
            //}

            //            12.DISPLAY THE NAMES, JOB AND SALARY OF ALL EMPLOYEES, SORTED ON  DESCENDING ORDER OF JOB AND WITHIN JOB, SORTED ON THE DESCENDING ORDER OF SALARY
            //          var query12wrong = from employee in db.EMPs
            //                             orderby employee.JOB descending
            //                             orderby
            //employee.SAL descending
            //                             select employee;
            //            var query12 = from employee in db.EMPs
            //                          orderby employee.JOB descending
            //                          ,
            //                         employee.SAL descending
            //                          select employee;

            //            foreach (var item in query12)
            //            {
            //                Console.WriteLine($"{item.EMPNO} \t {item.ENAME} +\t{item.DEPTNO} \t {item.JOB}\t {item.SAL} \t{item.COMM}\t {item.HIREDATE}\t  \n\n");
            //            }

            // 13.LIST DEPARTMENT NAME, EMPLOYEE NAME AND JOB
            //var query13 = from employee in db.EMPs
            //              join department in db.DEPTs
            //              on employee.DEPTNO equals department.DEPTNO
            //              select new
            //              {
            //                  department.DNAME,
            //                  employee.ENAME,
            //                  employee.JOB
            //              };
            // foreach (var item in query13)
            // {
            //     Console.WriteLine(item.DNAME + "\t" + item.ENAME + "\t" + item.JOB + "\n");
            // }

            // 14.LIST DEPARTMENT NAME AND MAX SALARY FOR EACH DEPARTMENT
            //aman solution
            //var joinquery2 = from emp in db.EMPs
            //                     join dep in db.DEPTs
            //                 on emp.DEPTNO equals dep.DEPTNO
            //                     group emp by dep.DNAME into depgrp
            //                     select new { grpnme = depgrp.Key, maxsal = depgrp.Max() };
                                  //    foreach (var item in joinquery2)
                                 //    {
                                 //        Console.WriteLine(item.grpnme + " " + item.maxsal);
                                 //    }
            var query14 = from e in db.EMPs
                          group e by e.DEPTNO into dptgrp
                          let topsal = dptgrp.Max(x => x.SAL)
                          select new
                          {
                              Dept = dptgrp.Key,
                              TopSal = dptgrp.First(y => y.SAL == topsal).EMPNO
                          };

            var query = from department in db.DEPTs

            
            foreach (var item in query14)
            {
                Console.WriteLine(item.Dept + "\t" + item.TopSal + "\n");
            }

            //           15.LIST DEPARTMENT NAME AND TOTAL EMPLOYEE WORKING IN EACH DEPARTMENT ALSO INCLUDE DEPARTMENT WHERE NO EMPLOYEES ARE WORKING
            //           var query15 = from department in db.DEPTs
            //                         join employee in db.EMPs
            //on department.DEPTNO equals employee.DEPTNO
            //                         orderby department.DNAME
            //                         select new { department.DNAME, employee.ENAME, employee.JOB, employee.SAL };
            //           foreach (var item in query15)
            //           {
            //               Console.WriteLine(item.DNAME + "\t" + item.ENAME + "\t" + item.JOB + "\t" + item.SAL + "\n");
            //           }

            //16.SELECT Dept Name FROM Department TABLE
            // WHILE DISPLAYING DATA ALSO DISPLAY Emp Name BASED ON Department
            //var query16= from department in db.DEPTs join



            // 17.INSERT NEW DEPARTMENT AND EMPLOYEE FOR THAT DEPARTMENT
            //DEPTNO = 50, DEPTNAME = IT
            //  EMPNO = 1001, EMPNAME = RAHUL
            //  EMP employee = new EMP()
            //  {
            //      EMPNO = 1001,
            //      ENAME = "RAHUL"
            //  };

            // DEPT department = new DEPT()
            // {
            //     DEPTNO = 50,
            //     DNAME = "IT"
            // };
            // db.EMPs.Add(employee);
            // db.DEPTs.Add(department);
            // try
            // {
            //     db.SaveChanges();
            // }
            // catch (Exception)
            // {
            //     throw;
            // }


            ////18.	UPDATE Rahul RECORD WITH SAL = 20000
            //var query18 = from employee in db.EMPs where employee.ENAME == "Rahul" select employee;
            //foreach (EMP emp in query18)
            //{
            //    emp.SAL = 20000;
            //}
            //try
            //{
            //    db.SaveChanges();
            //}
            //catch (Exception)
            //{
            //    throw;
            //}


            ////19.	Delete Record of Rahul
            //var query19 = from employee in db.EMPs where employee.ENAME == "Rahul" select employee;
            //foreach(var item in query19)
            //{
            //    db.EMPs.Remove(item);
            //}
            //try
            //{
            //    db.SaveChanges();
            //}
            //catch(Exception)
            //{
            //    throw;
            //}

            ////20.Write a stored procedure in SQL Server name it as JobWiseDetails which takes
            ////Job as in parameter and return Total Employee, Max Salary and Min Salary for the Job
            //var query20 = db.JobWiseDetails("Manager");
            //Console.WriteLine("Total employee =" + query20.First() + "\t Max Salary = " + query20.Second() + "\t Min alary = " + query20.Third()+"\n");

            Console.ReadLine();
        }
    }
}
