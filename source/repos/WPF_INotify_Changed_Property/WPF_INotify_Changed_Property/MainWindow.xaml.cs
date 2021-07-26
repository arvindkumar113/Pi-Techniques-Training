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

namespace WPF_INotify_Changed_Property
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Person person = new Person { FirstName = "Arvind", LastName = "Kumar" };
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
