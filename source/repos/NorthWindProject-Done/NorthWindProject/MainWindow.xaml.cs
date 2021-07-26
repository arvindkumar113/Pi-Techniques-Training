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

namespace NorthWindProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NorthwindEntities db = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        //public ObservableCollection<ProductModel> prodList = GetProduct();
        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            ProductModel product = new ProductModel();
            lstItems.DataContext = product.GetProduct();
        }

        private void lstItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(lstItems.SelectedIndex.ToString)
            MainGrid.DataContext = lstItems.SelectedItem as ProductModel;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
