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
using System.Windows.Shapes;

namespace WpfAppDemo
{
    /// <summary>
    /// Interaction logic for DBNorthWind.xaml
    /// </summary>
    public partial class DBNorthWind : Window
    {
        NorthwindEntities db = null;
        ObservableCollection<Product> productCollection;
        public DBNorthWind()
        {   
            InitializeComponent();
            db = new NorthwindEntities();
            //productCollection = new ObservableCollection<Product>();
        }

        private void lstItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainGrid.DataContext = lstItems.SelectedItem as Product;
        }

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            //MainGrid.DataContext = lstItems.SelectedItem as Product;
            //loading all data from database into observable colection
            productCollection = new ObservableCollection<Product>(db.Products);
            //passing Product table data to listbox
            lstItems.DataContext = productCollection;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            //Product product = lstItems.SelectedItem as Product;
            Product product = lstItems.SelectedItem as Product;
            productCollection.Remove(product);
            btnAdd.IsEnabled = true;
            btnEdit.IsEnabled = true;
            btnDelete.IsEnabled = true;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //add empty record in observable collection
            productCollection.Add(new Product());

            //make that record as an active collection
            lstItems.SelectedIndex = productCollection.Count - 1;

            //focus productname and set productid =0
            Prodid.Text = "0";
            Prodname.Focus();

            btnAdd.IsEnabled = false;
            btnDelete.IsEnabled = false;
            btnEdit.IsEnabled = false;

        }

        

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Product product = lstItems.SelectedItem as Product;
            db.Products.Add(product);
            db.SaveChanges();

            MessageBox.Show("Inserted Successfully");
            btnAdd.IsEnabled = false;
            btnDelete.IsEnabled = true;
            btnEdit.IsEnabled = true;

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure, you want to delete the record?", "Delete Product",
                MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);

            if(result==MessageBoxResult.Yes)
            {
                try
                {
                    db.Products.Remove(lstItems.SelectedItem as Product);//remove from DbSet<Products>
                    db.SaveChanges();//remove from database
                    productCollection.Remove(lstItems.SelectedItem as Product);//remove from observable collection

                    MessageBox.Show("Deleted Successfully");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }
    }
}
