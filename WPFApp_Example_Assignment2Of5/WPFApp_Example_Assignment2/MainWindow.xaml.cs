using System;
using System.Collections.Generic;
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

namespace WPFApp_Example_Assignment2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NorthwindEntities db = null ;
        //SqlConnection connection;

        public MainWindow()
        {
            InitializeComponent();
            db = new NorthwindEntities();

        }

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from order in db.Orders
                           join customer in db.Customers on order.CustomerID equals customer.CustomerID
                           select new { order.OrderID, customer.CompanyName, order.OrderDate,order.ShippedDate,
                               order.Freight};

            //var query = from order in db.Orders select order;
            //dataGrid1.ItemsSource = query.ToList();

            lstItem.DataContext = query.ToList();


        }

        private void dataGrid1_MouseMove(object sender, MouseEventArgs e)
        {
            

        }
    }
}
