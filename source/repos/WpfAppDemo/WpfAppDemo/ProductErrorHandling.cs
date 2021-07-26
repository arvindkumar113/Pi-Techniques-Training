using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfAppDemo
{
    public partial class Product : IDataErrorInfo
    {
        //public string this[string columnName] => throw new NotImplementedException();
        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;
                if (columnName == "ProductName")
                {
                    if (this.ProductName == "")
                        result = "Product name can not be empty";
                }
                return result;
            }

        }

        public string Error => throw new NotImplementedException();
        
        //public string Error
        //{
        //    get { return null};
        //}
    }
}
