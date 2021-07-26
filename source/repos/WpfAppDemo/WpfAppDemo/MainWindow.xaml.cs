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
using System.Collections;
using System.Collections.ObjectModel;
namespace WpfAppDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> personList;

        //ObservableCollection<Person> personList;

        public MainWindow()
        {
            InitializeComponent();

            personList = new ObservableCollection<Person>();

            personList.Add(new Person { FirstName = "Bhavana", LastName = "Desai", City = "Mumbai" });
            personList.Add(new Person { FirstName = "Arvind", LastName = "Kumar", City = "Madhubani" });

            lstName.DataContext = personList;
            lblCount.Content = "Total person in the list is = " + personList.Count;

        }

       

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            personList.Add(new Person { FirstName = txtFName.Text, LastName = txtLName.Text, City = txtCName.Text });


            txtFName.Text = string.Empty;
            txtCName.Text = string.Empty;
            txtLName.Text = string.Empty;

            lblCount.Content = "Total products in the list = " + personList.Count;
        }
    }
}
