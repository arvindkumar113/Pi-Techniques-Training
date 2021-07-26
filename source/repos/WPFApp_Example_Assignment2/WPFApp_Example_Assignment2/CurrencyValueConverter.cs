using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFApp_Example_Assignment2
{
    public partial class CurrencyValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ////throw new NotImplementedException();
            //if (value != null)
            //{
            //    DateTime test = (DateTime)value;
            //    string date = test.ToString("dd/mm/yyyy");
            //    return (date);
            //}
            //return string.Empty;
            decimal d = 0;
            if (value != null)
            {
                d = (decimal)value;
            }
            return d.ToString(parameter as string, culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
