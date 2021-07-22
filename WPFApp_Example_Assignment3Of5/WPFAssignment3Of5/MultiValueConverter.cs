using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFAssignment3Of5
{
    class MultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();
            if (values != null)
            {
                decimal netStock1 = (decimal)values[0];
                decimal netStock2 = (decimal)values[1];
                decimal netStock = netStock1 * netStock2;
                //return netStock.ToString(parameter as string, culture);
                return ((decimal)values[0] * (decimal)values[1]).ToString();
                //return values[0].ToString() + " " + values[1].ToString();
            }
            else
                return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
