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
using WpfApp_SOAPService.ProductServiceReference;

namespace WpfApp_SOAPService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductServiceClient proxyObject = new ProductServiceClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void MainPanel_Loaded(object sender, RoutedEventArgs e)
        {
            dgproduct.DataContext = proxyObject.GetAllProduts();
        }

        private void product_Click(object sender, RoutedEventArgs e)
        {
            datapanel.DataContext = proxyObject.GetProductById(Convert.ToInt32(txtpid.Text));
            //ProductID = product.ProductID;
        }
    }
}
