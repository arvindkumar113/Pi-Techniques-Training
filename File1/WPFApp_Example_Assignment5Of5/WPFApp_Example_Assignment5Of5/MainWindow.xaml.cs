using System;
using System.Collections.Generic;
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

namespace WPFApp_Example_Assignment5Of5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void treeDB_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem selectedTable = (TreeViewItem)treeDB.SelectedItem;
            string tableName = selectedTable.Header.ToString();
            SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; database=Northwind; integrated security=true;");
            string sql = "select * from " + tableName;

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, tableName);
            //table.DataContext = ds.Tables[tableName];
            treeDB.DataContext = ds.Tables[tableName];

        }
    }
}
