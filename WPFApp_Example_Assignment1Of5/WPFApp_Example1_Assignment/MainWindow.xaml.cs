using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
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

namespace WPFApp_Example1_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NorthwindEntities db = new NorthwindEntities();
        //ObservableCollection<Employee> employeeCollection;

        SqlConnection connection;

        public MainWindow()
        {
            InitializeComponent();
            //db = new NorthwindEntities();

            //connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database = NorthWind; integrated security = true;");
            //try
            //{
            //    if (connection.State == ConnectionState.Closed)
            //        connection.Open();
            //}
            //catch(Exception)
            //{
            //    throw;
            //}


        }

        private void btn_Mr_Click(object sender, RoutedEventArgs e)
        {
            //SqlDataAdapter da = null;
            //DataSet ds = null;
            //try
            //{
            //    da = new SqlDataAdapter("select * from Employee where TitleOfCourtesy = 'Mr.'", connection);
            //    //da.SelectCommand.CommandTimeout = 100000;
            //    ds = new DataSet();
            //    da.Fill(ds);
            //    dataGrid1.ItemsSource = ds.Tables[0].DefaultView;
            //}
            //catch (SqlException)
            //{
            //    throw;
            //}
            //finally
            //{
            //    if (connection.State == ConnectionState.Open)
            //        connection.Close();
            //}
            var query1 = from employee in db.Employees where employee.TitleOfCourtesy == "Mr." select employee;
            dataGrid1.ItemsSource = query1.ToList();

        }

        private void btn_Mrs_Click(object sender, RoutedEventArgs e)
        {
            dataGrid1.ItemsSource = null;
            var query1 = from employee in db.Employees where employee.TitleOfCourtesy == "Mrs." select employee;
            dataGrid1.ItemsSource = query1.ToList();

        }

        private void btn_Dr_Click(object sender, RoutedEventArgs e)
        {
            dataGrid1.ItemsSource = null;
            var query1 = from employee in db.Employees where employee.TitleOfCourtesy == "Dr." select employee;
            dataGrid1.ItemsSource = query1.ToList();

        }


        private void btn_Miss_Click(object sender, RoutedEventArgs e)
        {
            dataGrid1.ItemsSource = null;
            var query1 = from employee in db.Employees where employee.TitleOfCourtesy == "Ms." select employee;
            dataGrid1.ItemsSource = query1.ToList();

        }

        private void btn_All_Click(object sender, RoutedEventArgs e)
        {
            dataGrid1.ItemsSource = null;
            var query1 = from employee in db.Employees select employee;
            dataGrid1.ItemsSource = query1.ToList();
        }
    }
}
