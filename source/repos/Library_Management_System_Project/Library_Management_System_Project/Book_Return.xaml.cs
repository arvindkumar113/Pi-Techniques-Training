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
    /// Interaction logic for Book_Return.xaml
    /// </summary>
    public partial class Book_Return : Window
    {
        public Book_Return()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            txtBox_IssueCode.Clear();
            txtBox_BookCode.Clear();
            txtBlockBookName.Text = "";
            txtBlockMemberCode.Text = "";
            txtBlockMemberName.Text = "";
            txtBlockIssueDate.Text = "";
            txtBlockDueDate.Text = "";
            datePickerReturnedDate.SelectedDate = null;
        }
    }
}
