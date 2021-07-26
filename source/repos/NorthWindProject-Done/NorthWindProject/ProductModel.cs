using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindProject
{
    class ProductModel
    {
        public int productId { get; set; }

        public string productName { get; set; }
        public decimal unitPrice { get; set; }

       // public ObservableCollection<ProductModel> prodList = new ObservableCollection<ProductModel>();
        public ObservableCollection<ProductModel> GetProduct()
        {
            ObservableCollection<ProductModel> prodList = new ObservableCollection<ProductModel>
            {
                new ProductModel { productId=1, productName="Watch", unitPrice=50000},
                new ProductModel { productId=2, productName="ball", unitPrice=500},
                new ProductModel { productId=3, productName="bat", unitPrice=2000}

            };

            return prodList;
        }

    }
}
