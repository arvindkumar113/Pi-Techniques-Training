using Library_Management_System_Project;
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
using System.Windows.Shapes;

namespace Library_Management
{
    /// <summary>
    /// Interaction logic for Issue_window.xaml
    /// </summary>
    public partial class Issue_window : Window
    {
        //Library_Management_System_ProjectEntities 
        Library_Management_SystemEntities db;

            public Issue_window()
        {
            InitializeComponent();
            db = new Library_Management_SystemEntities();
        }



        private void btn_Issue_Click(object sender, RoutedEventArgs e)
        {
            IssueBook book = new IssueBook();
            book.MemberCode = int.Parse(txtBox_MemberCode.Text);
            book.BookCode = int.Parse(txtBox_BookCode.Text);
            //book.IssueDate = issueDatePicker.
            book.IssueDate = Convert.ToDateTime(issueDatePicker);
            book.DueDate = Convert.ToDateTime(dueDatePicker);
            //book.DueDate = Convert.ToDateTime(issueDatePicker).AddDays(7);
            book.ActualReturnDate = null;

            try
            {
                db.IssueBooks.Add(book);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            txtBox_MemberCode.Clear();
            txtBlock_MemberName.Text = "";
            txtBlock_MemberType.Text = "";
            txtBlock_BookAllowed.Text = "";
            txtBlock_BookIssued.Text = "";
            txtBox_BookCode.Clear();
            txtBlock_AuthorName.Text = "";
            issueDatePicker.SelectedDate = null;
            dueDatePicker.SelectedDate = null;
            //txtBlock_IssudeDate.Text="";
            //txtBlock_DueDate.Text = "";

        }

        private void MainGrid2_Loaded(object sender, RoutedEventArgs e)
        {
            var bookIssueQuery = (from issue in db.IssueBooks
                                 join b in db.Books on issue.BookCode equals b.BookCode
                                 join m in db.Members on issue.MemberCode equals m.MemberCode
                                 select new { b.BookName, b.Author, m.MemberName, issue.IssueDate, issue.DueDate }).ToList();

            listOfIssuedBook.DataContext = bookIssueQuery.ToList();
        }
    }
}
