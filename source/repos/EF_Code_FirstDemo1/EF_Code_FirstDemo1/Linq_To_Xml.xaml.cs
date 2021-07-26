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
using System.Xml.Linq;

namespace EF_Code_FirstDemo1
{
    /// <summary>
    /// Interaction logic for Linq_To_Xml.xaml
    /// </summary>
    public partial class Linq_To_Xml : Window
    {
        public Linq_To_Xml()
        {
            InitializeComponent();
        }

        private void Main_Grid_Loaded(object sender, RoutedEventArgs e)
        {
            XDocument document = XDocument.Load(@"");

            var querydata = from x in document.Descendants("product")
                            select new Product
                            {
                                ProductID = (int)x.Attribute("ProductID"),
                                ProductName = (string)x.Attribute("ProductName"),
                                Unitprice = (double)x.Attribute("UnitPrice")
                            };
        }
    }
}
