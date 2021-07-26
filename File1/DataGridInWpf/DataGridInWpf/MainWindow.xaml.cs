using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace DataGridInWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bindDataGrid_datagrid1();
        }

        private void bindDataGrid_datagrid1()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
               

            string sqlQuery = "select ib.issueCode, b.BookName, b.Author, ib.IssueDate, ib.DueDate, " +
                "ib.ActualReturnDate from Book as b, IssueBook as ib, " +
                "Member as m where m.MemberCode=ib.MemberCode and b.BookCode=ib.BookCode and m.MemberCode=1";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable datatable = new DataTable("Book_Issue_History");
            //da.Fill(datatable);
            //datagrid1.ItemsSource = datatable.DefaultView;
            
            
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagrid1.ItemsSource = ds.Tables;


            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }


        }
    }
}
