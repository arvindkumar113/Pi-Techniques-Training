using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace NorthWind_Add_Delete_Cancell_Button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        NorthwindEntities db = null;
        ObservableCollection<Product> productCollection;
        public MainWindow()
        {
            InitializeComponent();
            db = new NorthwindEntities();
        }

        private void Main_Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //loading product table data from database
            productCollection = new ObservableCollection<Product>(db.Products);
            //passing data to the listbox
            lstItem.DataContext = productCollection;
        }

        private void lstItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Main_Grid.DataContext = lstItem.SelectedItem as Product;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //adding empty product in collection just in listbox
            productCollection.Add(new Product());

            //in listbox selected item should be inserted product
            lstItem.SelectedIndex = productCollection.Count + 1;

            //focus product name and set productid null
            txtBox_productId.Text = "";
            txtBox_productId.Focus();
            txtBox_UnitPrice.Text = "";
         
            btnAdd.IsEnabled = false;
            btnDelete.IsEnabled = false;
            

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtBox_productId.Text = "";
            txtBox_productName.Text = "";
            txtBox_UnitPrice.Text = "";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = lstItem.SelectedItem as Product;
                db.Products.Add(product);
                db.SaveChanges();

                MessageBox.Show("Data Saved Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure, you want to delete the record?", "Delete Product",
                MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    db.Products.Remove(lstItem.SelectedItem as Product);//remove from DbSet<Products>
                    db.SaveChanges();//remove from database
                    productCollection.Remove(lstItem.SelectedItem as Product);//remove from observable collection

                    MessageBox.Show("Deleted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
