using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LinqDemoInWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Employee> empList;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {

            //defered execution querry

            //IEnumerable<Employee> query1 = from empobj in empList select empobj;
            //IEnumerable<Employee> query2 = from emp in empList where emp.Address =="mumbai" select emp;
            //IEnumerable<Employee> query3 = empList.Where(emp => emp.Address == "mumbai");
            //IEnumerable<Employee> query4= from emp in empList orderby emp.EmpName select emp;
            //IEnumerable<Employee> query3a = empList.Where(emp => emp.Address == "mumbai");
            //IEnumerable<Employee> query5 = from emp in empList orderby emp.Dept, emp.Address select emp;

            //IEnumerable<Employee> query5a = empList.OrderBy(emp => emp.Dept).ThenBy(emp => emp.Address);

            //for immediate execution querry be like below
            //IEnumerable<Employee> query1 = empList.ToList();

            //IEnumerable<Employee> query6 = from emp in empList where emp.EmpName == "amit" select emp;

            //Employee employee = (from emp in empList where emp.EmpName == "amit" select emp).First();
            //if record is found then returns record 
            // else return exception
            //Employee employee = (from emp in empList where emp.EmpName == "amit" select emp).FirstOrDefault();


            //for more than one record it gives exception
            //Employee employee = (from emp in empList where emp.EmpName == "amit" select emp).SingleOrDefault();

            //Employee employee = empList.SingleOrDefault(emp => emp.EmpName == "amit");

            //list all employee whose name ends with "a"
            //IEnumerable<Employee> query7 = from emp in empList where emp.EmpName.EndsWith("a") select emp;

            //list all employee whose name contains "i"
            //IEnumerable<Employee> query8 = from emp in empList where emp.EmpName.Contains("i") select emp;
            //other way is
            //empList.Where(x => x.EmpName[x.EmpName.Length - 1] == 'a');
            //empList.Where(x => x.EmpName.Contains('i'));


            //when user want to retrive data other than class data

            //var query9 = from emp in empList select new{ emp.EmpNo, emp.Dept, emp.Salary };

            //foreach(var item in query9)
            //{
            //   richTextBox1.AppendText("\n EmpNo " + item.EmpNo + "Dept No" + item.Dept + "Salary" + item.Salary);
            //}

            //var query10 = from emp in empList group emp by emp.Dept;

            //foreach(var item in query10)
            //{
            //    richTextBox1.AppendText("\n" + item.Key+"\n");

            //    foreach(var row in item)
            //    {
            //        richTextBox1.AppendText( row.ToString() + "\n");
            //    }
            //}

            //print emp who are having highest salary

            var query11 = (from emp in empList orderby emp.Salary descending select emp).Take(2);
            foreach (var item in query11)
            {
                richTextBox1.AppendText(item.ToString() + "\n");
            }

            //var query12 = from emp in empList
            //              let increment = emp.Salary * 0.1
            //              select new
            //              {
            //                  EmpName = emp.EmpName,
            //                  Salary = emp.Salary,
            //                  IncrementAmt = increment,
            //                  NetSalary = emp.Salary + increment
            //              };
            //foreach(var item in query12)
            //{
            //    richTextBox1.AppendText()
            //}

            //var querycount = (from emp in empList select emp).Count();

            //var querysum = (from emp in empList select emp).Sum(emp=>emp.Salary);


            //var queryavg = (from emp in empList select emp).Average(emp => emp.Salary);

            //department wise total salary

            //var querygroupwise = from emp in empList group emp by emp.Dept into empgroup
            //                     select new { groupname=empgroup, salsum= empgroup.Sum(emp=>emp.Salary), 
            //                     maxsalary = empgroup.Max(emp=>emp.Salary), 
            //                     minSalary = empgroup.Min(emp=>emp.Salary)};



            //Console.WriteLine("------\n employee.ToString()");

            //foreach(Employee item in query1)
            //{
            //    richTextBox1.AppendText(item + "\n");
            //}
            //richTextBox1.AppendText("--------------------\n");
            //empList.Add(new Employee() { EmpNo = 108, EmpName = "nancy", Address = "london", Dept = "hr", Salary = 25000 });

            //foreach (Employee item in query9)
            //{
            //    richTextBox1.AppendText(item + "\n");
            //}
        }

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            empList = new List<Employee>();
            empList.Add(new Employee() { EmpNo = 101, EmpName = "bhavana", Address = "mumbai", Dept = "hr", Salary = 15000 });
            empList.Add(new Employee() { EmpNo = 102, EmpName = "amit", Address = "mumbai", Dept = "sales", Salary = 25000 });
            empList.Add(new Employee() { EmpNo = 103, EmpName = "vishal", Address = "pune", Dept = "sales", Salary = 20000 });
            empList.Add(new Employee() { EmpNo = 104, EmpName = "priya", Address = "mumbai", Dept = "hr", Salary = 30000 });
            empList.Add(new Employee() { EmpNo = 105, EmpName = "asha", Address = "mumbai", Dept = "sales", Salary = 30000 });
            empList.Add(new Employee() { EmpNo = 106, EmpName = "pankaj", Address = "pune", Dept = "hr", Salary = 35000 });
            empList.Add(new Employee() { EmpNo = 107, EmpName = "anil", Address = "mumbai", Dept = "sales", Salary = 18000 });
            empList.Add(new Employee() { EmpNo = 108, EmpName = "preeti", Address = "pune", Dept = "hr", Salary = 25000 });



        }
    }
}
